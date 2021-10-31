// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HPOWERNOTIFY
    {
        public static explicit operator HPOWERNOTIFY(nuint value) => new HPOWERNOTIFY((nint)(value));

        public static explicit operator nuint(HPOWERNOTIFY value) => (nuint)(value.Value);

        public static explicit operator HPOWERNOTIFY(void* value) => new HPOWERNOTIFY((nint)(value));

        public static explicit operator void*(HPOWERNOTIFY value) => (void*)(value.Value);
    }
}
