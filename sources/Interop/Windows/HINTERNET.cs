// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HINTERNET : IEquatable<HINTERNET>
    {
        public readonly nint Value;

        public HINTERNET(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HINTERNET left, HINTERNET right) => left.Value == right.Value;

        public static bool operator !=(HINTERNET left, HINTERNET right) => left.Value != right.Value;

        public static implicit operator HINTERNET(nint value) => new HINTERNET(value);

        public static implicit operator nint(HINTERNET value) => value.Value;

        public override bool Equals(object? obj) => (obj is HINTERNET other) && Equals(other);

        public bool Equals(HINTERNET other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
