// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct RAS_SERVER_HANDLE : IComparable, IComparable<RAS_SERVER_HANDLE>, IEquatable<RAS_SERVER_HANDLE>, IFormattable
    {
        public readonly void* Value;

        public RAS_SERVER_HANDLE(void* value)
        {
            Value = value;
        }

        public static RAS_SERVER_HANDLE INVALID_VALUE => new RAS_SERVER_HANDLE((void*)(-1));

        public static RAS_SERVER_HANDLE NULL => new RAS_SERVER_HANDLE(null);

        public static bool operator ==(RAS_SERVER_HANDLE left, RAS_SERVER_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(RAS_SERVER_HANDLE left, RAS_SERVER_HANDLE right) => left.Value != right.Value;

        public static bool operator <(RAS_SERVER_HANDLE left, RAS_SERVER_HANDLE right) => left.Value < right.Value;

        public static bool operator <=(RAS_SERVER_HANDLE left, RAS_SERVER_HANDLE right) => left.Value <= right.Value;

        public static bool operator >(RAS_SERVER_HANDLE left, RAS_SERVER_HANDLE right) => left.Value > right.Value;

        public static bool operator >=(RAS_SERVER_HANDLE left, RAS_SERVER_HANDLE right) => left.Value >= right.Value;

        public static explicit operator RAS_SERVER_HANDLE(void* value) => new RAS_SERVER_HANDLE(value);

        public static implicit operator void*(RAS_SERVER_HANDLE value) => value.Value;

        public static explicit operator RAS_SERVER_HANDLE(HANDLE value) => new RAS_SERVER_HANDLE(value);

        public static implicit operator HANDLE(RAS_SERVER_HANDLE value) => new HANDLE(value.Value);

        public static explicit operator RAS_SERVER_HANDLE(byte value) => new RAS_SERVER_HANDLE((void*)(value));

        public static explicit operator byte(RAS_SERVER_HANDLE value) => (byte)(value.Value);

        public static explicit operator RAS_SERVER_HANDLE(short value) => new RAS_SERVER_HANDLE((void*)(value));

        public static explicit operator short(RAS_SERVER_HANDLE value) => (short)(value.Value);

        public static explicit operator RAS_SERVER_HANDLE(int value) => new RAS_SERVER_HANDLE((void*)(value));

        public static explicit operator int(RAS_SERVER_HANDLE value) => (int)(value.Value);

        public static explicit operator RAS_SERVER_HANDLE(long value) => new RAS_SERVER_HANDLE((void*)(value));

        public static explicit operator long(RAS_SERVER_HANDLE value) => (long)(value.Value);

        public static explicit operator RAS_SERVER_HANDLE(nint value) => new RAS_SERVER_HANDLE((void*)(value));

        public static implicit operator nint(RAS_SERVER_HANDLE value) => (nint)(value.Value);

        public static explicit operator RAS_SERVER_HANDLE(sbyte value) => new RAS_SERVER_HANDLE((void*)(value));

        public static explicit operator sbyte(RAS_SERVER_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator RAS_SERVER_HANDLE(ushort value) => new RAS_SERVER_HANDLE((void*)(value));

        public static explicit operator ushort(RAS_SERVER_HANDLE value) => (ushort)(value.Value);

        public static explicit operator RAS_SERVER_HANDLE(uint value) => new RAS_SERVER_HANDLE((void*)(value));

        public static explicit operator uint(RAS_SERVER_HANDLE value) => (uint)(value.Value);

        public static explicit operator RAS_SERVER_HANDLE(ulong value) => new RAS_SERVER_HANDLE((void*)(value));

        public static explicit operator ulong(RAS_SERVER_HANDLE value) => (ulong)(value.Value);

        public static explicit operator RAS_SERVER_HANDLE(nuint value) => new RAS_SERVER_HANDLE((void*)(value));

        public static implicit operator nuint(RAS_SERVER_HANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is RAS_SERVER_HANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of RAS_SERVER_HANDLE.");
        }

        public int CompareTo(RAS_SERVER_HANDLE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is RAS_SERVER_HANDLE other) && Equals(other);

        public bool Equals(RAS_SERVER_HANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
