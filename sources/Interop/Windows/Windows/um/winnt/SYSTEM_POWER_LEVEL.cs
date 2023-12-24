// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SYSTEM_POWER_LEVEL.xml' path='doc/member[@name="SYSTEM_POWER_LEVEL"]/*' />
public partial struct SYSTEM_POWER_LEVEL
{
    /// <include file='SYSTEM_POWER_LEVEL.xml' path='doc/member[@name="SYSTEM_POWER_LEVEL.Enable"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte Enable;

    /// <include file='SYSTEM_POWER_LEVEL.xml' path='doc/member[@name="SYSTEM_POWER_LEVEL.Spare"]/*' />
    [NativeTypeName("BYTE[3]")]
    public _Spare_e__FixedBuffer Spare;

    /// <include file='SYSTEM_POWER_LEVEL.xml' path='doc/member[@name="SYSTEM_POWER_LEVEL.BatteryLevel"]/*' />
    [NativeTypeName("DWORD")]
    public uint BatteryLevel;

    /// <include file='SYSTEM_POWER_LEVEL.xml' path='doc/member[@name="SYSTEM_POWER_LEVEL.PowerPolicy"]/*' />
    public POWER_ACTION_POLICY PowerPolicy;

    /// <include file='SYSTEM_POWER_LEVEL.xml' path='doc/member[@name="SYSTEM_POWER_LEVEL.MinSystemState"]/*' />
    public SYSTEM_POWER_STATE MinSystemState;

    /// <include file='_Spare_e__FixedBuffer.xml' path='doc/member[@name="_Spare_e__FixedBuffer"]/*' />
    [InlineArray(3)]
    public partial struct _Spare_e__FixedBuffer
    {
        public byte e0;
    }
}
