// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HCERTSTORE
    {
        public static explicit operator HCERTSTORE(nuint value) => new HCERTSTORE((nint)(value));

        public static explicit operator nuint(HCERTSTORE value) => (nuint)(value.Value);

        public static explicit operator HCERTSTORE(void* value) => new HCERTSTORE((nint)(value));

        public static explicit operator void*(HCERTSTORE value) => (void*)(value.Value);
    }
}
