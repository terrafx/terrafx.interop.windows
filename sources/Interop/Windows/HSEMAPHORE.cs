// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HSEMAPHORE : IEquatable<HSEMAPHORE>
    {
        public readonly nint Value;

        public HSEMAPHORE(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HSEMAPHORE left, HSEMAPHORE right) => left.Value == right.Value;

        public static bool operator !=(HSEMAPHORE left, HSEMAPHORE right) => left.Value != right.Value;

        public static implicit operator HSEMAPHORE(nint value) => new HSEMAPHORE(value);

        public static implicit operator nint(HSEMAPHORE value) => value.Value;

        public override bool Equals(object? obj) => (obj is HSEMAPHORE other) && Equals(other);

        public bool Equals(HSEMAPHORE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
