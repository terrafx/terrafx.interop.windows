// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct CO_MTA_USAGE_COOKIE
    {
        public static explicit operator CO_MTA_USAGE_COOKIE(nuint value) => new CO_MTA_USAGE_COOKIE((nint)(value));

        public static explicit operator nuint(CO_MTA_USAGE_COOKIE value) => (nuint)(value.Value);

        public static explicit operator CO_MTA_USAGE_COOKIE(void* value) => new CO_MTA_USAGE_COOKIE((nint)(value));

        public static explicit operator void*(CO_MTA_USAGE_COOKIE value) => (void*)(value.Value);
    }
}
