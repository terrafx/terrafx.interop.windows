// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct SERVICE_STATUS_HANDLE : IComparable, IComparable<SERVICE_STATUS_HANDLE>, IEquatable<SERVICE_STATUS_HANDLE>, IFormattable
    {
        public readonly void* Value;

        public SERVICE_STATUS_HANDLE(void* value)
        {
            Value = value;
        }

        public static SERVICE_STATUS_HANDLE INVALID_VALUE => new SERVICE_STATUS_HANDLE((void*)(-1));

        public static SERVICE_STATUS_HANDLE NULL => new SERVICE_STATUS_HANDLE(null);

        public static bool operator ==(SERVICE_STATUS_HANDLE left, SERVICE_STATUS_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(SERVICE_STATUS_HANDLE left, SERVICE_STATUS_HANDLE right) => left.Value != right.Value;

        public static bool operator <(SERVICE_STATUS_HANDLE left, SERVICE_STATUS_HANDLE right) => left.Value < right.Value;

        public static bool operator <=(SERVICE_STATUS_HANDLE left, SERVICE_STATUS_HANDLE right) => left.Value <= right.Value;

        public static bool operator >(SERVICE_STATUS_HANDLE left, SERVICE_STATUS_HANDLE right) => left.Value > right.Value;

        public static bool operator >=(SERVICE_STATUS_HANDLE left, SERVICE_STATUS_HANDLE right) => left.Value >= right.Value;

        public static explicit operator SERVICE_STATUS_HANDLE(void* value) => new SERVICE_STATUS_HANDLE(value);

        public static implicit operator void*(SERVICE_STATUS_HANDLE value) => value.Value;

        public static explicit operator SERVICE_STATUS_HANDLE(HANDLE value) => new SERVICE_STATUS_HANDLE(value);

        public static implicit operator HANDLE(SERVICE_STATUS_HANDLE value) => new HANDLE(value.Value);

        public static explicit operator SERVICE_STATUS_HANDLE(byte value) => new SERVICE_STATUS_HANDLE((void*)(value));

        public static explicit operator byte(SERVICE_STATUS_HANDLE value) => (byte)(value.Value);

        public static explicit operator SERVICE_STATUS_HANDLE(short value) => new SERVICE_STATUS_HANDLE((void*)(value));

        public static explicit operator short(SERVICE_STATUS_HANDLE value) => (short)(value.Value);

        public static explicit operator SERVICE_STATUS_HANDLE(int value) => new SERVICE_STATUS_HANDLE((void*)(value));

        public static explicit operator int(SERVICE_STATUS_HANDLE value) => (int)(value.Value);

        public static explicit operator SERVICE_STATUS_HANDLE(long value) => new SERVICE_STATUS_HANDLE((void*)(value));

        public static explicit operator long(SERVICE_STATUS_HANDLE value) => (long)(value.Value);

        public static explicit operator SERVICE_STATUS_HANDLE(nint value) => new SERVICE_STATUS_HANDLE((void*)(value));

        public static implicit operator nint(SERVICE_STATUS_HANDLE value) => (nint)(value.Value);

        public static explicit operator SERVICE_STATUS_HANDLE(sbyte value) => new SERVICE_STATUS_HANDLE((void*)(value));

        public static explicit operator sbyte(SERVICE_STATUS_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator SERVICE_STATUS_HANDLE(ushort value) => new SERVICE_STATUS_HANDLE((void*)(value));

        public static explicit operator ushort(SERVICE_STATUS_HANDLE value) => (ushort)(value.Value);

        public static explicit operator SERVICE_STATUS_HANDLE(uint value) => new SERVICE_STATUS_HANDLE((void*)(value));

        public static explicit operator uint(SERVICE_STATUS_HANDLE value) => (uint)(value.Value);

        public static explicit operator SERVICE_STATUS_HANDLE(ulong value) => new SERVICE_STATUS_HANDLE((void*)(value));

        public static explicit operator ulong(SERVICE_STATUS_HANDLE value) => (ulong)(value.Value);

        public static explicit operator SERVICE_STATUS_HANDLE(nuint value) => new SERVICE_STATUS_HANDLE((void*)(value));

        public static implicit operator nuint(SERVICE_STATUS_HANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is SERVICE_STATUS_HANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SERVICE_STATUS_HANDLE.");
        }

        public int CompareTo(SERVICE_STATUS_HANDLE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is SERVICE_STATUS_HANDLE other) && Equals(other);

        public bool Equals(SERVICE_STATUS_HANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
