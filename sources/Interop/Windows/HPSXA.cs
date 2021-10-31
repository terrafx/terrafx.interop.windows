// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HPSXA : IEquatable<HPSXA>
    {
        public readonly nint Value;

        public HPSXA(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HPSXA left, HPSXA right) => left.Value == right.Value;

        public static bool operator !=(HPSXA left, HPSXA right) => left.Value != right.Value;

        public static implicit operator HPSXA(nint value) => new HPSXA(value);

        public static implicit operator nint(HPSXA value) => value.Value;

        public override bool Equals(object? obj) => (obj is HPSXA other) && Equals(other);

        public bool Equals(HPSXA other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
