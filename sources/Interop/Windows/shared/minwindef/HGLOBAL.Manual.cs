// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/minwindef.h in the Windows SDK for Windows 10.0.18632.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HGLOBAL : IEquatable<HGLOBAL>
    {
        public static readonly HGLOBAL NULL = default;

        private void* _value;

        public HGLOBAL(IntPtr value) : this(value.ToPointer())
        {
        }

        public HGLOBAL(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HGLOBAL l, HGLOBAL r) => l._value == r._value;

        public static bool operator !=(HGLOBAL l, HGLOBAL r) => !(l == r);

        public static implicit operator HGLOBAL(IntPtr value) => new HGLOBAL(value);

        public static implicit operator HGLOBAL(void* value) => new HGLOBAL(value);

        public static implicit operator IntPtr(HGLOBAL value) => new IntPtr(value._value);

        public static implicit operator void*(HGLOBAL value) => value._value;

        public override bool Equals(object? obj) => (obj is POINT other) && Equals(other);

        public bool Equals(HGLOBAL other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
