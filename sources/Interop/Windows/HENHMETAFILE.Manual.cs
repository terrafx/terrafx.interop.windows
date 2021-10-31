// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HENHMETAFILE
    {
        public static explicit operator HENHMETAFILE(nuint value) => new HENHMETAFILE((nint)(value));

        public static explicit operator nuint(HENHMETAFILE value) => (nuint)(value.Value);

        public static explicit operator HENHMETAFILE(void* value) => new HENHMETAFILE((nint)(value));

        public static explicit operator void*(HENHMETAFILE value) => (void*)(value.Value);
    }
}
