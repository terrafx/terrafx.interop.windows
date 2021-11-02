// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct COMPRESSOR_HANDLE : IEquatable<COMPRESSOR_HANDLE>
    {
        public readonly nint Value;

        public COMPRESSOR_HANDLE(nint value)
        {
            Value = value;
        }

        public static COMPRESSOR_HANDLE INVALID_HANDLE_VALUE => new COMPRESSOR_HANDLE(-1);

        public static COMPRESSOR_HANDLE NULL => new COMPRESSOR_HANDLE(0);

        public static bool operator ==(COMPRESSOR_HANDLE left, COMPRESSOR_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(COMPRESSOR_HANDLE left, COMPRESSOR_HANDLE right) => left.Value != right.Value;

        public static explicit operator COMPRESSOR_HANDLE(void* value) => new COMPRESSOR_HANDLE((nint)(value));

        public static implicit operator void*(COMPRESSOR_HANDLE value) => (void*)(value.Value);

        public static explicit operator COMPRESSOR_HANDLE(HANDLE value) => new COMPRESSOR_HANDLE(value);

        public static implicit operator HANDLE(COMPRESSOR_HANDLE value) => new COMPRESSOR_HANDLE(value);

        public static explicit operator COMPRESSOR_HANDLE(byte value) => new COMPRESSOR_HANDLE((nint)(value));

        public static implicit operator byte(COMPRESSOR_HANDLE value) => (byte)(value.Value);

        public static explicit operator COMPRESSOR_HANDLE(short value) => new COMPRESSOR_HANDLE((nint)(value));

        public static implicit operator short(COMPRESSOR_HANDLE value) => (short)(value.Value);

        public static explicit operator COMPRESSOR_HANDLE(int value) => new COMPRESSOR_HANDLE((nint)(value));

        public static implicit operator int(COMPRESSOR_HANDLE value) => (int)(value.Value);

        public static explicit operator COMPRESSOR_HANDLE(long value) => new COMPRESSOR_HANDLE((nint)(value));

        public static explicit operator long(COMPRESSOR_HANDLE value) => (long)(value.Value);

        public static explicit operator COMPRESSOR_HANDLE(nint value) => new COMPRESSOR_HANDLE((nint)(value));

        public static implicit operator nint(COMPRESSOR_HANDLE value) => (nint)(value.Value);

        public static explicit operator COMPRESSOR_HANDLE(sbyte value) => new COMPRESSOR_HANDLE((nint)(value));

        public static implicit operator sbyte(COMPRESSOR_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator COMPRESSOR_HANDLE(ushort value) => new COMPRESSOR_HANDLE((nint)(value));

        public static implicit operator ushort(COMPRESSOR_HANDLE value) => (ushort)(value.Value);

        public static explicit operator COMPRESSOR_HANDLE(uint value) => new COMPRESSOR_HANDLE((nint)(value));

        public static implicit operator uint(COMPRESSOR_HANDLE value) => (uint)(value.Value);

        public static explicit operator COMPRESSOR_HANDLE(ulong value) => new COMPRESSOR_HANDLE((nint)(value));

        public static explicit operator ulong(COMPRESSOR_HANDLE value) => (ulong)(value.Value);

        public static explicit operator COMPRESSOR_HANDLE(nuint value) => new COMPRESSOR_HANDLE((nint)(value));

        public static explicit operator nuint(COMPRESSOR_HANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is COMPRESSOR_HANDLE other) && Equals(other);

        public bool Equals(COMPRESSOR_HANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
