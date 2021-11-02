// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HAMSICONTEXT : IComparable, IComparable<HAMSICONTEXT>, IEquatable<HAMSICONTEXT>, IFormattable
    {
        public readonly void* Value;

        public HAMSICONTEXT(void* value)
        {
            Value = value;
        }

        public static HAMSICONTEXT INVALID_VALUE => new HAMSICONTEXT((void*)(-1));

        public static HAMSICONTEXT NULL => new HAMSICONTEXT(null);

        public static bool operator ==(HAMSICONTEXT left, HAMSICONTEXT right) => left.Value == right.Value;

        public static bool operator !=(HAMSICONTEXT left, HAMSICONTEXT right) => left.Value != right.Value;

        public static bool operator <(HAMSICONTEXT left, HAMSICONTEXT right) => left.Value < right.Value;

        public static bool operator <=(HAMSICONTEXT left, HAMSICONTEXT right) => left.Value <= right.Value;

        public static bool operator >(HAMSICONTEXT left, HAMSICONTEXT right) => left.Value > right.Value;

        public static bool operator >=(HAMSICONTEXT left, HAMSICONTEXT right) => left.Value >= right.Value;

        public static explicit operator HAMSICONTEXT(void* value) => new HAMSICONTEXT(value);

        public static implicit operator void*(HAMSICONTEXT value) => value.Value;

        public static explicit operator HAMSICONTEXT(HANDLE value) => new HAMSICONTEXT(value);

        public static implicit operator HANDLE(HAMSICONTEXT value) => new HANDLE(value.Value);

        public static explicit operator HAMSICONTEXT(byte value) => new HAMSICONTEXT((void*)(value));

        public static explicit operator byte(HAMSICONTEXT value) => (byte)(value.Value);

        public static explicit operator HAMSICONTEXT(short value) => new HAMSICONTEXT((void*)(value));

        public static explicit operator short(HAMSICONTEXT value) => (short)(value.Value);

        public static explicit operator HAMSICONTEXT(int value) => new HAMSICONTEXT((void*)(value));

        public static explicit operator int(HAMSICONTEXT value) => (int)(value.Value);

        public static explicit operator HAMSICONTEXT(long value) => new HAMSICONTEXT((void*)(value));

        public static explicit operator long(HAMSICONTEXT value) => (long)(value.Value);

        public static explicit operator HAMSICONTEXT(nint value) => new HAMSICONTEXT((void*)(value));

        public static implicit operator nint(HAMSICONTEXT value) => (nint)(value.Value);

        public static explicit operator HAMSICONTEXT(sbyte value) => new HAMSICONTEXT((void*)(value));

        public static explicit operator sbyte(HAMSICONTEXT value) => (sbyte)(value.Value);

        public static explicit operator HAMSICONTEXT(ushort value) => new HAMSICONTEXT((void*)(value));

        public static explicit operator ushort(HAMSICONTEXT value) => (ushort)(value.Value);

        public static explicit operator HAMSICONTEXT(uint value) => new HAMSICONTEXT((void*)(value));

        public static explicit operator uint(HAMSICONTEXT value) => (uint)(value.Value);

        public static explicit operator HAMSICONTEXT(ulong value) => new HAMSICONTEXT((void*)(value));

        public static explicit operator ulong(HAMSICONTEXT value) => (ulong)(value.Value);

        public static explicit operator HAMSICONTEXT(nuint value) => new HAMSICONTEXT((void*)(value));

        public static implicit operator nuint(HAMSICONTEXT value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HAMSICONTEXT other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HAMSICONTEXT.");
        }

        public int CompareTo(HAMSICONTEXT other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HAMSICONTEXT other) && Equals(other);

        public bool Equals(HAMSICONTEXT other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
