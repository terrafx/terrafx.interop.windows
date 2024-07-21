// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SensorReadingType.xml' path='doc/member[@name="SensorReadingType"]/*' />
public enum SensorReadingType
{
    /// <include file='SensorReadingType.xml' path='doc/member[@name="SensorReadingType.SensorReadingType_Absolute"]/*' />
    SensorReadingType_Absolute = 0,

    /// <include file='SensorReadingType.xml' path='doc/member[@name="SensorReadingType.SensorReadingType_Relative"]/*' />
    SensorReadingType_Relative = 1,
}
