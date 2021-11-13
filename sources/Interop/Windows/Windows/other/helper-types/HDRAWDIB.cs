// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct HDRAWDIB : IComparable, IComparable<HDRAWDIB>, IEquatable<HDRAWDIB>, IFormattable
    {
        public readonly void* Value;

        public HDRAWDIB(void* value)
        {
            Value = value;
        }

        public static HDRAWDIB INVALID_VALUE => new HDRAWDIB((void*)(-1));

        public static HDRAWDIB NULL => new HDRAWDIB(null);

        public static bool operator ==(HDRAWDIB left, HDRAWDIB right) => left.Value == right.Value;

        public static bool operator !=(HDRAWDIB left, HDRAWDIB right) => left.Value != right.Value;

        public static bool operator <(HDRAWDIB left, HDRAWDIB right) => left.Value < right.Value;

        public static bool operator <=(HDRAWDIB left, HDRAWDIB right) => left.Value <= right.Value;

        public static bool operator >(HDRAWDIB left, HDRAWDIB right) => left.Value > right.Value;

        public static bool operator >=(HDRAWDIB left, HDRAWDIB right) => left.Value >= right.Value;

        public static explicit operator HDRAWDIB(void* value) => new HDRAWDIB(value);

        public static implicit operator void*(HDRAWDIB value) => value.Value;

        public static explicit operator HDRAWDIB(HANDLE value) => new HDRAWDIB(value);

        public static implicit operator HANDLE(HDRAWDIB value) => new HANDLE(value.Value);

        public static explicit operator HDRAWDIB(byte value) => new HDRAWDIB((void*)(value));

        public static explicit operator byte(HDRAWDIB value) => (byte)(value.Value);

        public static explicit operator HDRAWDIB(short value) => new HDRAWDIB((void*)(value));

        public static explicit operator short(HDRAWDIB value) => (short)(value.Value);

        public static explicit operator HDRAWDIB(int value) => new HDRAWDIB((void*)(value));

        public static explicit operator int(HDRAWDIB value) => (int)(value.Value);

        public static explicit operator HDRAWDIB(long value) => new HDRAWDIB((void*)(value));

        public static explicit operator long(HDRAWDIB value) => (long)(value.Value);

        public static explicit operator HDRAWDIB(nint value) => new HDRAWDIB((void*)(value));

        public static implicit operator nint(HDRAWDIB value) => (nint)(value.Value);

        public static explicit operator HDRAWDIB(sbyte value) => new HDRAWDIB((void*)(value));

        public static explicit operator sbyte(HDRAWDIB value) => (sbyte)(value.Value);

        public static explicit operator HDRAWDIB(ushort value) => new HDRAWDIB((void*)(value));

        public static explicit operator ushort(HDRAWDIB value) => (ushort)(value.Value);

        public static explicit operator HDRAWDIB(uint value) => new HDRAWDIB((void*)(value));

        public static explicit operator uint(HDRAWDIB value) => (uint)(value.Value);

        public static explicit operator HDRAWDIB(ulong value) => new HDRAWDIB((void*)(value));

        public static explicit operator ulong(HDRAWDIB value) => (ulong)(value.Value);

        public static explicit operator HDRAWDIB(nuint value) => new HDRAWDIB((void*)(value));

        public static implicit operator nuint(HDRAWDIB value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HDRAWDIB other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HDRAWDIB.");
        }

        public int CompareTo(HDRAWDIB other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HDRAWDIB other) && Equals(other);

        public bool Equals(HDRAWDIB other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
