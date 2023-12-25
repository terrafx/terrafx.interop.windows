// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='HostNameType.xml' path='doc/member[@name="HostNameType"]/*' />
public enum HostNameType
{
    /// <include file='HostNameType.xml' path='doc/member[@name="HostNameType.HostNameType_DomainName"]/*' />
    HostNameType_DomainName = 0,

    /// <include file='HostNameType.xml' path='doc/member[@name="HostNameType.HostNameType_Ipv4"]/*' />
    HostNameType_Ipv4 = 1,

    /// <include file='HostNameType.xml' path='doc/member[@name="HostNameType.HostNameType_Ipv6"]/*' />
    HostNameType_Ipv6 = 2,

    /// <include file='HostNameType.xml' path='doc/member[@name="HostNameType.HostNameType_Bluetooth"]/*' />
    HostNameType_Bluetooth = 3,
}
