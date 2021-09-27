// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/minwindef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HRGN : IEquatable<HRGN>
    {
        public static HRGN NULL => default;

        private void* _value;

        public HRGN(IntPtr value) : this(value.ToPointer())
        {
        }

        public HRGN(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HRGN l, HRGN r) => l._value == r._value;

        public static bool operator !=(HRGN l, HRGN r) => !(l == r);

        public static implicit operator HRGN(IntPtr value) => new HRGN(value);

        public static implicit operator HRGN(void* value) => new HRGN(value);

        public static implicit operator IntPtr(HRGN value) => new IntPtr(value._value);

        public static implicit operator void*(HRGN value) => value._value;

        public override bool Equals(object? obj) => (obj is HRGN other) && Equals(other);

        public bool Equals(HRGN other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
