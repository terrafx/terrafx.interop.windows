// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PedometerStepKind.xml' path='doc/member[@name="PedometerStepKind"]/*' />
public enum PedometerStepKind
{
    /// <include file='PedometerStepKind.xml' path='doc/member[@name="PedometerStepKind.PedometerStepKind_Unknown"]/*' />
    PedometerStepKind_Unknown = 0,

    /// <include file='PedometerStepKind.xml' path='doc/member[@name="PedometerStepKind.PedometerStepKind_Walking"]/*' />
    PedometerStepKind_Walking = 1,

    /// <include file='PedometerStepKind.xml' path='doc/member[@name="PedometerStepKind.PedometerStepKind_Running"]/*' />
    PedometerStepKind_Running = 2,
}
