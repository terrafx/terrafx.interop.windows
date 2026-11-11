// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CHANGER
{
    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_BAR_CODE_SCANNER_INSTALLED"]/*' />
    [NativeTypeName("#define CHANGER_BAR_CODE_SCANNER_INSTALLED 0x00000001")]
    public const int CHANGER_BAR_CODE_SCANNER_INSTALLED = 0x00000001;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_INIT_ELEM_STAT_WITH_RANGE"]/*' />
    [NativeTypeName("#define CHANGER_INIT_ELEM_STAT_WITH_RANGE 0x00000002")]
    public const int CHANGER_INIT_ELEM_STAT_WITH_RANGE = 0x00000002;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_CLOSE_IEPORT"]/*' />
    [NativeTypeName("#define CHANGER_CLOSE_IEPORT 0x00000004")]
    public const int CHANGER_CLOSE_IEPORT = 0x00000004;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_OPEN_IEPORT"]/*' />
    [NativeTypeName("#define CHANGER_OPEN_IEPORT 0x00000008")]
    public const int CHANGER_OPEN_IEPORT = 0x00000008;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_STATUS_NON_VOLATILE"]/*' />
    [NativeTypeName("#define CHANGER_STATUS_NON_VOLATILE 0x00000010")]
    public const int CHANGER_STATUS_NON_VOLATILE = 0x00000010;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_EXCHANGE_MEDIA"]/*' />
    [NativeTypeName("#define CHANGER_EXCHANGE_MEDIA 0x00000020")]
    public const int CHANGER_EXCHANGE_MEDIA = 0x00000020;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_CLEANER_SLOT"]/*' />
    [NativeTypeName("#define CHANGER_CLEANER_SLOT 0x00000040")]
    public const int CHANGER_CLEANER_SLOT = 0x00000040;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_LOCK_UNLOCK"]/*' />
    [NativeTypeName("#define CHANGER_LOCK_UNLOCK 0x00000080")]
    public const int CHANGER_LOCK_UNLOCK = 0x00000080;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_CARTRIDGE_MAGAZINE"]/*' />
    [NativeTypeName("#define CHANGER_CARTRIDGE_MAGAZINE 0x00000100")]
    public const int CHANGER_CARTRIDGE_MAGAZINE = 0x00000100;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_MEDIUM_FLIP"]/*' />
    [NativeTypeName("#define CHANGER_MEDIUM_FLIP 0x00000200")]
    public const int CHANGER_MEDIUM_FLIP = 0x00000200;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_POSITION_TO_ELEMENT"]/*' />
    [NativeTypeName("#define CHANGER_POSITION_TO_ELEMENT 0x00000400")]
    public const int CHANGER_POSITION_TO_ELEMENT = 0x00000400;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_REPORT_IEPORT_STATE"]/*' />
    [NativeTypeName("#define CHANGER_REPORT_IEPORT_STATE 0x00000800")]
    public const int CHANGER_REPORT_IEPORT_STATE = 0x00000800;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_STORAGE_DRIVE"]/*' />
    [NativeTypeName("#define CHANGER_STORAGE_DRIVE 0x00001000")]
    public const int CHANGER_STORAGE_DRIVE = 0x00001000;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_STORAGE_IEPORT"]/*' />
    [NativeTypeName("#define CHANGER_STORAGE_IEPORT 0x00002000")]
    public const int CHANGER_STORAGE_IEPORT = 0x00002000;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_STORAGE_SLOT"]/*' />
    [NativeTypeName("#define CHANGER_STORAGE_SLOT 0x00004000")]
    public const int CHANGER_STORAGE_SLOT = 0x00004000;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_STORAGE_TRANSPORT"]/*' />
    [NativeTypeName("#define CHANGER_STORAGE_TRANSPORT 0x00008000")]
    public const int CHANGER_STORAGE_TRANSPORT = 0x00008000;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_DRIVE_CLEANING_REQUIRED"]/*' />
    [NativeTypeName("#define CHANGER_DRIVE_CLEANING_REQUIRED 0x00010000")]
    public const int CHANGER_DRIVE_CLEANING_REQUIRED = 0x00010000;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_PREDISMOUNT_EJECT_REQUIRED"]/*' />
    [NativeTypeName("#define CHANGER_PREDISMOUNT_EJECT_REQUIRED 0x00020000")]
    public const int CHANGER_PREDISMOUNT_EJECT_REQUIRED = 0x00020000;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_CLEANER_ACCESS_NOT_VALID"]/*' />
    [NativeTypeName("#define CHANGER_CLEANER_ACCESS_NOT_VALID 0x00040000")]
    public const int CHANGER_CLEANER_ACCESS_NOT_VALID = 0x00040000;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_PREMOUNT_EJECT_REQUIRED"]/*' />
    [NativeTypeName("#define CHANGER_PREMOUNT_EJECT_REQUIRED 0x00080000")]
    public const int CHANGER_PREMOUNT_EJECT_REQUIRED = 0x00080000;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_VOLUME_IDENTIFICATION"]/*' />
    [NativeTypeName("#define CHANGER_VOLUME_IDENTIFICATION 0x00100000")]
    public const int CHANGER_VOLUME_IDENTIFICATION = 0x00100000;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_VOLUME_SEARCH"]/*' />
    [NativeTypeName("#define CHANGER_VOLUME_SEARCH 0x00200000")]
    public const int CHANGER_VOLUME_SEARCH = 0x00200000;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_VOLUME_ASSERT"]/*' />
    [NativeTypeName("#define CHANGER_VOLUME_ASSERT 0x00400000")]
    public const int CHANGER_VOLUME_ASSERT = 0x00400000;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_VOLUME_REPLACE"]/*' />
    [NativeTypeName("#define CHANGER_VOLUME_REPLACE 0x00800000")]
    public const int CHANGER_VOLUME_REPLACE = 0x00800000;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_VOLUME_UNDEFINE"]/*' />
    [NativeTypeName("#define CHANGER_VOLUME_UNDEFINE 0x01000000")]
    public const int CHANGER_VOLUME_UNDEFINE = 0x01000000;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_SERIAL_NUMBER_VALID"]/*' />
    [NativeTypeName("#define CHANGER_SERIAL_NUMBER_VALID 0x04000000")]
    public const int CHANGER_SERIAL_NUMBER_VALID = 0x04000000;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_DEVICE_REINITIALIZE_CAPABLE"]/*' />
    [NativeTypeName("#define CHANGER_DEVICE_REINITIALIZE_CAPABLE 0x08000000")]
    public const int CHANGER_DEVICE_REINITIALIZE_CAPABLE = 0x08000000;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_KEYPAD_ENABLE_DISABLE"]/*' />
    [NativeTypeName("#define CHANGER_KEYPAD_ENABLE_DISABLE 0x10000000")]
    public const int CHANGER_KEYPAD_ENABLE_DISABLE = 0x10000000;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_DRIVE_EMPTY_ON_DOOR_ACCESS"]/*' />
    [NativeTypeName("#define CHANGER_DRIVE_EMPTY_ON_DOOR_ACCESS 0x20000000")]
    public const int CHANGER_DRIVE_EMPTY_ON_DOOR_ACCESS = 0x20000000;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_RESERVED_BIT"]/*' />
    [NativeTypeName("#define CHANGER_RESERVED_BIT 0x80000000")]
    public const uint CHANGER_RESERVED_BIT = 0x80000000;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_PREDISMOUNT_ALIGN_TO_SLOT"]/*' />
    [NativeTypeName("#define CHANGER_PREDISMOUNT_ALIGN_TO_SLOT 0x80000001")]
    public const uint CHANGER_PREDISMOUNT_ALIGN_TO_SLOT = 0x80000001;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_PREDISMOUNT_ALIGN_TO_DRIVE"]/*' />
    [NativeTypeName("#define CHANGER_PREDISMOUNT_ALIGN_TO_DRIVE 0x80000002")]
    public const uint CHANGER_PREDISMOUNT_ALIGN_TO_DRIVE = 0x80000002;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_CLEANER_AUTODISMOUNT"]/*' />
    [NativeTypeName("#define CHANGER_CLEANER_AUTODISMOUNT 0x80000004")]
    public const uint CHANGER_CLEANER_AUTODISMOUNT = 0x80000004;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_TRUE_EXCHANGE_CAPABLE"]/*' />
    [NativeTypeName("#define CHANGER_TRUE_EXCHANGE_CAPABLE 0x80000008")]
    public const uint CHANGER_TRUE_EXCHANGE_CAPABLE = 0x80000008;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_SLOTS_USE_TRAYS"]/*' />
    [NativeTypeName("#define CHANGER_SLOTS_USE_TRAYS 0x80000010")]
    public const uint CHANGER_SLOTS_USE_TRAYS = 0x80000010;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_RTN_MEDIA_TO_ORIGINAL_ADDR"]/*' />
    [NativeTypeName("#define CHANGER_RTN_MEDIA_TO_ORIGINAL_ADDR 0x80000020")]
    public const uint CHANGER_RTN_MEDIA_TO_ORIGINAL_ADDR = 0x80000020;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_CLEANER_OPS_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define CHANGER_CLEANER_OPS_NOT_SUPPORTED 0x80000040")]
    public const uint CHANGER_CLEANER_OPS_NOT_SUPPORTED = 0x80000040;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_IEPORT_USER_CONTROL_OPEN"]/*' />
    [NativeTypeName("#define CHANGER_IEPORT_USER_CONTROL_OPEN 0x80000080")]
    public const uint CHANGER_IEPORT_USER_CONTROL_OPEN = 0x80000080;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_IEPORT_USER_CONTROL_CLOSE"]/*' />
    [NativeTypeName("#define CHANGER_IEPORT_USER_CONTROL_CLOSE 0x80000100")]
    public const uint CHANGER_IEPORT_USER_CONTROL_CLOSE = 0x80000100;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_MOVE_EXTENDS_IEPORT"]/*' />
    [NativeTypeName("#define CHANGER_MOVE_EXTENDS_IEPORT 0x80000200")]
    public const uint CHANGER_MOVE_EXTENDS_IEPORT = 0x80000200;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_MOVE_RETRACTS_IEPORT"]/*' />
    [NativeTypeName("#define CHANGER_MOVE_RETRACTS_IEPORT 0x80000400")]
    public const uint CHANGER_MOVE_RETRACTS_IEPORT = 0x80000400;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_TO_TRANSPORT"]/*' />
    [NativeTypeName("#define CHANGER_TO_TRANSPORT 0x01")]
    public const int CHANGER_TO_TRANSPORT = 0x01;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_TO_SLOT"]/*' />
    [NativeTypeName("#define CHANGER_TO_SLOT 0x02")]
    public const int CHANGER_TO_SLOT = 0x02;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_TO_IEPORT"]/*' />
    [NativeTypeName("#define CHANGER_TO_IEPORT 0x04")]
    public const int CHANGER_TO_IEPORT = 0x04;

    /// <include file='CHANGER.xml' path='doc/member[@name="CHANGER.CHANGER_TO_DRIVE"]/*' />
    [NativeTypeName("#define CHANGER_TO_DRIVE 0x08")]
    public const int CHANGER_TO_DRIVE = 0x08;
}
