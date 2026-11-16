// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WTD
{
    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_UI_ALL"]/*' />
    [NativeTypeName("#define WTD_UI_ALL 1")]
    public const int WTD_UI_ALL = 1;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_UI_NONE"]/*' />
    [NativeTypeName("#define WTD_UI_NONE 2")]
    public const int WTD_UI_NONE = 2;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_UI_NOBAD"]/*' />
    [NativeTypeName("#define WTD_UI_NOBAD 3")]
    public const int WTD_UI_NOBAD = 3;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_UI_NOGOOD"]/*' />
    [NativeTypeName("#define WTD_UI_NOGOOD 4")]
    public const int WTD_UI_NOGOOD = 4;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_REVOKE_NONE"]/*' />
    [NativeTypeName("#define WTD_REVOKE_NONE 0x00000000")]
    public const int WTD_REVOKE_NONE = 0x00000000;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_REVOKE_WHOLECHAIN"]/*' />
    [NativeTypeName("#define WTD_REVOKE_WHOLECHAIN 0x00000001")]
    public const int WTD_REVOKE_WHOLECHAIN = 0x00000001;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_CHOICE_FILE"]/*' />
    [NativeTypeName("#define WTD_CHOICE_FILE 1")]
    public const int WTD_CHOICE_FILE = 1;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_CHOICE_CATALOG"]/*' />
    [NativeTypeName("#define WTD_CHOICE_CATALOG 2")]
    public const int WTD_CHOICE_CATALOG = 2;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_CHOICE_BLOB"]/*' />
    [NativeTypeName("#define WTD_CHOICE_BLOB 3")]
    public const int WTD_CHOICE_BLOB = 3;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_CHOICE_SIGNER"]/*' />
    [NativeTypeName("#define WTD_CHOICE_SIGNER 4")]
    public const int WTD_CHOICE_SIGNER = 4;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_CHOICE_CERT"]/*' />
    [NativeTypeName("#define WTD_CHOICE_CERT 5")]
    public const int WTD_CHOICE_CERT = 5;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_CHOICE_DETACHED_SIG"]/*' />
    [NativeTypeName("#define WTD_CHOICE_DETACHED_SIG 6")]
    public const int WTD_CHOICE_DETACHED_SIG = 6;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_STATEACTION_IGNORE"]/*' />
    [NativeTypeName("#define WTD_STATEACTION_IGNORE 0x00000000")]
    public const int WTD_STATEACTION_IGNORE = 0x00000000;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_STATEACTION_VERIFY"]/*' />
    [NativeTypeName("#define WTD_STATEACTION_VERIFY 0x00000001")]
    public const int WTD_STATEACTION_VERIFY = 0x00000001;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_STATEACTION_CLOSE"]/*' />
    [NativeTypeName("#define WTD_STATEACTION_CLOSE 0x00000002")]
    public const int WTD_STATEACTION_CLOSE = 0x00000002;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_STATEACTION_AUTO_CACHE"]/*' />
    [NativeTypeName("#define WTD_STATEACTION_AUTO_CACHE 0x00000003")]
    public const int WTD_STATEACTION_AUTO_CACHE = 0x00000003;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_STATEACTION_AUTO_CACHE_FLUSH"]/*' />
    [NativeTypeName("#define WTD_STATEACTION_AUTO_CACHE_FLUSH 0x00000004")]
    public const int WTD_STATEACTION_AUTO_CACHE_FLUSH = 0x00000004;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_PROV_FLAGS_MASK"]/*' />
    [NativeTypeName("#define WTD_PROV_FLAGS_MASK 0x0000FFFF")]
    public const int WTD_PROV_FLAGS_MASK = 0x0000FFFF;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_USE_IE4_TRUST_FLAG"]/*' />
    [NativeTypeName("#define WTD_USE_IE4_TRUST_FLAG 0x00000001")]
    public const int WTD_USE_IE4_TRUST_FLAG = 0x00000001;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_NO_IE4_CHAIN_FLAG"]/*' />
    [NativeTypeName("#define WTD_NO_IE4_CHAIN_FLAG 0x00000002")]
    public const int WTD_NO_IE4_CHAIN_FLAG = 0x00000002;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_NO_POLICY_USAGE_FLAG"]/*' />
    [NativeTypeName("#define WTD_NO_POLICY_USAGE_FLAG 0x00000004")]
    public const int WTD_NO_POLICY_USAGE_FLAG = 0x00000004;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_USE_LOCAL_MACHINE_CERTS"]/*' />
    [NativeTypeName("#define WTD_USE_LOCAL_MACHINE_CERTS 0x00000008")]
    public const int WTD_USE_LOCAL_MACHINE_CERTS = 0x00000008;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_REVOCATION_CHECK_NONE"]/*' />
    [NativeTypeName("#define WTD_REVOCATION_CHECK_NONE 0x00000010")]
    public const int WTD_REVOCATION_CHECK_NONE = 0x00000010;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_REVOCATION_CHECK_END_CERT"]/*' />
    [NativeTypeName("#define WTD_REVOCATION_CHECK_END_CERT 0x00000020")]
    public const int WTD_REVOCATION_CHECK_END_CERT = 0x00000020;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_REVOCATION_CHECK_CHAIN"]/*' />
    [NativeTypeName("#define WTD_REVOCATION_CHECK_CHAIN 0x00000040")]
    public const int WTD_REVOCATION_CHECK_CHAIN = 0x00000040;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT"]/*' />
    [NativeTypeName("#define WTD_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT 0x00000080")]
    public const int WTD_REVOCATION_CHECK_CHAIN_EXCLUDE_ROOT = 0x00000080;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_SAFER_FLAG"]/*' />
    [NativeTypeName("#define WTD_SAFER_FLAG 0x00000100")]
    public const int WTD_SAFER_FLAG = 0x00000100;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_HASH_ONLY_FLAG"]/*' />
    [NativeTypeName("#define WTD_HASH_ONLY_FLAG 0x00000200")]
    public const int WTD_HASH_ONLY_FLAG = 0x00000200;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_USE_DEFAULT_OSVER_CHECK"]/*' />
    [NativeTypeName("#define WTD_USE_DEFAULT_OSVER_CHECK 0x00000400")]
    public const int WTD_USE_DEFAULT_OSVER_CHECK = 0x00000400;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_LIFETIME_SIGNING_FLAG"]/*' />
    [NativeTypeName("#define WTD_LIFETIME_SIGNING_FLAG 0x00000800")]
    public const int WTD_LIFETIME_SIGNING_FLAG = 0x00000800;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_CACHE_ONLY_URL_RETRIEVAL"]/*' />
    [NativeTypeName("#define WTD_CACHE_ONLY_URL_RETRIEVAL 0x00001000")]
    public const int WTD_CACHE_ONLY_URL_RETRIEVAL = 0x00001000;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_DISABLE_MD2_MD4"]/*' />
    [NativeTypeName("#define WTD_DISABLE_MD2_MD4 0x00002000")]
    public const int WTD_DISABLE_MD2_MD4 = 0x00002000;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_MOTW"]/*' />
    [NativeTypeName("#define WTD_MOTW 0x00004000")]
    public const int WTD_MOTW = 0x00004000;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_CODE_INTEGRITY_DRIVER_MODE"]/*' />
    [NativeTypeName("#define WTD_CODE_INTEGRITY_DRIVER_MODE 0x00008000")]
    public const int WTD_CODE_INTEGRITY_DRIVER_MODE = 0x00008000;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_UICONTEXT_EXECUTE"]/*' />
    [NativeTypeName("#define WTD_UICONTEXT_EXECUTE 0")]
    public const int WTD_UICONTEXT_EXECUTE = 0;

    /// <include file='WTD.xml' path='doc/member[@name="WTD.WTD_UICONTEXT_INSTALL"]/*' />
    [NativeTypeName("#define WTD_UICONTEXT_INSTALL 1")]
    public const int WTD_UICONTEXT_INSTALL = 1;
}
