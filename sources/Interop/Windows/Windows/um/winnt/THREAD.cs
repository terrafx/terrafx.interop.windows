// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class THREAD
{
    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_TERMINATE"]/*' />
    [NativeTypeName("#define THREAD_TERMINATE (0x0001)")]
    public const int THREAD_TERMINATE = (0x0001);

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_SUSPEND_RESUME"]/*' />
    [NativeTypeName("#define THREAD_SUSPEND_RESUME (0x0002)")]
    public const int THREAD_SUSPEND_RESUME = (0x0002);

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_GET_CONTEXT"]/*' />
    [NativeTypeName("#define THREAD_GET_CONTEXT (0x0008)")]
    public const int THREAD_GET_CONTEXT = (0x0008);

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_SET_CONTEXT"]/*' />
    [NativeTypeName("#define THREAD_SET_CONTEXT (0x0010)")]
    public const int THREAD_SET_CONTEXT = (0x0010);

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_QUERY_INFORMATION"]/*' />
    [NativeTypeName("#define THREAD_QUERY_INFORMATION (0x0040)")]
    public const int THREAD_QUERY_INFORMATION = (0x0040);

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_SET_INFORMATION"]/*' />
    [NativeTypeName("#define THREAD_SET_INFORMATION (0x0020)")]
    public const int THREAD_SET_INFORMATION = (0x0020);

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_SET_THREAD_TOKEN"]/*' />
    [NativeTypeName("#define THREAD_SET_THREAD_TOKEN (0x0080)")]
    public const int THREAD_SET_THREAD_TOKEN = (0x0080);

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_IMPERSONATE"]/*' />
    [NativeTypeName("#define THREAD_IMPERSONATE (0x0100)")]
    public const int THREAD_IMPERSONATE = (0x0100);

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_DIRECT_IMPERSONATION"]/*' />
    [NativeTypeName("#define THREAD_DIRECT_IMPERSONATION (0x0200)")]
    public const int THREAD_DIRECT_IMPERSONATION = (0x0200);

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_SET_LIMITED_INFORMATION"]/*' />
    [NativeTypeName("#define THREAD_SET_LIMITED_INFORMATION (0x0400)")]
    public const int THREAD_SET_LIMITED_INFORMATION = (0x0400);

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_QUERY_LIMITED_INFORMATION"]/*' />
    [NativeTypeName("#define THREAD_QUERY_LIMITED_INFORMATION (0x0800)")]
    public const int THREAD_QUERY_LIMITED_INFORMATION = (0x0800);

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_RESUME"]/*' />
    [NativeTypeName("#define THREAD_RESUME (0x1000)")]
    public const int THREAD_RESUME = (0x1000);

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_ALL_ACCESS"]/*' />
    [NativeTypeName("#define THREAD_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | \\\r\n                                   0xFFFF)")]
    public const int THREAD_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0xFFFF);

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_DYNAMIC_CODE_ALLOW"]/*' />
    [NativeTypeName("#define THREAD_DYNAMIC_CODE_ALLOW 1")]
    public const int THREAD_DYNAMIC_CODE_ALLOW = 1;

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_BASE_PRIORITY_LOWRT"]/*' />
    [NativeTypeName("#define THREAD_BASE_PRIORITY_LOWRT 15")]
    public const int THREAD_BASE_PRIORITY_LOWRT = 15;

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_BASE_PRIORITY_MAX"]/*' />
    [NativeTypeName("#define THREAD_BASE_PRIORITY_MAX 2")]
    public const int THREAD_BASE_PRIORITY_MAX = 2;

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_BASE_PRIORITY_MIN"]/*' />
    [NativeTypeName("#define THREAD_BASE_PRIORITY_MIN (-2)")]
    public const int THREAD_BASE_PRIORITY_MIN = (-2);

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_BASE_PRIORITY_IDLE"]/*' />
    [NativeTypeName("#define THREAD_BASE_PRIORITY_IDLE (-15)")]
    public const int THREAD_BASE_PRIORITY_IDLE = (-15);

    /// <include file='THREAD.xml' path='doc/member[@name="THREAD.THREAD_PROFILING_FLAG_DISPATCH"]/*' />
    [NativeTypeName("#define THREAD_PROFILING_FLAG_DISPATCH 0x00000001")]
    public const int THREAD_PROFILING_FLAG_DISPATCH = 0x00000001;
}
