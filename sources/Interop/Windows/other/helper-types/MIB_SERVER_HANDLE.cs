// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct MIB_SERVER_HANDLE : IComparable, IComparable<MIB_SERVER_HANDLE>, IEquatable<MIB_SERVER_HANDLE>, IFormattable
    {
        public readonly void* Value;

        public MIB_SERVER_HANDLE(void* value)
        {
            Value = value;
        }

        public static MIB_SERVER_HANDLE INVALID_VALUE => new MIB_SERVER_HANDLE((void*)(-1));

        public static MIB_SERVER_HANDLE NULL => new MIB_SERVER_HANDLE(null);

        public static bool operator ==(MIB_SERVER_HANDLE left, MIB_SERVER_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(MIB_SERVER_HANDLE left, MIB_SERVER_HANDLE right) => left.Value != right.Value;

        public static bool operator <(MIB_SERVER_HANDLE left, MIB_SERVER_HANDLE right) => left.Value < right.Value;

        public static bool operator <=(MIB_SERVER_HANDLE left, MIB_SERVER_HANDLE right) => left.Value <= right.Value;

        public static bool operator >(MIB_SERVER_HANDLE left, MIB_SERVER_HANDLE right) => left.Value > right.Value;

        public static bool operator >=(MIB_SERVER_HANDLE left, MIB_SERVER_HANDLE right) => left.Value >= right.Value;

        public static explicit operator MIB_SERVER_HANDLE(void* value) => new MIB_SERVER_HANDLE(value);

        public static implicit operator void*(MIB_SERVER_HANDLE value) => value.Value;

        public static explicit operator MIB_SERVER_HANDLE(HANDLE value) => new MIB_SERVER_HANDLE(value);

        public static implicit operator HANDLE(MIB_SERVER_HANDLE value) => new HANDLE(value.Value);

        public static explicit operator MIB_SERVER_HANDLE(byte value) => new MIB_SERVER_HANDLE((void*)(value));

        public static explicit operator byte(MIB_SERVER_HANDLE value) => (byte)(value.Value);

        public static explicit operator MIB_SERVER_HANDLE(short value) => new MIB_SERVER_HANDLE((void*)(value));

        public static explicit operator short(MIB_SERVER_HANDLE value) => (short)(value.Value);

        public static explicit operator MIB_SERVER_HANDLE(int value) => new MIB_SERVER_HANDLE((void*)(value));

        public static explicit operator int(MIB_SERVER_HANDLE value) => (int)(value.Value);

        public static explicit operator MIB_SERVER_HANDLE(long value) => new MIB_SERVER_HANDLE((void*)(value));

        public static explicit operator long(MIB_SERVER_HANDLE value) => (long)(value.Value);

        public static explicit operator MIB_SERVER_HANDLE(nint value) => new MIB_SERVER_HANDLE((void*)(value));

        public static implicit operator nint(MIB_SERVER_HANDLE value) => (nint)(value.Value);

        public static explicit operator MIB_SERVER_HANDLE(sbyte value) => new MIB_SERVER_HANDLE((void*)(value));

        public static explicit operator sbyte(MIB_SERVER_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator MIB_SERVER_HANDLE(ushort value) => new MIB_SERVER_HANDLE((void*)(value));

        public static explicit operator ushort(MIB_SERVER_HANDLE value) => (ushort)(value.Value);

        public static explicit operator MIB_SERVER_HANDLE(uint value) => new MIB_SERVER_HANDLE((void*)(value));

        public static explicit operator uint(MIB_SERVER_HANDLE value) => (uint)(value.Value);

        public static explicit operator MIB_SERVER_HANDLE(ulong value) => new MIB_SERVER_HANDLE((void*)(value));

        public static explicit operator ulong(MIB_SERVER_HANDLE value) => (ulong)(value.Value);

        public static explicit operator MIB_SERVER_HANDLE(nuint value) => new MIB_SERVER_HANDLE((void*)(value));

        public static implicit operator nuint(MIB_SERVER_HANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is MIB_SERVER_HANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of MIB_SERVER_HANDLE.");
        }

        public int CompareTo(MIB_SERVER_HANDLE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is MIB_SERVER_HANDLE other) && Equals(other);

        public bool Equals(MIB_SERVER_HANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
