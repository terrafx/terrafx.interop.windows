// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HTOUCHINPUT : IEquatable<HTOUCHINPUT>
    {
        public readonly nint Value;

        public HTOUCHINPUT(nint value)
        {
            Value = value;
        }

        public static HTOUCHINPUT INVALID_HANDLE_VALUE => new HTOUCHINPUT(-1);

        public static HTOUCHINPUT NULL => new HTOUCHINPUT(0);

        public static bool operator ==(HTOUCHINPUT left, HTOUCHINPUT right) => left.Value == right.Value;

        public static bool operator !=(HTOUCHINPUT left, HTOUCHINPUT right) => left.Value != right.Value;

        public static explicit operator HTOUCHINPUT(void* value) => new HTOUCHINPUT((nint)(value));

        public static implicit operator void*(HTOUCHINPUT value) => (void*)(value.Value);

        public static explicit operator HTOUCHINPUT(HANDLE value) => new HTOUCHINPUT(value);

        public static implicit operator HANDLE(HTOUCHINPUT value) => new HTOUCHINPUT(value);

        public static explicit operator HTOUCHINPUT(byte value) => new HTOUCHINPUT((nint)(value));

        public static implicit operator byte(HTOUCHINPUT value) => (byte)(value.Value);

        public static explicit operator HTOUCHINPUT(short value) => new HTOUCHINPUT((nint)(value));

        public static implicit operator short(HTOUCHINPUT value) => (short)(value.Value);

        public static explicit operator HTOUCHINPUT(int value) => new HTOUCHINPUT((nint)(value));

        public static implicit operator int(HTOUCHINPUT value) => (int)(value.Value);

        public static explicit operator HTOUCHINPUT(long value) => new HTOUCHINPUT((nint)(value));

        public static explicit operator long(HTOUCHINPUT value) => (long)(value.Value);

        public static explicit operator HTOUCHINPUT(nint value) => new HTOUCHINPUT((nint)(value));

        public static implicit operator nint(HTOUCHINPUT value) => (nint)(value.Value);

        public static explicit operator HTOUCHINPUT(sbyte value) => new HTOUCHINPUT((nint)(value));

        public static implicit operator sbyte(HTOUCHINPUT value) => (sbyte)(value.Value);

        public static explicit operator HTOUCHINPUT(ushort value) => new HTOUCHINPUT((nint)(value));

        public static implicit operator ushort(HTOUCHINPUT value) => (ushort)(value.Value);

        public static explicit operator HTOUCHINPUT(uint value) => new HTOUCHINPUT((nint)(value));

        public static implicit operator uint(HTOUCHINPUT value) => (uint)(value.Value);

        public static explicit operator HTOUCHINPUT(ulong value) => new HTOUCHINPUT((nint)(value));

        public static explicit operator ulong(HTOUCHINPUT value) => (ulong)(value.Value);

        public static explicit operator HTOUCHINPUT(nuint value) => new HTOUCHINPUT((nint)(value));

        public static explicit operator nuint(HTOUCHINPUT value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HTOUCHINPUT other) && Equals(other);

        public bool Equals(HTOUCHINPUT other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
