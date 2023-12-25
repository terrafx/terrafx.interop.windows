// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BasicGeoposition.xml' path='doc/member[@name="BasicGeoposition"]/*' />
public partial struct BasicGeoposition
{
    /// <include file='BasicGeoposition.xml' path='doc/member[@name="BasicGeoposition.Latitude"]/*' />
    public double Latitude;

    /// <include file='BasicGeoposition.xml' path='doc/member[@name="BasicGeoposition.Longitude"]/*' />
    public double Longitude;

    /// <include file='BasicGeoposition.xml' path='doc/member[@name="BasicGeoposition.Altitude"]/*' />
    public double Altitude;
}
