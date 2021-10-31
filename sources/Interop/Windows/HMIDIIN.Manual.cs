// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HMIDIIN
    {
        public static explicit operator HMIDIIN(nuint value) => new HMIDIIN((nint)(value));

        public static explicit operator nuint(HMIDIIN value) => (nuint)(value.Value);

        public static explicit operator HMIDIIN(void* value) => new HMIDIIN((nint)(value));

        public static explicit operator void*(HMIDIIN value) => (void*)(value.Value);
    }
}
