// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HIFTIMESTAMPCHANGE
    {
        public static explicit operator HIFTIMESTAMPCHANGE(nuint value) => new HIFTIMESTAMPCHANGE((nint)(value));

        public static explicit operator nuint(HIFTIMESTAMPCHANGE value) => (nuint)(value.Value);

        public static explicit operator HIFTIMESTAMPCHANGE(void* value) => new HIFTIMESTAMPCHANGE((nint)(value));

        public static explicit operator void*(HIFTIMESTAMPCHANGE value) => (void*)(value.Value);
    }
}
