// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTDEFAULTCONTEXT
    {
        public static explicit operator HCRYPTDEFAULTCONTEXT(nuint value) => new HCRYPTDEFAULTCONTEXT((nint)(value));

        public static explicit operator nuint(HCRYPTDEFAULTCONTEXT value) => (nuint)(value.Value);

        public static explicit operator HCRYPTDEFAULTCONTEXT(void* value) => new HCRYPTDEFAULTCONTEXT((nint)(value));

        public static explicit operator void*(HCRYPTDEFAULTCONTEXT value) => (void*)(value.Value);
    }
}
