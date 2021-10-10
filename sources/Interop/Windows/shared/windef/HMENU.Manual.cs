// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HMENU : IEquatable<HMENU>
    {
        public static HMENU NULL => default;

        private void* _value;

        public HMENU(IntPtr value) : this(value.ToPointer())
        {
        }

        public HMENU(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HMENU l, HMENU r) => l._value == r._value;

        public static bool operator !=(HMENU l, HMENU r) => !(l == r);

        public static implicit operator HMENU(IntPtr value) => new HMENU(value);

        public static implicit operator HMENU(void* value) => new HMENU(value);

        public static implicit operator IntPtr(HMENU value) => new IntPtr(value._value);

        public static implicit operator void*(HMENU value) => value._value;

        public override bool Equals(object? obj) => (obj is HMENU other) && Equals(other);

        public bool Equals(HMENU other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
