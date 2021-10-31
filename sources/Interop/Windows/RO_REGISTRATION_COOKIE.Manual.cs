// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct RO_REGISTRATION_COOKIE
    {
        public static explicit operator RO_REGISTRATION_COOKIE(nuint value) => new RO_REGISTRATION_COOKIE((nint)(value));

        public static explicit operator nuint(RO_REGISTRATION_COOKIE value) => (nuint)(value.Value);

        public static explicit operator RO_REGISTRATION_COOKIE(void* value) => new RO_REGISTRATION_COOKIE((nint)(value));

        public static explicit operator void*(RO_REGISTRATION_COOKIE value) => (void*)(value.Value);
    }
}
