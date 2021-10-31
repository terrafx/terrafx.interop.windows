// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HMONITOR
    {
        public static explicit operator HMONITOR(nuint value) => new HMONITOR((nint)(value));

        public static explicit operator nuint(HMONITOR value) => (nuint)(value.Value);

        public static explicit operator HMONITOR(void* value) => new HMONITOR((nint)(value));

        public static explicit operator void*(HMONITOR value) => (void*)(value.Value);
    }
}
