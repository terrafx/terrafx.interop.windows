// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HDESK
    {
        public static explicit operator HDESK(nuint value) => new HDESK((nint)(value));

        public static explicit operator nuint(HDESK value) => (nuint)(value.Value);

        public static explicit operator HDESK(void* value) => new HDESK((nint)(value));

        public static explicit operator void*(HDESK value) => (void*)(value.Value);
    }
}
