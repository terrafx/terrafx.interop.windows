// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.18632.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HGLRC : IEquatable<HGLRC>
    {
        public static readonly HGLRC NULL = default;

        private void* _value;

        public HGLRC(IntPtr value) : this(value.ToPointer())
        {
        }

        public HGLRC(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HGLRC l, HGLRC r) => l._value == r._value;

        public static bool operator !=(HGLRC l, HGLRC r) => !(l == r);

        public static implicit operator HGLRC(IntPtr value) => new HGLRC(value);

        public static implicit operator HGLRC(void* value) => new HGLRC(value);

        public static implicit operator IntPtr(HGLRC value) => new IntPtr(value._value);

        public static implicit operator void*(HGLRC value) => value._value;

        public override bool Equals(object? obj) => (obj is HGLRC other) && Equals(other);

        public bool Equals(HGLRC other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
