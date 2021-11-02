// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCMNOTIFICATION : IEquatable<HCMNOTIFICATION>
    {
        public readonly nint Value;

        public HCMNOTIFICATION(nint value)
        {
            Value = value;
        }

        public static HCMNOTIFICATION INVALID_HANDLE_VALUE => new HCMNOTIFICATION(-1);

        public static HCMNOTIFICATION NULL => new HCMNOTIFICATION(0);

        public static bool operator ==(HCMNOTIFICATION left, HCMNOTIFICATION right) => left.Value == right.Value;

        public static bool operator !=(HCMNOTIFICATION left, HCMNOTIFICATION right) => left.Value != right.Value;

        public static explicit operator HCMNOTIFICATION(void* value) => new HCMNOTIFICATION((nint)(value));

        public static implicit operator void*(HCMNOTIFICATION value) => (void*)(value.Value);

        public static explicit operator HCMNOTIFICATION(HANDLE value) => new HCMNOTIFICATION(value);

        public static implicit operator HANDLE(HCMNOTIFICATION value) => new HCMNOTIFICATION(value);

        public static explicit operator HCMNOTIFICATION(byte value) => new HCMNOTIFICATION((nint)(value));

        public static implicit operator byte(HCMNOTIFICATION value) => (byte)(value.Value);

        public static explicit operator HCMNOTIFICATION(short value) => new HCMNOTIFICATION((nint)(value));

        public static implicit operator short(HCMNOTIFICATION value) => (short)(value.Value);

        public static explicit operator HCMNOTIFICATION(int value) => new HCMNOTIFICATION((nint)(value));

        public static implicit operator int(HCMNOTIFICATION value) => (int)(value.Value);

        public static explicit operator HCMNOTIFICATION(long value) => new HCMNOTIFICATION((nint)(value));

        public static explicit operator long(HCMNOTIFICATION value) => (long)(value.Value);

        public static explicit operator HCMNOTIFICATION(nint value) => new HCMNOTIFICATION((nint)(value));

        public static implicit operator nint(HCMNOTIFICATION value) => (nint)(value.Value);

        public static explicit operator HCMNOTIFICATION(sbyte value) => new HCMNOTIFICATION((nint)(value));

        public static implicit operator sbyte(HCMNOTIFICATION value) => (sbyte)(value.Value);

        public static explicit operator HCMNOTIFICATION(ushort value) => new HCMNOTIFICATION((nint)(value));

        public static implicit operator ushort(HCMNOTIFICATION value) => (ushort)(value.Value);

        public static explicit operator HCMNOTIFICATION(uint value) => new HCMNOTIFICATION((nint)(value));

        public static implicit operator uint(HCMNOTIFICATION value) => (uint)(value.Value);

        public static explicit operator HCMNOTIFICATION(ulong value) => new HCMNOTIFICATION((nint)(value));

        public static explicit operator ulong(HCMNOTIFICATION value) => (ulong)(value.Value);

        public static explicit operator HCMNOTIFICATION(nuint value) => new HCMNOTIFICATION((nint)(value));

        public static explicit operator nuint(HCMNOTIFICATION value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HCMNOTIFICATION other) && Equals(other);

        public bool Equals(HCMNOTIFICATION other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
