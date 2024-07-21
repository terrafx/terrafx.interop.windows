// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SensorType.xml' path='doc/member[@name="SensorType"]/*' />
public enum SensorType
{
    /// <include file='SensorType.xml' path='doc/member[@name="SensorType.SensorType_Accelerometer"]/*' />
    SensorType_Accelerometer = 0,

    /// <include file='SensorType.xml' path='doc/member[@name="SensorType.SensorType_ActivitySensor"]/*' />
    SensorType_ActivitySensor = 1,

    /// <include file='SensorType.xml' path='doc/member[@name="SensorType.SensorType_Barometer"]/*' />
    SensorType_Barometer = 2,

    /// <include file='SensorType.xml' path='doc/member[@name="SensorType.SensorType_Compass"]/*' />
    SensorType_Compass = 3,

    /// <include file='SensorType.xml' path='doc/member[@name="SensorType.SensorType_CustomSensor"]/*' />
    SensorType_CustomSensor = 4,

    /// <include file='SensorType.xml' path='doc/member[@name="SensorType.SensorType_Gyroscope"]/*' />
    SensorType_Gyroscope = 5,

    /// <include file='SensorType.xml' path='doc/member[@name="SensorType.SensorType_ProximitySensor"]/*' />
    SensorType_ProximitySensor = 6,

    /// <include file='SensorType.xml' path='doc/member[@name="SensorType.SensorType_Inclinometer"]/*' />
    SensorType_Inclinometer = 7,

    /// <include file='SensorType.xml' path='doc/member[@name="SensorType.SensorType_LightSensor"]/*' />
    SensorType_LightSensor = 8,

    /// <include file='SensorType.xml' path='doc/member[@name="SensorType.SensorType_OrientationSensor"]/*' />
    SensorType_OrientationSensor = 9,

    /// <include file='SensorType.xml' path='doc/member[@name="SensorType.SensorType_Pedometer"]/*' />
    SensorType_Pedometer = 10,

    /// <include file='SensorType.xml' path='doc/member[@name="SensorType.SensorType_RelativeInclinometer"]/*' />
    SensorType_RelativeInclinometer = 11,

    /// <include file='SensorType.xml' path='doc/member[@name="SensorType.SensorType_RelativeOrientationSensor"]/*' />
    SensorType_RelativeOrientationSensor = 12,

    /// <include file='SensorType.xml' path='doc/member[@name="SensorType.SensorType_SimpleOrientationSensor"]/*' />
    SensorType_SimpleOrientationSensor = 13,
}
