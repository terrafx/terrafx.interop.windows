// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class FCIDM
{
    /// <include file='FCIDM.xml' path='doc/member[@name="FCIDM.FCIDM_SHVIEWFIRST"]/*' />
    [NativeTypeName("#define FCIDM_SHVIEWFIRST 0x0000")]
    public const int FCIDM_SHVIEWFIRST = 0x0000;

    /// <include file='FCIDM.xml' path='doc/member[@name="FCIDM.FCIDM_SHVIEWLAST"]/*' />
    [NativeTypeName("#define FCIDM_SHVIEWLAST 0x7fff")]
    public const int FCIDM_SHVIEWLAST = 0x7fff;

    /// <include file='FCIDM.xml' path='doc/member[@name="FCIDM.FCIDM_BROWSERFIRST"]/*' />
    [NativeTypeName("#define FCIDM_BROWSERFIRST 0xa000")]
    public const int FCIDM_BROWSERFIRST = 0xa000;

    /// <include file='FCIDM.xml' path='doc/member[@name="FCIDM.FCIDM_BROWSERLAST"]/*' />
    [NativeTypeName("#define FCIDM_BROWSERLAST 0xbf00")]
    public const int FCIDM_BROWSERLAST = 0xbf00;

    /// <include file='FCIDM.xml' path='doc/member[@name="FCIDM.FCIDM_GLOBALFIRST"]/*' />
    [NativeTypeName("#define FCIDM_GLOBALFIRST 0x8000")]
    public const int FCIDM_GLOBALFIRST = 0x8000;

    /// <include file='FCIDM.xml' path='doc/member[@name="FCIDM.FCIDM_GLOBALLAST"]/*' />
    [NativeTypeName("#define FCIDM_GLOBALLAST 0x9fff")]
    public const int FCIDM_GLOBALLAST = 0x9fff;

    /// <include file='FCIDM.xml' path='doc/member[@name="FCIDM.FCIDM_MENU_FILE"]/*' />
    [NativeTypeName("#define FCIDM_MENU_FILE (FCIDM_GLOBALFIRST+0x0000)")]
    public const int FCIDM_MENU_FILE = (0x8000 + 0x0000);

    /// <include file='FCIDM.xml' path='doc/member[@name="FCIDM.FCIDM_MENU_EDIT"]/*' />
    [NativeTypeName("#define FCIDM_MENU_EDIT (FCIDM_GLOBALFIRST+0x0040)")]
    public const int FCIDM_MENU_EDIT = (0x8000 + 0x0040);

    /// <include file='FCIDM.xml' path='doc/member[@name="FCIDM.FCIDM_MENU_VIEW"]/*' />
    [NativeTypeName("#define FCIDM_MENU_VIEW (FCIDM_GLOBALFIRST+0x0080)")]
    public const int FCIDM_MENU_VIEW = (0x8000 + 0x0080);

    /// <include file='FCIDM.xml' path='doc/member[@name="FCIDM.FCIDM_MENU_VIEW_SEP_OPTIONS"]/*' />
    [NativeTypeName("#define FCIDM_MENU_VIEW_SEP_OPTIONS (FCIDM_GLOBALFIRST+0x0081)")]
    public const int FCIDM_MENU_VIEW_SEP_OPTIONS = (0x8000 + 0x0081);

    /// <include file='FCIDM.xml' path='doc/member[@name="FCIDM.FCIDM_MENU_TOOLS"]/*' />
    [NativeTypeName("#define FCIDM_MENU_TOOLS (FCIDM_GLOBALFIRST+0x00c0)")]
    public const int FCIDM_MENU_TOOLS = (0x8000 + 0x00c0);

    /// <include file='FCIDM.xml' path='doc/member[@name="FCIDM.FCIDM_MENU_TOOLS_SEP_GOTO"]/*' />
    [NativeTypeName("#define FCIDM_MENU_TOOLS_SEP_GOTO (FCIDM_GLOBALFIRST+0x00c1)")]
    public const int FCIDM_MENU_TOOLS_SEP_GOTO = (0x8000 + 0x00c1);

    /// <include file='FCIDM.xml' path='doc/member[@name="FCIDM.FCIDM_MENU_HELP"]/*' />
    [NativeTypeName("#define FCIDM_MENU_HELP (FCIDM_GLOBALFIRST+0x0100)")]
    public const int FCIDM_MENU_HELP = (0x8000 + 0x0100);

    /// <include file='FCIDM.xml' path='doc/member[@name="FCIDM.FCIDM_MENU_FIND"]/*' />
    [NativeTypeName("#define FCIDM_MENU_FIND (FCIDM_GLOBALFIRST+0x0140)")]
    public const int FCIDM_MENU_FIND = (0x8000 + 0x0140);

    /// <include file='FCIDM.xml' path='doc/member[@name="FCIDM.FCIDM_MENU_EXPLORE"]/*' />
    [NativeTypeName("#define FCIDM_MENU_EXPLORE (FCIDM_GLOBALFIRST+0x0150)")]
    public const int FCIDM_MENU_EXPLORE = (0x8000 + 0x0150);

    /// <include file='FCIDM.xml' path='doc/member[@name="FCIDM.FCIDM_MENU_FAVORITES"]/*' />
    [NativeTypeName("#define FCIDM_MENU_FAVORITES (FCIDM_GLOBALFIRST+0x0170)")]
    public const int FCIDM_MENU_FAVORITES = (0x8000 + 0x0170);
}
