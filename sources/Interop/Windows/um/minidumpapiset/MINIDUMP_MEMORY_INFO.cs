// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct MINIDUMP_MEMORY_INFO
    {
        [NativeTypeName("ULONG64")]
        public ulong BaseAddress;

        [NativeTypeName("ULONG64")]
        public ulong AllocationBase;

        [NativeTypeName("ULONG32")]
        public uint AllocationProtect;

        [NativeTypeName("ULONG32")]
        public uint __alignment1;

        [NativeTypeName("ULONG64")]
        public ulong RegionSize;

        [NativeTypeName("ULONG32")]
        public uint State;

        [NativeTypeName("ULONG32")]
        public uint Protect;

        [NativeTypeName("ULONG32")]
        public uint Type;

        [NativeTypeName("ULONG32")]
        public uint __alignment2;
    }
}
