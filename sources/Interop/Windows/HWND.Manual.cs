// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HWND
    {
        public static explicit operator HWND(nuint value) => new HWND((nint)(value));

        public static explicit operator nuint(HWND value) => (nuint)(value.Value);

        public static explicit operator HWND(void* value) => new HWND((nint)(value));

        public static explicit operator void*(HWND value) => (void*)(value.Value);
    }
}
