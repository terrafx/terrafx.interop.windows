// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum eAVEncCommonRateControlMode
    {
        eAVEncCommonRateControlMode_CBR = 0,
        eAVEncCommonRateControlMode_PeakConstrainedVBR = 1,
        eAVEncCommonRateControlMode_UnconstrainedVBR = 2,
        eAVEncCommonRateControlMode_Quality = 3,
        eAVEncCommonRateControlMode_LowDelayVBR = 4,
        eAVEncCommonRateControlMode_GlobalVBR = 5,
        eAVEncCommonRateControlMode_GlobalLowDelayVBR = 6,
    }
}
