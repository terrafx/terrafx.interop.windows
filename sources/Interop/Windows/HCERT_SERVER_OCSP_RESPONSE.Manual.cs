// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop
{
    public unsafe partial struct HCERT_SERVER_OCSP_RESPONSE
    {
        public static explicit operator HCERT_SERVER_OCSP_RESPONSE(nuint value) => new HCERT_SERVER_OCSP_RESPONSE((nint)(value));

        public static explicit operator nuint(HCERT_SERVER_OCSP_RESPONSE value) => (nuint)(value.Value);

        public static explicit operator HCERT_SERVER_OCSP_RESPONSE(void* value) => new HCERT_SERVER_OCSP_RESPONSE((nint)(value));

        public static explicit operator void*(HCERT_SERVER_OCSP_RESPONSE value) => (void*)(value.Value);
    }
}
