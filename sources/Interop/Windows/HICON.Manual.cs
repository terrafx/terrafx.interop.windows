// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HICON
    {
        public static explicit operator HICON(nuint value) => new HICON((nint)(value));

        public static explicit operator nuint(HICON value) => (nuint)(value.Value);

        public static explicit operator HICON(void* value) => new HICON((nint)(value));

        public static explicit operator void*(HICON value) => (void*)(value.Value);
    }
}
