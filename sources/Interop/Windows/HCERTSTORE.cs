// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCERTSTORE : IEquatable<HCERTSTORE>
    {
        public readonly nint Value;

        public HCERTSTORE(nint value)
        {
            Value = value;
        }

        public static HCERTSTORE INVALID_HANDLE_VALUE => new HCERTSTORE(-1);

        public static HCERTSTORE NULL => new HCERTSTORE(0);

        public static bool operator ==(HCERTSTORE left, HCERTSTORE right) => left.Value == right.Value;

        public static bool operator !=(HCERTSTORE left, HCERTSTORE right) => left.Value != right.Value;

        public static explicit operator HCERTSTORE(void* value) => new HCERTSTORE((nint)(value));

        public static implicit operator void*(HCERTSTORE value) => (void*)(value.Value);

        public static explicit operator HCERTSTORE(HANDLE value) => new HCERTSTORE(value);

        public static implicit operator HANDLE(HCERTSTORE value) => new HCERTSTORE(value);

        public static explicit operator HCERTSTORE(byte value) => new HCERTSTORE((nint)(value));

        public static implicit operator byte(HCERTSTORE value) => (byte)(value.Value);

        public static explicit operator HCERTSTORE(short value) => new HCERTSTORE((nint)(value));

        public static implicit operator short(HCERTSTORE value) => (short)(value.Value);

        public static explicit operator HCERTSTORE(int value) => new HCERTSTORE((nint)(value));

        public static implicit operator int(HCERTSTORE value) => (int)(value.Value);

        public static explicit operator HCERTSTORE(long value) => new HCERTSTORE((nint)(value));

        public static explicit operator long(HCERTSTORE value) => (long)(value.Value);

        public static explicit operator HCERTSTORE(nint value) => new HCERTSTORE((nint)(value));

        public static implicit operator nint(HCERTSTORE value) => (nint)(value.Value);

        public static explicit operator HCERTSTORE(sbyte value) => new HCERTSTORE((nint)(value));

        public static implicit operator sbyte(HCERTSTORE value) => (sbyte)(value.Value);

        public static explicit operator HCERTSTORE(ushort value) => new HCERTSTORE((nint)(value));

        public static implicit operator ushort(HCERTSTORE value) => (ushort)(value.Value);

        public static explicit operator HCERTSTORE(uint value) => new HCERTSTORE((nint)(value));

        public static implicit operator uint(HCERTSTORE value) => (uint)(value.Value);

        public static explicit operator HCERTSTORE(ulong value) => new HCERTSTORE((nint)(value));

        public static explicit operator ulong(HCERTSTORE value) => (ulong)(value.Value);

        public static explicit operator HCERTSTORE(nuint value) => new HCERTSTORE((nint)(value));

        public static explicit operator nuint(HCERTSTORE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HCERTSTORE other) && Equals(other);

        public bool Equals(HCERTSTORE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
