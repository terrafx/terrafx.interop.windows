// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MagnetometerAccuracy.xml' path='doc/member[@name="MagnetometerAccuracy"]/*' />
public enum MagnetometerAccuracy
{
    /// <include file='MagnetometerAccuracy.xml' path='doc/member[@name="MagnetometerAccuracy.MagnetometerAccuracy_Unknown"]/*' />
    MagnetometerAccuracy_Unknown = 0,

    /// <include file='MagnetometerAccuracy.xml' path='doc/member[@name="MagnetometerAccuracy.MagnetometerAccuracy_Unreliable"]/*' />
    MagnetometerAccuracy_Unreliable = 1,

    /// <include file='MagnetometerAccuracy.xml' path='doc/member[@name="MagnetometerAccuracy.MagnetometerAccuracy_Approximate"]/*' />
    MagnetometerAccuracy_Approximate = 2,

    /// <include file='MagnetometerAccuracy.xml' path='doc/member[@name="MagnetometerAccuracy.MagnetometerAccuracy_High"]/*' />
    MagnetometerAccuracy_High = 3,
}
