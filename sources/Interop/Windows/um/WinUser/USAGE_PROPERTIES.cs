// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct USAGE_PROPERTIES
    {
        [NativeTypeName("USHORT")]
        public ushort level;

        [NativeTypeName("USHORT")]
        public ushort page;

        [NativeTypeName("USHORT")]
        public ushort usage;

        [NativeTypeName("INT32")]
        public int logicalMinimum;

        [NativeTypeName("INT32")]
        public int logicalMaximum;

        [NativeTypeName("USHORT")]
        public ushort unit;

        [NativeTypeName("USHORT")]
        public ushort exponent;

        [NativeTypeName("BYTE")]
        public byte count;

        [NativeTypeName("INT32")]
        public int physicalMinimum;

        [NativeTypeName("INT32")]
        public int physicalMaximum;
    }
}
