// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static nuint LSAP_SE_ADT_PARAMETER_ARRAY_TRUE_SIZE([NativeTypeName("PSE_ADT_PARAMETER_ARRAY")] SE_ADT_PARAMETER_ARRAY* AuditParameters)
    {
        uint unusedParameterCount = unchecked((uint)SE.SE_MAX_AUDIT_PARAMETERS - AuditParameters->ParameterCount);
        return unchecked((nuint)sizeof(SE_ADT_PARAMETER_ARRAY) - ((nuint)sizeof(SE_ADT_PARAMETER_ARRAY_ENTRY) * unusedParameterCount));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool LSA_SUCCESS(int Error) => Error >= 0;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint STAGING_FLAG(uint Effective) => (Effective & 0xFu) << 8;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint MSV1_0_IUM_SUPPLEMENTAL_CREDENTIAL_SIZE([NativeTypeName("PMSV1_0_IUM_SUPPLEMENTAL_CREDENTIAL")] MSV1_0_IUM_SUPPLEMENTAL_CREDENTIAL* Creds)
    {
        Unsafe.SkipInit(out MSV1_0_IUM_SUPPLEMENTAL_CREDENTIAL tmp);
        uint offset = unchecked((uint)(&tmp.EncryptedCreds.e0) - (uint)(&tmp));
        return unchecked(offset + Creds->EncryptedCredsSize);
    }

    [NativeTypeName("#define MSV1_0_NTLM3_MIN_NT_RESPONSE_LENGTH RTL_SIZEOF_THROUGH_FIELD(MSV1_0_NTLM3_RESPONSE, AvPairsOff)")]
    public static uint MSV1_0_NTLM3_MIN_NT_RESPONSE_LENGTH
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            Unsafe.SkipInit(out MSV1_0_NTLM3_RESPONSE tmp);
            return unchecked(((uint)(&tmp.AvPairsOff) - (uint)(&tmp)) + (uint)sizeof(uint));
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool KERB_IS_MS_PRINCIPAL(int principalNameType)
        => (principalNameType <= KRB.KRB_NT_MS_PRINCIPAL)
        || (principalNameType >= KRB.KRB_NT_ENTERPRISE_PRINCIPAL);
}
