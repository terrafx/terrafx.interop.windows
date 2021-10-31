// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HANDLE
    {
        public static explicit operator HANDLE(nuint value) => new HANDLE((nint)(value));

        public static explicit operator nuint(HANDLE value) => (nuint)(value.Value);

        public static explicit operator HANDLE(void* value) => new HANDLE((nint)(value));

        public static explicit operator void*(HANDLE value) => (void*)(value.Value);
    }
}
