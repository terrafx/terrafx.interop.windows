// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct InstanceHandle : IEquatable<InstanceHandle>
    {
        public readonly ulong Value;

        public InstanceHandle(ulong value)
        {
            Value = value;
        }

        public InstanceHandle(long value)
        {
            Value = ((ulong)(value));
        }

        public static bool operator ==(InstanceHandle left, InstanceHandle right) => left.Value == right.Value;

        public static bool operator !=(InstanceHandle left, InstanceHandle right) => left.Value != right.Value;

        public static explicit operator InstanceHandle(long value) => new InstanceHandle(value);

        public static explicit operator long(InstanceHandle value) => (long)(value.Value);

        public static implicit operator InstanceHandle(ulong value) => new InstanceHandle(value);

        public static implicit operator ulong(InstanceHandle value) => value.Value;

        public override bool Equals(object? obj) => (obj is InstanceHandle other) && Equals(other);

        public bool Equals(InstanceHandle other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
