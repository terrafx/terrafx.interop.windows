// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HRSRC : IEquatable<HRSRC>
    {
        public readonly nint Value;

        public HRSRC(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HRSRC left, HRSRC right) => left.Value == right.Value;

        public static bool operator !=(HRSRC left, HRSRC right) => left.Value != right.Value;

        public static implicit operator HRSRC(nint value) => new HRSRC(value);

        public static implicit operator nint(HRSRC value) => value.Value;

        public override bool Equals(object? obj) => (obj is HRSRC other) && Equals(other);

        public bool Equals(HRSRC other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
