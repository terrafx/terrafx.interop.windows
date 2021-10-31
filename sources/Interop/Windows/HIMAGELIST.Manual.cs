// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HIMAGELIST
    {
        public static explicit operator HIMAGELIST(nuint value) => new HIMAGELIST((nint)(value));

        public static explicit operator nuint(HIMAGELIST value) => (nuint)(value.Value);

        public static explicit operator HIMAGELIST(void* value) => new HIMAGELIST((nint)(value));

        public static explicit operator void*(HIMAGELIST value) => (void*)(value.Value);
    }
}
