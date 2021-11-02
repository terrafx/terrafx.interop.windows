// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HMETAFILEPICT : IComparable, IComparable<HMETAFILEPICT>, IEquatable<HMETAFILEPICT>, IFormattable
    {
        public readonly nint Value;

        public HMETAFILEPICT(nint value)
        {
            Value = value;
        }

        public static HMETAFILEPICT INVALID_VALUE => new HMETAFILEPICT(-1);

        public static HMETAFILEPICT NULL => new HMETAFILEPICT(0);

        public static bool operator ==(HMETAFILEPICT left, HMETAFILEPICT right) => left.Value == right.Value;

        public static bool operator !=(HMETAFILEPICT left, HMETAFILEPICT right) => left.Value != right.Value;

        public static bool operator <(HMETAFILEPICT left, HMETAFILEPICT right) => left.Value < right.Value;

        public static bool operator <=(HMETAFILEPICT left, HMETAFILEPICT right) => left.Value <= right.Value;

        public static bool operator >(HMETAFILEPICT left, HMETAFILEPICT right) => left.Value > right.Value;

        public static bool operator >=(HMETAFILEPICT left, HMETAFILEPICT right) => left.Value >= right.Value;

        public static explicit operator HMETAFILEPICT(void* value) => new HMETAFILEPICT((nint)(value));

        public static implicit operator void*(HMETAFILEPICT value) => (void*)(value.Value);

        public static explicit operator HMETAFILEPICT(HANDLE value) => new HMETAFILEPICT(value);

        public static implicit operator HANDLE(HMETAFILEPICT value) => new HANDLE(value.Value);

        public static explicit operator HMETAFILEPICT(byte value) => new HMETAFILEPICT((nint)(value));

        public static explicit operator byte(HMETAFILEPICT value) => (byte)(value.Value);

        public static explicit operator HMETAFILEPICT(short value) => new HMETAFILEPICT((nint)(value));

        public static explicit operator short(HMETAFILEPICT value) => (short)(value.Value);

        public static explicit operator HMETAFILEPICT(int value) => new HMETAFILEPICT((nint)(value));

        public static explicit operator int(HMETAFILEPICT value) => (int)(value.Value);

        public static explicit operator HMETAFILEPICT(long value) => new HMETAFILEPICT((nint)(value));

        public static implicit operator long(HMETAFILEPICT value) => value.Value;

        public static explicit operator HMETAFILEPICT(nint value) => new HMETAFILEPICT((nint)(value));

        public static implicit operator nint(HMETAFILEPICT value) => value.Value;

        public static explicit operator HMETAFILEPICT(sbyte value) => new HMETAFILEPICT((nint)(value));

        public static explicit operator sbyte(HMETAFILEPICT value) => (sbyte)(value.Value);

        public static explicit operator HMETAFILEPICT(ushort value) => new HMETAFILEPICT((nint)(value));

        public static explicit operator ushort(HMETAFILEPICT value) => (ushort)(value.Value);

        public static explicit operator HMETAFILEPICT(uint value) => new HMETAFILEPICT((nint)(value));

        public static explicit operator uint(HMETAFILEPICT value) => (uint)(value.Value);

        public static explicit operator HMETAFILEPICT(ulong value) => new HMETAFILEPICT((nint)(value));

        public static explicit operator ulong(HMETAFILEPICT value) => (ulong)(value.Value);

        public static explicit operator HMETAFILEPICT(nuint value) => new HMETAFILEPICT((nint)(value));

        public static explicit operator nuint(HMETAFILEPICT value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HMETAFILEPICT other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HMETAFILEPICT.");
        }

        public int CompareTo(HMETAFILEPICT other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HMETAFILEPICT other) && Equals(other);

        public bool Equals(HMETAFILEPICT other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}
