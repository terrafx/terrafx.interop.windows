// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SCRUB_DATA_OUTPUT
    {
        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint Status;

        [NativeTypeName("ULONGLONG")]
        public ulong ErrorFileOffset;

        [NativeTypeName("ULONGLONG")]
        public ulong ErrorLength;

        [NativeTypeName("ULONGLONG")]
        public ulong NumberOfBytesRepaired;

        [NativeTypeName("ULONGLONG")]
        public ulong NumberOfBytesFailed;

        [NativeTypeName("ULONGLONG")]
        public ulong InternalFileReference;

        [NativeTypeName("WORD")]
        public ushort ResumeContextLength;

        [NativeTypeName("WORD")]
        public ushort ParityExtentDataOffset;

        [NativeTypeName("DWORD [9]")]
        public fixed uint Reserved[9];

        [NativeTypeName("ULONGLONG")]
        public ulong NumberOfMetadataBytesProcessed;

        [NativeTypeName("ULONGLONG")]
        public ulong NumberOfDataBytesProcessed;

        [NativeTypeName("ULONGLONG")]
        public ulong TotalNumberOfMetadataBytesInUse;

        [NativeTypeName("ULONGLONG")]
        public ulong TotalNumberOfDataBytesInUse;

        [NativeTypeName("BYTE [816]")]
        public fixed byte ResumeContext[816];
    }
}
