// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class HELP
{
    /// <include file='HELP.xml' path='doc/member[@name="HELP.HELP_CONTEXT"]/*' />
    [NativeTypeName("#define HELP_CONTEXT 0x0001L")]
    public const int HELP_CONTEXT = 0x0001;

    /// <include file='HELP.xml' path='doc/member[@name="HELP.HELP_QUIT"]/*' />
    [NativeTypeName("#define HELP_QUIT 0x0002L")]
    public const int HELP_QUIT = 0x0002;

    /// <include file='HELP.xml' path='doc/member[@name="HELP.HELP_INDEX"]/*' />
    [NativeTypeName("#define HELP_INDEX 0x0003L")]
    public const int HELP_INDEX = 0x0003;

    /// <include file='HELP.xml' path='doc/member[@name="HELP.HELP_CONTENTS"]/*' />
    [NativeTypeName("#define HELP_CONTENTS 0x0003L")]
    public const int HELP_CONTENTS = 0x0003;

    /// <include file='HELP.xml' path='doc/member[@name="HELP.HELP_HELPONHELP"]/*' />
    [NativeTypeName("#define HELP_HELPONHELP 0x0004L")]
    public const int HELP_HELPONHELP = 0x0004;

    /// <include file='HELP.xml' path='doc/member[@name="HELP.HELP_SETINDEX"]/*' />
    [NativeTypeName("#define HELP_SETINDEX 0x0005L")]
    public const int HELP_SETINDEX = 0x0005;

    /// <include file='HELP.xml' path='doc/member[@name="HELP.HELP_SETCONTENTS"]/*' />
    [NativeTypeName("#define HELP_SETCONTENTS 0x0005L")]
    public const int HELP_SETCONTENTS = 0x0005;

    /// <include file='HELP.xml' path='doc/member[@name="HELP.HELP_CONTEXTPOPUP"]/*' />
    [NativeTypeName("#define HELP_CONTEXTPOPUP 0x0008L")]
    public const int HELP_CONTEXTPOPUP = 0x0008;

    /// <include file='HELP.xml' path='doc/member[@name="HELP.HELP_FORCEFILE"]/*' />
    [NativeTypeName("#define HELP_FORCEFILE 0x0009L")]
    public const int HELP_FORCEFILE = 0x0009;

    /// <include file='HELP.xml' path='doc/member[@name="HELP.HELP_KEY"]/*' />
    [NativeTypeName("#define HELP_KEY 0x0101L")]
    public const int HELP_KEY = 0x0101;

    /// <include file='HELP.xml' path='doc/member[@name="HELP.HELP_COMMAND"]/*' />
    [NativeTypeName("#define HELP_COMMAND 0x0102L")]
    public const int HELP_COMMAND = 0x0102;

    /// <include file='HELP.xml' path='doc/member[@name="HELP.HELP_PARTIALKEY"]/*' />
    [NativeTypeName("#define HELP_PARTIALKEY 0x0105L")]
    public const int HELP_PARTIALKEY = 0x0105;

    /// <include file='HELP.xml' path='doc/member[@name="HELP.HELP_MULTIKEY"]/*' />
    [NativeTypeName("#define HELP_MULTIKEY 0x0201L")]
    public const int HELP_MULTIKEY = 0x0201;

    /// <include file='HELP.xml' path='doc/member[@name="HELP.HELP_SETWINPOS"]/*' />
    [NativeTypeName("#define HELP_SETWINPOS 0x0203L")]
    public const int HELP_SETWINPOS = 0x0203;

    /// <include file='HELP.xml' path='doc/member[@name="HELP.HELP_CONTEXTMENU"]/*' />
    [NativeTypeName("#define HELP_CONTEXTMENU 0x000a")]
    public const int HELP_CONTEXTMENU = 0x000a;

    /// <include file='HELP.xml' path='doc/member[@name="HELP.HELP_FINDER"]/*' />
    [NativeTypeName("#define HELP_FINDER 0x000b")]
    public const int HELP_FINDER = 0x000b;

    /// <include file='HELP.xml' path='doc/member[@name="HELP.HELP_WM_HELP"]/*' />
    [NativeTypeName("#define HELP_WM_HELP 0x000c")]
    public const int HELP_WM_HELP = 0x000c;

    /// <include file='HELP.xml' path='doc/member[@name="HELP.HELP_SETPOPUP_POS"]/*' />
    [NativeTypeName("#define HELP_SETPOPUP_POS 0x000d")]
    public const int HELP_SETPOPUP_POS = 0x000d;

    /// <include file='HELP.xml' path='doc/member[@name="HELP.HELP_TCARD"]/*' />
    [NativeTypeName("#define HELP_TCARD 0x8000")]
    public const int HELP_TCARD = 0x8000;

    /// <include file='HELP.xml' path='doc/member[@name="HELP.HELP_TCARD_DATA"]/*' />
    [NativeTypeName("#define HELP_TCARD_DATA 0x0010")]
    public const int HELP_TCARD_DATA = 0x0010;

    /// <include file='HELP.xml' path='doc/member[@name="HELP.HELP_TCARD_OTHER_CALLER"]/*' />
    [NativeTypeName("#define HELP_TCARD_OTHER_CALLER 0x0011")]
    public const int HELP_TCARD_OTHER_CALLER = 0x0011;
}
