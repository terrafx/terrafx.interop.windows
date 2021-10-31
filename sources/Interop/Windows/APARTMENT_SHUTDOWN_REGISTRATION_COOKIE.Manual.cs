// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct APARTMENT_SHUTDOWN_REGISTRATION_COOKIE
    {
        public static explicit operator APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(nuint value) => new APARTMENT_SHUTDOWN_REGISTRATION_COOKIE((nint)(value));

        public static explicit operator nuint(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE value) => (nuint)(value.Value);

        public static explicit operator APARTMENT_SHUTDOWN_REGISTRATION_COOKIE(void* value) => new APARTMENT_SHUTDOWN_REGISTRATION_COOKIE((nint)(value));

        public static explicit operator void*(APARTMENT_SHUTDOWN_REGISTRATION_COOKIE value) => (void*)(value.Value);
    }
}
