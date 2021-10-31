// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HINSTANCE
    {
        public static explicit operator HINSTANCE(nuint value) => new HINSTANCE((nint)(value));

        public static explicit operator nuint(HINSTANCE value) => (nuint)(value.Value);

        public static explicit operator HINSTANCE(void* value) => new HINSTANCE((nint)(value));

        public static explicit operator void*(HINSTANCE value) => (void*)(value.Value);
    }
}
