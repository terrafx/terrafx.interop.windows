// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HSYNTHETICPOINTERDEVICE
    {
        public static explicit operator HSYNTHETICPOINTERDEVICE(nuint value) => new HSYNTHETICPOINTERDEVICE((nint)(value));

        public static explicit operator nuint(HSYNTHETICPOINTERDEVICE value) => (nuint)(value.Value);

        public static explicit operator HSYNTHETICPOINTERDEVICE(void* value) => new HSYNTHETICPOINTERDEVICE((nint)(value));

        public static explicit operator void*(HSYNTHETICPOINTERDEVICE value) => (void*)(value.Value);
    }
}
