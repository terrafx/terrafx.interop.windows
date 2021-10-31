// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HHANDLE
    {
        public static explicit operator HHANDLE(nuint value) => new HHANDLE((nint)(value));

        public static explicit operator nuint(HHANDLE value) => (nuint)(value.Value);

        public static explicit operator HHANDLE(void* value) => new HHANDLE((nint)(value));

        public static explicit operator void*(HHANDLE value) => (void*)(value.Value);
    }
}
