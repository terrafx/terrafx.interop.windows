// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='CM_POWER_DATA.xml' path='doc/member[@name="CM_POWER_DATA"]/*' />
public partial struct CM_POWER_DATA
{
    /// <include file='CM_POWER_DATA.xml' path='doc/member[@name="CM_POWER_DATA.PD_Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint PD_Size;

    /// <include file='CM_POWER_DATA.xml' path='doc/member[@name="CM_POWER_DATA.PD_MostRecentPowerState"]/*' />
    public DEVICE_POWER_STATE PD_MostRecentPowerState;

    /// <include file='CM_POWER_DATA.xml' path='doc/member[@name="CM_POWER_DATA.PD_Capabilities"]/*' />
    [NativeTypeName("DWORD")]
    public uint PD_Capabilities;

    /// <include file='CM_POWER_DATA.xml' path='doc/member[@name="CM_POWER_DATA.PD_D1Latency"]/*' />
    [NativeTypeName("DWORD")]
    public uint PD_D1Latency;

    /// <include file='CM_POWER_DATA.xml' path='doc/member[@name="CM_POWER_DATA.PD_D2Latency"]/*' />
    [NativeTypeName("DWORD")]
    public uint PD_D2Latency;

    /// <include file='CM_POWER_DATA.xml' path='doc/member[@name="CM_POWER_DATA.PD_D3Latency"]/*' />
    [NativeTypeName("DWORD")]
    public uint PD_D3Latency;

    /// <include file='CM_POWER_DATA.xml' path='doc/member[@name="CM_POWER_DATA.PD_PowerStateMapping"]/*' />
    [NativeTypeName("DEVICE_POWER_STATE[7]")]
    public _PD_PowerStateMapping_e__FixedBuffer PD_PowerStateMapping;

    /// <include file='CM_POWER_DATA.xml' path='doc/member[@name="CM_POWER_DATA.PD_DeepestSystemWake"]/*' />
    public SYSTEM_POWER_STATE PD_DeepestSystemWake;

    /// <include file='_PD_PowerStateMapping_e__FixedBuffer.xml' path='doc/member[@name="_PD_PowerStateMapping_e__FixedBuffer"]/*' />
    [InlineArray(7)]
    public partial struct _PD_PowerStateMapping_e__FixedBuffer
    {
        public DEVICE_POWER_STATE e0;
    }
}
