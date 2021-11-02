// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct NFC_SNEP_CLIENT_HANDLE : IEquatable<NFC_SNEP_CLIENT_HANDLE>
    {
        public readonly nint Value;

        public NFC_SNEP_CLIENT_HANDLE(nint value)
        {
            Value = value;
        }

        public static NFC_SNEP_CLIENT_HANDLE INVALID_HANDLE_VALUE => new NFC_SNEP_CLIENT_HANDLE(-1);

        public static NFC_SNEP_CLIENT_HANDLE NULL => new NFC_SNEP_CLIENT_HANDLE(0);

        public static bool operator ==(NFC_SNEP_CLIENT_HANDLE left, NFC_SNEP_CLIENT_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(NFC_SNEP_CLIENT_HANDLE left, NFC_SNEP_CLIENT_HANDLE right) => left.Value != right.Value;

        public static explicit operator NFC_SNEP_CLIENT_HANDLE(void* value) => new NFC_SNEP_CLIENT_HANDLE((nint)(value));

        public static implicit operator void*(NFC_SNEP_CLIENT_HANDLE value) => (void*)(value.Value);

        public static explicit operator NFC_SNEP_CLIENT_HANDLE(HANDLE value) => new NFC_SNEP_CLIENT_HANDLE(value);

        public static implicit operator HANDLE(NFC_SNEP_CLIENT_HANDLE value) => new NFC_SNEP_CLIENT_HANDLE(value);

        public static explicit operator NFC_SNEP_CLIENT_HANDLE(byte value) => new NFC_SNEP_CLIENT_HANDLE((nint)(value));

        public static implicit operator byte(NFC_SNEP_CLIENT_HANDLE value) => (byte)(value.Value);

        public static explicit operator NFC_SNEP_CLIENT_HANDLE(short value) => new NFC_SNEP_CLIENT_HANDLE((nint)(value));

        public static implicit operator short(NFC_SNEP_CLIENT_HANDLE value) => (short)(value.Value);

        public static explicit operator NFC_SNEP_CLIENT_HANDLE(int value) => new NFC_SNEP_CLIENT_HANDLE((nint)(value));

        public static implicit operator int(NFC_SNEP_CLIENT_HANDLE value) => (int)(value.Value);

        public static explicit operator NFC_SNEP_CLIENT_HANDLE(long value) => new NFC_SNEP_CLIENT_HANDLE((nint)(value));

        public static explicit operator long(NFC_SNEP_CLIENT_HANDLE value) => (long)(value.Value);

        public static explicit operator NFC_SNEP_CLIENT_HANDLE(nint value) => new NFC_SNEP_CLIENT_HANDLE((nint)(value));

        public static implicit operator nint(NFC_SNEP_CLIENT_HANDLE value) => (nint)(value.Value);

        public static explicit operator NFC_SNEP_CLIENT_HANDLE(sbyte value) => new NFC_SNEP_CLIENT_HANDLE((nint)(value));

        public static implicit operator sbyte(NFC_SNEP_CLIENT_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator NFC_SNEP_CLIENT_HANDLE(ushort value) => new NFC_SNEP_CLIENT_HANDLE((nint)(value));

        public static implicit operator ushort(NFC_SNEP_CLIENT_HANDLE value) => (ushort)(value.Value);

        public static explicit operator NFC_SNEP_CLIENT_HANDLE(uint value) => new NFC_SNEP_CLIENT_HANDLE((nint)(value));

        public static implicit operator uint(NFC_SNEP_CLIENT_HANDLE value) => (uint)(value.Value);

        public static explicit operator NFC_SNEP_CLIENT_HANDLE(ulong value) => new NFC_SNEP_CLIENT_HANDLE((nint)(value));

        public static explicit operator ulong(NFC_SNEP_CLIENT_HANDLE value) => (ulong)(value.Value);

        public static explicit operator NFC_SNEP_CLIENT_HANDLE(nuint value) => new NFC_SNEP_CLIENT_HANDLE((nint)(value));

        public static explicit operator nuint(NFC_SNEP_CLIENT_HANDLE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is NFC_SNEP_CLIENT_HANDLE other) && Equals(other);

        public bool Equals(NFC_SNEP_CLIENT_HANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
