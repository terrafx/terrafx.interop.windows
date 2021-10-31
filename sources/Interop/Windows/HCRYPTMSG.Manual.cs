// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTMSG
    {
        public static explicit operator HCRYPTMSG(nuint value) => new HCRYPTMSG((nint)(value));

        public static explicit operator nuint(HCRYPTMSG value) => (nuint)(value.Value);

        public static explicit operator HCRYPTMSG(void* value) => new HCRYPTMSG((nint)(value));

        public static explicit operator void*(HCRYPTMSG value) => (void*)(value.Value);
    }
}
