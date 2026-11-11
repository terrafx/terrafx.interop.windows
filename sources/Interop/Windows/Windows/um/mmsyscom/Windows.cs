// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmsyscom.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MAXPNAMELEN"]/*' />
    [NativeTypeName("#define MAXPNAMELEN 32")]
    public const int MAXPNAMELEN = 32;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MAXERRORLENGTH"]/*' />
    [NativeTypeName("#define MAXERRORLENGTH 256")]
    public const int MAXERRORLENGTH = 256;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WAVERR_BASE"]/*' />
    [NativeTypeName("#define WAVERR_BASE 32")]
    public const int WAVERR_BASE = 32;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.TIMERR_BASE"]/*' />
    [NativeTypeName("#define TIMERR_BASE 96")]
    public const int TIMERR_BASE = 96;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.JOYERR_BASE"]/*' />
    [NativeTypeName("#define JOYERR_BASE 160")]
    public const int JOYERR_BASE = 160;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCIERR_BASE"]/*' />
    [NativeTypeName("#define MCIERR_BASE 256")]
    public const int MCIERR_BASE = 256;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MIXERR_BASE"]/*' />
    [NativeTypeName("#define MIXERR_BASE 1024")]
    public const int MIXERR_BASE = 1024;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCI_STRING_OFFSET"]/*' />
    [NativeTypeName("#define MCI_STRING_OFFSET 512")]
    public const int MCI_STRING_OFFSET = 512;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCI_VD_OFFSET"]/*' />
    [NativeTypeName("#define MCI_VD_OFFSET 1024")]
    public const int MCI_VD_OFFSET = 1024;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCI_CD_OFFSET"]/*' />
    [NativeTypeName("#define MCI_CD_OFFSET 1088")]
    public const int MCI_CD_OFFSET = 1088;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCI_WAVE_OFFSET"]/*' />
    [NativeTypeName("#define MCI_WAVE_OFFSET 1152")]
    public const int MCI_WAVE_OFFSET = 1152;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MCI_SEQ_OFFSET"]/*' />
    [NativeTypeName("#define MCI_SEQ_OFFSET 1216")]
    public const int MCI_SEQ_OFFSET = 1216;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CALLBACK_TYPEMASK"]/*' />
    [NativeTypeName("#define CALLBACK_TYPEMASK 0x00070000l")]
    public const int CALLBACK_TYPEMASK = 0x00070000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CALLBACK_NULL"]/*' />
    [NativeTypeName("#define CALLBACK_NULL 0x00000000l")]
    public const int CALLBACK_NULL = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CALLBACK_WINDOW"]/*' />
    [NativeTypeName("#define CALLBACK_WINDOW 0x00010000l")]
    public const int CALLBACK_WINDOW = 0x00010000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CALLBACK_TASK"]/*' />
    [NativeTypeName("#define CALLBACK_TASK 0x00020000l")]
    public const int CALLBACK_TASK = 0x00020000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CALLBACK_FUNCTION"]/*' />
    [NativeTypeName("#define CALLBACK_FUNCTION 0x00030000l")]
    public const int CALLBACK_FUNCTION = 0x00030000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CALLBACK_THREAD"]/*' />
    [NativeTypeName("#define CALLBACK_THREAD (CALLBACK_TASK)")]
    public const int CALLBACK_THREAD = (0x00020000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CALLBACK_EVENT"]/*' />
    [NativeTypeName("#define CALLBACK_EVENT 0x00050000l")]
    public const int CALLBACK_EVENT = 0x00050000;
}
