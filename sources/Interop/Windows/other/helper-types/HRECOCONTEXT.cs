// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HRECOCONTEXT : IComparable, IComparable<HRECOCONTEXT>, IEquatable<HRECOCONTEXT>, IFormattable
    {
        public readonly nint Value;

        public HRECOCONTEXT(nint value)
        {
            Value = value;
        }

        public static HRECOCONTEXT INVALID_VALUE => new HRECOCONTEXT(-1);

        public static HRECOCONTEXT NULL => new HRECOCONTEXT(0);

        public static bool operator ==(HRECOCONTEXT left, HRECOCONTEXT right) => left.Value == right.Value;

        public static bool operator !=(HRECOCONTEXT left, HRECOCONTEXT right) => left.Value != right.Value;

        public static bool operator <(HRECOCONTEXT left, HRECOCONTEXT right) => left.Value < right.Value;

        public static bool operator <=(HRECOCONTEXT left, HRECOCONTEXT right) => left.Value <= right.Value;

        public static bool operator >(HRECOCONTEXT left, HRECOCONTEXT right) => left.Value > right.Value;

        public static bool operator >=(HRECOCONTEXT left, HRECOCONTEXT right) => left.Value >= right.Value;

        public static explicit operator HRECOCONTEXT(void* value) => new HRECOCONTEXT((nint)(value));

        public static implicit operator void*(HRECOCONTEXT value) => (void*)(value.Value);

        public static explicit operator HRECOCONTEXT(HANDLE value) => new HRECOCONTEXT(value);

        public static implicit operator HANDLE(HRECOCONTEXT value) => new HANDLE(value.Value);

        public static explicit operator HRECOCONTEXT(byte value) => new HRECOCONTEXT((nint)(value));

        public static explicit operator byte(HRECOCONTEXT value) => (byte)(value.Value);

        public static explicit operator HRECOCONTEXT(short value) => new HRECOCONTEXT((nint)(value));

        public static explicit operator short(HRECOCONTEXT value) => (short)(value.Value);

        public static explicit operator HRECOCONTEXT(int value) => new HRECOCONTEXT((nint)(value));

        public static explicit operator int(HRECOCONTEXT value) => (int)(value.Value);

        public static explicit operator HRECOCONTEXT(long value) => new HRECOCONTEXT((nint)(value));

        public static implicit operator long(HRECOCONTEXT value) => value.Value;

        public static explicit operator HRECOCONTEXT(nint value) => new HRECOCONTEXT((nint)(value));

        public static implicit operator nint(HRECOCONTEXT value) => value.Value;

        public static explicit operator HRECOCONTEXT(sbyte value) => new HRECOCONTEXT((nint)(value));

        public static explicit operator sbyte(HRECOCONTEXT value) => (sbyte)(value.Value);

        public static explicit operator HRECOCONTEXT(ushort value) => new HRECOCONTEXT((nint)(value));

        public static explicit operator ushort(HRECOCONTEXT value) => (ushort)(value.Value);

        public static explicit operator HRECOCONTEXT(uint value) => new HRECOCONTEXT((nint)(value));

        public static explicit operator uint(HRECOCONTEXT value) => (uint)(value.Value);

        public static explicit operator HRECOCONTEXT(ulong value) => new HRECOCONTEXT((nint)(value));

        public static explicit operator ulong(HRECOCONTEXT value) => (ulong)(value.Value);

        public static explicit operator HRECOCONTEXT(nuint value) => new HRECOCONTEXT((nint)(value));

        public static explicit operator nuint(HRECOCONTEXT value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HRECOCONTEXT other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HRECOCONTEXT.");
        }

        public int CompareTo(HRECOCONTEXT other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HRECOCONTEXT other) && Equals(other);

        public bool Equals(HRECOCONTEXT other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}
