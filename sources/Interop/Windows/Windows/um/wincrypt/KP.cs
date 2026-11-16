// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class KP
{
    /// <include file='KP.xml' path='doc/member[@name="KP.KP_IV"]/*' />
    [NativeTypeName("#define KP_IV 1")]
    public const int KP_IV = 1;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_SALT"]/*' />
    [NativeTypeName("#define KP_SALT 2")]
    public const int KP_SALT = 2;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_PADDING"]/*' />
    [NativeTypeName("#define KP_PADDING 3")]
    public const int KP_PADDING = 3;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_MODE"]/*' />
    [NativeTypeName("#define KP_MODE 4")]
    public const int KP_MODE = 4;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_MODE_BITS"]/*' />
    [NativeTypeName("#define KP_MODE_BITS 5")]
    public const int KP_MODE_BITS = 5;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_PERMISSIONS"]/*' />
    [NativeTypeName("#define KP_PERMISSIONS 6")]
    public const int KP_PERMISSIONS = 6;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_ALGID"]/*' />
    [NativeTypeName("#define KP_ALGID 7")]
    public const int KP_ALGID = 7;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_BLOCKLEN"]/*' />
    [NativeTypeName("#define KP_BLOCKLEN 8")]
    public const int KP_BLOCKLEN = 8;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_KEYLEN"]/*' />
    [NativeTypeName("#define KP_KEYLEN 9")]
    public const int KP_KEYLEN = 9;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_SALT_EX"]/*' />
    [NativeTypeName("#define KP_SALT_EX 10")]
    public const int KP_SALT_EX = 10;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_P"]/*' />
    [NativeTypeName("#define KP_P 11")]
    public const int KP_P = 11;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_G"]/*' />
    [NativeTypeName("#define KP_G 12")]
    public const int KP_G = 12;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_Q"]/*' />
    [NativeTypeName("#define KP_Q 13")]
    public const int KP_Q = 13;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_X"]/*' />
    [NativeTypeName("#define KP_X 14")]
    public const int KP_X = 14;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_Y"]/*' />
    [NativeTypeName("#define KP_Y 15")]
    public const int KP_Y = 15;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_RA"]/*' />
    [NativeTypeName("#define KP_RA 16")]
    public const int KP_RA = 16;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_RB"]/*' />
    [NativeTypeName("#define KP_RB 17")]
    public const int KP_RB = 17;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_INFO"]/*' />
    [NativeTypeName("#define KP_INFO 18")]
    public const int KP_INFO = 18;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_EFFECTIVE_KEYLEN"]/*' />
    [NativeTypeName("#define KP_EFFECTIVE_KEYLEN 19")]
    public const int KP_EFFECTIVE_KEYLEN = 19;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_SCHANNEL_ALG"]/*' />
    [NativeTypeName("#define KP_SCHANNEL_ALG 20")]
    public const int KP_SCHANNEL_ALG = 20;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_CLIENT_RANDOM"]/*' />
    [NativeTypeName("#define KP_CLIENT_RANDOM 21")]
    public const int KP_CLIENT_RANDOM = 21;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_SERVER_RANDOM"]/*' />
    [NativeTypeName("#define KP_SERVER_RANDOM 22")]
    public const int KP_SERVER_RANDOM = 22;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_RP"]/*' />
    [NativeTypeName("#define KP_RP 23")]
    public const int KP_RP = 23;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_PRECOMP_MD5"]/*' />
    [NativeTypeName("#define KP_PRECOMP_MD5 24")]
    public const int KP_PRECOMP_MD5 = 24;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_PRECOMP_SHA"]/*' />
    [NativeTypeName("#define KP_PRECOMP_SHA 25")]
    public const int KP_PRECOMP_SHA = 25;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_CERTIFICATE"]/*' />
    [NativeTypeName("#define KP_CERTIFICATE 26")]
    public const int KP_CERTIFICATE = 26;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_CLEAR_KEY"]/*' />
    [NativeTypeName("#define KP_CLEAR_KEY 27")]
    public const int KP_CLEAR_KEY = 27;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_PUB_EX_LEN"]/*' />
    [NativeTypeName("#define KP_PUB_EX_LEN 28")]
    public const int KP_PUB_EX_LEN = 28;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_PUB_EX_VAL"]/*' />
    [NativeTypeName("#define KP_PUB_EX_VAL 29")]
    public const int KP_PUB_EX_VAL = 29;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_KEYVAL"]/*' />
    [NativeTypeName("#define KP_KEYVAL 30")]
    public const int KP_KEYVAL = 30;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_ADMIN_PIN"]/*' />
    [NativeTypeName("#define KP_ADMIN_PIN 31")]
    public const int KP_ADMIN_PIN = 31;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_KEYEXCHANGE_PIN"]/*' />
    [NativeTypeName("#define KP_KEYEXCHANGE_PIN 32")]
    public const int KP_KEYEXCHANGE_PIN = 32;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_SIGNATURE_PIN"]/*' />
    [NativeTypeName("#define KP_SIGNATURE_PIN 33")]
    public const int KP_SIGNATURE_PIN = 33;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_PREHASH"]/*' />
    [NativeTypeName("#define KP_PREHASH 34")]
    public const int KP_PREHASH = 34;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_ROUNDS"]/*' />
    [NativeTypeName("#define KP_ROUNDS 35")]
    public const int KP_ROUNDS = 35;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_OAEP_PARAMS"]/*' />
    [NativeTypeName("#define KP_OAEP_PARAMS 36")]
    public const int KP_OAEP_PARAMS = 36;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_CMS_KEY_INFO"]/*' />
    [NativeTypeName("#define KP_CMS_KEY_INFO 37")]
    public const int KP_CMS_KEY_INFO = 37;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_CMS_DH_KEY_INFO"]/*' />
    [NativeTypeName("#define KP_CMS_DH_KEY_INFO 38")]
    public const int KP_CMS_DH_KEY_INFO = 38;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_PUB_PARAMS"]/*' />
    [NativeTypeName("#define KP_PUB_PARAMS 39")]
    public const int KP_PUB_PARAMS = 39;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_VERIFY_PARAMS"]/*' />
    [NativeTypeName("#define KP_VERIFY_PARAMS 40")]
    public const int KP_VERIFY_PARAMS = 40;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_HIGHEST_VERSION"]/*' />
    [NativeTypeName("#define KP_HIGHEST_VERSION 41")]
    public const int KP_HIGHEST_VERSION = 41;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_GET_USE_COUNT"]/*' />
    [NativeTypeName("#define KP_GET_USE_COUNT 42")]
    public const int KP_GET_USE_COUNT = 42;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_PIN_ID"]/*' />
    [NativeTypeName("#define KP_PIN_ID 43")]
    public const int KP_PIN_ID = 43;

    /// <include file='KP.xml' path='doc/member[@name="KP.KP_PIN_INFO"]/*' />
    [NativeTypeName("#define KP_PIN_INFO 44")]
    public const int KP_PIN_INFO = 44;
}
