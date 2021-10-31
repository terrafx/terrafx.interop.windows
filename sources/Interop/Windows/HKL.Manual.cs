// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HKL
    {
        public static explicit operator HKL(nuint value) => new HKL((nint)(value));

        public static explicit operator nuint(HKL value) => (nuint)(value.Value);

        public static explicit operator HKL(void* value) => new HKL((nint)(value));

        public static explicit operator void*(HKL value) => (void*)(value.Value);
    }
}
