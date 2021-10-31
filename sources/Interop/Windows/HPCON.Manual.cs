// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HPCON
    {
        public static explicit operator HPCON(nuint value) => new HPCON((nint)(value));

        public static explicit operator nuint(HPCON value) => (nuint)(value.Value);

        public static explicit operator HPCON(void* value) => new HPCON((nint)(value));

        public static explicit operator void*(HPCON value) => (void*)(value.Value);
    }
}
