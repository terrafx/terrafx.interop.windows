// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct ROPARAMIIDHANDLE
    {
        public static explicit operator ROPARAMIIDHANDLE(nuint value) => new ROPARAMIIDHANDLE((nint)(value));

        public static explicit operator nuint(ROPARAMIIDHANDLE value) => (nuint)(value.Value);

        public static explicit operator ROPARAMIIDHANDLE(void* value) => new ROPARAMIIDHANDLE((nint)(value));

        public static explicit operator void*(ROPARAMIIDHANDLE value) => (void*)(value.Value);
    }
}
