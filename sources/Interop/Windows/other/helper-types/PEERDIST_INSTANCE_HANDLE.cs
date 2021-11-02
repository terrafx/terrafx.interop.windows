// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PEERDIST_INSTANCE_HANDLE : IComparable, IComparable<PEERDIST_INSTANCE_HANDLE>, IEquatable<PEERDIST_INSTANCE_HANDLE>, IFormattable
    {
        public readonly void* Value;

        public PEERDIST_INSTANCE_HANDLE(void* value)
        {
            Value = value;
        }

        public static PEERDIST_INSTANCE_HANDLE INVALID_VALUE => new PEERDIST_INSTANCE_HANDLE((void*)(-1));

        public static PEERDIST_INSTANCE_HANDLE NULL => new PEERDIST_INSTANCE_HANDLE(null);

        public static bool operator ==(PEERDIST_INSTANCE_HANDLE left, PEERDIST_INSTANCE_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(PEERDIST_INSTANCE_HANDLE left, PEERDIST_INSTANCE_HANDLE right) => left.Value != right.Value;

        public static bool operator <(PEERDIST_INSTANCE_HANDLE left, PEERDIST_INSTANCE_HANDLE right) => left.Value < right.Value;

        public static bool operator <=(PEERDIST_INSTANCE_HANDLE left, PEERDIST_INSTANCE_HANDLE right) => left.Value <= right.Value;

        public static bool operator >(PEERDIST_INSTANCE_HANDLE left, PEERDIST_INSTANCE_HANDLE right) => left.Value > right.Value;

        public static bool operator >=(PEERDIST_INSTANCE_HANDLE left, PEERDIST_INSTANCE_HANDLE right) => left.Value >= right.Value;

        public static explicit operator PEERDIST_INSTANCE_HANDLE(void* value) => new PEERDIST_INSTANCE_HANDLE(value);

        public static implicit operator void*(PEERDIST_INSTANCE_HANDLE value) => value.Value;

        public static explicit operator PEERDIST_INSTANCE_HANDLE(HANDLE value) => new PEERDIST_INSTANCE_HANDLE(value);

        public static implicit operator HANDLE(PEERDIST_INSTANCE_HANDLE value) => new HANDLE(value.Value);

        public static explicit operator PEERDIST_INSTANCE_HANDLE(byte value) => new PEERDIST_INSTANCE_HANDLE((void*)(value));

        public static explicit operator byte(PEERDIST_INSTANCE_HANDLE value) => (byte)(value.Value);

        public static explicit operator PEERDIST_INSTANCE_HANDLE(short value) => new PEERDIST_INSTANCE_HANDLE((void*)(value));

        public static explicit operator short(PEERDIST_INSTANCE_HANDLE value) => (short)(value.Value);

        public static explicit operator PEERDIST_INSTANCE_HANDLE(int value) => new PEERDIST_INSTANCE_HANDLE((void*)(value));

        public static explicit operator int(PEERDIST_INSTANCE_HANDLE value) => (int)(value.Value);

        public static explicit operator PEERDIST_INSTANCE_HANDLE(long value) => new PEERDIST_INSTANCE_HANDLE((void*)(value));

        public static explicit operator long(PEERDIST_INSTANCE_HANDLE value) => (long)(value.Value);

        public static explicit operator PEERDIST_INSTANCE_HANDLE(nint value) => new PEERDIST_INSTANCE_HANDLE((void*)(value));

        public static implicit operator nint(PEERDIST_INSTANCE_HANDLE value) => (nint)(value.Value);

        public static explicit operator PEERDIST_INSTANCE_HANDLE(sbyte value) => new PEERDIST_INSTANCE_HANDLE((void*)(value));

        public static explicit operator sbyte(PEERDIST_INSTANCE_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator PEERDIST_INSTANCE_HANDLE(ushort value) => new PEERDIST_INSTANCE_HANDLE((void*)(value));

        public static explicit operator ushort(PEERDIST_INSTANCE_HANDLE value) => (ushort)(value.Value);

        public static explicit operator PEERDIST_INSTANCE_HANDLE(uint value) => new PEERDIST_INSTANCE_HANDLE((void*)(value));

        public static explicit operator uint(PEERDIST_INSTANCE_HANDLE value) => (uint)(value.Value);

        public static explicit operator PEERDIST_INSTANCE_HANDLE(ulong value) => new PEERDIST_INSTANCE_HANDLE((void*)(value));

        public static explicit operator ulong(PEERDIST_INSTANCE_HANDLE value) => (ulong)(value.Value);

        public static explicit operator PEERDIST_INSTANCE_HANDLE(nuint value) => new PEERDIST_INSTANCE_HANDLE((void*)(value));

        public static implicit operator nuint(PEERDIST_INSTANCE_HANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is PEERDIST_INSTANCE_HANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of PEERDIST_INSTANCE_HANDLE.");
        }

        public int CompareTo(PEERDIST_INSTANCE_HANDLE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is PEERDIST_INSTANCE_HANDLE other) && Equals(other);

        public bool Equals(PEERDIST_INSTANCE_HANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
