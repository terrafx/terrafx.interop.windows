// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='CPU_INFORMATION.xml' path='doc/member[@name="CPU_INFORMATION"]/*' />
[StructLayout(LayoutKind.Explicit)]
public partial struct CPU_INFORMATION
{
    /// <include file='CPU_INFORMATION.xml' path='doc/member[@name="CPU_INFORMATION.X86CpuInfo"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_minidumpapiset_L192_C5")]
    public _X86CpuInfo_e__Struct X86CpuInfo;

    /// <include file='CPU_INFORMATION.xml' path='doc/member[@name="CPU_INFORMATION.OtherCpuInfo"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_minidumpapiset_L226_C5")]
    public _OtherCpuInfo_e__Struct OtherCpuInfo;

    /// <include file='_X86CpuInfo_e__Struct.xml' path='doc/member[@name="_X86CpuInfo_e__Struct"]/*' />
    public partial struct _X86CpuInfo_e__Struct
    {
        /// <include file='_X86CpuInfo_e__Struct.xml' path='doc/member[@name="_X86CpuInfo_e__Struct.VendorId"]/*' />
        [NativeTypeName("ULONG32[3]")]
        public _VendorId_e__FixedBuffer VendorId;

        /// <include file='_X86CpuInfo_e__Struct.xml' path='doc/member[@name="_X86CpuInfo_e__Struct.VersionInformation"]/*' />
        [NativeTypeName("ULONG32")]
        public uint VersionInformation;

        /// <include file='_X86CpuInfo_e__Struct.xml' path='doc/member[@name="_X86CpuInfo_e__Struct.FeatureInformation"]/*' />
        [NativeTypeName("ULONG32")]
        public uint FeatureInformation;

        /// <include file='_X86CpuInfo_e__Struct.xml' path='doc/member[@name="_X86CpuInfo_e__Struct.AMDExtendedCpuFeatures"]/*' />
        [NativeTypeName("ULONG32")]
        public uint AMDExtendedCpuFeatures;

        /// <include file='_VendorId_e__FixedBuffer.xml' path='doc/member[@name="_VendorId_e__FixedBuffer"]/*' />
        [InlineArray(3)]
        public partial struct _VendorId_e__FixedBuffer
        {
            public uint e0;
        }
    }

    /// <include file='_OtherCpuInfo_e__Struct.xml' path='doc/member[@name="_OtherCpuInfo_e__Struct"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _OtherCpuInfo_e__Struct
    {
        /// <include file='_OtherCpuInfo_e__Struct.xml' path='doc/member[@name="_OtherCpuInfo_e__Struct.ProcessorFeatures"]/*' />
        [NativeTypeName("ULONG64[2]")]
        public _ProcessorFeatures_e__FixedBuffer ProcessorFeatures;

        /// <include file='_ProcessorFeatures_e__FixedBuffer.xml' path='doc/member[@name="_ProcessorFeatures_e__FixedBuffer"]/*' />
        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        [InlineArray(2)]
        public partial struct _ProcessorFeatures_e__FixedBuffer
        {
            public ulong e0;
        }
    }
}
