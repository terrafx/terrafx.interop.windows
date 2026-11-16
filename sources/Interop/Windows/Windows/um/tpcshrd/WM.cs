// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/tpcshrd.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WM
{
    /// <include file='WM.xml' path='doc/member[@name="WM.WM_TABLET_DEFBASE"]/*' />
    [NativeTypeName("#define WM_TABLET_DEFBASE 0x02C0")]
    public const int WM_TABLET_DEFBASE = 0x02C0;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_TABLET_MAXOFFSET"]/*' />
    [NativeTypeName("#define WM_TABLET_MAXOFFSET 0x20")]
    public const int WM_TABLET_MAXOFFSET = 0x20;

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_TABLET_ADDED"]/*' />
    [NativeTypeName("#define WM_TABLET_ADDED (WM_TABLET_DEFBASE + 8)")]
    public const int WM_TABLET_ADDED = (0x02C0 + 8);

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_TABLET_DELETED"]/*' />
    [NativeTypeName("#define WM_TABLET_DELETED (WM_TABLET_DEFBASE + 9)")]
    public const int WM_TABLET_DELETED = (0x02C0 + 9);

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_TABLET_FLICK"]/*' />
    [NativeTypeName("#define WM_TABLET_FLICK (WM_TABLET_DEFBASE + 11)")]
    public const int WM_TABLET_FLICK = (0x02C0 + 11);

    /// <include file='WM.xml' path='doc/member[@name="WM.WM_TABLET_QUERYSYSTEMGESTURESTATUS"]/*' />
    [NativeTypeName("#define WM_TABLET_QUERYSYSTEMGESTURESTATUS (WM_TABLET_DEFBASE + 12)")]
    public const int WM_TABLET_QUERYSYSTEMGESTURESTATUS = (0x02C0 + 12);
}
