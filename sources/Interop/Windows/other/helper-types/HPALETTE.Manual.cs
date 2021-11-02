// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HPALETTE : IEquatable<HPALETTE>
    {
        public HPALETTE(HGDIOBJ value)
        {
            Value = value.Value;
        }

        public static explicit operator HPALETTE(HGDIOBJ value) => new HPALETTE(value);

        public static implicit operator HGDIOBJ(HPALETTE value) => (HGDIOBJ)(value.Value);
    }
}
