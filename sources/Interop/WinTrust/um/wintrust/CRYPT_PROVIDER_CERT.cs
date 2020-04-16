// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_PROVIDER_CERT
    {
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        [NativeTypeName("PCCERT_CONTEXT")]
        public _CERT_CONTEXT* pCert;

        [NativeTypeName("BOOL")]
        public int fCommercial;

        [NativeTypeName("BOOL")]
        public int fTrustedRoot;

        [NativeTypeName("BOOL")]
        public int fSelfSigned;

        [NativeTypeName("BOOL")]
        public int fTestCert;

        [NativeTypeName("DWORD")]
        public uint dwRevokedReason;

        [NativeTypeName("DWORD")]
        public uint dwConfidence;

        [NativeTypeName("DWORD")]
        public uint dwError;

        [NativeTypeName("CTL_CONTEXT *")]
        public _CTL_CONTEXT* pTrustListContext;

        [NativeTypeName("BOOL")]
        public int fTrustListSignerCert;

        [NativeTypeName("PCCTL_CONTEXT")]
        public _CTL_CONTEXT* pCtlContext;

        [NativeTypeName("DWORD")]
        public uint dwCtlError;

        [NativeTypeName("BOOL")]
        public int fIsCyclic;

        [NativeTypeName("PCERT_CHAIN_ELEMENT")]
        public _CERT_CHAIN_ELEMENT* pChainElement;
    }
}
