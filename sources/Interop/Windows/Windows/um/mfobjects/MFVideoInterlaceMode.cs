// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum MFVideoInterlaceMode
{
    MFVideoInterlace_Unknown = 0,
    MFVideoInterlace_Progressive = 2,
    MFVideoInterlace_FieldInterleavedUpperFirst = 3,
    MFVideoInterlace_FieldInterleavedLowerFirst = 4,
    MFVideoInterlace_FieldSingleUpper = 5,
    MFVideoInterlace_FieldSingleLower = 6,
    MFVideoInterlace_MixedInterlaceOrProgressive = 7,
    MFVideoInterlace_Last = (MFVideoInterlace_MixedInterlaceOrProgressive + 1),
    MFVideoInterlace_ForceDWORD = 0x7fffffff,
}
