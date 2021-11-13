// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct HSAVEDUILANGUAGES : IComparable, IComparable<HSAVEDUILANGUAGES>, IEquatable<HSAVEDUILANGUAGES>, IFormattable
    {
        public readonly void* Value;

        public HSAVEDUILANGUAGES(void* value)
        {
            Value = value;
        }

        public static HSAVEDUILANGUAGES INVALID_VALUE => new HSAVEDUILANGUAGES((void*)(-1));

        public static HSAVEDUILANGUAGES NULL => new HSAVEDUILANGUAGES(null);

        public static bool operator ==(HSAVEDUILANGUAGES left, HSAVEDUILANGUAGES right) => left.Value == right.Value;

        public static bool operator !=(HSAVEDUILANGUAGES left, HSAVEDUILANGUAGES right) => left.Value != right.Value;

        public static bool operator <(HSAVEDUILANGUAGES left, HSAVEDUILANGUAGES right) => left.Value < right.Value;

        public static bool operator <=(HSAVEDUILANGUAGES left, HSAVEDUILANGUAGES right) => left.Value <= right.Value;

        public static bool operator >(HSAVEDUILANGUAGES left, HSAVEDUILANGUAGES right) => left.Value > right.Value;

        public static bool operator >=(HSAVEDUILANGUAGES left, HSAVEDUILANGUAGES right) => left.Value >= right.Value;

        public static explicit operator HSAVEDUILANGUAGES(void* value) => new HSAVEDUILANGUAGES(value);

        public static implicit operator void*(HSAVEDUILANGUAGES value) => value.Value;

        public static explicit operator HSAVEDUILANGUAGES(HANDLE value) => new HSAVEDUILANGUAGES(value);

        public static implicit operator HANDLE(HSAVEDUILANGUAGES value) => new HANDLE(value.Value);

        public static explicit operator HSAVEDUILANGUAGES(byte value) => new HSAVEDUILANGUAGES((void*)(value));

        public static explicit operator byte(HSAVEDUILANGUAGES value) => (byte)(value.Value);

        public static explicit operator HSAVEDUILANGUAGES(short value) => new HSAVEDUILANGUAGES((void*)(value));

        public static explicit operator short(HSAVEDUILANGUAGES value) => (short)(value.Value);

        public static explicit operator HSAVEDUILANGUAGES(int value) => new HSAVEDUILANGUAGES((void*)(value));

        public static explicit operator int(HSAVEDUILANGUAGES value) => (int)(value.Value);

        public static explicit operator HSAVEDUILANGUAGES(long value) => new HSAVEDUILANGUAGES((void*)(value));

        public static explicit operator long(HSAVEDUILANGUAGES value) => (long)(value.Value);

        public static explicit operator HSAVEDUILANGUAGES(nint value) => new HSAVEDUILANGUAGES((void*)(value));

        public static implicit operator nint(HSAVEDUILANGUAGES value) => (nint)(value.Value);

        public static explicit operator HSAVEDUILANGUAGES(sbyte value) => new HSAVEDUILANGUAGES((void*)(value));

        public static explicit operator sbyte(HSAVEDUILANGUAGES value) => (sbyte)(value.Value);

        public static explicit operator HSAVEDUILANGUAGES(ushort value) => new HSAVEDUILANGUAGES((void*)(value));

        public static explicit operator ushort(HSAVEDUILANGUAGES value) => (ushort)(value.Value);

        public static explicit operator HSAVEDUILANGUAGES(uint value) => new HSAVEDUILANGUAGES((void*)(value));

        public static explicit operator uint(HSAVEDUILANGUAGES value) => (uint)(value.Value);

        public static explicit operator HSAVEDUILANGUAGES(ulong value) => new HSAVEDUILANGUAGES((void*)(value));

        public static explicit operator ulong(HSAVEDUILANGUAGES value) => (ulong)(value.Value);

        public static explicit operator HSAVEDUILANGUAGES(nuint value) => new HSAVEDUILANGUAGES((void*)(value));

        public static implicit operator nuint(HSAVEDUILANGUAGES value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HSAVEDUILANGUAGES other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HSAVEDUILANGUAGES.");
        }

        public int CompareTo(HSAVEDUILANGUAGES other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HSAVEDUILANGUAGES other) && Equals(other);

        public bool Equals(HSAVEDUILANGUAGES other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
