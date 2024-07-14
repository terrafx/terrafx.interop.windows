// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PositionSource.xml' path='doc/member[@name="PositionSource"]/*' />
public enum PositionSource
{
    /// <include file='PositionSource.xml' path='doc/member[@name="PositionSource.PositionSource_Cellular"]/*' />
    PositionSource_Cellular = 0,

    /// <include file='PositionSource.xml' path='doc/member[@name="PositionSource.PositionSource_Satellite"]/*' />
    PositionSource_Satellite = 1,

    /// <include file='PositionSource.xml' path='doc/member[@name="PositionSource.PositionSource_WiFi"]/*' />
    PositionSource_WiFi = 2,

    /// <include file='PositionSource.xml' path='doc/member[@name="PositionSource.PositionSource_IPAddress"]/*' />
    PositionSource_IPAddress = 3,

    /// <include file='PositionSource.xml' path='doc/member[@name="PositionSource.PositionSource_Unknown"]/*' />
    PositionSource_Unknown = 4,

    /// <include file='PositionSource.xml' path='doc/member[@name="PositionSource.PositionSource_Default"]/*' />
    PositionSource_Default = 5,

    /// <include file='PositionSource.xml' path='doc/member[@name="PositionSource.PositionSource_Obfuscated"]/*' />
    PositionSource_Obfuscated = 6,
}
