// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HDEVNOTIFY
    {
        public static explicit operator HDEVNOTIFY(nuint value) => new HDEVNOTIFY((nint)(value));

        public static explicit operator nuint(HDEVNOTIFY value) => (nuint)(value.Value);

        public static explicit operator HDEVNOTIFY(void* value) => new HDEVNOTIFY((nint)(value));

        public static explicit operator void*(HDEVNOTIFY value) => (void*)(value.Value);
    }
}
