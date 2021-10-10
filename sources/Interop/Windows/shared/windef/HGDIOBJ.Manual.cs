// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HGDIOBJ : IEquatable<HGDIOBJ>
    {
        public static HGDIOBJ NULL => default;

        private void* _value;

        public HGDIOBJ(IntPtr value) : this(value.ToPointer())
        {
        }

        public HGDIOBJ(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HGDIOBJ l, HGDIOBJ r) => l._value == r._value;

        public static bool operator !=(HGDIOBJ l, HGDIOBJ r) => !(l == r);

        public static implicit operator HGDIOBJ(IntPtr value) => new HGDIOBJ(value);

        public static implicit operator HGDIOBJ(void* value) => new HGDIOBJ(value);

        public static implicit operator IntPtr(HGDIOBJ value) => new IntPtr(value._value);

        public static implicit operator void*(HGDIOBJ value) => value._value;

        public override bool Equals(object? obj) => (obj is HGDIOBJ other) && Equals(other);

        public bool Equals(HGDIOBJ other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
