// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HWND : IEquatable<HWND>
    {
        public readonly nint Value;

        public HWND(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HWND left, HWND right) => left.Value == right.Value;

        public static bool operator !=(HWND left, HWND right) => left.Value != right.Value;

        public static implicit operator HWND(nint value) => new HWND(value);

        public static implicit operator nint(HWND value) => value.Value;

        public override bool Equals(object? obj) => (obj is HWND other) && Equals(other);

        public bool Equals(HWND other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
