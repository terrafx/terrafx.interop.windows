// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HMIXER
    {
        public static explicit operator HMIXER(nuint value) => new HMIXER((nint)(value));

        public static explicit operator nuint(HMIXER value) => (nuint)(value.Value);

        public static explicit operator HMIXER(void* value) => new HMIXER((nint)(value));

        public static explicit operator void*(HMIXER value) => (void*)(value.Value);
    }
}
