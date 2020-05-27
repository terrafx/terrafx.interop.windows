// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct FILE_STORAGE_INFO
    {
        [NativeTypeName("ULONG")]
        public uint LogicalBytesPerSector;

        [NativeTypeName("ULONG")]
        public uint PhysicalBytesPerSectorForAtomicity;

        [NativeTypeName("ULONG")]
        public uint PhysicalBytesPerSectorForPerformance;

        [NativeTypeName("ULONG")]
        public uint FileSystemEffectivePhysicalBytesPerSectorForAtomicity;

        [NativeTypeName("ULONG")]
        public uint Flags;

        [NativeTypeName("ULONG")]
        public uint ByteOffsetForSectorAlignment;

        [NativeTypeName("ULONG")]
        public uint ByteOffsetForPartitionAlignment;
    }
}
