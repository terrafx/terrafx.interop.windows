// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_SERVICE_CONFIG_QUERY_TYPE.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_QUERY_TYPE"]/*' />
public enum HTTP_SERVICE_CONFIG_QUERY_TYPE
{
    /// <include file='HTTP_SERVICE_CONFIG_QUERY_TYPE.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_QUERY_TYPE.HttpServiceConfigQueryExact"]/*' />
    HttpServiceConfigQueryExact,

    /// <include file='HTTP_SERVICE_CONFIG_QUERY_TYPE.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_QUERY_TYPE.HttpServiceConfigQueryNext"]/*' />
    HttpServiceConfigQueryNext,

    /// <include file='HTTP_SERVICE_CONFIG_QUERY_TYPE.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_QUERY_TYPE.HttpServiceConfigQueryMax"]/*' />
    HttpServiceConfigQueryMax,
}
