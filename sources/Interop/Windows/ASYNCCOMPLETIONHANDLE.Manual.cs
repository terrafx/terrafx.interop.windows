// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct ASYNCCOMPLETIONHANDLE
    {
        public static explicit operator ASYNCCOMPLETIONHANDLE(nint value) => new ASYNCCOMPLETIONHANDLE((nuint)(value));

        public static explicit operator nint(ASYNCCOMPLETIONHANDLE value) => (nint)(value.Value);

        public static explicit operator ASYNCCOMPLETIONHANDLE(void* value) => new ASYNCCOMPLETIONHANDLE((nuint)(value));

        public static explicit operator void*(ASYNCCOMPLETIONHANDLE value) => (void*)(value.Value);
    }
}
