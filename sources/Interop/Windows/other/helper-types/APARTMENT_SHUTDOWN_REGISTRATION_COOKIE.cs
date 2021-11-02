// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct APARTMENT_SHUTDOWN_REGISTRATION_COOKIE : IEquatable<APARTMENT_SHUTDOWN_REGISTRATION_COOKIE>
    {
        public readonly nint Value;

        public APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(nint value)
        {
            Value = value;
        }

        public static APARTMENT_SHUTDOWN_REGISTRATION_COOKIE INVALID_VALUE => new APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(-1);

        public static APARTMENT_SHUTDOWN_REGISTRATION_COOKIE NULL => new APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(0);

        public static bool operator ==(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE left, APARTMENT_SHUTDOWN_REGISTRATION_COOKIE right) => left.Value == right.Value;

        public static bool operator !=(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE left, APARTMENT_SHUTDOWN_REGISTRATION_COOKIE right) => left.Value != right.Value;

        public static explicit operator APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(void* value) => new APARTMENT_SHUTDOWN_REGISTRATION_COOKIE((nint)(value));

        public static implicit operator void*(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE value) => (void*)(value.Value);

        public static explicit operator APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(HANDLE value) => new APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(value);

        public static implicit operator HANDLE(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE value) => new APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(value);

        public static explicit operator APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(byte value) => new APARTMENT_SHUTDOWN_REGISTRATION_COOKIE((nint)(value));

        public static explicit operator byte(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE value) => (byte)(value.Value);

        public static explicit operator APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(short value) => new APARTMENT_SHUTDOWN_REGISTRATION_COOKIE((nint)(value));

        public static explicit operator short(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE value) => (short)(value.Value);

        public static explicit operator APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(int value) => new APARTMENT_SHUTDOWN_REGISTRATION_COOKIE((nint)(value));

        public static explicit operator int(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE value) => (int)(value.Value);

        public static explicit operator APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(long value) => new APARTMENT_SHUTDOWN_REGISTRATION_COOKIE((nint)(value));

        public static implicit operator long(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE value) => (long)(value.Value);

        public static explicit operator APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(nint value) => new APARTMENT_SHUTDOWN_REGISTRATION_COOKIE((nint)(value));

        public static implicit operator nint(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE value) => (nint)(value.Value);

        public static explicit operator APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(sbyte value) => new APARTMENT_SHUTDOWN_REGISTRATION_COOKIE((nint)(value));

        public static explicit operator sbyte(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE value) => (sbyte)(value.Value);

        public static explicit operator APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(ushort value) => new APARTMENT_SHUTDOWN_REGISTRATION_COOKIE((nint)(value));

        public static explicit operator ushort(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE value) => (ushort)(value.Value);

        public static explicit operator APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(uint value) => new APARTMENT_SHUTDOWN_REGISTRATION_COOKIE((nint)(value));

        public static explicit operator uint(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE value) => (uint)(value.Value);

        public static explicit operator APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(ulong value) => new APARTMENT_SHUTDOWN_REGISTRATION_COOKIE((nint)(value));

        public static explicit operator ulong(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE value) => (ulong)(value.Value);

        public static explicit operator APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(nuint value) => new APARTMENT_SHUTDOWN_REGISTRATION_COOKIE((nint)(value));

        public static explicit operator nuint(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is APARTMENT_SHUTDOWN_REGISTRATION_COOKIE other) && Equals(other);

        public bool Equals(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
