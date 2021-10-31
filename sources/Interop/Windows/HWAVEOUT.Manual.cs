// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HWAVEOUT
    {
        public static explicit operator HWAVEOUT(nuint value) => new HWAVEOUT((nint)(value));

        public static explicit operator nuint(HWAVEOUT value) => (nuint)(value.Value);

        public static explicit operator HWAVEOUT(void* value) => new HWAVEOUT((nint)(value));

        public static explicit operator void*(HWAVEOUT value) => (void*)(value.Value);
    }
}
