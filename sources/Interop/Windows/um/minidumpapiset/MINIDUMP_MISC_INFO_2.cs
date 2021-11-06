// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct MINIDUMP_MISC_INFO_2
    {
        [NativeTypeName("ULONG32")]
        public uint SizeOfInfo;

        [NativeTypeName("ULONG32")]
        public uint Flags1;

        [NativeTypeName("ULONG32")]
        public uint ProcessId;

        [NativeTypeName("ULONG32")]
        public uint ProcessCreateTime;

        [NativeTypeName("ULONG32")]
        public uint ProcessUserTime;

        [NativeTypeName("ULONG32")]
        public uint ProcessKernelTime;

        [NativeTypeName("ULONG32")]
        public uint ProcessorMaxMhz;

        [NativeTypeName("ULONG32")]
        public uint ProcessorCurrentMhz;

        [NativeTypeName("ULONG32")]
        public uint ProcessorMhzLimit;

        [NativeTypeName("ULONG32")]
        public uint ProcessorMaxIdleState;

        [NativeTypeName("ULONG32")]
        public uint ProcessorCurrentIdleState;
    }
}
