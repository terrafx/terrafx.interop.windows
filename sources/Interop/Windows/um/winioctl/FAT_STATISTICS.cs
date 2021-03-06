// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct FAT_STATISTICS
    {
        [NativeTypeName("DWORD")]
        public uint CreateHits;

        [NativeTypeName("DWORD")]
        public uint SuccessfulCreates;

        [NativeTypeName("DWORD")]
        public uint FailedCreates;

        [NativeTypeName("DWORD")]
        public uint NonCachedReads;

        [NativeTypeName("DWORD")]
        public uint NonCachedReadBytes;

        [NativeTypeName("DWORD")]
        public uint NonCachedWrites;

        [NativeTypeName("DWORD")]
        public uint NonCachedWriteBytes;

        [NativeTypeName("DWORD")]
        public uint NonCachedDiskReads;

        [NativeTypeName("DWORD")]
        public uint NonCachedDiskWrites;
    }
}
