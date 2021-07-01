// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct PPM_IDLE_STATE_ACCOUNTING
    {
        [NativeTypeName("DWORD")]
        public uint IdleTransitions;

        [NativeTypeName("DWORD")]
        public uint FailedTransitions;

        [NativeTypeName("DWORD")]
        public uint InvalidBucketIndex;

        [NativeTypeName("DWORD64")]
        public ulong TotalTime;

        [NativeTypeName("DWORD [6]")]
        public fixed uint IdleTimeBuckets[6];
    }
}
