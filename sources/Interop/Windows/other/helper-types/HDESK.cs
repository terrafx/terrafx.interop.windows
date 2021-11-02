// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDESK : IEquatable<HDESK>
    {
        public readonly nint Value;

        public HDESK(nint value)
        {
            Value = value;
        }

        public static HDESK INVALID_HANDLE_VALUE => new HDESK(-1);

        public static HDESK NULL => new HDESK(0);

        public static bool operator ==(HDESK left, HDESK right) => left.Value == right.Value;

        public static bool operator !=(HDESK left, HDESK right) => left.Value != right.Value;

        public static explicit operator HDESK(void* value) => new HDESK((nint)(value));

        public static implicit operator void*(HDESK value) => (void*)(value.Value);

        public static explicit operator HDESK(HANDLE value) => new HDESK(value);

        public static implicit operator HANDLE(HDESK value) => new HDESK(value);

        public static explicit operator HDESK(byte value) => new HDESK((nint)(value));

        public static explicit operator byte(HDESK value) => (byte)(value.Value);

        public static explicit operator HDESK(short value) => new HDESK((nint)(value));

        public static explicit operator short(HDESK value) => (short)(value.Value);

        public static explicit operator HDESK(int value) => new HDESK((nint)(value));

        public static explicit operator int(HDESK value) => (int)(value.Value);

        public static explicit operator HDESK(long value) => new HDESK((nint)(value));

        public static implicit operator long(HDESK value) => (long)(value.Value);

        public static explicit operator HDESK(nint value) => new HDESK((nint)(value));

        public static implicit operator nint(HDESK value) => (nint)(value.Value);

        public static explicit operator HDESK(sbyte value) => new HDESK((nint)(value));

        public static explicit operator sbyte(HDESK value) => (sbyte)(value.Value);

        public static explicit operator HDESK(ushort value) => new HDESK((nint)(value));

        public static explicit operator ushort(HDESK value) => (ushort)(value.Value);

        public static explicit operator HDESK(uint value) => new HDESK((nint)(value));

        public static explicit operator uint(HDESK value) => (uint)(value.Value);

        public static explicit operator HDESK(ulong value) => new HDESK((nint)(value));

        public static implicit operator ulong(HDESK value) => (ulong)(value.Value);

        public static explicit operator HDESK(nuint value) => new HDESK((nint)(value));

        public static explicit operator nuint(HDESK value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HDESK other) && Equals(other);

        public bool Equals(HDESK other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
