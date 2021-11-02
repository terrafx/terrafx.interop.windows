// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct D3DKMDT_HMONITORDESCRIPTORSET : IComparable, IComparable<D3DKMDT_HMONITORDESCRIPTORSET>, IEquatable<D3DKMDT_HMONITORDESCRIPTORSET>, IFormattable
    {
        public readonly nint Value;

        public D3DKMDT_HMONITORDESCRIPTORSET(nint value)
        {
            Value = value;
        }

        public static D3DKMDT_HMONITORDESCRIPTORSET INVALID_VALUE => new D3DKMDT_HMONITORDESCRIPTORSET(-1);

        public static D3DKMDT_HMONITORDESCRIPTORSET NULL => new D3DKMDT_HMONITORDESCRIPTORSET(0);

        public static bool operator ==(D3DKMDT_HMONITORDESCRIPTORSET left, D3DKMDT_HMONITORDESCRIPTORSET right) => left.Value == right.Value;

        public static bool operator !=(D3DKMDT_HMONITORDESCRIPTORSET left, D3DKMDT_HMONITORDESCRIPTORSET right) => left.Value != right.Value;

        public static bool operator <(D3DKMDT_HMONITORDESCRIPTORSET left, D3DKMDT_HMONITORDESCRIPTORSET right) => left.Value < right.Value;

        public static bool operator <=(D3DKMDT_HMONITORDESCRIPTORSET left, D3DKMDT_HMONITORDESCRIPTORSET right) => left.Value <= right.Value;

        public static bool operator >(D3DKMDT_HMONITORDESCRIPTORSET left, D3DKMDT_HMONITORDESCRIPTORSET right) => left.Value > right.Value;

        public static bool operator >=(D3DKMDT_HMONITORDESCRIPTORSET left, D3DKMDT_HMONITORDESCRIPTORSET right) => left.Value >= right.Value;

        public static explicit operator D3DKMDT_HMONITORDESCRIPTORSET(void* value) => new D3DKMDT_HMONITORDESCRIPTORSET((nint)(value));

        public static implicit operator void*(D3DKMDT_HMONITORDESCRIPTORSET value) => (void*)(value.Value);

        public static explicit operator D3DKMDT_HMONITORDESCRIPTORSET(HANDLE value) => new D3DKMDT_HMONITORDESCRIPTORSET(value);

        public static implicit operator HANDLE(D3DKMDT_HMONITORDESCRIPTORSET value) => new HANDLE(value.Value);

        public static explicit operator D3DKMDT_HMONITORDESCRIPTORSET(byte value) => new D3DKMDT_HMONITORDESCRIPTORSET((nint)(value));

        public static explicit operator byte(D3DKMDT_HMONITORDESCRIPTORSET value) => (byte)(value.Value);

        public static explicit operator D3DKMDT_HMONITORDESCRIPTORSET(short value) => new D3DKMDT_HMONITORDESCRIPTORSET((nint)(value));

        public static explicit operator short(D3DKMDT_HMONITORDESCRIPTORSET value) => (short)(value.Value);

        public static explicit operator D3DKMDT_HMONITORDESCRIPTORSET(int value) => new D3DKMDT_HMONITORDESCRIPTORSET((nint)(value));

        public static explicit operator int(D3DKMDT_HMONITORDESCRIPTORSET value) => (int)(value.Value);

        public static explicit operator D3DKMDT_HMONITORDESCRIPTORSET(long value) => new D3DKMDT_HMONITORDESCRIPTORSET((nint)(value));

        public static implicit operator long(D3DKMDT_HMONITORDESCRIPTORSET value) => value.Value;

        public static explicit operator D3DKMDT_HMONITORDESCRIPTORSET(nint value) => new D3DKMDT_HMONITORDESCRIPTORSET((nint)(value));

        public static implicit operator nint(D3DKMDT_HMONITORDESCRIPTORSET value) => value.Value;

        public static explicit operator D3DKMDT_HMONITORDESCRIPTORSET(sbyte value) => new D3DKMDT_HMONITORDESCRIPTORSET((nint)(value));

        public static explicit operator sbyte(D3DKMDT_HMONITORDESCRIPTORSET value) => (sbyte)(value.Value);

        public static explicit operator D3DKMDT_HMONITORDESCRIPTORSET(ushort value) => new D3DKMDT_HMONITORDESCRIPTORSET((nint)(value));

        public static explicit operator ushort(D3DKMDT_HMONITORDESCRIPTORSET value) => (ushort)(value.Value);

        public static explicit operator D3DKMDT_HMONITORDESCRIPTORSET(uint value) => new D3DKMDT_HMONITORDESCRIPTORSET((nint)(value));

        public static explicit operator uint(D3DKMDT_HMONITORDESCRIPTORSET value) => (uint)(value.Value);

        public static explicit operator D3DKMDT_HMONITORDESCRIPTORSET(ulong value) => new D3DKMDT_HMONITORDESCRIPTORSET((nint)(value));

        public static explicit operator ulong(D3DKMDT_HMONITORDESCRIPTORSET value) => (ulong)(value.Value);

        public static explicit operator D3DKMDT_HMONITORDESCRIPTORSET(nuint value) => new D3DKMDT_HMONITORDESCRIPTORSET((nint)(value));

        public static explicit operator nuint(D3DKMDT_HMONITORDESCRIPTORSET value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is D3DKMDT_HMONITORDESCRIPTORSET other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of D3DKMDT_HMONITORDESCRIPTORSET.");
        }

        public int CompareTo(D3DKMDT_HMONITORDESCRIPTORSET other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is D3DKMDT_HMONITORDESCRIPTORSET other) && Equals(other);

        public bool Equals(D3DKMDT_HMONITORDESCRIPTORSET other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}
