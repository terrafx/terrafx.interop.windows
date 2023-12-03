// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_PHYSICAL_DEVICE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_DEVICE_DATA"]/*' />
[SupportedOSPlatform("windows10.0")]
public partial struct STORAGE_PHYSICAL_DEVICE_DATA
{
    /// <include file='STORAGE_PHYSICAL_DEVICE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_DEVICE_DATA.DeviceId"]/*' />
    [NativeTypeName("DWORD")]
    public uint DeviceId;

    /// <include file='STORAGE_PHYSICAL_DEVICE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_DEVICE_DATA.Role"]/*' />
    [NativeTypeName("DWORD")]
    public uint Role;

    /// <include file='STORAGE_PHYSICAL_DEVICE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_DEVICE_DATA.HealthStatus"]/*' />
    public STORAGE_COMPONENT_HEALTH_STATUS HealthStatus;

    /// <include file='STORAGE_PHYSICAL_DEVICE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_DEVICE_DATA.CommandProtocol"]/*' />
    public STORAGE_PROTOCOL_TYPE CommandProtocol;

    /// <include file='STORAGE_PHYSICAL_DEVICE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_DEVICE_DATA.SpecVersion"]/*' />
    public STORAGE_SPEC_VERSION SpecVersion;

    /// <include file='STORAGE_PHYSICAL_DEVICE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_DEVICE_DATA.FormFactor"]/*' />
    public STORAGE_DEVICE_FORM_FACTOR FormFactor;

    /// <include file='STORAGE_PHYSICAL_DEVICE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_DEVICE_DATA.Vendor"]/*' />
    [NativeTypeName("BYTE[8]")]
    public _Vendor_e__FixedBuffer Vendor;

    /// <include file='STORAGE_PHYSICAL_DEVICE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_DEVICE_DATA.Model"]/*' />
    [NativeTypeName("BYTE[40]")]
    public _Model_e__FixedBuffer Model;

    /// <include file='STORAGE_PHYSICAL_DEVICE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_DEVICE_DATA.FirmwareRevision"]/*' />
    [NativeTypeName("BYTE[16]")]
    public _FirmwareRevision_e__FixedBuffer FirmwareRevision;

    /// <include file='STORAGE_PHYSICAL_DEVICE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_DEVICE_DATA.Capacity"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong Capacity;

    /// <include file='STORAGE_PHYSICAL_DEVICE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_DEVICE_DATA.PhysicalLocation"]/*' />
    [NativeTypeName("BYTE[32]")]
    public _PhysicalLocation_e__FixedBuffer PhysicalLocation;

    /// <include file='STORAGE_PHYSICAL_DEVICE_DATA.xml' path='doc/member[@name="STORAGE_PHYSICAL_DEVICE_DATA.Reserved"]/*' />
    [NativeTypeName("DWORD[2]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='_Vendor_e__FixedBuffer.xml' path='doc/member[@name="_Vendor_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _Vendor_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_Model_e__FixedBuffer.xml' path='doc/member[@name="_Model_e__FixedBuffer"]/*' />
    [InlineArray(40)]
    public partial struct _Model_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_FirmwareRevision_e__FixedBuffer.xml' path='doc/member[@name="_FirmwareRevision_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _FirmwareRevision_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_PhysicalLocation_e__FixedBuffer.xml' path='doc/member[@name="_PhysicalLocation_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _PhysicalLocation_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public uint e0;
    }
}
