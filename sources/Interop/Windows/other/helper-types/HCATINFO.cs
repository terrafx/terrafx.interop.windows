// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCATINFO : IComparable, IComparable<HCATINFO>, IEquatable<HCATINFO>, IFormattable
    {
        public readonly nint Value;

        public HCATINFO(nint value)
        {
            Value = value;
        }

        public static HCATINFO INVALID_VALUE => new HCATINFO(-1);

        public static HCATINFO NULL => new HCATINFO(0);

        public static bool operator ==(HCATINFO left, HCATINFO right) => left.Value == right.Value;

        public static bool operator !=(HCATINFO left, HCATINFO right) => left.Value != right.Value;

        public static bool operator <(HCATINFO left, HCATINFO right) => left.Value < right.Value;

        public static bool operator <=(HCATINFO left, HCATINFO right) => left.Value <= right.Value;

        public static bool operator >(HCATINFO left, HCATINFO right) => left.Value > right.Value;

        public static bool operator >=(HCATINFO left, HCATINFO right) => left.Value >= right.Value;

        public static explicit operator HCATINFO(void* value) => new HCATINFO((nint)(value));

        public static implicit operator void*(HCATINFO value) => (void*)(value.Value);

        public static explicit operator HCATINFO(HANDLE value) => new HCATINFO(value);

        public static implicit operator HANDLE(HCATINFO value) => new HANDLE(value.Value);

        public static explicit operator HCATINFO(byte value) => new HCATINFO((nint)(value));

        public static explicit operator byte(HCATINFO value) => (byte)(value.Value);

        public static explicit operator HCATINFO(short value) => new HCATINFO((nint)(value));

        public static explicit operator short(HCATINFO value) => (short)(value.Value);

        public static explicit operator HCATINFO(int value) => new HCATINFO((nint)(value));

        public static explicit operator int(HCATINFO value) => (int)(value.Value);

        public static explicit operator HCATINFO(long value) => new HCATINFO((nint)(value));

        public static implicit operator long(HCATINFO value) => value.Value;

        public static explicit operator HCATINFO(nint value) => new HCATINFO((nint)(value));

        public static implicit operator nint(HCATINFO value) => value.Value;

        public static explicit operator HCATINFO(sbyte value) => new HCATINFO((nint)(value));

        public static explicit operator sbyte(HCATINFO value) => (sbyte)(value.Value);

        public static explicit operator HCATINFO(ushort value) => new HCATINFO((nint)(value));

        public static explicit operator ushort(HCATINFO value) => (ushort)(value.Value);

        public static explicit operator HCATINFO(uint value) => new HCATINFO((nint)(value));

        public static explicit operator uint(HCATINFO value) => (uint)(value.Value);

        public static explicit operator HCATINFO(ulong value) => new HCATINFO((nint)(value));

        public static explicit operator ulong(HCATINFO value) => (ulong)(value.Value);

        public static explicit operator HCATINFO(nuint value) => new HCATINFO((nint)(value));

        public static explicit operator nuint(HCATINFO value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HCATINFO other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HCATINFO.");
        }

        public int CompareTo(HCATINFO other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HCATINFO other) && Equals(other);

        public bool Equals(HCATINFO other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
