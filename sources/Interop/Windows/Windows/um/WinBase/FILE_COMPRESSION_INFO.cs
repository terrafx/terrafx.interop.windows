// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct FILE_COMPRESSION_INFO
    {
        public LARGE_INTEGER CompressedFileSize;

        [NativeTypeName("WORD")]
        public ushort CompressionFormat;

        [NativeTypeName("UCHAR")]
        public byte CompressionUnitShift;

        [NativeTypeName("UCHAR")]
        public byte ChunkShift;

        [NativeTypeName("UCHAR")]
        public byte ClusterShift;

        [NativeTypeName("UCHAR [3]")]
        public fixed byte Reserved[3];
    }
}
