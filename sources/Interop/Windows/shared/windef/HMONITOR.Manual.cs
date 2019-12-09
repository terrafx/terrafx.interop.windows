// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.18632.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HMONITOR : IEquatable<HMONITOR>
    {
        public static readonly HMONITOR NULL = default;

        private void* _value;

        public HMONITOR(IntPtr value) : this(value.ToPointer())
        {
        }

        public HMONITOR(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HMONITOR l, HMONITOR r) => l._value == r._value;

        public static bool operator !=(HMONITOR l, HMONITOR r) => !(l == r);

        public static implicit operator HMONITOR(IntPtr value) => new HMONITOR(value);

        public static implicit operator HMONITOR(void* value) => new HMONITOR(value);

        public static implicit operator IntPtr(HMONITOR value) => new IntPtr(value._value);

        public static implicit operator void*(HMONITOR value) => value._value;

        public override bool Equals(object? obj) => (obj is POINT other) && Equals(other);

        public bool Equals(HMONITOR other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
