// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct TXFS_START_RM_INFORMATION
    {
        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORDLONG")]
        public ulong LogContainerSize;

        [NativeTypeName("DWORD")]
        public uint LogContainerCountMin;

        [NativeTypeName("DWORD")]
        public uint LogContainerCountMax;

        [NativeTypeName("DWORD")]
        public uint LogGrowthIncrement;

        [NativeTypeName("DWORD")]
        public uint LogAutoShrinkPercentage;

        [NativeTypeName("DWORD")]
        public uint TmLogPathOffset;

        [NativeTypeName("WORD")]
        public ushort TmLogPathLength;

        [NativeTypeName("WORD")]
        public ushort LoggingMode;

        [NativeTypeName("WORD")]
        public ushort LogPathLength;

        [NativeTypeName("WORD")]
        public ushort Reserved;

        [NativeTypeName("WCHAR [1]")]
        public fixed ushort LogPath[1];
    }
}
