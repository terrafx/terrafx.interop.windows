// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.QualityMode;

namespace TerraFX.Interop
{
    public enum CompositingQuality
    {
        CompositingQualityInvalid = QualityModeInvalid,
        CompositingQualityDefault = QualityModeDefault,
        CompositingQualityHighSpeed = QualityModeLow,
        CompositingQualityHighQuality = QualityModeHigh,
        CompositingQualityGammaCorrected,
        CompositingQualityAssumeLinear,
    }
}
