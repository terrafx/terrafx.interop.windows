// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
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
            internal PPM_IDLE_STATE_BUCKET_EX e0;
            internal PPM_IDLE_STATE_BUCKET_EX e1;
            internal PPM_IDLE_STATE_BUCKET_EX e2;
            internal PPM_IDLE_STATE_BUCKET_EX e3;
            internal PPM_IDLE_STATE_BUCKET_EX e4;
            internal PPM_IDLE_STATE_BUCKET_EX e5;
            internal PPM_IDLE_STATE_BUCKET_EX e6;
            internal PPM_IDLE_STATE_BUCKET_EX e7;
            internal PPM_IDLE_STATE_BUCKET_EX e8;
            internal PPM_IDLE_STATE_BUCKET_EX e9;
            internal PPM_IDLE_STATE_BUCKET_EX e10;
            internal PPM_IDLE_STATE_BUCKET_EX e11;
            internal PPM_IDLE_STATE_BUCKET_EX e12;
            internal PPM_IDLE_STATE_BUCKET_EX e13;
            internal PPM_IDLE_STATE_BUCKET_EX e14;
            internal PPM_IDLE_STATE_BUCKET_EX e15;

            public ref PPM_IDLE_STATE_BUCKET_EX this[int index] => ref AsSpan()[index];

            public Span<PPM_IDLE_STATE_BUCKET_EX> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
        }
    }
}
