// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HCOLORSPACE
    {
        public static explicit operator HCOLORSPACE(nuint value) => new HCOLORSPACE((nint)(value));

        public static explicit operator nuint(HCOLORSPACE value) => (nuint)(value.Value);

        public static explicit operator HCOLORSPACE(void* value) => new HCOLORSPACE((nint)(value));

        public static explicit operator void*(HCOLORSPACE value) => (void*)(value.Value);
    }
}
