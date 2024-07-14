// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='IMAGE_ARCHIVE_MEMBER_HEADER.xml' path='doc/member[@name="IMAGE_ARCHIVE_MEMBER_HEADER"]/*' />
public partial struct IMAGE_ARCHIVE_MEMBER_HEADER
{
    /// <include file='IMAGE_ARCHIVE_MEMBER_HEADER.xml' path='doc/member[@name="IMAGE_ARCHIVE_MEMBER_HEADER.Name"]/*' />
    [NativeTypeName("BYTE[16]")]
    public _Name_e__FixedBuffer Name;

    /// <include file='IMAGE_ARCHIVE_MEMBER_HEADER.xml' path='doc/member[@name="IMAGE_ARCHIVE_MEMBER_HEADER.Date"]/*' />
    [NativeTypeName("BYTE[12]")]
    public _Date_e__FixedBuffer Date;

    /// <include file='IMAGE_ARCHIVE_MEMBER_HEADER.xml' path='doc/member[@name="IMAGE_ARCHIVE_MEMBER_HEADER.UserID"]/*' />
    [NativeTypeName("BYTE[6]")]
    public _UserID_e__FixedBuffer UserID;

    /// <include file='IMAGE_ARCHIVE_MEMBER_HEADER.xml' path='doc/member[@name="IMAGE_ARCHIVE_MEMBER_HEADER.GroupID"]/*' />
    [NativeTypeName("BYTE[6]")]
    public _GroupID_e__FixedBuffer GroupID;

    /// <include file='IMAGE_ARCHIVE_MEMBER_HEADER.xml' path='doc/member[@name="IMAGE_ARCHIVE_MEMBER_HEADER.Mode"]/*' />
    [NativeTypeName("BYTE[8]")]
    public _Mode_e__FixedBuffer Mode;

    /// <include file='IMAGE_ARCHIVE_MEMBER_HEADER.xml' path='doc/member[@name="IMAGE_ARCHIVE_MEMBER_HEADER.Size"]/*' />
    [NativeTypeName("BYTE[10]")]
    public _Size_e__FixedBuffer Size;

    /// <include file='IMAGE_ARCHIVE_MEMBER_HEADER.xml' path='doc/member[@name="IMAGE_ARCHIVE_MEMBER_HEADER.EndHeader"]/*' />
    [NativeTypeName("BYTE[2]")]
    public _EndHeader_e__FixedBuffer EndHeader;

    /// <include file='_Name_e__FixedBuffer.xml' path='doc/member[@name="_Name_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _Name_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_Date_e__FixedBuffer.xml' path='doc/member[@name="_Date_e__FixedBuffer"]/*' />
    [InlineArray(12)]
    public partial struct _Date_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_UserID_e__FixedBuffer.xml' path='doc/member[@name="_UserID_e__FixedBuffer"]/*' />
    [InlineArray(6)]
    public partial struct _UserID_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_GroupID_e__FixedBuffer.xml' path='doc/member[@name="_GroupID_e__FixedBuffer"]/*' />
    [InlineArray(6)]
    public partial struct _GroupID_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_Mode_e__FixedBuffer.xml' path='doc/member[@name="_Mode_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _Mode_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_Size_e__FixedBuffer.xml' path='doc/member[@name="_Size_e__FixedBuffer"]/*' />
    [InlineArray(10)]
    public partial struct _Size_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_EndHeader_e__FixedBuffer.xml' path='doc/member[@name="_EndHeader_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _EndHeader_e__FixedBuffer
    {
        public byte e0;
    }
}
