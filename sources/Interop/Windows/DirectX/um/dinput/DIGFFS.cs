// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DIGFFS
{
    /// <include file='DIGFFS.xml' path='doc/member[@name="DIGFFS.DIGFFS_EMPTY"]/*' />
    [NativeTypeName("#define DIGFFS_EMPTY 0x00000001")]
    public const int DIGFFS_EMPTY = 0x00000001;

    /// <include file='DIGFFS.xml' path='doc/member[@name="DIGFFS.DIGFFS_STOPPED"]/*' />
    [NativeTypeName("#define DIGFFS_STOPPED 0x00000002")]
    public const int DIGFFS_STOPPED = 0x00000002;

    /// <include file='DIGFFS.xml' path='doc/member[@name="DIGFFS.DIGFFS_PAUSED"]/*' />
    [NativeTypeName("#define DIGFFS_PAUSED 0x00000004")]
    public const int DIGFFS_PAUSED = 0x00000004;

    /// <include file='DIGFFS.xml' path='doc/member[@name="DIGFFS.DIGFFS_ACTUATORSON"]/*' />
    [NativeTypeName("#define DIGFFS_ACTUATORSON 0x00000010")]
    public const int DIGFFS_ACTUATORSON = 0x00000010;

    /// <include file='DIGFFS.xml' path='doc/member[@name="DIGFFS.DIGFFS_ACTUATORSOFF"]/*' />
    [NativeTypeName("#define DIGFFS_ACTUATORSOFF 0x00000020")]
    public const int DIGFFS_ACTUATORSOFF = 0x00000020;

    /// <include file='DIGFFS.xml' path='doc/member[@name="DIGFFS.DIGFFS_POWERON"]/*' />
    [NativeTypeName("#define DIGFFS_POWERON 0x00000040")]
    public const int DIGFFS_POWERON = 0x00000040;

    /// <include file='DIGFFS.xml' path='doc/member[@name="DIGFFS.DIGFFS_POWEROFF"]/*' />
    [NativeTypeName("#define DIGFFS_POWEROFF 0x00000080")]
    public const int DIGFFS_POWEROFF = 0x00000080;

    /// <include file='DIGFFS.xml' path='doc/member[@name="DIGFFS.DIGFFS_SAFETYSWITCHON"]/*' />
    [NativeTypeName("#define DIGFFS_SAFETYSWITCHON 0x00000100")]
    public const int DIGFFS_SAFETYSWITCHON = 0x00000100;

    /// <include file='DIGFFS.xml' path='doc/member[@name="DIGFFS.DIGFFS_SAFETYSWITCHOFF"]/*' />
    [NativeTypeName("#define DIGFFS_SAFETYSWITCHOFF 0x00000200")]
    public const int DIGFFS_SAFETYSWITCHOFF = 0x00000200;

    /// <include file='DIGFFS.xml' path='doc/member[@name="DIGFFS.DIGFFS_USERFFSWITCHON"]/*' />
    [NativeTypeName("#define DIGFFS_USERFFSWITCHON 0x00000400")]
    public const int DIGFFS_USERFFSWITCHON = 0x00000400;

    /// <include file='DIGFFS.xml' path='doc/member[@name="DIGFFS.DIGFFS_USERFFSWITCHOFF"]/*' />
    [NativeTypeName("#define DIGFFS_USERFFSWITCHOFF 0x00000800")]
    public const int DIGFFS_USERFFSWITCHOFF = 0x00000800;

    /// <include file='DIGFFS.xml' path='doc/member[@name="DIGFFS.DIGFFS_DEVICELOST"]/*' />
    [NativeTypeName("#define DIGFFS_DEVICELOST 0x80000000")]
    public const uint DIGFFS_DEVICELOST = 0x80000000;
}
