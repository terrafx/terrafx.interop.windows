// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HSYNTHETICPOINTERDEVICE : IEquatable<HSYNTHETICPOINTERDEVICE>
    {
        public readonly nint Value;

        public HSYNTHETICPOINTERDEVICE(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HSYNTHETICPOINTERDEVICE left, HSYNTHETICPOINTERDEVICE right) => left.Value == right.Value;

        public static bool operator !=(HSYNTHETICPOINTERDEVICE left, HSYNTHETICPOINTERDEVICE right) => left.Value != right.Value;

        public static implicit operator HSYNTHETICPOINTERDEVICE(nint value) => new HSYNTHETICPOINTERDEVICE(value);

        public static implicit operator nint(HSYNTHETICPOINTERDEVICE value) => value.Value;

        public override bool Equals(object? obj) => (obj is HSYNTHETICPOINTERDEVICE other) && Equals(other);

        public bool Equals(HSYNTHETICPOINTERDEVICE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
