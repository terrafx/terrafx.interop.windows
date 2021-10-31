// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct DML_SCALAR_UNION
    {
        [FieldOffset(0)]
        [NativeTypeName("BYTE [8]")]
        public fixed byte Bytes[8];

        [FieldOffset(0)]
        [NativeTypeName("INT8")]
        public sbyte Int8;

        [FieldOffset(0)]
        [NativeTypeName("UINT8")]
        public byte UInt8;

        [FieldOffset(0)]
        [NativeTypeName("INT16")]
        public short Int16;

        [FieldOffset(0)]
        [NativeTypeName("UINT16")]
        public ushort UInt16;

        [FieldOffset(0)]
        [NativeTypeName("INT32")]
        public int Int32;

        [FieldOffset(0)]
        [NativeTypeName("UINT32")]
        public uint UInt32;

        [FieldOffset(0)]
        [NativeTypeName("INT64")]
        public long Int64;

        [FieldOffset(0)]
        [NativeTypeName("UINT64")]
        public ulong UInt64;

        [FieldOffset(0)]
        public float Float32;

        [FieldOffset(0)]
        public double Float64;
    }
}
