// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmsyscom.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TIME
{
    /// <include file='TIME.xml' path='doc/member[@name="TIME.TIME_MS"]/*' />
    [NativeTypeName("#define TIME_MS 0x0001")]
    public const int TIME_MS = 0x0001;

    /// <include file='TIME.xml' path='doc/member[@name="TIME.TIME_SAMPLES"]/*' />
    [NativeTypeName("#define TIME_SAMPLES 0x0002")]
    public const int TIME_SAMPLES = 0x0002;

    /// <include file='TIME.xml' path='doc/member[@name="TIME.TIME_BYTES"]/*' />
    [NativeTypeName("#define TIME_BYTES 0x0004")]
    public const int TIME_BYTES = 0x0004;

    /// <include file='TIME.xml' path='doc/member[@name="TIME.TIME_SMPTE"]/*' />
    [NativeTypeName("#define TIME_SMPTE 0x0008")]
    public const int TIME_SMPTE = 0x0008;

    /// <include file='TIME.xml' path='doc/member[@name="TIME.TIME_MIDI"]/*' />
    [NativeTypeName("#define TIME_MIDI 0x0010")]
    public const int TIME_MIDI = 0x0010;

    /// <include file='TIME.xml' path='doc/member[@name="TIME.TIME_TICKS"]/*' />
    [NativeTypeName("#define TIME_TICKS 0x0020")]
    public const int TIME_TICKS = 0x0020;
}
