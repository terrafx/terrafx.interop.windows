// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct BLUETOOTH_GATT_EVENT_HANDLE : IEquatable<BLUETOOTH_GATT_EVENT_HANDLE>
    {
        public readonly nint Value;

        public BLUETOOTH_GATT_EVENT_HANDLE(nint value)
        {
            Value = value;
        }

        public static BLUETOOTH_GATT_EVENT_HANDLE INVALID_VALUE => new BLUETOOTH_GATT_EVENT_HANDLE(-1);

        public static BLUETOOTH_GATT_EVENT_HANDLE NULL => new BLUETOOTH_GATT_EVENT_HANDLE(0);

        public static bool operator ==(BLUETOOTH_GATT_EVENT_HANDLE left, BLUETOOTH_GATT_EVENT_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(BLUETOOTH_GATT_EVENT_HANDLE left, BLUETOOTH_GATT_EVENT_HANDLE right) => left.Value != right.Value;

        public static explicit operator BLUETOOTH_GATT_EVENT_HANDLE(void* value) => new BLUETOOTH_GATT_EVENT_HANDLE((nint)(value));

        public static implicit operator void*(BLUETOOTH_GATT_EVENT_HANDLE value) => (void*)(value.Value);

        public static explicit operator BLUETOOTH_GATT_EVENT_HANDLE(HANDLE value) => new BLUETOOTH_GATT_EVENT_HANDLE(value);

        public static implicit operator HANDLE(BLUETOOTH_GATT_EVENT_HANDLE value) => new BLUETOOTH_GATT_EVENT_HANDLE(value);

        public static explicit operator BLUETOOTH_GATT_EVENT_HANDLE(byte value) => new BLUETOOTH_GATT_EVENT_HANDLE((nint)(value));

        public static explicit operator byte(BLUETOOTH_GATT_EVENT_HANDLE value) => (byte)(value.Value);

        public static explicit operator BLUETOOTH_GATT_EVENT_HANDLE(short value) => new BLUETOOTH_GATT_EVENT_HANDLE((nint)(value));

        public static explicit operator short(BLUETOOTH_GATT_EVENT_HANDLE value) => (short)(value.Value);

        public static explicit operator BLUETOOTH_GATT_EVENT_HANDLE(int value) => new BLUETOOTH_GATT_EVENT_HANDLE((nint)(value));

        public static explicit operator int(BLUETOOTH_GATT_EVENT_HANDLE value) => (int)(value.Value);

        public static explicit operator BLUETOOTH_GATT_EVENT_HANDLE(long value) => new BLUETOOTH_GATT_EVENT_HANDLE((nint)(value));

        public static implicit operator long(BLUETOOTH_GATT_EVENT_HANDLE value) => (long)(value.Value);

        public static explicit operator BLUETOOTH_GATT_EVENT_HANDLE(nint value) => new BLUETOOTH_GATT_EVENT_HANDLE((nint)(value));

        public static implicit operator nint(BLUETOOTH_GATT_EVENT_HANDLE value) => (nint)(value.Value);

        public static explicit operator BLUETOOTH_GATT_EVENT_HANDLE(sbyte value) => new BLUETOOTH_GATT_EVENT_HANDLE((nint)(value));

        public static explicit operator sbyte(BLUETOOTH_GATT_EVENT_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator BLUETOOTH_GATT_EVENT_HANDLE(ushort value) => new BLUETOOTH_GATT_EVENT_HANDLE((nint)(value));

        public static explicit operator ushort(BLUETOOTH_GATT_EVENT_HANDLE value) => (ushort)(value.Value);

        public static explicit operator BLUETOOTH_GATT_EVENT_HANDLE(uint value) => new BLUETOOTH_GATT_EVENT_HANDLE((nint)(value));

        public static explicit operator uint(BLUETOOTH_GATT_EVENT_HANDLE value) => (uint)(value.Value);

        public static explicit operator BLUETOOTH_GATT_EVENT_HANDLE(ulong value) => new BLUETOOTH_GATT_EVENT_HANDLE((nint)(value));

        public static explicit operator ulong(BLUETOOTH_GATT_EVENT_HANDLE value) => (ulong)(value.Value);

        public static explicit operator BLUETOOTH_GATT_EVENT_HANDLE(nuint value) => new BLUETOOTH_GATT_EVENT_HANDLE((nint)(value));

        public static explicit operator nuint(BLUETOOTH_GATT_EVENT_HANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is BLUETOOTH_GATT_EVENT_HANDLE other) && Equals(other);

        public bool Equals(BLUETOOTH_GATT_EVENT_HANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
