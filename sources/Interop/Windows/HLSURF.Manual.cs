// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HLSURF
    {
        public static explicit operator HLSURF(nuint value) => new HLSURF((nint)(value));

        public static explicit operator nuint(HLSURF value) => (nuint)(value.Value);

        public static explicit operator HLSURF(void* value) => new HLSURF((nint)(value));

        public static explicit operator void*(HLSURF value) => (void*)(value.Value);
    }
}
