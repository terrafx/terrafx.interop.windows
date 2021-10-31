// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HSWDEVICE
    {
        public static explicit operator HSWDEVICE(nuint value) => new HSWDEVICE((nint)(value));

        public static explicit operator nuint(HSWDEVICE value) => (nuint)(value.Value);

        public static explicit operator HSWDEVICE(void* value) => new HSWDEVICE((nint)(value));

        public static explicit operator void*(HSWDEVICE value) => (void*)(value.Value);
    }
}
