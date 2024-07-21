// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ifmib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='MIB_IFROW.xml' path='doc/member[@name="MIB_IFROW"]/*' />
public partial struct MIB_IFROW
{
    /// <include file='MIB_IFROW.xml' path='doc/member[@name="MIB_IFROW.wszName"]/*' />
    [NativeTypeName("WCHAR[256]")]
    public _wszName_e__FixedBuffer wszName;

    /// <include file='MIB_IFROW.xml' path='doc/member[@name="MIB_IFROW.dwIndex"]/*' />
    [NativeTypeName("IF_INDEX")]
    public uint dwIndex;

    /// <include file='MIB_IFROW.xml' path='doc/member[@name="MIB_IFROW.dwType"]/*' />
    [NativeTypeName("IFTYPE")]
    public uint dwType;

    /// <include file='MIB_IFROW.xml' path='doc/member[@name="MIB_IFROW.dwMtu"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMtu;

    /// <include file='MIB_IFROW.xml' path='doc/member[@name="MIB_IFROW.dwSpeed"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSpeed;

    /// <include file='MIB_IFROW.xml' path='doc/member[@name="MIB_IFROW.dwPhysAddrLen"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwPhysAddrLen;

    /// <include file='MIB_IFROW.xml' path='doc/member[@name="MIB_IFROW.bPhysAddr"]/*' />
    [NativeTypeName("UCHAR[8]")]
    public _bPhysAddr_e__FixedBuffer bPhysAddr;

    /// <include file='MIB_IFROW.xml' path='doc/member[@name="MIB_IFROW.dwAdminStatus"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAdminStatus;

    /// <include file='MIB_IFROW.xml' path='doc/member[@name="MIB_IFROW.dwOperStatus"]/*' />
    public INTERNAL_IF_OPER_STATUS dwOperStatus;

    /// <include file='MIB_IFROW.xml' path='doc/member[@name="MIB_IFROW.dwLastChange"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLastChange;

    /// <include file='MIB_IFROW.xml' path='doc/member[@name="MIB_IFROW.dwInOctets"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwInOctets;

    /// <include file='MIB_IFROW.xml' path='doc/member[@name="MIB_IFROW.dwInUcastPkts"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwInUcastPkts;

    /// <include file='MIB_IFROW.xml' path='doc/member[@name="MIB_IFROW.dwInNUcastPkts"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwInNUcastPkts;

    /// <include file='MIB_IFROW.xml' path='doc/member[@name="MIB_IFROW.dwInDiscards"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwInDiscards;

    /// <include file='MIB_IFROW.xml' path='doc/member[@name="MIB_IFROW.dwInErrors"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwInErrors;

    /// <include file='MIB_IFROW.xml' path='doc/member[@name="MIB_IFROW.dwInUnknownProtos"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwInUnknownProtos;

    /// <include file='MIB_IFROW.xml' path='doc/member[@name="MIB_IFROW.dwOutOctets"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOutOctets;

    /// <include file='MIB_IFROW.xml' path='doc/member[@name="MIB_IFROW.dwOutUcastPkts"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOutUcastPkts;

    /// <include file='MIB_IFROW.xml' path='doc/member[@name="MIB_IFROW.dwOutNUcastPkts"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOutNUcastPkts;

    /// <include file='MIB_IFROW.xml' path='doc/member[@name="MIB_IFROW.dwOutDiscards"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOutDiscards;

    /// <include file='MIB_IFROW.xml' path='doc/member[@name="MIB_IFROW.dwOutErrors"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOutErrors;

    /// <include file='MIB_IFROW.xml' path='doc/member[@name="MIB_IFROW.dwOutQLen"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOutQLen;

    /// <include file='MIB_IFROW.xml' path='doc/member[@name="MIB_IFROW.dwDescrLen"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDescrLen;

    /// <include file='MIB_IFROW.xml' path='doc/member[@name="MIB_IFROW.bDescr"]/*' />
    [NativeTypeName("UCHAR[256]")]
    public _bDescr_e__FixedBuffer bDescr;

    /// <include file='_wszName_e__FixedBuffer.xml' path='doc/member[@name="_wszName_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _wszName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_bPhysAddr_e__FixedBuffer.xml' path='doc/member[@name="_bPhysAddr_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _bPhysAddr_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_bDescr_e__FixedBuffer.xml' path='doc/member[@name="_bDescr_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _bDescr_e__FixedBuffer
    {
        public byte e0;
    }
}
