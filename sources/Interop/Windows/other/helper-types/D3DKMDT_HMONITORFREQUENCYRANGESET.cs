// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct D3DKMDT_HMONITORFREQUENCYRANGESET : IComparable, IComparable<D3DKMDT_HMONITORFREQUENCYRANGESET>, IEquatable<D3DKMDT_HMONITORFREQUENCYRANGESET>, IFormattable
    {
        public readonly nint Value;

        public D3DKMDT_HMONITORFREQUENCYRANGESET(nint value)
        {
            Value = value;
        }

        public static D3DKMDT_HMONITORFREQUENCYRANGESET INVALID_VALUE => new D3DKMDT_HMONITORFREQUENCYRANGESET(-1);

        public static D3DKMDT_HMONITORFREQUENCYRANGESET NULL => new D3DKMDT_HMONITORFREQUENCYRANGESET(0);

        public static bool operator ==(D3DKMDT_HMONITORFREQUENCYRANGESET left, D3DKMDT_HMONITORFREQUENCYRANGESET right) => left.Value == right.Value;

        public static bool operator !=(D3DKMDT_HMONITORFREQUENCYRANGESET left, D3DKMDT_HMONITORFREQUENCYRANGESET right) => left.Value != right.Value;

        public static bool operator <(D3DKMDT_HMONITORFREQUENCYRANGESET left, D3DKMDT_HMONITORFREQUENCYRANGESET right) => left.Value < right.Value;

        public static bool operator <=(D3DKMDT_HMONITORFREQUENCYRANGESET left, D3DKMDT_HMONITORFREQUENCYRANGESET right) => left.Value <= right.Value;

        public static bool operator >(D3DKMDT_HMONITORFREQUENCYRANGESET left, D3DKMDT_HMONITORFREQUENCYRANGESET right) => left.Value > right.Value;

        public static bool operator >=(D3DKMDT_HMONITORFREQUENCYRANGESET left, D3DKMDT_HMONITORFREQUENCYRANGESET right) => left.Value >= right.Value;

        public static explicit operator D3DKMDT_HMONITORFREQUENCYRANGESET(void* value) => new D3DKMDT_HMONITORFREQUENCYRANGESET((nint)(value));

        public static implicit operator void*(D3DKMDT_HMONITORFREQUENCYRANGESET value) => (void*)(value.Value);

        public static explicit operator D3DKMDT_HMONITORFREQUENCYRANGESET(HANDLE value) => new D3DKMDT_HMONITORFREQUENCYRANGESET(value);

        public static implicit operator HANDLE(D3DKMDT_HMONITORFREQUENCYRANGESET value) => new HANDLE(value.Value);

        public static explicit operator D3DKMDT_HMONITORFREQUENCYRANGESET(byte value) => new D3DKMDT_HMONITORFREQUENCYRANGESET((nint)(value));

        public static explicit operator byte(D3DKMDT_HMONITORFREQUENCYRANGESET value) => (byte)(value.Value);

        public static explicit operator D3DKMDT_HMONITORFREQUENCYRANGESET(short value) => new D3DKMDT_HMONITORFREQUENCYRANGESET((nint)(value));

        public static explicit operator short(D3DKMDT_HMONITORFREQUENCYRANGESET value) => (short)(value.Value);

        public static explicit operator D3DKMDT_HMONITORFREQUENCYRANGESET(int value) => new D3DKMDT_HMONITORFREQUENCYRANGESET((nint)(value));

        public static explicit operator int(D3DKMDT_HMONITORFREQUENCYRANGESET value) => (int)(value.Value);

        public static explicit operator D3DKMDT_HMONITORFREQUENCYRANGESET(long value) => new D3DKMDT_HMONITORFREQUENCYRANGESET((nint)(value));

        public static implicit operator long(D3DKMDT_HMONITORFREQUENCYRANGESET value) => (long)(value.Value);

        public static explicit operator D3DKMDT_HMONITORFREQUENCYRANGESET(nint value) => new D3DKMDT_HMONITORFREQUENCYRANGESET((nint)(value));

        public static implicit operator nint(D3DKMDT_HMONITORFREQUENCYRANGESET value) => (nint)(value.Value);

        public static explicit operator D3DKMDT_HMONITORFREQUENCYRANGESET(sbyte value) => new D3DKMDT_HMONITORFREQUENCYRANGESET((nint)(value));

        public static explicit operator sbyte(D3DKMDT_HMONITORFREQUENCYRANGESET value) => (sbyte)(value.Value);

        public static explicit operator D3DKMDT_HMONITORFREQUENCYRANGESET(ushort value) => new D3DKMDT_HMONITORFREQUENCYRANGESET((nint)(value));

        public static explicit operator ushort(D3DKMDT_HMONITORFREQUENCYRANGESET value) => (ushort)(value.Value);

        public static explicit operator D3DKMDT_HMONITORFREQUENCYRANGESET(uint value) => new D3DKMDT_HMONITORFREQUENCYRANGESET((nint)(value));

        public static explicit operator uint(D3DKMDT_HMONITORFREQUENCYRANGESET value) => (uint)(value.Value);

        public static explicit operator D3DKMDT_HMONITORFREQUENCYRANGESET(ulong value) => new D3DKMDT_HMONITORFREQUENCYRANGESET((nint)(value));

        public static explicit operator ulong(D3DKMDT_HMONITORFREQUENCYRANGESET value) => (ulong)(value.Value);

        public static explicit operator D3DKMDT_HMONITORFREQUENCYRANGESET(nuint value) => new D3DKMDT_HMONITORFREQUENCYRANGESET((nint)(value));

        public static explicit operator nuint(D3DKMDT_HMONITORFREQUENCYRANGESET value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is D3DKMDT_HMONITORFREQUENCYRANGESET other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of D3DKMDT_HMONITORFREQUENCYRANGESET.");
        }

        public int CompareTo(D3DKMDT_HMONITORFREQUENCYRANGESET other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is D3DKMDT_HMONITORFREQUENCYRANGESET other) && Equals(other);

        public bool Equals(D3DKMDT_HMONITORFREQUENCYRANGESET other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
