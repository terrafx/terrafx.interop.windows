// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HUIAPATTERNOBJECT : IEquatable<HUIAPATTERNOBJECT>
    {
        public readonly nint Value;

        public HUIAPATTERNOBJECT(nint value)
        {
            Value = value;
        }

        public static HUIAPATTERNOBJECT INVALID_HANDLE_VALUE => new HUIAPATTERNOBJECT(-1);

        public static HUIAPATTERNOBJECT NULL => new HUIAPATTERNOBJECT(0);

        public static bool operator ==(HUIAPATTERNOBJECT left, HUIAPATTERNOBJECT right) => left.Value == right.Value;

        public static bool operator !=(HUIAPATTERNOBJECT left, HUIAPATTERNOBJECT right) => left.Value != right.Value;

        public static explicit operator HUIAPATTERNOBJECT(void* value) => new HUIAPATTERNOBJECT((nint)(value));

        public static implicit operator void*(HUIAPATTERNOBJECT value) => (void*)(value.Value);

        public static explicit operator HUIAPATTERNOBJECT(HANDLE value) => new HUIAPATTERNOBJECT(value);

        public static implicit operator HANDLE(HUIAPATTERNOBJECT value) => new HUIAPATTERNOBJECT(value);

        public static explicit operator HUIAPATTERNOBJECT(byte value) => new HUIAPATTERNOBJECT((nint)(value));

        public static implicit operator byte(HUIAPATTERNOBJECT value) => (byte)(value.Value);

        public static explicit operator HUIAPATTERNOBJECT(short value) => new HUIAPATTERNOBJECT((nint)(value));

        public static implicit operator short(HUIAPATTERNOBJECT value) => (short)(value.Value);

        public static explicit operator HUIAPATTERNOBJECT(int value) => new HUIAPATTERNOBJECT((nint)(value));

        public static implicit operator int(HUIAPATTERNOBJECT value) => (int)(value.Value);

        public static explicit operator HUIAPATTERNOBJECT(long value) => new HUIAPATTERNOBJECT((nint)(value));

        public static explicit operator long(HUIAPATTERNOBJECT value) => (long)(value.Value);

        public static explicit operator HUIAPATTERNOBJECT(nint value) => new HUIAPATTERNOBJECT((nint)(value));

        public static implicit operator nint(HUIAPATTERNOBJECT value) => (nint)(value.Value);

        public static explicit operator HUIAPATTERNOBJECT(sbyte value) => new HUIAPATTERNOBJECT((nint)(value));

        public static implicit operator sbyte(HUIAPATTERNOBJECT value) => (sbyte)(value.Value);

        public static explicit operator HUIAPATTERNOBJECT(ushort value) => new HUIAPATTERNOBJECT((nint)(value));

        public static implicit operator ushort(HUIAPATTERNOBJECT value) => (ushort)(value.Value);

        public static explicit operator HUIAPATTERNOBJECT(uint value) => new HUIAPATTERNOBJECT((nint)(value));

        public static implicit operator uint(HUIAPATTERNOBJECT value) => (uint)(value.Value);

        public static explicit operator HUIAPATTERNOBJECT(ulong value) => new HUIAPATTERNOBJECT((nint)(value));

        public static explicit operator ulong(HUIAPATTERNOBJECT value) => (ulong)(value.Value);

        public static explicit operator HUIAPATTERNOBJECT(nuint value) => new HUIAPATTERNOBJECT((nint)(value));

        public static explicit operator nuint(HUIAPATTERNOBJECT value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HUIAPATTERNOBJECT other) && Equals(other);

        public bool Equals(HUIAPATTERNOBJECT other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
