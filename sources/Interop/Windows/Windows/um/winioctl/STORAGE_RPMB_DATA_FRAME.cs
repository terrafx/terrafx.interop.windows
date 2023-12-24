// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_RPMB_DATA_FRAME.xml' path='doc/member[@name="STORAGE_RPMB_DATA_FRAME"]/*' />
public partial struct STORAGE_RPMB_DATA_FRAME
{
    /// <include file='STORAGE_RPMB_DATA_FRAME.xml' path='doc/member[@name="STORAGE_RPMB_DATA_FRAME.Stuff"]/*' />
    [NativeTypeName("BYTE[196]")]
    public _Stuff_e__FixedBuffer Stuff;

    /// <include file='STORAGE_RPMB_DATA_FRAME.xml' path='doc/member[@name="STORAGE_RPMB_DATA_FRAME.KeyOrMAC"]/*' />
    [NativeTypeName("BYTE[32]")]
    public _KeyOrMAC_e__FixedBuffer KeyOrMAC;

    /// <include file='STORAGE_RPMB_DATA_FRAME.xml' path='doc/member[@name="STORAGE_RPMB_DATA_FRAME.Data"]/*' />
    [NativeTypeName("BYTE[256]")]
    public _Data_e__FixedBuffer Data;

    /// <include file='STORAGE_RPMB_DATA_FRAME.xml' path='doc/member[@name="STORAGE_RPMB_DATA_FRAME.Nonce"]/*' />
    [NativeTypeName("BYTE[16]")]
    public _Nonce_e__FixedBuffer Nonce;

    /// <include file='STORAGE_RPMB_DATA_FRAME.xml' path='doc/member[@name="STORAGE_RPMB_DATA_FRAME.WriteCounter"]/*' />
    [NativeTypeName("BYTE[4]")]
    public _WriteCounter_e__FixedBuffer WriteCounter;

    /// <include file='STORAGE_RPMB_DATA_FRAME.xml' path='doc/member[@name="STORAGE_RPMB_DATA_FRAME.Address"]/*' />
    [NativeTypeName("BYTE[2]")]
    public _Address_e__FixedBuffer Address;

    /// <include file='STORAGE_RPMB_DATA_FRAME.xml' path='doc/member[@name="STORAGE_RPMB_DATA_FRAME.BlockCount"]/*' />
    [NativeTypeName("BYTE[2]")]
    public _BlockCount_e__FixedBuffer BlockCount;

    /// <include file='STORAGE_RPMB_DATA_FRAME.xml' path='doc/member[@name="STORAGE_RPMB_DATA_FRAME.OperationResult"]/*' />
    [NativeTypeName("BYTE[2]")]
    public _OperationResult_e__FixedBuffer OperationResult;

    /// <include file='STORAGE_RPMB_DATA_FRAME.xml' path='doc/member[@name="STORAGE_RPMB_DATA_FRAME.RequestOrResponseType"]/*' />
    [NativeTypeName("BYTE[2]")]
    public _RequestOrResponseType_e__FixedBuffer RequestOrResponseType;

    /// <include file='_Stuff_e__FixedBuffer.xml' path='doc/member[@name="_Stuff_e__FixedBuffer"]/*' />
    [InlineArray(196)]
    public partial struct _Stuff_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_KeyOrMAC_e__FixedBuffer.xml' path='doc/member[@name="_KeyOrMAC_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _KeyOrMAC_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_Data_e__FixedBuffer.xml' path='doc/member[@name="_Data_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _Data_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_Nonce_e__FixedBuffer.xml' path='doc/member[@name="_Nonce_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _Nonce_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_WriteCounter_e__FixedBuffer.xml' path='doc/member[@name="_WriteCounter_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _WriteCounter_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_Address_e__FixedBuffer.xml' path='doc/member[@name="_Address_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _Address_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_BlockCount_e__FixedBuffer.xml' path='doc/member[@name="_BlockCount_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _BlockCount_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_OperationResult_e__FixedBuffer.xml' path='doc/member[@name="_OperationResult_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _OperationResult_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_RequestOrResponseType_e__FixedBuffer.xml' path='doc/member[@name="_RequestOrResponseType_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _RequestOrResponseType_e__FixedBuffer
    {
        public byte e0;
    }
}
