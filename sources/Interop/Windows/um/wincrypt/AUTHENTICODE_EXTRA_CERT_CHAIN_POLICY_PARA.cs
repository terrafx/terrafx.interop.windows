// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct AUTHENTICODE_EXTRA_CERT_CHAIN_POLICY_PARA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwRegPolicySettings;

        [NativeTypeName("PCMSG_SIGNER_INFO")]
        public CMSG_SIGNER_INFO* pSignerInfo;
    }
}
