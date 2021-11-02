// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HBLUETOOTH_AUTHENTICATION_REGISTRATION : IEquatable<HBLUETOOTH_AUTHENTICATION_REGISTRATION>
    {
        public readonly nint Value;

        public HBLUETOOTH_AUTHENTICATION_REGISTRATION(nint value)
        {
            Value = value;
        }

        public static HBLUETOOTH_AUTHENTICATION_REGISTRATION INVALID_HANDLE_VALUE => new HBLUETOOTH_AUTHENTICATION_REGISTRATION(-1);

        public static HBLUETOOTH_AUTHENTICATION_REGISTRATION NULL => new HBLUETOOTH_AUTHENTICATION_REGISTRATION(0);

        public static bool operator ==(HBLUETOOTH_AUTHENTICATION_REGISTRATION left, HBLUETOOTH_AUTHENTICATION_REGISTRATION right) => left.Value == right.Value;

        public static bool operator !=(HBLUETOOTH_AUTHENTICATION_REGISTRATION left, HBLUETOOTH_AUTHENTICATION_REGISTRATION right) => left.Value != right.Value;

        public static explicit operator HBLUETOOTH_AUTHENTICATION_REGISTRATION(void* value) => new HBLUETOOTH_AUTHENTICATION_REGISTRATION((nint)(value));

        public static implicit operator void*(HBLUETOOTH_AUTHENTICATION_REGISTRATION value) => (void*)(value.Value);

        public static explicit operator HBLUETOOTH_AUTHENTICATION_REGISTRATION(HANDLE value) => new HBLUETOOTH_AUTHENTICATION_REGISTRATION(value);

        public static implicit operator HANDLE(HBLUETOOTH_AUTHENTICATION_REGISTRATION value) => new HBLUETOOTH_AUTHENTICATION_REGISTRATION(value);

        public static explicit operator HBLUETOOTH_AUTHENTICATION_REGISTRATION(byte value) => new HBLUETOOTH_AUTHENTICATION_REGISTRATION((nint)(value));

        public static implicit operator byte(HBLUETOOTH_AUTHENTICATION_REGISTRATION value) => (byte)(value.Value);

        public static explicit operator HBLUETOOTH_AUTHENTICATION_REGISTRATION(short value) => new HBLUETOOTH_AUTHENTICATION_REGISTRATION((nint)(value));

        public static implicit operator short(HBLUETOOTH_AUTHENTICATION_REGISTRATION value) => (short)(value.Value);

        public static explicit operator HBLUETOOTH_AUTHENTICATION_REGISTRATION(int value) => new HBLUETOOTH_AUTHENTICATION_REGISTRATION((nint)(value));

        public static implicit operator int(HBLUETOOTH_AUTHENTICATION_REGISTRATION value) => (int)(value.Value);

        public static explicit operator HBLUETOOTH_AUTHENTICATION_REGISTRATION(long value) => new HBLUETOOTH_AUTHENTICATION_REGISTRATION((nint)(value));

        public static explicit operator long(HBLUETOOTH_AUTHENTICATION_REGISTRATION value) => (long)(value.Value);

        public static explicit operator HBLUETOOTH_AUTHENTICATION_REGISTRATION(nint value) => new HBLUETOOTH_AUTHENTICATION_REGISTRATION((nint)(value));

        public static implicit operator nint(HBLUETOOTH_AUTHENTICATION_REGISTRATION value) => (nint)(value.Value);

        public static explicit operator HBLUETOOTH_AUTHENTICATION_REGISTRATION(sbyte value) => new HBLUETOOTH_AUTHENTICATION_REGISTRATION((nint)(value));

        public static implicit operator sbyte(HBLUETOOTH_AUTHENTICATION_REGISTRATION value) => (sbyte)(value.Value);

        public static explicit operator HBLUETOOTH_AUTHENTICATION_REGISTRATION(ushort value) => new HBLUETOOTH_AUTHENTICATION_REGISTRATION((nint)(value));

        public static implicit operator ushort(HBLUETOOTH_AUTHENTICATION_REGISTRATION value) => (ushort)(value.Value);

        public static explicit operator HBLUETOOTH_AUTHENTICATION_REGISTRATION(uint value) => new HBLUETOOTH_AUTHENTICATION_REGISTRATION((nint)(value));

        public static implicit operator uint(HBLUETOOTH_AUTHENTICATION_REGISTRATION value) => (uint)(value.Value);

        public static explicit operator HBLUETOOTH_AUTHENTICATION_REGISTRATION(ulong value) => new HBLUETOOTH_AUTHENTICATION_REGISTRATION((nint)(value));

        public static explicit operator ulong(HBLUETOOTH_AUTHENTICATION_REGISTRATION value) => (ulong)(value.Value);

        public static explicit operator HBLUETOOTH_AUTHENTICATION_REGISTRATION(nuint value) => new HBLUETOOTH_AUTHENTICATION_REGISTRATION((nint)(value));

        public static explicit operator nuint(HBLUETOOTH_AUTHENTICATION_REGISTRATION value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HBLUETOOTH_AUTHENTICATION_REGISTRATION other) && Equals(other);

        public bool Equals(HBLUETOOTH_AUTHENTICATION_REGISTRATION other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
