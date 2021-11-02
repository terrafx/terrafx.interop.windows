// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct LPARAM
    {
        public static explicit operator LPARAM(void* value) => new LPARAM((nint)(value));

        public static implicit operator void*(LPARAM value) => (void*)(value.Value);
    }
}
