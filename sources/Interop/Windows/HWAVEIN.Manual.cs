// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HWAVEIN
    {
        public static explicit operator HWAVEIN(nuint value) => new HWAVEIN((nint)(value));

        public static explicit operator nuint(HWAVEIN value) => (nuint)(value.Value);

        public static explicit operator HWAVEIN(void* value) => new HWAVEIN((nint)(value));

        public static explicit operator void*(HWAVEIN value) => (void*)(value.Value);
    }
}
