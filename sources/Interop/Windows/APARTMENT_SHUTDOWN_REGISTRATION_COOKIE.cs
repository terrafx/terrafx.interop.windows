// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct APARTMENT_SHUTDOWN_REGISTRATION_COOKIE : IEquatable<APARTMENT_SHUTDOWN_REGISTRATION_COOKIE>
    {
        public readonly nint Value;

        public APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(int value)
        {
            Value = ((nint)(value));
        }

        public APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(uint value)
        {
            Value = ((nint)(value));
        }

        public APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(nint value)
        {
            Value = ((nint)(value));
        }

        public APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(nuint value)
        {
            Value = ((nint)(value));
        }

        public APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(void* value)
        {
            Value = ((nint)(value));
        }

        public APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE left, APARTMENT_SHUTDOWN_REGISTRATION_COOKIE right) => left.Value == right.Value;

        public static bool operator !=(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE left, APARTMENT_SHUTDOWN_REGISTRATION_COOKIE right) => left.Value != right.Value;

        public static explicit operator APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(int value) => new APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(value);

        public static explicit operator APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(uint value) => new APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(value);

        public static explicit operator APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(nint value) => new APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(value);

        public static explicit operator APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(nuint value) => new APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(value);

        public static explicit operator APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(void* value) => new APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(value);

        public static explicit operator APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(HANDLE value) => new APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(value);

        public static implicit operator int(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE value) => (int)(value.Value);

        public static implicit operator uint(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE value) => (uint)(value.Value);

        public static implicit operator nint(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE value) => (nint)(value.Value);

        public static implicit operator nuint(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE value) => (nuint)(value.Value);

        public static implicit operator void*(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE value) => (void*)(value.Value);

        public static implicit operator HANDLE(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is APARTMENT_SHUTDOWN_REGISTRATION_COOKIE other) && Equals(other);

        public bool Equals(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
