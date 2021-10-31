// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HMIDI
    {
        public static explicit operator HMIDI(nuint value) => new HMIDI((nint)(value));

        public static explicit operator nuint(HMIDI value) => (nuint)(value.Value);

        public static explicit operator HMIDI(void* value) => new HMIDI((nint)(value));

        public static explicit operator void*(HMIDI value) => (void*)(value.Value);
    }
}
