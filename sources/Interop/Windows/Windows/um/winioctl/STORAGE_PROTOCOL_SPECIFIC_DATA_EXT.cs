// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_PROTOCOL_SPECIFIC_DATA_EXT.xml' path='doc/member[@name="STORAGE_PROTOCOL_SPECIFIC_DATA_EXT"]/*' />
public partial struct STORAGE_PROTOCOL_SPECIFIC_DATA_EXT
{
    /// <include file='STORAGE_PROTOCOL_SPECIFIC_DATA_EXT.xml' path='doc/member[@name="STORAGE_PROTOCOL_SPECIFIC_DATA_EXT.ProtocolType"]/*' />
    public STORAGE_PROTOCOL_TYPE ProtocolType;

    /// <include file='STORAGE_PROTOCOL_SPECIFIC_DATA_EXT.xml' path='doc/member[@name="STORAGE_PROTOCOL_SPECIFIC_DATA_EXT.DataType"]/*' />
    [NativeTypeName("DWORD")]
    public uint DataType;

    /// <include file='STORAGE_PROTOCOL_SPECIFIC_DATA_EXT.xml' path='doc/member[@name="STORAGE_PROTOCOL_SPECIFIC_DATA_EXT.ProtocolDataValue"]/*' />
    [NativeTypeName("DWORD")]
    public uint ProtocolDataValue;

    /// <include file='STORAGE_PROTOCOL_SPECIFIC_DATA_EXT.xml' path='doc/member[@name="STORAGE_PROTOCOL_SPECIFIC_DATA_EXT.ProtocolDataSubValue"]/*' />
    [NativeTypeName("DWORD")]
    public uint ProtocolDataSubValue;

    /// <include file='STORAGE_PROTOCOL_SPECIFIC_DATA_EXT.xml' path='doc/member[@name="STORAGE_PROTOCOL_SPECIFIC_DATA_EXT.ProtocolDataOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint ProtocolDataOffset;

    /// <include file='STORAGE_PROTOCOL_SPECIFIC_DATA_EXT.xml' path='doc/member[@name="STORAGE_PROTOCOL_SPECIFIC_DATA_EXT.ProtocolDataLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint ProtocolDataLength;

    /// <include file='STORAGE_PROTOCOL_SPECIFIC_DATA_EXT.xml' path='doc/member[@name="STORAGE_PROTOCOL_SPECIFIC_DATA_EXT.FixedProtocolReturnData"]/*' />
    [NativeTypeName("DWORD")]
    public uint FixedProtocolReturnData;

    /// <include file='STORAGE_PROTOCOL_SPECIFIC_DATA_EXT.xml' path='doc/member[@name="STORAGE_PROTOCOL_SPECIFIC_DATA_EXT.ProtocolDataSubValue2"]/*' />
    [NativeTypeName("DWORD")]
    public uint ProtocolDataSubValue2;

    /// <include file='STORAGE_PROTOCOL_SPECIFIC_DATA_EXT.xml' path='doc/member[@name="STORAGE_PROTOCOL_SPECIFIC_DATA_EXT.ProtocolDataSubValue3"]/*' />
    [NativeTypeName("DWORD")]
    public uint ProtocolDataSubValue3;

    /// <include file='STORAGE_PROTOCOL_SPECIFIC_DATA_EXT.xml' path='doc/member[@name="STORAGE_PROTOCOL_SPECIFIC_DATA_EXT.ProtocolDataSubValue4"]/*' />
    [NativeTypeName("DWORD")]
    public uint ProtocolDataSubValue4;

    /// <include file='STORAGE_PROTOCOL_SPECIFIC_DATA_EXT.xml' path='doc/member[@name="STORAGE_PROTOCOL_SPECIFIC_DATA_EXT.ProtocolDataSubValue5"]/*' />
    [NativeTypeName("DWORD")]
    public uint ProtocolDataSubValue5;

    /// <include file='STORAGE_PROTOCOL_SPECIFIC_DATA_EXT.xml' path='doc/member[@name="STORAGE_PROTOCOL_SPECIFIC_DATA_EXT.ProtocolDataSubValue6"]/*' />
    [NativeTypeName("DWORD")]
    public uint ProtocolDataSubValue6;

    /// <include file='STORAGE_PROTOCOL_SPECIFIC_DATA_EXT.xml' path='doc/member[@name="STORAGE_PROTOCOL_SPECIFIC_DATA_EXT.Reserved"]/*' />
    [NativeTypeName("DWORD[4]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public uint e0;
    }
}
