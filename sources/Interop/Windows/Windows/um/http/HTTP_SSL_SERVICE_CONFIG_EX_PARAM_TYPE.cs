// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_SSL_SERVICE_CONFIG_EX_PARAM_TYPE.xml' path='doc/member[@name="HTTP_SSL_SERVICE_CONFIG_EX_PARAM_TYPE"]/*' />
public enum HTTP_SSL_SERVICE_CONFIG_EX_PARAM_TYPE
{
    /// <include file='HTTP_SSL_SERVICE_CONFIG_EX_PARAM_TYPE.xml' path='doc/member[@name="HTTP_SSL_SERVICE_CONFIG_EX_PARAM_TYPE.ExParamTypeHttp2Window"]/*' />
    ExParamTypeHttp2Window,

    /// <include file='HTTP_SSL_SERVICE_CONFIG_EX_PARAM_TYPE.xml' path='doc/member[@name="HTTP_SSL_SERVICE_CONFIG_EX_PARAM_TYPE.ExParamTypeHttp2SettingsLimits"]/*' />
    ExParamTypeHttp2SettingsLimits,

    /// <include file='HTTP_SSL_SERVICE_CONFIG_EX_PARAM_TYPE.xml' path='doc/member[@name="HTTP_SSL_SERVICE_CONFIG_EX_PARAM_TYPE.ExParamTypeHttpPerformance"]/*' />
    ExParamTypeHttpPerformance,

    /// <include file='HTTP_SSL_SERVICE_CONFIG_EX_PARAM_TYPE.xml' path='doc/member[@name="HTTP_SSL_SERVICE_CONFIG_EX_PARAM_TYPE.ExParamTypeTlsRestrictions"]/*' />
    ExParamTypeTlsRestrictions,

    /// <include file='HTTP_SSL_SERVICE_CONFIG_EX_PARAM_TYPE.xml' path='doc/member[@name="HTTP_SSL_SERVICE_CONFIG_EX_PARAM_TYPE.ExParamTypeErrorHeaders"]/*' />
    ExParamTypeErrorHeaders,

    /// <include file='HTTP_SSL_SERVICE_CONFIG_EX_PARAM_TYPE.xml' path='doc/member[@name="HTTP_SSL_SERVICE_CONFIG_EX_PARAM_TYPE.ExParamTypeTlsSessionTicketKeys"]/*' />
    ExParamTypeTlsSessionTicketKeys,

    /// <include file='HTTP_SSL_SERVICE_CONFIG_EX_PARAM_TYPE.xml' path='doc/member[@name="HTTP_SSL_SERVICE_CONFIG_EX_PARAM_TYPE.ExParamTypeCertConfig"]/*' />
    ExParamTypeCertConfig,

    /// <include file='HTTP_SSL_SERVICE_CONFIG_EX_PARAM_TYPE.xml' path='doc/member[@name="HTTP_SSL_SERVICE_CONFIG_EX_PARAM_TYPE.ExParamTypeMax"]/*' />
    ExParamTypeMax,
}
