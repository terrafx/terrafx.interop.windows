// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.18632.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HGESTUREINFO : IEquatable<HGESTUREINFO>
    {
        public static readonly HGESTUREINFO NULL = default;

        private void* _value;

        public HGESTUREINFO(IntPtr value) : this(value.ToPointer())
        {
        }

        public HGESTUREINFO(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HGESTUREINFO l, HGESTUREINFO r) => l._value == r._value;

        public static bool operator !=(HGESTUREINFO l, HGESTUREINFO r) => !(l == r);

        public static implicit operator HGESTUREINFO(IntPtr value) => new HGESTUREINFO(value);

        public static implicit operator HGESTUREINFO(void* value) => new HGESTUREINFO(value);

        public static implicit operator IntPtr(HGESTUREINFO value) => new IntPtr(value._value);

        public static implicit operator void*(HGESTUREINFO value) => value._value;

        public override bool Equals(object? obj) => (obj is HGESTUREINFO other) && Equals(other);

        public bool Equals(HGESTUREINFO other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
