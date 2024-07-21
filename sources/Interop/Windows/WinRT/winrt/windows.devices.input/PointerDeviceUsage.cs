// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PointerDeviceUsage.xml' path='doc/member[@name="PointerDeviceUsage"]/*' />
public partial struct PointerDeviceUsage
{
    /// <include file='PointerDeviceUsage.xml' path='doc/member[@name="PointerDeviceUsage.UsagePage"]/*' />
    [NativeTypeName("UINT32")]
    public uint UsagePage;

    /// <include file='PointerDeviceUsage.xml' path='doc/member[@name="PointerDeviceUsage.Usage"]/*' />
    [NativeTypeName("UINT32")]
    public uint Usage;

    /// <include file='PointerDeviceUsage.xml' path='doc/member[@name="PointerDeviceUsage.MinLogical"]/*' />
    [NativeTypeName("INT32")]
    public int MinLogical;

    /// <include file='PointerDeviceUsage.xml' path='doc/member[@name="PointerDeviceUsage.MaxLogical"]/*' />
    [NativeTypeName("INT32")]
    public int MaxLogical;

    /// <include file='PointerDeviceUsage.xml' path='doc/member[@name="PointerDeviceUsage.MinPhysical"]/*' />
    [NativeTypeName("INT32")]
    public int MinPhysical;

    /// <include file='PointerDeviceUsage.xml' path='doc/member[@name="PointerDeviceUsage.MaxPhysical"]/*' />
    [NativeTypeName("INT32")]
    public int MaxPhysical;

    /// <include file='PointerDeviceUsage.xml' path='doc/member[@name="PointerDeviceUsage.Unit"]/*' />
    [NativeTypeName("UINT32")]
    public uint Unit;

    /// <include file='PointerDeviceUsage.xml' path='doc/member[@name="PointerDeviceUsage.PhysicalMultiplier"]/*' />
    public float PhysicalMultiplier;
}
