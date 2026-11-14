// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PP
{
    /// <include file='PP.xml' path='doc/member[@name="PP.PP_ENUMALGS"]/*' />
    [NativeTypeName("#define PP_ENUMALGS 1")]
    public const int PP_ENUMALGS = 1;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_ENUMCONTAINERS"]/*' />
    [NativeTypeName("#define PP_ENUMCONTAINERS 2")]
    public const int PP_ENUMCONTAINERS = 2;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_IMPTYPE"]/*' />
    [NativeTypeName("#define PP_IMPTYPE 3")]
    public const int PP_IMPTYPE = 3;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_NAME"]/*' />
    [NativeTypeName("#define PP_NAME 4")]
    public const int PP_NAME = 4;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_VERSION"]/*' />
    [NativeTypeName("#define PP_VERSION 5")]
    public const int PP_VERSION = 5;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_CONTAINER"]/*' />
    [NativeTypeName("#define PP_CONTAINER 6")]
    public const int PP_CONTAINER = 6;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_CHANGE_PASSWORD"]/*' />
    [NativeTypeName("#define PP_CHANGE_PASSWORD 7")]
    public const int PP_CHANGE_PASSWORD = 7;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_KEYSET_SEC_DESCR"]/*' />
    [NativeTypeName("#define PP_KEYSET_SEC_DESCR 8")]
    public const int PP_KEYSET_SEC_DESCR = 8;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_CERTCHAIN"]/*' />
    [NativeTypeName("#define PP_CERTCHAIN 9")]
    public const int PP_CERTCHAIN = 9;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_KEY_TYPE_SUBTYPE"]/*' />
    [NativeTypeName("#define PP_KEY_TYPE_SUBTYPE 10")]
    public const int PP_KEY_TYPE_SUBTYPE = 10;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_PROVTYPE"]/*' />
    [NativeTypeName("#define PP_PROVTYPE 16")]
    public const int PP_PROVTYPE = 16;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_KEYSTORAGE"]/*' />
    [NativeTypeName("#define PP_KEYSTORAGE 17")]
    public const int PP_KEYSTORAGE = 17;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_APPLI_CERT"]/*' />
    [NativeTypeName("#define PP_APPLI_CERT 18")]
    public const int PP_APPLI_CERT = 18;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_SYM_KEYSIZE"]/*' />
    [NativeTypeName("#define PP_SYM_KEYSIZE 19")]
    public const int PP_SYM_KEYSIZE = 19;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_SESSION_KEYSIZE"]/*' />
    [NativeTypeName("#define PP_SESSION_KEYSIZE 20")]
    public const int PP_SESSION_KEYSIZE = 20;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_UI_PROMPT"]/*' />
    [NativeTypeName("#define PP_UI_PROMPT 21")]
    public const int PP_UI_PROMPT = 21;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_ENUMALGS_EX"]/*' />
    [NativeTypeName("#define PP_ENUMALGS_EX 22")]
    public const int PP_ENUMALGS_EX = 22;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_ENUMMANDROOTS"]/*' />
    [NativeTypeName("#define PP_ENUMMANDROOTS 25")]
    public const int PP_ENUMMANDROOTS = 25;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_ENUMELECTROOTS"]/*' />
    [NativeTypeName("#define PP_ENUMELECTROOTS 26")]
    public const int PP_ENUMELECTROOTS = 26;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_KEYSET_TYPE"]/*' />
    [NativeTypeName("#define PP_KEYSET_TYPE 27")]
    public const int PP_KEYSET_TYPE = 27;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_ADMIN_PIN"]/*' />
    [NativeTypeName("#define PP_ADMIN_PIN 31")]
    public const int PP_ADMIN_PIN = 31;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_KEYEXCHANGE_PIN"]/*' />
    [NativeTypeName("#define PP_KEYEXCHANGE_PIN 32")]
    public const int PP_KEYEXCHANGE_PIN = 32;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_SIGNATURE_PIN"]/*' />
    [NativeTypeName("#define PP_SIGNATURE_PIN 33")]
    public const int PP_SIGNATURE_PIN = 33;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_SIG_KEYSIZE_INC"]/*' />
    [NativeTypeName("#define PP_SIG_KEYSIZE_INC 34")]
    public const int PP_SIG_KEYSIZE_INC = 34;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_KEYX_KEYSIZE_INC"]/*' />
    [NativeTypeName("#define PP_KEYX_KEYSIZE_INC 35")]
    public const int PP_KEYX_KEYSIZE_INC = 35;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_UNIQUE_CONTAINER"]/*' />
    [NativeTypeName("#define PP_UNIQUE_CONTAINER 36")]
    public const int PP_UNIQUE_CONTAINER = 36;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_SGC_INFO"]/*' />
    [NativeTypeName("#define PP_SGC_INFO 37")]
    public const int PP_SGC_INFO = 37;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_USE_HARDWARE_RNG"]/*' />
    [NativeTypeName("#define PP_USE_HARDWARE_RNG 38")]
    public const int PP_USE_HARDWARE_RNG = 38;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_KEYSPEC"]/*' />
    [NativeTypeName("#define PP_KEYSPEC 39")]
    public const int PP_KEYSPEC = 39;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_ENUMEX_SIGNING_PROT"]/*' />
    [NativeTypeName("#define PP_ENUMEX_SIGNING_PROT 40")]
    public const int PP_ENUMEX_SIGNING_PROT = 40;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_CRYPT_COUNT_KEY_USE"]/*' />
    [NativeTypeName("#define PP_CRYPT_COUNT_KEY_USE 41")]
    public const int PP_CRYPT_COUNT_KEY_USE = 41;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_USER_CERTSTORE"]/*' />
    [NativeTypeName("#define PP_USER_CERTSTORE 42")]
    public const int PP_USER_CERTSTORE = 42;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_SMARTCARD_READER"]/*' />
    [NativeTypeName("#define PP_SMARTCARD_READER 43")]
    public const int PP_SMARTCARD_READER = 43;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_SMARTCARD_GUID"]/*' />
    [NativeTypeName("#define PP_SMARTCARD_GUID 45")]
    public const int PP_SMARTCARD_GUID = 45;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_ROOT_CERTSTORE"]/*' />
    [NativeTypeName("#define PP_ROOT_CERTSTORE 46")]
    public const int PP_ROOT_CERTSTORE = 46;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_SMARTCARD_READER_ICON"]/*' />
    [NativeTypeName("#define PP_SMARTCARD_READER_ICON 47")]
    public const int PP_SMARTCARD_READER_ICON = 47;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_CLIENT_HWND"]/*' />
    [NativeTypeName("#define PP_CLIENT_HWND 1")]
    public const int PP_CLIENT_HWND = 1;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_CONTEXT_INFO"]/*' />
    [NativeTypeName("#define PP_CONTEXT_INFO 11")]
    public const int PP_CONTEXT_INFO = 11;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_KEYEXCHANGE_KEYSIZE"]/*' />
    [NativeTypeName("#define PP_KEYEXCHANGE_KEYSIZE 12")]
    public const int PP_KEYEXCHANGE_KEYSIZE = 12;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_SIGNATURE_KEYSIZE"]/*' />
    [NativeTypeName("#define PP_SIGNATURE_KEYSIZE 13")]
    public const int PP_SIGNATURE_KEYSIZE = 13;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_KEYEXCHANGE_ALG"]/*' />
    [NativeTypeName("#define PP_KEYEXCHANGE_ALG 14")]
    public const int PP_KEYEXCHANGE_ALG = 14;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_SIGNATURE_ALG"]/*' />
    [NativeTypeName("#define PP_SIGNATURE_ALG 15")]
    public const int PP_SIGNATURE_ALG = 15;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_DELETEKEY"]/*' />
    [NativeTypeName("#define PP_DELETEKEY 24")]
    public const int PP_DELETEKEY = 24;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_PIN_PROMPT_STRING"]/*' />
    [NativeTypeName("#define PP_PIN_PROMPT_STRING 44")]
    public const int PP_PIN_PROMPT_STRING = 44;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_SECURE_KEYEXCHANGE_PIN"]/*' />
    [NativeTypeName("#define PP_SECURE_KEYEXCHANGE_PIN 47")]
    public const int PP_SECURE_KEYEXCHANGE_PIN = 47;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_SECURE_SIGNATURE_PIN"]/*' />
    [NativeTypeName("#define PP_SECURE_SIGNATURE_PIN 48")]
    public const int PP_SECURE_SIGNATURE_PIN = 48;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_DISMISS_PIN_UI_SEC"]/*' />
    [NativeTypeName("#define PP_DISMISS_PIN_UI_SEC 49")]
    public const int PP_DISMISS_PIN_UI_SEC = 49;

    /// <include file='PP.xml' path='doc/member[@name="PP.PP_IS_PFX_EPHEMERAL"]/*' />
    [NativeTypeName("#define PP_IS_PFX_EPHEMERAL 50")]
    public const int PP_IS_PFX_EPHEMERAL = 50;
}
