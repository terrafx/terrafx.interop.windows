// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTOIDFUNCSET
    {
        public static explicit operator HCRYPTOIDFUNCSET(nuint value) => new HCRYPTOIDFUNCSET((nint)(value));

        public static explicit operator nuint(HCRYPTOIDFUNCSET value) => (nuint)(value.Value);

        public static explicit operator HCRYPTOIDFUNCSET(void* value) => new HCRYPTOIDFUNCSET((nint)(value));

        public static explicit operator void*(HCRYPTOIDFUNCSET value) => (void*)(value.Value);
    }
}
