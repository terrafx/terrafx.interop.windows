// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HDC : IEquatable<HDC>
    {
        public static HDC NULL => default;

        private void* _value;

        public HDC(IntPtr value) : this(value.ToPointer())
        {
        }

        public HDC(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HDC l, HDC r) => l._value == r._value;

        public static bool operator !=(HDC l, HDC r) => !(l == r);

        public static implicit operator HDC(IntPtr value) => new HDC(value);

        public static implicit operator HDC(void* value) => new HDC(value);

        public static implicit operator IntPtr(HDC value) => new IntPtr(value._value);

        public static implicit operator void*(HDC value) => value._value;

        public override bool Equals(object? obj) => (obj is HDC other) && Equals(other);

        public bool Equals(HDC other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
