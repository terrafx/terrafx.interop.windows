// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HRAWINPUT
    {
        public static explicit operator HRAWINPUT(nuint value) => new HRAWINPUT((nint)(value));

        public static explicit operator nuint(HRAWINPUT value) => (nuint)(value.Value);

        public static explicit operator HRAWINPUT(void* value) => new HRAWINPUT((nint)(value));

        public static explicit operator void*(HRAWINPUT value) => (void*)(value.Value);
    }
}
