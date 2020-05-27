// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HACCEL : IEquatable<HACCEL>
    {
        public static readonly HACCEL NULL = default;

        private void* _value;

        public HACCEL(IntPtr value) : this(value.ToPointer())
        {
        }

        public HACCEL(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HACCEL l, HACCEL r) => l._value == r._value;

        public static bool operator !=(HACCEL l, HACCEL r) => !(l == r);

        public static implicit operator HACCEL(IntPtr value) => new HACCEL(value);

        public static implicit operator HACCEL(void* value) => new HACCEL(value);

        public static implicit operator IntPtr(HACCEL value) => new IntPtr(value._value);

        public static implicit operator void*(HACCEL value) => value._value;

        public override bool Equals(object? obj) => (obj is HACCEL other) && Equals(other);

        public bool Equals(HACCEL other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
