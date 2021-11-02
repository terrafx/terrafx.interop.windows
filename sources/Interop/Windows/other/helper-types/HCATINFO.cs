// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCATINFO : IComparable, IComparable<HCATINFO>, IEquatable<HCATINFO>, IFormattable
    {
        public readonly void* Value;

        public HCATINFO(void* value)
        {
            Value = value;
        }

        public static HCATINFO INVALID_VALUE => new HCATINFO((void*)(-1));

        public static HCATINFO NULL => new HCATINFO(null);

        public static bool operator ==(HCATINFO left, HCATINFO right) => left.Value == right.Value;

        public static bool operator !=(HCATINFO left, HCATINFO right) => left.Value != right.Value;

        public static bool operator <(HCATINFO left, HCATINFO right) => left.Value < right.Value;

        public static bool operator <=(HCATINFO left, HCATINFO right) => left.Value <= right.Value;

        public static bool operator >(HCATINFO left, HCATINFO right) => left.Value > right.Value;

        public static bool operator >=(HCATINFO left, HCATINFO right) => left.Value >= right.Value;

        public static explicit operator HCATINFO(void* value) => new HCATINFO(value);

        public static implicit operator void*(HCATINFO value) => value.Value;

        public static explicit operator HCATINFO(HANDLE value) => new HCATINFO(value);

        public static implicit operator HANDLE(HCATINFO value) => new HANDLE(value.Value);

        public static explicit operator HCATINFO(byte value) => new HCATINFO((void*)(value));

        public static explicit operator byte(HCATINFO value) => (byte)(value.Value);

        public static explicit operator HCATINFO(short value) => new HCATINFO((void*)(value));

        public static explicit operator short(HCATINFO value) => (short)(value.Value);

        public static explicit operator HCATINFO(int value) => new HCATINFO((void*)(value));

        public static explicit operator int(HCATINFO value) => (int)(value.Value);

        public static explicit operator HCATINFO(long value) => new HCATINFO((void*)(value));

        public static explicit operator long(HCATINFO value) => (long)(value.Value);

        public static explicit operator HCATINFO(nint value) => new HCATINFO((void*)(value));

        public static implicit operator nint(HCATINFO value) => (nint)(value.Value);

        public static explicit operator HCATINFO(sbyte value) => new HCATINFO((void*)(value));

        public static explicit operator sbyte(HCATINFO value) => (sbyte)(value.Value);

        public static explicit operator HCATINFO(ushort value) => new HCATINFO((void*)(value));

        public static explicit operator ushort(HCATINFO value) => (ushort)(value.Value);

        public static explicit operator HCATINFO(uint value) => new HCATINFO((void*)(value));

        public static explicit operator uint(HCATINFO value) => (uint)(value.Value);

        public static explicit operator HCATINFO(ulong value) => new HCATINFO((void*)(value));

        public static explicit operator ulong(HCATINFO value) => (ulong)(value.Value);

        public static explicit operator HCATINFO(nuint value) => new HCATINFO((void*)(value));

        public static implicit operator nuint(HCATINFO value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HCATINFO other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HCATINFO.");
        }

        public int CompareTo(HCATINFO other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HCATINFO other) && Equals(other);

        public bool Equals(HCATINFO other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
