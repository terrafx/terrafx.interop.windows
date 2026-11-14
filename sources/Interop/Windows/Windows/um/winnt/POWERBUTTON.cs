// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class POWERBUTTON
{
    /// <include file='POWERBUTTON.xml' path='doc/member[@name="POWERBUTTON.POWERBUTTON_ACTION_INDEX_NOTHING"]/*' />
    [NativeTypeName("#define POWERBUTTON_ACTION_INDEX_NOTHING 0")]
    public const int POWERBUTTON_ACTION_INDEX_NOTHING = 0;

    /// <include file='POWERBUTTON.xml' path='doc/member[@name="POWERBUTTON.POWERBUTTON_ACTION_INDEX_SLEEP"]/*' />
    [NativeTypeName("#define POWERBUTTON_ACTION_INDEX_SLEEP 1")]
    public const int POWERBUTTON_ACTION_INDEX_SLEEP = 1;

    /// <include file='POWERBUTTON.xml' path='doc/member[@name="POWERBUTTON.POWERBUTTON_ACTION_INDEX_HIBERNATE"]/*' />
    [NativeTypeName("#define POWERBUTTON_ACTION_INDEX_HIBERNATE 2")]
    public const int POWERBUTTON_ACTION_INDEX_HIBERNATE = 2;

    /// <include file='POWERBUTTON.xml' path='doc/member[@name="POWERBUTTON.POWERBUTTON_ACTION_INDEX_SHUTDOWN"]/*' />
    [NativeTypeName("#define POWERBUTTON_ACTION_INDEX_SHUTDOWN 3")]
    public const int POWERBUTTON_ACTION_INDEX_SHUTDOWN = 3;

    /// <include file='POWERBUTTON.xml' path='doc/member[@name="POWERBUTTON.POWERBUTTON_ACTION_INDEX_TURN_OFF_THE_DISPLAY"]/*' />
    [NativeTypeName("#define POWERBUTTON_ACTION_INDEX_TURN_OFF_THE_DISPLAY 4")]
    public const int POWERBUTTON_ACTION_INDEX_TURN_OFF_THE_DISPLAY = 4;

    /// <include file='POWERBUTTON.xml' path='doc/member[@name="POWERBUTTON.POWERBUTTON_ACTION_VALUE_NOTHING"]/*' />
    [NativeTypeName("#define POWERBUTTON_ACTION_VALUE_NOTHING 0")]
    public const int POWERBUTTON_ACTION_VALUE_NOTHING = 0;

    /// <include file='POWERBUTTON.xml' path='doc/member[@name="POWERBUTTON.POWERBUTTON_ACTION_VALUE_SLEEP"]/*' />
    [NativeTypeName("#define POWERBUTTON_ACTION_VALUE_SLEEP 2")]
    public const int POWERBUTTON_ACTION_VALUE_SLEEP = 2;

    /// <include file='POWERBUTTON.xml' path='doc/member[@name="POWERBUTTON.POWERBUTTON_ACTION_VALUE_HIBERNATE"]/*' />
    [NativeTypeName("#define POWERBUTTON_ACTION_VALUE_HIBERNATE 3")]
    public const int POWERBUTTON_ACTION_VALUE_HIBERNATE = 3;

    /// <include file='POWERBUTTON.xml' path='doc/member[@name="POWERBUTTON.POWERBUTTON_ACTION_VALUE_SHUTDOWN"]/*' />
    [NativeTypeName("#define POWERBUTTON_ACTION_VALUE_SHUTDOWN 6")]
    public const int POWERBUTTON_ACTION_VALUE_SHUTDOWN = 6;

    /// <include file='POWERBUTTON.xml' path='doc/member[@name="POWERBUTTON.POWERBUTTON_ACTION_VALUE_TURN_OFF_THE_DISPLAY"]/*' />
    [NativeTypeName("#define POWERBUTTON_ACTION_VALUE_TURN_OFF_THE_DISPLAY 8")]
    public const int POWERBUTTON_ACTION_VALUE_TURN_OFF_THE_DISPLAY = 8;
}
