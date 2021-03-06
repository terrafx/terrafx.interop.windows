// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SPC_SP_AGENCY_INFO
    {
        [NativeTypeName("struct SPC_LINK_ *")]
        public SPC_LINK* pPolicyInformation;

        [NativeTypeName("LPWSTR")]
        public ushort* pwszPolicyDisplayText;

        [NativeTypeName("PSPC_IMAGE")]
        public SPC_IMAGE* pLogoImage;

        [NativeTypeName("struct SPC_LINK_ *")]
        public SPC_LINK* pLogoLink;
    }
}
