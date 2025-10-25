// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_FEATURE_ID.xml' path='doc/member[@name="HTTP_FEATURE_ID"]/*' />
public enum HTTP_FEATURE_ID
{
    /// <include file='HTTP_FEATURE_ID.xml' path='doc/member[@name="HTTP_FEATURE_ID.HttpFeatureUnknown"]/*' />
    HttpFeatureUnknown = 0,

    /// <include file='HTTP_FEATURE_ID.xml' path='doc/member[@name="HTTP_FEATURE_ID.HttpFeatureResponseTrailers"]/*' />
    HttpFeatureResponseTrailers = 1,

    /// <include file='HTTP_FEATURE_ID.xml' path='doc/member[@name="HTTP_FEATURE_ID.HttpFeatureApiTimings"]/*' />
    HttpFeatureApiTimings = 2,

    /// <include file='HTTP_FEATURE_ID.xml' path='doc/member[@name="HTTP_FEATURE_ID.HttpFeatureDelegateEx"]/*' />
    HttpFeatureDelegateEx = 3,

    /// <include file='HTTP_FEATURE_ID.xml' path='doc/member[@name="HTTP_FEATURE_ID.HttpFeatureHttp3"]/*' />
    HttpFeatureHttp3 = 4,

    /// <include file='HTTP_FEATURE_ID.xml' path='doc/member[@name="HTTP_FEATURE_ID.HttpFeatureTlsSessionTickets"]/*' />
    HttpFeatureTlsSessionTickets = 5,

    /// <include file='HTTP_FEATURE_ID.xml' path='doc/member[@name="HTTP_FEATURE_ID.HttpFeatureDisableTlsSessionId"]/*' />
    HttpFeatureDisableTlsSessionId = 6,

    /// <include file='HTTP_FEATURE_ID.xml' path='doc/member[@name="HTTP_FEATURE_ID.HttpFeatureTlsDualCerts"]/*' />
    HttpFeatureTlsDualCerts = 7,

    /// <include file='HTTP_FEATURE_ID.xml' path='doc/member[@name="HTTP_FEATURE_ID.HttpFeatureAutomaticChunkedEncoding"]/*' />
    HttpFeatureAutomaticChunkedEncoding = 8,

    /// <include file='HTTP_FEATURE_ID.xml' path='doc/member[@name="HTTP_FEATURE_ID.HttpFeatureDedicatedReqQueueDelegationType"]/*' />
    HttpFeatureDedicatedReqQueueDelegationType = 9,

    /// <include file='HTTP_FEATURE_ID.xml' path='doc/member[@name="HTTP_FEATURE_ID.HttpFeatureFastForwardResponse"]/*' />
    HttpFeatureFastForwardResponse = 10,

    /// <include file='HTTP_FEATURE_ID.xml' path='doc/member[@name="HTTP_FEATURE_ID.HttpFeatureCacheTlsClientHello"]/*' />
    HttpFeatureCacheTlsClientHello = 11,

    /// <include file='HTTP_FEATURE_ID.xml' path='doc/member[@name="HTTP_FEATURE_ID.HttpFeatureIdleConnectionTimeoutRequestProperty"]/*' />
    HttpFeatureIdleConnectionTimeoutRequestProperty = 12,

    /// <include file='HTTP_FEATURE_ID.xml' path='doc/member[@name="HTTP_FEATURE_ID.HttpFeatureDisableAiaFlag"]/*' />
    HttpFeatureDisableAiaFlag = 13,

    /// <include file='HTTP_FEATURE_ID.xml' path='doc/member[@name="HTTP_FEATURE_ID.HttpFeatureDscp"]/*' />
    HttpFeatureDscp = 14,

    /// <include file='HTTP_FEATURE_ID.xml' path='doc/member[@name="HTTP_FEATURE_ID.HttpFeatureQueryCipherInfo"]/*' />
    HttpFeatureQueryCipherInfo = 15,

    /// <include file='HTTP_FEATURE_ID.xml' path='doc/member[@name="HTTP_FEATURE_ID.HttpFeatureQueryInitialPacketTtl"]/*' />
    HttpFeatureQueryInitialPacketTtl = 16,

    /// <include file='HTTP_FEATURE_ID.xml' path='doc/member[@name="HTTP_FEATURE_ID.HttpFeatureLast"]/*' />
    HttpFeatureLast = 17,

    /// <include file='HTTP_FEATURE_ID.xml' path='doc/member[@name="HTTP_FEATURE_ID.HttpFeaturemax"]/*' />
    HttpFeaturemax = unchecked((int)(0xFFFFFFFF)),
}
