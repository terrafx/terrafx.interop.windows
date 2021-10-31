// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HPEN
    {
        public static explicit operator HPEN(nuint value) => new HPEN((nint)(value));

        public static explicit operator nuint(HPEN value) => (nuint)(value.Value);

        public static explicit operator HPEN(void* value) => new HPEN((nint)(value));

        public static explicit operator void*(HPEN value) => (void*)(value.Value);
    }
}
