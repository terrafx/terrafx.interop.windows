// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct CO_DEVICE_CATALOG_COOKIE
    {
        public static explicit operator CO_DEVICE_CATALOG_COOKIE(nuint value) => new CO_DEVICE_CATALOG_COOKIE((nint)(value));

        public static explicit operator nuint(CO_DEVICE_CATALOG_COOKIE value) => (nuint)(value.Value);

        public static explicit operator CO_DEVICE_CATALOG_COOKIE(void* value) => new CO_DEVICE_CATALOG_COOKIE((nint)(value));

        public static explicit operator void*(CO_DEVICE_CATALOG_COOKIE value) => (void*)(value.Value);
    }
}
