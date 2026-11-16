// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WSS
{
    /// <include file='WSS.xml' path='doc/member[@name="WSS.WSS_VERIFY_SPECIFIC"]/*' />
    [NativeTypeName("#define WSS_VERIFY_SPECIFIC 0x00000001")]
    public const int WSS_VERIFY_SPECIFIC = 0x00000001;

    /// <include file='WSS.xml' path='doc/member[@name="WSS.WSS_GET_SECONDARY_SIG_COUNT"]/*' />
    [NativeTypeName("#define WSS_GET_SECONDARY_SIG_COUNT 0x00000002")]
    public const int WSS_GET_SECONDARY_SIG_COUNT = 0x00000002;

    /// <include file='WSS.xml' path='doc/member[@name="WSS.WSS_VERIFY_SEALING"]/*' />
    [NativeTypeName("#define WSS_VERIFY_SEALING 0x00000004")]
    public const int WSS_VERIFY_SEALING = 0x00000004;

    /// <include file='WSS.xml' path='doc/member[@name="WSS.WSS_INPUT_FLAG_MASK"]/*' />
    [NativeTypeName("#define WSS_INPUT_FLAG_MASK 0x00000007")]
    public const int WSS_INPUT_FLAG_MASK = 0x00000007;

    /// <include file='WSS.xml' path='doc/member[@name="WSS.WSS_OUT_SEALING_STATUS_VERIFIED"]/*' />
    [NativeTypeName("#define WSS_OUT_SEALING_STATUS_VERIFIED 0x80000000")]
    public const uint WSS_OUT_SEALING_STATUS_VERIFIED = 0x80000000;

    /// <include file='WSS.xml' path='doc/member[@name="WSS.WSS_OUT_HAS_SEALING_INTENT"]/*' />
    [NativeTypeName("#define WSS_OUT_HAS_SEALING_INTENT 0x40000000")]
    public const int WSS_OUT_HAS_SEALING_INTENT = 0x40000000;

    /// <include file='WSS.xml' path='doc/member[@name="WSS.WSS_OUT_FILE_SUPPORTS_SEAL"]/*' />
    [NativeTypeName("#define WSS_OUT_FILE_SUPPORTS_SEAL 0x20000000")]
    public const int WSS_OUT_FILE_SUPPORTS_SEAL = 0x20000000;

    /// <include file='WSS.xml' path='doc/member[@name="WSS.WSS_OUTPUT_FLAG_MASK"]/*' />
    [NativeTypeName("#define WSS_OUTPUT_FLAG_MASK 0xe0000000")]
    public const uint WSS_OUTPUT_FLAG_MASK = 0xe0000000;

    /// <include file='WSS.xml' path='doc/member[@name="WSS.WSS_OBJTRUST_SUPPORT"]/*' />
    [NativeTypeName("#define WSS_OBJTRUST_SUPPORT 0x00000001")]
    public const int WSS_OBJTRUST_SUPPORT = 0x00000001;

    /// <include file='WSS.xml' path='doc/member[@name="WSS.WSS_SIGTRUST_SUPPORT"]/*' />
    [NativeTypeName("#define WSS_SIGTRUST_SUPPORT 0x00000002")]
    public const int WSS_SIGTRUST_SUPPORT = 0x00000002;

    /// <include file='WSS.xml' path='doc/member[@name="WSS.WSS_CERTTRUST_SUPPORT"]/*' />
    [NativeTypeName("#define WSS_CERTTRUST_SUPPORT 0x00000004")]
    public const int WSS_CERTTRUST_SUPPORT = 0x00000004;
}
