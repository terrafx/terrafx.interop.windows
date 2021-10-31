// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HPROPSHEETPAGE
    {
        public static explicit operator HPROPSHEETPAGE(nuint value) => new HPROPSHEETPAGE((nint)(value));

        public static explicit operator nuint(HPROPSHEETPAGE value) => (nuint)(value.Value);

        public static explicit operator HPROPSHEETPAGE(void* value) => new HPROPSHEETPAGE((nint)(value));

        public static explicit operator void*(HPROPSHEETPAGE value) => (void*)(value.Value);
    }
}
