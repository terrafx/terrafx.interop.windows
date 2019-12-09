// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.18632.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct DPI_AWARENESS_CONTEXT : IEquatable<DPI_AWARENESS_CONTEXT>
    {
        public static readonly DPI_AWARENESS_CONTEXT NULL = default;

        private void* _value;

        public DPI_AWARENESS_CONTEXT(IntPtr value) : this(value.ToPointer())
        {
        }

        public DPI_AWARENESS_CONTEXT(void* value)
        {
            _value = value;
        }

        public static bool operator ==(DPI_AWARENESS_CONTEXT l, DPI_AWARENESS_CONTEXT r) => l._value == r._value;

        public static bool operator !=(DPI_AWARENESS_CONTEXT l, DPI_AWARENESS_CONTEXT r) => !(l == r);

        public static implicit operator DPI_AWARENESS_CONTEXT(IntPtr value) => new DPI_AWARENESS_CONTEXT(value);

        public static implicit operator DPI_AWARENESS_CONTEXT(void* value) => new DPI_AWARENESS_CONTEXT(value);

        public static implicit operator IntPtr(DPI_AWARENESS_CONTEXT value) => new IntPtr(value._value);

        public static implicit operator void*(DPI_AWARENESS_CONTEXT value) => value._value;

        public override bool Equals(object? obj) => (obj is POINT other) && Equals(other);

        public bool Equals(DPI_AWARENESS_CONTEXT other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
