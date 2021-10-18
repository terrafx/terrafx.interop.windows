// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public unsafe partial struct WINHTTP_REQUEST_STATS
    {
        [NativeTypeName("ULONGLONG")]
        public ulong ullFlags;

        [NativeTypeName("ULONG")]
        public uint ulIndex;

        [NativeTypeName("ULONG")]
        public uint cStats;

        [NativeTypeName("ULONGLONG [32]")]
        public fixed ulong rgullStats[32];
    }
}
