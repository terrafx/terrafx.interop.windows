// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HUIAEVENT : IEquatable<HUIAEVENT>
    {
        public readonly nint Value;

        public HUIAEVENT(nint value)
        {
            Value = value;
        }

        public static HUIAEVENT INVALID_HANDLE_VALUE => new HUIAEVENT(-1);

        public static HUIAEVENT NULL => new HUIAEVENT(0);

        public static bool operator ==(HUIAEVENT left, HUIAEVENT right) => left.Value == right.Value;

        public static bool operator !=(HUIAEVENT left, HUIAEVENT right) => left.Value != right.Value;

        public static explicit operator HUIAEVENT(void* value) => new HUIAEVENT((nint)(value));

        public static implicit operator void*(HUIAEVENT value) => (void*)(value.Value);

        public static explicit operator HUIAEVENT(HANDLE value) => new HUIAEVENT(value);

        public static implicit operator HANDLE(HUIAEVENT value) => new HUIAEVENT(value);

        public static explicit operator HUIAEVENT(byte value) => new HUIAEVENT((nint)(value));

        public static implicit operator byte(HUIAEVENT value) => (byte)(value.Value);

        public static explicit operator HUIAEVENT(short value) => new HUIAEVENT((nint)(value));

        public static implicit operator short(HUIAEVENT value) => (short)(value.Value);

        public static explicit operator HUIAEVENT(int value) => new HUIAEVENT((nint)(value));

        public static implicit operator int(HUIAEVENT value) => (int)(value.Value);

        public static explicit operator HUIAEVENT(long value) => new HUIAEVENT((nint)(value));

        public static explicit operator long(HUIAEVENT value) => (long)(value.Value);

        public static explicit operator HUIAEVENT(nint value) => new HUIAEVENT((nint)(value));

        public static implicit operator nint(HUIAEVENT value) => (nint)(value.Value);

        public static explicit operator HUIAEVENT(sbyte value) => new HUIAEVENT((nint)(value));

        public static implicit operator sbyte(HUIAEVENT value) => (sbyte)(value.Value);

        public static explicit operator HUIAEVENT(ushort value) => new HUIAEVENT((nint)(value));

        public static implicit operator ushort(HUIAEVENT value) => (ushort)(value.Value);

        public static explicit operator HUIAEVENT(uint value) => new HUIAEVENT((nint)(value));

        public static implicit operator uint(HUIAEVENT value) => (uint)(value.Value);

        public static explicit operator HUIAEVENT(ulong value) => new HUIAEVENT((nint)(value));

        public static explicit operator ulong(HUIAEVENT value) => (ulong)(value.Value);

        public static explicit operator HUIAEVENT(nuint value) => new HUIAEVENT((nint)(value));

        public static explicit operator nuint(HUIAEVENT value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HUIAEVENT other) && Equals(other);

        public bool Equals(HUIAEVENT other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
