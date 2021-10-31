// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HICON : IEquatable<HICON>
    {
        public readonly nint Value;

        public HICON(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HICON left, HICON right) => left.Value == right.Value;

        public static bool operator !=(HICON left, HICON right) => left.Value != right.Value;

        public static implicit operator HICON(nint value) => new HICON(value);

        public static implicit operator nint(HICON value) => value.Value;

        public override bool Equals(object? obj) => (obj is HICON other) && Equals(other);

        public bool Equals(HICON other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
