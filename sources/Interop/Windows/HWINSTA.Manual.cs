// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HWINSTA
    {
        public static explicit operator HWINSTA(nuint value) => new HWINSTA((nint)(value));

        public static explicit operator nuint(HWINSTA value) => (nuint)(value.Value);

        public static explicit operator HWINSTA(void* value) => new HWINSTA((nint)(value));

        public static explicit operator void*(HWINSTA value) => (void*)(value.Value);
    }
}
