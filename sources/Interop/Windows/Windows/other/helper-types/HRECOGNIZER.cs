// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct HRECOGNIZER : IComparable, IComparable<HRECOGNIZER>, IEquatable<HRECOGNIZER>, IFormattable
    {
        public readonly void* Value;

        public HRECOGNIZER(void* value)
        {
            Value = value;
        }

        public static HRECOGNIZER INVALID_VALUE => new HRECOGNIZER((void*)(-1));

        public static HRECOGNIZER NULL => new HRECOGNIZER(null);

        public static bool operator ==(HRECOGNIZER left, HRECOGNIZER right) => left.Value == right.Value;

        public static bool operator !=(HRECOGNIZER left, HRECOGNIZER right) => left.Value != right.Value;

        public static bool operator <(HRECOGNIZER left, HRECOGNIZER right) => left.Value < right.Value;

        public static bool operator <=(HRECOGNIZER left, HRECOGNIZER right) => left.Value <= right.Value;

        public static bool operator >(HRECOGNIZER left, HRECOGNIZER right) => left.Value > right.Value;

        public static bool operator >=(HRECOGNIZER left, HRECOGNIZER right) => left.Value >= right.Value;

        public static explicit operator HRECOGNIZER(void* value) => new HRECOGNIZER(value);

        public static implicit operator void*(HRECOGNIZER value) => value.Value;

        public static explicit operator HRECOGNIZER(HANDLE value) => new HRECOGNIZER(value);

        public static implicit operator HANDLE(HRECOGNIZER value) => new HANDLE(value.Value);

        public static explicit operator HRECOGNIZER(byte value) => new HRECOGNIZER((void*)(value));

        public static explicit operator byte(HRECOGNIZER value) => (byte)(value.Value);

        public static explicit operator HRECOGNIZER(short value) => new HRECOGNIZER((void*)(value));

        public static explicit operator short(HRECOGNIZER value) => (short)(value.Value);

        public static explicit operator HRECOGNIZER(int value) => new HRECOGNIZER((void*)(value));

        public static explicit operator int(HRECOGNIZER value) => (int)(value.Value);

        public static explicit operator HRECOGNIZER(long value) => new HRECOGNIZER((void*)(value));

        public static explicit operator long(HRECOGNIZER value) => (long)(value.Value);

        public static explicit operator HRECOGNIZER(nint value) => new HRECOGNIZER((void*)(value));

        public static implicit operator nint(HRECOGNIZER value) => (nint)(value.Value);

        public static explicit operator HRECOGNIZER(sbyte value) => new HRECOGNIZER((void*)(value));

        public static explicit operator sbyte(HRECOGNIZER value) => (sbyte)(value.Value);

        public static explicit operator HRECOGNIZER(ushort value) => new HRECOGNIZER((void*)(value));

        public static explicit operator ushort(HRECOGNIZER value) => (ushort)(value.Value);

        public static explicit operator HRECOGNIZER(uint value) => new HRECOGNIZER((void*)(value));

        public static explicit operator uint(HRECOGNIZER value) => (uint)(value.Value);

        public static explicit operator HRECOGNIZER(ulong value) => new HRECOGNIZER((void*)(value));

        public static explicit operator ulong(HRECOGNIZER value) => (ulong)(value.Value);

        public static explicit operator HRECOGNIZER(nuint value) => new HRECOGNIZER((void*)(value));

        public static implicit operator nuint(HRECOGNIZER value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HRECOGNIZER other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HRECOGNIZER.");
        }

        public int CompareTo(HRECOGNIZER other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HRECOGNIZER other) && Equals(other);

        public bool Equals(HRECOGNIZER other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
