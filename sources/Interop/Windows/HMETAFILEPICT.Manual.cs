// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HMETAFILEPICT
    {
        public static explicit operator HMETAFILEPICT(nuint value) => new HMETAFILEPICT((nint)(value));

        public static explicit operator nuint(HMETAFILEPICT value) => (nuint)(value.Value);

        public static explicit operator HMETAFILEPICT(void* value) => new HMETAFILEPICT((nint)(value));

        public static explicit operator void*(HMETAFILEPICT value) => (void*)(value.Value);
    }
}
