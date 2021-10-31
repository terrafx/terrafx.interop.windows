// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTPROV_LEGACY
    {
        public static explicit operator HCRYPTPROV_LEGACY(nuint value) => new HCRYPTPROV_LEGACY((nint)(value));

        public static explicit operator nuint(HCRYPTPROV_LEGACY value) => (nuint)(value.Value);

        public static explicit operator HCRYPTPROV_LEGACY(void* value) => new HCRYPTPROV_LEGACY((nint)(value));

        public static explicit operator void*(HCRYPTPROV_LEGACY value) => (void*)(value.Value);
    }
}
