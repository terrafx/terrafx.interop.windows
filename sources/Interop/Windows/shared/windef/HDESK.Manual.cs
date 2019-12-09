// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.18632.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HDESK : IEquatable<HDESK>
    {
        public static readonly HDESK NULL = default;

        private void* _value;

        public HDESK(IntPtr value) : this(value.ToPointer())
        {
        }

        public HDESK(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HDESK l, HDESK r) => l._value == r._value;

        public static bool operator !=(HDESK l, HDESK r) => !(l == r);

        public static implicit operator HDESK(IntPtr value) => new HDESK(value);

        public static implicit operator HDESK(void* value) => new HDESK(value);

        public static implicit operator IntPtr(HDESK value) => new IntPtr(value._value);

        public static implicit operator void*(HDESK value) => value._value;

        public override bool Equals(object? obj) => (obj is HDESK other) && Equals(other);

        public bool Equals(HDESK other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
