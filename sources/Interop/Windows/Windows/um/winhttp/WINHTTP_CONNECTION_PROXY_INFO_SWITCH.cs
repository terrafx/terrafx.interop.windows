// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WINHTTP_CONNECTION_PROXY_INFO_SWITCH.xml' path='doc/member[@name="WINHTTP_CONNECTION_PROXY_INFO_SWITCH"]/*' />
public enum WINHTTP_CONNECTION_PROXY_INFO_SWITCH
{
    /// <include file='WINHTTP_CONNECTION_PROXY_INFO_SWITCH.xml' path='doc/member[@name="WINHTTP_CONNECTION_PROXY_INFO_SWITCH.WINHTTP_CONNECTION_PROXY_INFO_SWITCH_CONFIG"]/*' />
    WINHTTP_CONNECTION_PROXY_INFO_SWITCH_CONFIG = 0,

    /// <include file='WINHTTP_CONNECTION_PROXY_INFO_SWITCH.xml' path='doc/member[@name="WINHTTP_CONNECTION_PROXY_INFO_SWITCH.WINHTTP_CONNECTION_PROXY_INFO_SWITCH_SCRIPT"]/*' />
    WINHTTP_CONNECTION_PROXY_INFO_SWITCH_SCRIPT,

    /// <include file='WINHTTP_CONNECTION_PROXY_INFO_SWITCH.xml' path='doc/member[@name="WINHTTP_CONNECTION_PROXY_INFO_SWITCH.WINHTTP_CONNECTION_PROXY_INFO_SWITCH_WPAD"]/*' />
    WINHTTP_CONNECTION_PROXY_INFO_SWITCH_WPAD,
}
