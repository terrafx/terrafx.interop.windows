// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct LOCALHANDLE : IComparable, IComparable<LOCALHANDLE>, IEquatable<LOCALHANDLE>, IFormattable
    {
        public readonly void* Value;

        public LOCALHANDLE(void* value)
        {
            Value = value;
        }

        public static LOCALHANDLE INVALID_VALUE => new LOCALHANDLE((void*)(-1));

        public static LOCALHANDLE NULL => new LOCALHANDLE(null);

        public static bool operator ==(LOCALHANDLE left, LOCALHANDLE right) => left.Value == right.Value;

        public static bool operator !=(LOCALHANDLE left, LOCALHANDLE right) => left.Value != right.Value;

        public static bool operator <(LOCALHANDLE left, LOCALHANDLE right) => left.Value < right.Value;

        public static bool operator <=(LOCALHANDLE left, LOCALHANDLE right) => left.Value <= right.Value;

        public static bool operator >(LOCALHANDLE left, LOCALHANDLE right) => left.Value > right.Value;

        public static bool operator >=(LOCALHANDLE left, LOCALHANDLE right) => left.Value >= right.Value;

        public static explicit operator LOCALHANDLE(void* value) => new LOCALHANDLE(value);

        public static implicit operator void*(LOCALHANDLE value) => value.Value;

        public static explicit operator LOCALHANDLE(HANDLE value) => new LOCALHANDLE(value);

        public static implicit operator HANDLE(LOCALHANDLE value) => new HANDLE(value.Value);

        public static explicit operator LOCALHANDLE(byte value) => new LOCALHANDLE((void*)(value));

        public static explicit operator byte(LOCALHANDLE value) => (byte)(value.Value);

        public static explicit operator LOCALHANDLE(short value) => new LOCALHANDLE((void*)(value));

        public static explicit operator short(LOCALHANDLE value) => (short)(value.Value);

        public static explicit operator LOCALHANDLE(int value) => new LOCALHANDLE((void*)(value));

        public static explicit operator int(LOCALHANDLE value) => (int)(value.Value);

        public static explicit operator LOCALHANDLE(long value) => new LOCALHANDLE((void*)(value));

        public static explicit operator long(LOCALHANDLE value) => (long)(value.Value);

        public static explicit operator LOCALHANDLE(nint value) => new LOCALHANDLE((void*)(value));

        public static implicit operator nint(LOCALHANDLE value) => (nint)(value.Value);

        public static explicit operator LOCALHANDLE(sbyte value) => new LOCALHANDLE((void*)(value));

        public static explicit operator sbyte(LOCALHANDLE value) => (sbyte)(value.Value);

        public static explicit operator LOCALHANDLE(ushort value) => new LOCALHANDLE((void*)(value));

        public static explicit operator ushort(LOCALHANDLE value) => (ushort)(value.Value);

        public static explicit operator LOCALHANDLE(uint value) => new LOCALHANDLE((void*)(value));

        public static explicit operator uint(LOCALHANDLE value) => (uint)(value.Value);

        public static explicit operator LOCALHANDLE(ulong value) => new LOCALHANDLE((void*)(value));

        public static explicit operator ulong(LOCALHANDLE value) => (ulong)(value.Value);

        public static explicit operator LOCALHANDLE(nuint value) => new LOCALHANDLE((void*)(value));

        public static implicit operator nuint(LOCALHANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is LOCALHANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of LOCALHANDLE.");
        }

        public int CompareTo(LOCALHANDLE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is LOCALHANDLE other) && Equals(other);

        public bool Equals(LOCALHANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
