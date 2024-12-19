// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_RESPONSE_INFO_TYPE.xml' path='doc/member[@name="HTTP_RESPONSE_INFO_TYPE"]/*' />
public enum HTTP_RESPONSE_INFO_TYPE
{
    /// <include file='HTTP_RESPONSE_INFO_TYPE.xml' path='doc/member[@name="HTTP_RESPONSE_INFO_TYPE.HttpResponseInfoTypeMultipleKnownHeaders"]/*' />
    HttpResponseInfoTypeMultipleKnownHeaders,

    /// <include file='HTTP_RESPONSE_INFO_TYPE.xml' path='doc/member[@name="HTTP_RESPONSE_INFO_TYPE.HttpResponseInfoTypeAuthenticationProperty"]/*' />
    HttpResponseInfoTypeAuthenticationProperty,

    /// <include file='HTTP_RESPONSE_INFO_TYPE.xml' path='doc/member[@name="HTTP_RESPONSE_INFO_TYPE.HttpResponseInfoTypeQoSProperty"]/*' />
    HttpResponseInfoTypeQoSProperty,

    /// <include file='HTTP_RESPONSE_INFO_TYPE.xml' path='doc/member[@name="HTTP_RESPONSE_INFO_TYPE.HttpResponseInfoTypeChannelBind"]/*' />
    HttpResponseInfoTypeChannelBind,
}
