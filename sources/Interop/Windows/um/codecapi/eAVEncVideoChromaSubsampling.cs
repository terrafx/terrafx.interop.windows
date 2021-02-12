// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum eAVEncVideoChromaSubsampling
    {
        eAVEncVideoChromaSubsamplingFormat_SameAsSource = 0,
        eAVEncVideoChromaSubsamplingFormat_ProgressiveChroma = 0x8,
        eAVEncVideoChromaSubsamplingFormat_Horizontally_Cosited = 0x4,
        eAVEncVideoChromaSubsamplingFormat_Vertically_Cosited = 0x2,
        eAVEncVideoChromaSubsamplingFormat_Vertically_AlignedChromaPlanes = 0x1,
    }
}
