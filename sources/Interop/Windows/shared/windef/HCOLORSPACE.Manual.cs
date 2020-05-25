// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HCOLORSPACE : IEquatable<HCOLORSPACE>
    {
        public static readonly HCOLORSPACE NULL = default;

        private void* _value;

        public HCOLORSPACE(IntPtr value) : this(value.ToPointer())
        {
        }

        public HCOLORSPACE(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HCOLORSPACE l, HCOLORSPACE r) => l._value == r._value;

        public static bool operator !=(HCOLORSPACE l, HCOLORSPACE r) => !(l == r);

        public static implicit operator HCOLORSPACE(IntPtr value) => new HCOLORSPACE(value);

        public static implicit operator HCOLORSPACE(void* value) => new HCOLORSPACE(value);

        public static implicit operator IntPtr(HCOLORSPACE value) => new IntPtr(value._value);

        public static implicit operator void*(HCOLORSPACE value) => value._value;

        public override bool Equals(object? obj) => (obj is HCOLORSPACE other) && Equals(other);

        public bool Equals(HCOLORSPACE other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
