// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TAPE
{
    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_ERASE_SHORT"]/*' />
    [NativeTypeName("#define TAPE_ERASE_SHORT 0L")]
    public const int TAPE_ERASE_SHORT = 0;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_ERASE_LONG"]/*' />
    [NativeTypeName("#define TAPE_ERASE_LONG 1L")]
    public const int TAPE_ERASE_LONG = 1;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_LOAD"]/*' />
    [NativeTypeName("#define TAPE_LOAD 0L")]
    public const int TAPE_LOAD = 0;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_UNLOAD"]/*' />
    [NativeTypeName("#define TAPE_UNLOAD 1L")]
    public const int TAPE_UNLOAD = 1;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_TENSION"]/*' />
    [NativeTypeName("#define TAPE_TENSION 2L")]
    public const int TAPE_TENSION = 2;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_LOCK"]/*' />
    [NativeTypeName("#define TAPE_LOCK 3L")]
    public const int TAPE_LOCK = 3;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_UNLOCK"]/*' />
    [NativeTypeName("#define TAPE_UNLOCK 4L")]
    public const int TAPE_UNLOCK = 4;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_FORMAT"]/*' />
    [NativeTypeName("#define TAPE_FORMAT 5L")]
    public const int TAPE_FORMAT = 5;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_SETMARKS"]/*' />
    [NativeTypeName("#define TAPE_SETMARKS 0L")]
    public const int TAPE_SETMARKS = 0;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_FILEMARKS"]/*' />
    [NativeTypeName("#define TAPE_FILEMARKS 1L")]
    public const int TAPE_FILEMARKS = 1;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_SHORT_FILEMARKS"]/*' />
    [NativeTypeName("#define TAPE_SHORT_FILEMARKS 2L")]
    public const int TAPE_SHORT_FILEMARKS = 2;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_LONG_FILEMARKS"]/*' />
    [NativeTypeName("#define TAPE_LONG_FILEMARKS 3L")]
    public const int TAPE_LONG_FILEMARKS = 3;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_ABSOLUTE_POSITION"]/*' />
    [NativeTypeName("#define TAPE_ABSOLUTE_POSITION 0L")]
    public const int TAPE_ABSOLUTE_POSITION = 0;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_LOGICAL_POSITION"]/*' />
    [NativeTypeName("#define TAPE_LOGICAL_POSITION 1L")]
    public const int TAPE_LOGICAL_POSITION = 1;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_PSEUDO_LOGICAL_POSITION"]/*' />
    [NativeTypeName("#define TAPE_PSEUDO_LOGICAL_POSITION 2L")]
    public const int TAPE_PSEUDO_LOGICAL_POSITION = 2;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_REWIND"]/*' />
    [NativeTypeName("#define TAPE_REWIND 0L")]
    public const int TAPE_REWIND = 0;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_ABSOLUTE_BLOCK"]/*' />
    [NativeTypeName("#define TAPE_ABSOLUTE_BLOCK 1L")]
    public const int TAPE_ABSOLUTE_BLOCK = 1;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_LOGICAL_BLOCK"]/*' />
    [NativeTypeName("#define TAPE_LOGICAL_BLOCK 2L")]
    public const int TAPE_LOGICAL_BLOCK = 2;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_PSEUDO_LOGICAL_BLOCK"]/*' />
    [NativeTypeName("#define TAPE_PSEUDO_LOGICAL_BLOCK 3L")]
    public const int TAPE_PSEUDO_LOGICAL_BLOCK = 3;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_SPACE_END_OF_DATA"]/*' />
    [NativeTypeName("#define TAPE_SPACE_END_OF_DATA 4L")]
    public const int TAPE_SPACE_END_OF_DATA = 4;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_SPACE_RELATIVE_BLOCKS"]/*' />
    [NativeTypeName("#define TAPE_SPACE_RELATIVE_BLOCKS 5L")]
    public const int TAPE_SPACE_RELATIVE_BLOCKS = 5;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_SPACE_FILEMARKS"]/*' />
    [NativeTypeName("#define TAPE_SPACE_FILEMARKS 6L")]
    public const int TAPE_SPACE_FILEMARKS = 6;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_SPACE_SEQUENTIAL_FMKS"]/*' />
    [NativeTypeName("#define TAPE_SPACE_SEQUENTIAL_FMKS 7L")]
    public const int TAPE_SPACE_SEQUENTIAL_FMKS = 7;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_SPACE_SETMARKS"]/*' />
    [NativeTypeName("#define TAPE_SPACE_SETMARKS 8L")]
    public const int TAPE_SPACE_SETMARKS = 8;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_SPACE_SEQUENTIAL_SMKS"]/*' />
    [NativeTypeName("#define TAPE_SPACE_SEQUENTIAL_SMKS 9L")]
    public const int TAPE_SPACE_SEQUENTIAL_SMKS = 9;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_FIXED"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_FIXED 0x00000001")]
    public const int TAPE_DRIVE_FIXED = 0x00000001;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_SELECT"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_SELECT 0x00000002")]
    public const int TAPE_DRIVE_SELECT = 0x00000002;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_INITIATOR"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_INITIATOR 0x00000004")]
    public const int TAPE_DRIVE_INITIATOR = 0x00000004;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_ERASE_SHORT"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_ERASE_SHORT 0x00000010")]
    public const int TAPE_DRIVE_ERASE_SHORT = 0x00000010;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_ERASE_LONG"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_ERASE_LONG 0x00000020")]
    public const int TAPE_DRIVE_ERASE_LONG = 0x00000020;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_ERASE_BOP_ONLY"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_ERASE_BOP_ONLY 0x00000040")]
    public const int TAPE_DRIVE_ERASE_BOP_ONLY = 0x00000040;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_ERASE_IMMEDIATE"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_ERASE_IMMEDIATE 0x00000080")]
    public const int TAPE_DRIVE_ERASE_IMMEDIATE = 0x00000080;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_TAPE_CAPACITY"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_TAPE_CAPACITY 0x00000100")]
    public const int TAPE_DRIVE_TAPE_CAPACITY = 0x00000100;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_TAPE_REMAINING"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_TAPE_REMAINING 0x00000200")]
    public const int TAPE_DRIVE_TAPE_REMAINING = 0x00000200;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_FIXED_BLOCK"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_FIXED_BLOCK 0x00000400")]
    public const int TAPE_DRIVE_FIXED_BLOCK = 0x00000400;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_VARIABLE_BLOCK"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_VARIABLE_BLOCK 0x00000800")]
    public const int TAPE_DRIVE_VARIABLE_BLOCK = 0x00000800;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_WRITE_PROTECT"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_WRITE_PROTECT 0x00001000")]
    public const int TAPE_DRIVE_WRITE_PROTECT = 0x00001000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_EOT_WZ_SIZE"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_EOT_WZ_SIZE 0x00002000")]
    public const int TAPE_DRIVE_EOT_WZ_SIZE = 0x00002000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_ECC"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_ECC 0x00010000")]
    public const int TAPE_DRIVE_ECC = 0x00010000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_COMPRESSION"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_COMPRESSION 0x00020000")]
    public const int TAPE_DRIVE_COMPRESSION = 0x00020000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_PADDING"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_PADDING 0x00040000")]
    public const int TAPE_DRIVE_PADDING = 0x00040000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_REPORT_SMKS"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_REPORT_SMKS 0x00080000")]
    public const int TAPE_DRIVE_REPORT_SMKS = 0x00080000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_GET_ABSOLUTE_BLK"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_GET_ABSOLUTE_BLK 0x00100000")]
    public const int TAPE_DRIVE_GET_ABSOLUTE_BLK = 0x00100000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_GET_LOGICAL_BLK"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_GET_LOGICAL_BLK 0x00200000")]
    public const int TAPE_DRIVE_GET_LOGICAL_BLK = 0x00200000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_SET_EOT_WZ_SIZE"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_SET_EOT_WZ_SIZE 0x00400000")]
    public const int TAPE_DRIVE_SET_EOT_WZ_SIZE = 0x00400000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_EJECT_MEDIA"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_EJECT_MEDIA 0x01000000")]
    public const int TAPE_DRIVE_EJECT_MEDIA = 0x01000000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_CLEAN_REQUESTS"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_CLEAN_REQUESTS 0x02000000")]
    public const int TAPE_DRIVE_CLEAN_REQUESTS = 0x02000000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_SET_CMP_BOP_ONLY"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_SET_CMP_BOP_ONLY 0x04000000")]
    public const int TAPE_DRIVE_SET_CMP_BOP_ONLY = 0x04000000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_RESERVED_BIT"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_RESERVED_BIT 0x80000000")]
    public const uint TAPE_DRIVE_RESERVED_BIT = 0x80000000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_LOAD_UNLOAD"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_LOAD_UNLOAD 0x80000001")]
    public const uint TAPE_DRIVE_LOAD_UNLOAD = 0x80000001;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_TENSION"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_TENSION 0x80000002")]
    public const uint TAPE_DRIVE_TENSION = 0x80000002;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_LOCK_UNLOCK"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_LOCK_UNLOCK 0x80000004")]
    public const uint TAPE_DRIVE_LOCK_UNLOCK = 0x80000004;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_REWIND_IMMEDIATE"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_REWIND_IMMEDIATE 0x80000008")]
    public const uint TAPE_DRIVE_REWIND_IMMEDIATE = 0x80000008;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_SET_BLOCK_SIZE"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_SET_BLOCK_SIZE 0x80000010")]
    public const uint TAPE_DRIVE_SET_BLOCK_SIZE = 0x80000010;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_LOAD_UNLD_IMMED"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_LOAD_UNLD_IMMED 0x80000020")]
    public const uint TAPE_DRIVE_LOAD_UNLD_IMMED = 0x80000020;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_TENSION_IMMED"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_TENSION_IMMED 0x80000040")]
    public const uint TAPE_DRIVE_TENSION_IMMED = 0x80000040;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_LOCK_UNLK_IMMED"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_LOCK_UNLK_IMMED 0x80000080")]
    public const uint TAPE_DRIVE_LOCK_UNLK_IMMED = 0x80000080;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_SET_ECC"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_SET_ECC 0x80000100")]
    public const uint TAPE_DRIVE_SET_ECC = 0x80000100;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_SET_COMPRESSION"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_SET_COMPRESSION 0x80000200")]
    public const uint TAPE_DRIVE_SET_COMPRESSION = 0x80000200;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_SET_PADDING"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_SET_PADDING 0x80000400")]
    public const uint TAPE_DRIVE_SET_PADDING = 0x80000400;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_SET_REPORT_SMKS"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_SET_REPORT_SMKS 0x80000800")]
    public const uint TAPE_DRIVE_SET_REPORT_SMKS = 0x80000800;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_ABSOLUTE_BLK"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_ABSOLUTE_BLK 0x80001000")]
    public const uint TAPE_DRIVE_ABSOLUTE_BLK = 0x80001000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_ABS_BLK_IMMED"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_ABS_BLK_IMMED 0x80002000")]
    public const uint TAPE_DRIVE_ABS_BLK_IMMED = 0x80002000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_LOGICAL_BLK"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_LOGICAL_BLK 0x80004000")]
    public const uint TAPE_DRIVE_LOGICAL_BLK = 0x80004000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_LOG_BLK_IMMED"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_LOG_BLK_IMMED 0x80008000")]
    public const uint TAPE_DRIVE_LOG_BLK_IMMED = 0x80008000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_END_OF_DATA"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_END_OF_DATA 0x80010000")]
    public const uint TAPE_DRIVE_END_OF_DATA = 0x80010000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_RELATIVE_BLKS"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_RELATIVE_BLKS 0x80020000")]
    public const uint TAPE_DRIVE_RELATIVE_BLKS = 0x80020000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_FILEMARKS"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_FILEMARKS 0x80040000")]
    public const uint TAPE_DRIVE_FILEMARKS = 0x80040000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_SEQUENTIAL_FMKS"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_SEQUENTIAL_FMKS 0x80080000")]
    public const uint TAPE_DRIVE_SEQUENTIAL_FMKS = 0x80080000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_SETMARKS"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_SETMARKS 0x80100000")]
    public const uint TAPE_DRIVE_SETMARKS = 0x80100000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_SEQUENTIAL_SMKS"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_SEQUENTIAL_SMKS 0x80200000")]
    public const uint TAPE_DRIVE_SEQUENTIAL_SMKS = 0x80200000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_REVERSE_POSITION"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_REVERSE_POSITION 0x80400000")]
    public const uint TAPE_DRIVE_REVERSE_POSITION = 0x80400000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_SPACE_IMMEDIATE"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_SPACE_IMMEDIATE 0x80800000")]
    public const uint TAPE_DRIVE_SPACE_IMMEDIATE = 0x80800000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_WRITE_SETMARKS"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_WRITE_SETMARKS 0x81000000")]
    public const uint TAPE_DRIVE_WRITE_SETMARKS = 0x81000000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_WRITE_FILEMARKS"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_WRITE_FILEMARKS 0x82000000")]
    public const uint TAPE_DRIVE_WRITE_FILEMARKS = 0x82000000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_WRITE_SHORT_FMKS"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_WRITE_SHORT_FMKS 0x84000000")]
    public const uint TAPE_DRIVE_WRITE_SHORT_FMKS = 0x84000000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_WRITE_LONG_FMKS"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_WRITE_LONG_FMKS 0x88000000")]
    public const uint TAPE_DRIVE_WRITE_LONG_FMKS = 0x88000000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_WRITE_MARK_IMMED"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_WRITE_MARK_IMMED 0x90000000")]
    public const uint TAPE_DRIVE_WRITE_MARK_IMMED = 0x90000000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_FORMAT"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_FORMAT 0xA0000000")]
    public const uint TAPE_DRIVE_FORMAT = 0xA0000000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_FORMAT_IMMEDIATE"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_FORMAT_IMMEDIATE 0xC0000000")]
    public const uint TAPE_DRIVE_FORMAT_IMMEDIATE = 0xC0000000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_DRIVE_HIGH_FEATURES"]/*' />
    [NativeTypeName("#define TAPE_DRIVE_HIGH_FEATURES 0x80000000")]
    public const uint TAPE_DRIVE_HIGH_FEATURES = 0x80000000;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_FIXED_PARTITIONS"]/*' />
    [NativeTypeName("#define TAPE_FIXED_PARTITIONS 0L")]
    public const int TAPE_FIXED_PARTITIONS = 0;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_SELECT_PARTITIONS"]/*' />
    [NativeTypeName("#define TAPE_SELECT_PARTITIONS 1L")]
    public const int TAPE_SELECT_PARTITIONS = 1;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_INITIATOR_PARTITIONS"]/*' />
    [NativeTypeName("#define TAPE_INITIATOR_PARTITIONS 2L")]
    public const int TAPE_INITIATOR_PARTITIONS = 2;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_QUERY_DRIVE_PARAMETERS"]/*' />
    [NativeTypeName("#define TAPE_QUERY_DRIVE_PARAMETERS 0L")]
    public const int TAPE_QUERY_DRIVE_PARAMETERS = 0;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_QUERY_MEDIA_CAPACITY"]/*' />
    [NativeTypeName("#define TAPE_QUERY_MEDIA_CAPACITY 1L")]
    public const int TAPE_QUERY_MEDIA_CAPACITY = 1;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_CHECK_FOR_DRIVE_PROBLEM"]/*' />
    [NativeTypeName("#define TAPE_CHECK_FOR_DRIVE_PROBLEM 2L")]
    public const int TAPE_CHECK_FOR_DRIVE_PROBLEM = 2;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_QUERY_IO_ERROR_DATA"]/*' />
    [NativeTypeName("#define TAPE_QUERY_IO_ERROR_DATA 3L")]
    public const int TAPE_QUERY_IO_ERROR_DATA = 3;

    /// <include file='TAPE.xml' path='doc/member[@name="TAPE.TAPE_QUERY_DEVICE_ERROR_DATA"]/*' />
    [NativeTypeName("#define TAPE_QUERY_DEVICE_ERROR_DATA 4L")]
    public const int TAPE_QUERY_DEVICE_ERROR_DATA = 4;
}
