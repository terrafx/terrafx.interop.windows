// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public partial struct BOOL
    {
        public static BOOL FALSE => Windows.FALSE;

        public static BOOL TRUE => Windows.TRUE;

        public static explicit operator BOOL(uint value) => new BOOL((int)(value));

        public static explicit operator uint(BOOL value) => (uint)(value.Value);

        public static bool operator false(BOOL value) => value.Value == 0;

        public static bool operator true(BOOL value) => value.Value != 0;
    }
}
