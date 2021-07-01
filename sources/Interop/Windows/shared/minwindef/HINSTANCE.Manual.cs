// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/minwindef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HINSTANCE : IEquatable<HINSTANCE>
    {
        public static readonly HINSTANCE NULL = default;

        private void* _value;

        public HINSTANCE(IntPtr value) : this(value.ToPointer())
        {
        }

        public HINSTANCE(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HINSTANCE l, HINSTANCE r) => l._value == r._value;

        public static bool operator !=(HINSTANCE l, HINSTANCE r) => !(l == r);

        public static implicit operator HINSTANCE(IntPtr value) => new HINSTANCE(value);

        public static implicit operator HINSTANCE(void* value) => new HINSTANCE(value);

        public static implicit operator IntPtr(HINSTANCE value) => new IntPtr(value._value);

        public static implicit operator void*(HINSTANCE value) => value._value;

        public override bool Equals(object? obj) => (obj is HINSTANCE other) && Equals(other);

        public bool Equals(HINSTANCE other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
