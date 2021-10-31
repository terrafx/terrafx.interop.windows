// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public partial struct BOOL
    {
        public BOOL(uint value)
        {
            Value = ((int)(value));
        }

        public static BOOL FALSE => Windows.FALSE;

        public static BOOL TRUE => Windows.TRUE;

        public static explicit operator BOOL(uint value) => new BOOL(value);

        public static explicit operator uint(BOOL value) => (uint)(value.Value);
    }
}
