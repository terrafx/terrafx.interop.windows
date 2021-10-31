// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HMETAFILE
    {
        public static explicit operator HMETAFILE(nuint value) => new HMETAFILE((nint)(value));

        public static explicit operator nuint(HMETAFILE value) => (nuint)(value.Value);

        public static explicit operator HMETAFILE(void* value) => new HMETAFILE((nint)(value));

        public static explicit operator void*(HMETAFILE value) => (void*)(value.Value);
    }
}
