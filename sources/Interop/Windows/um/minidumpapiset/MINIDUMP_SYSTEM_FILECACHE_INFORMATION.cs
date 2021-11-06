// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct MINIDUMP_SYSTEM_FILECACHE_INFORMATION
    {
        [NativeTypeName("ULONG64")]
        public ulong CurrentSize;

        [NativeTypeName("ULONG64")]
        public ulong PeakSize;

        [NativeTypeName("ULONG")]
        public uint PageFaultCount;

        [NativeTypeName("ULONG64")]
        public ulong MinimumWorkingSet;

        [NativeTypeName("ULONG64")]
        public ulong MaximumWorkingSet;

        [NativeTypeName("ULONG64")]
        public ulong CurrentSizeIncludingTransitionInPages;

        [NativeTypeName("ULONG64")]
        public ulong PeakSizeIncludingTransitionInPages;

        [NativeTypeName("ULONG")]
        public uint TransitionRePurposeCount;

        [NativeTypeName("ULONG")]
        public uint Flags;
    }
}
