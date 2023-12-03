// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='DEVICEDUMP_SECTION_HEADER.xml' path='doc/member[@name="DEVICEDUMP_SECTION_HEADER"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DEVICEDUMP_SECTION_HEADER
{
    /// <include file='DEVICEDUMP_SECTION_HEADER.xml' path='doc/member[@name="DEVICEDUMP_SECTION_HEADER.guidDeviceDataId"]/*' />
    public Guid guidDeviceDataId;

    /// <include file='DEVICEDUMP_SECTION_HEADER.xml' path='doc/member[@name="DEVICEDUMP_SECTION_HEADER.sOrganizationID"]/*' />
    [NativeTypeName("BYTE[16]")]
    public _sOrganizationID_e__FixedBuffer sOrganizationID;

    /// <include file='DEVICEDUMP_SECTION_HEADER.xml' path='doc/member[@name="DEVICEDUMP_SECTION_HEADER.dwFirmwareRevision"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFirmwareRevision;

    /// <include file='DEVICEDUMP_SECTION_HEADER.xml' path='doc/member[@name="DEVICEDUMP_SECTION_HEADER.sModelNumber"]/*' />
    [NativeTypeName("BYTE[32]")]
    public _sModelNumber_e__FixedBuffer sModelNumber;

    /// <include file='DEVICEDUMP_SECTION_HEADER.xml' path='doc/member[@name="DEVICEDUMP_SECTION_HEADER.szDeviceManufacturingID"]/*' />
    [NativeTypeName("BYTE[32]")]
    public _szDeviceManufacturingID_e__FixedBuffer szDeviceManufacturingID;

    /// <include file='DEVICEDUMP_SECTION_HEADER.xml' path='doc/member[@name="DEVICEDUMP_SECTION_HEADER.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='DEVICEDUMP_SECTION_HEADER.xml' path='doc/member[@name="DEVICEDUMP_SECTION_HEADER.bRestrictedPrivateDataVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint bRestrictedPrivateDataVersion;

    /// <include file='DEVICEDUMP_SECTION_HEADER.xml' path='doc/member[@name="DEVICEDUMP_SECTION_HEADER.dwFirmwareIssueId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFirmwareIssueId;

    /// <include file='DEVICEDUMP_SECTION_HEADER.xml' path='doc/member[@name="DEVICEDUMP_SECTION_HEADER.szIssueDescriptionString"]/*' />
    [NativeTypeName("BYTE[132]")]
    public _szIssueDescriptionString_e__FixedBuffer szIssueDescriptionString;

    /// <include file='_sOrganizationID_e__FixedBuffer.xml' path='doc/member[@name="_sOrganizationID_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(16)]
    public partial struct _sOrganizationID_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_sModelNumber_e__FixedBuffer.xml' path='doc/member[@name="_sModelNumber_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(32)]
    public partial struct _sModelNumber_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_szDeviceManufacturingID_e__FixedBuffer.xml' path='doc/member[@name="_szDeviceManufacturingID_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(32)]
    public partial struct _szDeviceManufacturingID_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_szIssueDescriptionString_e__FixedBuffer.xml' path='doc/member[@name="_szIssueDescriptionString_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(132)]
    public partial struct _szIssueDescriptionString_e__FixedBuffer
    {
        public byte e0;
    }
}
