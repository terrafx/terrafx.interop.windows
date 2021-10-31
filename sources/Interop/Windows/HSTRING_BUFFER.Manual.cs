// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HSTRING_BUFFER
    {
        public static explicit operator HSTRING_BUFFER(nuint value) => new HSTRING_BUFFER((nint)(value));

        public static explicit operator nuint(HSTRING_BUFFER value) => (nuint)(value.Value);

        public static explicit operator HSTRING_BUFFER(void* value) => new HSTRING_BUFFER((nint)(value));

        public static explicit operator void*(HSTRING_BUFFER value) => (void*)(value.Value);
    }
}
