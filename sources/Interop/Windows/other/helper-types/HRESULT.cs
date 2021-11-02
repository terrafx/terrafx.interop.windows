// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HRESULT : IEquatable<HRESULT>
    {
        public readonly int Value;

        public HRESULT(int value)
        {
            Value = value;
        }

        public static bool operator ==(HRESULT left, HRESULT right) => left.Value == right.Value;

        public static bool operator !=(HRESULT left, HRESULT right) => left.Value != right.Value;

        public static explicit operator HRESULT(byte value) => new HRESULT((int)(value));

        public static implicit operator byte(HRESULT value) => (byte)(value.Value);

        public static explicit operator HRESULT(short value) => new HRESULT((int)(value));

        public static implicit operator short(HRESULT value) => (short)(value.Value);

        public static implicit operator HRESULT(int value) => new HRESULT((int)(value));

        public static implicit operator int(HRESULT value) => (int)(value.Value);

        public static implicit operator HRESULT(long value) => new HRESULT((int)(value));

        public static explicit operator long(HRESULT value) => (long)(value.Value);

        public static implicit operator HRESULT(nint value) => new HRESULT((int)(value));

        public static explicit operator nint(HRESULT value) => (nint)(value.Value);

        public static explicit operator HRESULT(sbyte value) => new HRESULT((int)(value));

        public static implicit operator sbyte(HRESULT value) => (sbyte)(value.Value);

        public static explicit operator HRESULT(ushort value) => new HRESULT((int)(value));

        public static implicit operator ushort(HRESULT value) => (ushort)(value.Value);

        public static explicit operator HRESULT(uint value) => new HRESULT((int)(value));

        public static explicit operator uint(HRESULT value) => (uint)(value.Value);

        public static implicit operator HRESULT(ulong value) => new HRESULT((int)(value));

        public static explicit operator ulong(HRESULT value) => (ulong)(value.Value);

        public static implicit operator HRESULT(nuint value) => new HRESULT((int)(value));

        public static explicit operator nuint(HRESULT value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HRESULT other) && Equals(other);

        public bool Equals(HRESULT other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
