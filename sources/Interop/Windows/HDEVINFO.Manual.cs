// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HDEVINFO
    {
        public static explicit operator HDEVINFO(nuint value) => new HDEVINFO((nint)(value));

        public static explicit operator nuint(HDEVINFO value) => (nuint)(value.Value);

        public static explicit operator HDEVINFO(void* value) => new HDEVINFO((nint)(value));

        public static explicit operator void*(HDEVINFO value) => (void*)(value.Value);
    }
}
