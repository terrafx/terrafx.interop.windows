// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='GeolocationAccessStatus.xml' path='doc/member[@name="GeolocationAccessStatus"]/*' />
public enum GeolocationAccessStatus
{
    /// <include file='GeolocationAccessStatus.xml' path='doc/member[@name="GeolocationAccessStatus.GeolocationAccessStatus_Unspecified"]/*' />
    GeolocationAccessStatus_Unspecified = 0,

    /// <include file='GeolocationAccessStatus.xml' path='doc/member[@name="GeolocationAccessStatus.GeolocationAccessStatus_Allowed"]/*' />
    GeolocationAccessStatus_Allowed = 1,

    /// <include file='GeolocationAccessStatus.xml' path='doc/member[@name="GeolocationAccessStatus.GeolocationAccessStatus_Denied"]/*' />
    GeolocationAccessStatus_Denied = 2,
}
