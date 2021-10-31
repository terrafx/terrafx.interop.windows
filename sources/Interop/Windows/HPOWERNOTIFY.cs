// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HPOWERNOTIFY : IEquatable<HPOWERNOTIFY>
    {
        public readonly nint Value;

        public HPOWERNOTIFY(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HPOWERNOTIFY left, HPOWERNOTIFY right) => left.Value == right.Value;

        public static bool operator !=(HPOWERNOTIFY left, HPOWERNOTIFY right) => left.Value != right.Value;

        public static implicit operator HPOWERNOTIFY(nint value) => new HPOWERNOTIFY(value);

        public static implicit operator nint(HPOWERNOTIFY value) => value.Value;

        public override bool Equals(object? obj) => (obj is HPOWERNOTIFY other) && Equals(other);

        public bool Equals(HPOWERNOTIFY other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
