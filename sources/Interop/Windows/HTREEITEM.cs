// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HTREEITEM : IEquatable<HTREEITEM>
    {
        public readonly nint Value;

        public HTREEITEM(nint value)
        {
            Value = ((nint)(value));
        }

        public HTREEITEM(nuint value)
        {
            Value = ((nint)(value));
        }

        public HTREEITEM(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HTREEITEM left, HTREEITEM right) => left.Value == right.Value;

        public static bool operator !=(HTREEITEM left, HTREEITEM right) => left.Value != right.Value;

        public static explicit operator HTREEITEM(nint value) => new HTREEITEM(value);

        public static explicit operator HTREEITEM(nuint value) => new HTREEITEM(value);

        public static explicit operator HTREEITEM(void* value) => new HTREEITEM(value);

        public static implicit operator nint(HTREEITEM value) => (nint)(value.Value);

        public static implicit operator nuint(HTREEITEM value) => (nuint)(value.Value);

        public static implicit operator void*(HTREEITEM value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HTREEITEM other) && Equals(other);

        public bool Equals(HTREEITEM other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
