// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HRGN : IEquatable<HRGN>
    {
        public HRGN(HGDIOBJ value)
        {
            Value = value.Value;
        }

        public static explicit operator HRGN(HGDIOBJ value) => new HRGN(value);

        public static implicit operator HGDIOBJ(HRGN value) => (HGDIOBJ)(value.Value);
    }
}
