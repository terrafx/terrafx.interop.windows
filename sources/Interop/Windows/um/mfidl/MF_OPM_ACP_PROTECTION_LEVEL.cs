// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MF_OPM_ACP_PROTECTION_LEVEL
    {
        MF_OPM_ACP_OFF = 0,
        MF_OPM_ACP_LEVEL_ONE = 1,
        MF_OPM_ACP_LEVEL_TWO = 2,
        MF_OPM_ACP_LEVEL_THREE = 3,
        MF_OPM_ACP_FORCE_ULONG = 0x7fffffff,
    }
}
