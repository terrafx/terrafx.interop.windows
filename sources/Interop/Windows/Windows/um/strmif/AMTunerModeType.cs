// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum AMTunerModeType
{
    AMTUNER_MODE_DEFAULT = 0,
    AMTUNER_MODE_TV = 0x1,
    AMTUNER_MODE_FM_RADIO = 0x2,
    AMTUNER_MODE_AM_RADIO = 0x4,
    AMTUNER_MODE_DSS = 0x8,
}
