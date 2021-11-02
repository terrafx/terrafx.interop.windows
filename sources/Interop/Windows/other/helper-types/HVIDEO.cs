// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HVIDEO : IComparable, IComparable<HVIDEO>, IEquatable<HVIDEO>, IFormattable
    {
        public readonly void* Value;

        public HVIDEO(void* value)
        {
            Value = value;
        }

        public static HVIDEO INVALID_VALUE => new HVIDEO((void*)(-1));

        public static HVIDEO NULL => new HVIDEO(null);

        public static bool operator ==(HVIDEO left, HVIDEO right) => left.Value == right.Value;

        public static bool operator !=(HVIDEO left, HVIDEO right) => left.Value != right.Value;

        public static bool operator <(HVIDEO left, HVIDEO right) => left.Value < right.Value;

        public static bool operator <=(HVIDEO left, HVIDEO right) => left.Value <= right.Value;

        public static bool operator >(HVIDEO left, HVIDEO right) => left.Value > right.Value;

        public static bool operator >=(HVIDEO left, HVIDEO right) => left.Value >= right.Value;

        public static explicit operator HVIDEO(void* value) => new HVIDEO(value);

        public static implicit operator void*(HVIDEO value) => value.Value;

        public static explicit operator HVIDEO(HANDLE value) => new HVIDEO(value);

        public static implicit operator HANDLE(HVIDEO value) => new HANDLE(value.Value);

        public static explicit operator HVIDEO(byte value) => new HVIDEO((void*)(value));

        public static explicit operator byte(HVIDEO value) => (byte)(value.Value);

        public static explicit operator HVIDEO(short value) => new HVIDEO((void*)(value));

        public static explicit operator short(HVIDEO value) => (short)(value.Value);

        public static explicit operator HVIDEO(int value) => new HVIDEO((void*)(value));

        public static explicit operator int(HVIDEO value) => (int)(value.Value);

        public static explicit operator HVIDEO(long value) => new HVIDEO((void*)(value));

        public static explicit operator long(HVIDEO value) => (long)(value.Value);

        public static explicit operator HVIDEO(nint value) => new HVIDEO((void*)(value));

        public static implicit operator nint(HVIDEO value) => (nint)(value.Value);

        public static explicit operator HVIDEO(sbyte value) => new HVIDEO((void*)(value));

        public static explicit operator sbyte(HVIDEO value) => (sbyte)(value.Value);

        public static explicit operator HVIDEO(ushort value) => new HVIDEO((void*)(value));

        public static explicit operator ushort(HVIDEO value) => (ushort)(value.Value);

        public static explicit operator HVIDEO(uint value) => new HVIDEO((void*)(value));

        public static explicit operator uint(HVIDEO value) => (uint)(value.Value);

        public static explicit operator HVIDEO(ulong value) => new HVIDEO((void*)(value));

        public static explicit operator ulong(HVIDEO value) => (ulong)(value.Value);

        public static explicit operator HVIDEO(nuint value) => new HVIDEO((void*)(value));

        public static implicit operator nuint(HVIDEO value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HVIDEO other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HVIDEO.");
        }

        public int CompareTo(HVIDEO other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HVIDEO other) && Equals(other);

        public bool Equals(HVIDEO other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
