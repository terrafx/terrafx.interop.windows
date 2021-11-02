// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTASYNC : IEquatable<HCRYPTASYNC>
    {
        public readonly nint Value;

        public HCRYPTASYNC(nint value)
        {
            Value = value;
        }

        public static HCRYPTASYNC INVALID_VALUE => new HCRYPTASYNC(-1);

        public static HCRYPTASYNC NULL => new HCRYPTASYNC(0);

        public static bool operator ==(HCRYPTASYNC left, HCRYPTASYNC right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTASYNC left, HCRYPTASYNC right) => left.Value != right.Value;

        public static explicit operator HCRYPTASYNC(void* value) => new HCRYPTASYNC((nint)(value));

        public static implicit operator void*(HCRYPTASYNC value) => (void*)(value.Value);

        public static explicit operator HCRYPTASYNC(HANDLE value) => new HCRYPTASYNC(value);

        public static implicit operator HANDLE(HCRYPTASYNC value) => new HCRYPTASYNC(value);

        public static explicit operator HCRYPTASYNC(byte value) => new HCRYPTASYNC((nint)(value));

        public static explicit operator byte(HCRYPTASYNC value) => (byte)(value.Value);

        public static explicit operator HCRYPTASYNC(short value) => new HCRYPTASYNC((nint)(value));

        public static explicit operator short(HCRYPTASYNC value) => (short)(value.Value);

        public static explicit operator HCRYPTASYNC(int value) => new HCRYPTASYNC((nint)(value));

        public static explicit operator int(HCRYPTASYNC value) => (int)(value.Value);

        public static explicit operator HCRYPTASYNC(long value) => new HCRYPTASYNC((nint)(value));

        public static implicit operator long(HCRYPTASYNC value) => (long)(value.Value);

        public static explicit operator HCRYPTASYNC(nint value) => new HCRYPTASYNC((nint)(value));

        public static implicit operator nint(HCRYPTASYNC value) => (nint)(value.Value);

        public static explicit operator HCRYPTASYNC(sbyte value) => new HCRYPTASYNC((nint)(value));

        public static explicit operator sbyte(HCRYPTASYNC value) => (sbyte)(value.Value);

        public static explicit operator HCRYPTASYNC(ushort value) => new HCRYPTASYNC((nint)(value));

        public static explicit operator ushort(HCRYPTASYNC value) => (ushort)(value.Value);

        public static explicit operator HCRYPTASYNC(uint value) => new HCRYPTASYNC((nint)(value));

        public static explicit operator uint(HCRYPTASYNC value) => (uint)(value.Value);

        public static explicit operator HCRYPTASYNC(ulong value) => new HCRYPTASYNC((nint)(value));

        public static implicit operator ulong(HCRYPTASYNC value) => (ulong)(value.Value);

        public static explicit operator HCRYPTASYNC(nuint value) => new HCRYPTASYNC((nint)(value));

        public static explicit operator nuint(HCRYPTASYNC value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HCRYPTASYNC other) && Equals(other);

        public bool Equals(HCRYPTASYNC other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
