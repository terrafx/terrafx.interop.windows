// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.18632.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HFONT : IEquatable<HFONT>
    {
        public static readonly HFONT NULL = default;

        private void* _value;

        public HFONT(IntPtr value) : this(value.ToPointer())
        {
        }

        public HFONT(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HFONT l, HFONT r) => l._value == r._value;

        public static bool operator !=(HFONT l, HFONT r) => !(l == r);

        public static implicit operator HFONT(IntPtr value) => new HFONT(value);

        public static implicit operator HFONT(void* value) => new HFONT(value);

        public static implicit operator IntPtr(HFONT value) => new IntPtr(value._value);

        public static implicit operator void*(HFONT value) => value._value;

        public override bool Equals(object? obj) => (obj is HFONT other) && Equals(other);

        public bool Equals(HFONT other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
