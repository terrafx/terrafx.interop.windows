// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='RemoteSystemDiscoveryType.xml' path='doc/member[@name="RemoteSystemDiscoveryType"]/*' />
public enum RemoteSystemDiscoveryType
{
    /// <include file='RemoteSystemDiscoveryType.xml' path='doc/member[@name="RemoteSystemDiscoveryType.RemoteSystemDiscoveryType_Any"]/*' />
    RemoteSystemDiscoveryType_Any = 0,

    /// <include file='RemoteSystemDiscoveryType.xml' path='doc/member[@name="RemoteSystemDiscoveryType.RemoteSystemDiscoveryType_Proximal"]/*' />
    RemoteSystemDiscoveryType_Proximal = 1,

    /// <include file='RemoteSystemDiscoveryType.xml' path='doc/member[@name="RemoteSystemDiscoveryType.RemoteSystemDiscoveryType_Cloud"]/*' />
    RemoteSystemDiscoveryType_Cloud = 2,

    /// <include file='RemoteSystemDiscoveryType.xml' path='doc/member[@name="RemoteSystemDiscoveryType.RemoteSystemDiscoveryType_SpatiallyProximal"]/*' />
    RemoteSystemDiscoveryType_SpatiallyProximal = 3,
}
