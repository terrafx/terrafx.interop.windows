// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HGDIOBJ
    {
        public static explicit operator HGDIOBJ(nuint value) => new HGDIOBJ((nint)(value));

        public static explicit operator nuint(HGDIOBJ value) => (nuint)(value.Value);

        public static explicit operator HGDIOBJ(void* value) => new HGDIOBJ((nint)(value));

        public static explicit operator void*(HGDIOBJ value) => (void*)(value.Value);
    }
}
