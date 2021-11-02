// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HBLUETOOTH_CONTAINER_ELEMENT : IEquatable<HBLUETOOTH_CONTAINER_ELEMENT>
    {
        public readonly nint Value;

        public HBLUETOOTH_CONTAINER_ELEMENT(nint value)
        {
            Value = value;
        }

        public static HBLUETOOTH_CONTAINER_ELEMENT INVALID_VALUE => new HBLUETOOTH_CONTAINER_ELEMENT(-1);

        public static HBLUETOOTH_CONTAINER_ELEMENT NULL => new HBLUETOOTH_CONTAINER_ELEMENT(0);

        public static bool operator ==(HBLUETOOTH_CONTAINER_ELEMENT left, HBLUETOOTH_CONTAINER_ELEMENT right) => left.Value == right.Value;

        public static bool operator !=(HBLUETOOTH_CONTAINER_ELEMENT left, HBLUETOOTH_CONTAINER_ELEMENT right) => left.Value != right.Value;

        public static explicit operator HBLUETOOTH_CONTAINER_ELEMENT(void* value) => new HBLUETOOTH_CONTAINER_ELEMENT((nint)(value));

        public static implicit operator void*(HBLUETOOTH_CONTAINER_ELEMENT value) => (void*)(value.Value);

        public static explicit operator HBLUETOOTH_CONTAINER_ELEMENT(HANDLE value) => new HBLUETOOTH_CONTAINER_ELEMENT(value);

        public static implicit operator HANDLE(HBLUETOOTH_CONTAINER_ELEMENT value) => new HBLUETOOTH_CONTAINER_ELEMENT(value);

        public static explicit operator HBLUETOOTH_CONTAINER_ELEMENT(byte value) => new HBLUETOOTH_CONTAINER_ELEMENT((nint)(value));

        public static explicit operator byte(HBLUETOOTH_CONTAINER_ELEMENT value) => (byte)(value.Value);

        public static explicit operator HBLUETOOTH_CONTAINER_ELEMENT(short value) => new HBLUETOOTH_CONTAINER_ELEMENT((nint)(value));

        public static explicit operator short(HBLUETOOTH_CONTAINER_ELEMENT value) => (short)(value.Value);

        public static explicit operator HBLUETOOTH_CONTAINER_ELEMENT(int value) => new HBLUETOOTH_CONTAINER_ELEMENT((nint)(value));

        public static explicit operator int(HBLUETOOTH_CONTAINER_ELEMENT value) => (int)(value.Value);

        public static explicit operator HBLUETOOTH_CONTAINER_ELEMENT(long value) => new HBLUETOOTH_CONTAINER_ELEMENT((nint)(value));

        public static implicit operator long(HBLUETOOTH_CONTAINER_ELEMENT value) => (long)(value.Value);

        public static explicit operator HBLUETOOTH_CONTAINER_ELEMENT(nint value) => new HBLUETOOTH_CONTAINER_ELEMENT((nint)(value));

        public static implicit operator nint(HBLUETOOTH_CONTAINER_ELEMENT value) => (nint)(value.Value);

        public static explicit operator HBLUETOOTH_CONTAINER_ELEMENT(sbyte value) => new HBLUETOOTH_CONTAINER_ELEMENT((nint)(value));

        public static explicit operator sbyte(HBLUETOOTH_CONTAINER_ELEMENT value) => (sbyte)(value.Value);

        public static explicit operator HBLUETOOTH_CONTAINER_ELEMENT(ushort value) => new HBLUETOOTH_CONTAINER_ELEMENT((nint)(value));

        public static explicit operator ushort(HBLUETOOTH_CONTAINER_ELEMENT value) => (ushort)(value.Value);

        public static explicit operator HBLUETOOTH_CONTAINER_ELEMENT(uint value) => new HBLUETOOTH_CONTAINER_ELEMENT((nint)(value));

        public static explicit operator uint(HBLUETOOTH_CONTAINER_ELEMENT value) => (uint)(value.Value);

        public static explicit operator HBLUETOOTH_CONTAINER_ELEMENT(ulong value) => new HBLUETOOTH_CONTAINER_ELEMENT((nint)(value));

        public static implicit operator ulong(HBLUETOOTH_CONTAINER_ELEMENT value) => (ulong)(value.Value);

        public static explicit operator HBLUETOOTH_CONTAINER_ELEMENT(nuint value) => new HBLUETOOTH_CONTAINER_ELEMENT((nint)(value));

        public static explicit operator nuint(HBLUETOOTH_CONTAINER_ELEMENT value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HBLUETOOTH_CONTAINER_ELEMENT other) && Equals(other);

        public bool Equals(HBLUETOOTH_CONTAINER_ELEMENT other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
