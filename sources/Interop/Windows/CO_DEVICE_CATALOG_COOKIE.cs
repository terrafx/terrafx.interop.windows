// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct CO_DEVICE_CATALOG_COOKIE : IEquatable<CO_DEVICE_CATALOG_COOKIE>
    {
        public readonly nint Value;

        public CO_DEVICE_CATALOG_COOKIE(nint value)
        {
            Value = value;
        }

        public static bool operator ==(CO_DEVICE_CATALOG_COOKIE left, CO_DEVICE_CATALOG_COOKIE right) => left.Value == right.Value;

        public static bool operator !=(CO_DEVICE_CATALOG_COOKIE left, CO_DEVICE_CATALOG_COOKIE right) => left.Value != right.Value;

        public static implicit operator CO_DEVICE_CATALOG_COOKIE(nint value) => new CO_DEVICE_CATALOG_COOKIE(value);

        public static implicit operator nint(CO_DEVICE_CATALOG_COOKIE value) => value.Value;

        public override bool Equals(object? obj) => (obj is CO_DEVICE_CATALOG_COOKIE other) && Equals(other);

        public bool Equals(CO_DEVICE_CATALOG_COOKIE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
