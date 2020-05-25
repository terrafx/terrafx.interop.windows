// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HHOOK : IEquatable<HHOOK>
    {
        public static readonly HHOOK NULL = default;

        private void* _value;

        public HHOOK(IntPtr value) : this(value.ToPointer())
        {
        }

        public HHOOK(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HHOOK l, HHOOK r) => l._value == r._value;

        public static bool operator !=(HHOOK l, HHOOK r) => !(l == r);

        public static implicit operator HHOOK(IntPtr value) => new HHOOK(value);

        public static implicit operator HHOOK(void* value) => new HHOOK(value);

        public static implicit operator IntPtr(HHOOK value) => new IntPtr(value._value);

        public static implicit operator void*(HHOOK value) => value._value;

        public override bool Equals(object? obj) => (obj is HHOOK other) && Equals(other);

        public bool Equals(HHOOK other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
