// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PERSISTENT
{
    /// <include file='PERSISTENT.xml' path='doc/member[@name="PERSISTENT.PERSISTENT_VOLUME_STATE_SHORT_NAME_CREATION_DISABLED"]/*' />
    [NativeTypeName("#define PERSISTENT_VOLUME_STATE_SHORT_NAME_CREATION_DISABLED (0x00000001)")]
    public const int PERSISTENT_VOLUME_STATE_SHORT_NAME_CREATION_DISABLED = (0x00000001);

    /// <include file='PERSISTENT.xml' path='doc/member[@name="PERSISTENT.PERSISTENT_VOLUME_STATE_VOLUME_SCRUB_DISABLED"]/*' />
    [NativeTypeName("#define PERSISTENT_VOLUME_STATE_VOLUME_SCRUB_DISABLED (0x00000002)")]
    public const int PERSISTENT_VOLUME_STATE_VOLUME_SCRUB_DISABLED = (0x00000002);

    /// <include file='PERSISTENT.xml' path='doc/member[@name="PERSISTENT.PERSISTENT_VOLUME_STATE_GLOBAL_METADATA_NO_SEEK_PENALTY"]/*' />
    [NativeTypeName("#define PERSISTENT_VOLUME_STATE_GLOBAL_METADATA_NO_SEEK_PENALTY (0x00000004)")]
    public const int PERSISTENT_VOLUME_STATE_GLOBAL_METADATA_NO_SEEK_PENALTY = (0x00000004);

    /// <include file='PERSISTENT.xml' path='doc/member[@name="PERSISTENT.PERSISTENT_VOLUME_STATE_LOCAL_METADATA_NO_SEEK_PENALTY"]/*' />
    [NativeTypeName("#define PERSISTENT_VOLUME_STATE_LOCAL_METADATA_NO_SEEK_PENALTY (0x00000008)")]
    public const int PERSISTENT_VOLUME_STATE_LOCAL_METADATA_NO_SEEK_PENALTY = (0x00000008);

    /// <include file='PERSISTENT.xml' path='doc/member[@name="PERSISTENT.PERSISTENT_VOLUME_STATE_NO_HEAT_GATHERING"]/*' />
    [NativeTypeName("#define PERSISTENT_VOLUME_STATE_NO_HEAT_GATHERING (0x00000010)")]
    public const int PERSISTENT_VOLUME_STATE_NO_HEAT_GATHERING = (0x00000010);

    /// <include file='PERSISTENT.xml' path='doc/member[@name="PERSISTENT.PERSISTENT_VOLUME_STATE_CONTAINS_BACKING_WIM"]/*' />
    [NativeTypeName("#define PERSISTENT_VOLUME_STATE_CONTAINS_BACKING_WIM (0x00000020)")]
    public const int PERSISTENT_VOLUME_STATE_CONTAINS_BACKING_WIM = (0x00000020);

    /// <include file='PERSISTENT.xml' path='doc/member[@name="PERSISTENT.PERSISTENT_VOLUME_STATE_BACKED_BY_WIM"]/*' />
    [NativeTypeName("#define PERSISTENT_VOLUME_STATE_BACKED_BY_WIM (0x00000040)")]
    public const int PERSISTENT_VOLUME_STATE_BACKED_BY_WIM = (0x00000040);

    /// <include file='PERSISTENT.xml' path='doc/member[@name="PERSISTENT.PERSISTENT_VOLUME_STATE_NO_WRITE_AUTO_TIERING"]/*' />
    [NativeTypeName("#define PERSISTENT_VOLUME_STATE_NO_WRITE_AUTO_TIERING (0x00000080)")]
    public const int PERSISTENT_VOLUME_STATE_NO_WRITE_AUTO_TIERING = (0x00000080);

    /// <include file='PERSISTENT.xml' path='doc/member[@name="PERSISTENT.PERSISTENT_VOLUME_STATE_TXF_DISABLED"]/*' />
    [NativeTypeName("#define PERSISTENT_VOLUME_STATE_TXF_DISABLED (0x00000100)")]
    public const int PERSISTENT_VOLUME_STATE_TXF_DISABLED = (0x00000100);

    /// <include file='PERSISTENT.xml' path='doc/member[@name="PERSISTENT.PERSISTENT_VOLUME_STATE_REALLOCATE_ALL_DATA_WRITES"]/*' />
    [NativeTypeName("#define PERSISTENT_VOLUME_STATE_REALLOCATE_ALL_DATA_WRITES (0x00000200)")]
    public const int PERSISTENT_VOLUME_STATE_REALLOCATE_ALL_DATA_WRITES = (0x00000200);

    /// <include file='PERSISTENT.xml' path='doc/member[@name="PERSISTENT.PERSISTENT_VOLUME_STATE_CHKDSK_RAN_ONCE"]/*' />
    [NativeTypeName("#define PERSISTENT_VOLUME_STATE_CHKDSK_RAN_ONCE (0x00000400)")]
    public const int PERSISTENT_VOLUME_STATE_CHKDSK_RAN_ONCE = (0x00000400);

    /// <include file='PERSISTENT.xml' path='doc/member[@name="PERSISTENT.PERSISTENT_VOLUME_STATE_MODIFIED_BY_CHKDSK"]/*' />
    [NativeTypeName("#define PERSISTENT_VOLUME_STATE_MODIFIED_BY_CHKDSK (0x00000800)")]
    public const int PERSISTENT_VOLUME_STATE_MODIFIED_BY_CHKDSK = (0x00000800);

    /// <include file='PERSISTENT.xml' path='doc/member[@name="PERSISTENT.PERSISTENT_VOLUME_STATE_DAX_FORMATTED"]/*' />
    [NativeTypeName("#define PERSISTENT_VOLUME_STATE_DAX_FORMATTED (0x00001000)")]
    public const int PERSISTENT_VOLUME_STATE_DAX_FORMATTED = (0x00001000);

    /// <include file='PERSISTENT.xml' path='doc/member[@name="PERSISTENT.PERSISTENT_VOLUME_STATE_DEV_VOLUME"]/*' />
    [NativeTypeName("#define PERSISTENT_VOLUME_STATE_DEV_VOLUME (0x00002000)")]
    public const int PERSISTENT_VOLUME_STATE_DEV_VOLUME = (0x00002000);

    /// <include file='PERSISTENT.xml' path='doc/member[@name="PERSISTENT.PERSISTENT_VOLUME_STATE_TRUSTED_VOLUME"]/*' />
    [NativeTypeName("#define PERSISTENT_VOLUME_STATE_TRUSTED_VOLUME (0x00004000)")]
    public const int PERSISTENT_VOLUME_STATE_TRUSTED_VOLUME = (0x00004000);
}
