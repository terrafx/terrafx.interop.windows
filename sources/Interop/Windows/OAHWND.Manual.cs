// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct OAHWND
    {
        public static explicit operator OAHWND(nuint value) => new OAHWND((nint)(value));

        public static explicit operator nuint(OAHWND value) => (nuint)(value.Value);

        public static explicit operator OAHWND(void* value) => new OAHWND((nint)(value));

        public static explicit operator void*(OAHWND value) => (void*)(value.Value);
    }
}
