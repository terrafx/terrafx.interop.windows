// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    public const int ADVISE_NONE = 0;

    public const int ADVISE_CLIPPING = 0x1;

    public const int ADVISE_PALETTE = 0x2;

    public const int ADVISE_COLORKEY = 0x4;

    public const int ADVISE_POSITION = 0x8;

    public const int ADVISE_DISPLAY_CHANGE = 0x10;

    public const int MERIT_PREFERRED = 0x800000;

    public const int MERIT_NORMAL = 0x600000;

    public const int MERIT_UNLIKELY = 0x400000;

    public const int MERIT_DO_NOT_USE = 0x200000;

    public const int MERIT_SW_COMPRESSOR = 0x100000;

    public const int MERIT_HW_COMPRESSOR = 0x100050;

    public const int REG_PINFLAG_B_ZERO = 0x1;

    public const int REG_PINFLAG_B_RENDERER = 0x2;

    public const int REG_PINFLAG_B_MANY = 0x4;

    public const int REG_PINFLAG_B_OUTPUT = 0x8;

    public const int CK_NOCOLORKEY = 0;

    public const int CK_INDEX = 0x1;

    public const int CK_RGB = 0x2;

    public const int MAX_NUMBER_OF_STREAMS = 16;
}
