// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTKEY
    {
        public static explicit operator HCRYPTKEY(nuint value) => new HCRYPTKEY((nint)(value));

        public static explicit operator nuint(HCRYPTKEY value) => (nuint)(value.Value);

        public static explicit operator HCRYPTKEY(void* value) => new HCRYPTKEY((nint)(value));

        public static explicit operator void*(HCRYPTKEY value) => (void*)(value.Value);
    }
}
