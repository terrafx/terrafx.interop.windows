// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct FEATURE_STATE_CHANGE_SUBSCRIPTION : IEquatable<FEATURE_STATE_CHANGE_SUBSCRIPTION>
    {
        public readonly nint Value;

        public FEATURE_STATE_CHANGE_SUBSCRIPTION(nint value)
        {
            Value = value;
        }

        public static FEATURE_STATE_CHANGE_SUBSCRIPTION INVALID_VALUE => new FEATURE_STATE_CHANGE_SUBSCRIPTION(-1);

        public static FEATURE_STATE_CHANGE_SUBSCRIPTION NULL => new FEATURE_STATE_CHANGE_SUBSCRIPTION(0);

        public static bool operator ==(FEATURE_STATE_CHANGE_SUBSCRIPTION left, FEATURE_STATE_CHANGE_SUBSCRIPTION right) => left.Value == right.Value;

        public static bool operator !=(FEATURE_STATE_CHANGE_SUBSCRIPTION left, FEATURE_STATE_CHANGE_SUBSCRIPTION right) => left.Value != right.Value;

        public static explicit operator FEATURE_STATE_CHANGE_SUBSCRIPTION(void* value) => new FEATURE_STATE_CHANGE_SUBSCRIPTION((nint)(value));

        public static implicit operator void*(FEATURE_STATE_CHANGE_SUBSCRIPTION value) => (void*)(value.Value);

        public static explicit operator FEATURE_STATE_CHANGE_SUBSCRIPTION(HANDLE value) => new FEATURE_STATE_CHANGE_SUBSCRIPTION(value);

        public static implicit operator HANDLE(FEATURE_STATE_CHANGE_SUBSCRIPTION value) => new FEATURE_STATE_CHANGE_SUBSCRIPTION(value);

        public static explicit operator FEATURE_STATE_CHANGE_SUBSCRIPTION(byte value) => new FEATURE_STATE_CHANGE_SUBSCRIPTION((nint)(value));

        public static explicit operator byte(FEATURE_STATE_CHANGE_SUBSCRIPTION value) => (byte)(value.Value);

        public static explicit operator FEATURE_STATE_CHANGE_SUBSCRIPTION(short value) => new FEATURE_STATE_CHANGE_SUBSCRIPTION((nint)(value));

        public static explicit operator short(FEATURE_STATE_CHANGE_SUBSCRIPTION value) => (short)(value.Value);

        public static explicit operator FEATURE_STATE_CHANGE_SUBSCRIPTION(int value) => new FEATURE_STATE_CHANGE_SUBSCRIPTION((nint)(value));

        public static explicit operator int(FEATURE_STATE_CHANGE_SUBSCRIPTION value) => (int)(value.Value);

        public static explicit operator FEATURE_STATE_CHANGE_SUBSCRIPTION(long value) => new FEATURE_STATE_CHANGE_SUBSCRIPTION((nint)(value));

        public static implicit operator long(FEATURE_STATE_CHANGE_SUBSCRIPTION value) => (long)(value.Value);

        public static explicit operator FEATURE_STATE_CHANGE_SUBSCRIPTION(nint value) => new FEATURE_STATE_CHANGE_SUBSCRIPTION((nint)(value));

        public static implicit operator nint(FEATURE_STATE_CHANGE_SUBSCRIPTION value) => (nint)(value.Value);

        public static explicit operator FEATURE_STATE_CHANGE_SUBSCRIPTION(sbyte value) => new FEATURE_STATE_CHANGE_SUBSCRIPTION((nint)(value));

        public static explicit operator sbyte(FEATURE_STATE_CHANGE_SUBSCRIPTION value) => (sbyte)(value.Value);

        public static explicit operator FEATURE_STATE_CHANGE_SUBSCRIPTION(ushort value) => new FEATURE_STATE_CHANGE_SUBSCRIPTION((nint)(value));

        public static explicit operator ushort(FEATURE_STATE_CHANGE_SUBSCRIPTION value) => (ushort)(value.Value);

        public static explicit operator FEATURE_STATE_CHANGE_SUBSCRIPTION(uint value) => new FEATURE_STATE_CHANGE_SUBSCRIPTION((nint)(value));

        public static explicit operator uint(FEATURE_STATE_CHANGE_SUBSCRIPTION value) => (uint)(value.Value);

        public static explicit operator FEATURE_STATE_CHANGE_SUBSCRIPTION(ulong value) => new FEATURE_STATE_CHANGE_SUBSCRIPTION((nint)(value));

        public static implicit operator ulong(FEATURE_STATE_CHANGE_SUBSCRIPTION value) => (ulong)(value.Value);

        public static explicit operator FEATURE_STATE_CHANGE_SUBSCRIPTION(nuint value) => new FEATURE_STATE_CHANGE_SUBSCRIPTION((nint)(value));

        public static explicit operator nuint(FEATURE_STATE_CHANGE_SUBSCRIPTION value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is FEATURE_STATE_CHANGE_SUBSCRIPTION other) && Equals(other);

        public bool Equals(FEATURE_STATE_CHANGE_SUBSCRIPTION other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
