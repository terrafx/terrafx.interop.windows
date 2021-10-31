// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HTOUCHINPUT
    {
        public static explicit operator HTOUCHINPUT(nuint value) => new HTOUCHINPUT((nint)(value));

        public static explicit operator nuint(HTOUCHINPUT value) => (nuint)(value.Value);

        public static explicit operator HTOUCHINPUT(void* value) => new HTOUCHINPUT((nint)(value));

        public static explicit operator void*(HTOUCHINPUT value) => (void*)(value.Value);
    }
}
