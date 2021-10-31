// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct PRJ_DIR_ENTRY_BUFFER_HANDLE : IEquatable<PRJ_DIR_ENTRY_BUFFER_HANDLE>
    {
        public readonly nint Value;

        public PRJ_DIR_ENTRY_BUFFER_HANDLE(nint value)
        {
            Value = value;
        }

        public static bool operator ==(PRJ_DIR_ENTRY_BUFFER_HANDLE left, PRJ_DIR_ENTRY_BUFFER_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(PRJ_DIR_ENTRY_BUFFER_HANDLE left, PRJ_DIR_ENTRY_BUFFER_HANDLE right) => left.Value != right.Value;

        public static implicit operator PRJ_DIR_ENTRY_BUFFER_HANDLE(nint value) => new PRJ_DIR_ENTRY_BUFFER_HANDLE(value);

        public static implicit operator nint(PRJ_DIR_ENTRY_BUFFER_HANDLE value) => value.Value;

        public override bool Equals(object? obj) => (obj is PRJ_DIR_ENTRY_BUFFER_HANDLE other) && Equals(other);

        public bool Equals(PRJ_DIR_ENTRY_BUFFER_HANDLE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
