// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum eAVEncVideoColorTransferFunction
    {
        eAVEncVideoColorTransferFunction_SameAsSource = 0,
        eAVEncVideoColorTransferFunction_10 = 1,
        eAVEncVideoColorTransferFunction_18 = 2,
        eAVEncVideoColorTransferFunction_20 = 3,
        eAVEncVideoColorTransferFunction_22 = 4,
        eAVEncVideoColorTransferFunction_22_709 = 5,
        eAVEncVideoColorTransferFunction_22_240M = 6,
        eAVEncVideoColorTransferFunction_22_8bit_sRGB = 7,
        eAVEncVideoColorTransferFunction_28 = 8,
    }
}
