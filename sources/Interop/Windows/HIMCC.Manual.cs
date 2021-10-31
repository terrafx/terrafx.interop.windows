// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HIMCC
    {
        public static explicit operator HIMCC(nuint value) => new HIMCC((nint)(value));

        public static explicit operator nuint(HIMCC value) => (nuint)(value.Value);

        public static explicit operator HIMCC(void* value) => new HIMCC((nint)(value));

        public static explicit operator void*(HIMCC value) => (void*)(value.Value);
    }
}
