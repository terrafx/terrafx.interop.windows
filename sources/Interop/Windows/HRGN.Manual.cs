// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HRGN
    {
        public static explicit operator HRGN(nuint value) => new HRGN((nint)(value));

        public static explicit operator nuint(HRGN value) => (nuint)(value.Value);

        public static explicit operator HRGN(void* value) => new HRGN((nint)(value));

        public static explicit operator void*(HRGN value) => (void*)(value.Value);
    }
}
