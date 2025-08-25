// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SYSTEM_POWER_SOURCE_STATE.xml' path='doc/member[@name="SYSTEM_POWER_SOURCE_STATE"]/*' />
public partial struct SYSTEM_POWER_SOURCE_STATE
{
    /// <include file='SYSTEM_POWER_SOURCE_STATE.xml' path='doc/member[@name="SYSTEM_POWER_SOURCE_STATE.BatteryState"]/*' />
    public SYSTEM_BATTERY_STATE BatteryState;

    /// <include file='SYSTEM_POWER_SOURCE_STATE.xml' path='doc/member[@name="SYSTEM_POWER_SOURCE_STATE.InstantaneousPeakPower"]/*' />
    [NativeTypeName("DWORD")]
    public uint InstantaneousPeakPower;

    /// <include file='SYSTEM_POWER_SOURCE_STATE.xml' path='doc/member[@name="SYSTEM_POWER_SOURCE_STATE.InstantaneousPeakPeriod"]/*' />
    [NativeTypeName("DWORD")]
    public uint InstantaneousPeakPeriod;

    /// <include file='SYSTEM_POWER_SOURCE_STATE.xml' path='doc/member[@name="SYSTEM_POWER_SOURCE_STATE.SustainablePeakPower"]/*' />
    [NativeTypeName("DWORD")]
    public uint SustainablePeakPower;

    /// <include file='SYSTEM_POWER_SOURCE_STATE.xml' path='doc/member[@name="SYSTEM_POWER_SOURCE_STATE.SustainablePeakPeriod"]/*' />
    [NativeTypeName("DWORD")]
    public uint SustainablePeakPeriod;

    /// <include file='SYSTEM_POWER_SOURCE_STATE.xml' path='doc/member[@name="SYSTEM_POWER_SOURCE_STATE.PeakPower"]/*' />
    [NativeTypeName("DWORD")]
    public uint PeakPower;

    /// <include file='SYSTEM_POWER_SOURCE_STATE.xml' path='doc/member[@name="SYSTEM_POWER_SOURCE_STATE.MaxOutputPower"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxOutputPower;

    /// <include file='SYSTEM_POWER_SOURCE_STATE.xml' path='doc/member[@name="SYSTEM_POWER_SOURCE_STATE.MaxInputPower"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxInputPower;

    /// <include file='SYSTEM_POWER_SOURCE_STATE.xml' path='doc/member[@name="SYSTEM_POWER_SOURCE_STATE.BatteryRateInCurrent"]/*' />
    [NativeTypeName("LONG")]
    public int BatteryRateInCurrent;

    /// <include file='SYSTEM_POWER_SOURCE_STATE.xml' path='doc/member[@name="SYSTEM_POWER_SOURCE_STATE.BatteryVoltage"]/*' />
    [NativeTypeName("DWORD")]
    public uint BatteryVoltage;
}
