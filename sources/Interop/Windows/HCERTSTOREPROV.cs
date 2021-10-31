// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HCERTSTOREPROV : IEquatable<HCERTSTOREPROV>
    {
        public readonly nint Value;

        public HCERTSTOREPROV(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HCERTSTOREPROV left, HCERTSTOREPROV right) => left.Value == right.Value;

        public static bool operator !=(HCERTSTOREPROV left, HCERTSTOREPROV right) => left.Value != right.Value;

        public static implicit operator HCERTSTOREPROV(nint value) => new HCERTSTOREPROV(value);

        public static implicit operator nint(HCERTSTOREPROV value) => value.Value;

        public override bool Equals(object? obj) => (obj is HCERTSTOREPROV other) && Equals(other);

        public bool Equals(HCERTSTOREPROV other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
