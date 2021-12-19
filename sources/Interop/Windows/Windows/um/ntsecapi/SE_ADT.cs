// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SE_ADT
{
    [NativeTypeName("#define SE_ADT_OBJECT_ONLY 0x1")]
    public const int SE_ADT_OBJECT_ONLY = 0x1;

    [NativeTypeName("#define SE_ADT_PARAMETERS_SELF_RELATIVE 0x00000001")]
    public const int SE_ADT_PARAMETERS_SELF_RELATIVE = 0x00000001;

    [NativeTypeName("#define SE_ADT_PARAMETERS_SEND_TO_LSA 0x00000002")]
    public const int SE_ADT_PARAMETERS_SEND_TO_LSA = 0x00000002;

    [NativeTypeName("#define SE_ADT_PARAMETER_EXTENSIBLE_AUDIT 0x00000004")]
    public const int SE_ADT_PARAMETER_EXTENSIBLE_AUDIT = 0x00000004;

    [NativeTypeName("#define SE_ADT_PARAMETER_GENERIC_AUDIT 0x00000008")]
    public const int SE_ADT_PARAMETER_GENERIC_AUDIT = 0x00000008;

    [NativeTypeName("#define SE_ADT_PARAMETER_WRITE_SYNCHRONOUS 0x00000010")]
    public const int SE_ADT_PARAMETER_WRITE_SYNCHRONOUS = 0x00000010;
}
