// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WINHTTP_CONNECTION_INFO.xml' path='doc/member[@name="WINHTTP_CONNECTION_INFO"]/*' />
public partial struct WINHTTP_CONNECTION_INFO
{
    /// <include file='WINHTTP_CONNECTION_INFO.xml' path='doc/member[@name="WINHTTP_CONNECTION_INFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='WINHTTP_CONNECTION_INFO.xml' path='doc/member[@name="WINHTTP_CONNECTION_INFO.LocalAddress"]/*' />
    public SOCKADDR_STORAGE LocalAddress;

    /// <include file='WINHTTP_CONNECTION_INFO.xml' path='doc/member[@name="WINHTTP_CONNECTION_INFO.RemoteAddress"]/*' />
    public SOCKADDR_STORAGE RemoteAddress;
}
