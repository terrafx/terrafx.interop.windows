// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP2_SETTINGS_LIMITS_PARAM.xml' path='doc/member[@name="HTTP2_SETTINGS_LIMITS_PARAM"]/*' />
public partial struct HTTP2_SETTINGS_LIMITS_PARAM
{
    /// <include file='HTTP2_SETTINGS_LIMITS_PARAM.xml' path='doc/member[@name="HTTP2_SETTINGS_LIMITS_PARAM.Http2MaxSettingsPerFrame"]/*' />
    [NativeTypeName("DWORD")]
    public uint Http2MaxSettingsPerFrame;

    /// <include file='HTTP2_SETTINGS_LIMITS_PARAM.xml' path='doc/member[@name="HTTP2_SETTINGS_LIMITS_PARAM.Http2MaxSettingsPerMinute"]/*' />
    [NativeTypeName("DWORD")]
    public uint Http2MaxSettingsPerMinute;
}
