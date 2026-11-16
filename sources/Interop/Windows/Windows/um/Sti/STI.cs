// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Sti.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public static partial class STI
{
    /// <include file='STI.xml' path='doc/member[@name="STI.STI_UNICODE"]/*' />
    [NativeTypeName("#define STI_UNICODE 1")]
    public const int STI_UNICODE = 1;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_VERSION_FLAG_MASK"]/*' />
    [NativeTypeName("#define STI_VERSION_FLAG_MASK 0xff000000")]
    public const uint STI_VERSION_FLAG_MASK = 0xff000000;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_VERSION_FLAG_UNICODE"]/*' />
    [NativeTypeName("#define STI_VERSION_FLAG_UNICODE 0x01000000")]
    public const int STI_VERSION_FLAG_UNICODE = 0x01000000;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_VERSION_REAL"]/*' />
    [NativeTypeName("#define STI_VERSION_REAL 0x00000002")]
    public const int STI_VERSION_REAL = 0x00000002;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_VERSION_3"]/*' />
    [NativeTypeName("#define STI_VERSION_3 (0x00000003 | STI_VERSION_FLAG_UNICODE)")]
    public const int STI_VERSION_3 = (0x00000003 | 0x01000000);

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_VERSION_MIN_ALLOWED"]/*' />
    [NativeTypeName("#define STI_VERSION_MIN_ALLOWED 0x00000002")]
    public const int STI_VERSION_MIN_ALLOWED = 0x00000002;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_VERSION"]/*' />
    [NativeTypeName("#define STI_VERSION (STI_VERSION_REAL | STI_VERSION_FLAG_UNICODE)")]
    public const int STI_VERSION = (0x00000002 | 0x01000000);

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_MAX_INTERNAL_NAME_LENGTH"]/*' />
    [NativeTypeName("#define STI_MAX_INTERNAL_NAME_LENGTH 128")]
    public const int STI_MAX_INTERNAL_NAME_LENGTH = 128;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_GENCAP_COMMON_MASK"]/*' />
    [NativeTypeName("#define STI_GENCAP_COMMON_MASK (DWORD)0x00ff")]
    public const uint STI_GENCAP_COMMON_MASK = (uint)(0x00ff);

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_GENCAP_NOTIFICATIONS"]/*' />
    [NativeTypeName("#define STI_GENCAP_NOTIFICATIONS 0x00000001")]
    public const int STI_GENCAP_NOTIFICATIONS = 0x00000001;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_GENCAP_POLLING_NEEDED"]/*' />
    [NativeTypeName("#define STI_GENCAP_POLLING_NEEDED 0x00000002")]
    public const int STI_GENCAP_POLLING_NEEDED = 0x00000002;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_GENCAP_GENERATE_ARRIVALEVENT"]/*' />
    [NativeTypeName("#define STI_GENCAP_GENERATE_ARRIVALEVENT 0x00000004")]
    public const int STI_GENCAP_GENERATE_ARRIVALEVENT = 0x00000004;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_GENCAP_AUTO_PORTSELECT"]/*' />
    [NativeTypeName("#define STI_GENCAP_AUTO_PORTSELECT 0x00000008")]
    public const int STI_GENCAP_AUTO_PORTSELECT = 0x00000008;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_GENCAP_WIA"]/*' />
    [NativeTypeName("#define STI_GENCAP_WIA 0x00000010")]
    public const int STI_GENCAP_WIA = 0x00000010;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_GENCAP_SUBSET"]/*' />
    [NativeTypeName("#define STI_GENCAP_SUBSET 0x00000020")]
    public const int STI_GENCAP_SUBSET = 0x00000020;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_HW_CONFIG_UNKNOWN"]/*' />
    [NativeTypeName("#define STI_HW_CONFIG_UNKNOWN 0x0001")]
    public const int STI_HW_CONFIG_UNKNOWN = 0x0001;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_HW_CONFIG_SCSI"]/*' />
    [NativeTypeName("#define STI_HW_CONFIG_SCSI 0x0002")]
    public const int STI_HW_CONFIG_SCSI = 0x0002;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_HW_CONFIG_USB"]/*' />
    [NativeTypeName("#define STI_HW_CONFIG_USB 0x0004")]
    public const int STI_HW_CONFIG_USB = 0x0004;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_HW_CONFIG_SERIAL"]/*' />
    [NativeTypeName("#define STI_HW_CONFIG_SERIAL 0x0008")]
    public const int STI_HW_CONFIG_SERIAL = 0x0008;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_HW_CONFIG_PARALLEL"]/*' />
    [NativeTypeName("#define STI_HW_CONFIG_PARALLEL 0x0010")]
    public const int STI_HW_CONFIG_PARALLEL = 0x0010;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_DEVSTATUS_ONLINE_STATE"]/*' />
    [NativeTypeName("#define STI_DEVSTATUS_ONLINE_STATE 0x0001")]
    public const int STI_DEVSTATUS_ONLINE_STATE = 0x0001;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_DEVSTATUS_EVENTS_STATE"]/*' />
    [NativeTypeName("#define STI_DEVSTATUS_EVENTS_STATE 0x0002")]
    public const int STI_DEVSTATUS_EVENTS_STATE = 0x0002;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_ONLINESTATE_OPERATIONAL"]/*' />
    [NativeTypeName("#define STI_ONLINESTATE_OPERATIONAL 0x00000001")]
    public const int STI_ONLINESTATE_OPERATIONAL = 0x00000001;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_ONLINESTATE_PENDING"]/*' />
    [NativeTypeName("#define STI_ONLINESTATE_PENDING 0x00000002")]
    public const int STI_ONLINESTATE_PENDING = 0x00000002;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_ONLINESTATE_ERROR"]/*' />
    [NativeTypeName("#define STI_ONLINESTATE_ERROR 0x00000004")]
    public const int STI_ONLINESTATE_ERROR = 0x00000004;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_ONLINESTATE_PAUSED"]/*' />
    [NativeTypeName("#define STI_ONLINESTATE_PAUSED 0x00000008")]
    public const int STI_ONLINESTATE_PAUSED = 0x00000008;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_ONLINESTATE_PAPER_JAM"]/*' />
    [NativeTypeName("#define STI_ONLINESTATE_PAPER_JAM 0x00000010")]
    public const int STI_ONLINESTATE_PAPER_JAM = 0x00000010;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_ONLINESTATE_PAPER_PROBLEM"]/*' />
    [NativeTypeName("#define STI_ONLINESTATE_PAPER_PROBLEM 0x00000020")]
    public const int STI_ONLINESTATE_PAPER_PROBLEM = 0x00000020;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_ONLINESTATE_OFFLINE"]/*' />
    [NativeTypeName("#define STI_ONLINESTATE_OFFLINE 0x00000040")]
    public const int STI_ONLINESTATE_OFFLINE = 0x00000040;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_ONLINESTATE_IO_ACTIVE"]/*' />
    [NativeTypeName("#define STI_ONLINESTATE_IO_ACTIVE 0x00000080")]
    public const int STI_ONLINESTATE_IO_ACTIVE = 0x00000080;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_ONLINESTATE_BUSY"]/*' />
    [NativeTypeName("#define STI_ONLINESTATE_BUSY 0x00000100")]
    public const int STI_ONLINESTATE_BUSY = 0x00000100;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_ONLINESTATE_TRANSFERRING"]/*' />
    [NativeTypeName("#define STI_ONLINESTATE_TRANSFERRING 0x00000200")]
    public const int STI_ONLINESTATE_TRANSFERRING = 0x00000200;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_ONLINESTATE_INITIALIZING"]/*' />
    [NativeTypeName("#define STI_ONLINESTATE_INITIALIZING 0x00000400")]
    public const int STI_ONLINESTATE_INITIALIZING = 0x00000400;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_ONLINESTATE_WARMING_UP"]/*' />
    [NativeTypeName("#define STI_ONLINESTATE_WARMING_UP 0x00000800")]
    public const int STI_ONLINESTATE_WARMING_UP = 0x00000800;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_ONLINESTATE_USER_INTERVENTION"]/*' />
    [NativeTypeName("#define STI_ONLINESTATE_USER_INTERVENTION 0x00001000")]
    public const int STI_ONLINESTATE_USER_INTERVENTION = 0x00001000;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_ONLINESTATE_POWER_SAVE"]/*' />
    [NativeTypeName("#define STI_ONLINESTATE_POWER_SAVE 0x00002000")]
    public const int STI_ONLINESTATE_POWER_SAVE = 0x00002000;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_EVENTHANDLING_ENABLED"]/*' />
    [NativeTypeName("#define STI_EVENTHANDLING_ENABLED 0x00000001")]
    public const int STI_EVENTHANDLING_ENABLED = 0x00000001;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_EVENTHANDLING_POLLING"]/*' />
    [NativeTypeName("#define STI_EVENTHANDLING_POLLING 0x00000002")]
    public const int STI_EVENTHANDLING_POLLING = 0x00000002;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_EVENTHANDLING_PENDING"]/*' />
    [NativeTypeName("#define STI_EVENTHANDLING_PENDING 0x00000004")]
    public const int STI_EVENTHANDLING_PENDING = 0x00000004;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_DIAGCODE_HWPRESENCE"]/*' />
    [NativeTypeName("#define STI_DIAGCODE_HWPRESENCE 0x00000001")]
    public const int STI_DIAGCODE_HWPRESENCE = 0x00000001;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_TRACE_INFORMATION"]/*' />
    [NativeTypeName("#define STI_TRACE_INFORMATION 0x00000001")]
    public const int STI_TRACE_INFORMATION = 0x00000001;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_TRACE_WARNING"]/*' />
    [NativeTypeName("#define STI_TRACE_WARNING 0x00000002")]
    public const int STI_TRACE_WARNING = 0x00000002;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_TRACE_ERROR"]/*' />
    [NativeTypeName("#define STI_TRACE_ERROR 0x00000004")]
    public const int STI_TRACE_ERROR = 0x00000004;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_SUBSCRIBE_FLAG_WINDOW"]/*' />
    [NativeTypeName("#define STI_SUBSCRIBE_FLAG_WINDOW 0x0001")]
    public const int STI_SUBSCRIBE_FLAG_WINDOW = 0x0001;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_SUBSCRIBE_FLAG_EVENT"]/*' />
    [NativeTypeName("#define STI_SUBSCRIBE_FLAG_EVENT 0x0002")]
    public const int STI_SUBSCRIBE_FLAG_EVENT = 0x0002;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_ADD_DEVICE_BROADCAST_ACTION"]/*' />
    [NativeTypeName("#define STI_ADD_DEVICE_BROADCAST_ACTION \"Arrival\"")]
    public static ReadOnlySpan<byte> STI_ADD_DEVICE_BROADCAST_ACTION => "Arrival"u8;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_REMOVE_DEVICE_BROADCAST_ACTION"]/*' />
    [NativeTypeName("#define STI_REMOVE_DEVICE_BROADCAST_ACTION \"Removal\"")]
    public static ReadOnlySpan<byte> STI_REMOVE_DEVICE_BROADCAST_ACTION => "Removal"u8;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_ADD_DEVICE_BROADCAST_STRING"]/*' />
    [NativeTypeName("#define STI_ADD_DEVICE_BROADCAST_STRING \"STI\" STI_ADD_DEVICE_BROADCAST_ACTION \"\\%s\"")]
    public static ReadOnlySpan<byte> STI_ADD_DEVICE_BROADCAST_STRING => "STI\\Arrival\\%s"u8;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_REMOVE_DEVICE_BROADCAST_STRING"]/*' />
    [NativeTypeName("#define STI_REMOVE_DEVICE_BROADCAST_STRING \"STI\" STI_REMOVE_DEVICE_BROADCAST_ACTION \"\\%s\"")]
    public static ReadOnlySpan<byte> STI_REMOVE_DEVICE_BROADCAST_STRING => "STI\\Removal\\%s"u8;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_DEVICE_CREATE_STATUS"]/*' />
    [NativeTypeName("#define STI_DEVICE_CREATE_STATUS 0x00000001")]
    public const int STI_DEVICE_CREATE_STATUS = 0x00000001;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_DEVICE_CREATE_DATA"]/*' />
    [NativeTypeName("#define STI_DEVICE_CREATE_DATA 0x00000002")]
    public const int STI_DEVICE_CREATE_DATA = 0x00000002;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_DEVICE_CREATE_BOTH"]/*' />
    [NativeTypeName("#define STI_DEVICE_CREATE_BOTH 0x00000003")]
    public const int STI_DEVICE_CREATE_BOTH = 0x00000003;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_DEVICE_CREATE_MASK"]/*' />
    [NativeTypeName("#define STI_DEVICE_CREATE_MASK 0x0000FFFF")]
    public const int STI_DEVICE_CREATE_MASK = 0x0000FFFF;

    /// <include file='STI.xml' path='doc/member[@name="STI.STI_RAW_RESERVED"]/*' />
    [NativeTypeName("#define STI_RAW_RESERVED 0x1000")]
    public const int STI_RAW_RESERVED = 0x1000;
}
