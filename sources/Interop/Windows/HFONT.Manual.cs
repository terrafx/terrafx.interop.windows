// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HFONT
    {
        public static explicit operator HFONT(nuint value) => new HFONT((nint)(value));

        public static explicit operator nuint(HFONT value) => (nuint)(value.Value);

        public static explicit operator HFONT(void* value) => new HFONT((nint)(value));

        public static explicit operator void*(HFONT value) => (void*)(value.Value);
    }
}
