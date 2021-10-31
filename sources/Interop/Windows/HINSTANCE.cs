// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HINSTANCE : IEquatable<HINSTANCE>
    {
        public readonly nint Value;

        public HINSTANCE(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HINSTANCE left, HINSTANCE right) => left.Value == right.Value;

        public static bool operator !=(HINSTANCE left, HINSTANCE right) => left.Value != right.Value;

        public static implicit operator HINSTANCE(nint value) => new HINSTANCE(value);

        public static implicit operator nint(HINSTANCE value) => value.Value;

        public override bool Equals(object? obj) => (obj is HINSTANCE other) && Equals(other);

        public bool Equals(HINSTANCE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
