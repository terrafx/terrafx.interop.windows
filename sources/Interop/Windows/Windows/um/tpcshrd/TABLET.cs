// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/tpcshrd.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TABLET
{
    /// <include file='TABLET.xml' path='doc/member[@name="TABLET.TABLET_DISABLE_PRESSANDHOLD"]/*' />
    [NativeTypeName("#define TABLET_DISABLE_PRESSANDHOLD 0x00000001")]
    public const int TABLET_DISABLE_PRESSANDHOLD = 0x00000001;

    /// <include file='TABLET.xml' path='doc/member[@name="TABLET.TABLET_DISABLE_PENTAPFEEDBACK"]/*' />
    [NativeTypeName("#define TABLET_DISABLE_PENTAPFEEDBACK 0x00000008")]
    public const int TABLET_DISABLE_PENTAPFEEDBACK = 0x00000008;

    /// <include file='TABLET.xml' path='doc/member[@name="TABLET.TABLET_DISABLE_PENBARRELFEEDBACK"]/*' />
    [NativeTypeName("#define TABLET_DISABLE_PENBARRELFEEDBACK 0x00000010")]
    public const int TABLET_DISABLE_PENBARRELFEEDBACK = 0x00000010;

    /// <include file='TABLET.xml' path='doc/member[@name="TABLET.TABLET_DISABLE_TOUCHUIFORCEON"]/*' />
    [NativeTypeName("#define TABLET_DISABLE_TOUCHUIFORCEON 0x00000100")]
    public const int TABLET_DISABLE_TOUCHUIFORCEON = 0x00000100;

    /// <include file='TABLET.xml' path='doc/member[@name="TABLET.TABLET_DISABLE_TOUCHUIFORCEOFF"]/*' />
    [NativeTypeName("#define TABLET_DISABLE_TOUCHUIFORCEOFF 0x00000200")]
    public const int TABLET_DISABLE_TOUCHUIFORCEOFF = 0x00000200;

    /// <include file='TABLET.xml' path='doc/member[@name="TABLET.TABLET_DISABLE_TOUCHSWITCH"]/*' />
    [NativeTypeName("#define TABLET_DISABLE_TOUCHSWITCH 0x00008000")]
    public const int TABLET_DISABLE_TOUCHSWITCH = 0x00008000;

    /// <include file='TABLET.xml' path='doc/member[@name="TABLET.TABLET_DISABLE_FLICKS"]/*' />
    [NativeTypeName("#define TABLET_DISABLE_FLICKS 0x00010000")]
    public const int TABLET_DISABLE_FLICKS = 0x00010000;

    /// <include file='TABLET.xml' path='doc/member[@name="TABLET.TABLET_ENABLE_FLICKSONCONTEXT"]/*' />
    [NativeTypeName("#define TABLET_ENABLE_FLICKSONCONTEXT 0x00020000")]
    public const int TABLET_ENABLE_FLICKSONCONTEXT = 0x00020000;

    /// <include file='TABLET.xml' path='doc/member[@name="TABLET.TABLET_ENABLE_FLICKLEARNINGMODE"]/*' />
    [NativeTypeName("#define TABLET_ENABLE_FLICKLEARNINGMODE 0x00040000")]
    public const int TABLET_ENABLE_FLICKLEARNINGMODE = 0x00040000;

    /// <include file='TABLET.xml' path='doc/member[@name="TABLET.TABLET_DISABLE_SMOOTHSCROLLING"]/*' />
    [NativeTypeName("#define TABLET_DISABLE_SMOOTHSCROLLING 0x00080000")]
    public const int TABLET_DISABLE_SMOOTHSCROLLING = 0x00080000;

    /// <include file='TABLET.xml' path='doc/member[@name="TABLET.TABLET_DISABLE_FLICKFALLBACKKEYS"]/*' />
    [NativeTypeName("#define TABLET_DISABLE_FLICKFALLBACKKEYS 0x00100000")]
    public const int TABLET_DISABLE_FLICKFALLBACKKEYS = 0x00100000;

    /// <include file='TABLET.xml' path='doc/member[@name="TABLET.TABLET_ENABLE_MULTITOUCHDATA"]/*' />
    [NativeTypeName("#define TABLET_ENABLE_MULTITOUCHDATA 0x01000000")]
    public const int TABLET_ENABLE_MULTITOUCHDATA = 0x01000000;
}
