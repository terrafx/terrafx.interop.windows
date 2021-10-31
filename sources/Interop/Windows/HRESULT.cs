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

        public HRESULT(uint value)
        {
            Value = ((int)(value));
        }

        public static bool operator ==(HRESULT left, HRESULT right) => left.Value == right.Value;

        public static bool operator !=(HRESULT left, HRESULT right) => left.Value != right.Value;

        public static explicit operator HRESULT(uint value) => newHRESULT(value);

        public static explicit operator uint(HRESULT value) => (uint)(value.Value);

        public static implicit operator HRESULT(int value) => new HRESULT(value);

        public static implicit operator int(HRESULT value) => value.Value;

        public override bool Equals(object? obj) => (obj is HRESULT other) && Equals(other);

        public bool Equals(HRESULT other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
