// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MFVideoPrimaries
    {
        MFVideoPrimaries_Unknown = 0,
        MFVideoPrimaries_reserved = 1,
        MFVideoPrimaries_BT709 = 2,
        MFVideoPrimaries_BT470_2_SysM = 3,
        MFVideoPrimaries_BT470_2_SysBG = 4,
        MFVideoPrimaries_SMPTE170M = 5,
        MFVideoPrimaries_SMPTE240M = 6,
        MFVideoPrimaries_EBU3213 = 7,
        MFVideoPrimaries_SMPTE_C = 8,
        MFVideoPrimaries_BT2020 = 9,
        MFVideoPrimaries_XYZ = 10,
        MFVideoPrimaries_DCI_P3 = 11,
        MFVideoPrimaries_ACES = 12,
        MFVideoPrimaries_Last = (MFVideoPrimaries_ACES + 1),
        MFVideoPrimaries_ForceDWORD = 0x7fffffff,
    }
}
