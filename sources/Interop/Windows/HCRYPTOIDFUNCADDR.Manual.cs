// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTOIDFUNCADDR
    {
        public static explicit operator HCRYPTOIDFUNCADDR(nuint value) => new HCRYPTOIDFUNCADDR((nint)(value));

        public static explicit operator nuint(HCRYPTOIDFUNCADDR value) => (nuint)(value.Value);

        public static explicit operator HCRYPTOIDFUNCADDR(void* value) => new HCRYPTOIDFUNCADDR((nint)(value));

        public static explicit operator void*(HCRYPTOIDFUNCADDR value) => (void*)(value.Value);
    }
}
