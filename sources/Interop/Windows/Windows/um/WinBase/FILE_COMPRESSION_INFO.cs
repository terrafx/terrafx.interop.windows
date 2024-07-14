// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='FILE_COMPRESSION_INFO.xml' path='doc/member[@name="FILE_COMPRESSION_INFO"]/*' />
public partial struct FILE_COMPRESSION_INFO
{
    /// <include file='FILE_COMPRESSION_INFO.xml' path='doc/member[@name="FILE_COMPRESSION_INFO.CompressedFileSize"]/*' />
    public LARGE_INTEGER CompressedFileSize;

    /// <include file='FILE_COMPRESSION_INFO.xml' path='doc/member[@name="FILE_COMPRESSION_INFO.CompressionFormat"]/*' />
    [NativeTypeName("WORD")]
    public ushort CompressionFormat;

    /// <include file='FILE_COMPRESSION_INFO.xml' path='doc/member[@name="FILE_COMPRESSION_INFO.CompressionUnitShift"]/*' />
    [NativeTypeName("UCHAR")]
    public byte CompressionUnitShift;

    /// <include file='FILE_COMPRESSION_INFO.xml' path='doc/member[@name="FILE_COMPRESSION_INFO.ChunkShift"]/*' />
    [NativeTypeName("UCHAR")]
    public byte ChunkShift;

    /// <include file='FILE_COMPRESSION_INFO.xml' path='doc/member[@name="FILE_COMPRESSION_INFO.ClusterShift"]/*' />
    [NativeTypeName("UCHAR")]
    public byte ClusterShift;

    /// <include file='FILE_COMPRESSION_INFO.xml' path='doc/member[@name="FILE_COMPRESSION_INFO.Reserved"]/*' />
    [NativeTypeName("UCHAR[3]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(3)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public byte e0;
    }
}
