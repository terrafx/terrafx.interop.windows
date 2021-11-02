// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HACMDRIVERID : IEquatable<HACMDRIVERID>
    {
        public readonly nint Value;

        public HACMDRIVERID(nint value)
        {
            Value = value;
        }

        public static HACMDRIVERID INVALID_HANDLE_VALUE => new HACMDRIVERID(-1);

        public static HACMDRIVERID NULL => new HACMDRIVERID(0);

        public static bool operator ==(HACMDRIVERID left, HACMDRIVERID right) => left.Value == right.Value;

        public static bool operator !=(HACMDRIVERID left, HACMDRIVERID right) => left.Value != right.Value;

        public static explicit operator HACMDRIVERID(void* value) => new HACMDRIVERID((nint)(value));

        public static implicit operator void*(HACMDRIVERID value) => (void*)(value.Value);

        public static explicit operator HACMDRIVERID(HANDLE value) => new HACMDRIVERID(value);

        public static implicit operator HANDLE(HACMDRIVERID value) => new HACMDRIVERID(value);

        public static explicit operator HACMDRIVERID(byte value) => new HACMDRIVERID((nint)(value));

        public static implicit operator byte(HACMDRIVERID value) => (byte)(value.Value);

        public static explicit operator HACMDRIVERID(short value) => new HACMDRIVERID((nint)(value));

        public static implicit operator short(HACMDRIVERID value) => (short)(value.Value);

        public static explicit operator HACMDRIVERID(int value) => new HACMDRIVERID((nint)(value));

        public static implicit operator int(HACMDRIVERID value) => (int)(value.Value);

        public static explicit operator HACMDRIVERID(long value) => new HACMDRIVERID((nint)(value));

        public static explicit operator long(HACMDRIVERID value) => (long)(value.Value);

        public static explicit operator HACMDRIVERID(nint value) => new HACMDRIVERID((nint)(value));

        public static implicit operator nint(HACMDRIVERID value) => (nint)(value.Value);

        public static explicit operator HACMDRIVERID(sbyte value) => new HACMDRIVERID((nint)(value));

        public static implicit operator sbyte(HACMDRIVERID value) => (sbyte)(value.Value);

        public static explicit operator HACMDRIVERID(ushort value) => new HACMDRIVERID((nint)(value));

        public static implicit operator ushort(HACMDRIVERID value) => (ushort)(value.Value);

        public static explicit operator HACMDRIVERID(uint value) => new HACMDRIVERID((nint)(value));

        public static implicit operator uint(HACMDRIVERID value) => (uint)(value.Value);

        public static explicit operator HACMDRIVERID(ulong value) => new HACMDRIVERID((nint)(value));

        public static explicit operator ulong(HACMDRIVERID value) => (ulong)(value.Value);

        public static explicit operator HACMDRIVERID(nuint value) => new HACMDRIVERID((nint)(value));

        public static explicit operator nuint(HACMDRIVERID value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HACMDRIVERID other) && Equals(other);

        public bool Equals(HACMDRIVERID other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
