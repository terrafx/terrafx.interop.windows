// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DVD
{
    /// <include file='DVD.xml' path='doc/member[@name="DVD.DVD_TITLE_MENU"]/*' />
    [NativeTypeName("#define DVD_TITLE_MENU 0x000")]
    public const int DVD_TITLE_MENU = 0x000;

    /// <include file='DVD.xml' path='doc/member[@name="DVD.DVD_STREAM_DATA_CURRENT"]/*' />
    [NativeTypeName("#define DVD_STREAM_DATA_CURRENT 0x800")]
    public const int DVD_STREAM_DATA_CURRENT = 0x800;

    /// <include file='DVD.xml' path='doc/member[@name="DVD.DVD_STREAM_DATA_VMGM"]/*' />
    [NativeTypeName("#define DVD_STREAM_DATA_VMGM 0x400")]
    public const int DVD_STREAM_DATA_VMGM = 0x400;

    /// <include file='DVD.xml' path='doc/member[@name="DVD.DVD_STREAM_DATA_VTSM"]/*' />
    [NativeTypeName("#define DVD_STREAM_DATA_VTSM 0x401")]
    public const int DVD_STREAM_DATA_VTSM = 0x401;

    /// <include file='DVD.xml' path='doc/member[@name="DVD.DVD_DEFAULT_AUDIO_STREAM"]/*' />
    [NativeTypeName("#define DVD_DEFAULT_AUDIO_STREAM 0x0f")]
    public const int DVD_DEFAULT_AUDIO_STREAM = 0x0f;

    /// <include file='DVD.xml' path='doc/member[@name="DVD.DVD_AUDIO_CAPS_AC3"]/*' />
    [NativeTypeName("#define DVD_AUDIO_CAPS_AC3 0x00000001")]
    public const int DVD_AUDIO_CAPS_AC3 = 0x00000001;

    /// <include file='DVD.xml' path='doc/member[@name="DVD.DVD_AUDIO_CAPS_MPEG2"]/*' />
    [NativeTypeName("#define DVD_AUDIO_CAPS_MPEG2 0x00000002")]
    public const int DVD_AUDIO_CAPS_MPEG2 = 0x00000002;

    /// <include file='DVD.xml' path='doc/member[@name="DVD.DVD_AUDIO_CAPS_LPCM"]/*' />
    [NativeTypeName("#define DVD_AUDIO_CAPS_LPCM 0x00000004")]
    public const int DVD_AUDIO_CAPS_LPCM = 0x00000004;

    /// <include file='DVD.xml' path='doc/member[@name="DVD.DVD_AUDIO_CAPS_DTS"]/*' />
    [NativeTypeName("#define DVD_AUDIO_CAPS_DTS 0x00000008")]
    public const int DVD_AUDIO_CAPS_DTS = 0x00000008;

    /// <include file='DVD.xml' path='doc/member[@name="DVD.DVD_AUDIO_CAPS_SDDS"]/*' />
    [NativeTypeName("#define DVD_AUDIO_CAPS_SDDS 0x00000010")]
    public const int DVD_AUDIO_CAPS_SDDS = 0x00000010;
}
