// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct ENCRYPTED_DATA_INFO
    {
        [NativeTypeName("DWORDLONG")]
        public ulong StartingFileOffset;

        [NativeTypeName("DWORD")]
        public uint OutputBufferOffset;

        [NativeTypeName("DWORD")]
        public uint BytesWithinFileSize;

        [NativeTypeName("DWORD")]
        public uint BytesWithinValidDataLength;

        [NativeTypeName("WORD")]
        public ushort CompressionFormat;

        public byte DataUnitShift;

        public byte ChunkShift;

        public byte ClusterShift;

        public byte EncryptionFormat;

        [NativeTypeName("WORD")]
        public ushort NumberOfDataBlocks;

        [NativeTypeName("DWORD [1]")]
        public fixed uint DataBlockSize[1];
    }
}
