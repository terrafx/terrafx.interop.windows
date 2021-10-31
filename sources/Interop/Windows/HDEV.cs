// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDEV : IEquatable<HDEV>
    {
        public readonly nint Value;

        public static HDEV NULL => (HDEV)(0);

        public HDEV(int value)
        {
            Value = ((nint)(value));
        }

        public HDEV(uint value)
        {
            Value = ((nint)(value));
        }

        public HDEV(nint value)
        {
            Value = ((nint)(value));
        }

        public HDEV(nuint value)
        {
            Value = ((nint)(value));
        }

        public HDEV(void* value)
        {
            Value = ((nint)(value));
        }

        public HDEV(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HDEV left, HDEV right) => left.Value == right.Value;

        public static bool operator !=(HDEV left, HDEV right) => left.Value != right.Value;

        public static explicit operator HDEV(int value) => new HDEV(value);

        public static explicit operator HDEV(uint value) => new HDEV(value);

        public static explicit operator HDEV(nint value) => new HDEV(value);

        public static explicit operator HDEV(nuint value) => new HDEV(value);

        public static explicit operator HDEV(void* value) => new HDEV(value);

        public static explicit operator HDEV(HANDLE value) => new HDEV(value);

        public static implicit operator int(HDEV value) => (int)(value.Value);

        public static implicit operator uint(HDEV value) => (uint)(value.Value);

        public static implicit operator nint(HDEV value) => (nint)(value.Value);

        public static implicit operator nuint(HDEV value) => (nuint)(value.Value);

        public static implicit operator void*(HDEV value) => (void*)(value.Value);

        public static implicit operator HANDLE(HDEV value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HDEV other) && Equals(other);

        public bool Equals(HDEV other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
