// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.18632.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HPEN : IEquatable<HPEN>
    {
        public static readonly HPEN NULL = default;

        private void* _value;

        public HPEN(IntPtr value) : this(value.ToPointer())
        {
        }

        public HPEN(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HPEN l, HPEN r) => l._value == r._value;

        public static bool operator !=(HPEN l, HPEN r) => !(l == r);

        public static implicit operator HPEN(IntPtr value) => new HPEN(value);

        public static implicit operator HPEN(void* value) => new HPEN(value);

        public static implicit operator IntPtr(HPEN value) => new IntPtr(value._value);

        public static implicit operator void*(HPEN value) => value._value;

        public override bool Equals(object? obj) => (obj is POINT other) && Equals(other);

        public bool Equals(HPEN other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
