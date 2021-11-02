// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HBITMAP : IEquatable<HBITMAP>
    {
        public HBITMAP(HGDIOBJ value)
        {
            Value = value.Value;
        }

        public static explicit operator HBITMAP(HGDIOBJ value) => new HBITMAP(value);

        public static implicit operator HGDIOBJ(HBITMAP value) => (HGDIOBJ)(value.Value);
    }
}
