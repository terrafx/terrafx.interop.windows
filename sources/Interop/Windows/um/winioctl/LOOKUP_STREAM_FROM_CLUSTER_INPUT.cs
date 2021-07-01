// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct LOOKUP_STREAM_FROM_CLUSTER_INPUT
    {
        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint NumberOfClusters;

        [NativeTypeName("LARGE_INTEGER [1]")]
        public _Cluster_e__FixedBuffer Cluster;

        public partial struct _Cluster_e__FixedBuffer
        {
            public LARGE_INTEGER e0;

            public ref LARGE_INTEGER this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<LARGE_INTEGER> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
