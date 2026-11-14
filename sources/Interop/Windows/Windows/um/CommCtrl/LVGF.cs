// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class LVGF
{
    /// <include file='LVGF.xml' path='doc/member[@name="LVGF.LVGF_NONE"]/*' />
    [NativeTypeName("#define LVGF_NONE 0x00000000")]
    public const int LVGF_NONE = 0x00000000;

    /// <include file='LVGF.xml' path='doc/member[@name="LVGF.LVGF_HEADER"]/*' />
    [NativeTypeName("#define LVGF_HEADER 0x00000001")]
    public const int LVGF_HEADER = 0x00000001;

    /// <include file='LVGF.xml' path='doc/member[@name="LVGF.LVGF_FOOTER"]/*' />
    [NativeTypeName("#define LVGF_FOOTER 0x00000002")]
    public const int LVGF_FOOTER = 0x00000002;

    /// <include file='LVGF.xml' path='doc/member[@name="LVGF.LVGF_STATE"]/*' />
    [NativeTypeName("#define LVGF_STATE 0x00000004")]
    public const int LVGF_STATE = 0x00000004;

    /// <include file='LVGF.xml' path='doc/member[@name="LVGF.LVGF_ALIGN"]/*' />
    [NativeTypeName("#define LVGF_ALIGN 0x00000008")]
    public const int LVGF_ALIGN = 0x00000008;

    /// <include file='LVGF.xml' path='doc/member[@name="LVGF.LVGF_GROUPID"]/*' />
    [NativeTypeName("#define LVGF_GROUPID 0x00000010")]
    public const int LVGF_GROUPID = 0x00000010;

    /// <include file='LVGF.xml' path='doc/member[@name="LVGF.LVGF_SUBTITLE"]/*' />
    [NativeTypeName("#define LVGF_SUBTITLE 0x00000100")]
    public const int LVGF_SUBTITLE = 0x00000100;

    /// <include file='LVGF.xml' path='doc/member[@name="LVGF.LVGF_TASK"]/*' />
    [NativeTypeName("#define LVGF_TASK 0x00000200")]
    public const int LVGF_TASK = 0x00000200;

    /// <include file='LVGF.xml' path='doc/member[@name="LVGF.LVGF_DESCRIPTIONTOP"]/*' />
    [NativeTypeName("#define LVGF_DESCRIPTIONTOP 0x00000400")]
    public const int LVGF_DESCRIPTIONTOP = 0x00000400;

    /// <include file='LVGF.xml' path='doc/member[@name="LVGF.LVGF_DESCRIPTIONBOTTOM"]/*' />
    [NativeTypeName("#define LVGF_DESCRIPTIONBOTTOM 0x00000800")]
    public const int LVGF_DESCRIPTIONBOTTOM = 0x00000800;

    /// <include file='LVGF.xml' path='doc/member[@name="LVGF.LVGF_TITLEIMAGE"]/*' />
    [NativeTypeName("#define LVGF_TITLEIMAGE 0x00001000")]
    public const int LVGF_TITLEIMAGE = 0x00001000;

    /// <include file='LVGF.xml' path='doc/member[@name="LVGF.LVGF_EXTENDEDIMAGE"]/*' />
    [NativeTypeName("#define LVGF_EXTENDEDIMAGE 0x00002000")]
    public const int LVGF_EXTENDEDIMAGE = 0x00002000;

    /// <include file='LVGF.xml' path='doc/member[@name="LVGF.LVGF_ITEMS"]/*' />
    [NativeTypeName("#define LVGF_ITEMS 0x00004000")]
    public const int LVGF_ITEMS = 0x00004000;

    /// <include file='LVGF.xml' path='doc/member[@name="LVGF.LVGF_SUBSET"]/*' />
    [NativeTypeName("#define LVGF_SUBSET 0x00008000")]
    public const int LVGF_SUBSET = 0x00008000;

    /// <include file='LVGF.xml' path='doc/member[@name="LVGF.LVGF_SUBSETITEMS"]/*' />
    [NativeTypeName("#define LVGF_SUBSETITEMS 0x00010000")]
    public const int LVGF_SUBSETITEMS = 0x00010000;
}
