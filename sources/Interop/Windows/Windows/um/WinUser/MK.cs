// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MK
{
    /// <include file='MK.xml' path='doc/member[@name="MK.MK_LBUTTON"]/*' />
    [NativeTypeName("#define MK_LBUTTON 0x0001")]
    public const int MK_LBUTTON = 0x0001;

    /// <include file='MK.xml' path='doc/member[@name="MK.MK_RBUTTON"]/*' />
    [NativeTypeName("#define MK_RBUTTON 0x0002")]
    public const int MK_RBUTTON = 0x0002;

    /// <include file='MK.xml' path='doc/member[@name="MK.MK_SHIFT"]/*' />
    [NativeTypeName("#define MK_SHIFT 0x0004")]
    public const int MK_SHIFT = 0x0004;

    /// <include file='MK.xml' path='doc/member[@name="MK.MK_CONTROL"]/*' />
    [NativeTypeName("#define MK_CONTROL 0x0008")]
    public const int MK_CONTROL = 0x0008;

    /// <include file='MK.xml' path='doc/member[@name="MK.MK_MBUTTON"]/*' />
    [NativeTypeName("#define MK_MBUTTON 0x0010")]
    public const int MK_MBUTTON = 0x0010;

    /// <include file='MK.xml' path='doc/member[@name="MK.MK_XBUTTON1"]/*' />
    [NativeTypeName("#define MK_XBUTTON1 0x0020")]
    public const int MK_XBUTTON1 = 0x0020;

    /// <include file='MK.xml' path='doc/member[@name="MK.MK_XBUTTON2"]/*' />
    [NativeTypeName("#define MK_XBUTTON2 0x0040")]
    public const int MK_XBUTTON2 = 0x0040;
}
