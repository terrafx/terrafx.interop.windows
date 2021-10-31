// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HDEVNOTIFY : IEquatable<HDEVNOTIFY>
    {
        public readonly nint Value;

        public HDEVNOTIFY(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HDEVNOTIFY left, HDEVNOTIFY right) => left.Value == right.Value;

        public static bool operator !=(HDEVNOTIFY left, HDEVNOTIFY right) => left.Value != right.Value;

        public static implicit operator HDEVNOTIFY(nint value) => new HDEVNOTIFY(value);

        public static implicit operator nint(HDEVNOTIFY value) => value.Value;

        public override bool Equals(object? obj) => (obj is HDEVNOTIFY other) && Equals(other);

        public bool Equals(HDEVNOTIFY other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
