// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/evntprov.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class EVENT
{
    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_MIN_LEVEL"]/*' />
    [NativeTypeName("#define EVENT_MIN_LEVEL (0)")]
    public const int EVENT_MIN_LEVEL = (0);

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_MAX_LEVEL"]/*' />
    [NativeTypeName("#define EVENT_MAX_LEVEL (0xff)")]
    public const int EVENT_MAX_LEVEL = (0xff);

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_ACTIVITY_CTRL_GET_ID"]/*' />
    [NativeTypeName("#define EVENT_ACTIVITY_CTRL_GET_ID (1)")]
    public const int EVENT_ACTIVITY_CTRL_GET_ID = (1);

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_ACTIVITY_CTRL_SET_ID"]/*' />
    [NativeTypeName("#define EVENT_ACTIVITY_CTRL_SET_ID (2)")]
    public const int EVENT_ACTIVITY_CTRL_SET_ID = (2);

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_ACTIVITY_CTRL_CREATE_ID"]/*' />
    [NativeTypeName("#define EVENT_ACTIVITY_CTRL_CREATE_ID (3)")]
    public const int EVENT_ACTIVITY_CTRL_CREATE_ID = (3);

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_ACTIVITY_CTRL_GET_SET_ID"]/*' />
    [NativeTypeName("#define EVENT_ACTIVITY_CTRL_GET_SET_ID (4)")]
    public const int EVENT_ACTIVITY_CTRL_GET_SET_ID = (4);

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_ACTIVITY_CTRL_CREATE_SET_ID"]/*' />
    [NativeTypeName("#define EVENT_ACTIVITY_CTRL_CREATE_SET_ID (5)")]
    public const int EVENT_ACTIVITY_CTRL_CREATE_SET_ID = (5);

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_FILTER_TYPE_NONE"]/*' />
    [NativeTypeName("#define EVENT_FILTER_TYPE_NONE (0x00000000)")]
    public const int EVENT_FILTER_TYPE_NONE = (0x00000000);

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_FILTER_TYPE_SCHEMATIZED"]/*' />
    [NativeTypeName("#define EVENT_FILTER_TYPE_SCHEMATIZED (0x80000000)")]
    public const uint EVENT_FILTER_TYPE_SCHEMATIZED = (0x80000000);

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_FILTER_TYPE_SYSTEM_FLAGS"]/*' />
    [NativeTypeName("#define EVENT_FILTER_TYPE_SYSTEM_FLAGS (0x80000001)")]
    public const uint EVENT_FILTER_TYPE_SYSTEM_FLAGS = (0x80000001);

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_FILTER_TYPE_TRACEHANDLE"]/*' />
    [NativeTypeName("#define EVENT_FILTER_TYPE_TRACEHANDLE (0x80000002)")]
    public const uint EVENT_FILTER_TYPE_TRACEHANDLE = (0x80000002);

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_FILTER_TYPE_PID"]/*' />
    [NativeTypeName("#define EVENT_FILTER_TYPE_PID (0x80000004)")]
    public const uint EVENT_FILTER_TYPE_PID = (0x80000004);

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_FILTER_TYPE_EXECUTABLE_NAME"]/*' />
    [NativeTypeName("#define EVENT_FILTER_TYPE_EXECUTABLE_NAME (0x80000008)")]
    public const uint EVENT_FILTER_TYPE_EXECUTABLE_NAME = (0x80000008);

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_FILTER_TYPE_PACKAGE_ID"]/*' />
    [NativeTypeName("#define EVENT_FILTER_TYPE_PACKAGE_ID (0x80000010)")]
    public const uint EVENT_FILTER_TYPE_PACKAGE_ID = (0x80000010);

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_FILTER_TYPE_PACKAGE_APP_ID"]/*' />
    [NativeTypeName("#define EVENT_FILTER_TYPE_PACKAGE_APP_ID (0x80000020)")]
    public const uint EVENT_FILTER_TYPE_PACKAGE_APP_ID = (0x80000020);

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_FILTER_TYPE_PAYLOAD"]/*' />
    [NativeTypeName("#define EVENT_FILTER_TYPE_PAYLOAD (0x80000100)")]
    public const uint EVENT_FILTER_TYPE_PAYLOAD = (0x80000100);

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_FILTER_TYPE_EVENT_ID"]/*' />
    [NativeTypeName("#define EVENT_FILTER_TYPE_EVENT_ID (0x80000200)")]
    public const uint EVENT_FILTER_TYPE_EVENT_ID = (0x80000200);

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_FILTER_TYPE_EVENT_NAME"]/*' />
    [NativeTypeName("#define EVENT_FILTER_TYPE_EVENT_NAME (0x80000400)")]
    public const uint EVENT_FILTER_TYPE_EVENT_NAME = (0x80000400);

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_FILTER_TYPE_STACKWALK"]/*' />
    [NativeTypeName("#define EVENT_FILTER_TYPE_STACKWALK (0x80001000)")]
    public const uint EVENT_FILTER_TYPE_STACKWALK = (0x80001000);

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_FILTER_TYPE_STACKWALK_NAME"]/*' />
    [NativeTypeName("#define EVENT_FILTER_TYPE_STACKWALK_NAME (0x80002000)")]
    public const uint EVENT_FILTER_TYPE_STACKWALK_NAME = (0x80002000);

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_FILTER_TYPE_STACKWALK_LEVEL_KW"]/*' />
    [NativeTypeName("#define EVENT_FILTER_TYPE_STACKWALK_LEVEL_KW (0x80004000)")]
    public const uint EVENT_FILTER_TYPE_STACKWALK_LEVEL_KW = (0x80004000);

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_FILTER_TYPE_CONTAINER"]/*' />
    [NativeTypeName("#define EVENT_FILTER_TYPE_CONTAINER (0x80008000)")]
    public const uint EVENT_FILTER_TYPE_CONTAINER = (0x80008000);

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_DATA_DESCRIPTOR_TYPE_NONE"]/*' />
    [NativeTypeName("#define EVENT_DATA_DESCRIPTOR_TYPE_NONE (0)")]
    public const int EVENT_DATA_DESCRIPTOR_TYPE_NONE = (0);

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_DATA_DESCRIPTOR_TYPE_EVENT_METADATA"]/*' />
    [NativeTypeName("#define EVENT_DATA_DESCRIPTOR_TYPE_EVENT_METADATA (1)")]
    public const int EVENT_DATA_DESCRIPTOR_TYPE_EVENT_METADATA = (1);

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_DATA_DESCRIPTOR_TYPE_PROVIDER_METADATA"]/*' />
    [NativeTypeName("#define EVENT_DATA_DESCRIPTOR_TYPE_PROVIDER_METADATA (2)")]
    public const int EVENT_DATA_DESCRIPTOR_TYPE_PROVIDER_METADATA = (2);

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_DATA_DESCRIPTOR_TYPE_TIMESTAMP_OVERRIDE"]/*' />
    [NativeTypeName("#define EVENT_DATA_DESCRIPTOR_TYPE_TIMESTAMP_OVERRIDE (3)")]
    public const int EVENT_DATA_DESCRIPTOR_TYPE_TIMESTAMP_OVERRIDE = (3);

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_DATA_DESCRIPTOR_TYPE_RESERVED1"]/*' />
    [NativeTypeName("#define EVENT_DATA_DESCRIPTOR_TYPE_RESERVED1 (4)")]
    public const int EVENT_DATA_DESCRIPTOR_TYPE_RESERVED1 = (4);

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_WRITE_FLAG_NO_FAULTING"]/*' />
    [NativeTypeName("#define EVENT_WRITE_FLAG_NO_FAULTING 0x00000001")]
    public const int EVENT_WRITE_FLAG_NO_FAULTING = 0x00000001;

    /// <include file='EVENT.xml' path='doc/member[@name="EVENT.EVENT_WRITE_FLAG_INPRIVATE"]/*' />
    [NativeTypeName("#define EVENT_WRITE_FLAG_INPRIVATE 0x00000002")]
    public const int EVENT_WRITE_FLAG_INPRIVATE = 0x00000002;
}
