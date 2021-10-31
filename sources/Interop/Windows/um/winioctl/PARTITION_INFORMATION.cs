// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct PARTITION_INFORMATION
    {
        public LARGE_INTEGER StartingOffset;

        public LARGE_INTEGER PartitionLength;

        [NativeTypeName("DWORD")]
        public uint HiddenSectors;

        [NativeTypeName("DWORD")]
        public uint PartitionNumber;

        public byte PartitionType;

        [NativeTypeName("BOOLEAN")]
        public byte BootIndicator;

        [NativeTypeName("BOOLEAN")]
        public byte RecognizedPartition;

        [NativeTypeName("BOOLEAN")]
        public byte RewritePartition;
    }
}
