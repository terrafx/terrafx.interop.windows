// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HHOOK
    {
        public static explicit operator HHOOK(nuint value) => new HHOOK((nint)(value));

        public static explicit operator nuint(HHOOK value) => (nuint)(value.Value);

        public static explicit operator HHOOK(void* value) => new HHOOK((nint)(value));

        public static explicit operator void*(HHOOK value) => (void*)(value.Value);
    }
}
