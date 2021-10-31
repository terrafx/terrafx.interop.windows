// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HMIDISTRM
    {
        public static explicit operator HMIDISTRM(nuint value) => new HMIDISTRM((nint)(value));

        public static explicit operator nuint(HMIDISTRM value) => (nuint)(value.Value);

        public static explicit operator HMIDISTRM(void* value) => new HMIDISTRM((nint)(value));

        public static explicit operator void*(HMIDISTRM value) => (void*)(value.Value);
    }
}
