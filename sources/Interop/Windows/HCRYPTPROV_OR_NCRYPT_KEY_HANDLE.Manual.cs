// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTPROV_OR_NCRYPT_KEY_HANDLE
    {
        public static explicit operator HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(nuint value) => new HCRYPTPROV_OR_NCRYPT_KEY_HANDLE((nint)(value));

        public static explicit operator nuint(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE value) => (nuint)(value.Value);

        public static explicit operator HCRYPTPROV_OR_NCRYPT_KEY_HANDLE(void* value) => new HCRYPTPROV_OR_NCRYPT_KEY_HANDLE((nint)(value));

        public static explicit operator void*(HCRYPTPROV_OR_NCRYPT_KEY_HANDLE value) => (void*)(value.Value);
    }
}
