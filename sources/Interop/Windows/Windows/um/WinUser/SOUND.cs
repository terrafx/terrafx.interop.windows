// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SOUND
{
    /// <include file='SOUND.xml' path='doc/member[@name="SOUND.SOUND_SYSTEM_STARTUP"]/*' />
    [NativeTypeName("#define SOUND_SYSTEM_STARTUP 1")]
    public const int SOUND_SYSTEM_STARTUP = 1;

    /// <include file='SOUND.xml' path='doc/member[@name="SOUND.SOUND_SYSTEM_SHUTDOWN"]/*' />
    [NativeTypeName("#define SOUND_SYSTEM_SHUTDOWN 2")]
    public const int SOUND_SYSTEM_SHUTDOWN = 2;

    /// <include file='SOUND.xml' path='doc/member[@name="SOUND.SOUND_SYSTEM_BEEP"]/*' />
    [NativeTypeName("#define SOUND_SYSTEM_BEEP 3")]
    public const int SOUND_SYSTEM_BEEP = 3;

    /// <include file='SOUND.xml' path='doc/member[@name="SOUND.SOUND_SYSTEM_ERROR"]/*' />
    [NativeTypeName("#define SOUND_SYSTEM_ERROR 4")]
    public const int SOUND_SYSTEM_ERROR = 4;

    /// <include file='SOUND.xml' path='doc/member[@name="SOUND.SOUND_SYSTEM_QUESTION"]/*' />
    [NativeTypeName("#define SOUND_SYSTEM_QUESTION 5")]
    public const int SOUND_SYSTEM_QUESTION = 5;

    /// <include file='SOUND.xml' path='doc/member[@name="SOUND.SOUND_SYSTEM_WARNING"]/*' />
    [NativeTypeName("#define SOUND_SYSTEM_WARNING 6")]
    public const int SOUND_SYSTEM_WARNING = 6;

    /// <include file='SOUND.xml' path='doc/member[@name="SOUND.SOUND_SYSTEM_INFORMATION"]/*' />
    [NativeTypeName("#define SOUND_SYSTEM_INFORMATION 7")]
    public const int SOUND_SYSTEM_INFORMATION = 7;

    /// <include file='SOUND.xml' path='doc/member[@name="SOUND.SOUND_SYSTEM_MAXIMIZE"]/*' />
    [NativeTypeName("#define SOUND_SYSTEM_MAXIMIZE 8")]
    public const int SOUND_SYSTEM_MAXIMIZE = 8;

    /// <include file='SOUND.xml' path='doc/member[@name="SOUND.SOUND_SYSTEM_MINIMIZE"]/*' />
    [NativeTypeName("#define SOUND_SYSTEM_MINIMIZE 9")]
    public const int SOUND_SYSTEM_MINIMIZE = 9;

    /// <include file='SOUND.xml' path='doc/member[@name="SOUND.SOUND_SYSTEM_RESTOREUP"]/*' />
    [NativeTypeName("#define SOUND_SYSTEM_RESTOREUP 10")]
    public const int SOUND_SYSTEM_RESTOREUP = 10;

    /// <include file='SOUND.xml' path='doc/member[@name="SOUND.SOUND_SYSTEM_RESTOREDOWN"]/*' />
    [NativeTypeName("#define SOUND_SYSTEM_RESTOREDOWN 11")]
    public const int SOUND_SYSTEM_RESTOREDOWN = 11;

    /// <include file='SOUND.xml' path='doc/member[@name="SOUND.SOUND_SYSTEM_APPSTART"]/*' />
    [NativeTypeName("#define SOUND_SYSTEM_APPSTART 12")]
    public const int SOUND_SYSTEM_APPSTART = 12;

    /// <include file='SOUND.xml' path='doc/member[@name="SOUND.SOUND_SYSTEM_FAULT"]/*' />
    [NativeTypeName("#define SOUND_SYSTEM_FAULT 13")]
    public const int SOUND_SYSTEM_FAULT = 13;

    /// <include file='SOUND.xml' path='doc/member[@name="SOUND.SOUND_SYSTEM_APPEND"]/*' />
    [NativeTypeName("#define SOUND_SYSTEM_APPEND 14")]
    public const int SOUND_SYSTEM_APPEND = 14;

    /// <include file='SOUND.xml' path='doc/member[@name="SOUND.SOUND_SYSTEM_MENUCOMMAND"]/*' />
    [NativeTypeName("#define SOUND_SYSTEM_MENUCOMMAND 15")]
    public const int SOUND_SYSTEM_MENUCOMMAND = 15;

    /// <include file='SOUND.xml' path='doc/member[@name="SOUND.SOUND_SYSTEM_MENUPOPUP"]/*' />
    [NativeTypeName("#define SOUND_SYSTEM_MENUPOPUP 16")]
    public const int SOUND_SYSTEM_MENUPOPUP = 16;
}
