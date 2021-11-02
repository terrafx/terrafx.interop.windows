// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HGDIOBJ : IEquatable<HGDIOBJ>
    {
        public readonly nint Value;

        public HGDIOBJ(nint value)
        {
            Value = value;
        }

        public static HGDIOBJ INVALID_VALUE => new HGDIOBJ(-1);

        public static HGDIOBJ NULL => new HGDIOBJ(0);

        public static bool operator ==(HGDIOBJ left, HGDIOBJ right) => left.Value == right.Value;

        public static bool operator !=(HGDIOBJ left, HGDIOBJ right) => left.Value != right.Value;

        public static explicit operator HGDIOBJ(void* value) => new HGDIOBJ((nint)(value));

        public static implicit operator void*(HGDIOBJ value) => (void*)(value.Value);

        public static explicit operator HGDIOBJ(HANDLE value) => new HGDIOBJ(value);

        public static implicit operator HANDLE(HGDIOBJ value) => new HGDIOBJ(value);

        public static explicit operator HGDIOBJ(byte value) => new HGDIOBJ((nint)(value));

        public static explicit operator byte(HGDIOBJ value) => (byte)(value.Value);

        public static explicit operator HGDIOBJ(short value) => new HGDIOBJ((nint)(value));

        public static explicit operator short(HGDIOBJ value) => (short)(value.Value);

        public static explicit operator HGDIOBJ(int value) => new HGDIOBJ((nint)(value));

        public static explicit operator int(HGDIOBJ value) => (int)(value.Value);

        public static explicit operator HGDIOBJ(long value) => new HGDIOBJ((nint)(value));

        public static implicit operator long(HGDIOBJ value) => (long)(value.Value);

        public static explicit operator HGDIOBJ(nint value) => new HGDIOBJ((nint)(value));

        public static implicit operator nint(HGDIOBJ value) => (nint)(value.Value);

        public static explicit operator HGDIOBJ(sbyte value) => new HGDIOBJ((nint)(value));

        public static explicit operator sbyte(HGDIOBJ value) => (sbyte)(value.Value);

        public static explicit operator HGDIOBJ(ushort value) => new HGDIOBJ((nint)(value));

        public static explicit operator ushort(HGDIOBJ value) => (ushort)(value.Value);

        public static explicit operator HGDIOBJ(uint value) => new HGDIOBJ((nint)(value));

        public static explicit operator uint(HGDIOBJ value) => (uint)(value.Value);

        public static explicit operator HGDIOBJ(ulong value) => new HGDIOBJ((nint)(value));

        public static explicit operator ulong(HGDIOBJ value) => (ulong)(value.Value);

        public static explicit operator HGDIOBJ(nuint value) => new HGDIOBJ((nint)(value));

        public static explicit operator nuint(HGDIOBJ value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HGDIOBJ other) && Equals(other);

        public bool Equals(HGDIOBJ other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
