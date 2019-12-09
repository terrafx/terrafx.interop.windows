// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/minwindef.h in the Windows SDK for Windows 10.0.18632.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HMETAFILE : IEquatable<HMETAFILE>
    {
        public static readonly HMETAFILE NULL = default;

        private void* _value;

        public HMETAFILE(IntPtr value) : this(value.ToPointer())
        {
        }

        public HMETAFILE(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HMETAFILE l, HMETAFILE r) => l._value == r._value;

        public static bool operator !=(HMETAFILE l, HMETAFILE r) => !(l == r);

        public static implicit operator HMETAFILE(IntPtr value) => new HMETAFILE(value);

        public static implicit operator HMETAFILE(void* value) => new HMETAFILE(value);

        public static implicit operator IntPtr(HMETAFILE value) => new IntPtr(value._value);

        public static implicit operator void*(HMETAFILE value) => value._value;

        public override bool Equals(object? obj) => (obj is POINT other) && Equals(other);

        public bool Equals(HMETAFILE other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
