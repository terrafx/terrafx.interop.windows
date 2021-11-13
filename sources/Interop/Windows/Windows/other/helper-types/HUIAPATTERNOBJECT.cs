// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct HUIAPATTERNOBJECT : IComparable, IComparable<HUIAPATTERNOBJECT>, IEquatable<HUIAPATTERNOBJECT>, IFormattable
    {
        public readonly void* Value;

        public HUIAPATTERNOBJECT(void* value)
        {
            Value = value;
        }

        public static HUIAPATTERNOBJECT INVALID_VALUE => new HUIAPATTERNOBJECT((void*)(-1));

        public static HUIAPATTERNOBJECT NULL => new HUIAPATTERNOBJECT(null);

        public static bool operator ==(HUIAPATTERNOBJECT left, HUIAPATTERNOBJECT right) => left.Value == right.Value;

        public static bool operator !=(HUIAPATTERNOBJECT left, HUIAPATTERNOBJECT right) => left.Value != right.Value;

        public static bool operator <(HUIAPATTERNOBJECT left, HUIAPATTERNOBJECT right) => left.Value < right.Value;

        public static bool operator <=(HUIAPATTERNOBJECT left, HUIAPATTERNOBJECT right) => left.Value <= right.Value;

        public static bool operator >(HUIAPATTERNOBJECT left, HUIAPATTERNOBJECT right) => left.Value > right.Value;

        public static bool operator >=(HUIAPATTERNOBJECT left, HUIAPATTERNOBJECT right) => left.Value >= right.Value;

        public static explicit operator HUIAPATTERNOBJECT(void* value) => new HUIAPATTERNOBJECT(value);

        public static implicit operator void*(HUIAPATTERNOBJECT value) => value.Value;

        public static explicit operator HUIAPATTERNOBJECT(HANDLE value) => new HUIAPATTERNOBJECT(value);

        public static implicit operator HANDLE(HUIAPATTERNOBJECT value) => new HANDLE(value.Value);

        public static explicit operator HUIAPATTERNOBJECT(byte value) => new HUIAPATTERNOBJECT((void*)(value));

        public static explicit operator byte(HUIAPATTERNOBJECT value) => (byte)(value.Value);

        public static explicit operator HUIAPATTERNOBJECT(short value) => new HUIAPATTERNOBJECT((void*)(value));

        public static explicit operator short(HUIAPATTERNOBJECT value) => (short)(value.Value);

        public static explicit operator HUIAPATTERNOBJECT(int value) => new HUIAPATTERNOBJECT((void*)(value));

        public static explicit operator int(HUIAPATTERNOBJECT value) => (int)(value.Value);

        public static explicit operator HUIAPATTERNOBJECT(long value) => new HUIAPATTERNOBJECT((void*)(value));

        public static explicit operator long(HUIAPATTERNOBJECT value) => (long)(value.Value);

        public static explicit operator HUIAPATTERNOBJECT(nint value) => new HUIAPATTERNOBJECT((void*)(value));

        public static implicit operator nint(HUIAPATTERNOBJECT value) => (nint)(value.Value);

        public static explicit operator HUIAPATTERNOBJECT(sbyte value) => new HUIAPATTERNOBJECT((void*)(value));

        public static explicit operator sbyte(HUIAPATTERNOBJECT value) => (sbyte)(value.Value);

        public static explicit operator HUIAPATTERNOBJECT(ushort value) => new HUIAPATTERNOBJECT((void*)(value));

        public static explicit operator ushort(HUIAPATTERNOBJECT value) => (ushort)(value.Value);

        public static explicit operator HUIAPATTERNOBJECT(uint value) => new HUIAPATTERNOBJECT((void*)(value));

        public static explicit operator uint(HUIAPATTERNOBJECT value) => (uint)(value.Value);

        public static explicit operator HUIAPATTERNOBJECT(ulong value) => new HUIAPATTERNOBJECT((void*)(value));

        public static explicit operator ulong(HUIAPATTERNOBJECT value) => (ulong)(value.Value);

        public static explicit operator HUIAPATTERNOBJECT(nuint value) => new HUIAPATTERNOBJECT((void*)(value));

        public static implicit operator nuint(HUIAPATTERNOBJECT value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HUIAPATTERNOBJECT other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HUIAPATTERNOBJECT.");
        }

        public int CompareTo(HUIAPATTERNOBJECT other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HUIAPATTERNOBJECT other) && Equals(other);

        public bool Equals(HUIAPATTERNOBJECT other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
