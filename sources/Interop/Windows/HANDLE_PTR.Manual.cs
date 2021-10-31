// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HANDLE_PTR
    {
        public static explicit operator HANDLE_PTR(nuint value) => new HANDLE_PTR((nint)(value));

        public static explicit operator nuint(HANDLE_PTR value) => (nuint)(value.Value);

        public static explicit operator HANDLE_PTR(void* value) => new HANDLE_PTR((nint)(value));

        public static explicit operator void*(HANDLE_PTR value) => (void*)(value.Value);
    }
}
