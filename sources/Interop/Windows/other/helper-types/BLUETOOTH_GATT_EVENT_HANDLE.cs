// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct BLUETOOTH_GATT_EVENT_HANDLE : IComparable, IComparable<BLUETOOTH_GATT_EVENT_HANDLE>, IEquatable<BLUETOOTH_GATT_EVENT_HANDLE>, IFormattable
    {
        public readonly void* Value;

        public BLUETOOTH_GATT_EVENT_HANDLE(void* value)
        {
            Value = value;
        }

        public static BLUETOOTH_GATT_EVENT_HANDLE INVALID_VALUE => new BLUETOOTH_GATT_EVENT_HANDLE((void*)(-1));

        public static BLUETOOTH_GATT_EVENT_HANDLE NULL => new BLUETOOTH_GATT_EVENT_HANDLE(null);

        public static bool operator ==(BLUETOOTH_GATT_EVENT_HANDLE left, BLUETOOTH_GATT_EVENT_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(BLUETOOTH_GATT_EVENT_HANDLE left, BLUETOOTH_GATT_EVENT_HANDLE right) => left.Value != right.Value;

        public static bool operator <(BLUETOOTH_GATT_EVENT_HANDLE left, BLUETOOTH_GATT_EVENT_HANDLE right) => left.Value < right.Value;

        public static bool operator <=(BLUETOOTH_GATT_EVENT_HANDLE left, BLUETOOTH_GATT_EVENT_HANDLE right) => left.Value <= right.Value;

        public static bool operator >(BLUETOOTH_GATT_EVENT_HANDLE left, BLUETOOTH_GATT_EVENT_HANDLE right) => left.Value > right.Value;

        public static bool operator >=(BLUETOOTH_GATT_EVENT_HANDLE left, BLUETOOTH_GATT_EVENT_HANDLE right) => left.Value >= right.Value;

        public static explicit operator BLUETOOTH_GATT_EVENT_HANDLE(void* value) => new BLUETOOTH_GATT_EVENT_HANDLE(value);

        public static implicit operator void*(BLUETOOTH_GATT_EVENT_HANDLE value) => value.Value;

        public static explicit operator BLUETOOTH_GATT_EVENT_HANDLE(HANDLE value) => new BLUETOOTH_GATT_EVENT_HANDLE(value);

        public static implicit operator HANDLE(BLUETOOTH_GATT_EVENT_HANDLE value) => new HANDLE(value.Value);

        public static explicit operator BLUETOOTH_GATT_EVENT_HANDLE(byte value) => new BLUETOOTH_GATT_EVENT_HANDLE((void*)(value));

        public static explicit operator byte(BLUETOOTH_GATT_EVENT_HANDLE value) => (byte)(value.Value);

        public static explicit operator BLUETOOTH_GATT_EVENT_HANDLE(short value) => new BLUETOOTH_GATT_EVENT_HANDLE((void*)(value));

        public static explicit operator short(BLUETOOTH_GATT_EVENT_HANDLE value) => (short)(value.Value);

        public static explicit operator BLUETOOTH_GATT_EVENT_HANDLE(int value) => new BLUETOOTH_GATT_EVENT_HANDLE((void*)(value));

        public static explicit operator int(BLUETOOTH_GATT_EVENT_HANDLE value) => (int)(value.Value);

        public static explicit operator BLUETOOTH_GATT_EVENT_HANDLE(long value) => new BLUETOOTH_GATT_EVENT_HANDLE((void*)(value));

        public static explicit operator long(BLUETOOTH_GATT_EVENT_HANDLE value) => (long)(value.Value);

        public static explicit operator BLUETOOTH_GATT_EVENT_HANDLE(nint value) => new BLUETOOTH_GATT_EVENT_HANDLE((void*)(value));

        public static implicit operator nint(BLUETOOTH_GATT_EVENT_HANDLE value) => (nint)(value.Value);

        public static explicit operator BLUETOOTH_GATT_EVENT_HANDLE(sbyte value) => new BLUETOOTH_GATT_EVENT_HANDLE((void*)(value));

        public static explicit operator sbyte(BLUETOOTH_GATT_EVENT_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator BLUETOOTH_GATT_EVENT_HANDLE(ushort value) => new BLUETOOTH_GATT_EVENT_HANDLE((void*)(value));

        public static explicit operator ushort(BLUETOOTH_GATT_EVENT_HANDLE value) => (ushort)(value.Value);

        public static explicit operator BLUETOOTH_GATT_EVENT_HANDLE(uint value) => new BLUETOOTH_GATT_EVENT_HANDLE((void*)(value));

        public static explicit operator uint(BLUETOOTH_GATT_EVENT_HANDLE value) => (uint)(value.Value);

        public static explicit operator BLUETOOTH_GATT_EVENT_HANDLE(ulong value) => new BLUETOOTH_GATT_EVENT_HANDLE((void*)(value));

        public static explicit operator ulong(BLUETOOTH_GATT_EVENT_HANDLE value) => (ulong)(value.Value);

        public static explicit operator BLUETOOTH_GATT_EVENT_HANDLE(nuint value) => new BLUETOOTH_GATT_EVENT_HANDLE((void*)(value));

        public static implicit operator nuint(BLUETOOTH_GATT_EVENT_HANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is BLUETOOTH_GATT_EVENT_HANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of BLUETOOTH_GATT_EVENT_HANDLE.");
        }

        public int CompareTo(BLUETOOTH_GATT_EVENT_HANDLE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is BLUETOOTH_GATT_EVENT_HANDLE other) && Equals(other);

        public bool Equals(BLUETOOTH_GATT_EVENT_HANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
