// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HPEN : IEquatable<HPEN>
    {
        public HPEN(HGDIOBJ value)
        {
            Value = value.Value;
        }

        public static explicit operator HPEN(HGDIOBJ value) => new HPEN(value);

        public static implicit operator HGDIOBJ(HPEN value) => (HGDIOBJ)(value.Value);
    }
}
