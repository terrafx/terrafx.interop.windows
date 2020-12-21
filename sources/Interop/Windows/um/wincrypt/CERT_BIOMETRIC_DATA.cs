// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_BIOMETRIC_DATA
    {
        [NativeTypeName("DWORD")]
        public uint dwTypeOfBiometricDataChoice;

        [NativeTypeName("_CERT_BIOMETRIC_DATA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wincrypt.h:5553:5)")]
        public _Anonymous_e__Union Anonymous;

        public unsafe ref uint dwPredefined
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
#if !NETSTANDARD2_0
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.dwPredefined, 1));
#else
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->dwPredefined;
#endif
            }
        }

        public unsafe ref sbyte* pszObjId
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref ((_Anonymous_e__Union*)Unsafe.AsPointer(ref Anonymous))->pszObjId;
            }
        }

        public CERT_HASHED_URL HashedUrl;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwPredefined;

            [FieldOffset(0)]
            [NativeTypeName("LPSTR")]
            public sbyte* pszObjId;
        }
    }
}
