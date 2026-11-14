// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DCX
{
    /// <include file='DCX.xml' path='doc/member[@name="DCX.DCX_WINDOW"]/*' />
    [NativeTypeName("#define DCX_WINDOW 0x00000001L")]
    public const int DCX_WINDOW = 0x00000001;

    /// <include file='DCX.xml' path='doc/member[@name="DCX.DCX_CACHE"]/*' />
    [NativeTypeName("#define DCX_CACHE 0x00000002L")]
    public const int DCX_CACHE = 0x00000002;

    /// <include file='DCX.xml' path='doc/member[@name="DCX.DCX_NORESETATTRS"]/*' />
    [NativeTypeName("#define DCX_NORESETATTRS 0x00000004L")]
    public const int DCX_NORESETATTRS = 0x00000004;

    /// <include file='DCX.xml' path='doc/member[@name="DCX.DCX_CLIPCHILDREN"]/*' />
    [NativeTypeName("#define DCX_CLIPCHILDREN 0x00000008L")]
    public const int DCX_CLIPCHILDREN = 0x00000008;

    /// <include file='DCX.xml' path='doc/member[@name="DCX.DCX_CLIPSIBLINGS"]/*' />
    [NativeTypeName("#define DCX_CLIPSIBLINGS 0x00000010L")]
    public const int DCX_CLIPSIBLINGS = 0x00000010;

    /// <include file='DCX.xml' path='doc/member[@name="DCX.DCX_PARENTCLIP"]/*' />
    [NativeTypeName("#define DCX_PARENTCLIP 0x00000020L")]
    public const int DCX_PARENTCLIP = 0x00000020;

    /// <include file='DCX.xml' path='doc/member[@name="DCX.DCX_EXCLUDERGN"]/*' />
    [NativeTypeName("#define DCX_EXCLUDERGN 0x00000040L")]
    public const int DCX_EXCLUDERGN = 0x00000040;

    /// <include file='DCX.xml' path='doc/member[@name="DCX.DCX_INTERSECTRGN"]/*' />
    [NativeTypeName("#define DCX_INTERSECTRGN 0x00000080L")]
    public const int DCX_INTERSECTRGN = 0x00000080;

    /// <include file='DCX.xml' path='doc/member[@name="DCX.DCX_EXCLUDEUPDATE"]/*' />
    [NativeTypeName("#define DCX_EXCLUDEUPDATE 0x00000100L")]
    public const int DCX_EXCLUDEUPDATE = 0x00000100;

    /// <include file='DCX.xml' path='doc/member[@name="DCX.DCX_INTERSECTUPDATE"]/*' />
    [NativeTypeName("#define DCX_INTERSECTUPDATE 0x00000200L")]
    public const int DCX_INTERSECTUPDATE = 0x00000200;

    /// <include file='DCX.xml' path='doc/member[@name="DCX.DCX_LOCKWINDOWUPDATE"]/*' />
    [NativeTypeName("#define DCX_LOCKWINDOWUPDATE 0x00000400L")]
    public const int DCX_LOCKWINDOWUPDATE = 0x00000400;

    /// <include file='DCX.xml' path='doc/member[@name="DCX.DCX_VALIDATE"]/*' />
    [NativeTypeName("#define DCX_VALIDATE 0x00200000L")]
    public const int DCX_VALIDATE = 0x00200000;
}
