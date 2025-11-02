// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows;

public readonly unsafe partial struct PTP_TIMER : IComparable, IComparable<PTP_TIMER>, IEquatable<PTP_TIMER>, IFormattable
{
    public readonly void* Value;

    public PTP_TIMER(void* value)
    {
        Value = value;
    }

    public static PTP_TIMER NULL => new PTP_TIMER(null);

    public static bool operator ==(PTP_TIMER left, PTP_TIMER right) => left.Value == right.Value;

    public static bool operator !=(PTP_TIMER left, PTP_TIMER right) => left.Value != right.Value;

    public static bool operator <(PTP_TIMER left, PTP_TIMER right) => left.Value < right.Value;

    public static bool operator <=(PTP_TIMER left, PTP_TIMER right) => left.Value <= right.Value;

    public static bool operator >(PTP_TIMER left, PTP_TIMER right) => left.Value > right.Value;

    public static bool operator >=(PTP_TIMER left, PTP_TIMER right) => left.Value >= right.Value;

    public static explicit operator PTP_TIMER(void* value) => new PTP_TIMER(value);

    public static implicit operator void*(PTP_TIMER value) => value.Value;

    public static explicit operator PTP_TIMER(byte value) => new PTP_TIMER(unchecked((void*)(value)));

    public static explicit operator byte(PTP_TIMER value) => (byte)(value.Value);

    public static explicit operator PTP_TIMER(short value) => new PTP_TIMER(unchecked((void*)(value)));

    public static explicit operator short(PTP_TIMER value) => (short)(value.Value);

    public static explicit operator PTP_TIMER(int value) => new PTP_TIMER(unchecked((void*)(value)));

    public static explicit operator int(PTP_TIMER value) => (int)(value.Value);

    public static explicit operator PTP_TIMER(long value) => new PTP_TIMER(unchecked((void*)(value)));

    public static explicit operator long(PTP_TIMER value) => (long)(value.Value);

    public static explicit operator PTP_TIMER(nint value) => new PTP_TIMER(unchecked((void*)(value)));

    public static implicit operator nint(PTP_TIMER value) => (nint)(value.Value);

    public static explicit operator PTP_TIMER(sbyte value) => new PTP_TIMER(unchecked((void*)(value)));

    public static explicit operator sbyte(PTP_TIMER value) => (sbyte)(value.Value);

    public static explicit operator PTP_TIMER(ushort value) => new PTP_TIMER(unchecked((void*)(value)));

    public static explicit operator ushort(PTP_TIMER value) => (ushort)(value.Value);

    public static explicit operator PTP_TIMER(uint value) => new PTP_TIMER(unchecked((void*)(value)));

    public static explicit operator uint(PTP_TIMER value) => (uint)(value.Value);

    public static explicit operator PTP_TIMER(ulong value) => new PTP_TIMER(unchecked((void*)(value)));

    public static explicit operator ulong(PTP_TIMER value) => (ulong)(value.Value);

    public static explicit operator PTP_TIMER(nuint value) => new PTP_TIMER(unchecked((void*)(value)));

    public static implicit operator nuint(PTP_TIMER value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is PTP_TIMER other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of PTP_TIMER.");
    }

    public int CompareTo(PTP_TIMER other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is PTP_TIMER other) && Equals(other);

    public bool Equals(PTP_TIMER other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
