// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AccelerometerReadingType.xml' path='doc/member[@name="AccelerometerReadingType"]/*' />
public enum AccelerometerReadingType
{
    /// <include file='AccelerometerReadingType.xml' path='doc/member[@name="AccelerometerReadingType.AccelerometerReadingType_Standard"]/*' />
    AccelerometerReadingType_Standard = 0,

    /// <include file='AccelerometerReadingType.xml' path='doc/member[@name="AccelerometerReadingType.AccelerometerReadingType_Linear"]/*' />
    AccelerometerReadingType_Linear = 1,

    /// <include file='AccelerometerReadingType.xml' path='doc/member[@name="AccelerometerReadingType.AccelerometerReadingType_Gravity"]/*' />
    AccelerometerReadingType_Gravity = 2,
}
