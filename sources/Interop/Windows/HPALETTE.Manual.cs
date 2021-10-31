// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HPALETTE
    {
        public static explicit operator HPALETTE(nuint value) => new HPALETTE((nint)(value));

        public static explicit operator nuint(HPALETTE value) => (nuint)(value.Value);

        public static explicit operator HPALETTE(void* value) => new HPALETTE((nint)(value));

        public static explicit operator void*(HPALETTE value) => (void*)(value.Value);
    }
}
