// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HIMC
    {
        public static explicit operator HIMC(nuint value) => new HIMC((nint)(value));

        public static explicit operator nuint(HIMC value) => (nuint)(value.Value);

        public static explicit operator HIMC(void* value) => new HIMC((nint)(value));

        public static explicit operator void*(HIMC value) => (void*)(value.Value);
    }
}
