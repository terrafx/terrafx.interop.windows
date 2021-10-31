// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HIMCC : IEquatable<HIMCC>
    {
        public readonly nint Value;

        public HIMCC(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HIMCC left, HIMCC right) => left.Value == right.Value;

        public static bool operator !=(HIMCC left, HIMCC right) => left.Value != right.Value;

        public static implicit operator HIMCC(nint value) => new HIMCC(value);

        public static implicit operator nint(HIMCC value) => value.Value;

        public override bool Equals(object? obj) => (obj is HIMCC other) && Equals(other);

        public bool Equals(HIMCC other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
