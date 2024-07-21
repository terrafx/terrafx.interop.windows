// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='CHANGER_ELEMENT_STATUS_EX.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS_EX"]/*' />
public partial struct CHANGER_ELEMENT_STATUS_EX
{
    /// <include file='CHANGER_ELEMENT_STATUS_EX.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS_EX.Element"]/*' />
    public CHANGER_ELEMENT Element;

    /// <include file='CHANGER_ELEMENT_STATUS_EX.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS_EX.SrcElementAddress"]/*' />
    public CHANGER_ELEMENT SrcElementAddress;

    /// <include file='CHANGER_ELEMENT_STATUS_EX.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS_EX.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='CHANGER_ELEMENT_STATUS_EX.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS_EX.ExceptionCode"]/*' />
    [NativeTypeName("DWORD")]
    public uint ExceptionCode;

    /// <include file='CHANGER_ELEMENT_STATUS_EX.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS_EX.TargetId"]/*' />
    public byte TargetId;

    /// <include file='CHANGER_ELEMENT_STATUS_EX.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS_EX.Lun"]/*' />
    public byte Lun;

    /// <include file='CHANGER_ELEMENT_STATUS_EX.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS_EX.Reserved"]/*' />
    [NativeTypeName("WORD")]
    public ushort Reserved;

    /// <include file='CHANGER_ELEMENT_STATUS_EX.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS_EX.PrimaryVolumeID"]/*' />
    [NativeTypeName("BYTE[36]")]
    public _PrimaryVolumeID_e__FixedBuffer PrimaryVolumeID;

    /// <include file='CHANGER_ELEMENT_STATUS_EX.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS_EX.AlternateVolumeID"]/*' />
    [NativeTypeName("BYTE[36]")]
    public _AlternateVolumeID_e__FixedBuffer AlternateVolumeID;

    /// <include file='CHANGER_ELEMENT_STATUS_EX.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS_EX.VendorIdentification"]/*' />
    [NativeTypeName("BYTE[8]")]
    public _VendorIdentification_e__FixedBuffer VendorIdentification;

    /// <include file='CHANGER_ELEMENT_STATUS_EX.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS_EX.ProductIdentification"]/*' />
    [NativeTypeName("BYTE[16]")]
    public _ProductIdentification_e__FixedBuffer ProductIdentification;

    /// <include file='CHANGER_ELEMENT_STATUS_EX.xml' path='doc/member[@name="CHANGER_ELEMENT_STATUS_EX.SerialNumber"]/*' />
    [NativeTypeName("BYTE[32]")]
    public _SerialNumber_e__FixedBuffer SerialNumber;

    /// <include file='_PrimaryVolumeID_e__FixedBuffer.xml' path='doc/member[@name="_PrimaryVolumeID_e__FixedBuffer"]/*' />
    [InlineArray(36)]
    public partial struct _PrimaryVolumeID_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_AlternateVolumeID_e__FixedBuffer.xml' path='doc/member[@name="_AlternateVolumeID_e__FixedBuffer"]/*' />
    [InlineArray(36)]
    public partial struct _AlternateVolumeID_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_VendorIdentification_e__FixedBuffer.xml' path='doc/member[@name="_VendorIdentification_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _VendorIdentification_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_ProductIdentification_e__FixedBuffer.xml' path='doc/member[@name="_ProductIdentification_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _ProductIdentification_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_SerialNumber_e__FixedBuffer.xml' path='doc/member[@name="_SerialNumber_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _SerialNumber_e__FixedBuffer
    {
        public byte e0;
    }
}
