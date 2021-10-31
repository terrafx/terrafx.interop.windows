// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public partial struct MSIHANDLE
    {
        public static explicit operator MSIHANDLE(int value) => new MSIHANDLE((uint)(value));

        public static explicit operator int(MSIHANDLE value) => (int)(value.Value);
    }
}
