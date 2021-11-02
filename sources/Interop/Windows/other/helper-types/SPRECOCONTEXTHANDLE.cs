// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SPRECOCONTEXTHANDLE : IComparable, IComparable<SPRECOCONTEXTHANDLE>, IEquatable<SPRECOCONTEXTHANDLE>, IFormattable
    {
        public readonly void* Value;

        public SPRECOCONTEXTHANDLE(void* value)
        {
            Value = value;
        }

        public static SPRECOCONTEXTHANDLE INVALID_VALUE => new SPRECOCONTEXTHANDLE((void*)(-1));

        public static SPRECOCONTEXTHANDLE NULL => new SPRECOCONTEXTHANDLE(null);

        public static bool operator ==(SPRECOCONTEXTHANDLE left, SPRECOCONTEXTHANDLE right) => left.Value == right.Value;

        public static bool operator !=(SPRECOCONTEXTHANDLE left, SPRECOCONTEXTHANDLE right) => left.Value != right.Value;

        public static bool operator <(SPRECOCONTEXTHANDLE left, SPRECOCONTEXTHANDLE right) => left.Value < right.Value;

        public static bool operator <=(SPRECOCONTEXTHANDLE left, SPRECOCONTEXTHANDLE right) => left.Value <= right.Value;

        public static bool operator >(SPRECOCONTEXTHANDLE left, SPRECOCONTEXTHANDLE right) => left.Value > right.Value;

        public static bool operator >=(SPRECOCONTEXTHANDLE left, SPRECOCONTEXTHANDLE right) => left.Value >= right.Value;

        public static explicit operator SPRECOCONTEXTHANDLE(void* value) => new SPRECOCONTEXTHANDLE(value);

        public static implicit operator void*(SPRECOCONTEXTHANDLE value) => value.Value;

        public static explicit operator SPRECOCONTEXTHANDLE(HANDLE value) => new SPRECOCONTEXTHANDLE(value);

        public static implicit operator HANDLE(SPRECOCONTEXTHANDLE value) => new HANDLE(value.Value);

        public static explicit operator SPRECOCONTEXTHANDLE(byte value) => new SPRECOCONTEXTHANDLE((void*)(value));

        public static explicit operator byte(SPRECOCONTEXTHANDLE value) => (byte)(value.Value);

        public static explicit operator SPRECOCONTEXTHANDLE(short value) => new SPRECOCONTEXTHANDLE((void*)(value));

        public static explicit operator short(SPRECOCONTEXTHANDLE value) => (short)(value.Value);

        public static explicit operator SPRECOCONTEXTHANDLE(int value) => new SPRECOCONTEXTHANDLE((void*)(value));

        public static explicit operator int(SPRECOCONTEXTHANDLE value) => (int)(value.Value);

        public static explicit operator SPRECOCONTEXTHANDLE(long value) => new SPRECOCONTEXTHANDLE((void*)(value));

        public static explicit operator long(SPRECOCONTEXTHANDLE value) => (long)(value.Value);

        public static explicit operator SPRECOCONTEXTHANDLE(nint value) => new SPRECOCONTEXTHANDLE((void*)(value));

        public static implicit operator nint(SPRECOCONTEXTHANDLE value) => (nint)(value.Value);

        public static explicit operator SPRECOCONTEXTHANDLE(sbyte value) => new SPRECOCONTEXTHANDLE((void*)(value));

        public static explicit operator sbyte(SPRECOCONTEXTHANDLE value) => (sbyte)(value.Value);

        public static explicit operator SPRECOCONTEXTHANDLE(ushort value) => new SPRECOCONTEXTHANDLE((void*)(value));

        public static explicit operator ushort(SPRECOCONTEXTHANDLE value) => (ushort)(value.Value);

        public static explicit operator SPRECOCONTEXTHANDLE(uint value) => new SPRECOCONTEXTHANDLE((void*)(value));

        public static explicit operator uint(SPRECOCONTEXTHANDLE value) => (uint)(value.Value);

        public static explicit operator SPRECOCONTEXTHANDLE(ulong value) => new SPRECOCONTEXTHANDLE((void*)(value));

        public static explicit operator ulong(SPRECOCONTEXTHANDLE value) => (ulong)(value.Value);

        public static explicit operator SPRECOCONTEXTHANDLE(nuint value) => new SPRECOCONTEXTHANDLE((void*)(value));

        public static implicit operator nuint(SPRECOCONTEXTHANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is SPRECOCONTEXTHANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SPRECOCONTEXTHANDLE.");
        }

        public int CompareTo(SPRECOCONTEXTHANDLE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is SPRECOCONTEXTHANDLE other) && Equals(other);

        public bool Equals(SPRECOCONTEXTHANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
