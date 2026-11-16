// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WINHTTP_CONNECTION_PROXY_TYPE.xml' path='doc/member[@name="WINHTTP_CONNECTION_PROXY_TYPE"]/*' />
public enum WINHTTP_CONNECTION_PROXY_TYPE
{
    /// <include file='WINHTTP_CONNECTION_PROXY_TYPE.xml' path='doc/member[@name="WINHTTP_CONNECTION_PROXY_TYPE.WINHTTP_CONNECTION_PROXY_TYPE_NULL"]/*' />
    WINHTTP_CONNECTION_PROXY_TYPE_NULL = 0,

    /// <include file='WINHTTP_CONNECTION_PROXY_TYPE.xml' path='doc/member[@name="WINHTTP_CONNECTION_PROXY_TYPE.WINHTTP_CONNECTION_PROXY_TYPE_HTTP"]/*' />
    WINHTTP_CONNECTION_PROXY_TYPE_HTTP = 1,

    /// <include file='WINHTTP_CONNECTION_PROXY_TYPE.xml' path='doc/member[@name="WINHTTP_CONNECTION_PROXY_TYPE.WINHTTP_CONNECTION_PROXY_TYPE_SOCKS"]/*' />
    WINHTTP_CONNECTION_PROXY_TYPE_SOCKS = 2,
}
