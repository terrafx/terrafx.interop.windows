// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum htmlCellAlign
{
    htmlCellAlignNotSet = 0,
    htmlCellAlignLeft = 1,
    htmlCellAlignCenter = 2,
    htmlCellAlignRight = 3,
    htmlCellAlignMiddle = htmlCellAlignCenter,
    htmlCellAlign_Max = 2147483647,
}
