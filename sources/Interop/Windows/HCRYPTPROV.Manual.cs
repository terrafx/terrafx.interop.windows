// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTPROV
    {
        public static explicit operator HCRYPTPROV(nuint value) => new HCRYPTPROV((nint)(value));

        public static explicit operator nuint(HCRYPTPROV value) => (nuint)(value.Value);

        public static explicit operator HCRYPTPROV(void* value) => new HCRYPTPROV((nint)(value));

        public static explicit operator void*(HCRYPTPROV value) => (void*)(value.Value);
    }
}
