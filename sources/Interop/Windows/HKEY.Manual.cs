// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HKEY
    {
        public static explicit operator HKEY(nuint value) => new HKEY((nint)(value));

        public static explicit operator nuint(HKEY value) => (nuint)(value.Value);

        public static explicit operator HKEY(void* value) => new HKEY((nint)(value));

        public static explicit operator void*(HKEY value) => (void*)(value.Value);
    }
}
