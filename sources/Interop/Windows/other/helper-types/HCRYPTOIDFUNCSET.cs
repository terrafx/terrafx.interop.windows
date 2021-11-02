// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTOIDFUNCSET : IEquatable<HCRYPTOIDFUNCSET>
    {
        public readonly nint Value;

        public HCRYPTOIDFUNCSET(nint value)
        {
            Value = value;
        }

        public static HCRYPTOIDFUNCSET INVALID_VALUE => new HCRYPTOIDFUNCSET(-1);

        public static HCRYPTOIDFUNCSET NULL => new HCRYPTOIDFUNCSET(0);

        public static bool operator ==(HCRYPTOIDFUNCSET left, HCRYPTOIDFUNCSET right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTOIDFUNCSET left, HCRYPTOIDFUNCSET right) => left.Value != right.Value;

        public static explicit operator HCRYPTOIDFUNCSET(void* value) => new HCRYPTOIDFUNCSET((nint)(value));

        public static implicit operator void*(HCRYPTOIDFUNCSET value) => (void*)(value.Value);

        public static explicit operator HCRYPTOIDFUNCSET(HANDLE value) => new HCRYPTOIDFUNCSET(value);

        public static implicit operator HANDLE(HCRYPTOIDFUNCSET value) => new HANDLE(value.Value);

        public static explicit operator HCRYPTOIDFUNCSET(byte value) => new HCRYPTOIDFUNCSET((nint)(value));

        public static explicit operator byte(HCRYPTOIDFUNCSET value) => (byte)(value.Value);

        public static explicit operator HCRYPTOIDFUNCSET(short value) => new HCRYPTOIDFUNCSET((nint)(value));

        public static explicit operator short(HCRYPTOIDFUNCSET value) => (short)(value.Value);

        public static explicit operator HCRYPTOIDFUNCSET(int value) => new HCRYPTOIDFUNCSET((nint)(value));

        public static explicit operator int(HCRYPTOIDFUNCSET value) => (int)(value.Value);

        public static explicit operator HCRYPTOIDFUNCSET(long value) => new HCRYPTOIDFUNCSET((nint)(value));

        public static implicit operator long(HCRYPTOIDFUNCSET value) => (long)(value.Value);

        public static explicit operator HCRYPTOIDFUNCSET(nint value) => new HCRYPTOIDFUNCSET((nint)(value));

        public static implicit operator nint(HCRYPTOIDFUNCSET value) => (nint)(value.Value);

        public static explicit operator HCRYPTOIDFUNCSET(sbyte value) => new HCRYPTOIDFUNCSET((nint)(value));

        public static explicit operator sbyte(HCRYPTOIDFUNCSET value) => (sbyte)(value.Value);

        public static explicit operator HCRYPTOIDFUNCSET(ushort value) => new HCRYPTOIDFUNCSET((nint)(value));

        public static explicit operator ushort(HCRYPTOIDFUNCSET value) => (ushort)(value.Value);

        public static explicit operator HCRYPTOIDFUNCSET(uint value) => new HCRYPTOIDFUNCSET((nint)(value));

        public static explicit operator uint(HCRYPTOIDFUNCSET value) => (uint)(value.Value);

        public static explicit operator HCRYPTOIDFUNCSET(ulong value) => new HCRYPTOIDFUNCSET((nint)(value));

        public static explicit operator ulong(HCRYPTOIDFUNCSET value) => (ulong)(value.Value);

        public static explicit operator HCRYPTOIDFUNCSET(nuint value) => new HCRYPTOIDFUNCSET((nint)(value));

        public static explicit operator nuint(HCRYPTOIDFUNCSET value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HCRYPTOIDFUNCSET other) && Equals(other);

        public bool Equals(HCRYPTOIDFUNCSET other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
