// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDRVOBJ : IComparable, IComparable<HDRVOBJ>, IEquatable<HDRVOBJ>, IFormattable
    {
        public readonly nint Value;

        public HDRVOBJ(nint value)
        {
            Value = value;
        }

        public static HDRVOBJ INVALID_VALUE => new HDRVOBJ(-1);

        public static HDRVOBJ NULL => new HDRVOBJ(0);

        public static bool operator ==(HDRVOBJ left, HDRVOBJ right) => left.Value == right.Value;

        public static bool operator !=(HDRVOBJ left, HDRVOBJ right) => left.Value != right.Value;

        public static bool operator <(HDRVOBJ left, HDRVOBJ right) => left.Value < right.Value;

        public static bool operator <=(HDRVOBJ left, HDRVOBJ right) => left.Value <= right.Value;

        public static bool operator >(HDRVOBJ left, HDRVOBJ right) => left.Value > right.Value;

        public static bool operator >=(HDRVOBJ left, HDRVOBJ right) => left.Value >= right.Value;

        public static explicit operator HDRVOBJ(void* value) => new HDRVOBJ((nint)(value));

        public static implicit operator void*(HDRVOBJ value) => (void*)(value.Value);

        public static explicit operator HDRVOBJ(HANDLE value) => new HDRVOBJ(value);

        public static implicit operator HANDLE(HDRVOBJ value) => new HANDLE(value.Value);

        public static explicit operator HDRVOBJ(byte value) => new HDRVOBJ((nint)(value));

        public static explicit operator byte(HDRVOBJ value) => (byte)(value.Value);

        public static explicit operator HDRVOBJ(short value) => new HDRVOBJ((nint)(value));

        public static explicit operator short(HDRVOBJ value) => (short)(value.Value);

        public static explicit operator HDRVOBJ(int value) => new HDRVOBJ((nint)(value));

        public static explicit operator int(HDRVOBJ value) => (int)(value.Value);

        public static explicit operator HDRVOBJ(long value) => new HDRVOBJ((nint)(value));

        public static implicit operator long(HDRVOBJ value) => (long)(value.Value);

        public static explicit operator HDRVOBJ(nint value) => new HDRVOBJ((nint)(value));

        public static implicit operator nint(HDRVOBJ value) => (nint)(value.Value);

        public static explicit operator HDRVOBJ(sbyte value) => new HDRVOBJ((nint)(value));

        public static explicit operator sbyte(HDRVOBJ value) => (sbyte)(value.Value);

        public static explicit operator HDRVOBJ(ushort value) => new HDRVOBJ((nint)(value));

        public static explicit operator ushort(HDRVOBJ value) => (ushort)(value.Value);

        public static explicit operator HDRVOBJ(uint value) => new HDRVOBJ((nint)(value));

        public static explicit operator uint(HDRVOBJ value) => (uint)(value.Value);

        public static explicit operator HDRVOBJ(ulong value) => new HDRVOBJ((nint)(value));

        public static explicit operator ulong(HDRVOBJ value) => (ulong)(value.Value);

        public static explicit operator HDRVOBJ(nuint value) => new HDRVOBJ((nint)(value));

        public static explicit operator nuint(HDRVOBJ value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HDRVOBJ other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HDRVOBJ.");
        }

        public int CompareTo(HDRVOBJ other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HDRVOBJ other) && Equals(other);

        public bool Equals(HDRVOBJ other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
