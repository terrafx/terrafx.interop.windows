// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HPROPSHEETPAGE : IComparable, IComparable<HPROPSHEETPAGE>, IEquatable<HPROPSHEETPAGE>, IFormattable
    {
        public readonly nint Value;

        public HPROPSHEETPAGE(nint value)
        {
            Value = value;
        }

        public static HPROPSHEETPAGE INVALID_VALUE => new HPROPSHEETPAGE(-1);

        public static HPROPSHEETPAGE NULL => new HPROPSHEETPAGE(0);

        public static bool operator ==(HPROPSHEETPAGE left, HPROPSHEETPAGE right) => left.Value == right.Value;

        public static bool operator !=(HPROPSHEETPAGE left, HPROPSHEETPAGE right) => left.Value != right.Value;

        public static bool operator <(HPROPSHEETPAGE left, HPROPSHEETPAGE right) => left.Value < right.Value;

        public static bool operator <=(HPROPSHEETPAGE left, HPROPSHEETPAGE right) => left.Value <= right.Value;

        public static bool operator >(HPROPSHEETPAGE left, HPROPSHEETPAGE right) => left.Value > right.Value;

        public static bool operator >=(HPROPSHEETPAGE left, HPROPSHEETPAGE right) => left.Value >= right.Value;

        public static explicit operator HPROPSHEETPAGE(void* value) => new HPROPSHEETPAGE((nint)(value));

        public static implicit operator void*(HPROPSHEETPAGE value) => (void*)(value.Value);

        public static explicit operator HPROPSHEETPAGE(HANDLE value) => new HPROPSHEETPAGE(value);

        public static implicit operator HANDLE(HPROPSHEETPAGE value) => new HANDLE(value.Value);

        public static explicit operator HPROPSHEETPAGE(byte value) => new HPROPSHEETPAGE((nint)(value));

        public static explicit operator byte(HPROPSHEETPAGE value) => (byte)(value.Value);

        public static explicit operator HPROPSHEETPAGE(short value) => new HPROPSHEETPAGE((nint)(value));

        public static explicit operator short(HPROPSHEETPAGE value) => (short)(value.Value);

        public static explicit operator HPROPSHEETPAGE(int value) => new HPROPSHEETPAGE((nint)(value));

        public static explicit operator int(HPROPSHEETPAGE value) => (int)(value.Value);

        public static explicit operator HPROPSHEETPAGE(long value) => new HPROPSHEETPAGE((nint)(value));

        public static implicit operator long(HPROPSHEETPAGE value) => value.Value;

        public static explicit operator HPROPSHEETPAGE(nint value) => new HPROPSHEETPAGE((nint)(value));

        public static implicit operator nint(HPROPSHEETPAGE value) => value.Value;

        public static explicit operator HPROPSHEETPAGE(sbyte value) => new HPROPSHEETPAGE((nint)(value));

        public static explicit operator sbyte(HPROPSHEETPAGE value) => (sbyte)(value.Value);

        public static explicit operator HPROPSHEETPAGE(ushort value) => new HPROPSHEETPAGE((nint)(value));

        public static explicit operator ushort(HPROPSHEETPAGE value) => (ushort)(value.Value);

        public static explicit operator HPROPSHEETPAGE(uint value) => new HPROPSHEETPAGE((nint)(value));

        public static explicit operator uint(HPROPSHEETPAGE value) => (uint)(value.Value);

        public static explicit operator HPROPSHEETPAGE(ulong value) => new HPROPSHEETPAGE((nint)(value));

        public static explicit operator ulong(HPROPSHEETPAGE value) => (ulong)(value.Value);

        public static explicit operator HPROPSHEETPAGE(nuint value) => new HPROPSHEETPAGE((nint)(value));

        public static explicit operator nuint(HPROPSHEETPAGE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HPROPSHEETPAGE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HPROPSHEETPAGE.");
        }

        public int CompareTo(HPROPSHEETPAGE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HPROPSHEETPAGE other) && Equals(other);

        public bool Equals(HPROPSHEETPAGE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}
