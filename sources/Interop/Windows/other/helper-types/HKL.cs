// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HKL : IEquatable<HKL>
    {
        public readonly nint Value;

        public HKL(nint value)
        {
            Value = value;
        }

        public static HKL INVALID_VALUE => new HKL(-1);

        public static HKL NULL => new HKL(0);

        public static bool operator ==(HKL left, HKL right) => left.Value == right.Value;

        public static bool operator !=(HKL left, HKL right) => left.Value != right.Value;

        public static explicit operator HKL(void* value) => new HKL((nint)(value));

        public static implicit operator void*(HKL value) => (void*)(value.Value);

        public static explicit operator HKL(HANDLE value) => new HKL(value);

        public static implicit operator HANDLE(HKL value) => new HKL(value);

        public static explicit operator HKL(byte value) => new HKL((nint)(value));

        public static explicit operator byte(HKL value) => (byte)(value.Value);

        public static explicit operator HKL(short value) => new HKL((nint)(value));

        public static explicit operator short(HKL value) => (short)(value.Value);

        public static explicit operator HKL(int value) => new HKL((nint)(value));

        public static explicit operator int(HKL value) => (int)(value.Value);

        public static explicit operator HKL(long value) => new HKL((nint)(value));

        public static implicit operator long(HKL value) => (long)(value.Value);

        public static explicit operator HKL(nint value) => new HKL((nint)(value));

        public static implicit operator nint(HKL value) => (nint)(value.Value);

        public static explicit operator HKL(sbyte value) => new HKL((nint)(value));

        public static explicit operator sbyte(HKL value) => (sbyte)(value.Value);

        public static explicit operator HKL(ushort value) => new HKL((nint)(value));

        public static explicit operator ushort(HKL value) => (ushort)(value.Value);

        public static explicit operator HKL(uint value) => new HKL((nint)(value));

        public static explicit operator uint(HKL value) => (uint)(value.Value);

        public static explicit operator HKL(ulong value) => new HKL((nint)(value));

        public static implicit operator ulong(HKL value) => (ulong)(value.Value);

        public static explicit operator HKL(nuint value) => new HKL((nint)(value));

        public static explicit operator nuint(HKL value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HKL other) && Equals(other);

        public bool Equals(HKL other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
