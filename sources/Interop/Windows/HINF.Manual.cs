// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HINF
    {
        public static explicit operator HINF(nuint value) => new HINF((nint)(value));

        public static explicit operator nuint(HINF value) => (nuint)(value.Value);

        public static explicit operator HINF(void* value) => new HINF((nint)(value));

        public static explicit operator void*(HINF value) => (void*)(value.Value);
    }
}
