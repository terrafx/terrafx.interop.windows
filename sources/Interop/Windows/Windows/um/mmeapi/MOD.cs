// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MOD
{
    /// <include file='MOD.xml' path='doc/member[@name="MOD.MOD_MIDIPORT"]/*' />
    [NativeTypeName("#define MOD_MIDIPORT 1")]
    public const int MOD_MIDIPORT = 1;

    /// <include file='MOD.xml' path='doc/member[@name="MOD.MOD_SYNTH"]/*' />
    [NativeTypeName("#define MOD_SYNTH 2")]
    public const int MOD_SYNTH = 2;

    /// <include file='MOD.xml' path='doc/member[@name="MOD.MOD_SQSYNTH"]/*' />
    [NativeTypeName("#define MOD_SQSYNTH 3")]
    public const int MOD_SQSYNTH = 3;

    /// <include file='MOD.xml' path='doc/member[@name="MOD.MOD_FMSYNTH"]/*' />
    [NativeTypeName("#define MOD_FMSYNTH 4")]
    public const int MOD_FMSYNTH = 4;

    /// <include file='MOD.xml' path='doc/member[@name="MOD.MOD_MAPPER"]/*' />
    [NativeTypeName("#define MOD_MAPPER 5")]
    public const int MOD_MAPPER = 5;

    /// <include file='MOD.xml' path='doc/member[@name="MOD.MOD_WAVETABLE"]/*' />
    [NativeTypeName("#define MOD_WAVETABLE 6")]
    public const int MOD_WAVETABLE = 6;

    /// <include file='MOD.xml' path='doc/member[@name="MOD.MOD_SWSYNTH"]/*' />
    [NativeTypeName("#define MOD_SWSYNTH 7")]
    public const int MOD_SWSYNTH = 7;
}
