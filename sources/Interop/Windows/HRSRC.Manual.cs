// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HRSRC
    {
        public static explicit operator HRSRC(nuint value) => new HRSRC((nint)(value));

        public static explicit operator nuint(HRSRC value) => (nuint)(value.Value);

        public static explicit operator HRSRC(void* value) => new HRSRC((nint)(value));

        public static explicit operator void*(HRSRC value) => (void*)(value.Value);
    }
}
