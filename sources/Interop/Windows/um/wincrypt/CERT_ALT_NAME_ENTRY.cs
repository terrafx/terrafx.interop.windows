// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct CERT_ALT_NAME_ENTRY
    {
        [NativeTypeName("DWORD")]
        public uint dwAltNameChoice;

        [NativeTypeName("_CERT_ALT_NAME_ENTRY::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wincrypt.h:3957:5)")]
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("PCERT_OTHER_NAME")]
            public CERT_OTHER_NAME* pOtherName;

            [FieldOffset(0)]
            [NativeTypeName("LPWSTR")]
            public ushort* pwszRfc822Name;

            [FieldOffset(0)]
            [NativeTypeName("LPWSTR")]
            public ushort* pwszDNSName;

            [FieldOffset(0)]
            [NativeTypeName("CERT_NAME_BLOB")]
            public CRYPTOAPI_BLOB DirectoryName;

            [FieldOffset(0)]
            [NativeTypeName("LPWSTR")]
            public ushort* pwszURL;

            [FieldOffset(0)]
            [NativeTypeName("CRYPT_DATA_BLOB")]
            public CRYPTOAPI_BLOB IPAddress;

            [FieldOffset(0)]
            [NativeTypeName("LPSTR")]
            public sbyte* pszRegisteredID;
        }
    }
}
