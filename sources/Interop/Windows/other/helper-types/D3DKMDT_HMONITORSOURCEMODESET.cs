// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct D3DKMDT_HMONITORSOURCEMODESET : IComparable, IComparable<D3DKMDT_HMONITORSOURCEMODESET>, IEquatable<D3DKMDT_HMONITORSOURCEMODESET>, IFormattable
    {
        public readonly nint Value;

        public D3DKMDT_HMONITORSOURCEMODESET(nint value)
        {
            Value = value;
        }

        public static D3DKMDT_HMONITORSOURCEMODESET INVALID_VALUE => new D3DKMDT_HMONITORSOURCEMODESET(-1);

        public static D3DKMDT_HMONITORSOURCEMODESET NULL => new D3DKMDT_HMONITORSOURCEMODESET(0);

        public static bool operator ==(D3DKMDT_HMONITORSOURCEMODESET left, D3DKMDT_HMONITORSOURCEMODESET right) => left.Value == right.Value;

        public static bool operator !=(D3DKMDT_HMONITORSOURCEMODESET left, D3DKMDT_HMONITORSOURCEMODESET right) => left.Value != right.Value;

        public static bool operator <(D3DKMDT_HMONITORSOURCEMODESET left, D3DKMDT_HMONITORSOURCEMODESET right) => left.Value < right.Value;

        public static bool operator <=(D3DKMDT_HMONITORSOURCEMODESET left, D3DKMDT_HMONITORSOURCEMODESET right) => left.Value <= right.Value;

        public static bool operator >(D3DKMDT_HMONITORSOURCEMODESET left, D3DKMDT_HMONITORSOURCEMODESET right) => left.Value > right.Value;

        public static bool operator >=(D3DKMDT_HMONITORSOURCEMODESET left, D3DKMDT_HMONITORSOURCEMODESET right) => left.Value >= right.Value;

        public static explicit operator D3DKMDT_HMONITORSOURCEMODESET(void* value) => new D3DKMDT_HMONITORSOURCEMODESET((nint)(value));

        public static implicit operator void*(D3DKMDT_HMONITORSOURCEMODESET value) => (void*)(value.Value);

        public static explicit operator D3DKMDT_HMONITORSOURCEMODESET(HANDLE value) => new D3DKMDT_HMONITORSOURCEMODESET(value);

        public static implicit operator HANDLE(D3DKMDT_HMONITORSOURCEMODESET value) => new HANDLE(value.Value);

        public static explicit operator D3DKMDT_HMONITORSOURCEMODESET(byte value) => new D3DKMDT_HMONITORSOURCEMODESET((nint)(value));

        public static explicit operator byte(D3DKMDT_HMONITORSOURCEMODESET value) => (byte)(value.Value);

        public static explicit operator D3DKMDT_HMONITORSOURCEMODESET(short value) => new D3DKMDT_HMONITORSOURCEMODESET((nint)(value));

        public static explicit operator short(D3DKMDT_HMONITORSOURCEMODESET value) => (short)(value.Value);

        public static explicit operator D3DKMDT_HMONITORSOURCEMODESET(int value) => new D3DKMDT_HMONITORSOURCEMODESET((nint)(value));

        public static explicit operator int(D3DKMDT_HMONITORSOURCEMODESET value) => (int)(value.Value);

        public static explicit operator D3DKMDT_HMONITORSOURCEMODESET(long value) => new D3DKMDT_HMONITORSOURCEMODESET((nint)(value));

        public static implicit operator long(D3DKMDT_HMONITORSOURCEMODESET value) => (long)(value.Value);

        public static explicit operator D3DKMDT_HMONITORSOURCEMODESET(nint value) => new D3DKMDT_HMONITORSOURCEMODESET((nint)(value));

        public static implicit operator nint(D3DKMDT_HMONITORSOURCEMODESET value) => (nint)(value.Value);

        public static explicit operator D3DKMDT_HMONITORSOURCEMODESET(sbyte value) => new D3DKMDT_HMONITORSOURCEMODESET((nint)(value));

        public static explicit operator sbyte(D3DKMDT_HMONITORSOURCEMODESET value) => (sbyte)(value.Value);

        public static explicit operator D3DKMDT_HMONITORSOURCEMODESET(ushort value) => new D3DKMDT_HMONITORSOURCEMODESET((nint)(value));

        public static explicit operator ushort(D3DKMDT_HMONITORSOURCEMODESET value) => (ushort)(value.Value);

        public static explicit operator D3DKMDT_HMONITORSOURCEMODESET(uint value) => new D3DKMDT_HMONITORSOURCEMODESET((nint)(value));

        public static explicit operator uint(D3DKMDT_HMONITORSOURCEMODESET value) => (uint)(value.Value);

        public static explicit operator D3DKMDT_HMONITORSOURCEMODESET(ulong value) => new D3DKMDT_HMONITORSOURCEMODESET((nint)(value));

        public static explicit operator ulong(D3DKMDT_HMONITORSOURCEMODESET value) => (ulong)(value.Value);

        public static explicit operator D3DKMDT_HMONITORSOURCEMODESET(nuint value) => new D3DKMDT_HMONITORSOURCEMODESET((nint)(value));

        public static explicit operator nuint(D3DKMDT_HMONITORSOURCEMODESET value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is D3DKMDT_HMONITORSOURCEMODESET other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of D3DKMDT_HMONITORSOURCEMODESET.");
        }

        public int CompareTo(D3DKMDT_HMONITORSOURCEMODESET other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is D3DKMDT_HMONITORSOURCEMODESET other) && Equals(other);

        public bool Equals(D3DKMDT_HMONITORSOURCEMODESET other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
