// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PCUSERIALIZEDPROPSTORAGE : IEquatable<PCUSERIALIZEDPROPSTORAGE>
    {
        public readonly nint Value;

        public PCUSERIALIZEDPROPSTORAGE(nint value)
        {
            Value = ((nint)(value));
        }

        public PCUSERIALIZEDPROPSTORAGE(nuint value)
        {
            Value = ((nint)(value));
        }

        public PCUSERIALIZEDPROPSTORAGE(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(PCUSERIALIZEDPROPSTORAGE left, PCUSERIALIZEDPROPSTORAGE right) => left.Value == right.Value;

        public static bool operator !=(PCUSERIALIZEDPROPSTORAGE left, PCUSERIALIZEDPROPSTORAGE right) => left.Value != right.Value;

        public static explicit operator PCUSERIALIZEDPROPSTORAGE(nint value) => new PCUSERIALIZEDPROPSTORAGE(value);

        public static explicit operator PCUSERIALIZEDPROPSTORAGE(nuint value) => new PCUSERIALIZEDPROPSTORAGE(value);

        public static explicit operator PCUSERIALIZEDPROPSTORAGE(void* value) => new PCUSERIALIZEDPROPSTORAGE(value);

        public static implicit operator nint(PCUSERIALIZEDPROPSTORAGE value) => (nint)(value.Value);

        public static implicit operator nuint(PCUSERIALIZEDPROPSTORAGE value) => (nuint)(value.Value);

        public static implicit operator void*(PCUSERIALIZEDPROPSTORAGE value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is PCUSERIALIZEDPROPSTORAGE other) && Equals(other);

        public bool Equals(PCUSERIALIZEDPROPSTORAGE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
