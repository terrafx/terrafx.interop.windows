// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct SPSTATEHANDLE
    {
        public static explicit operator SPSTATEHANDLE(nuint value) => new SPSTATEHANDLE((nint)(value));

        public static explicit operator nuint(SPSTATEHANDLE value) => (nuint)(value.Value);

        public static explicit operator SPSTATEHANDLE(void* value) => new SPSTATEHANDLE((nint)(value));

        public static explicit operator void*(SPSTATEHANDLE value) => (void*)(value.Value);
    }
}
