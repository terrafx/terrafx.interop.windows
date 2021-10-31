// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HSWDEVICE : IEquatable<HSWDEVICE>
    {
        public readonly nint Value;

        public HSWDEVICE(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HSWDEVICE left, HSWDEVICE right) => left.Value == right.Value;

        public static bool operator !=(HSWDEVICE left, HSWDEVICE right) => left.Value != right.Value;

        public static implicit operator HSWDEVICE(nint value) => new HSWDEVICE(value);

        public static implicit operator nint(HSWDEVICE value) => value.Value;

        public override bool Equals(object? obj) => (obj is HSWDEVICE other) && Equals(other);

        public bool Equals(HSWDEVICE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
