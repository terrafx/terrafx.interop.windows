// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WAVE
{
    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_MAPPER"]/*' />
    [NativeTypeName("#define WAVE_MAPPER ((UINT)-1)")]
    public const uint WAVE_MAPPER = unchecked((uint)(-1));

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_QUERY"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_QUERY 0x0001")]
    public const int WAVE_FORMAT_QUERY = 0x0001;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_ALLOWSYNC"]/*' />
    [NativeTypeName("#define WAVE_ALLOWSYNC 0x0002")]
    public const int WAVE_ALLOWSYNC = 0x0002;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_MAPPED"]/*' />
    [NativeTypeName("#define WAVE_MAPPED 0x0004")]
    public const int WAVE_MAPPED = 0x0004;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_DIRECT"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_DIRECT 0x0008")]
    public const int WAVE_FORMAT_DIRECT = 0x0008;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_DIRECT_QUERY"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_DIRECT_QUERY (WAVE_FORMAT_QUERY | WAVE_FORMAT_DIRECT)")]
    public const int WAVE_FORMAT_DIRECT_QUERY = (0x0001 | 0x0008);

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_MAPPED_DEFAULT_COMMUNICATION_DEVICE"]/*' />
    [NativeTypeName("#define WAVE_MAPPED_DEFAULT_COMMUNICATION_DEVICE 0x0010")]
    public const int WAVE_MAPPED_DEFAULT_COMMUNICATION_DEVICE = 0x0010;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_INVALIDFORMAT"]/*' />
    [NativeTypeName("#define WAVE_INVALIDFORMAT 0x00000000")]
    public const int WAVE_INVALIDFORMAT = 0x00000000;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_1M08"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_1M08 0x00000001")]
    public const int WAVE_FORMAT_1M08 = 0x00000001;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_1S08"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_1S08 0x00000002")]
    public const int WAVE_FORMAT_1S08 = 0x00000002;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_1M16"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_1M16 0x00000004")]
    public const int WAVE_FORMAT_1M16 = 0x00000004;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_1S16"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_1S16 0x00000008")]
    public const int WAVE_FORMAT_1S16 = 0x00000008;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_2M08"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_2M08 0x00000010")]
    public const int WAVE_FORMAT_2M08 = 0x00000010;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_2S08"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_2S08 0x00000020")]
    public const int WAVE_FORMAT_2S08 = 0x00000020;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_2M16"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_2M16 0x00000040")]
    public const int WAVE_FORMAT_2M16 = 0x00000040;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_2S16"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_2S16 0x00000080")]
    public const int WAVE_FORMAT_2S16 = 0x00000080;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_4M08"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_4M08 0x00000100")]
    public const int WAVE_FORMAT_4M08 = 0x00000100;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_4S08"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_4S08 0x00000200")]
    public const int WAVE_FORMAT_4S08 = 0x00000200;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_4M16"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_4M16 0x00000400")]
    public const int WAVE_FORMAT_4M16 = 0x00000400;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_4S16"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_4S16 0x00000800")]
    public const int WAVE_FORMAT_4S16 = 0x00000800;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_44M08"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_44M08 0x00000100")]
    public const int WAVE_FORMAT_44M08 = 0x00000100;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_44S08"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_44S08 0x00000200")]
    public const int WAVE_FORMAT_44S08 = 0x00000200;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_44M16"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_44M16 0x00000400")]
    public const int WAVE_FORMAT_44M16 = 0x00000400;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_44S16"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_44S16 0x00000800")]
    public const int WAVE_FORMAT_44S16 = 0x00000800;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_48M08"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_48M08 0x00001000")]
    public const int WAVE_FORMAT_48M08 = 0x00001000;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_48S08"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_48S08 0x00002000")]
    public const int WAVE_FORMAT_48S08 = 0x00002000;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_48M16"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_48M16 0x00004000")]
    public const int WAVE_FORMAT_48M16 = 0x00004000;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_48S16"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_48S16 0x00008000")]
    public const int WAVE_FORMAT_48S16 = 0x00008000;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_96M08"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_96M08 0x00010000")]
    public const int WAVE_FORMAT_96M08 = 0x00010000;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_96S08"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_96S08 0x00020000")]
    public const int WAVE_FORMAT_96S08 = 0x00020000;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_96M16"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_96M16 0x00040000")]
    public const int WAVE_FORMAT_96M16 = 0x00040000;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_96S16"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_96S16 0x00080000")]
    public const int WAVE_FORMAT_96S16 = 0x00080000;

    /// <include file='WAVE.xml' path='doc/member[@name="WAVE.WAVE_FORMAT_PCM"]/*' />
    [NativeTypeName("#define WAVE_FORMAT_PCM 1")]
    public const int WAVE_FORMAT_PCM = 1;
}
