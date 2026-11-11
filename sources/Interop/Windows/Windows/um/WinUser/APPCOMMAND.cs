// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class APPCOMMAND
{
    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_BROWSER_BACKWARD"]/*' />
    [NativeTypeName("#define APPCOMMAND_BROWSER_BACKWARD 1")]
    public const int APPCOMMAND_BROWSER_BACKWARD = 1;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_BROWSER_FORWARD"]/*' />
    [NativeTypeName("#define APPCOMMAND_BROWSER_FORWARD 2")]
    public const int APPCOMMAND_BROWSER_FORWARD = 2;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_BROWSER_REFRESH"]/*' />
    [NativeTypeName("#define APPCOMMAND_BROWSER_REFRESH 3")]
    public const int APPCOMMAND_BROWSER_REFRESH = 3;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_BROWSER_STOP"]/*' />
    [NativeTypeName("#define APPCOMMAND_BROWSER_STOP 4")]
    public const int APPCOMMAND_BROWSER_STOP = 4;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_BROWSER_SEARCH"]/*' />
    [NativeTypeName("#define APPCOMMAND_BROWSER_SEARCH 5")]
    public const int APPCOMMAND_BROWSER_SEARCH = 5;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_BROWSER_FAVORITES"]/*' />
    [NativeTypeName("#define APPCOMMAND_BROWSER_FAVORITES 6")]
    public const int APPCOMMAND_BROWSER_FAVORITES = 6;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_BROWSER_HOME"]/*' />
    [NativeTypeName("#define APPCOMMAND_BROWSER_HOME 7")]
    public const int APPCOMMAND_BROWSER_HOME = 7;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_VOLUME_MUTE"]/*' />
    [NativeTypeName("#define APPCOMMAND_VOLUME_MUTE 8")]
    public const int APPCOMMAND_VOLUME_MUTE = 8;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_VOLUME_DOWN"]/*' />
    [NativeTypeName("#define APPCOMMAND_VOLUME_DOWN 9")]
    public const int APPCOMMAND_VOLUME_DOWN = 9;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_VOLUME_UP"]/*' />
    [NativeTypeName("#define APPCOMMAND_VOLUME_UP 10")]
    public const int APPCOMMAND_VOLUME_UP = 10;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_MEDIA_NEXTTRACK"]/*' />
    [NativeTypeName("#define APPCOMMAND_MEDIA_NEXTTRACK 11")]
    public const int APPCOMMAND_MEDIA_NEXTTRACK = 11;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_MEDIA_PREVIOUSTRACK"]/*' />
    [NativeTypeName("#define APPCOMMAND_MEDIA_PREVIOUSTRACK 12")]
    public const int APPCOMMAND_MEDIA_PREVIOUSTRACK = 12;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_MEDIA_STOP"]/*' />
    [NativeTypeName("#define APPCOMMAND_MEDIA_STOP 13")]
    public const int APPCOMMAND_MEDIA_STOP = 13;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_MEDIA_PLAY_PAUSE"]/*' />
    [NativeTypeName("#define APPCOMMAND_MEDIA_PLAY_PAUSE 14")]
    public const int APPCOMMAND_MEDIA_PLAY_PAUSE = 14;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_LAUNCH_MAIL"]/*' />
    [NativeTypeName("#define APPCOMMAND_LAUNCH_MAIL 15")]
    public const int APPCOMMAND_LAUNCH_MAIL = 15;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_LAUNCH_MEDIA_SELECT"]/*' />
    [NativeTypeName("#define APPCOMMAND_LAUNCH_MEDIA_SELECT 16")]
    public const int APPCOMMAND_LAUNCH_MEDIA_SELECT = 16;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_LAUNCH_APP1"]/*' />
    [NativeTypeName("#define APPCOMMAND_LAUNCH_APP1 17")]
    public const int APPCOMMAND_LAUNCH_APP1 = 17;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_LAUNCH_APP2"]/*' />
    [NativeTypeName("#define APPCOMMAND_LAUNCH_APP2 18")]
    public const int APPCOMMAND_LAUNCH_APP2 = 18;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_BASS_DOWN"]/*' />
    [NativeTypeName("#define APPCOMMAND_BASS_DOWN 19")]
    public const int APPCOMMAND_BASS_DOWN = 19;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_BASS_BOOST"]/*' />
    [NativeTypeName("#define APPCOMMAND_BASS_BOOST 20")]
    public const int APPCOMMAND_BASS_BOOST = 20;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_BASS_UP"]/*' />
    [NativeTypeName("#define APPCOMMAND_BASS_UP 21")]
    public const int APPCOMMAND_BASS_UP = 21;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_TREBLE_DOWN"]/*' />
    [NativeTypeName("#define APPCOMMAND_TREBLE_DOWN 22")]
    public const int APPCOMMAND_TREBLE_DOWN = 22;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_TREBLE_UP"]/*' />
    [NativeTypeName("#define APPCOMMAND_TREBLE_UP 23")]
    public const int APPCOMMAND_TREBLE_UP = 23;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_MICROPHONE_VOLUME_MUTE"]/*' />
    [NativeTypeName("#define APPCOMMAND_MICROPHONE_VOLUME_MUTE 24")]
    public const int APPCOMMAND_MICROPHONE_VOLUME_MUTE = 24;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_MICROPHONE_VOLUME_DOWN"]/*' />
    [NativeTypeName("#define APPCOMMAND_MICROPHONE_VOLUME_DOWN 25")]
    public const int APPCOMMAND_MICROPHONE_VOLUME_DOWN = 25;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_MICROPHONE_VOLUME_UP"]/*' />
    [NativeTypeName("#define APPCOMMAND_MICROPHONE_VOLUME_UP 26")]
    public const int APPCOMMAND_MICROPHONE_VOLUME_UP = 26;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_HELP"]/*' />
    [NativeTypeName("#define APPCOMMAND_HELP 27")]
    public const int APPCOMMAND_HELP = 27;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_FIND"]/*' />
    [NativeTypeName("#define APPCOMMAND_FIND 28")]
    public const int APPCOMMAND_FIND = 28;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_NEW"]/*' />
    [NativeTypeName("#define APPCOMMAND_NEW 29")]
    public const int APPCOMMAND_NEW = 29;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_OPEN"]/*' />
    [NativeTypeName("#define APPCOMMAND_OPEN 30")]
    public const int APPCOMMAND_OPEN = 30;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_CLOSE"]/*' />
    [NativeTypeName("#define APPCOMMAND_CLOSE 31")]
    public const int APPCOMMAND_CLOSE = 31;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_SAVE"]/*' />
    [NativeTypeName("#define APPCOMMAND_SAVE 32")]
    public const int APPCOMMAND_SAVE = 32;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_PRINT"]/*' />
    [NativeTypeName("#define APPCOMMAND_PRINT 33")]
    public const int APPCOMMAND_PRINT = 33;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_UNDO"]/*' />
    [NativeTypeName("#define APPCOMMAND_UNDO 34")]
    public const int APPCOMMAND_UNDO = 34;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_REDO"]/*' />
    [NativeTypeName("#define APPCOMMAND_REDO 35")]
    public const int APPCOMMAND_REDO = 35;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_COPY"]/*' />
    [NativeTypeName("#define APPCOMMAND_COPY 36")]
    public const int APPCOMMAND_COPY = 36;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_CUT"]/*' />
    [NativeTypeName("#define APPCOMMAND_CUT 37")]
    public const int APPCOMMAND_CUT = 37;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_PASTE"]/*' />
    [NativeTypeName("#define APPCOMMAND_PASTE 38")]
    public const int APPCOMMAND_PASTE = 38;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_REPLY_TO_MAIL"]/*' />
    [NativeTypeName("#define APPCOMMAND_REPLY_TO_MAIL 39")]
    public const int APPCOMMAND_REPLY_TO_MAIL = 39;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_FORWARD_MAIL"]/*' />
    [NativeTypeName("#define APPCOMMAND_FORWARD_MAIL 40")]
    public const int APPCOMMAND_FORWARD_MAIL = 40;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_SEND_MAIL"]/*' />
    [NativeTypeName("#define APPCOMMAND_SEND_MAIL 41")]
    public const int APPCOMMAND_SEND_MAIL = 41;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_SPELL_CHECK"]/*' />
    [NativeTypeName("#define APPCOMMAND_SPELL_CHECK 42")]
    public const int APPCOMMAND_SPELL_CHECK = 42;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_DICTATE_OR_COMMAND_CONTROL_TOGGLE"]/*' />
    [NativeTypeName("#define APPCOMMAND_DICTATE_OR_COMMAND_CONTROL_TOGGLE 43")]
    public const int APPCOMMAND_DICTATE_OR_COMMAND_CONTROL_TOGGLE = 43;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_MIC_ON_OFF_TOGGLE"]/*' />
    [NativeTypeName("#define APPCOMMAND_MIC_ON_OFF_TOGGLE 44")]
    public const int APPCOMMAND_MIC_ON_OFF_TOGGLE = 44;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_CORRECTION_LIST"]/*' />
    [NativeTypeName("#define APPCOMMAND_CORRECTION_LIST 45")]
    public const int APPCOMMAND_CORRECTION_LIST = 45;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_MEDIA_PLAY"]/*' />
    [NativeTypeName("#define APPCOMMAND_MEDIA_PLAY 46")]
    public const int APPCOMMAND_MEDIA_PLAY = 46;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_MEDIA_PAUSE"]/*' />
    [NativeTypeName("#define APPCOMMAND_MEDIA_PAUSE 47")]
    public const int APPCOMMAND_MEDIA_PAUSE = 47;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_MEDIA_RECORD"]/*' />
    [NativeTypeName("#define APPCOMMAND_MEDIA_RECORD 48")]
    public const int APPCOMMAND_MEDIA_RECORD = 48;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_MEDIA_FAST_FORWARD"]/*' />
    [NativeTypeName("#define APPCOMMAND_MEDIA_FAST_FORWARD 49")]
    public const int APPCOMMAND_MEDIA_FAST_FORWARD = 49;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_MEDIA_REWIND"]/*' />
    [NativeTypeName("#define APPCOMMAND_MEDIA_REWIND 50")]
    public const int APPCOMMAND_MEDIA_REWIND = 50;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_MEDIA_CHANNEL_UP"]/*' />
    [NativeTypeName("#define APPCOMMAND_MEDIA_CHANNEL_UP 51")]
    public const int APPCOMMAND_MEDIA_CHANNEL_UP = 51;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_MEDIA_CHANNEL_DOWN"]/*' />
    [NativeTypeName("#define APPCOMMAND_MEDIA_CHANNEL_DOWN 52")]
    public const int APPCOMMAND_MEDIA_CHANNEL_DOWN = 52;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_DELETE"]/*' />
    [NativeTypeName("#define APPCOMMAND_DELETE 53")]
    public const int APPCOMMAND_DELETE = 53;

    /// <include file='APPCOMMAND.xml' path='doc/member[@name="APPCOMMAND.APPCOMMAND_DWM_FLIP3D"]/*' />
    [NativeTypeName("#define APPCOMMAND_DWM_FLIP3D 54")]
    public const int APPCOMMAND_DWM_FLIP3D = 54;
}
