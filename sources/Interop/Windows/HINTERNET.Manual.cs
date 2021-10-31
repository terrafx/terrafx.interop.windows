// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HINTERNET
    {
        public static explicit operator HINTERNET(nuint value) => new HINTERNET((nint)(value));

        public static explicit operator nuint(HINTERNET value) => (nuint)(value.Value);

        public static explicit operator HINTERNET(void* value) => new HINTERNET((nint)(value));

        public static explicit operator void*(HINTERNET value) => (void*)(value.Value);
    }
}
