// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct PTP_CLEANUP_GROUP : IEquatable<PTP_CLEANUP_GROUP>
    {
        public readonly nint Value;

        public PTP_CLEANUP_GROUP(nint value)
        {
            Value = value;
        }

        public static bool operator ==(PTP_CLEANUP_GROUP left, PTP_CLEANUP_GROUP right) => left.Value == right.Value;

        public static bool operator !=(PTP_CLEANUP_GROUP left, PTP_CLEANUP_GROUP right) => left.Value != right.Value;

        public static implicit operator PTP_CLEANUP_GROUP(nint value) => new PTP_CLEANUP_GROUP(value);

        public static implicit operator nint(PTP_CLEANUP_GROUP value) => value.Value;

        public override bool Equals(object? obj) => (obj is PTP_CLEANUP_GROUP other) && Equals(other);

        public bool Equals(PTP_CLEANUP_GROUP other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
