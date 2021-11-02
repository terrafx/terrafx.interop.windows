// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HPOWERNOTIFY : IEquatable<HPOWERNOTIFY>
    {
        public readonly nint Value;

        public HPOWERNOTIFY(nint value)
        {
            Value = value;
        }

        public static HPOWERNOTIFY INVALID_HANDLE_VALUE => new HPOWERNOTIFY(-1);

        public static HPOWERNOTIFY NULL => new HPOWERNOTIFY(0);

        public static bool operator ==(HPOWERNOTIFY left, HPOWERNOTIFY right) => left.Value == right.Value;

        public static bool operator !=(HPOWERNOTIFY left, HPOWERNOTIFY right) => left.Value != right.Value;

        public static explicit operator HPOWERNOTIFY(void* value) => new HPOWERNOTIFY((nint)(value));

        public static implicit operator void*(HPOWERNOTIFY value) => (void*)(value.Value);

        public static explicit operator HPOWERNOTIFY(HANDLE value) => new HPOWERNOTIFY(value);

        public static implicit operator HANDLE(HPOWERNOTIFY value) => new HPOWERNOTIFY(value);

        public static explicit operator HPOWERNOTIFY(byte value) => new HPOWERNOTIFY((nint)(value));

        public static implicit operator byte(HPOWERNOTIFY value) => (byte)(value.Value);

        public static explicit operator HPOWERNOTIFY(short value) => new HPOWERNOTIFY((nint)(value));

        public static implicit operator short(HPOWERNOTIFY value) => (short)(value.Value);

        public static explicit operator HPOWERNOTIFY(int value) => new HPOWERNOTIFY((nint)(value));

        public static implicit operator int(HPOWERNOTIFY value) => (int)(value.Value);

        public static explicit operator HPOWERNOTIFY(long value) => new HPOWERNOTIFY((nint)(value));

        public static explicit operator long(HPOWERNOTIFY value) => (long)(value.Value);

        public static explicit operator HPOWERNOTIFY(nint value) => new HPOWERNOTIFY((nint)(value));

        public static implicit operator nint(HPOWERNOTIFY value) => (nint)(value.Value);

        public static explicit operator HPOWERNOTIFY(sbyte value) => new HPOWERNOTIFY((nint)(value));

        public static implicit operator sbyte(HPOWERNOTIFY value) => (sbyte)(value.Value);

        public static explicit operator HPOWERNOTIFY(ushort value) => new HPOWERNOTIFY((nint)(value));

        public static implicit operator ushort(HPOWERNOTIFY value) => (ushort)(value.Value);

        public static explicit operator HPOWERNOTIFY(uint value) => new HPOWERNOTIFY((nint)(value));

        public static implicit operator uint(HPOWERNOTIFY value) => (uint)(value.Value);

        public static explicit operator HPOWERNOTIFY(ulong value) => new HPOWERNOTIFY((nint)(value));

        public static explicit operator ulong(HPOWERNOTIFY value) => (ulong)(value.Value);

        public static explicit operator HPOWERNOTIFY(nuint value) => new HPOWERNOTIFY((nint)(value));

        public static explicit operator nuint(HPOWERNOTIFY value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HPOWERNOTIFY other) && Equals(other);

        public bool Equals(HPOWERNOTIFY other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
