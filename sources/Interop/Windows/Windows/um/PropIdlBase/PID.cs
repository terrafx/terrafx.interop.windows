// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PID
{
    /// <include file='PID.xml' path='doc/member[@name="PID.PID_DICTIONARY"]/*' />
    [NativeTypeName("#define PID_DICTIONARY ( 0 )")]
    public const int PID_DICTIONARY = (0);

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_CODEPAGE"]/*' />
    [NativeTypeName("#define PID_CODEPAGE ( 0x1 )")]
    public const int PID_CODEPAGE = (0x1);

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_FIRST_USABLE"]/*' />
    [NativeTypeName("#define PID_FIRST_USABLE ( 0x2 )")]
    public const int PID_FIRST_USABLE = (0x2);

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_FIRST_NAME_DEFAULT"]/*' />
    [NativeTypeName("#define PID_FIRST_NAME_DEFAULT ( 0xfff )")]
    public const int PID_FIRST_NAME_DEFAULT = (0xfff);

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_LOCALE"]/*' />
    [NativeTypeName("#define PID_LOCALE ( 0x80000000 )")]
    public const uint PID_LOCALE = (0x80000000);

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_MODIFY_TIME"]/*' />
    [NativeTypeName("#define PID_MODIFY_TIME ( 0x80000001 )")]
    public const uint PID_MODIFY_TIME = (0x80000001);

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_SECURITY"]/*' />
    [NativeTypeName("#define PID_SECURITY ( 0x80000002 )")]
    public const uint PID_SECURITY = (0x80000002);

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_BEHAVIOR"]/*' />
    [NativeTypeName("#define PID_BEHAVIOR ( 0x80000003 )")]
    public const uint PID_BEHAVIOR = (0x80000003);

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_ILLEGAL"]/*' />
    [NativeTypeName("#define PID_ILLEGAL ( 0xffffffff )")]
    public const uint PID_ILLEGAL = (0xffffffff);

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_MIN_READONLY"]/*' />
    [NativeTypeName("#define PID_MIN_READONLY ( 0x80000000 )")]
    public const uint PID_MIN_READONLY = (0x80000000);

    /// <include file='PID.xml' path='doc/member[@name="PID.PID_MAX_READONLY"]/*' />
    [NativeTypeName("#define PID_MAX_READONLY ( 0xbfffffff )")]
    public const uint PID_MAX_READONLY = (0xbfffffff);
}
