// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PRJ_DIR_ENTRY_BUFFER_HANDLE : IEquatable<PRJ_DIR_ENTRY_BUFFER_HANDLE>
    {
        public readonly nint Value;

        public PRJ_DIR_ENTRY_BUFFER_HANDLE(nint value)
        {
            Value = value;
        }

        public static PRJ_DIR_ENTRY_BUFFER_HANDLE INVALID_VALUE => new PRJ_DIR_ENTRY_BUFFER_HANDLE(-1);

        public static PRJ_DIR_ENTRY_BUFFER_HANDLE NULL => new PRJ_DIR_ENTRY_BUFFER_HANDLE(0);

        public static bool operator ==(PRJ_DIR_ENTRY_BUFFER_HANDLE left, PRJ_DIR_ENTRY_BUFFER_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(PRJ_DIR_ENTRY_BUFFER_HANDLE left, PRJ_DIR_ENTRY_BUFFER_HANDLE right) => left.Value != right.Value;

        public static explicit operator PRJ_DIR_ENTRY_BUFFER_HANDLE(void* value) => new PRJ_DIR_ENTRY_BUFFER_HANDLE((nint)(value));

        public static implicit operator void*(PRJ_DIR_ENTRY_BUFFER_HANDLE value) => (void*)(value.Value);

        public static explicit operator PRJ_DIR_ENTRY_BUFFER_HANDLE(HANDLE value) => new PRJ_DIR_ENTRY_BUFFER_HANDLE(value);

        public static implicit operator HANDLE(PRJ_DIR_ENTRY_BUFFER_HANDLE value) => new HANDLE(value.Value);

        public static explicit operator PRJ_DIR_ENTRY_BUFFER_HANDLE(byte value) => new PRJ_DIR_ENTRY_BUFFER_HANDLE((nint)(value));

        public static explicit operator byte(PRJ_DIR_ENTRY_BUFFER_HANDLE value) => (byte)(value.Value);

        public static explicit operator PRJ_DIR_ENTRY_BUFFER_HANDLE(short value) => new PRJ_DIR_ENTRY_BUFFER_HANDLE((nint)(value));

        public static explicit operator short(PRJ_DIR_ENTRY_BUFFER_HANDLE value) => (short)(value.Value);

        public static explicit operator PRJ_DIR_ENTRY_BUFFER_HANDLE(int value) => new PRJ_DIR_ENTRY_BUFFER_HANDLE((nint)(value));

        public static explicit operator int(PRJ_DIR_ENTRY_BUFFER_HANDLE value) => (int)(value.Value);

        public static explicit operator PRJ_DIR_ENTRY_BUFFER_HANDLE(long value) => new PRJ_DIR_ENTRY_BUFFER_HANDLE((nint)(value));

        public static implicit operator long(PRJ_DIR_ENTRY_BUFFER_HANDLE value) => (long)(value.Value);

        public static explicit operator PRJ_DIR_ENTRY_BUFFER_HANDLE(nint value) => new PRJ_DIR_ENTRY_BUFFER_HANDLE((nint)(value));

        public static implicit operator nint(PRJ_DIR_ENTRY_BUFFER_HANDLE value) => (nint)(value.Value);

        public static explicit operator PRJ_DIR_ENTRY_BUFFER_HANDLE(sbyte value) => new PRJ_DIR_ENTRY_BUFFER_HANDLE((nint)(value));

        public static explicit operator sbyte(PRJ_DIR_ENTRY_BUFFER_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator PRJ_DIR_ENTRY_BUFFER_HANDLE(ushort value) => new PRJ_DIR_ENTRY_BUFFER_HANDLE((nint)(value));

        public static explicit operator ushort(PRJ_DIR_ENTRY_BUFFER_HANDLE value) => (ushort)(value.Value);

        public static explicit operator PRJ_DIR_ENTRY_BUFFER_HANDLE(uint value) => new PRJ_DIR_ENTRY_BUFFER_HANDLE((nint)(value));

        public static explicit operator uint(PRJ_DIR_ENTRY_BUFFER_HANDLE value) => (uint)(value.Value);

        public static explicit operator PRJ_DIR_ENTRY_BUFFER_HANDLE(ulong value) => new PRJ_DIR_ENTRY_BUFFER_HANDLE((nint)(value));

        public static explicit operator ulong(PRJ_DIR_ENTRY_BUFFER_HANDLE value) => (ulong)(value.Value);

        public static explicit operator PRJ_DIR_ENTRY_BUFFER_HANDLE(nuint value) => new PRJ_DIR_ENTRY_BUFFER_HANDLE((nint)(value));

        public static explicit operator nuint(PRJ_DIR_ENTRY_BUFFER_HANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is PRJ_DIR_ENTRY_BUFFER_HANDLE other) && Equals(other);

        public bool Equals(PRJ_DIR_ENTRY_BUFFER_HANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
