// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HPSSWALK
    {
        public static explicit operator HPSSWALK(nuint value) => new HPSSWALK((nint)(value));

        public static explicit operator nuint(HPSSWALK value) => (nuint)(value.Value);

        public static explicit operator HPSSWALK(void* value) => new HPSSWALK((nint)(value));

        public static explicit operator void*(HPSSWALK value) => (void*)(value.Value);
    }
}
