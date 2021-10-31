// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HDROP
    {
        public static explicit operator HDROP(nuint value) => new HDROP((nint)(value));

        public static explicit operator nuint(HDROP value) => (nuint)(value.Value);

        public static explicit operator HDROP(void* value) => new HDROP((nint)(value));

        public static explicit operator void*(HDROP value) => (void*)(value.Value);
    }
}
