// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HSEMAPHORE
    {
        public static explicit operator HSEMAPHORE(nuint value) => new HSEMAPHORE((nint)(value));

        public static explicit operator nuint(HSEMAPHORE value) => (nuint)(value.Value);

        public static explicit operator HSEMAPHORE(void* value) => new HSEMAPHORE((nint)(value));

        public static explicit operator void*(HSEMAPHORE value) => (void*)(value.Value);
    }
}
