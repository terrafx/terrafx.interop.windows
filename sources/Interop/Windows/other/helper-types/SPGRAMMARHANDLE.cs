// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SPGRAMMARHANDLE : IComparable, IComparable<SPGRAMMARHANDLE>, IEquatable<SPGRAMMARHANDLE>, IFormattable
    {
        public readonly void* Value;

        public SPGRAMMARHANDLE(void* value)
        {
            Value = value;
        }

        public static SPGRAMMARHANDLE INVALID_VALUE => new SPGRAMMARHANDLE((void*)(-1));

        public static SPGRAMMARHANDLE NULL => new SPGRAMMARHANDLE(null);

        public static bool operator ==(SPGRAMMARHANDLE left, SPGRAMMARHANDLE right) => left.Value == right.Value;

        public static bool operator !=(SPGRAMMARHANDLE left, SPGRAMMARHANDLE right) => left.Value != right.Value;

        public static bool operator <(SPGRAMMARHANDLE left, SPGRAMMARHANDLE right) => left.Value < right.Value;

        public static bool operator <=(SPGRAMMARHANDLE left, SPGRAMMARHANDLE right) => left.Value <= right.Value;

        public static bool operator >(SPGRAMMARHANDLE left, SPGRAMMARHANDLE right) => left.Value > right.Value;

        public static bool operator >=(SPGRAMMARHANDLE left, SPGRAMMARHANDLE right) => left.Value >= right.Value;

        public static explicit operator SPGRAMMARHANDLE(void* value) => new SPGRAMMARHANDLE(value);

        public static implicit operator void*(SPGRAMMARHANDLE value) => value.Value;

        public static explicit operator SPGRAMMARHANDLE(HANDLE value) => new SPGRAMMARHANDLE(value);

        public static implicit operator HANDLE(SPGRAMMARHANDLE value) => new HANDLE(value.Value);

        public static explicit operator SPGRAMMARHANDLE(byte value) => new SPGRAMMARHANDLE((void*)(value));

        public static explicit operator byte(SPGRAMMARHANDLE value) => (byte)(value.Value);

        public static explicit operator SPGRAMMARHANDLE(short value) => new SPGRAMMARHANDLE((void*)(value));

        public static explicit operator short(SPGRAMMARHANDLE value) => (short)(value.Value);

        public static explicit operator SPGRAMMARHANDLE(int value) => new SPGRAMMARHANDLE((void*)(value));

        public static explicit operator int(SPGRAMMARHANDLE value) => (int)(value.Value);

        public static explicit operator SPGRAMMARHANDLE(long value) => new SPGRAMMARHANDLE((void*)(value));

        public static explicit operator long(SPGRAMMARHANDLE value) => (long)(value.Value);

        public static explicit operator SPGRAMMARHANDLE(nint value) => new SPGRAMMARHANDLE((void*)(value));

        public static implicit operator nint(SPGRAMMARHANDLE value) => (nint)(value.Value);

        public static explicit operator SPGRAMMARHANDLE(sbyte value) => new SPGRAMMARHANDLE((void*)(value));

        public static explicit operator sbyte(SPGRAMMARHANDLE value) => (sbyte)(value.Value);

        public static explicit operator SPGRAMMARHANDLE(ushort value) => new SPGRAMMARHANDLE((void*)(value));

        public static explicit operator ushort(SPGRAMMARHANDLE value) => (ushort)(value.Value);

        public static explicit operator SPGRAMMARHANDLE(uint value) => new SPGRAMMARHANDLE((void*)(value));

        public static explicit operator uint(SPGRAMMARHANDLE value) => (uint)(value.Value);

        public static explicit operator SPGRAMMARHANDLE(ulong value) => new SPGRAMMARHANDLE((void*)(value));

        public static explicit operator ulong(SPGRAMMARHANDLE value) => (ulong)(value.Value);

        public static explicit operator SPGRAMMARHANDLE(nuint value) => new SPGRAMMARHANDLE((void*)(value));

        public static implicit operator nuint(SPGRAMMARHANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is SPGRAMMARHANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SPGRAMMARHANDLE.");
        }

        public int CompareTo(SPGRAMMARHANDLE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is SPGRAMMARHANDLE other) && Equals(other);

        public bool Equals(SPGRAMMARHANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
