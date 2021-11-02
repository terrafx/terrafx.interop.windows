// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct WPARAM
    {
        public static explicit operator WPARAM(void* value) => new WPARAM((nuint)(value));

        public static implicit operator void*(WPARAM value) => (void*)(value.Value);
    }
}
