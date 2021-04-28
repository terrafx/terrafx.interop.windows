// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tbs.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct TPM_WNF_PROVISIONING
    {
        [NativeTypeName("UINT32")]
        public uint status;

        [NativeTypeName("BYTE [28]")]
        public fixed byte message[28];
    }
}
