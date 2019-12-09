// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.18632.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    public struct HRESULT : IEquatable<HRESULT>
    {
        private int _value;

        public HRESULT(int value)
        {
            _value = value;
        }

        public bool FAILED => FAILED(_value);

        public bool SUCCEEDED => SUCCEEDED(_value);

        public static bool operator ==(HRESULT l, HRESULT r) => l._value == r._value;

        public static bool operator !=(HRESULT l, HRESULT r) => !(l == r);

        public static implicit operator HRESULT(int value) => new HRESULT(value);

        public static implicit operator int(HRESULT value) => value._value;

        public override bool Equals(object? obj) => (obj is HRESULT other) && Equals(other);

        public bool Equals(HRESULT other) => this == other;

        public override int GetHashCode() => _value.GetHashCode();
    }
}
