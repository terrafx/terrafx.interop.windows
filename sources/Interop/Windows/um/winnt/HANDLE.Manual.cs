// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HANDLE : IEquatable<HANDLE>
    {
        public static readonly HANDLE NULL = default;

        private void* _value;

        public HANDLE(IntPtr value) : this(value.ToPointer())
        {
        }

        public HANDLE(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HANDLE l, HANDLE r) => l._value == r._value;

        public static bool operator !=(HANDLE l, HANDLE r) => !(l == r);

        public static implicit operator HANDLE(IntPtr value) => new HANDLE(value);

        public static implicit operator HANDLE(void* value) => new HANDLE(value);

        public static implicit operator IntPtr(HANDLE value) => new IntPtr(value._value);

        public static implicit operator void*(HANDLE value) => value._value;

        public override bool Equals(object? obj) => (obj is HANDLE other) && Equals(other);

        public bool Equals(HANDLE other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
