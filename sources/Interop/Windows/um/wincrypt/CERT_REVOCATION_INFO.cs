// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CERT_REVOCATION_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwRevocationResult;

        [NativeTypeName("LPCSTR")]
        public sbyte* pszRevocationOid;

        [NativeTypeName("LPVOID")]
        public void* pvOidSpecificInfo;

        [NativeTypeName("BOOL")]
        public int fHasFreshnessTime;

        [NativeTypeName("DWORD")]
        public uint dwFreshnessTime;

        [NativeTypeName("PCERT_REVOCATION_CRL_INFO")]
        public CERT_REVOCATION_CRL_INFO* pCrlInfo;
    }
}
