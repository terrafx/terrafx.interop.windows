// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct OCSP_BASIC_RESPONSE_ENTRY
    {
        public OCSP_CERT_ID CertId;

        [NativeTypeName("DWORD")]
        public uint dwCertStatus;

        [NativeTypeName("_OCSP_BASIC_RESPONSE_ENTRY::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.18362.0/um/wincrypt.h:5682:5)")]
        public _Anonymous_e__Union Anonymous;

        public FILETIME ThisUpdate;

        public FILETIME NextUpdate;

        [NativeTypeName("DWORD")]
        public uint cExtension;

        [NativeTypeName("PCERT_EXTENSION")]
        public CERT_EXTENSION* rgExtension;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("POCSP_BASIC_REVOKED_INFO")]
            public OCSP_BASIC_REVOKED_INFO* pRevokedInfo;
        }
    }
}
