// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class IO
{
    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_RESERVED_ZERO"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_RESERVED_ZERO (0)")]
    public const int IO_REPARSE_TAG_RESERVED_ZERO = (0);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_RESERVED_ONE"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_RESERVED_ONE (1)")]
    public const int IO_REPARSE_TAG_RESERVED_ONE = (1);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_RESERVED_TWO"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_RESERVED_TWO (2)")]
    public const int IO_REPARSE_TAG_RESERVED_TWO = (2);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_RESERVED_RANGE"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_RESERVED_RANGE IO_REPARSE_TAG_RESERVED_TWO")]
    public const int IO_REPARSE_TAG_RESERVED_RANGE = (2);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_RESERVED_INVALID"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_RESERVED_INVALID (0xC0008000L)")]
    public const uint IO_REPARSE_TAG_RESERVED_INVALID = (0xC0008000);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_MOUNT_POINT"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_MOUNT_POINT (0xA0000003L)")]
    public const uint IO_REPARSE_TAG_MOUNT_POINT = (0xA0000003);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_HSM"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_HSM (0xC0000004L)")]
    public const uint IO_REPARSE_TAG_HSM = (0xC0000004);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_HSM2"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_HSM2 (0x80000006L)")]
    public const uint IO_REPARSE_TAG_HSM2 = (0x80000006);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_SIS"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_SIS (0x80000007L)")]
    public const uint IO_REPARSE_TAG_SIS = (0x80000007);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_WIM"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_WIM (0x80000008L)")]
    public const uint IO_REPARSE_TAG_WIM = (0x80000008);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_CSV"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_CSV (0x80000009L)")]
    public const uint IO_REPARSE_TAG_CSV = (0x80000009);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_DFS"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_DFS (0x8000000AL)")]
    public const uint IO_REPARSE_TAG_DFS = (0x8000000A);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_SYMLINK"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_SYMLINK (0xA000000CL)")]
    public const uint IO_REPARSE_TAG_SYMLINK = (0xA000000C);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_DFSR"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_DFSR (0x80000012L)")]
    public const uint IO_REPARSE_TAG_DFSR = (0x80000012);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_DEDUP"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_DEDUP (0x80000013L)")]
    public const uint IO_REPARSE_TAG_DEDUP = (0x80000013);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_NFS"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_NFS (0x80000014L)")]
    public const uint IO_REPARSE_TAG_NFS = (0x80000014);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_FILE_PLACEHOLDER"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_FILE_PLACEHOLDER (0x80000015L)")]
    public const uint IO_REPARSE_TAG_FILE_PLACEHOLDER = (0x80000015);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_WOF"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_WOF (0x80000017L)")]
    public const uint IO_REPARSE_TAG_WOF = (0x80000017);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_WCI"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_WCI (0x80000018L)")]
    public const uint IO_REPARSE_TAG_WCI = (0x80000018);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_WCI_1"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_WCI_1 (0x90001018L)")]
    public const uint IO_REPARSE_TAG_WCI_1 = (0x90001018);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_GLOBAL_REPARSE"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_GLOBAL_REPARSE (0xA0000019L)")]
    public const uint IO_REPARSE_TAG_GLOBAL_REPARSE = (0xA0000019);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_CLOUD"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD (0x9000001AL)")]
    public const uint IO_REPARSE_TAG_CLOUD = (0x9000001A);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_CLOUD_1"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_1 (0x9000101AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_1 = (0x9000101A);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_CLOUD_2"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_2 (0x9000201AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_2 = (0x9000201A);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_CLOUD_3"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_3 (0x9000301AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_3 = (0x9000301A);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_CLOUD_4"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_4 (0x9000401AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_4 = (0x9000401A);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_CLOUD_5"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_5 (0x9000501AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_5 = (0x9000501A);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_CLOUD_6"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_6 (0x9000601AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_6 = (0x9000601A);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_CLOUD_7"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_7 (0x9000701AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_7 = (0x9000701A);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_CLOUD_8"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_8 (0x9000801AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_8 = (0x9000801A);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_CLOUD_9"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_9 (0x9000901AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_9 = (0x9000901A);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_CLOUD_A"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_A (0x9000A01AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_A = (0x9000A01A);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_CLOUD_B"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_B (0x9000B01AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_B = (0x9000B01A);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_CLOUD_C"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_C (0x9000C01AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_C = (0x9000C01A);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_CLOUD_D"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_D (0x9000D01AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_D = (0x9000D01A);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_CLOUD_E"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_E (0x9000E01AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_E = (0x9000E01A);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_CLOUD_F"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_F (0x9000F01AL)")]
    public const uint IO_REPARSE_TAG_CLOUD_F = (0x9000F01A);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_CLOUD_MASK"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_CLOUD_MASK (0x0000F000L)")]
    public const int IO_REPARSE_TAG_CLOUD_MASK = (0x0000F000);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_APPEXECLINK"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_APPEXECLINK (0x8000001BL)")]
    public const uint IO_REPARSE_TAG_APPEXECLINK = (0x8000001B);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_PROJFS"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_PROJFS (0x9000001CL)")]
    public const uint IO_REPARSE_TAG_PROJFS = (0x9000001C);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_STORAGE_SYNC"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_STORAGE_SYNC (0x8000001EL)")]
    public const uint IO_REPARSE_TAG_STORAGE_SYNC = (0x8000001E);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_WCI_TOMBSTONE"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_WCI_TOMBSTONE (0xA000001FL)")]
    public const uint IO_REPARSE_TAG_WCI_TOMBSTONE = (0xA000001F);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_UNHANDLED"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_UNHANDLED (0x80000020L)")]
    public const uint IO_REPARSE_TAG_UNHANDLED = (0x80000020);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_ONEDRIVE"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_ONEDRIVE (0x80000021L)")]
    public const uint IO_REPARSE_TAG_ONEDRIVE = (0x80000021);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_PROJFS_TOMBSTONE"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_PROJFS_TOMBSTONE (0xA0000022L)")]
    public const uint IO_REPARSE_TAG_PROJFS_TOMBSTONE = (0xA0000022);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_AF_UNIX"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_AF_UNIX (0x80000023L)")]
    public const uint IO_REPARSE_TAG_AF_UNIX = (0x80000023);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_STORAGE_SYNC_FOLDER"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_STORAGE_SYNC_FOLDER (0x90000027L)")]
    public const uint IO_REPARSE_TAG_STORAGE_SYNC_FOLDER = (0x90000027);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_WCI_LINK"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_WCI_LINK (0xA0000027L)")]
    public const uint IO_REPARSE_TAG_WCI_LINK = (0xA0000027);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_WCI_LINK_1"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_WCI_LINK_1 (0xA0001027L)")]
    public const uint IO_REPARSE_TAG_WCI_LINK_1 = (0xA0001027);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_REPARSE_TAG_DATALESS_CIM"]/*' />
    [NativeTypeName("#define IO_REPARSE_TAG_DATALESS_CIM (0xA0000028L)")]
    public const uint IO_REPARSE_TAG_DATALESS_CIM = (0xA0000028);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_COMPLETION_MODIFY_STATE"]/*' />
    [NativeTypeName("#define IO_COMPLETION_MODIFY_STATE 0x0002")]
    public const int IO_COMPLETION_MODIFY_STATE = 0x0002;

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_COMPLETION_ALL_ACCESS"]/*' />
    [NativeTypeName("#define IO_COMPLETION_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED|SYNCHRONIZE|0x3)")]
    public const int IO_COMPLETION_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0x3);

    /// <include file='IO.xml' path='doc/member[@name="IO.IO_QOS_MAX_RESERVATION"]/*' />
    [NativeTypeName("#define IO_QOS_MAX_RESERVATION 1000000000ULL")]
    public const ulong IO_QOS_MAX_RESERVATION = 1000000000UL;
}
