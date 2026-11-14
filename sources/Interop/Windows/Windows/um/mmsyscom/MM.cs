// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmsyscom.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MM
{
    /// <include file='MM.xml' path='doc/member[@name="MM.MM_JOY1MOVE"]/*' />
    [NativeTypeName("#define MM_JOY1MOVE 0x3A0")]
    public const int MM_JOY1MOVE = 0x3A0;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_JOY2MOVE"]/*' />
    [NativeTypeName("#define MM_JOY2MOVE 0x3A1")]
    public const int MM_JOY2MOVE = 0x3A1;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_JOY1ZMOVE"]/*' />
    [NativeTypeName("#define MM_JOY1ZMOVE 0x3A2")]
    public const int MM_JOY1ZMOVE = 0x3A2;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_JOY2ZMOVE"]/*' />
    [NativeTypeName("#define MM_JOY2ZMOVE 0x3A3")]
    public const int MM_JOY2ZMOVE = 0x3A3;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_JOY1BUTTONDOWN"]/*' />
    [NativeTypeName("#define MM_JOY1BUTTONDOWN 0x3B5")]
    public const int MM_JOY1BUTTONDOWN = 0x3B5;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_JOY2BUTTONDOWN"]/*' />
    [NativeTypeName("#define MM_JOY2BUTTONDOWN 0x3B6")]
    public const int MM_JOY2BUTTONDOWN = 0x3B6;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_JOY1BUTTONUP"]/*' />
    [NativeTypeName("#define MM_JOY1BUTTONUP 0x3B7")]
    public const int MM_JOY1BUTTONUP = 0x3B7;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_JOY2BUTTONUP"]/*' />
    [NativeTypeName("#define MM_JOY2BUTTONUP 0x3B8")]
    public const int MM_JOY2BUTTONUP = 0x3B8;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_MCINOTIFY"]/*' />
    [NativeTypeName("#define MM_MCINOTIFY 0x3B9")]
    public const int MM_MCINOTIFY = 0x3B9;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_WOM_OPEN"]/*' />
    [NativeTypeName("#define MM_WOM_OPEN 0x3BB")]
    public const int MM_WOM_OPEN = 0x3BB;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_WOM_CLOSE"]/*' />
    [NativeTypeName("#define MM_WOM_CLOSE 0x3BC")]
    public const int MM_WOM_CLOSE = 0x3BC;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_WOM_DONE"]/*' />
    [NativeTypeName("#define MM_WOM_DONE 0x3BD")]
    public const int MM_WOM_DONE = 0x3BD;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_WIM_OPEN"]/*' />
    [NativeTypeName("#define MM_WIM_OPEN 0x3BE")]
    public const int MM_WIM_OPEN = 0x3BE;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_WIM_CLOSE"]/*' />
    [NativeTypeName("#define MM_WIM_CLOSE 0x3BF")]
    public const int MM_WIM_CLOSE = 0x3BF;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_WIM_DATA"]/*' />
    [NativeTypeName("#define MM_WIM_DATA 0x3C0")]
    public const int MM_WIM_DATA = 0x3C0;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_MIM_OPEN"]/*' />
    [NativeTypeName("#define MM_MIM_OPEN 0x3C1")]
    public const int MM_MIM_OPEN = 0x3C1;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_MIM_CLOSE"]/*' />
    [NativeTypeName("#define MM_MIM_CLOSE 0x3C2")]
    public const int MM_MIM_CLOSE = 0x3C2;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_MIM_DATA"]/*' />
    [NativeTypeName("#define MM_MIM_DATA 0x3C3")]
    public const int MM_MIM_DATA = 0x3C3;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_MIM_LONGDATA"]/*' />
    [NativeTypeName("#define MM_MIM_LONGDATA 0x3C4")]
    public const int MM_MIM_LONGDATA = 0x3C4;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_MIM_ERROR"]/*' />
    [NativeTypeName("#define MM_MIM_ERROR 0x3C5")]
    public const int MM_MIM_ERROR = 0x3C5;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_MIM_LONGERROR"]/*' />
    [NativeTypeName("#define MM_MIM_LONGERROR 0x3C6")]
    public const int MM_MIM_LONGERROR = 0x3C6;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_MOM_OPEN"]/*' />
    [NativeTypeName("#define MM_MOM_OPEN 0x3C7")]
    public const int MM_MOM_OPEN = 0x3C7;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_MOM_CLOSE"]/*' />
    [NativeTypeName("#define MM_MOM_CLOSE 0x3C8")]
    public const int MM_MOM_CLOSE = 0x3C8;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_MOM_DONE"]/*' />
    [NativeTypeName("#define MM_MOM_DONE 0x3C9")]
    public const int MM_MOM_DONE = 0x3C9;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_DRVM_OPEN"]/*' />
    [NativeTypeName("#define MM_DRVM_OPEN 0x3D0")]
    public const int MM_DRVM_OPEN = 0x3D0;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_DRVM_CLOSE"]/*' />
    [NativeTypeName("#define MM_DRVM_CLOSE 0x3D1")]
    public const int MM_DRVM_CLOSE = 0x3D1;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_DRVM_DATA"]/*' />
    [NativeTypeName("#define MM_DRVM_DATA 0x3D2")]
    public const int MM_DRVM_DATA = 0x3D2;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_DRVM_ERROR"]/*' />
    [NativeTypeName("#define MM_DRVM_ERROR 0x3D3")]
    public const int MM_DRVM_ERROR = 0x3D3;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_STREAM_OPEN"]/*' />
    [NativeTypeName("#define MM_STREAM_OPEN 0x3D4")]
    public const int MM_STREAM_OPEN = 0x3D4;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_STREAM_CLOSE"]/*' />
    [NativeTypeName("#define MM_STREAM_CLOSE 0x3D5")]
    public const int MM_STREAM_CLOSE = 0x3D5;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_STREAM_DONE"]/*' />
    [NativeTypeName("#define MM_STREAM_DONE 0x3D6")]
    public const int MM_STREAM_DONE = 0x3D6;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_STREAM_ERROR"]/*' />
    [NativeTypeName("#define MM_STREAM_ERROR 0x3D7")]
    public const int MM_STREAM_ERROR = 0x3D7;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_MOM_POSITIONCB"]/*' />
    [NativeTypeName("#define MM_MOM_POSITIONCB 0x3CA")]
    public const int MM_MOM_POSITIONCB = 0x3CA;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_MCISIGNAL"]/*' />
    [NativeTypeName("#define MM_MCISIGNAL 0x3CB")]
    public const int MM_MCISIGNAL = 0x3CB;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_MIM_MOREDATA"]/*' />
    [NativeTypeName("#define MM_MIM_MOREDATA 0x3CC")]
    public const int MM_MIM_MOREDATA = 0x3CC;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_MIXM_LINE_CHANGE"]/*' />
    [NativeTypeName("#define MM_MIXM_LINE_CHANGE 0x3D0")]
    public const int MM_MIXM_LINE_CHANGE = 0x3D0;

    /// <include file='MM.xml' path='doc/member[@name="MM.MM_MIXM_CONTROL_CHANGE"]/*' />
    [NativeTypeName("#define MM_MIXM_CONTROL_CHANGE 0x3D1")]
    public const int MM_MIXM_CONTROL_CHANGE = 0x3D1;
}
