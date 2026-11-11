// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MFT
{
    /// <include file='MFT.xml' path='doc/member[@name="MFT.MFT_STRING"]/*' />
    [NativeTypeName("#define MFT_STRING MF_STRING")]
    public const int MFT_STRING = 0x00000000;

    /// <include file='MFT.xml' path='doc/member[@name="MFT.MFT_BITMAP"]/*' />
    [NativeTypeName("#define MFT_BITMAP MF_BITMAP")]
    public const int MFT_BITMAP = 0x00000004;

    /// <include file='MFT.xml' path='doc/member[@name="MFT.MFT_MENUBARBREAK"]/*' />
    [NativeTypeName("#define MFT_MENUBARBREAK MF_MENUBARBREAK")]
    public const int MFT_MENUBARBREAK = 0x00000020;

    /// <include file='MFT.xml' path='doc/member[@name="MFT.MFT_MENUBREAK"]/*' />
    [NativeTypeName("#define MFT_MENUBREAK MF_MENUBREAK")]
    public const int MFT_MENUBREAK = 0x00000040;

    /// <include file='MFT.xml' path='doc/member[@name="MFT.MFT_OWNERDRAW"]/*' />
    [NativeTypeName("#define MFT_OWNERDRAW MF_OWNERDRAW")]
    public const int MFT_OWNERDRAW = 0x00000100;

    /// <include file='MFT.xml' path='doc/member[@name="MFT.MFT_RADIOCHECK"]/*' />
    [NativeTypeName("#define MFT_RADIOCHECK 0x00000200L")]
    public const int MFT_RADIOCHECK = 0x00000200;

    /// <include file='MFT.xml' path='doc/member[@name="MFT.MFT_SEPARATOR"]/*' />
    [NativeTypeName("#define MFT_SEPARATOR MF_SEPARATOR")]
    public const int MFT_SEPARATOR = 0x00000800;

    /// <include file='MFT.xml' path='doc/member[@name="MFT.MFT_RIGHTORDER"]/*' />
    [NativeTypeName("#define MFT_RIGHTORDER 0x00002000L")]
    public const int MFT_RIGHTORDER = 0x00002000;

    /// <include file='MFT.xml' path='doc/member[@name="MFT.MFT_RIGHTJUSTIFY"]/*' />
    [NativeTypeName("#define MFT_RIGHTJUSTIFY MF_RIGHTJUSTIFY")]
    public const int MFT_RIGHTJUSTIFY = 0x00004000;
}
