// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct DPI_AWARENESS_CONTEXT : IEquatable<DPI_AWARENESS_CONTEXT>
    {
        public readonly nint Value;

        public DPI_AWARENESS_CONTEXT(nint value)
        {
            Value = value;
        }

        public static DPI_AWARENESS_CONTEXT INVALID_VALUE => new DPI_AWARENESS_CONTEXT(-1);

        public static DPI_AWARENESS_CONTEXT NULL => new DPI_AWARENESS_CONTEXT(0);

        public static bool operator ==(DPI_AWARENESS_CONTEXT left, DPI_AWARENESS_CONTEXT right) => left.Value == right.Value;

        public static bool operator !=(DPI_AWARENESS_CONTEXT left, DPI_AWARENESS_CONTEXT right) => left.Value != right.Value;

        public static explicit operator DPI_AWARENESS_CONTEXT(void* value) => new DPI_AWARENESS_CONTEXT((nint)(value));

        public static implicit operator void*(DPI_AWARENESS_CONTEXT value) => (void*)(value.Value);

        public static explicit operator DPI_AWARENESS_CONTEXT(HANDLE value) => new DPI_AWARENESS_CONTEXT(value);

        public static implicit operator HANDLE(DPI_AWARENESS_CONTEXT value) => new HANDLE(value.Value);

        public static explicit operator DPI_AWARENESS_CONTEXT(byte value) => new DPI_AWARENESS_CONTEXT((nint)(value));

        public static explicit operator byte(DPI_AWARENESS_CONTEXT value) => (byte)(value.Value);

        public static explicit operator DPI_AWARENESS_CONTEXT(short value) => new DPI_AWARENESS_CONTEXT((nint)(value));

        public static explicit operator short(DPI_AWARENESS_CONTEXT value) => (short)(value.Value);

        public static explicit operator DPI_AWARENESS_CONTEXT(int value) => new DPI_AWARENESS_CONTEXT((nint)(value));

        public static explicit operator int(DPI_AWARENESS_CONTEXT value) => (int)(value.Value);

        public static explicit operator DPI_AWARENESS_CONTEXT(long value) => new DPI_AWARENESS_CONTEXT((nint)(value));

        public static implicit operator long(DPI_AWARENESS_CONTEXT value) => (long)(value.Value);

        public static explicit operator DPI_AWARENESS_CONTEXT(nint value) => new DPI_AWARENESS_CONTEXT((nint)(value));

        public static implicit operator nint(DPI_AWARENESS_CONTEXT value) => (nint)(value.Value);

        public static explicit operator DPI_AWARENESS_CONTEXT(sbyte value) => new DPI_AWARENESS_CONTEXT((nint)(value));

        public static explicit operator sbyte(DPI_AWARENESS_CONTEXT value) => (sbyte)(value.Value);

        public static explicit operator DPI_AWARENESS_CONTEXT(ushort value) => new DPI_AWARENESS_CONTEXT((nint)(value));

        public static explicit operator ushort(DPI_AWARENESS_CONTEXT value) => (ushort)(value.Value);

        public static explicit operator DPI_AWARENESS_CONTEXT(uint value) => new DPI_AWARENESS_CONTEXT((nint)(value));

        public static explicit operator uint(DPI_AWARENESS_CONTEXT value) => (uint)(value.Value);

        public static explicit operator DPI_AWARENESS_CONTEXT(ulong value) => new DPI_AWARENESS_CONTEXT((nint)(value));

        public static explicit operator ulong(DPI_AWARENESS_CONTEXT value) => (ulong)(value.Value);

        public static explicit operator DPI_AWARENESS_CONTEXT(nuint value) => new DPI_AWARENESS_CONTEXT((nint)(value));

        public static explicit operator nuint(DPI_AWARENESS_CONTEXT value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is DPI_AWARENESS_CONTEXT other) && Equals(other);

        public bool Equals(DPI_AWARENESS_CONTEXT other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
