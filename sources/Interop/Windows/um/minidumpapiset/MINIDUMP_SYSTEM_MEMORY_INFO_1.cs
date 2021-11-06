// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct MINIDUMP_SYSTEM_MEMORY_INFO_1
    {
        public ushort Revision;

        public ushort Flags;

        public MINIDUMP_SYSTEM_BASIC_INFORMATION BasicInfo;

        public MINIDUMP_SYSTEM_FILECACHE_INFORMATION FileCacheInfo;

        public MINIDUMP_SYSTEM_BASIC_PERFORMANCE_INFORMATION BasicPerfInfo;

        public MINIDUMP_SYSTEM_PERFORMANCE_INFORMATION PerfInfo;
    }
}
