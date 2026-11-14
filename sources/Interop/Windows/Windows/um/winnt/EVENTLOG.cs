// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class EVENTLOG
{
    /// <include file='EVENTLOG.xml' path='doc/member[@name="EVENTLOG.EVENTLOG_SEQUENTIAL_READ"]/*' />
    [NativeTypeName("#define EVENTLOG_SEQUENTIAL_READ 0x0001")]
    public const int EVENTLOG_SEQUENTIAL_READ = 0x0001;

    /// <include file='EVENTLOG.xml' path='doc/member[@name="EVENTLOG.EVENTLOG_SEEK_READ"]/*' />
    [NativeTypeName("#define EVENTLOG_SEEK_READ 0x0002")]
    public const int EVENTLOG_SEEK_READ = 0x0002;

    /// <include file='EVENTLOG.xml' path='doc/member[@name="EVENTLOG.EVENTLOG_FORWARDS_READ"]/*' />
    [NativeTypeName("#define EVENTLOG_FORWARDS_READ 0x0004")]
    public const int EVENTLOG_FORWARDS_READ = 0x0004;

    /// <include file='EVENTLOG.xml' path='doc/member[@name="EVENTLOG.EVENTLOG_BACKWARDS_READ"]/*' />
    [NativeTypeName("#define EVENTLOG_BACKWARDS_READ 0x0008")]
    public const int EVENTLOG_BACKWARDS_READ = 0x0008;

    /// <include file='EVENTLOG.xml' path='doc/member[@name="EVENTLOG.EVENTLOG_SUCCESS"]/*' />
    [NativeTypeName("#define EVENTLOG_SUCCESS 0x0000")]
    public const int EVENTLOG_SUCCESS = 0x0000;

    /// <include file='EVENTLOG.xml' path='doc/member[@name="EVENTLOG.EVENTLOG_ERROR_TYPE"]/*' />
    [NativeTypeName("#define EVENTLOG_ERROR_TYPE 0x0001")]
    public const int EVENTLOG_ERROR_TYPE = 0x0001;

    /// <include file='EVENTLOG.xml' path='doc/member[@name="EVENTLOG.EVENTLOG_WARNING_TYPE"]/*' />
    [NativeTypeName("#define EVENTLOG_WARNING_TYPE 0x0002")]
    public const int EVENTLOG_WARNING_TYPE = 0x0002;

    /// <include file='EVENTLOG.xml' path='doc/member[@name="EVENTLOG.EVENTLOG_INFORMATION_TYPE"]/*' />
    [NativeTypeName("#define EVENTLOG_INFORMATION_TYPE 0x0004")]
    public const int EVENTLOG_INFORMATION_TYPE = 0x0004;

    /// <include file='EVENTLOG.xml' path='doc/member[@name="EVENTLOG.EVENTLOG_AUDIT_SUCCESS"]/*' />
    [NativeTypeName("#define EVENTLOG_AUDIT_SUCCESS 0x0008")]
    public const int EVENTLOG_AUDIT_SUCCESS = 0x0008;

    /// <include file='EVENTLOG.xml' path='doc/member[@name="EVENTLOG.EVENTLOG_AUDIT_FAILURE"]/*' />
    [NativeTypeName("#define EVENTLOG_AUDIT_FAILURE 0x0010")]
    public const int EVENTLOG_AUDIT_FAILURE = 0x0010;

    /// <include file='EVENTLOG.xml' path='doc/member[@name="EVENTLOG.EVENTLOG_START_PAIRED_EVENT"]/*' />
    [NativeTypeName("#define EVENTLOG_START_PAIRED_EVENT 0x0001")]
    public const int EVENTLOG_START_PAIRED_EVENT = 0x0001;

    /// <include file='EVENTLOG.xml' path='doc/member[@name="EVENTLOG.EVENTLOG_END_PAIRED_EVENT"]/*' />
    [NativeTypeName("#define EVENTLOG_END_PAIRED_EVENT 0x0002")]
    public const int EVENTLOG_END_PAIRED_EVENT = 0x0002;

    /// <include file='EVENTLOG.xml' path='doc/member[@name="EVENTLOG.EVENTLOG_END_ALL_PAIRED_EVENTS"]/*' />
    [NativeTypeName("#define EVENTLOG_END_ALL_PAIRED_EVENTS 0x0004")]
    public const int EVENTLOG_END_ALL_PAIRED_EVENTS = 0x0004;

    /// <include file='EVENTLOG.xml' path='doc/member[@name="EVENTLOG.EVENTLOG_PAIRED_EVENT_ACTIVE"]/*' />
    [NativeTypeName("#define EVENTLOG_PAIRED_EVENT_ACTIVE 0x0008")]
    public const int EVENTLOG_PAIRED_EVENT_ACTIVE = 0x0008;

    /// <include file='EVENTLOG.xml' path='doc/member[@name="EVENTLOG.EVENTLOG_PAIRED_EVENT_INACTIVE"]/*' />
    [NativeTypeName("#define EVENTLOG_PAIRED_EVENT_INACTIVE 0x0010")]
    public const int EVENTLOG_PAIRED_EVENT_INACTIVE = 0x0010;
}
