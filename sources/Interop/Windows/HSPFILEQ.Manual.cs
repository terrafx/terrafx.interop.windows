// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HSPFILEQ
    {
        public static explicit operator HSPFILEQ(nuint value) => new HSPFILEQ((nint)(value));

        public static explicit operator nuint(HSPFILEQ value) => (nuint)(value.Value);

        public static explicit operator HSPFILEQ(void* value) => new HSPFILEQ((nint)(value));

        public static explicit operator void*(HSPFILEQ value) => (void*)(value.Value);
    }
}
