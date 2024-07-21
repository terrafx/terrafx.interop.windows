// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='CHANGER_PRODUCT_DATA.xml' path='doc/member[@name="CHANGER_PRODUCT_DATA"]/*' />
public partial struct CHANGER_PRODUCT_DATA
{
    /// <include file='CHANGER_PRODUCT_DATA.xml' path='doc/member[@name="CHANGER_PRODUCT_DATA.VendorId"]/*' />
    [NativeTypeName("BYTE[8]")]
    public _VendorId_e__FixedBuffer VendorId;

    /// <include file='CHANGER_PRODUCT_DATA.xml' path='doc/member[@name="CHANGER_PRODUCT_DATA.ProductId"]/*' />
    [NativeTypeName("BYTE[16]")]
    public _ProductId_e__FixedBuffer ProductId;

    /// <include file='CHANGER_PRODUCT_DATA.xml' path='doc/member[@name="CHANGER_PRODUCT_DATA.Revision"]/*' />
    [NativeTypeName("BYTE[4]")]
    public _Revision_e__FixedBuffer Revision;

    /// <include file='CHANGER_PRODUCT_DATA.xml' path='doc/member[@name="CHANGER_PRODUCT_DATA.SerialNumber"]/*' />
    [NativeTypeName("BYTE[32]")]
    public _SerialNumber_e__FixedBuffer SerialNumber;

    /// <include file='CHANGER_PRODUCT_DATA.xml' path='doc/member[@name="CHANGER_PRODUCT_DATA.DeviceType"]/*' />
    public byte DeviceType;

    /// <include file='_VendorId_e__FixedBuffer.xml' path='doc/member[@name="_VendorId_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _VendorId_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_ProductId_e__FixedBuffer.xml' path='doc/member[@name="_ProductId_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _ProductId_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_Revision_e__FixedBuffer.xml' path='doc/member[@name="_Revision_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _Revision_e__FixedBuffer
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
