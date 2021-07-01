// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct POINTER_DEVICE_PROPERTY
    {
        [NativeTypeName("INT32")]
        public int logicalMin;

        [NativeTypeName("INT32")]
        public int logicalMax;

        [NativeTypeName("INT32")]
        public int physicalMin;

        [NativeTypeName("INT32")]
        public int physicalMax;

        [NativeTypeName("UINT32")]
        public uint unit;

        [NativeTypeName("UINT32")]
        public uint unitExponent;

        [NativeTypeName("USHORT")]
        public ushort usagePageId;

        [NativeTypeName("USHORT")]
        public ushort usageId;
    }
}
