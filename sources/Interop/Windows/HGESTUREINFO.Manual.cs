// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HGESTUREINFO
    {
        public static explicit operator HGESTUREINFO(nuint value) => new HGESTUREINFO((nint)(value));

        public static explicit operator nuint(HGESTUREINFO value) => (nuint)(value.Value);

        public static explicit operator HGESTUREINFO(void* value) => new HGESTUREINFO((nint)(value));

        public static explicit operator void*(HGESTUREINFO value) => (void*)(value.Value);
    }
}
