// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTHASH
    {
        public static explicit operator HCRYPTHASH(nuint value) => new HCRYPTHASH((nint)(value));

        public static explicit operator nuint(HCRYPTHASH value) => (nuint)(value.Value);

        public static explicit operator HCRYPTHASH(void* value) => new HCRYPTHASH((nint)(value));

        public static explicit operator void*(HCRYPTHASH value) => (void*)(value.Value);
    }
}
