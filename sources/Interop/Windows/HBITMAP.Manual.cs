// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HBITMAP
    {
        public static explicit operator HBITMAP(nuint value) => new HBITMAP((nint)(value));

        public static explicit operator nuint(HBITMAP value) => (nuint)(value.Value);

        public static explicit operator HBITMAP(void* value) => new HBITMAP((nint)(value));

        public static explicit operator void*(HBITMAP value) => (void*)(value.Value);
    }
}
