// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class VIEW
{
    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_LARGEICONS"]/*' />
    [NativeTypeName("#define VIEW_LARGEICONS 0")]
    public const int VIEW_LARGEICONS = 0;

    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_SMALLICONS"]/*' />
    [NativeTypeName("#define VIEW_SMALLICONS 1")]
    public const int VIEW_SMALLICONS = 1;

    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_LIST"]/*' />
    [NativeTypeName("#define VIEW_LIST 2")]
    public const int VIEW_LIST = 2;

    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_DETAILS"]/*' />
    [NativeTypeName("#define VIEW_DETAILS 3")]
    public const int VIEW_DETAILS = 3;

    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_SORTNAME"]/*' />
    [NativeTypeName("#define VIEW_SORTNAME 4")]
    public const int VIEW_SORTNAME = 4;

    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_SORTSIZE"]/*' />
    [NativeTypeName("#define VIEW_SORTSIZE 5")]
    public const int VIEW_SORTSIZE = 5;

    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_SORTDATE"]/*' />
    [NativeTypeName("#define VIEW_SORTDATE 6")]
    public const int VIEW_SORTDATE = 6;

    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_SORTTYPE"]/*' />
    [NativeTypeName("#define VIEW_SORTTYPE 7")]
    public const int VIEW_SORTTYPE = 7;

    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_PARENTFOLDER"]/*' />
    [NativeTypeName("#define VIEW_PARENTFOLDER 8")]
    public const int VIEW_PARENTFOLDER = 8;

    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_NETCONNECT"]/*' />
    [NativeTypeName("#define VIEW_NETCONNECT 9")]
    public const int VIEW_NETCONNECT = 9;

    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_NETDISCONNECT"]/*' />
    [NativeTypeName("#define VIEW_NETDISCONNECT 10")]
    public const int VIEW_NETDISCONNECT = 10;

    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_NEWFOLDER"]/*' />
    [NativeTypeName("#define VIEW_NEWFOLDER 11")]
    public const int VIEW_NEWFOLDER = 11;

    /// <include file='VIEW.xml' path='doc/member[@name="VIEW.VIEW_VIEWMENU"]/*' />
    [NativeTypeName("#define VIEW_VIEWMENU 12")]
    public const int VIEW_VIEWMENU = 12;
}
