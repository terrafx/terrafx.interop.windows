// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HSPFILELOG
    {
        public static explicit operator HSPFILELOG(nuint value) => new HSPFILELOG((nint)(value));

        public static explicit operator nuint(HSPFILELOG value) => (nuint)(value.Value);

        public static explicit operator HSPFILELOG(void* value) => new HSPFILELOG((nint)(value));

        public static explicit operator void*(HSPFILELOG value) => (void*)(value.Value);
    }
}
