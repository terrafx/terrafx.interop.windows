// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HCERT_SERVER_OCSP_RESPONSE : IEquatable<HCERT_SERVER_OCSP_RESPONSE>
    {
        public readonly nint Value;

        public HCERT_SERVER_OCSP_RESPONSE(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HCERT_SERVER_OCSP_RESPONSE left, HCERT_SERVER_OCSP_RESPONSE right) => left.Value == right.Value;

        public static bool operator !=(HCERT_SERVER_OCSP_RESPONSE left, HCERT_SERVER_OCSP_RESPONSE right) => left.Value != right.Value;

        public static implicit operator HCERT_SERVER_OCSP_RESPONSE(nint value) => new HCERT_SERVER_OCSP_RESPONSE(value);

        public static implicit operator nint(HCERT_SERVER_OCSP_RESPONSE value) => value.Value;

        public override bool Equals(object? obj) => (obj is HCERT_SERVER_OCSP_RESPONSE other) && Equals(other);

        public bool Equals(HCERT_SERVER_OCSP_RESPONSE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
