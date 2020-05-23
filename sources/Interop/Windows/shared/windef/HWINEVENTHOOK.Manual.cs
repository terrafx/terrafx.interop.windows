// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HWINEVENTHOOK : IEquatable<HWINEVENTHOOK>
    {
        public static readonly HWINEVENTHOOK NULL = default;

        private void* _value;

        public HWINEVENTHOOK(IntPtr value) : this(value.ToPointer())
        {
        }

        public HWINEVENTHOOK(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HWINEVENTHOOK l, HWINEVENTHOOK r) => l._value == r._value;

        public static bool operator !=(HWINEVENTHOOK l, HWINEVENTHOOK r) => !(l == r);

        public static implicit operator HWINEVENTHOOK(IntPtr value) => new HWINEVENTHOOK(value);

        public static implicit operator HWINEVENTHOOK(void* value) => new HWINEVENTHOOK(value);

        public static implicit operator IntPtr(HWINEVENTHOOK value) => new IntPtr(value._value);

        public static implicit operator void*(HWINEVENTHOOK value) => value._value;

        public override bool Equals(object? obj) => (obj is HWINEVENTHOOK other) && Equals(other);

        public bool Equals(HWINEVENTHOOK other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
