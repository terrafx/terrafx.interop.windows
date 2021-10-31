// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HBRUSH
    {
        public static explicit operator HBRUSH(nuint value) => new HBRUSH((nint)(value));

        public static explicit operator nuint(HBRUSH value) => (nuint)(value.Value);

        public static explicit operator HBRUSH(void* value) => new HBRUSH((nint)(value));

        public static explicit operator void*(HBRUSH value) => (void*)(value.Value);
    }
}
