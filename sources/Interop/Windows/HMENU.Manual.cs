// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HMENU
    {
        public static explicit operator HMENU(nuint value) => new HMENU((nint)(value));

        public static explicit operator nuint(HMENU value) => (nuint)(value.Value);

        public static explicit operator HMENU(void* value) => new HMENU((nint)(value));

        public static explicit operator void*(HMENU value) => (void*)(value.Value);
    }
}
