// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.18632.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HPALETTE : IEquatable<HPALETTE>
    {
        public static readonly HPALETTE NULL = default;

        private void* _value;

        public HPALETTE(IntPtr value) : this(value.ToPointer())
        {
        }

        public HPALETTE(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HPALETTE l, HPALETTE r) => l._value == r._value;

        public static bool operator !=(HPALETTE l, HPALETTE r) => !(l == r);

        public static implicit operator HPALETTE(IntPtr value) => new HPALETTE(value);

        public static implicit operator HPALETTE(void* value) => new HPALETTE(value);

        public static implicit operator IntPtr(HPALETTE value) => new IntPtr(value._value);

        public static implicit operator void*(HPALETTE value) => value._value;

        public override bool Equals(object? obj) => (obj is POINT other) && Equals(other);

        public bool Equals(HPALETTE other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
