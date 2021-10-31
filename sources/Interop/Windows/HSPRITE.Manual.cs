// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HSPRITE
    {
        public static explicit operator HSPRITE(nuint value) => new HSPRITE((nint)(value));

        public static explicit operator nuint(HSPRITE value) => (nuint)(value.Value);

        public static explicit operator HSPRITE(void* value) => new HSPRITE((nint)(value));

        public static explicit operator void*(HSPRITE value) => (void*)(value.Value);
    }
}
