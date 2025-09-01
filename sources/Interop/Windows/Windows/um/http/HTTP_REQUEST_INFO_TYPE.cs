// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_REQUEST_INFO_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_INFO_TYPE"]/*' />
public enum HTTP_REQUEST_INFO_TYPE
{
    /// <include file='HTTP_REQUEST_INFO_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_INFO_TYPE.HttpRequestInfoTypeAuth"]/*' />
    HttpRequestInfoTypeAuth,

    /// <include file='HTTP_REQUEST_INFO_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_INFO_TYPE.HttpRequestInfoTypeChannelBind"]/*' />
    HttpRequestInfoTypeChannelBind,

    /// <include file='HTTP_REQUEST_INFO_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_INFO_TYPE.HttpRequestInfoTypeSslProtocol"]/*' />
    HttpRequestInfoTypeSslProtocol,

    /// <include file='HTTP_REQUEST_INFO_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_INFO_TYPE.HttpRequestInfoTypeSslTokenBindingDraft"]/*' />
    HttpRequestInfoTypeSslTokenBindingDraft,

    /// <include file='HTTP_REQUEST_INFO_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_INFO_TYPE.HttpRequestInfoTypeSslTokenBinding"]/*' />
    HttpRequestInfoTypeSslTokenBinding,

    /// <include file='HTTP_REQUEST_INFO_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_INFO_TYPE.HttpRequestInfoTypeRequestTiming"]/*' />
    HttpRequestInfoTypeRequestTiming,

    /// <include file='HTTP_REQUEST_INFO_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_INFO_TYPE.HttpRequestInfoTypeTcpInfoV0"]/*' />
    HttpRequestInfoTypeTcpInfoV0,

    /// <include file='HTTP_REQUEST_INFO_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_INFO_TYPE.HttpRequestInfoTypeRequestSizing"]/*' />
    HttpRequestInfoTypeRequestSizing,

    /// <include file='HTTP_REQUEST_INFO_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_INFO_TYPE.HttpRequestInfoTypeQuicStats"]/*' />
    HttpRequestInfoTypeQuicStats,

    /// <include file='HTTP_REQUEST_INFO_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_INFO_TYPE.HttpRequestInfoTypeTcpInfoV1"]/*' />
    HttpRequestInfoTypeTcpInfoV1,

    /// <include file='HTTP_REQUEST_INFO_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_INFO_TYPE.HttpRequestInfoTypeQuicStatsV2"]/*' />
    HttpRequestInfoTypeQuicStatsV2,

    /// <include file='HTTP_REQUEST_INFO_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_INFO_TYPE.HttpRequestInfoTypeTcpInfoV2"]/*' />
    HttpRequestInfoTypeTcpInfoV2,

    /// <include file='HTTP_REQUEST_INFO_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_INFO_TYPE.HttpRequestInfoTypeTransportIdleConnectionTimeout"]/*' />
    HttpRequestInfoTypeTransportIdleConnectionTimeout,

    /// <include file='HTTP_REQUEST_INFO_TYPE.xml' path='doc/member[@name="HTTP_REQUEST_INFO_TYPE.HttpRequestInfoTypeDscpTag"]/*' />
    HttpRequestInfoTypeDscpTag,
}
