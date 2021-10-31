// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HDSKSPC
    {
        public static explicit operator HDSKSPC(nuint value) => new HDSKSPC((nint)(value));

        public static explicit operator nuint(HDSKSPC value) => (nuint)(value.Value);

        public static explicit operator HDSKSPC(void* value) => new HDSKSPC((nint)(value));

        public static explicit operator void*(HDSKSPC value) => (void*)(value.Value);
    }
}
