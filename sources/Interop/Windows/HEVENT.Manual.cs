// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HEVENT
    {
        public static explicit operator HEVENT(nuint value) => new HEVENT((nint)(value));

        public static explicit operator nuint(HEVENT value) => (nuint)(value.Value);

        public static explicit operator HEVENT(void* value) => new HEVENT((nint)(value));

        public static explicit operator void*(HEVENT value) => (void*)(value.Value);
    }
}
