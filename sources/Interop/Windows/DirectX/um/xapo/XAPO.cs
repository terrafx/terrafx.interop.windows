// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapo.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

public static partial class XAPO
{
    /// <include file='XAPO.xml' path='doc/member[@name="XAPO.XAPO_E_FORMAT_UNSUPPORTED"]/*' />
    [NativeTypeName("#define XAPO_E_FORMAT_UNSUPPORTED MAKE_HRESULT(SEVERITY_ERROR, FACILITY_XAPO, 0x01)")]
    public const int XAPO_E_FORMAT_UNSUPPORTED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x897) << 16) | ((uint)(0x01))));

    /// <include file='XAPO.xml' path='doc/member[@name="XAPO.XAPO_MIN_CHANNELS"]/*' />
    [NativeTypeName("#define XAPO_MIN_CHANNELS 1")]
    public const int XAPO_MIN_CHANNELS = 1;

    /// <include file='XAPO.xml' path='doc/member[@name="XAPO.XAPO_MAX_CHANNELS"]/*' />
    [NativeTypeName("#define XAPO_MAX_CHANNELS 64")]
    public const int XAPO_MAX_CHANNELS = 64;

    /// <include file='XAPO.xml' path='doc/member[@name="XAPO.XAPO_MIN_FRAMERATE"]/*' />
    [NativeTypeName("#define XAPO_MIN_FRAMERATE 1000")]
    public const int XAPO_MIN_FRAMERATE = 1000;

    /// <include file='XAPO.xml' path='doc/member[@name="XAPO.XAPO_MAX_FRAMERATE"]/*' />
    [NativeTypeName("#define XAPO_MAX_FRAMERATE 384000")]
    public const int XAPO_MAX_FRAMERATE = 384000;

    /// <include file='XAPO.xml' path='doc/member[@name="XAPO.XAPO_REGISTRATION_STRING_LENGTH"]/*' />
    [NativeTypeName("#define XAPO_REGISTRATION_STRING_LENGTH 256")]
    public const int XAPO_REGISTRATION_STRING_LENGTH = 256;

    /// <include file='XAPO.xml' path='doc/member[@name="XAPO.XAPO_FLAG_CHANNELS_MUST_MATCH"]/*' />
    [NativeTypeName("#define XAPO_FLAG_CHANNELS_MUST_MATCH 0x00000001")]
    public const int XAPO_FLAG_CHANNELS_MUST_MATCH = 0x00000001;

    /// <include file='XAPO.xml' path='doc/member[@name="XAPO.XAPO_FLAG_FRAMERATE_MUST_MATCH"]/*' />
    [NativeTypeName("#define XAPO_FLAG_FRAMERATE_MUST_MATCH 0x00000002")]
    public const int XAPO_FLAG_FRAMERATE_MUST_MATCH = 0x00000002;

    /// <include file='XAPO.xml' path='doc/member[@name="XAPO.XAPO_FLAG_BITSPERSAMPLE_MUST_MATCH"]/*' />
    [NativeTypeName("#define XAPO_FLAG_BITSPERSAMPLE_MUST_MATCH 0x00000004")]
    public const int XAPO_FLAG_BITSPERSAMPLE_MUST_MATCH = 0x00000004;

    /// <include file='XAPO.xml' path='doc/member[@name="XAPO.XAPO_FLAG_BUFFERCOUNT_MUST_MATCH"]/*' />
    [NativeTypeName("#define XAPO_FLAG_BUFFERCOUNT_MUST_MATCH 0x00000008")]
    public const int XAPO_FLAG_BUFFERCOUNT_MUST_MATCH = 0x00000008;

    /// <include file='XAPO.xml' path='doc/member[@name="XAPO.XAPO_FLAG_INPLACE_REQUIRED"]/*' />
    [NativeTypeName("#define XAPO_FLAG_INPLACE_REQUIRED 0x00000020")]
    public const int XAPO_FLAG_INPLACE_REQUIRED = 0x00000020;

    /// <include file='XAPO.xml' path='doc/member[@name="XAPO.XAPO_FLAG_INPLACE_SUPPORTED"]/*' />
    [NativeTypeName("#define XAPO_FLAG_INPLACE_SUPPORTED 0x00000010")]
    public const int XAPO_FLAG_INPLACE_SUPPORTED = 0x00000010;
}
