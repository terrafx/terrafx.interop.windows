// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct HWAVE : IComparable, IComparable<HWAVE>, IEquatable<HWAVE>, IFormattable
    {
        public readonly void* Value;

        public HWAVE(void* value)
        {
            Value = value;
        }

        public static HWAVE INVALID_VALUE => new HWAVE((void*)(-1));

        public static HWAVE NULL => new HWAVE(null);

        public static bool operator ==(HWAVE left, HWAVE right) => left.Value == right.Value;

        public static bool operator !=(HWAVE left, HWAVE right) => left.Value != right.Value;

        public static bool operator <(HWAVE left, HWAVE right) => left.Value < right.Value;

        public static bool operator <=(HWAVE left, HWAVE right) => left.Value <= right.Value;

        public static bool operator >(HWAVE left, HWAVE right) => left.Value > right.Value;

        public static bool operator >=(HWAVE left, HWAVE right) => left.Value >= right.Value;

        public static explicit operator HWAVE(void* value) => new HWAVE(value);

        public static implicit operator void*(HWAVE value) => value.Value;

        public static explicit operator HWAVE(HANDLE value) => new HWAVE(value);

        public static implicit operator HANDLE(HWAVE value) => new HANDLE(value.Value);

        public static explicit operator HWAVE(byte value) => new HWAVE((void*)(value));

        public static explicit operator byte(HWAVE value) => (byte)(value.Value);

        public static explicit operator HWAVE(short value) => new HWAVE((void*)(value));

        public static explicit operator short(HWAVE value) => (short)(value.Value);

        public static explicit operator HWAVE(int value) => new HWAVE((void*)(value));

        public static explicit operator int(HWAVE value) => (int)(value.Value);

        public static explicit operator HWAVE(long value) => new HWAVE((void*)(value));

        public static explicit operator long(HWAVE value) => (long)(value.Value);

        public static explicit operator HWAVE(nint value) => new HWAVE((void*)(value));

        public static implicit operator nint(HWAVE value) => (nint)(value.Value);

        public static explicit operator HWAVE(sbyte value) => new HWAVE((void*)(value));

        public static explicit operator sbyte(HWAVE value) => (sbyte)(value.Value);

        public static explicit operator HWAVE(ushort value) => new HWAVE((void*)(value));

        public static explicit operator ushort(HWAVE value) => (ushort)(value.Value);

        public static explicit operator HWAVE(uint value) => new HWAVE((void*)(value));

        public static explicit operator uint(HWAVE value) => (uint)(value.Value);

        public static explicit operator HWAVE(ulong value) => new HWAVE((void*)(value));

        public static explicit operator ulong(HWAVE value) => (ulong)(value.Value);

        public static explicit operator HWAVE(nuint value) => new HWAVE((void*)(value));

        public static implicit operator nuint(HWAVE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HWAVE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HWAVE.");
        }

        public int CompareTo(HWAVE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HWAVE other) && Equals(other);

        public bool Equals(HWAVE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
