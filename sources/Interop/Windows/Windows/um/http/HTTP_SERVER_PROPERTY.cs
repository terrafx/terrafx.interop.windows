// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_SERVER_PROPERTY.xml' path='doc/member[@name="HTTP_SERVER_PROPERTY"]/*' />
public enum HTTP_SERVER_PROPERTY
{
    /// <include file='HTTP_SERVER_PROPERTY.xml' path='doc/member[@name="HTTP_SERVER_PROPERTY.HttpServerAuthenticationProperty"]/*' />
    HttpServerAuthenticationProperty = 0,

    /// <include file='HTTP_SERVER_PROPERTY.xml' path='doc/member[@name="HTTP_SERVER_PROPERTY.HttpServerLoggingProperty"]/*' />
    HttpServerLoggingProperty = 1,

    /// <include file='HTTP_SERVER_PROPERTY.xml' path='doc/member[@name="HTTP_SERVER_PROPERTY.HttpServerQosProperty"]/*' />
    HttpServerQosProperty = 2,

    /// <include file='HTTP_SERVER_PROPERTY.xml' path='doc/member[@name="HTTP_SERVER_PROPERTY.HttpServerTimeoutsProperty"]/*' />
    HttpServerTimeoutsProperty = 3,

    /// <include file='HTTP_SERVER_PROPERTY.xml' path='doc/member[@name="HTTP_SERVER_PROPERTY.HttpServerQueueLengthProperty"]/*' />
    HttpServerQueueLengthProperty = 4,

    /// <include file='HTTP_SERVER_PROPERTY.xml' path='doc/member[@name="HTTP_SERVER_PROPERTY.HttpServerStateProperty"]/*' />
    HttpServerStateProperty = 5,

    /// <include file='HTTP_SERVER_PROPERTY.xml' path='doc/member[@name="HTTP_SERVER_PROPERTY.HttpServer503VerbosityProperty"]/*' />
    HttpServer503VerbosityProperty = 6,

    /// <include file='HTTP_SERVER_PROPERTY.xml' path='doc/member[@name="HTTP_SERVER_PROPERTY.HttpServerBindingProperty"]/*' />
    HttpServerBindingProperty = 7,

    /// <include file='HTTP_SERVER_PROPERTY.xml' path='doc/member[@name="HTTP_SERVER_PROPERTY.HttpServerExtendedAuthenticationProperty"]/*' />
    HttpServerExtendedAuthenticationProperty = 8,

    /// <include file='HTTP_SERVER_PROPERTY.xml' path='doc/member[@name="HTTP_SERVER_PROPERTY.HttpServerListenEndpointProperty"]/*' />
    HttpServerListenEndpointProperty = 9,

    /// <include file='HTTP_SERVER_PROPERTY.xml' path='doc/member[@name="HTTP_SERVER_PROPERTY.HttpServerChannelBindProperty"]/*' />
    HttpServerChannelBindProperty = 10,

    /// <include file='HTTP_SERVER_PROPERTY.xml' path='doc/member[@name="HTTP_SERVER_PROPERTY.HttpServerProtectionLevelProperty"]/*' />
    HttpServerProtectionLevelProperty = 11,

    /// <include file='HTTP_SERVER_PROPERTY.xml' path='doc/member[@name="HTTP_SERVER_PROPERTY.HttpServerDelegationProperty"]/*' />
    HttpServerDelegationProperty = 16,

    /// <include file='HTTP_SERVER_PROPERTY.xml' path='doc/member[@name="HTTP_SERVER_PROPERTY.HttpServerFastForwardingProperty"]/*' />
    HttpServerFastForwardingProperty = 18,
}
