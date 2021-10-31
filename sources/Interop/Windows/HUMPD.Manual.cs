// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HUMPD
    {
        public static explicit operator HUMPD(nuint value) => new HUMPD((nint)(value));

        public static explicit operator nuint(HUMPD value) => (nuint)(value.Value);

        public static explicit operator HUMPD(void* value) => new HUMPD((nint)(value));

        public static explicit operator void*(HUMPD value) => (void*)(value.Value);
    }
}
