// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HMODULE
    {
        public HMODULE(HINSTANCE value)
        {
            Value = value.Value;
        }

        public static explicit operator HMODULE(HINSTANCE value) => new HMODULE(value);

        public static implicit operator HINSTANCE(HMODULE value) => (HINSTANCE)(value.Value);
    }
}
