// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.18632.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HICON : IEquatable<HICON>
    {
        public static readonly HICON NULL = default;

        private void* _value;

        public HICON(IntPtr value) : this(value.ToPointer())
        {
        }

        public HICON(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HICON l, HICON r) => l._value == r._value;

        public static bool operator !=(HICON l, HICON r) => !(l == r);

        public static implicit operator HICON(IntPtr value) => new HICON(value);

        public static implicit operator HICON(void* value) => new HICON(value);

        public static implicit operator IntPtr(HICON value) => new IntPtr(value._value);

        public static implicit operator void*(HICON value) => value._value;

        public override bool Equals(object? obj) => (obj is POINT other) && Equals(other);

        public bool Equals(HICON other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
