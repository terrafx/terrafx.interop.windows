// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct HIBERFILE_BUCKET
    {
        [NativeTypeName("DWORD64")]
        public ulong MaxPhysicalMemory;

        [NativeTypeName("DWORD [3]")]
        public fixed uint PhysicalMemoryPercent[3];
    }
}
