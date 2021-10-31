// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HMIXEROBJ
    {
        public static explicit operator HMIXEROBJ(nuint value) => new HMIXEROBJ((nint)(value));

        public static explicit operator nuint(HMIXEROBJ value) => (nuint)(value.Value);

        public static explicit operator HMIXEROBJ(void* value) => new HMIXEROBJ((nint)(value));

        public static explicit operator void*(HMIXEROBJ value) => (void*)(value.Value);
    }
}
