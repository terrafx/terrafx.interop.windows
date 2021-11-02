// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSEMAPHORE : IEquatable<HSEMAPHORE>
    {
        public readonly nint Value;

        public HSEMAPHORE(nint value)
        {
            Value = value;
        }

        public static HSEMAPHORE INVALID_VALUE => new HSEMAPHORE(-1);

        public static HSEMAPHORE NULL => new HSEMAPHORE(0);

        public static bool operator ==(HSEMAPHORE left, HSEMAPHORE right) => left.Value == right.Value;

        public static bool operator !=(HSEMAPHORE left, HSEMAPHORE right) => left.Value != right.Value;

        public static explicit operator HSEMAPHORE(void* value) => new HSEMAPHORE((nint)(value));

        public static implicit operator void*(HSEMAPHORE value) => (void*)(value.Value);

        public static explicit operator HSEMAPHORE(HANDLE value) => new HSEMAPHORE(value);

        public static implicit operator HANDLE(HSEMAPHORE value) => new HANDLE(value.Value);

        public static explicit operator HSEMAPHORE(byte value) => new HSEMAPHORE((nint)(value));

        public static explicit operator byte(HSEMAPHORE value) => (byte)(value.Value);

        public static explicit operator HSEMAPHORE(short value) => new HSEMAPHORE((nint)(value));

        public static explicit operator short(HSEMAPHORE value) => (short)(value.Value);

        public static explicit operator HSEMAPHORE(int value) => new HSEMAPHORE((nint)(value));

        public static explicit operator int(HSEMAPHORE value) => (int)(value.Value);

        public static explicit operator HSEMAPHORE(long value) => new HSEMAPHORE((nint)(value));

        public static implicit operator long(HSEMAPHORE value) => (long)(value.Value);

        public static explicit operator HSEMAPHORE(nint value) => new HSEMAPHORE((nint)(value));

        public static implicit operator nint(HSEMAPHORE value) => (nint)(value.Value);

        public static explicit operator HSEMAPHORE(sbyte value) => new HSEMAPHORE((nint)(value));

        public static explicit operator sbyte(HSEMAPHORE value) => (sbyte)(value.Value);

        public static explicit operator HSEMAPHORE(ushort value) => new HSEMAPHORE((nint)(value));

        public static explicit operator ushort(HSEMAPHORE value) => (ushort)(value.Value);

        public static explicit operator HSEMAPHORE(uint value) => new HSEMAPHORE((nint)(value));

        public static explicit operator uint(HSEMAPHORE value) => (uint)(value.Value);

        public static explicit operator HSEMAPHORE(ulong value) => new HSEMAPHORE((nint)(value));

        public static explicit operator ulong(HSEMAPHORE value) => (ulong)(value.Value);

        public static explicit operator HSEMAPHORE(nuint value) => new HSEMAPHORE((nint)(value));

        public static explicit operator nuint(HSEMAPHORE value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HSEMAPHORE other) && Equals(other);

        public bool Equals(HSEMAPHORE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
