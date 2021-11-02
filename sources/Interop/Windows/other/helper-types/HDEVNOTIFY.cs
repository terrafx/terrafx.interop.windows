// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDEVNOTIFY : IEquatable<HDEVNOTIFY>
    {
        public readonly nint Value;

        public HDEVNOTIFY(nint value)
        {
            Value = value;
        }

        public static HDEVNOTIFY INVALID_VALUE => new HDEVNOTIFY(-1);

        public static HDEVNOTIFY NULL => new HDEVNOTIFY(0);

        public static bool operator ==(HDEVNOTIFY left, HDEVNOTIFY right) => left.Value == right.Value;

        public static bool operator !=(HDEVNOTIFY left, HDEVNOTIFY right) => left.Value != right.Value;

        public static explicit operator HDEVNOTIFY(void* value) => new HDEVNOTIFY((nint)(value));

        public static implicit operator void*(HDEVNOTIFY value) => (void*)(value.Value);

        public static explicit operator HDEVNOTIFY(HANDLE value) => new HDEVNOTIFY(value);

        public static implicit operator HANDLE(HDEVNOTIFY value) => new HDEVNOTIFY(value);

        public static explicit operator HDEVNOTIFY(byte value) => new HDEVNOTIFY((nint)(value));

        public static explicit operator byte(HDEVNOTIFY value) => (byte)(value.Value);

        public static explicit operator HDEVNOTIFY(short value) => new HDEVNOTIFY((nint)(value));

        public static explicit operator short(HDEVNOTIFY value) => (short)(value.Value);

        public static explicit operator HDEVNOTIFY(int value) => new HDEVNOTIFY((nint)(value));

        public static explicit operator int(HDEVNOTIFY value) => (int)(value.Value);

        public static explicit operator HDEVNOTIFY(long value) => new HDEVNOTIFY((nint)(value));

        public static implicit operator long(HDEVNOTIFY value) => (long)(value.Value);

        public static explicit operator HDEVNOTIFY(nint value) => new HDEVNOTIFY((nint)(value));

        public static implicit operator nint(HDEVNOTIFY value) => (nint)(value.Value);

        public static explicit operator HDEVNOTIFY(sbyte value) => new HDEVNOTIFY((nint)(value));

        public static explicit operator sbyte(HDEVNOTIFY value) => (sbyte)(value.Value);

        public static explicit operator HDEVNOTIFY(ushort value) => new HDEVNOTIFY((nint)(value));

        public static explicit operator ushort(HDEVNOTIFY value) => (ushort)(value.Value);

        public static explicit operator HDEVNOTIFY(uint value) => new HDEVNOTIFY((nint)(value));

        public static explicit operator uint(HDEVNOTIFY value) => (uint)(value.Value);

        public static explicit operator HDEVNOTIFY(ulong value) => new HDEVNOTIFY((nint)(value));

        public static implicit operator ulong(HDEVNOTIFY value) => (ulong)(value.Value);

        public static explicit operator HDEVNOTIFY(nuint value) => new HDEVNOTIFY((nint)(value));

        public static explicit operator nuint(HDEVNOTIFY value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HDEVNOTIFY other) && Equals(other);

        public bool Equals(HDEVNOTIFY other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
