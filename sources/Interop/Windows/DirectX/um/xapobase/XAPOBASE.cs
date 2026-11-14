// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapobase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class XAPOBASE
{
    /// <include file='XAPOBASE.xml' path='doc/member[@name="XAPOBASE.XAPOBASE_DEFAULT_FORMAT_TAG"]/*' />
    [NativeTypeName("#define XAPOBASE_DEFAULT_FORMAT_TAG WAVE_FORMAT_IEEE_FLOAT")]
    public const int XAPOBASE_DEFAULT_FORMAT_TAG = 0x0003;

    /// <include file='XAPOBASE.xml' path='doc/member[@name="XAPOBASE.XAPOBASE_DEFAULT_FORMAT_MIN_CHANNELS"]/*' />
    [NativeTypeName("#define XAPOBASE_DEFAULT_FORMAT_MIN_CHANNELS XAPO_MIN_CHANNELS")]
    public const int XAPOBASE_DEFAULT_FORMAT_MIN_CHANNELS = 1;

    /// <include file='XAPOBASE.xml' path='doc/member[@name="XAPOBASE.XAPOBASE_DEFAULT_FORMAT_MAX_CHANNELS"]/*' />
    [NativeTypeName("#define XAPOBASE_DEFAULT_FORMAT_MAX_CHANNELS XAPO_MAX_CHANNELS")]
    public const int XAPOBASE_DEFAULT_FORMAT_MAX_CHANNELS = 64;

    /// <include file='XAPOBASE.xml' path='doc/member[@name="XAPOBASE.XAPOBASE_DEFAULT_FORMAT_MIN_FRAMERATE"]/*' />
    [NativeTypeName("#define XAPOBASE_DEFAULT_FORMAT_MIN_FRAMERATE XAPO_MIN_FRAMERATE")]
    public const int XAPOBASE_DEFAULT_FORMAT_MIN_FRAMERATE = 1000;

    /// <include file='XAPOBASE.xml' path='doc/member[@name="XAPOBASE.XAPOBASE_DEFAULT_FORMAT_MAX_FRAMERATE"]/*' />
    [NativeTypeName("#define XAPOBASE_DEFAULT_FORMAT_MAX_FRAMERATE XAPO_MAX_FRAMERATE")]
    public const int XAPOBASE_DEFAULT_FORMAT_MAX_FRAMERATE = 384000;

    /// <include file='XAPOBASE.xml' path='doc/member[@name="XAPOBASE.XAPOBASE_DEFAULT_FORMAT_BITSPERSAMPLE"]/*' />
    [NativeTypeName("#define XAPOBASE_DEFAULT_FORMAT_BITSPERSAMPLE 32")]
    public const int XAPOBASE_DEFAULT_FORMAT_BITSPERSAMPLE = 32;

    /// <include file='XAPOBASE.xml' path='doc/member[@name="XAPOBASE.XAPOBASE_DEFAULT_FLAG"]/*' />
    [NativeTypeName("#define XAPOBASE_DEFAULT_FLAG (XAPO_FLAG_CHANNELS_MUST_MATCH | XAPO_FLAG_FRAMERATE_MUST_MATCH | XAPO_FLAG_BITSPERSAMPLE_MUST_MATCH | XAPO_FLAG_BUFFERCOUNT_MUST_MATCH | XAPO_FLAG_INPLACE_SUPPORTED)")]
    public const int XAPOBASE_DEFAULT_FLAG = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008 | 0x00000010);

    /// <include file='XAPOBASE.xml' path='doc/member[@name="XAPOBASE.XAPOBASE_DEFAULT_BUFFER_COUNT"]/*' />
    [NativeTypeName("#define XAPOBASE_DEFAULT_BUFFER_COUNT 1")]
    public const int XAPOBASE_DEFAULT_BUFFER_COUNT = 1;
}
