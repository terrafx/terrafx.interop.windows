// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='PERFORMANCE_DATA.xml' path='doc/member[@name="PERFORMANCE_DATA"]/*' />
public partial struct PERFORMANCE_DATA
{
    /// <include file='PERFORMANCE_DATA.xml' path='doc/member[@name="PERFORMANCE_DATA.Size"]/*' />
    [NativeTypeName("WORD")]
    public ushort Size;

    /// <include file='PERFORMANCE_DATA.xml' path='doc/member[@name="PERFORMANCE_DATA.Version"]/*' />
    public byte Version;

    /// <include file='PERFORMANCE_DATA.xml' path='doc/member[@name="PERFORMANCE_DATA.HwCountersCount"]/*' />
    public byte HwCountersCount;

    /// <include file='PERFORMANCE_DATA.xml' path='doc/member[@name="PERFORMANCE_DATA.ContextSwitchCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint ContextSwitchCount;

    /// <include file='PERFORMANCE_DATA.xml' path='doc/member[@name="PERFORMANCE_DATA.WaitReasonBitMap"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong WaitReasonBitMap;

    /// <include file='PERFORMANCE_DATA.xml' path='doc/member[@name="PERFORMANCE_DATA.CycleTime"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong CycleTime;

    /// <include file='PERFORMANCE_DATA.xml' path='doc/member[@name="PERFORMANCE_DATA.RetryCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint RetryCount;

    /// <include file='PERFORMANCE_DATA.xml' path='doc/member[@name="PERFORMANCE_DATA.Reserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved;

    /// <include file='PERFORMANCE_DATA.xml' path='doc/member[@name="PERFORMANCE_DATA.HwCounters"]/*' />
    [NativeTypeName("HARDWARE_COUNTER_DATA[16]")]
    public _HwCounters_e__FixedBuffer HwCounters;

    /// <include file='_HwCounters_e__FixedBuffer.xml' path='doc/member[@name="_HwCounters_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _HwCounters_e__FixedBuffer
    {
        public HARDWARE_COUNTER_DATA e0;
    }
}
