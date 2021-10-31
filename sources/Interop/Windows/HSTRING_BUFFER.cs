// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HSTRING_BUFFER : IEquatable<HSTRING_BUFFER>
    {
        public readonly nint Value;

        public HSTRING_BUFFER(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HSTRING_BUFFER left, HSTRING_BUFFER right) => left.Value == right.Value;

        public static bool operator !=(HSTRING_BUFFER left, HSTRING_BUFFER right) => left.Value != right.Value;

        public static implicit operator HSTRING_BUFFER(nint value) => new HSTRING_BUFFER(value);

        public static implicit operator nint(HSTRING_BUFFER value) => value.Value;

        public override bool Equals(object? obj) => (obj is HSTRING_BUFFER other) && Equals(other);

        public bool Equals(HSTRING_BUFFER other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
