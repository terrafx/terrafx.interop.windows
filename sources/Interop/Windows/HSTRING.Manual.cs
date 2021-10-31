// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HSTRING
    {
        public static explicit operator HSTRING(nuint value) => new HSTRING((nint)(value));

        public static explicit operator nuint(HSTRING value) => (nuint)(value.Value);

        public static explicit operator HSTRING(void* value) => new HSTRING((nint)(value));

        public static explicit operator void*(HSTRING value) => (void*)(value.Value);
    }
}
