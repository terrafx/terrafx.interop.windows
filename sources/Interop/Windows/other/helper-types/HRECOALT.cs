// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HRECOALT : IEquatable<HRECOALT>
    {
        public readonly nint Value;

        public HRECOALT(nint value)
        {
            Value = value;
        }

        public static HRECOALT INVALID_VALUE => new HRECOALT(-1);

        public static HRECOALT NULL => new HRECOALT(0);

        public static bool operator ==(HRECOALT left, HRECOALT right) => left.Value == right.Value;

        public static bool operator !=(HRECOALT left, HRECOALT right) => left.Value != right.Value;

        public static explicit operator HRECOALT(void* value) => new HRECOALT((nint)(value));

        public static implicit operator void*(HRECOALT value) => (void*)(value.Value);

        public static explicit operator HRECOALT(HANDLE value) => new HRECOALT(value);

        public static implicit operator HANDLE(HRECOALT value) => new HANDLE(value.Value);

        public static explicit operator HRECOALT(byte value) => new HRECOALT((nint)(value));

        public static explicit operator byte(HRECOALT value) => (byte)(value.Value);

        public static explicit operator HRECOALT(short value) => new HRECOALT((nint)(value));

        public static explicit operator short(HRECOALT value) => (short)(value.Value);

        public static explicit operator HRECOALT(int value) => new HRECOALT((nint)(value));

        public static explicit operator int(HRECOALT value) => (int)(value.Value);

        public static explicit operator HRECOALT(long value) => new HRECOALT((nint)(value));

        public static implicit operator long(HRECOALT value) => (long)(value.Value);

        public static explicit operator HRECOALT(nint value) => new HRECOALT((nint)(value));

        public static implicit operator nint(HRECOALT value) => (nint)(value.Value);

        public static explicit operator HRECOALT(sbyte value) => new HRECOALT((nint)(value));

        public static explicit operator sbyte(HRECOALT value) => (sbyte)(value.Value);

        public static explicit operator HRECOALT(ushort value) => new HRECOALT((nint)(value));

        public static explicit operator ushort(HRECOALT value) => (ushort)(value.Value);

        public static explicit operator HRECOALT(uint value) => new HRECOALT((nint)(value));

        public static explicit operator uint(HRECOALT value) => (uint)(value.Value);

        public static explicit operator HRECOALT(ulong value) => new HRECOALT((nint)(value));

        public static explicit operator ulong(HRECOALT value) => (ulong)(value.Value);

        public static explicit operator HRECOALT(nuint value) => new HRECOALT((nint)(value));

        public static explicit operator nuint(HRECOALT value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HRECOALT other) && Equals(other);

        public bool Equals(HRECOALT other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
