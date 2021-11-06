// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct CPU_INFORMATION
    {
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/minidumpapiset.h:192:5)")]
        public _X86CpuInfo_e__Struct X86CpuInfo;

        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/minidumpapiset.h:226:5)")]
        public _OtherCpuInfo_e__Struct OtherCpuInfo;

        public unsafe partial struct _X86CpuInfo_e__Struct
        {
            [NativeTypeName("ULONG32 [3]")]
            public fixed uint VendorId[3];

            [NativeTypeName("ULONG32")]
            public uint VersionInformation;

            [NativeTypeName("ULONG32")]
            public uint FeatureInformation;

            [NativeTypeName("ULONG32")]
            public uint AMDExtendedCpuFeatures;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public unsafe partial struct _OtherCpuInfo_e__Struct
        {
            [NativeTypeName("ULONG64 [2]")]
            public fixed ulong ProcessorFeatures[2];
        }
    }
}
