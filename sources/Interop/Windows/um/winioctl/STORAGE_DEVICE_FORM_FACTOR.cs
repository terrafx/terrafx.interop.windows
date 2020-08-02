// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum STORAGE_DEVICE_FORM_FACTOR
    {
        FormFactorUnknown = 0,
        FormFactor3_5,
        FormFactor2_5,
        FormFactor1_8,
        FormFactor1_8Less,
        FormFactorEmbedded,
        FormFactorMemoryCard,
        FormFactormSata,
        FormFactorM_2,
        FormFactorPCIeBoard,
        FormFactorDimm,
    }
}
