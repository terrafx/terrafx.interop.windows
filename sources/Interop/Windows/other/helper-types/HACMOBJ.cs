// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HACMOBJ : IEquatable<HACMOBJ>
    {
        public readonly nint Value;

        public HACMOBJ(nint value)
        {
            Value = value;
        }

        public static HACMOBJ INVALID_VALUE => new HACMOBJ(-1);

        public static HACMOBJ NULL => new HACMOBJ(0);

        public static bool operator ==(HACMOBJ left, HACMOBJ right) => left.Value == right.Value;

        public static bool operator !=(HACMOBJ left, HACMOBJ right) => left.Value != right.Value;

        public static explicit operator HACMOBJ(void* value) => new HACMOBJ((nint)(value));

        public static implicit operator void*(HACMOBJ value) => (void*)(value.Value);

        public static explicit operator HACMOBJ(HANDLE value) => new HACMOBJ(value);

        public static implicit operator HANDLE(HACMOBJ value) => new HACMOBJ(value);

        public static explicit operator HACMOBJ(byte value) => new HACMOBJ((nint)(value));

        public static explicit operator byte(HACMOBJ value) => (byte)(value.Value);

        public static explicit operator HACMOBJ(short value) => new HACMOBJ((nint)(value));

        public static explicit operator short(HACMOBJ value) => (short)(value.Value);

        public static explicit operator HACMOBJ(int value) => new HACMOBJ((nint)(value));

        public static explicit operator int(HACMOBJ value) => (int)(value.Value);

        public static explicit operator HACMOBJ(long value) => new HACMOBJ((nint)(value));

        public static implicit operator long(HACMOBJ value) => (long)(value.Value);

        public static explicit operator HACMOBJ(nint value) => new HACMOBJ((nint)(value));

        public static implicit operator nint(HACMOBJ value) => (nint)(value.Value);

        public static explicit operator HACMOBJ(sbyte value) => new HACMOBJ((nint)(value));

        public static explicit operator sbyte(HACMOBJ value) => (sbyte)(value.Value);

        public static explicit operator HACMOBJ(ushort value) => new HACMOBJ((nint)(value));

        public static explicit operator ushort(HACMOBJ value) => (ushort)(value.Value);

        public static explicit operator HACMOBJ(uint value) => new HACMOBJ((nint)(value));

        public static explicit operator uint(HACMOBJ value) => (uint)(value.Value);

        public static explicit operator HACMOBJ(ulong value) => new HACMOBJ((nint)(value));

        public static explicit operator ulong(HACMOBJ value) => (ulong)(value.Value);

        public static explicit operator HACMOBJ(nuint value) => new HACMOBJ((nint)(value));

        public static explicit operator nuint(HACMOBJ value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HACMOBJ other) && Equals(other);

        public bool Equals(HACMOBJ other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
