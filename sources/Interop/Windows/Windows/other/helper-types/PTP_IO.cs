// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows;

public readonly unsafe partial struct PTP_IO : IComparable, IComparable<PTP_IO>, IEquatable<PTP_IO>, IFormattable
{
    public readonly void* Value;

    public PTP_IO(void* value)
    {
        Value = value;
    }

    public static PTP_IO NULL => new PTP_IO(null);

    public static bool operator ==(PTP_IO left, PTP_IO right) => left.Value == right.Value;

    public static bool operator !=(PTP_IO left, PTP_IO right) => left.Value != right.Value;

    public static bool operator <(PTP_IO left, PTP_IO right) => left.Value < right.Value;

    public static bool operator <=(PTP_IO left, PTP_IO right) => left.Value <= right.Value;

    public static bool operator >(PTP_IO left, PTP_IO right) => left.Value > right.Value;

    public static bool operator >=(PTP_IO left, PTP_IO right) => left.Value >= right.Value;

    public static explicit operator PTP_IO(void* value) => new PTP_IO(value);

    public static implicit operator void*(PTP_IO value) => value.Value;

    public static explicit operator PTP_IO(byte value) => new PTP_IO(unchecked((void*)(value)));

    public static explicit operator byte(PTP_IO value) => (byte)(value.Value);

    public static explicit operator PTP_IO(short value) => new PTP_IO(unchecked((void*)(value)));

    public static explicit operator short(PTP_IO value) => (short)(value.Value);

    public static explicit operator PTP_IO(int value) => new PTP_IO(unchecked((void*)(value)));

    public static explicit operator int(PTP_IO value) => (int)(value.Value);

    public static explicit operator PTP_IO(long value) => new PTP_IO(unchecked((void*)(value)));

    public static explicit operator long(PTP_IO value) => (long)(value.Value);

    public static explicit operator PTP_IO(nint value) => new PTP_IO(unchecked((void*)(value)));

    public static implicit operator nint(PTP_IO value) => (nint)(value.Value);

    public static explicit operator PTP_IO(sbyte value) => new PTP_IO(unchecked((void*)(value)));

    public static explicit operator sbyte(PTP_IO value) => (sbyte)(value.Value);

    public static explicit operator PTP_IO(ushort value) => new PTP_IO(unchecked((void*)(value)));

    public static explicit operator ushort(PTP_IO value) => (ushort)(value.Value);

    public static explicit operator PTP_IO(uint value) => new PTP_IO(unchecked((void*)(value)));

    public static explicit operator uint(PTP_IO value) => (uint)(value.Value);

    public static explicit operator PTP_IO(ulong value) => new PTP_IO(unchecked((void*)(value)));

    public static explicit operator ulong(PTP_IO value) => (ulong)(value.Value);

    public static explicit operator PTP_IO(nuint value) => new PTP_IO(unchecked((void*)(value)));

    public static implicit operator nuint(PTP_IO value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is PTP_IO other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of PTP_IO.");
    }

    public int CompareTo(PTP_IO other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is PTP_IO other) && Equals(other);

    public bool Equals(PTP_IO other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
