// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct NFC_SE_HANDLE : IEquatable<NFC_SE_HANDLE>
    {
        public readonly nint Value;

        public NFC_SE_HANDLE(nint value)
        {
            Value = value;
        }

        public static NFC_SE_HANDLE INVALID_VALUE => new NFC_SE_HANDLE(-1);

        public static NFC_SE_HANDLE NULL => new NFC_SE_HANDLE(0);

        public static bool operator ==(NFC_SE_HANDLE left, NFC_SE_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(NFC_SE_HANDLE left, NFC_SE_HANDLE right) => left.Value != right.Value;

        public static explicit operator NFC_SE_HANDLE(void* value) => new NFC_SE_HANDLE((nint)(value));

        public static implicit operator void*(NFC_SE_HANDLE value) => (void*)(value.Value);

        public static explicit operator NFC_SE_HANDLE(HANDLE value) => new NFC_SE_HANDLE(value);

        public static implicit operator HANDLE(NFC_SE_HANDLE value) => new NFC_SE_HANDLE(value);

        public static explicit operator NFC_SE_HANDLE(byte value) => new NFC_SE_HANDLE((nint)(value));

        public static explicit operator byte(NFC_SE_HANDLE value) => (byte)(value.Value);

        public static explicit operator NFC_SE_HANDLE(short value) => new NFC_SE_HANDLE((nint)(value));

        public static explicit operator short(NFC_SE_HANDLE value) => (short)(value.Value);

        public static explicit operator NFC_SE_HANDLE(int value) => new NFC_SE_HANDLE((nint)(value));

        public static explicit operator int(NFC_SE_HANDLE value) => (int)(value.Value);

        public static explicit operator NFC_SE_HANDLE(long value) => new NFC_SE_HANDLE((nint)(value));

        public static implicit operator long(NFC_SE_HANDLE value) => (long)(value.Value);

        public static explicit operator NFC_SE_HANDLE(nint value) => new NFC_SE_HANDLE((nint)(value));

        public static implicit operator nint(NFC_SE_HANDLE value) => (nint)(value.Value);

        public static explicit operator NFC_SE_HANDLE(sbyte value) => new NFC_SE_HANDLE((nint)(value));

        public static explicit operator sbyte(NFC_SE_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator NFC_SE_HANDLE(ushort value) => new NFC_SE_HANDLE((nint)(value));

        public static explicit operator ushort(NFC_SE_HANDLE value) => (ushort)(value.Value);

        public static explicit operator NFC_SE_HANDLE(uint value) => new NFC_SE_HANDLE((nint)(value));

        public static explicit operator uint(NFC_SE_HANDLE value) => (uint)(value.Value);

        public static explicit operator NFC_SE_HANDLE(ulong value) => new NFC_SE_HANDLE((nint)(value));

        public static implicit operator ulong(NFC_SE_HANDLE value) => (ulong)(value.Value);

        public static explicit operator NFC_SE_HANDLE(nuint value) => new NFC_SE_HANDLE((nint)(value));

        public static explicit operator nuint(NFC_SE_HANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is NFC_SE_HANDLE other) && Equals(other);

        public bool Equals(NFC_SE_HANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
