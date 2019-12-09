// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.18632.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HTOUCHINPUT : IEquatable<HTOUCHINPUT>
    {
        public static readonly HTOUCHINPUT NULL = default;

        private void* _value;

        public HTOUCHINPUT(IntPtr value) : this(value.ToPointer())
        {
        }

        public HTOUCHINPUT(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HTOUCHINPUT l, HTOUCHINPUT r) => l._value == r._value;

        public static bool operator !=(HTOUCHINPUT l, HTOUCHINPUT r) => !(l == r);

        public static implicit operator HTOUCHINPUT(IntPtr value) => new HTOUCHINPUT(value);

        public static implicit operator HTOUCHINPUT(void* value) => new HTOUCHINPUT(value);

        public static implicit operator IntPtr(HTOUCHINPUT value) => new IntPtr(value._value);

        public static implicit operator void*(HTOUCHINPUT value) => value._value;

        public override bool Equals(object? obj) => (obj is HTOUCHINPUT other) && Equals(other);

        public bool Equals(HTOUCHINPUT other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
