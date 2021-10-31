// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct COMPRESSOR_HANDLE
    {
        public static explicit operator COMPRESSOR_HANDLE(nuint value) => new COMPRESSOR_HANDLE((nint)(value));

        public static explicit operator nuint(COMPRESSOR_HANDLE value) => (nuint)(value.Value);

        public static explicit operator COMPRESSOR_HANDLE(void* value) => new COMPRESSOR_HANDLE((nint)(value));

        public static explicit operator void*(COMPRESSOR_HANDLE value) => (void*)(value.Value);
    }
}
