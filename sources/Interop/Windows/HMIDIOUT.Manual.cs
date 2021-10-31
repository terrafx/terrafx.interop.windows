// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HMIDIOUT
    {
        public static explicit operator HMIDIOUT(nuint value) => new HMIDIOUT((nint)(value));

        public static explicit operator nuint(HMIDIOUT value) => (nuint)(value.Value);

        public static explicit operator HMIDIOUT(void* value) => new HMIDIOUT((nint)(value));

        public static explicit operator void*(HMIDIOUT value) => (void*)(value.Value);
    }
}
