// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows;

public readonly unsafe partial struct PTP_WORK : IComparable, IComparable<PTP_WORK>, IEquatable<PTP_WORK>, IFormattable
{
    public readonly void* Value;

    public PTP_WORK(void* value)
    {
        Value = value;
    }

    public static PTP_WORK NULL => new PTP_WORK(null);

    public static bool operator ==(PTP_WORK left, PTP_WORK right) => left.Value == right.Value;

    public static bool operator !=(PTP_WORK left, PTP_WORK right) => left.Value != right.Value;

    public static bool operator <(PTP_WORK left, PTP_WORK right) => left.Value < right.Value;

    public static bool operator <=(PTP_WORK left, PTP_WORK right) => left.Value <= right.Value;

    public static bool operator >(PTP_WORK left, PTP_WORK right) => left.Value > right.Value;

    public static bool operator >=(PTP_WORK left, PTP_WORK right) => left.Value >= right.Value;

    public static explicit operator PTP_WORK(void* value) => new PTP_WORK(value);

    public static implicit operator void*(PTP_WORK value) => value.Value;

    public static explicit operator PTP_WORK(byte value) => new PTP_WORK(unchecked((void*)(value)));

    public static explicit operator byte(PTP_WORK value) => (byte)(value.Value);

    public static explicit operator PTP_WORK(short value) => new PTP_WORK(unchecked((void*)(value)));

    public static explicit operator short(PTP_WORK value) => (short)(value.Value);

    public static explicit operator PTP_WORK(int value) => new PTP_WORK(unchecked((void*)(value)));

    public static explicit operator int(PTP_WORK value) => (int)(value.Value);

    public static explicit operator PTP_WORK(long value) => new PTP_WORK(unchecked((void*)(value)));

    public static explicit operator long(PTP_WORK value) => (long)(value.Value);

    public static explicit operator PTP_WORK(nint value) => new PTP_WORK(unchecked((void*)(value)));

    public static implicit operator nint(PTP_WORK value) => (nint)(value.Value);

    public static explicit operator PTP_WORK(sbyte value) => new PTP_WORK(unchecked((void*)(value)));

    public static explicit operator sbyte(PTP_WORK value) => (sbyte)(value.Value);

    public static explicit operator PTP_WORK(ushort value) => new PTP_WORK(unchecked((void*)(value)));

    public static explicit operator ushort(PTP_WORK value) => (ushort)(value.Value);

    public static explicit operator PTP_WORK(uint value) => new PTP_WORK(unchecked((void*)(value)));

    public static explicit operator uint(PTP_WORK value) => (uint)(value.Value);

    public static explicit operator PTP_WORK(ulong value) => new PTP_WORK(unchecked((void*)(value)));

    public static explicit operator ulong(PTP_WORK value) => (ulong)(value.Value);

    public static explicit operator PTP_WORK(nuint value) => new PTP_WORK(unchecked((void*)(value)));

    public static implicit operator nuint(PTP_WORK value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is PTP_WORK other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of PTP_WORK.");
    }

    public int CompareTo(PTP_WORK other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is PTP_WORK other) && Equals(other);

    public bool Equals(PTP_WORK other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
