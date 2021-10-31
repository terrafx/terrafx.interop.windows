// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HDESK : IEquatable<HDESK>
    {
        public readonly nint Value;

        public HDESK(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HDESK left, HDESK right) => left.Value == right.Value;

        public static bool operator !=(HDESK left, HDESK right) => left.Value != right.Value;

        public static implicit operator HDESK(nint value) => new HDESK(value);

        public static implicit operator nint(HDESK value) => value.Value;

        public override bool Equals(object? obj) => (obj is HDESK other) && Equals(other);

        public bool Equals(HDESK other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
