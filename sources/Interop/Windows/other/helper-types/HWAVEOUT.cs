// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HWAVEOUT : IEquatable<HWAVEOUT>
    {
        public readonly nint Value;

        public HWAVEOUT(nint value)
        {
            Value = value;
        }

        public static HWAVEOUT INVALID_VALUE => new HWAVEOUT(-1);

        public static HWAVEOUT NULL => new HWAVEOUT(0);

        public static bool operator ==(HWAVEOUT left, HWAVEOUT right) => left.Value == right.Value;

        public static bool operator !=(HWAVEOUT left, HWAVEOUT right) => left.Value != right.Value;

        public static explicit operator HWAVEOUT(void* value) => new HWAVEOUT((nint)(value));

        public static implicit operator void*(HWAVEOUT value) => (void*)(value.Value);

        public static explicit operator HWAVEOUT(HANDLE value) => new HWAVEOUT(value);

        public static implicit operator HANDLE(HWAVEOUT value) => new HWAVEOUT(value);

        public static explicit operator HWAVEOUT(byte value) => new HWAVEOUT((nint)(value));

        public static explicit operator byte(HWAVEOUT value) => (byte)(value.Value);

        public static explicit operator HWAVEOUT(short value) => new HWAVEOUT((nint)(value));

        public static explicit operator short(HWAVEOUT value) => (short)(value.Value);

        public static explicit operator HWAVEOUT(int value) => new HWAVEOUT((nint)(value));

        public static explicit operator int(HWAVEOUT value) => (int)(value.Value);

        public static explicit operator HWAVEOUT(long value) => new HWAVEOUT((nint)(value));

        public static implicit operator long(HWAVEOUT value) => (long)(value.Value);

        public static explicit operator HWAVEOUT(nint value) => new HWAVEOUT((nint)(value));

        public static implicit operator nint(HWAVEOUT value) => (nint)(value.Value);

        public static explicit operator HWAVEOUT(sbyte value) => new HWAVEOUT((nint)(value));

        public static explicit operator sbyte(HWAVEOUT value) => (sbyte)(value.Value);

        public static explicit operator HWAVEOUT(ushort value) => new HWAVEOUT((nint)(value));

        public static explicit operator ushort(HWAVEOUT value) => (ushort)(value.Value);

        public static explicit operator HWAVEOUT(uint value) => new HWAVEOUT((nint)(value));

        public static explicit operator uint(HWAVEOUT value) => (uint)(value.Value);

        public static explicit operator HWAVEOUT(ulong value) => new HWAVEOUT((nint)(value));

        public static implicit operator ulong(HWAVEOUT value) => (ulong)(value.Value);

        public static explicit operator HWAVEOUT(nuint value) => new HWAVEOUT((nint)(value));

        public static explicit operator nuint(HWAVEOUT value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HWAVEOUT other) && Equals(other);

        public bool Equals(HWAVEOUT other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
