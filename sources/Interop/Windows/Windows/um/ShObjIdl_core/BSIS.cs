// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class BSIS
{
    /// <include file='BSIS.xml' path='doc/member[@name="BSIS.BSIS_AUTOGRIPPER"]/*' />
    [NativeTypeName("#define BSIS_AUTOGRIPPER 0x00000000")]
    public const int BSIS_AUTOGRIPPER = 0x00000000;

    /// <include file='BSIS.xml' path='doc/member[@name="BSIS.BSIS_NOGRIPPER"]/*' />
    [NativeTypeName("#define BSIS_NOGRIPPER 0x00000001")]
    public const int BSIS_NOGRIPPER = 0x00000001;

    /// <include file='BSIS.xml' path='doc/member[@name="BSIS.BSIS_ALWAYSGRIPPER"]/*' />
    [NativeTypeName("#define BSIS_ALWAYSGRIPPER 0x00000002")]
    public const int BSIS_ALWAYSGRIPPER = 0x00000002;

    /// <include file='BSIS.xml' path='doc/member[@name="BSIS.BSIS_LEFTALIGN"]/*' />
    [NativeTypeName("#define BSIS_LEFTALIGN 0x00000004")]
    public const int BSIS_LEFTALIGN = 0x00000004;

    /// <include file='BSIS.xml' path='doc/member[@name="BSIS.BSIS_SINGLECLICK"]/*' />
    [NativeTypeName("#define BSIS_SINGLECLICK 0x00000008")]
    public const int BSIS_SINGLECLICK = 0x00000008;

    /// <include file='BSIS.xml' path='doc/member[@name="BSIS.BSIS_NOCONTEXTMENU"]/*' />
    [NativeTypeName("#define BSIS_NOCONTEXTMENU 0x00000010")]
    public const int BSIS_NOCONTEXTMENU = 0x00000010;

    /// <include file='BSIS.xml' path='doc/member[@name="BSIS.BSIS_NODROPTARGET"]/*' />
    [NativeTypeName("#define BSIS_NODROPTARGET 0x00000020")]
    public const int BSIS_NODROPTARGET = 0x00000020;

    /// <include file='BSIS.xml' path='doc/member[@name="BSIS.BSIS_NOCAPTION"]/*' />
    [NativeTypeName("#define BSIS_NOCAPTION 0x00000040")]
    public const int BSIS_NOCAPTION = 0x00000040;

    /// <include file='BSIS.xml' path='doc/member[@name="BSIS.BSIS_PREFERNOLINEBREAK"]/*' />
    [NativeTypeName("#define BSIS_PREFERNOLINEBREAK 0x00000080")]
    public const int BSIS_PREFERNOLINEBREAK = 0x00000080;

    /// <include file='BSIS.xml' path='doc/member[@name="BSIS.BSIS_LOCKED"]/*' />
    [NativeTypeName("#define BSIS_LOCKED 0x00000100")]
    public const int BSIS_LOCKED = 0x00000100;

    /// <include file='BSIS.xml' path='doc/member[@name="BSIS.BSIS_PRESERVEORDERDURINGLAYOUT"]/*' />
    [NativeTypeName("#define BSIS_PRESERVEORDERDURINGLAYOUT 0x00000200")]
    public const int BSIS_PRESERVEORDERDURINGLAYOUT = 0x00000200;

    /// <include file='BSIS.xml' path='doc/member[@name="BSIS.BSIS_FIXEDORDER"]/*' />
    [NativeTypeName("#define BSIS_FIXEDORDER 0x00000400")]
    public const int BSIS_FIXEDORDER = 0x00000400;
}
