// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_SERVICE_CONFIG_SETTING_KEY.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SETTING_KEY"]/*' />
public enum HTTP_SERVICE_CONFIG_SETTING_KEY
{
    /// <include file='HTTP_SERVICE_CONFIG_SETTING_KEY.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SETTING_KEY.HttpNone"]/*' />
    HttpNone = 0,

    /// <include file='HTTP_SERVICE_CONFIG_SETTING_KEY.xml' path='doc/member[@name="HTTP_SERVICE_CONFIG_SETTING_KEY.HttpTlsThrottle"]/*' />
    HttpTlsThrottle,
}
