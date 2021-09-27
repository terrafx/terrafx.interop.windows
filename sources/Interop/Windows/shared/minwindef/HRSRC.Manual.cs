// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/minwindef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HRSRC : IEquatable<HRSRC>
    {
        public static HRSRC NULL => default;

        private void* _value;

        public HRSRC(IntPtr value) : this(value.ToPointer())
        {
        }

        public HRSRC(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HRSRC l, HRSRC r) => l._value == r._value;

        public static bool operator !=(HRSRC l, HRSRC r) => !(l == r);

        public static implicit operator HRSRC(IntPtr value) => new HRSRC(value);

        public static implicit operator HRSRC(void* value) => new HRSRC(value);

        public static implicit operator IntPtr(HRSRC value) => new IntPtr(value._value);

        public static implicit operator void*(HRSRC value) => value._value;

        public override bool Equals(object? obj) => (obj is HRSRC other) && Equals(other);

        public bool Equals(HRSRC other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
