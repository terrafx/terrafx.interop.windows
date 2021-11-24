// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum eAVEncVideoOutputScanType
{
    eAVEncVideoOutputScan_Progressive = 0,
    eAVEncVideoOutputScan_Interlaced = 1,
    eAVEncVideoOutputScan_SameAsInput = 2,
    eAVEncVideoOutputScan_Automatic = 3,
}
