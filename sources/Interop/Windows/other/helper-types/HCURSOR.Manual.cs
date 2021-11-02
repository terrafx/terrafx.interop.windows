// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HCURSOR
    {
        public HCURSOR(HICON value)
        {
            Value = value.Value;
        }

        public static explicit operator HCURSOR(HICON value) => new HCURSOR(value);

        public static implicit operator HICON(HCURSOR value) => (HICON)(value.Value);
    }
}
