// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/minwindef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HWINSTA : IEquatable<HWINSTA>
    {
        public static readonly HWINSTA NULL = default;

        private void* _value;

        public HWINSTA(IntPtr value) : this(value.ToPointer())
        {
        }

        public HWINSTA(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HWINSTA l, HWINSTA r) => l._value == r._value;

        public static bool operator !=(HWINSTA l, HWINSTA r) => !(l == r);

        public static implicit operator HWINSTA(IntPtr value) => new HWINSTA(value);

        public static implicit operator HWINSTA(void* value) => new HWINSTA(value);

        public static implicit operator IntPtr(HWINSTA value) => new IntPtr(value._value);

        public static implicit operator void*(HWINSTA value) => value._value;

        public override bool Equals(object? obj) => (obj is HWINSTA other) && Equals(other);

        public bool Equals(HWINSTA other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
