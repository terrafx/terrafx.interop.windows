// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HENHMETAFILE : IEquatable<HENHMETAFILE>
    {
        public static readonly HENHMETAFILE NULL = default;

        private void* _value;

        public HENHMETAFILE(IntPtr value) : this(value.ToPointer())
        {
        }

        public HENHMETAFILE(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HENHMETAFILE l, HENHMETAFILE r) => l._value == r._value;

        public static bool operator !=(HENHMETAFILE l, HENHMETAFILE r) => !(l == r);

        public static implicit operator HENHMETAFILE(IntPtr value) => new HENHMETAFILE(value);

        public static implicit operator HENHMETAFILE(void* value) => new HENHMETAFILE(value);

        public static implicit operator IntPtr(HENHMETAFILE value) => new IntPtr(value._value);

        public static implicit operator void*(HENHMETAFILE value) => value._value;

        public override bool Equals(object? obj) => (obj is HENHMETAFILE other) && Equals(other);

        public bool Equals(HENHMETAFILE other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
