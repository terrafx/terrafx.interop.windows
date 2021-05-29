// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HRAWINPUT : IEquatable<HRAWINPUT>
    {
        public static readonly HRAWINPUT NULL = default;

        private void* _value;

        public HRAWINPUT(IntPtr value) : this(value.ToPointer())
        {
        }

        public HRAWINPUT(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HRAWINPUT l, HRAWINPUT r) => l._value == r._value;

        public static bool operator !=(HRAWINPUT l, HRAWINPUT r) => !(l == r);

        public static implicit operator HRAWINPUT(IntPtr value) => new HRAWINPUT(value);

        public static implicit operator HRAWINPUT(void* value) => new HRAWINPUT(value);

        public static implicit operator IntPtr(HRAWINPUT value) => new IntPtr(value._value);

        public static implicit operator void*(HRAWINPUT value) => value._value;

        public override bool Equals(object? obj) => (obj is HRAWINPUT other) && Equals(other);

        public bool Equals(HRAWINPUT other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
