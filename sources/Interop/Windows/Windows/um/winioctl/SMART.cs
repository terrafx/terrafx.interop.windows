// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SMART
{
    /// <include file='SMART.xml' path='doc/member[@name="SMART.SMART_GET_VERSION"]/*' />
    [NativeTypeName("#define SMART_GET_VERSION CTL_CODE(IOCTL_DISK_BASE, 0x0020, METHOD_BUFFERED, FILE_READ_ACCESS)")]
    public const int SMART_GET_VERSION = (((0x00000007) << 16) | (((0x0001)) << 14) | ((0x0020) << 2) | (0));

    /// <include file='SMART.xml' path='doc/member[@name="SMART.SMART_SEND_DRIVE_COMMAND"]/*' />
    [NativeTypeName("#define SMART_SEND_DRIVE_COMMAND CTL_CODE(IOCTL_DISK_BASE, 0x0021, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
    public const int SMART_SEND_DRIVE_COMMAND = (((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0021) << 2) | (0));

    /// <include file='SMART.xml' path='doc/member[@name="SMART.SMART_RCV_DRIVE_DATA"]/*' />
    [NativeTypeName("#define SMART_RCV_DRIVE_DATA CTL_CODE(IOCTL_DISK_BASE, 0x0022, METHOD_BUFFERED, FILE_READ_ACCESS | FILE_WRITE_ACCESS)")]
    public const int SMART_RCV_DRIVE_DATA = (((0x00000007) << 16) | (((0x0001) | (0x0002)) << 14) | ((0x0022) << 2) | (0));

    /// <include file='SMART.xml' path='doc/member[@name="SMART.SMART_RCV_DRIVE_DATA_EX"]/*' />
    [NativeTypeName("#define SMART_RCV_DRIVE_DATA_EX CTL_CODE(IOCTL_DISK_BASE, 0x0023, METHOD_BUFFERED, FILE_ANY_ACCESS)")]
    public const int SMART_RCV_DRIVE_DATA_EX = (((0x00000007) << 16) | ((0) << 14) | ((0x0023) << 2) | (0));

    /// <include file='SMART.xml' path='doc/member[@name="SMART.SMART_CMD"]/*' />
    [NativeTypeName("#define SMART_CMD 0xB0")]
    public const int SMART_CMD = 0xB0;

    /// <include file='SMART.xml' path='doc/member[@name="SMART.SMART_CYL_LOW"]/*' />
    [NativeTypeName("#define SMART_CYL_LOW 0x4F")]
    public const int SMART_CYL_LOW = 0x4F;

    /// <include file='SMART.xml' path='doc/member[@name="SMART.SMART_CYL_HI"]/*' />
    [NativeTypeName("#define SMART_CYL_HI 0xC2")]
    public const int SMART_CYL_HI = 0xC2;

    /// <include file='SMART.xml' path='doc/member[@name="SMART.SMART_NO_ERROR"]/*' />
    [NativeTypeName("#define SMART_NO_ERROR 0")]
    public const int SMART_NO_ERROR = 0;

    /// <include file='SMART.xml' path='doc/member[@name="SMART.SMART_IDE_ERROR"]/*' />
    [NativeTypeName("#define SMART_IDE_ERROR 1")]
    public const int SMART_IDE_ERROR = 1;

    /// <include file='SMART.xml' path='doc/member[@name="SMART.SMART_INVALID_FLAG"]/*' />
    [NativeTypeName("#define SMART_INVALID_FLAG 2")]
    public const int SMART_INVALID_FLAG = 2;

    /// <include file='SMART.xml' path='doc/member[@name="SMART.SMART_INVALID_COMMAND"]/*' />
    [NativeTypeName("#define SMART_INVALID_COMMAND 3")]
    public const int SMART_INVALID_COMMAND = 3;

    /// <include file='SMART.xml' path='doc/member[@name="SMART.SMART_INVALID_BUFFER"]/*' />
    [NativeTypeName("#define SMART_INVALID_BUFFER 4")]
    public const int SMART_INVALID_BUFFER = 4;

    /// <include file='SMART.xml' path='doc/member[@name="SMART.SMART_INVALID_DRIVE"]/*' />
    [NativeTypeName("#define SMART_INVALID_DRIVE 5")]
    public const int SMART_INVALID_DRIVE = 5;

    /// <include file='SMART.xml' path='doc/member[@name="SMART.SMART_INVALID_IOCTL"]/*' />
    [NativeTypeName("#define SMART_INVALID_IOCTL 6")]
    public const int SMART_INVALID_IOCTL = 6;

    /// <include file='SMART.xml' path='doc/member[@name="SMART.SMART_ERROR_NO_MEM"]/*' />
    [NativeTypeName("#define SMART_ERROR_NO_MEM 7")]
    public const int SMART_ERROR_NO_MEM = 7;

    /// <include file='SMART.xml' path='doc/member[@name="SMART.SMART_INVALID_REGISTER"]/*' />
    [NativeTypeName("#define SMART_INVALID_REGISTER 8")]
    public const int SMART_INVALID_REGISTER = 8;

    /// <include file='SMART.xml' path='doc/member[@name="SMART.SMART_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define SMART_NOT_SUPPORTED 9")]
    public const int SMART_NOT_SUPPORTED = 9;

    /// <include file='SMART.xml' path='doc/member[@name="SMART.SMART_NO_IDE_DEVICE"]/*' />
    [NativeTypeName("#define SMART_NO_IDE_DEVICE 10")]
    public const int SMART_NO_IDE_DEVICE = 10;

    /// <include file='SMART.xml' path='doc/member[@name="SMART.SMART_OFFLINE_ROUTINE_OFFLINE"]/*' />
    [NativeTypeName("#define SMART_OFFLINE_ROUTINE_OFFLINE 0")]
    public const int SMART_OFFLINE_ROUTINE_OFFLINE = 0;

    /// <include file='SMART.xml' path='doc/member[@name="SMART.SMART_SHORT_SELFTEST_OFFLINE"]/*' />
    [NativeTypeName("#define SMART_SHORT_SELFTEST_OFFLINE 1")]
    public const int SMART_SHORT_SELFTEST_OFFLINE = 1;

    /// <include file='SMART.xml' path='doc/member[@name="SMART.SMART_EXTENDED_SELFTEST_OFFLINE"]/*' />
    [NativeTypeName("#define SMART_EXTENDED_SELFTEST_OFFLINE 2")]
    public const int SMART_EXTENDED_SELFTEST_OFFLINE = 2;

    /// <include file='SMART.xml' path='doc/member[@name="SMART.SMART_ABORT_OFFLINE_SELFTEST"]/*' />
    [NativeTypeName("#define SMART_ABORT_OFFLINE_SELFTEST 127")]
    public const int SMART_ABORT_OFFLINE_SELFTEST = 127;

    /// <include file='SMART.xml' path='doc/member[@name="SMART.SMART_SHORT_SELFTEST_CAPTIVE"]/*' />
    [NativeTypeName("#define SMART_SHORT_SELFTEST_CAPTIVE 129")]
    public const int SMART_SHORT_SELFTEST_CAPTIVE = 129;

    /// <include file='SMART.xml' path='doc/member[@name="SMART.SMART_EXTENDED_SELFTEST_CAPTIVE"]/*' />
    [NativeTypeName("#define SMART_EXTENDED_SELFTEST_CAPTIVE 130")]
    public const int SMART_EXTENDED_SELFTEST_CAPTIVE = 130;

    /// <include file='SMART.xml' path='doc/member[@name="SMART.SMART_LOG_SECTOR_SIZE"]/*' />
    [NativeTypeName("#define SMART_LOG_SECTOR_SIZE 512")]
    public const int SMART_LOG_SECTOR_SIZE = 512;

    /// <include file='SMART.xml' path='doc/member[@name="SMART.SMART_READ_LOG"]/*' />
    [NativeTypeName("#define SMART_READ_LOG 0xD5")]
    public const int SMART_READ_LOG = 0xD5;

    /// <include file='SMART.xml' path='doc/member[@name="SMART.SMART_WRITE_LOG"]/*' />
    [NativeTypeName("#define SMART_WRITE_LOG 0xd6")]
    public const int SMART_WRITE_LOG = 0xd6;
}
