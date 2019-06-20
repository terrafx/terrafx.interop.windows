// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\oaidl.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [Unmanaged]
    public unsafe struct EXCEPINFO
    {
        #region Fields
        [NativeTypeName("WORD")]
        public ushort wCode;

        [NativeTypeName("WORD")]
        public ushort wReserved;

        [NativeTypeName("BSTR")]
        public char* bstrSource;

        [NativeTypeName("BSTR")]
        public char* bstrDescription;

        [NativeTypeName("BSTR")]
        public char* bstrHelpFile;

        [NativeTypeName("DWORD")]
        public uint dwHelpContext;

        [NativeTypeName("PVOID")]
        public void* pvReserved;

        [NativeTypeName("pfnDeferredFillIn")]
        public IntPtr pfnDeferredFillIn;

        [NativeTypeName("SCODE")]
        public int scode;
        #endregion
    }
}
