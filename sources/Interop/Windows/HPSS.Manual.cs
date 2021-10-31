// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HPSS
    {
        public static explicit operator HPSS(nuint value) => new HPSS((nint)(value));

        public static explicit operator nuint(HPSS value) => (nuint)(value.Value);

        public static explicit operator HPSS(void* value) => new HPSS((nint)(value));

        public static explicit operator void*(HPSS value) => (void*)(value.Value);
    }
}
