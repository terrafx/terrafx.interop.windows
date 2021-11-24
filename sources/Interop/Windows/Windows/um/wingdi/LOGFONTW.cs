// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct LOGFONTW
{
    [NativeTypeName("LONG")]
    public int lfHeight;

    [NativeTypeName("LONG")]
    public int lfWidth;

    [NativeTypeName("LONG")]
    public int lfEscapement;

    [NativeTypeName("LONG")]
    public int lfOrientation;

    [NativeTypeName("LONG")]
    public int lfWeight;

    public byte lfItalic;

    public byte lfUnderline;

    public byte lfStrikeOut;

    public byte lfCharSet;

    public byte lfOutPrecision;

    public byte lfClipPrecision;

    public byte lfQuality;

    public byte lfPitchAndFamily;

    [NativeTypeName("WCHAR [32]")]
    public fixed ushort lfFaceName[32];
}
