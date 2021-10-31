// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HSTR
    {
        public static explicit operator HSTR(nuint value) => new HSTR((nint)(value));

        public static explicit operator nuint(HSTR value) => (nuint)(value.Value);

        public static explicit operator HSTR(void* value) => new HSTR((nint)(value));

        public static explicit operator void*(HSTR value) => (void*)(value.Value);
    }
}
