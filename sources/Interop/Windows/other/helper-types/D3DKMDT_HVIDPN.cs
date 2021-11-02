// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct D3DKMDT_HVIDPN : IComparable, IComparable<D3DKMDT_HVIDPN>, IEquatable<D3DKMDT_HVIDPN>, IFormattable
    {
        public readonly nint Value;

        public D3DKMDT_HVIDPN(nint value)
        {
            Value = value;
        }

        public static D3DKMDT_HVIDPN INVALID_VALUE => new D3DKMDT_HVIDPN(-1);

        public static D3DKMDT_HVIDPN NULL => new D3DKMDT_HVIDPN(0);

        public static bool operator ==(D3DKMDT_HVIDPN left, D3DKMDT_HVIDPN right) => left.Value == right.Value;

        public static bool operator !=(D3DKMDT_HVIDPN left, D3DKMDT_HVIDPN right) => left.Value != right.Value;

        public static bool operator <(D3DKMDT_HVIDPN left, D3DKMDT_HVIDPN right) => left.Value < right.Value;

        public static bool operator <=(D3DKMDT_HVIDPN left, D3DKMDT_HVIDPN right) => left.Value <= right.Value;

        public static bool operator >(D3DKMDT_HVIDPN left, D3DKMDT_HVIDPN right) => left.Value > right.Value;

        public static bool operator >=(D3DKMDT_HVIDPN left, D3DKMDT_HVIDPN right) => left.Value >= right.Value;

        public static explicit operator D3DKMDT_HVIDPN(void* value) => new D3DKMDT_HVIDPN((nint)(value));

        public static implicit operator void*(D3DKMDT_HVIDPN value) => (void*)(value.Value);

        public static explicit operator D3DKMDT_HVIDPN(HANDLE value) => new D3DKMDT_HVIDPN(value);

        public static implicit operator HANDLE(D3DKMDT_HVIDPN value) => new HANDLE(value.Value);

        public static explicit operator D3DKMDT_HVIDPN(byte value) => new D3DKMDT_HVIDPN((nint)(value));

        public static explicit operator byte(D3DKMDT_HVIDPN value) => (byte)(value.Value);

        public static explicit operator D3DKMDT_HVIDPN(short value) => new D3DKMDT_HVIDPN((nint)(value));

        public static explicit operator short(D3DKMDT_HVIDPN value) => (short)(value.Value);

        public static explicit operator D3DKMDT_HVIDPN(int value) => new D3DKMDT_HVIDPN((nint)(value));

        public static explicit operator int(D3DKMDT_HVIDPN value) => (int)(value.Value);

        public static explicit operator D3DKMDT_HVIDPN(long value) => new D3DKMDT_HVIDPN((nint)(value));

        public static implicit operator long(D3DKMDT_HVIDPN value) => (long)(value.Value);

        public static explicit operator D3DKMDT_HVIDPN(nint value) => new D3DKMDT_HVIDPN((nint)(value));

        public static implicit operator nint(D3DKMDT_HVIDPN value) => (nint)(value.Value);

        public static explicit operator D3DKMDT_HVIDPN(sbyte value) => new D3DKMDT_HVIDPN((nint)(value));

        public static explicit operator sbyte(D3DKMDT_HVIDPN value) => (sbyte)(value.Value);

        public static explicit operator D3DKMDT_HVIDPN(ushort value) => new D3DKMDT_HVIDPN((nint)(value));

        public static explicit operator ushort(D3DKMDT_HVIDPN value) => (ushort)(value.Value);

        public static explicit operator D3DKMDT_HVIDPN(uint value) => new D3DKMDT_HVIDPN((nint)(value));

        public static explicit operator uint(D3DKMDT_HVIDPN value) => (uint)(value.Value);

        public static explicit operator D3DKMDT_HVIDPN(ulong value) => new D3DKMDT_HVIDPN((nint)(value));

        public static explicit operator ulong(D3DKMDT_HVIDPN value) => (ulong)(value.Value);

        public static explicit operator D3DKMDT_HVIDPN(nuint value) => new D3DKMDT_HVIDPN((nint)(value));

        public static explicit operator nuint(D3DKMDT_HVIDPN value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is D3DKMDT_HVIDPN other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of D3DKMDT_HVIDPN.");
        }

        public int CompareTo(D3DKMDT_HVIDPN other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is D3DKMDT_HVIDPN other) && Equals(other);

        public bool Equals(D3DKMDT_HVIDPN other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
