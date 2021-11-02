// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct QUEUEHANDLE : IComparable, IComparable<QUEUEHANDLE>, IEquatable<QUEUEHANDLE>, IFormattable
    {
        public readonly void* Value;

        public QUEUEHANDLE(void* value)
        {
            Value = value;
        }

        public static QUEUEHANDLE INVALID_VALUE => new QUEUEHANDLE((void*)(-1));

        public static QUEUEHANDLE NULL => new QUEUEHANDLE(null);

        public static bool operator ==(QUEUEHANDLE left, QUEUEHANDLE right) => left.Value == right.Value;

        public static bool operator !=(QUEUEHANDLE left, QUEUEHANDLE right) => left.Value != right.Value;

        public static bool operator <(QUEUEHANDLE left, QUEUEHANDLE right) => left.Value < right.Value;

        public static bool operator <=(QUEUEHANDLE left, QUEUEHANDLE right) => left.Value <= right.Value;

        public static bool operator >(QUEUEHANDLE left, QUEUEHANDLE right) => left.Value > right.Value;

        public static bool operator >=(QUEUEHANDLE left, QUEUEHANDLE right) => left.Value >= right.Value;

        public static explicit operator QUEUEHANDLE(void* value) => new QUEUEHANDLE(value);

        public static implicit operator void*(QUEUEHANDLE value) => value.Value;

        public static explicit operator QUEUEHANDLE(HANDLE value) => new QUEUEHANDLE(value);

        public static implicit operator HANDLE(QUEUEHANDLE value) => new HANDLE(value.Value);

        public static explicit operator QUEUEHANDLE(byte value) => new QUEUEHANDLE((void*)(value));

        public static explicit operator byte(QUEUEHANDLE value) => (byte)(value.Value);

        public static explicit operator QUEUEHANDLE(short value) => new QUEUEHANDLE((void*)(value));

        public static explicit operator short(QUEUEHANDLE value) => (short)(value.Value);

        public static explicit operator QUEUEHANDLE(int value) => new QUEUEHANDLE((void*)(value));

        public static explicit operator int(QUEUEHANDLE value) => (int)(value.Value);

        public static explicit operator QUEUEHANDLE(long value) => new QUEUEHANDLE((void*)(value));

        public static explicit operator long(QUEUEHANDLE value) => (long)(value.Value);

        public static explicit operator QUEUEHANDLE(nint value) => new QUEUEHANDLE((void*)(value));

        public static implicit operator nint(QUEUEHANDLE value) => (nint)(value.Value);

        public static explicit operator QUEUEHANDLE(sbyte value) => new QUEUEHANDLE((void*)(value));

        public static explicit operator sbyte(QUEUEHANDLE value) => (sbyte)(value.Value);

        public static explicit operator QUEUEHANDLE(ushort value) => new QUEUEHANDLE((void*)(value));

        public static explicit operator ushort(QUEUEHANDLE value) => (ushort)(value.Value);

        public static explicit operator QUEUEHANDLE(uint value) => new QUEUEHANDLE((void*)(value));

        public static explicit operator uint(QUEUEHANDLE value) => (uint)(value.Value);

        public static explicit operator QUEUEHANDLE(ulong value) => new QUEUEHANDLE((void*)(value));

        public static explicit operator ulong(QUEUEHANDLE value) => (ulong)(value.Value);

        public static explicit operator QUEUEHANDLE(nuint value) => new QUEUEHANDLE((void*)(value));

        public static implicit operator nuint(QUEUEHANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is QUEUEHANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of QUEUEHANDLE.");
        }

        public int CompareTo(QUEUEHANDLE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is QUEUEHANDLE other) && Equals(other);

        public bool Equals(QUEUEHANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
