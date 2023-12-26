// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ActivitySensorReadingConfidence.xml' path='doc/member[@name="ActivitySensorReadingConfidence"]/*' />
public enum ActivitySensorReadingConfidence
{
    /// <include file='ActivitySensorReadingConfidence.xml' path='doc/member[@name="ActivitySensorReadingConfidence.ActivitySensorReadingConfidence_High"]/*' />
    ActivitySensorReadingConfidence_High = 0,

    /// <include file='ActivitySensorReadingConfidence.xml' path='doc/member[@name="ActivitySensorReadingConfidence.ActivitySensorReadingConfidence_Low"]/*' />
    ActivitySensorReadingConfidence_Low = 1,
}
