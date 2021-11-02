// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HOBJECT : IEquatable<HOBJECT>
    {
        public readonly nint Value;

        public HOBJECT(nint value)
        {
            Value = value;
        }

        public static HOBJECT INVALID_VALUE => new HOBJECT(-1);

        public static HOBJECT NULL => new HOBJECT(0);

        public static bool operator ==(HOBJECT left, HOBJECT right) => left.Value == right.Value;

        public static bool operator !=(HOBJECT left, HOBJECT right) => left.Value != right.Value;

        public static explicit operator HOBJECT(void* value) => new HOBJECT((nint)(value));

        public static implicit operator void*(HOBJECT value) => (void*)(value.Value);

        public static explicit operator HOBJECT(HANDLE value) => new HOBJECT(value);

        public static implicit operator HANDLE(HOBJECT value) => new HOBJECT(value);

        public static explicit operator HOBJECT(byte value) => new HOBJECT((nint)(value));

        public static explicit operator byte(HOBJECT value) => (byte)(value.Value);

        public static explicit operator HOBJECT(short value) => new HOBJECT((nint)(value));

        public static explicit operator short(HOBJECT value) => (short)(value.Value);

        public static explicit operator HOBJECT(int value) => new HOBJECT((nint)(value));

        public static explicit operator int(HOBJECT value) => (int)(value.Value);

        public static explicit operator HOBJECT(long value) => new HOBJECT((nint)(value));

        public static implicit operator long(HOBJECT value) => (long)(value.Value);

        public static explicit operator HOBJECT(nint value) => new HOBJECT((nint)(value));

        public static implicit operator nint(HOBJECT value) => (nint)(value.Value);

        public static explicit operator HOBJECT(sbyte value) => new HOBJECT((nint)(value));

        public static explicit operator sbyte(HOBJECT value) => (sbyte)(value.Value);

        public static explicit operator HOBJECT(ushort value) => new HOBJECT((nint)(value));

        public static explicit operator ushort(HOBJECT value) => (ushort)(value.Value);

        public static explicit operator HOBJECT(uint value) => new HOBJECT((nint)(value));

        public static explicit operator uint(HOBJECT value) => (uint)(value.Value);

        public static explicit operator HOBJECT(ulong value) => new HOBJECT((nint)(value));

        public static implicit operator ulong(HOBJECT value) => (ulong)(value.Value);

        public static explicit operator HOBJECT(nuint value) => new HOBJECT((nint)(value));

        public static explicit operator nuint(HOBJECT value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HOBJECT other) && Equals(other);

        public bool Equals(HOBJECT other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
