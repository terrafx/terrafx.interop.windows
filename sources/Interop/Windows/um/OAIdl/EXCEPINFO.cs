// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop
{
    public unsafe partial struct EXCEPINFO
    {
        [NativeTypeName("WORD")]
        public ushort wCode;

        [NativeTypeName("WORD")]
        public ushort wReserved;

        [NativeTypeName("BSTR")]
        public ushort* bstrSource;

        [NativeTypeName("BSTR")]
        public ushort* bstrDescription;

        [NativeTypeName("BSTR")]
        public ushort* bstrHelpFile;

        [NativeTypeName("DWORD")]
        public uint dwHelpContext;

        [NativeTypeName("PVOID")]
        public void* pvReserved;

        [NativeTypeName("HRESULT (*)(struct tagEXCEPINFO *) __attribute__((stdcall))")]
#if !NETSTANDARD2_0
        public delegate* unmanaged<EXCEPINFO*, int> pfnDeferredFillIn;
#else
        public void* _pfnDeferredFillIn;

        public delegate* unmanaged[Stdcall]<EXCEPINFO*, int> pfnDeferredFillIn
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (delegate* unmanaged[Stdcall]<EXCEPINFO*, int>)_pfnDeferredFillIn;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _pfnDeferredFillIn = value;
            }
        }
#endif

        [NativeTypeName("SCODE")]
        public int scode;
    }
}
