// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HGLRC
    {
        public static explicit operator HGLRC(nuint value) => new HGLRC((nint)(value));

        public static explicit operator nuint(HGLRC value) => (nuint)(value.Value);

        public static explicit operator HGLRC(void* value) => new HGLRC((nint)(value));

        public static explicit operator void*(HGLRC value) => (void*)(value.Value);
    }
}
