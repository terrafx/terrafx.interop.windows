// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PEERDIST_CONTENTINFO_HANDLE : IEquatable<PEERDIST_CONTENTINFO_HANDLE>
    {
        public readonly nint Value;

        public PEERDIST_CONTENTINFO_HANDLE(nint value)
        {
            Value = value;
        }

        public static PEERDIST_CONTENTINFO_HANDLE INVALID_VALUE => new PEERDIST_CONTENTINFO_HANDLE(-1);

        public static PEERDIST_CONTENTINFO_HANDLE NULL => new PEERDIST_CONTENTINFO_HANDLE(0);

        public static bool operator ==(PEERDIST_CONTENTINFO_HANDLE left, PEERDIST_CONTENTINFO_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(PEERDIST_CONTENTINFO_HANDLE left, PEERDIST_CONTENTINFO_HANDLE right) => left.Value != right.Value;

        public static explicit operator PEERDIST_CONTENTINFO_HANDLE(void* value) => new PEERDIST_CONTENTINFO_HANDLE((nint)(value));

        public static implicit operator void*(PEERDIST_CONTENTINFO_HANDLE value) => (void*)(value.Value);

        public static explicit operator PEERDIST_CONTENTINFO_HANDLE(HANDLE value) => new PEERDIST_CONTENTINFO_HANDLE(value);

        public static implicit operator HANDLE(PEERDIST_CONTENTINFO_HANDLE value) => new HANDLE(value.Value);

        public static explicit operator PEERDIST_CONTENTINFO_HANDLE(byte value) => new PEERDIST_CONTENTINFO_HANDLE((nint)(value));

        public static explicit operator byte(PEERDIST_CONTENTINFO_HANDLE value) => (byte)(value.Value);

        public static explicit operator PEERDIST_CONTENTINFO_HANDLE(short value) => new PEERDIST_CONTENTINFO_HANDLE((nint)(value));

        public static explicit operator short(PEERDIST_CONTENTINFO_HANDLE value) => (short)(value.Value);

        public static explicit operator PEERDIST_CONTENTINFO_HANDLE(int value) => new PEERDIST_CONTENTINFO_HANDLE((nint)(value));

        public static explicit operator int(PEERDIST_CONTENTINFO_HANDLE value) => (int)(value.Value);

        public static explicit operator PEERDIST_CONTENTINFO_HANDLE(long value) => new PEERDIST_CONTENTINFO_HANDLE((nint)(value));

        public static implicit operator long(PEERDIST_CONTENTINFO_HANDLE value) => (long)(value.Value);

        public static explicit operator PEERDIST_CONTENTINFO_HANDLE(nint value) => new PEERDIST_CONTENTINFO_HANDLE((nint)(value));

        public static implicit operator nint(PEERDIST_CONTENTINFO_HANDLE value) => (nint)(value.Value);

        public static explicit operator PEERDIST_CONTENTINFO_HANDLE(sbyte value) => new PEERDIST_CONTENTINFO_HANDLE((nint)(value));

        public static explicit operator sbyte(PEERDIST_CONTENTINFO_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator PEERDIST_CONTENTINFO_HANDLE(ushort value) => new PEERDIST_CONTENTINFO_HANDLE((nint)(value));

        public static explicit operator ushort(PEERDIST_CONTENTINFO_HANDLE value) => (ushort)(value.Value);

        public static explicit operator PEERDIST_CONTENTINFO_HANDLE(uint value) => new PEERDIST_CONTENTINFO_HANDLE((nint)(value));

        public static explicit operator uint(PEERDIST_CONTENTINFO_HANDLE value) => (uint)(value.Value);

        public static explicit operator PEERDIST_CONTENTINFO_HANDLE(ulong value) => new PEERDIST_CONTENTINFO_HANDLE((nint)(value));

        public static explicit operator ulong(PEERDIST_CONTENTINFO_HANDLE value) => (ulong)(value.Value);

        public static explicit operator PEERDIST_CONTENTINFO_HANDLE(nuint value) => new PEERDIST_CONTENTINFO_HANDLE((nint)(value));

        public static explicit operator nuint(PEERDIST_CONTENTINFO_HANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is PEERDIST_CONTENTINFO_HANDLE other) && Equals(other);

        public bool Equals(PEERDIST_CONTENTINFO_HANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
