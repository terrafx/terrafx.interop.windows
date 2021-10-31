// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HTASK
    {
        public static explicit operator HTASK(nuint value) => new HTASK((nint)(value));

        public static explicit operator nuint(HTASK value) => (nuint)(value.Value);

        public static explicit operator HTASK(void* value) => new HTASK((nint)(value));

        public static explicit operator void*(HTASK value) => (void*)(value.Value);
    }
}
