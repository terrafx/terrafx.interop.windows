// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HACCEL
    {
        public static explicit operator HACCEL(nuint value) => new HACCEL((nint)(value));

        public static explicit operator nuint(HACCEL value) => (nuint)(value.Value);

        public static explicit operator HACCEL(void* value) => new HACCEL((nint)(value));

        public static explicit operator void*(HACCEL value) => (void*)(value.Value);
    }
}
