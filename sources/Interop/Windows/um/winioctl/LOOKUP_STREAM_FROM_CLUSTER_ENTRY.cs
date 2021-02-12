// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct LOOKUP_STREAM_FROM_CLUSTER_ENTRY
    {
        [NativeTypeName("DWORD")]
        public uint OffsetToNext;

        [NativeTypeName("DWORD")]
        public uint Flags;

        public LARGE_INTEGER Reserved;

        public LARGE_INTEGER Cluster;

        [NativeTypeName("WCHAR [1]")]
        public fixed ushort FileName[1];
    }
}
