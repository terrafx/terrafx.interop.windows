// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public partial struct PPM_IDLE_STATE_ACCOUNTING_EX
    {
        [NativeTypeName("DWORD64")]
        public ulong TotalTime;

        [NativeTypeName("DWORD")]
        public uint IdleTransitions;

        [NativeTypeName("DWORD")]
        public uint FailedTransitions;

        [NativeTypeName("DWORD")]
        public uint InvalidBucketIndex;

        [NativeTypeName("DWORD")]
        public uint MinTimeUs;

        [NativeTypeName("DWORD")]
        public uint MaxTimeUs;

        [NativeTypeName("DWORD")]
        public uint CancelledTransitions;

        [NativeTypeName("PPM_IDLE_STATE_BUCKET_EX [16]")]
        public _IdleTimeBuckets_e__FixedBuffer IdleTimeBuckets;

        public partial struct _IdleTimeBuckets_e__FixedBuffer
        {
            public PPM_IDLE_STATE_BUCKET_EX e0;
            public PPM_IDLE_STATE_BUCKET_EX e1;
            public PPM_IDLE_STATE_BUCKET_EX e2;
            public PPM_IDLE_STATE_BUCKET_EX e3;
            public PPM_IDLE_STATE_BUCKET_EX e4;
            public PPM_IDLE_STATE_BUCKET_EX e5;
            public PPM_IDLE_STATE_BUCKET_EX e6;
            public PPM_IDLE_STATE_BUCKET_EX e7;
            public PPM_IDLE_STATE_BUCKET_EX e8;
            public PPM_IDLE_STATE_BUCKET_EX e9;
            public PPM_IDLE_STATE_BUCKET_EX e10;
            public PPM_IDLE_STATE_BUCKET_EX e11;
            public PPM_IDLE_STATE_BUCKET_EX e12;
            public PPM_IDLE_STATE_BUCKET_EX e13;
            public PPM_IDLE_STATE_BUCKET_EX e14;
            public PPM_IDLE_STATE_BUCKET_EX e15;

            public ref PPM_IDLE_STATE_BUCKET_EX this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<PPM_IDLE_STATE_BUCKET_EX> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
        }
    }
}
