// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class VSCLASS
{
    /// <include file='VSCLASS.xml' path='doc/member[@name="VSCLASS.VSCLASS_LINK"]/*' />
    [NativeTypeName("#define VSCLASS_LINK L\"LINK\"")]
    public const string VSCLASS_LINK = "LINK";

    /// <include file='VSCLASS.xml' path='doc/member[@name="VSCLASS.VSCLASS_EMPTYMARKUP"]/*' />
    [NativeTypeName("#define VSCLASS_EMPTYMARKUP L\"EMPTYMARKUP\"")]
    public const string VSCLASS_EMPTYMARKUP = "EMPTYMARKUP";

    /// <include file='VSCLASS.xml' path='doc/member[@name="VSCLASS.VSCLASS_STATIC"]/*' />
    [NativeTypeName("#define VSCLASS_STATIC L\"STATIC\"")]
    public const string VSCLASS_STATIC = "STATIC";

    /// <include file='VSCLASS.xml' path='doc/member[@name="VSCLASS.VSCLASS_PAGE"]/*' />
    [NativeTypeName("#define VSCLASS_PAGE L\"PAGE\"")]
    public const string VSCLASS_PAGE = "PAGE";

    /// <include file='VSCLASS.xml' path='doc/member[@name="VSCLASS.VSCLASS_MONTHCAL"]/*' />
    [NativeTypeName("#define VSCLASS_MONTHCAL L\"MONTHCAL\"")]
    public const string VSCLASS_MONTHCAL = "MONTHCAL";

    /// <include file='VSCLASS.xml' path='doc/member[@name="VSCLASS.VSCLASS_CLOCK"]/*' />
    [NativeTypeName("#define VSCLASS_CLOCK L\"CLOCK\"")]
    public const string VSCLASS_CLOCK = "CLOCK";

    /// <include file='VSCLASS.xml' path='doc/member[@name="VSCLASS.VSCLASS_TRAYNOTIFY"]/*' />
    [NativeTypeName("#define VSCLASS_TRAYNOTIFY L\"TRAYNOTIFY\"")]
    public const string VSCLASS_TRAYNOTIFY = "TRAYNOTIFY";

    /// <include file='VSCLASS.xml' path='doc/member[@name="VSCLASS.VSCLASS_TASKBAR"]/*' />
    [NativeTypeName("#define VSCLASS_TASKBAR L\"TASKBAR\"")]
    public const string VSCLASS_TASKBAR = "TASKBAR";

    /// <include file='VSCLASS.xml' path='doc/member[@name="VSCLASS.VSCLASS_TASKBAND"]/*' />
    [NativeTypeName("#define VSCLASS_TASKBAND L\"TASKBAND\"")]
    public const string VSCLASS_TASKBAND = "TASKBAND";

    /// <include file='VSCLASS.xml' path='doc/member[@name="VSCLASS.VSCLASS_STARTPANEL"]/*' />
    [NativeTypeName("#define VSCLASS_STARTPANEL L\"STARTPANEL\"")]
    public const string VSCLASS_STARTPANEL = "STARTPANEL";

    /// <include file='VSCLASS.xml' path='doc/member[@name="VSCLASS.VSCLASS_MENUBAND"]/*' />
    [NativeTypeName("#define VSCLASS_MENUBAND L\"MENUBAND\"")]
    public const string VSCLASS_MENUBAND = "MENUBAND";
}
