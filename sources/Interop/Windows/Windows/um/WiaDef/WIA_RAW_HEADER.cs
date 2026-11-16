// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WiaDef.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='WIA_RAW_HEADER.xml' path='doc/member[@name="WIA_RAW_HEADER"]/*' />
public partial struct WIA_RAW_HEADER
{
    /// <include file='WIA_RAW_HEADER.xml' path='doc/member[@name="WIA_RAW_HEADER.Tag"]/*' />
    [NativeTypeName("DWORD")]
    public uint Tag;

    /// <include file='WIA_RAW_HEADER.xml' path='doc/member[@name="WIA_RAW_HEADER.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='WIA_RAW_HEADER.xml' path='doc/member[@name="WIA_RAW_HEADER.HeaderSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint HeaderSize;

    /// <include file='WIA_RAW_HEADER.xml' path='doc/member[@name="WIA_RAW_HEADER.XRes"]/*' />
    [NativeTypeName("DWORD")]
    public uint XRes;

    /// <include file='WIA_RAW_HEADER.xml' path='doc/member[@name="WIA_RAW_HEADER.YRes"]/*' />
    [NativeTypeName("DWORD")]
    public uint YRes;

    /// <include file='WIA_RAW_HEADER.xml' path='doc/member[@name="WIA_RAW_HEADER.XExtent"]/*' />
    [NativeTypeName("DWORD")]
    public uint XExtent;

    /// <include file='WIA_RAW_HEADER.xml' path='doc/member[@name="WIA_RAW_HEADER.YExtent"]/*' />
    [NativeTypeName("DWORD")]
    public uint YExtent;

    /// <include file='WIA_RAW_HEADER.xml' path='doc/member[@name="WIA_RAW_HEADER.BytesPerLine"]/*' />
    [NativeTypeName("DWORD")]
    public uint BytesPerLine;

    /// <include file='WIA_RAW_HEADER.xml' path='doc/member[@name="WIA_RAW_HEADER.BitsPerPixel"]/*' />
    [NativeTypeName("DWORD")]
    public uint BitsPerPixel;

    /// <include file='WIA_RAW_HEADER.xml' path='doc/member[@name="WIA_RAW_HEADER.ChannelsPerPixel"]/*' />
    [NativeTypeName("DWORD")]
    public uint ChannelsPerPixel;

    /// <include file='WIA_RAW_HEADER.xml' path='doc/member[@name="WIA_RAW_HEADER.DataType"]/*' />
    [NativeTypeName("DWORD")]
    public uint DataType;

    /// <include file='WIA_RAW_HEADER.xml' path='doc/member[@name="WIA_RAW_HEADER.BitsPerChannel"]/*' />
    [NativeTypeName("BYTE[8]")]
    public _BitsPerChannel_e__FixedBuffer BitsPerChannel;

    /// <include file='WIA_RAW_HEADER.xml' path='doc/member[@name="WIA_RAW_HEADER.Compression"]/*' />
    [NativeTypeName("DWORD")]
    public uint Compression;

    /// <include file='WIA_RAW_HEADER.xml' path='doc/member[@name="WIA_RAW_HEADER.PhotometricInterp"]/*' />
    [NativeTypeName("DWORD")]
    public uint PhotometricInterp;

    /// <include file='WIA_RAW_HEADER.xml' path='doc/member[@name="WIA_RAW_HEADER.LineOrder"]/*' />
    [NativeTypeName("DWORD")]
    public uint LineOrder;

    /// <include file='WIA_RAW_HEADER.xml' path='doc/member[@name="WIA_RAW_HEADER.RawDataOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint RawDataOffset;

    /// <include file='WIA_RAW_HEADER.xml' path='doc/member[@name="WIA_RAW_HEADER.RawDataSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint RawDataSize;

    /// <include file='WIA_RAW_HEADER.xml' path='doc/member[@name="WIA_RAW_HEADER.PaletteOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint PaletteOffset;

    /// <include file='WIA_RAW_HEADER.xml' path='doc/member[@name="WIA_RAW_HEADER.PaletteSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint PaletteSize;

    /// <include file='_BitsPerChannel_e__FixedBuffer.xml' path='doc/member[@name="_BitsPerChannel_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _BitsPerChannel_e__FixedBuffer
    {
        public byte e0;
    }
}
