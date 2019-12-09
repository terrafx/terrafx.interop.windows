// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.18632.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HSYNTHETICPOINTERDEVICE : IEquatable<HSYNTHETICPOINTERDEVICE>
    {
        public static readonly HSYNTHETICPOINTERDEVICE NULL = default;

        private void* _value;

        public HSYNTHETICPOINTERDEVICE(IntPtr value) : this(value.ToPointer())
        {
        }

        public HSYNTHETICPOINTERDEVICE(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HSYNTHETICPOINTERDEVICE l, HSYNTHETICPOINTERDEVICE r) => l._value == r._value;

        public static bool operator !=(HSYNTHETICPOINTERDEVICE l, HSYNTHETICPOINTERDEVICE r) => !(l == r);

        public static implicit operator HSYNTHETICPOINTERDEVICE(IntPtr value) => new HSYNTHETICPOINTERDEVICE(value);

        public static implicit operator HSYNTHETICPOINTERDEVICE(void* value) => new HSYNTHETICPOINTERDEVICE(value);

        public static implicit operator IntPtr(HSYNTHETICPOINTERDEVICE value) => new IntPtr(value._value);

        public static implicit operator void*(HSYNTHETICPOINTERDEVICE value) => value._value;

        public override bool Equals(object? obj) => (obj is POINT other) && Equals(other);

        public bool Equals(HSYNTHETICPOINTERDEVICE other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
