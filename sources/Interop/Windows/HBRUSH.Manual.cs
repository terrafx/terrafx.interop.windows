// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HBRUSH : IEquatable<HBRUSH>
    {
        public HBRUSH(HGDIOBJ value)
        {
            Value = value.Value;
        }

        public static explicit operator HBRUSH(HGDIOBJ value) => new HBRUSH(value);

        public static implicit operator HGDIOBJ(HBRUSH value) => (HGDIOBJ)(value.Value);
    }
}
