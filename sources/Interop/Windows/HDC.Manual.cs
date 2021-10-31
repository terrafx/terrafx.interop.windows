// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HDC
    {
        public static explicit operator HDC(nuint value) => new HDC((nint)(value));

        public static explicit operator nuint(HDC value) => (nuint)(value.Value);

        public static explicit operator HDC(void* value) => new HDC((nint)(value));

        public static explicit operator void*(HDC value) => (void*)(value.Value);
    }
}
