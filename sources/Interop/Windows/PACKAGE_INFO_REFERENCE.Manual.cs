// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct PACKAGE_INFO_REFERENCE
    {
        public static explicit operator PACKAGE_INFO_REFERENCE(nuint value) => new PACKAGE_INFO_REFERENCE((nint)(value));

        public static explicit operator nuint(PACKAGE_INFO_REFERENCE value) => (nuint)(value.Value);

        public static explicit operator PACKAGE_INFO_REFERENCE(void* value) => new PACKAGE_INFO_REFERENCE((nint)(value));

        public static explicit operator void*(PACKAGE_INFO_REFERENCE value) => (void*)(value.Value);
    }
}
