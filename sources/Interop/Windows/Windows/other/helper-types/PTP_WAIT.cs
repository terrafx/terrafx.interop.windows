// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows;

public readonly unsafe partial struct PTP_WAIT : IComparable, IComparable<PTP_WAIT>, IEquatable<PTP_WAIT>, IFormattable
{
    public readonly void* Value;

    public PTP_WAIT(void* value)
    {
        Value = value;
    }

    public static PTP_WAIT NULL => new PTP_WAIT(null);

    public static bool operator ==(PTP_WAIT left, PTP_WAIT right) => left.Value == right.Value;

    public static bool operator !=(PTP_WAIT left, PTP_WAIT right) => left.Value != right.Value;

    public static bool operator <(PTP_WAIT left, PTP_WAIT right) => left.Value < right.Value;

    public static bool operator <=(PTP_WAIT left, PTP_WAIT right) => left.Value <= right.Value;

    public static bool operator >(PTP_WAIT left, PTP_WAIT right) => left.Value > right.Value;

    public static bool operator >=(PTP_WAIT left, PTP_WAIT right) => left.Value >= right.Value;

    public static explicit operator PTP_WAIT(void* value) => new PTP_WAIT(value);

    public static implicit operator void*(PTP_WAIT value) => value.Value;

    public static explicit operator PTP_WAIT(byte value) => new PTP_WAIT(unchecked((void*)(value)));

    public static explicit operator byte(PTP_WAIT value) => (byte)(value.Value);

    public static explicit operator PTP_WAIT(short value) => new PTP_WAIT(unchecked((void*)(value)));

    public static explicit operator short(PTP_WAIT value) => (short)(value.Value);

    public static explicit operator PTP_WAIT(int value) => new PTP_WAIT(unchecked((void*)(value)));

    public static explicit operator int(PTP_WAIT value) => (int)(value.Value);

    public static explicit operator PTP_WAIT(long value) => new PTP_WAIT(unchecked((void*)(value)));

    public static explicit operator long(PTP_WAIT value) => (long)(value.Value);

    public static explicit operator PTP_WAIT(nint value) => new PTP_WAIT(unchecked((void*)(value)));

    public static implicit operator nint(PTP_WAIT value) => (nint)(value.Value);

    public static explicit operator PTP_WAIT(sbyte value) => new PTP_WAIT(unchecked((void*)(value)));

    public static explicit operator sbyte(PTP_WAIT value) => (sbyte)(value.Value);

    public static explicit operator PTP_WAIT(ushort value) => new PTP_WAIT(unchecked((void*)(value)));

    public static explicit operator ushort(PTP_WAIT value) => (ushort)(value.Value);

    public static explicit operator PTP_WAIT(uint value) => new PTP_WAIT(unchecked((void*)(value)));

    public static explicit operator uint(PTP_WAIT value) => (uint)(value.Value);

    public static explicit operator PTP_WAIT(ulong value) => new PTP_WAIT(unchecked((void*)(value)));

    public static explicit operator ulong(PTP_WAIT value) => (ulong)(value.Value);

    public static explicit operator PTP_WAIT(nuint value) => new PTP_WAIT(unchecked((void*)(value)));

    public static implicit operator nuint(PTP_WAIT value) => (nuint)(value.Value);

    public int CompareTo(object? obj)
    {
        if (obj is PTP_WAIT other)
        {
            return CompareTo(other);
        }

        return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of PTP_WAIT.");
    }

    public int CompareTo(PTP_WAIT other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

    public override bool Equals(object? obj) => (obj is PTP_WAIT other) && Equals(other);

    public bool Equals(PTP_WAIT other) => ((nuint)(Value)).Equals((nuint)(other.Value));

    public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

    public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

    public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
}
