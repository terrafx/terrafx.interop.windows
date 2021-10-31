// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HTREEITEM : IEquatable<HTREEITEM>
    {
        public readonly nint Value;

        public HTREEITEM(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HTREEITEM left, HTREEITEM right) => left.Value == right.Value;

        public static bool operator !=(HTREEITEM left, HTREEITEM right) => left.Value != right.Value;

        public static implicit operator HTREEITEM(nint value) => new HTREEITEM(value);

        public static implicit operator nint(HTREEITEM value) => value.Value;

        public override bool Equals(object? obj) => (obj is HTREEITEM other) && Equals(other);

        public bool Equals(HTREEITEM other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
