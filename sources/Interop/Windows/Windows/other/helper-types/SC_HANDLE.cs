// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct SC_HANDLE : IComparable, IComparable<SC_HANDLE>, IEquatable<SC_HANDLE>, IFormattable
    {
        public readonly void* Value;

        public SC_HANDLE(void* value)
        {
            Value = value;
        }

        public static SC_HANDLE INVALID_VALUE => new SC_HANDLE((void*)(-1));

        public static SC_HANDLE NULL => new SC_HANDLE(null);

        public static bool operator ==(SC_HANDLE left, SC_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(SC_HANDLE left, SC_HANDLE right) => left.Value != right.Value;

        public static bool operator <(SC_HANDLE left, SC_HANDLE right) => left.Value < right.Value;

        public static bool operator <=(SC_HANDLE left, SC_HANDLE right) => left.Value <= right.Value;

        public static bool operator >(SC_HANDLE left, SC_HANDLE right) => left.Value > right.Value;

        public static bool operator >=(SC_HANDLE left, SC_HANDLE right) => left.Value >= right.Value;

        public static explicit operator SC_HANDLE(void* value) => new SC_HANDLE(value);

        public static implicit operator void*(SC_HANDLE value) => value.Value;

        public static explicit operator SC_HANDLE(HANDLE value) => new SC_HANDLE(value);

        public static implicit operator HANDLE(SC_HANDLE value) => new HANDLE(value.Value);

        public static explicit operator SC_HANDLE(byte value) => new SC_HANDLE((void*)(value));

        public static explicit operator byte(SC_HANDLE value) => (byte)(value.Value);

        public static explicit operator SC_HANDLE(short value) => new SC_HANDLE((void*)(value));

        public static explicit operator short(SC_HANDLE value) => (short)(value.Value);

        public static explicit operator SC_HANDLE(int value) => new SC_HANDLE((void*)(value));

        public static explicit operator int(SC_HANDLE value) => (int)(value.Value);

        public static explicit operator SC_HANDLE(long value) => new SC_HANDLE((void*)(value));

        public static explicit operator long(SC_HANDLE value) => (long)(value.Value);

        public static explicit operator SC_HANDLE(nint value) => new SC_HANDLE((void*)(value));

        public static implicit operator nint(SC_HANDLE value) => (nint)(value.Value);

        public static explicit operator SC_HANDLE(sbyte value) => new SC_HANDLE((void*)(value));

        public static explicit operator sbyte(SC_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator SC_HANDLE(ushort value) => new SC_HANDLE((void*)(value));

        public static explicit operator ushort(SC_HANDLE value) => (ushort)(value.Value);

        public static explicit operator SC_HANDLE(uint value) => new SC_HANDLE((void*)(value));

        public static explicit operator uint(SC_HANDLE value) => (uint)(value.Value);

        public static explicit operator SC_HANDLE(ulong value) => new SC_HANDLE((void*)(value));

        public static explicit operator ulong(SC_HANDLE value) => (ulong)(value.Value);

        public static explicit operator SC_HANDLE(nuint value) => new SC_HANDLE((void*)(value));

        public static implicit operator nuint(SC_HANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is SC_HANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SC_HANDLE.");
        }

        public int CompareTo(SC_HANDLE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is SC_HANDLE other) && Equals(other);

        public bool Equals(SC_HANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
