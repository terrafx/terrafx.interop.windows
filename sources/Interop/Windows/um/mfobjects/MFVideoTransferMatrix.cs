// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MFVideoTransferMatrix
    {
        MFVideoTransferMatrix_Unknown = 0,
        MFVideoTransferMatrix_BT709 = 1,
        MFVideoTransferMatrix_BT601 = 2,
        MFVideoTransferMatrix_SMPTE240M = 3,
        MFVideoTransferMatrix_BT2020_10 = 4,
        MFVideoTransferMatrix_BT2020_12 = 5,
        MFVideoTransferMatrix_Last = (MFVideoTransferMatrix_BT2020_12 + 1),
        MFVideoTransferMatrix_ForceDWORD = 0x7fffffff,
    }
}
