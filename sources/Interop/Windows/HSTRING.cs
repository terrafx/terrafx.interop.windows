// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HSTRING : IEquatable<HSTRING>
    {
        public readonly nint Value;

        public HSTRING(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HSTRING left, HSTRING right) => left.Value == right.Value;

        public static bool operator !=(HSTRING left, HSTRING right) => left.Value != right.Value;

        public static implicit operator HSTRING(nint value) => new HSTRING(value);

        public static implicit operator nint(HSTRING value) => value.Value;

        public override bool Equals(object? obj) => (obj is HSTRING other) && Equals(other);

        public bool Equals(HSTRING other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
