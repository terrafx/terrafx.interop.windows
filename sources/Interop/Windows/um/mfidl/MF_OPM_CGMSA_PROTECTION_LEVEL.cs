// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MF_OPM_CGMSA_PROTECTION_LEVEL
    {
        MF_OPM_CGMSA_OFF = 0,
        MF_OPM_CGMSA_COPY_FREELY = 0x1,
        MF_OPM_CGMSA_COPY_NO_MORE = 0x2,
        MF_OPM_CGMSA_COPY_ONE_GENERATION = 0x3,
        MF_OPM_CGMSA_COPY_NEVER = 0x4,
        MF_OPM_CGMSA_REDISTRIBUTION_CONTROL_REQUIRED = 0x8,
    }
}
