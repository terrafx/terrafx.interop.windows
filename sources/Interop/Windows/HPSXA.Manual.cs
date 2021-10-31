// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HPSXA
    {
        public static explicit operator HPSXA(nuint value) => new HPSXA((nint)(value));

        public static explicit operator nuint(HPSXA value) => (nuint)(value.Value);

        public static explicit operator HPSXA(void* value) => new HPSXA((nint)(value));

        public static explicit operator void*(HPSXA value) => (void*)(value.Value);
    }
}
