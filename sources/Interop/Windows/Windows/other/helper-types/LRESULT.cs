// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows;

public readonly partial struct LRESULT : IComparable, IComparable<LRESULT>, IEquatable<LRESULT>, IFormattable
{
    public readonly nint Value;

    public LRESULT(nint value)
    {
        Value = value;
    }

    public static bool operator ==(LRESULT left, LRESULT right) => left.Value == right.Value;

    public static bool operator !=(LRESULT left, LRESULT right) => left.Value != right.Value;

    public static bool operator <(LRESULT left, LRESULT right) => left.Value < right.Value;

    public static bool operator <=(LRESULT left, LRESULT right) => left.Value <= right.Value;

    public static bool operator >(LRESULT left, LRESULT right) => left.Value > right.Value;

    public static bool operator >=(LRESULT left, LRESULT right) => left.Value >= right.Value;

    public static implicit operator LRESULT(byte value) => new LRESULT(value);

    public static explicit operator byte(LRESULT value) => unchecked((byte)(value.Value));

    public static implicit operator LRESULT(short value) => new LRESULT(value);

    public static explicit operator short(LRESULT value) => unchecked((short)(value.Value));

    public static implicit operator LRESULT(int value) => new LRESULT(value);

    public static explicit operator int(LRESULT value) => unchecked((int)(value.Value));

    public static explicit operator LRESULT(long value) => new LRESULT(unchecked((nint)(value)));

    public static implicit operator long(LRESULT value) => value.Value;

    public static implicit operator LRESULT(nint value) => new LRESULT(value);

    public static implicit operator nint(LRESULT value) => value.Value;

    public static implicit operator LRESULT(sbyte value) => new LRESULT(value);

    public static explicit operator sbyte(LRESULT value) => unchecked((sbyte)(value.Value));

    public static implicit operator LRESULT(ushort value) => new LRESULT(value);

    public static explicit operator ushort(LRESULT value) => unchecked((ushort)(value.Value));

    public static explicit operator LRESULT(uint value) => new LRESULT(unchecked((nint)(value)));

    public static explicit operator uint(LRESULT value) => unchecked((uint)(value.Value));

    public static explicit operator LRESULT(ulong value) => new LRESULT(unchecked((nint)(value)));

    public static explicit operator ulong(LRESULT value) => unchecked((ulong)(value.Value));

    public static explicit operator LRESULT(nuint value) => new LRESULT(unchecked((nint)(value)));

    public static explicit operator nuint(LRESULT value) => unchecked((nuint)(value.Value));

    public int CompareTo(object? obj)
    {
        if (obj is LRESULT other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of LRESULT.");
    }

    public int CompareTo(LRESULT other) => Value.CompareTo(other.Value);

    public override bool Equals(object? obj) => (obj is LRESULT other) && Equals(other);

    public bool Equals(LRESULT other) => Value.Equals(other.Value);

    public override int GetHashCode() => Value.GetHashCode();

    public override string ToString() => Value.ToString();

    public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
}
