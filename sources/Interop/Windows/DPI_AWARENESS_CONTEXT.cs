// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct DPI_AWARENESS_CONTEXT : IEquatable<DPI_AWARENESS_CONTEXT>
    {
        public readonly nint Value;

        public DPI_AWARENESS_CONTEXT(nint value)
        {
            Value = ((nint)(value));
        }

        public DPI_AWARENESS_CONTEXT(nuint value)
        {
            Value = ((nint)(value));
        }

        public DPI_AWARENESS_CONTEXT(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(DPI_AWARENESS_CONTEXT left, DPI_AWARENESS_CONTEXT right) => left.Value == right.Value;

        public static bool operator !=(DPI_AWARENESS_CONTEXT left, DPI_AWARENESS_CONTEXT right) => left.Value != right.Value;

        public static explicit operator DPI_AWARENESS_CONTEXT(nint value) => new DPI_AWARENESS_CONTEXT(value);

        public static explicit operator DPI_AWARENESS_CONTEXT(nuint value) => new DPI_AWARENESS_CONTEXT(value);

        public static explicit operator DPI_AWARENESS_CONTEXT(void* value) => new DPI_AWARENESS_CONTEXT(value);

        public static implicit operator nint(DPI_AWARENESS_CONTEXT value) => (nint)(value.Value);

        public static implicit operator nuint(DPI_AWARENESS_CONTEXT value) => (nuint)(value.Value);

        public static implicit operator void*(DPI_AWARENESS_CONTEXT value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is DPI_AWARENESS_CONTEXT other) && Equals(other);

        public bool Equals(DPI_AWARENESS_CONTEXT other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
