// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HWAVE
    {
        public static explicit operator HWAVE(nuint value) => new HWAVE((nint)(value));

        public static explicit operator nuint(HWAVE value) => (nuint)(value.Value);

        public static explicit operator HWAVE(void* value) => new HWAVE((nint)(value));

        public static explicit operator void*(HWAVE value) => (void*)(value.Value);
    }
}
