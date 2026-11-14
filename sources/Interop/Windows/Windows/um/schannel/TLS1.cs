// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class TLS1
{
    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_WARNING"]/*' />
    [NativeTypeName("#define TLS1_ALERT_WARNING 1")]
    public const int TLS1_ALERT_WARNING = 1;

    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_FATAL"]/*' />
    [NativeTypeName("#define TLS1_ALERT_FATAL 2")]
    public const int TLS1_ALERT_FATAL = 2;

    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_CLOSE_NOTIFY"]/*' />
    [NativeTypeName("#define TLS1_ALERT_CLOSE_NOTIFY 0")]
    public const int TLS1_ALERT_CLOSE_NOTIFY = 0;

    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_UNEXPECTED_MESSAGE"]/*' />
    [NativeTypeName("#define TLS1_ALERT_UNEXPECTED_MESSAGE 10")]
    public const int TLS1_ALERT_UNEXPECTED_MESSAGE = 10;

    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_BAD_RECORD_MAC"]/*' />
    [NativeTypeName("#define TLS1_ALERT_BAD_RECORD_MAC 20")]
    public const int TLS1_ALERT_BAD_RECORD_MAC = 20;

    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_DECRYPTION_FAILED"]/*' />
    [NativeTypeName("#define TLS1_ALERT_DECRYPTION_FAILED 21")]
    public const int TLS1_ALERT_DECRYPTION_FAILED = 21;

    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_RECORD_OVERFLOW"]/*' />
    [NativeTypeName("#define TLS1_ALERT_RECORD_OVERFLOW 22")]
    public const int TLS1_ALERT_RECORD_OVERFLOW = 22;

    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_DECOMPRESSION_FAIL"]/*' />
    [NativeTypeName("#define TLS1_ALERT_DECOMPRESSION_FAIL 30")]
    public const int TLS1_ALERT_DECOMPRESSION_FAIL = 30;

    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_HANDSHAKE_FAILURE"]/*' />
    [NativeTypeName("#define TLS1_ALERT_HANDSHAKE_FAILURE 40")]
    public const int TLS1_ALERT_HANDSHAKE_FAILURE = 40;

    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_BAD_CERTIFICATE"]/*' />
    [NativeTypeName("#define TLS1_ALERT_BAD_CERTIFICATE 42")]
    public const int TLS1_ALERT_BAD_CERTIFICATE = 42;

    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_UNSUPPORTED_CERT"]/*' />
    [NativeTypeName("#define TLS1_ALERT_UNSUPPORTED_CERT 43")]
    public const int TLS1_ALERT_UNSUPPORTED_CERT = 43;

    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_CERTIFICATE_REVOKED"]/*' />
    [NativeTypeName("#define TLS1_ALERT_CERTIFICATE_REVOKED 44")]
    public const int TLS1_ALERT_CERTIFICATE_REVOKED = 44;

    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_CERTIFICATE_EXPIRED"]/*' />
    [NativeTypeName("#define TLS1_ALERT_CERTIFICATE_EXPIRED 45")]
    public const int TLS1_ALERT_CERTIFICATE_EXPIRED = 45;

    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_CERTIFICATE_UNKNOWN"]/*' />
    [NativeTypeName("#define TLS1_ALERT_CERTIFICATE_UNKNOWN 46")]
    public const int TLS1_ALERT_CERTIFICATE_UNKNOWN = 46;

    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_ILLEGAL_PARAMETER"]/*' />
    [NativeTypeName("#define TLS1_ALERT_ILLEGAL_PARAMETER 47")]
    public const int TLS1_ALERT_ILLEGAL_PARAMETER = 47;

    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_UNKNOWN_CA"]/*' />
    [NativeTypeName("#define TLS1_ALERT_UNKNOWN_CA 48")]
    public const int TLS1_ALERT_UNKNOWN_CA = 48;

    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_ACCESS_DENIED"]/*' />
    [NativeTypeName("#define TLS1_ALERT_ACCESS_DENIED 49")]
    public const int TLS1_ALERT_ACCESS_DENIED = 49;

    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_DECODE_ERROR"]/*' />
    [NativeTypeName("#define TLS1_ALERT_DECODE_ERROR 50")]
    public const int TLS1_ALERT_DECODE_ERROR = 50;

    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_DECRYPT_ERROR"]/*' />
    [NativeTypeName("#define TLS1_ALERT_DECRYPT_ERROR 51")]
    public const int TLS1_ALERT_DECRYPT_ERROR = 51;

    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_EXPORT_RESTRICTION"]/*' />
    [NativeTypeName("#define TLS1_ALERT_EXPORT_RESTRICTION 60")]
    public const int TLS1_ALERT_EXPORT_RESTRICTION = 60;

    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_PROTOCOL_VERSION"]/*' />
    [NativeTypeName("#define TLS1_ALERT_PROTOCOL_VERSION 70")]
    public const int TLS1_ALERT_PROTOCOL_VERSION = 70;

    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_INSUFFIENT_SECURITY"]/*' />
    [NativeTypeName("#define TLS1_ALERT_INSUFFIENT_SECURITY 71")]
    public const int TLS1_ALERT_INSUFFIENT_SECURITY = 71;

    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_INTERNAL_ERROR"]/*' />
    [NativeTypeName("#define TLS1_ALERT_INTERNAL_ERROR 80")]
    public const int TLS1_ALERT_INTERNAL_ERROR = 80;

    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_USER_CANCELED"]/*' />
    [NativeTypeName("#define TLS1_ALERT_USER_CANCELED 90")]
    public const int TLS1_ALERT_USER_CANCELED = 90;

    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_NO_RENEGOTIATION"]/*' />
    [NativeTypeName("#define TLS1_ALERT_NO_RENEGOTIATION 100")]
    public const int TLS1_ALERT_NO_RENEGOTIATION = 100;

    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_UNSUPPORTED_EXT"]/*' />
    [NativeTypeName("#define TLS1_ALERT_UNSUPPORTED_EXT 110")]
    public const int TLS1_ALERT_UNSUPPORTED_EXT = 110;

    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_UNKNOWN_PSK_IDENTITY"]/*' />
    [NativeTypeName("#define TLS1_ALERT_UNKNOWN_PSK_IDENTITY 115")]
    public const int TLS1_ALERT_UNKNOWN_PSK_IDENTITY = 115;

    /// <include file='TLS1.xml' path='doc/member[@name="TLS1.TLS1_ALERT_NO_APP_PROTOCOL"]/*' />
    [NativeTypeName("#define TLS1_ALERT_NO_APP_PROTOCOL 120")]
    public const int TLS1_ALERT_NO_APP_PROTOCOL = 120;
}
