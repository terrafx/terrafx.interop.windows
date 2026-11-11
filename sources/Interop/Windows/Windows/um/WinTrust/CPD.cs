// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CPD
{
    /// <include file='CPD.xml' path='doc/member[@name="CPD.CPD_CHOICE_SIP"]/*' />
    [NativeTypeName("#define CPD_CHOICE_SIP 1")]
    public const int CPD_CHOICE_SIP = 1;

    /// <include file='CPD.xml' path='doc/member[@name="CPD.CPD_USE_NT5_CHAIN_FLAG"]/*' />
    [NativeTypeName("#define CPD_USE_NT5_CHAIN_FLAG 0x80000000")]
    public const uint CPD_USE_NT5_CHAIN_FLAG = 0x80000000;

    /// <include file='CPD.xml' path='doc/member[@name="CPD.CPD_REVOCATION_CHECK_NONE"]/*' />
    [NativeTypeName("#define CPD_REVOCATION_CHECK_NONE 0x00010000")]
    public const int CPD_REVOCATION_CHECK_NONE = 0x00010000;

    /// <include file='CPD.xml' path='doc/member[@name="CPD.CPD_REVOCATION_CHECK_END_CERT"]/*' />
    [NativeTypeName("#define CPD_REVOCATION_CHECK_END_CERT 0x00020000")]
    public const int CPD_REVOCATION_CHECK_END_CERT = 0x00020000;

    /// <include file='CPD.xml' path='doc/member[@name="CPD.CPD_REVOCATION_CHECK_CHAIN"]/*' />
    [NativeTypeName("#define CPD_REVOCATION_CHECK_CHAIN 0x00040000")]
    public const int CPD_REVOCATION_CHECK_CHAIN = 0x00040000;

    /// <include file='CPD.xml' path='doc/member[@name="CPD.CPD_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT"]/*' />
    [NativeTypeName("#define CPD_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT 0x00080000")]
    public const int CPD_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT = 0x00080000;

    /// <include file='CPD.xml' path='doc/member[@name="CPD.CPD_RETURN_LOWER_QUALITY_CHAINS"]/*' />
    [NativeTypeName("#define CPD_RETURN_LOWER_QUALITY_CHAINS 0x00100000")]
    public const int CPD_RETURN_LOWER_QUALITY_CHAINS = 0x00100000;

    /// <include file='CPD.xml' path='doc/member[@name="CPD.CPD_RFC3161v21"]/*' />
    [NativeTypeName("#define CPD_RFC3161v21 0x00200000")]
    public const int CPD_RFC3161v21 = 0x00200000;

    /// <include file='CPD.xml' path='doc/member[@name="CPD.CPD_UISTATE_MODE_PROMPT"]/*' />
    [NativeTypeName("#define CPD_UISTATE_MODE_PROMPT 0x00000000")]
    public const int CPD_UISTATE_MODE_PROMPT = 0x00000000;

    /// <include file='CPD.xml' path='doc/member[@name="CPD.CPD_UISTATE_MODE_BLOCK"]/*' />
    [NativeTypeName("#define CPD_UISTATE_MODE_BLOCK 0x00000001")]
    public const int CPD_UISTATE_MODE_BLOCK = 0x00000001;

    /// <include file='CPD.xml' path='doc/member[@name="CPD.CPD_UISTATE_MODE_ALLOW"]/*' />
    [NativeTypeName("#define CPD_UISTATE_MODE_ALLOW 0x00000002")]
    public const int CPD_UISTATE_MODE_ALLOW = 0x00000002;

    /// <include file='CPD.xml' path='doc/member[@name="CPD.CPD_UISTATE_MODE_MASK"]/*' />
    [NativeTypeName("#define CPD_UISTATE_MODE_MASK 0x00000003")]
    public const int CPD_UISTATE_MODE_MASK = 0x00000003;
}
