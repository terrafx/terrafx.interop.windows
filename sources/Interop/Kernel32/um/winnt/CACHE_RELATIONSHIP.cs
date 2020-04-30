// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CACHE_RELATIONSHIP
    {
        [NativeTypeName("BYTE")]
        public byte Level;

        [NativeTypeName("BYTE")]
        public byte Associativity;

        [NativeTypeName("WORD")]
        public ushort LineSize;

        [NativeTypeName("DWORD")]
        public uint CacheSize;

        public PROCESSOR_CACHE_TYPE Type;

        [NativeTypeName("BYTE [20]")]
        public fixed byte Reserved[20];

        public GROUP_AFFINITY GroupMask;
    }
}
