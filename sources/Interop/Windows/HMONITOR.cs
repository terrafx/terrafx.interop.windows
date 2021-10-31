// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HMONITOR : IEquatable<HMONITOR>
    {
        public readonly nint Value;

        public HMONITOR(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HMONITOR left, HMONITOR right) => left.Value == right.Value;

        public static bool operator !=(HMONITOR left, HMONITOR right) => left.Value != right.Value;

        public static implicit operator HMONITOR(nint value) => new HMONITOR(value);

        public static implicit operator nint(HMONITOR value) => value.Value;

        public override bool Equals(object? obj) => (obj is HMONITOR other) && Equals(other);

        public bool Equals(HMONITOR other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
