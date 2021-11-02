// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HFONT : IEquatable<HFONT>
    {
        public HFONT(HGDIOBJ value)
        {
            Value = value.Value;
        }

        public static explicit operator HFONT(HGDIOBJ value) => new HFONT(value);

        public static implicit operator HGDIOBJ(HFONT value) => (HGDIOBJ)(value.Value);
    }
}
