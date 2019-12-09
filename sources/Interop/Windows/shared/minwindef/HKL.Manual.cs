// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/minwindef.h in the Windows SDK for Windows 10.0.18632.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HKL : IEquatable<HKL>
    {
        public static readonly HKL NULL = default;

        private void* _value;

        public HKL(IntPtr value) : this(value.ToPointer())
        {
        }

        public HKL(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HKL l, HKL r) => l._value == r._value;

        public static bool operator !=(HKL l, HKL r) => !(l == r);

        public static implicit operator HKL(IntPtr value) => new HKL(value);

        public static implicit operator HKL(void* value) => new HKL(value);

        public static implicit operator IntPtr(HKL value) => new IntPtr(value._value);

        public static implicit operator void*(HKL value) => value._value;

        public override bool Equals(object? obj) => (obj is POINT other) && Equals(other);

        public bool Equals(HKL other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
