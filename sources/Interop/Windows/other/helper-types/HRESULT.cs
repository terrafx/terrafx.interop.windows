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

        public static implicit operator HRESULT(byte value) => new HRESULT((int)(value));

        public static explicit operator byte(HRESULT value) => (byte)(value.Value);

        public static implicit operator HRESULT(short value) => new HRESULT((int)(value));

        public static explicit operator short(HRESULT value) => (short)(value.Value);

        public static implicit operator HRESULT(int value) => new HRESULT((int)(value));

        public static implicit operator int(HRESULT value) => (int)(value.Value);

        public static explicit operator HRESULT(long value) => new HRESULT((int)(value));

        public static implicit operator long(HRESULT value) => (long)(value.Value);

        public static explicit operator HRESULT(nint value) => new HRESULT((int)(value));

        public static implicit operator nint(HRESULT value) => (nint)(value.Value);

        public static implicit operator HRESULT(sbyte value) => new HRESULT((int)(value));

        public static explicit operator sbyte(HRESULT value) => (sbyte)(value.Value);

        public static implicit operator HRESULT(ushort value) => new HRESULT((int)(value));

        public static explicit operator ushort(HRESULT value) => (ushort)(value.Value);

        public static explicit operator HRESULT(uint value) => new HRESULT((int)(value));

        public static explicit operator uint(HRESULT value) => (uint)(value.Value);

        public static explicit operator HRESULT(ulong value) => new HRESULT((int)(value));

        public static implicit operator ulong(HRESULT value) => (ulong)(value.Value);

        public static explicit operator HRESULT(nuint value) => new HRESULT((int)(value));

        public static implicit operator nuint(HRESULT value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HRESULT other) && Equals(other);

        public bool Equals(HRESULT other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
