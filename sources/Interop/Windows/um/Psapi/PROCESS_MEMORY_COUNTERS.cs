// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Psapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct PROCESS_MEMORY_COUNTERS
    {
        [NativeTypeName("DWORD")]
        public uint cb;

        [NativeTypeName("DWORD")]
        public uint PageFaultCount;

        [NativeTypeName("SIZE_T")]
        public nuint PeakWorkingSetSize;

        [NativeTypeName("SIZE_T")]
        public nuint WorkingSetSize;

        [NativeTypeName("SIZE_T")]
        public nuint QuotaPeakPagedPoolUsage;

        [NativeTypeName("SIZE_T")]
        public nuint QuotaPagedPoolUsage;

        [NativeTypeName("SIZE_T")]
        public nuint QuotaPeakNonPagedPoolUsage;

        [NativeTypeName("SIZE_T")]
        public nuint QuotaNonPagedPoolUsage;

        [NativeTypeName("SIZE_T")]
        public nuint PagefileUsage;

        [NativeTypeName("SIZE_T")]
        public nuint PeakPagefileUsage;
    }
}
