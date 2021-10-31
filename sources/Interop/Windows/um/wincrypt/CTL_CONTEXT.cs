// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CTL_CONTEXT
    {
        [NativeTypeName("DWORD")]
        public uint dwMsgAndCertEncodingType;

        public byte* pbCtlEncoded;

        [NativeTypeName("DWORD")]
        public uint cbCtlEncoded;

        [NativeTypeName("PCTL_INFO")]
        public CTL_INFO* pCtlInfo;

        public HCERTSTORE hCertStore;

        public HCRYPTMSG hCryptMsg;

        public byte* pbCtlContent;

        [NativeTypeName("DWORD")]
        public uint cbCtlContent;
    }
}
