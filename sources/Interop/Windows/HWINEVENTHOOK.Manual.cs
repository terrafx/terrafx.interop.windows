// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HWINEVENTHOOK
    {
        public static explicit operator HWINEVENTHOOK(nuint value) => new HWINEVENTHOOK((nint)(value));

        public static explicit operator nuint(HWINEVENTHOOK value) => (nuint)(value.Value);

        public static explicit operator HWINEVENTHOOK(void* value) => new HWINEVENTHOOK((nint)(value));

        public static explicit operator void*(HWINEVENTHOOK value) => (void*)(value.Value);
    }
}
