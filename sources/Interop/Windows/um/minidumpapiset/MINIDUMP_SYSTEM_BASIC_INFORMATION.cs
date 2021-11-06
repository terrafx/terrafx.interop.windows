// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct MINIDUMP_SYSTEM_BASIC_INFORMATION
    {
        [NativeTypeName("ULONG")]
        public uint TimerResolution;

        [NativeTypeName("ULONG")]
        public uint PageSize;

        [NativeTypeName("ULONG")]
        public uint NumberOfPhysicalPages;

        [NativeTypeName("ULONG")]
        public uint LowestPhysicalPageNumber;

        [NativeTypeName("ULONG")]
        public uint HighestPhysicalPageNumber;

        [NativeTypeName("ULONG")]
        public uint AllocationGranularity;

        [NativeTypeName("ULONG64")]
        public ulong MinimumUserModeAddress;

        [NativeTypeName("ULONG64")]
        public ulong MaximumUserModeAddress;

        [NativeTypeName("ULONG64")]
        public ulong ActiveProcessorsAffinityMask;

        [NativeTypeName("ULONG")]
        public uint NumberOfProcessors;
    }
}
