// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct MINIDUMP_MISC_INFO_5
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

        [NativeTypeName("ULONG32")]
        public uint ProcessIntegrityLevel;

        [NativeTypeName("ULONG32")]
        public uint ProcessExecuteFlags;

        [NativeTypeName("ULONG32")]
        public uint ProtectedProcess;

        [NativeTypeName("ULONG32")]
        public uint TimeZoneId;

        public TIME_ZONE_INFORMATION TimeZone;

        [NativeTypeName("WCHAR [260]")]
        public fixed ushort BuildString[260];

        [NativeTypeName("WCHAR [40]")]
        public fixed ushort DbgBldStr[40];

        public XSTATE_CONFIG_FEATURE_MSC_INFO XStateData;

        [NativeTypeName("ULONG32")]
        public uint ProcessCookie;
    }
}
