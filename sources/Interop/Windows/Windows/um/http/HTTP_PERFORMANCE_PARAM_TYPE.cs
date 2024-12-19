// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_PERFORMANCE_PARAM_TYPE.xml' path='doc/member[@name="HTTP_PERFORMANCE_PARAM_TYPE"]/*' />
public enum HTTP_PERFORMANCE_PARAM_TYPE
{
    /// <include file='HTTP_PERFORMANCE_PARAM_TYPE.xml' path='doc/member[@name="HTTP_PERFORMANCE_PARAM_TYPE.PerformanceParamSendBufferingFlags"]/*' />
    PerformanceParamSendBufferingFlags,

    /// <include file='HTTP_PERFORMANCE_PARAM_TYPE.xml' path='doc/member[@name="HTTP_PERFORMANCE_PARAM_TYPE.PerformanceParamAggressiveICW"]/*' />
    PerformanceParamAggressiveICW,

    /// <include file='HTTP_PERFORMANCE_PARAM_TYPE.xml' path='doc/member[@name="HTTP_PERFORMANCE_PARAM_TYPE.PerformanceParamMaxSendBufferSize"]/*' />
    PerformanceParamMaxSendBufferSize,

    /// <include file='HTTP_PERFORMANCE_PARAM_TYPE.xml' path='doc/member[@name="HTTP_PERFORMANCE_PARAM_TYPE.PerformanceParamMaxConcurrentClientStreams"]/*' />
    PerformanceParamMaxConcurrentClientStreams,

    /// <include file='HTTP_PERFORMANCE_PARAM_TYPE.xml' path='doc/member[@name="HTTP_PERFORMANCE_PARAM_TYPE.PerformanceParamMaxReceiveBufferSize"]/*' />
    PerformanceParamMaxReceiveBufferSize,

    /// <include file='HTTP_PERFORMANCE_PARAM_TYPE.xml' path='doc/member[@name="HTTP_PERFORMANCE_PARAM_TYPE.PerformanceParamDecryptOnSspiThread"]/*' />
    PerformanceParamDecryptOnSspiThread,

    /// <include file='HTTP_PERFORMANCE_PARAM_TYPE.xml' path='doc/member[@name="HTTP_PERFORMANCE_PARAM_TYPE.PerformanceParamMax"]/*' />
    PerformanceParamMax,
}
