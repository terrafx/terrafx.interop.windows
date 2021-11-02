// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HAMSICONTEXT : IComparable, IComparable<HAMSICONTEXT>, IEquatable<HAMSICONTEXT>, IFormattable
    {
        public readonly nint Value;

        public HAMSICONTEXT(nint value)
        {
            Value = value;
        }

        public static HAMSICONTEXT INVALID_VALUE => new HAMSICONTEXT(-1);

        public static HAMSICONTEXT NULL => new HAMSICONTEXT(0);

        public static bool operator ==(HAMSICONTEXT left, HAMSICONTEXT right) => left.Value == right.Value;

        public static bool operator !=(HAMSICONTEXT left, HAMSICONTEXT right) => left.Value != right.Value;

        public static bool operator <(HAMSICONTEXT left, HAMSICONTEXT right) => left.Value < right.Value;

        public static bool operator <=(HAMSICONTEXT left, HAMSICONTEXT right) => left.Value <= right.Value;

        public static bool operator >(HAMSICONTEXT left, HAMSICONTEXT right) => left.Value > right.Value;

        public static bool operator >=(HAMSICONTEXT left, HAMSICONTEXT right) => left.Value >= right.Value;

        public static explicit operator HAMSICONTEXT(void* value) => new HAMSICONTEXT((nint)(value));

        public static implicit operator void*(HAMSICONTEXT value) => (void*)(value.Value);

        public static explicit operator HAMSICONTEXT(HANDLE value) => new HAMSICONTEXT(value);

        public static implicit operator HANDLE(HAMSICONTEXT value) => new HANDLE(value.Value);

        public static explicit operator HAMSICONTEXT(byte value) => new HAMSICONTEXT((nint)(value));

        public static explicit operator byte(HAMSICONTEXT value) => (byte)(value.Value);

        public static explicit operator HAMSICONTEXT(short value) => new HAMSICONTEXT((nint)(value));

        public static explicit operator short(HAMSICONTEXT value) => (short)(value.Value);

        public static explicit operator HAMSICONTEXT(int value) => new HAMSICONTEXT((nint)(value));

        public static explicit operator int(HAMSICONTEXT value) => (int)(value.Value);

        public static explicit operator HAMSICONTEXT(long value) => new HAMSICONTEXT((nint)(value));

        public static implicit operator long(HAMSICONTEXT value) => value.Value;

        public static explicit operator HAMSICONTEXT(nint value) => new HAMSICONTEXT((nint)(value));

        public static implicit operator nint(HAMSICONTEXT value) => value.Value;

        public static explicit operator HAMSICONTEXT(sbyte value) => new HAMSICONTEXT((nint)(value));

        public static explicit operator sbyte(HAMSICONTEXT value) => (sbyte)(value.Value);

        public static explicit operator HAMSICONTEXT(ushort value) => new HAMSICONTEXT((nint)(value));

        public static explicit operator ushort(HAMSICONTEXT value) => (ushort)(value.Value);

        public static explicit operator HAMSICONTEXT(uint value) => new HAMSICONTEXT((nint)(value));

        public static explicit operator uint(HAMSICONTEXT value) => (uint)(value.Value);

        public static explicit operator HAMSICONTEXT(ulong value) => new HAMSICONTEXT((nint)(value));

        public static explicit operator ulong(HAMSICONTEXT value) => (ulong)(value.Value);

        public static explicit operator HAMSICONTEXT(nuint value) => new HAMSICONTEXT((nint)(value));

        public static explicit operator nuint(HAMSICONTEXT value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HAMSICONTEXT other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HAMSICONTEXT.");
        }

        public int CompareTo(HAMSICONTEXT other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HAMSICONTEXT other) && Equals(other);

        public bool Equals(HAMSICONTEXT other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}
