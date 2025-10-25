// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='OnlookerDetectionBackOnMode.xml' path='doc/member[@name="OnlookerDetectionBackOnMode"]/*' />
public enum OnlookerDetectionBackOnMode
{
    /// <include file='OnlookerDetectionBackOnMode.xml' path='doc/member[@name="OnlookerDetectionBackOnMode.OnlookerDetectionBackOnMode_Manually"]/*' />
    OnlookerDetectionBackOnMode_Manually = 0,

    /// <include file='OnlookerDetectionBackOnMode.xml' path='doc/member[@name="OnlookerDetectionBackOnMode.OnlookerDetectionBackOnMode_OneHour"]/*' />
    OnlookerDetectionBackOnMode_OneHour = 1,

    /// <include file='OnlookerDetectionBackOnMode.xml' path='doc/member[@name="OnlookerDetectionBackOnMode.OnlookerDetectionBackOnMode_FourHours"]/*' />
    OnlookerDetectionBackOnMode_FourHours = 2,

    /// <include file='OnlookerDetectionBackOnMode.xml' path='doc/member[@name="OnlookerDetectionBackOnMode.OnlookerDetectionBackOnMode_OneDay"]/*' />
    OnlookerDetectionBackOnMode_OneDay = 3,
}
