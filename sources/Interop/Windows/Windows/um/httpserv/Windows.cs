// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RQ_BEGIN_REQUEST"]/*' />
    [NativeTypeName("#define RQ_BEGIN_REQUEST 0x00000001")]
    public const int RQ_BEGIN_REQUEST = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RQ_AUTHENTICATE_REQUEST"]/*' />
    [NativeTypeName("#define RQ_AUTHENTICATE_REQUEST 0x00000002")]
    public const int RQ_AUTHENTICATE_REQUEST = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RQ_AUTHORIZE_REQUEST"]/*' />
    [NativeTypeName("#define RQ_AUTHORIZE_REQUEST 0x00000004")]
    public const int RQ_AUTHORIZE_REQUEST = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RQ_RESOLVE_REQUEST_CACHE"]/*' />
    [NativeTypeName("#define RQ_RESOLVE_REQUEST_CACHE 0x00000008")]
    public const int RQ_RESOLVE_REQUEST_CACHE = 0x00000008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RQ_MAP_REQUEST_HANDLER"]/*' />
    [NativeTypeName("#define RQ_MAP_REQUEST_HANDLER 0x00000010")]
    public const int RQ_MAP_REQUEST_HANDLER = 0x00000010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RQ_ACQUIRE_REQUEST_STATE"]/*' />
    [NativeTypeName("#define RQ_ACQUIRE_REQUEST_STATE 0x00000020")]
    public const int RQ_ACQUIRE_REQUEST_STATE = 0x00000020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RQ_PRE_EXECUTE_REQUEST_HANDLER"]/*' />
    [NativeTypeName("#define RQ_PRE_EXECUTE_REQUEST_HANDLER 0x00000040")]
    public const int RQ_PRE_EXECUTE_REQUEST_HANDLER = 0x00000040;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RQ_EXECUTE_REQUEST_HANDLER"]/*' />
    [NativeTypeName("#define RQ_EXECUTE_REQUEST_HANDLER 0x00000080")]
    public const int RQ_EXECUTE_REQUEST_HANDLER = 0x00000080;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RQ_RELEASE_REQUEST_STATE"]/*' />
    [NativeTypeName("#define RQ_RELEASE_REQUEST_STATE 0x00000100")]
    public const int RQ_RELEASE_REQUEST_STATE = 0x00000100;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RQ_UPDATE_REQUEST_CACHE"]/*' />
    [NativeTypeName("#define RQ_UPDATE_REQUEST_CACHE 0x00000200")]
    public const int RQ_UPDATE_REQUEST_CACHE = 0x00000200;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RQ_LOG_REQUEST"]/*' />
    [NativeTypeName("#define RQ_LOG_REQUEST 0x00000400")]
    public const int RQ_LOG_REQUEST = 0x00000400;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RQ_END_REQUEST"]/*' />
    [NativeTypeName("#define RQ_END_REQUEST 0x00000800")]
    public const int RQ_END_REQUEST = 0x00000800;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RQ_SEND_RESPONSE_STATUS_AND_HEADERS"]/*' />
    [NativeTypeName("#define RQ_SEND_RESPONSE_STATUS_AND_HEADERS 0x08000000")]
    public const int RQ_SEND_RESPONSE_STATUS_AND_HEADERS = 0x08000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RQ_CUSTOM_NOTIFICATION"]/*' />
    [NativeTypeName("#define RQ_CUSTOM_NOTIFICATION 0x10000000")]
    public const int RQ_CUSTOM_NOTIFICATION = 0x10000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RQ_SEND_RESPONSE"]/*' />
    [NativeTypeName("#define RQ_SEND_RESPONSE 0x20000000")]
    public const int RQ_SEND_RESPONSE = 0x20000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RQ_READ_ENTITY"]/*' />
    [NativeTypeName("#define RQ_READ_ENTITY 0x40000000")]
    public const int RQ_READ_ENTITY = 0x40000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.RQ_MAP_PATH"]/*' />
    [NativeTypeName("#define RQ_MAP_PATH 0x80000000")]
    public const uint RQ_MAP_PATH = 0x80000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PRIORITY_ALIAS_FIRST"]/*' />
    [NativeTypeName("#define PRIORITY_ALIAS_FIRST L\"FIRST\"")]
    public const string PRIORITY_ALIAS_FIRST = "FIRST";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PRIORITY_ALIAS_HIGH"]/*' />
    [NativeTypeName("#define PRIORITY_ALIAS_HIGH L\"HIGH\"")]
    public const string PRIORITY_ALIAS_HIGH = "HIGH";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PRIORITY_ALIAS_MEDIUM"]/*' />
    [NativeTypeName("#define PRIORITY_ALIAS_MEDIUM L\"MEDIUM\"")]
    public const string PRIORITY_ALIAS_MEDIUM = "MEDIUM";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PRIORITY_ALIAS_LOW"]/*' />
    [NativeTypeName("#define PRIORITY_ALIAS_LOW L\"LOW\"")]
    public const string PRIORITY_ALIAS_LOW = "LOW";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PRIORITY_ALIAS_LAST"]/*' />
    [NativeTypeName("#define PRIORITY_ALIAS_LAST L\"LAST\"")]
    public const string PRIORITY_ALIAS_LAST = "LAST";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLONE_FLAG_BASICS"]/*' />
    [NativeTypeName("#define CLONE_FLAG_BASICS 0x01")]
    public const int CLONE_FLAG_BASICS = 0x01;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLONE_FLAG_HEADERS"]/*' />
    [NativeTypeName("#define CLONE_FLAG_HEADERS 0x02")]
    public const int CLONE_FLAG_HEADERS = 0x02;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLONE_FLAG_ENTITY"]/*' />
    [NativeTypeName("#define CLONE_FLAG_ENTITY 0x04")]
    public const int CLONE_FLAG_ENTITY = 0x04;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLONE_FLAG_NO_PRECONDITION"]/*' />
    [NativeTypeName("#define CLONE_FLAG_NO_PRECONDITION 0x08")]
    public const int CLONE_FLAG_NO_PRECONDITION = 0x08;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLONE_FLAG_NO_DAV"]/*' />
    [NativeTypeName("#define CLONE_FLAG_NO_DAV 0x10")]
    public const int CLONE_FLAG_NO_DAV = 0x10;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLONE_FLAG_USER_CACHE_VARY_BY"]/*' />
    [NativeTypeName("#define CLONE_FLAG_USER_CACHE_VARY_BY 0x20")]
    public const int CLONE_FLAG_USER_CACHE_VARY_BY = 0x20;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLONE_FLAG_SERVER_VARIABLE"]/*' />
    [NativeTypeName("#define CLONE_FLAG_SERVER_VARIABLE 0x40")]
    public const int CLONE_FLAG_SERVER_VARIABLE = 0x40;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EXECUTE_FLAG_NO_HEADERS"]/*' />
    [NativeTypeName("#define EXECUTE_FLAG_NO_HEADERS 0x01")]
    public const int EXECUTE_FLAG_NO_HEADERS = 0x01;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EXECUTE_FLAG_IGNORE_CURRENT_INTERCEPTOR"]/*' />
    [NativeTypeName("#define EXECUTE_FLAG_IGNORE_CURRENT_INTERCEPTOR 0x02")]
    public const int EXECUTE_FLAG_IGNORE_CURRENT_INTERCEPTOR = 0x02;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EXECUTE_FLAG_IGNORE_APPPOOL"]/*' />
    [NativeTypeName("#define EXECUTE_FLAG_IGNORE_APPPOOL 0x04")]
    public const int EXECUTE_FLAG_IGNORE_APPPOOL = 0x04;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EXECUTE_FLAG_DISABLE_CUSTOM_ERROR"]/*' />
    [NativeTypeName("#define EXECUTE_FLAG_DISABLE_CUSTOM_ERROR 0x08")]
    public const int EXECUTE_FLAG_DISABLE_CUSTOM_ERROR = 0x08;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EXECUTE_FLAG_SAME_URL"]/*' />
    [NativeTypeName("#define EXECUTE_FLAG_SAME_URL 0x10")]
    public const int EXECUTE_FLAG_SAME_URL = 0x10;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EXECUTE_FLAG_BUFFER_RESPONSE"]/*' />
    [NativeTypeName("#define EXECUTE_FLAG_BUFFER_RESPONSE 0x20")]
    public const int EXECUTE_FLAG_BUFFER_RESPONSE = 0x20;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.EXECUTE_FLAG_HTTP_CACHE_ELIGIBLE"]/*' />
    [NativeTypeName("#define EXECUTE_FLAG_HTTP_CACHE_ELIGIBLE 0x40")]
    public const int EXECUTE_FLAG_HTTP_CACHE_ELIGIBLE = 0x40;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MODULE_REGISTERMODULE"]/*' />
    [NativeTypeName("#define MODULE_REGISTERMODULE \"RegisterModule\"")]
    public static ReadOnlySpan<byte> MODULE_REGISTERMODULE => "RegisterModule"u8;
}
