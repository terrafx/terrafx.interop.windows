// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct HIDP_CAPS
    {
        [NativeTypeName("USAGE")]
        public ushort Usage;

        [NativeTypeName("USAGE")]
        public ushort UsagePage;

        [NativeTypeName("USHORT")]
        public ushort InputReportByteLength;

        [NativeTypeName("USHORT")]
        public ushort OutputReportByteLength;

        [NativeTypeName("USHORT")]
        public ushort FeatureReportByteLength;

        [NativeTypeName("USHORT [17]")]
        public fixed ushort Reserved[17];

        [NativeTypeName("USHORT")]
        public ushort NumberLinkCollectionNodes;

        [NativeTypeName("USHORT")]
        public ushort NumberInputButtonCaps;

        [NativeTypeName("USHORT")]
        public ushort NumberInputValueCaps;

        [NativeTypeName("USHORT")]
        public ushort NumberInputDataIndices;

        [NativeTypeName("USHORT")]
        public ushort NumberOutputButtonCaps;

        [NativeTypeName("USHORT")]
        public ushort NumberOutputValueCaps;

        [NativeTypeName("USHORT")]
        public ushort NumberOutputDataIndices;

        [NativeTypeName("USHORT")]
        public ushort NumberFeatureButtonCaps;

        [NativeTypeName("USHORT")]
        public ushort NumberFeatureValueCaps;

        [NativeTypeName("USHORT")]
        public ushort NumberFeatureDataIndices;
    }
}
