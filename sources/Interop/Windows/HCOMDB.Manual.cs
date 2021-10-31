// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HCOMDB
    {
        public static explicit operator HCOMDB(nuint value) => new HCOMDB((nint)(value));

        public static explicit operator nuint(HCOMDB value) => (nuint)(value.Value);

        public static explicit operator HCOMDB(void* value) => new HCOMDB((nint)(value));

        public static explicit operator void*(HCOMDB value) => (void*)(value.Value);
    }
}
