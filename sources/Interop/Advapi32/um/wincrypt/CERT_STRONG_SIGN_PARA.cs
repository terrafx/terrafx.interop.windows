// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct CERT_STRONG_SIGN_PARA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwInfoChoice;

        [NativeTypeName("_CERT_STRONG_SIGN_PARA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/wincrypt.h:6533:5)")]
        public _Anonymous_e__Union Anonymous

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("void *")]
            public void* pvInfo;

            [FieldOffset(0)]
            [NativeTypeName("PCERT_STRONG_SIGN_SERIALIZED_INFO")]
            public CERT_STRONG_SIGN_SERIALIZED_INFO* pSerializedInfo;

            [FieldOffset(0)]
            [NativeTypeName("LPSTR")]
            public sbyte* pszOID;
        }
    }
}
