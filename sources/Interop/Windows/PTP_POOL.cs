// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct PTP_POOL : IEquatable<PTP_POOL>
    {
        public readonly nint Value;

        public PTP_POOL(nint value)
        {
            Value = value;
        }

        public static bool operator ==(PTP_POOL left, PTP_POOL right) => left.Value == right.Value;

        public static bool operator !=(PTP_POOL left, PTP_POOL right) => left.Value != right.Value;

        public static implicit operator PTP_POOL(nint value) => new PTP_POOL(value);

        public static implicit operator nint(PTP_POOL value) => value.Value;

        public override bool Equals(object? obj) => (obj is PTP_POOL other) && Equals(other);

        public bool Equals(PTP_POOL other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
