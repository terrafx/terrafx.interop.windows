// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CRYPTNET
{
    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_URL_CACHE_PRE_FETCH_NONE"]/*' />
    [NativeTypeName("#define CRYPTNET_URL_CACHE_PRE_FETCH_NONE 0")]
    public const int CRYPTNET_URL_CACHE_PRE_FETCH_NONE = 0;

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_URL_CACHE_PRE_FETCH_BLOB"]/*' />
    [NativeTypeName("#define CRYPTNET_URL_CACHE_PRE_FETCH_BLOB 1")]
    public const int CRYPTNET_URL_CACHE_PRE_FETCH_BLOB = 1;

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_URL_CACHE_PRE_FETCH_CRL"]/*' />
    [NativeTypeName("#define CRYPTNET_URL_CACHE_PRE_FETCH_CRL 2")]
    public const int CRYPTNET_URL_CACHE_PRE_FETCH_CRL = 2;

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_URL_CACHE_PRE_FETCH_OCSP"]/*' />
    [NativeTypeName("#define CRYPTNET_URL_CACHE_PRE_FETCH_OCSP 3")]
    public const int CRYPTNET_URL_CACHE_PRE_FETCH_OCSP = 3;

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_URL_CACHE_PRE_FETCH_AUTOROOT_CAB"]/*' />
    [NativeTypeName("#define CRYPTNET_URL_CACHE_PRE_FETCH_AUTOROOT_CAB 5")]
    public const int CRYPTNET_URL_CACHE_PRE_FETCH_AUTOROOT_CAB = 5;

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_URL_CACHE_PRE_FETCH_DISALLOWED_CERT_CAB"]/*' />
    [NativeTypeName("#define CRYPTNET_URL_CACHE_PRE_FETCH_DISALLOWED_CERT_CAB 6")]
    public const int CRYPTNET_URL_CACHE_PRE_FETCH_DISALLOWED_CERT_CAB = 6;

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_URL_CACHE_PRE_FETCH_PIN_RULES_CAB"]/*' />
    [NativeTypeName("#define CRYPTNET_URL_CACHE_PRE_FETCH_PIN_RULES_CAB 7")]
    public const int CRYPTNET_URL_CACHE_PRE_FETCH_PIN_RULES_CAB = 7;

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_URL_CACHE_DEFAULT_FLUSH"]/*' />
    [NativeTypeName("#define CRYPTNET_URL_CACHE_DEFAULT_FLUSH 0")]
    public const int CRYPTNET_URL_CACHE_DEFAULT_FLUSH = 0;

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_URL_CACHE_DISABLE_FLUSH"]/*' />
    [NativeTypeName("#define CRYPTNET_URL_CACHE_DISABLE_FLUSH 0xFFFFFFFF")]
    public const uint CRYPTNET_URL_CACHE_DISABLE_FLUSH = 0xFFFFFFFF;

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_URL_CACHE_RESPONSE_NONE"]/*' />
    [NativeTypeName("#define CRYPTNET_URL_CACHE_RESPONSE_NONE 0")]
    public const int CRYPTNET_URL_CACHE_RESPONSE_NONE = 0;

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_URL_CACHE_RESPONSE_HTTP"]/*' />
    [NativeTypeName("#define CRYPTNET_URL_CACHE_RESPONSE_HTTP 1")]
    public const int CRYPTNET_URL_CACHE_RESPONSE_HTTP = 1;

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_URL_CACHE_RESPONSE_VALIDATED"]/*' />
    [NativeTypeName("#define CRYPTNET_URL_CACHE_RESPONSE_VALIDATED 0x8000")]
    public const int CRYPTNET_URL_CACHE_RESPONSE_VALIDATED = 0x8000;

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_MAX_CACHED_OCSP_PER_CRL_COUNT_VALUE_NAME"]/*' />
    [NativeTypeName("#define CRYPTNET_MAX_CACHED_OCSP_PER_CRL_COUNT_VALUE_NAME L\"CryptnetMaxCachedOcspPerCrlCount\"")]
    public const string CRYPTNET_MAX_CACHED_OCSP_PER_CRL_COUNT_VALUE_NAME = "CryptnetMaxCachedOcspPerCrlCount";

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_MAX_CACHED_OCSP_PER_CRL_COUNT_DEFAULT"]/*' />
    [NativeTypeName("#define CRYPTNET_MAX_CACHED_OCSP_PER_CRL_COUNT_DEFAULT 500")]
    public const int CRYPTNET_MAX_CACHED_OCSP_PER_CRL_COUNT_DEFAULT = 500;

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_OCSP_AFTER_CRL_DISABLE"]/*' />
    [NativeTypeName("#define CRYPTNET_OCSP_AFTER_CRL_DISABLE 0xFFFFFFFF")]
    public const uint CRYPTNET_OCSP_AFTER_CRL_DISABLE = 0xFFFFFFFF;

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_URL_CACHE_DEFAULT_FLUSH_EXEMPT_SECONDS_VALUE_NAME"]/*' />
    [NativeTypeName("#define CRYPTNET_URL_CACHE_DEFAULT_FLUSH_EXEMPT_SECONDS_VALUE_NAME L\"CryptnetDefaultFlushExemptSeconds\"")]
    public const string CRYPTNET_URL_CACHE_DEFAULT_FLUSH_EXEMPT_SECONDS_VALUE_NAME = "CryptnetDefaultFlushExemptSeconds";

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_URL_CACHE_DEFAULT_FLUSH_EXEMPT_SECONDS_DEFAULT"]/*' />
    [NativeTypeName("#define CRYPTNET_URL_CACHE_DEFAULT_FLUSH_EXEMPT_SECONDS_DEFAULT (28 * 24 * 60 * 60)")]
    public const int CRYPTNET_URL_CACHE_DEFAULT_FLUSH_EXEMPT_SECONDS_DEFAULT = (28 * 24 * 60 * 60);

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_PRE_FETCH_MIN_MAX_AGE_SECONDS_VALUE_NAME"]/*' />
    [NativeTypeName("#define CRYPTNET_PRE_FETCH_MIN_MAX_AGE_SECONDS_VALUE_NAME L\"CryptnetPreFetchMinMaxAgeSeconds\"")]
    public const string CRYPTNET_PRE_FETCH_MIN_MAX_AGE_SECONDS_VALUE_NAME = "CryptnetPreFetchMinMaxAgeSeconds";

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_PRE_FETCH_MIN_MAX_AGE_SECONDS_DEFAULT"]/*' />
    [NativeTypeName("#define CRYPTNET_PRE_FETCH_MIN_MAX_AGE_SECONDS_DEFAULT (1 * 60 * 60)")]
    public const int CRYPTNET_PRE_FETCH_MIN_MAX_AGE_SECONDS_DEFAULT = (1 * 60 * 60);

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_PRE_FETCH_MAX_MAX_AGE_SECONDS_VALUE_NAME"]/*' />
    [NativeTypeName("#define CRYPTNET_PRE_FETCH_MAX_MAX_AGE_SECONDS_VALUE_NAME L\"CryptnetPreFetchMaxMaxAgeSeconds\"")]
    public const string CRYPTNET_PRE_FETCH_MAX_MAX_AGE_SECONDS_VALUE_NAME = "CryptnetPreFetchMaxMaxAgeSeconds";

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_PRE_FETCH_MAX_MAX_AGE_SECONDS_DEFAULT"]/*' />
    [NativeTypeName("#define CRYPTNET_PRE_FETCH_MAX_MAX_AGE_SECONDS_DEFAULT (14 * 24 * 60 * 60)")]
    public const int CRYPTNET_PRE_FETCH_MAX_MAX_AGE_SECONDS_DEFAULT = (14 * 24 * 60 * 60);

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_PRE_FETCH_MIN_OCSP_VALIDITY_PERIOD_SECONDS_VALUE_NAME"]/*' />
    [NativeTypeName("#define CRYPTNET_PRE_FETCH_MIN_OCSP_VALIDITY_PERIOD_SECONDS_VALUE_NAME L\"CryptnetPreFetchMinOcspValidityPeriodSeconds\"")]
    public const string CRYPTNET_PRE_FETCH_MIN_OCSP_VALIDITY_PERIOD_SECONDS_VALUE_NAME = "CryptnetPreFetchMinOcspValidityPeriodSeconds";

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_PRE_FETCH_MIN_OCSP_VALIDITY_PERIOD_SECONDS_DEFAULT"]/*' />
    [NativeTypeName("#define CRYPTNET_PRE_FETCH_MIN_OCSP_VALIDITY_PERIOD_SECONDS_DEFAULT (14 * 24 * 60 * 60)")]
    public const int CRYPTNET_PRE_FETCH_MIN_OCSP_VALIDITY_PERIOD_SECONDS_DEFAULT = (14 * 24 * 60 * 60);

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_PRE_FETCH_AFTER_PUBLISH_PRE_FETCH_DIVISOR_VALUE_NAME"]/*' />
    [NativeTypeName("#define CRYPTNET_PRE_FETCH_AFTER_PUBLISH_PRE_FETCH_DIVISOR_VALUE_NAME L\"CryptnetPreFetchAfterPublishPreFetchDivisor\"")]
    public const string CRYPTNET_PRE_FETCH_AFTER_PUBLISH_PRE_FETCH_DIVISOR_VALUE_NAME = "CryptnetPreFetchAfterPublishPreFetchDivisor";

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_PRE_FETCH_AFTER_PUBLISH_PRE_FETCH_DIVISOR_DEFAULT"]/*' />
    [NativeTypeName("#define CRYPTNET_PRE_FETCH_AFTER_PUBLISH_PRE_FETCH_DIVISOR_DEFAULT 10")]
    public const int CRYPTNET_PRE_FETCH_AFTER_PUBLISH_PRE_FETCH_DIVISOR_DEFAULT = 10;

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_PRE_FETCH_BEFORE_NEXT_UPDATE_PRE_FETCH_DIVISOR_VALUE_NAME"]/*' />
    [NativeTypeName("#define CRYPTNET_PRE_FETCH_BEFORE_NEXT_UPDATE_PRE_FETCH_DIVISOR_VALUE_NAME L\"CryptnetPreFetchBeforeNextUpdatePreFetchDivisor\"")]
    public const string CRYPTNET_PRE_FETCH_BEFORE_NEXT_UPDATE_PRE_FETCH_DIVISOR_VALUE_NAME = "CryptnetPreFetchBeforeNextUpdatePreFetchDivisor";

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_PRE_FETCH_BEFORE_NEXT_UPDATE_PRE_FETCH_DIVISOR_DEFAULT"]/*' />
    [NativeTypeName("#define CRYPTNET_PRE_FETCH_BEFORE_NEXT_UPDATE_PRE_FETCH_DIVISOR_DEFAULT 20")]
    public const int CRYPTNET_PRE_FETCH_BEFORE_NEXT_UPDATE_PRE_FETCH_DIVISOR_DEFAULT = 20;

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_PRE_FETCH_MIN_BEFORE_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_VALUE_NAME"]/*' />
    [NativeTypeName("#define CRYPTNET_PRE_FETCH_MIN_BEFORE_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_VALUE_NAME L\"CryptnetPreFetchMinBeforeNextUpdatePreFetchSeconds\"")]
    public const string CRYPTNET_PRE_FETCH_MIN_BEFORE_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_VALUE_NAME = "CryptnetPreFetchMinBeforeNextUpdatePreFetchSeconds";

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_PRE_FETCH_MIN_BEFORE_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_DEFAULT"]/*' />
    [NativeTypeName("#define CRYPTNET_PRE_FETCH_MIN_BEFORE_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_DEFAULT (1 * 60 * 60)")]
    public const int CRYPTNET_PRE_FETCH_MIN_BEFORE_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_DEFAULT = (1 * 60 * 60);

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_PRE_FETCH_VALIDITY_PERIOD_AFTER_NEXT_UPDATE_PRE_FETCH_DIVISOR_VALUE_NAME"]/*' />
    [NativeTypeName("#define CRYPTNET_PRE_FETCH_VALIDITY_PERIOD_AFTER_NEXT_UPDATE_PRE_FETCH_DIVISOR_VALUE_NAME L\"CryptnetPreFetchValidityPeriodAfterNextUpdatePreFetchDivisor\"")]
    public const string CRYPTNET_PRE_FETCH_VALIDITY_PERIOD_AFTER_NEXT_UPDATE_PRE_FETCH_DIVISOR_VALUE_NAME = "CryptnetPreFetchValidityPeriodAfterNextUpdatePreFetchDivisor";

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_PRE_FETCH_VALIDITY_PERIOD_AFTER_NEXT_UPDATE_PRE_FETCH_DIVISOR_DEFAULT"]/*' />
    [NativeTypeName("#define CRYPTNET_PRE_FETCH_VALIDITY_PERIOD_AFTER_NEXT_UPDATE_PRE_FETCH_DIVISOR_DEFAULT 10")]
    public const int CRYPTNET_PRE_FETCH_VALIDITY_PERIOD_AFTER_NEXT_UPDATE_PRE_FETCH_DIVISOR_DEFAULT = 10;

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_PRE_FETCH_MAX_AFTER_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_VALUE_NAME"]/*' />
    [NativeTypeName("#define CRYPTNET_PRE_FETCH_MAX_AFTER_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_VALUE_NAME L\"CryptnetPreFetchMaxAfterNextUpdatePreFetchPeriodSeconds\"")]
    public const string CRYPTNET_PRE_FETCH_MAX_AFTER_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_VALUE_NAME = "CryptnetPreFetchMaxAfterNextUpdatePreFetchPeriodSeconds";

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_PRE_FETCH_MAX_AFTER_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_DEFAULT"]/*' />
    [NativeTypeName("#define CRYPTNET_PRE_FETCH_MAX_AFTER_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_DEFAULT (4 * 60 * 60)")]
    public const int CRYPTNET_PRE_FETCH_MAX_AFTER_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_DEFAULT = (4 * 60 * 60);

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_PRE_FETCH_MIN_AFTER_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_VALUE_NAME"]/*' />
    [NativeTypeName("#define CRYPTNET_PRE_FETCH_MIN_AFTER_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_VALUE_NAME L\"CryptnetPreFetchMinAfterNextUpdatePreFetchPeriodSeconds\"")]
    public const string CRYPTNET_PRE_FETCH_MIN_AFTER_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_VALUE_NAME = "CryptnetPreFetchMinAfterNextUpdatePreFetchPeriodSeconds";

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_PRE_FETCH_MIN_AFTER_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_DEFAULT"]/*' />
    [NativeTypeName("#define CRYPTNET_PRE_FETCH_MIN_AFTER_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_DEFAULT (30 * 60)")]
    public const int CRYPTNET_PRE_FETCH_MIN_AFTER_NEXT_UPDATE_PRE_FETCH_PERIOD_SECONDS_DEFAULT = (30 * 60);

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_PRE_FETCH_AFTER_CURRENT_TIME_PRE_FETCH_PERIOD_SECONDS_VALUE_NAME"]/*' />
    [NativeTypeName("#define CRYPTNET_PRE_FETCH_AFTER_CURRENT_TIME_PRE_FETCH_PERIOD_SECONDS_VALUE_NAME L\"CryptnetPreFetchAfterCurrentTimePreFetchPeriodSeconds\"")]
    public const string CRYPTNET_PRE_FETCH_AFTER_CURRENT_TIME_PRE_FETCH_PERIOD_SECONDS_VALUE_NAME = "CryptnetPreFetchAfterCurrentTimePreFetchPeriodSeconds";

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_PRE_FETCH_AFTER_CURRENT_TIME_PRE_FETCH_PERIOD_SECONDS_DEFAULT"]/*' />
    [NativeTypeName("#define CRYPTNET_PRE_FETCH_AFTER_CURRENT_TIME_PRE_FETCH_PERIOD_SECONDS_DEFAULT (30 * 60)")]
    public const int CRYPTNET_PRE_FETCH_AFTER_CURRENT_TIME_PRE_FETCH_PERIOD_SECONDS_DEFAULT = (30 * 60);

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_PRE_FETCH_TRIGGER_PERIOD_SECONDS_VALUE_NAME"]/*' />
    [NativeTypeName("#define CRYPTNET_PRE_FETCH_TRIGGER_PERIOD_SECONDS_VALUE_NAME L\"CryptnetPreFetchTriggerPeriodSeconds\"")]
    public const string CRYPTNET_PRE_FETCH_TRIGGER_PERIOD_SECONDS_VALUE_NAME = "CryptnetPreFetchTriggerPeriodSeconds";

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_PRE_FETCH_TRIGGER_PERIOD_SECONDS_DEFAULT"]/*' />
    [NativeTypeName("#define CRYPTNET_PRE_FETCH_TRIGGER_PERIOD_SECONDS_DEFAULT (10 * 60)")]
    public const int CRYPTNET_PRE_FETCH_TRIGGER_PERIOD_SECONDS_DEFAULT = (10 * 60);

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_PRE_FETCH_TRIGGER_DISABLE"]/*' />
    [NativeTypeName("#define CRYPTNET_PRE_FETCH_TRIGGER_DISABLE 0xFFFFFFFF")]
    public const uint CRYPTNET_PRE_FETCH_TRIGGER_DISABLE = 0xFFFFFFFF;

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_PRE_FETCH_SCAN_AFTER_TRIGGER_DELAY_SECONDS_VALUE_NAME"]/*' />
    [NativeTypeName("#define CRYPTNET_PRE_FETCH_SCAN_AFTER_TRIGGER_DELAY_SECONDS_VALUE_NAME L\"CryptnetPreFetchScanAfterTriggerDelaySeconds\"")]
    public const string CRYPTNET_PRE_FETCH_SCAN_AFTER_TRIGGER_DELAY_SECONDS_VALUE_NAME = "CryptnetPreFetchScanAfterTriggerDelaySeconds";

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_PRE_FETCH_SCAN_AFTER_TRIGGER_DELAY_SECONDS_DEFAULT"]/*' />
    [NativeTypeName("#define CRYPTNET_PRE_FETCH_SCAN_AFTER_TRIGGER_DELAY_SECONDS_DEFAULT 60")]
    public const int CRYPTNET_PRE_FETCH_SCAN_AFTER_TRIGGER_DELAY_SECONDS_DEFAULT = 60;

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_PRE_FETCH_RETRIEVAL_TIMEOUT_SECONDS_VALUE_NAME"]/*' />
    [NativeTypeName("#define CRYPTNET_PRE_FETCH_RETRIEVAL_TIMEOUT_SECONDS_VALUE_NAME L\"CryptnetPreFetchRetrievalTimeoutSeconds\"")]
    public const string CRYPTNET_PRE_FETCH_RETRIEVAL_TIMEOUT_SECONDS_VALUE_NAME = "CryptnetPreFetchRetrievalTimeoutSeconds";

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_PRE_FETCH_RETRIEVAL_TIMEOUT_SECONDS_DEFAULT"]/*' />
    [NativeTypeName("#define CRYPTNET_PRE_FETCH_RETRIEVAL_TIMEOUT_SECONDS_DEFAULT (5 * 60)")]
    public const int CRYPTNET_PRE_FETCH_RETRIEVAL_TIMEOUT_SECONDS_DEFAULT = (5 * 60);

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_CRL_PRE_FETCH_CONFIG_REGPATH"]/*' />
    [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_CONFIG_REGPATH CERT_CHAIN_CONFIG_REGPATH L\"\\CrlPreFetch\"")]
    public const string CRYPTNET_CRL_PRE_FETCH_CONFIG_REGPATH = "Software\\Microsoft\\Cryptography\\OID\\EncodingType 0\\CertDllCreateCertificateChainEngine\\Config\\CrlPreFetch";

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_CRL_PRE_FETCH_PROCESS_NAME_LIST_VALUE_NAME"]/*' />
    [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_PROCESS_NAME_LIST_VALUE_NAME L\"ProcessNameList\"")]
    public const string CRYPTNET_CRL_PRE_FETCH_PROCESS_NAME_LIST_VALUE_NAME = "ProcessNameList";

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_CRL_PRE_FETCH_URL_LIST_VALUE_NAME"]/*' />
    [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_URL_LIST_VALUE_NAME L\"PreFetchUrlList\"")]
    public const string CRYPTNET_CRL_PRE_FETCH_URL_LIST_VALUE_NAME = "PreFetchUrlList";

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_CRL_PRE_FETCH_DISABLE_INFORMATION_EVENTS_VALUE_NAME"]/*' />
    [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_DISABLE_INFORMATION_EVENTS_VALUE_NAME L\"DisableInformationEvents\"")]
    public const string CRYPTNET_CRL_PRE_FETCH_DISABLE_INFORMATION_EVENTS_VALUE_NAME = "DisableInformationEvents";

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_CRL_PRE_FETCH_LOG_FILE_NAME_VALUE_NAME"]/*' />
    [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_LOG_FILE_NAME_VALUE_NAME L\"LogFileName\"")]
    public const string CRYPTNET_CRL_PRE_FETCH_LOG_FILE_NAME_VALUE_NAME = "LogFileName";

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_CRL_PRE_FETCH_TIMEOUT_SECONDS_VALUE_NAME"]/*' />
    [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_TIMEOUT_SECONDS_VALUE_NAME L\"TimeoutSeconds\"")]
    public const string CRYPTNET_CRL_PRE_FETCH_TIMEOUT_SECONDS_VALUE_NAME = "TimeoutSeconds";

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_CRL_PRE_FETCH_TIMEOUT_SECONDS_DEFAULT"]/*' />
    [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_TIMEOUT_SECONDS_DEFAULT (5 * 60)")]
    public const int CRYPTNET_CRL_PRE_FETCH_TIMEOUT_SECONDS_DEFAULT = (5 * 60);

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_CRL_PRE_FETCH_MAX_AGE_SECONDS_VALUE_NAME"]/*' />
    [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_MAX_AGE_SECONDS_VALUE_NAME L\"MaxAgeSeconds\"")]
    public const string CRYPTNET_CRL_PRE_FETCH_MAX_AGE_SECONDS_VALUE_NAME = "MaxAgeSeconds";

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_CRL_PRE_FETCH_MAX_AGE_SECONDS_DEFAULT"]/*' />
    [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_MAX_AGE_SECONDS_DEFAULT (2 * 60 * 60)")]
    public const int CRYPTNET_CRL_PRE_FETCH_MAX_AGE_SECONDS_DEFAULT = (2 * 60 * 60);

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_CRL_PRE_FETCH_MAX_AGE_SECONDS_MIN"]/*' />
    [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_MAX_AGE_SECONDS_MIN (5 * 60)")]
    public const int CRYPTNET_CRL_PRE_FETCH_MAX_AGE_SECONDS_MIN = (5 * 60);

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_CRL_PRE_FETCH_PUBLISH_BEFORE_NEXT_UPDATE_SECONDS_VALUE_NAME"]/*' />
    [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_PUBLISH_BEFORE_NEXT_UPDATE_SECONDS_VALUE_NAME L\"PublishBeforeNextUpdateSeconds\"")]
    public const string CRYPTNET_CRL_PRE_FETCH_PUBLISH_BEFORE_NEXT_UPDATE_SECONDS_VALUE_NAME = "PublishBeforeNextUpdateSeconds";

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_CRL_PRE_FETCH_PUBLISH_BEFORE_NEXT_UPDATE_SECONDS_DEFAULT"]/*' />
    [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_PUBLISH_BEFORE_NEXT_UPDATE_SECONDS_DEFAULT (1 * 60 * 60)")]
    public const int CRYPTNET_CRL_PRE_FETCH_PUBLISH_BEFORE_NEXT_UPDATE_SECONDS_DEFAULT = (1 * 60 * 60);

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_CRL_PRE_FETCH_PUBLISH_RANDOM_INTERVAL_SECONDS_VALUE_NAME"]/*' />
    [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_PUBLISH_RANDOM_INTERVAL_SECONDS_VALUE_NAME L\"PublishRandomIntervalSeconds\"")]
    public const string CRYPTNET_CRL_PRE_FETCH_PUBLISH_RANDOM_INTERVAL_SECONDS_VALUE_NAME = "PublishRandomIntervalSeconds";

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_CRL_PRE_FETCH_PUBLISH_RANDOM_INTERVAL_SECONDS_DEFAULT"]/*' />
    [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_PUBLISH_RANDOM_INTERVAL_SECONDS_DEFAULT (5 * 60)")]
    public const int CRYPTNET_CRL_PRE_FETCH_PUBLISH_RANDOM_INTERVAL_SECONDS_DEFAULT = (5 * 60);

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_CRL_PRE_FETCH_MIN_BEFORE_NEXT_UPDATE_SECONDS_VALUE_NAME"]/*' />
    [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_MIN_BEFORE_NEXT_UPDATE_SECONDS_VALUE_NAME L\"MinBeforeNextUpdateSeconds\"")]
    public const string CRYPTNET_CRL_PRE_FETCH_MIN_BEFORE_NEXT_UPDATE_SECONDS_VALUE_NAME = "MinBeforeNextUpdateSeconds";

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_CRL_PRE_FETCH_MIN_BEFORE_NEXT_UPDATE_SECONDS_DEFAULT"]/*' />
    [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_MIN_BEFORE_NEXT_UPDATE_SECONDS_DEFAULT (5 * 60)")]
    public const int CRYPTNET_CRL_PRE_FETCH_MIN_BEFORE_NEXT_UPDATE_SECONDS_DEFAULT = (5 * 60);

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_CRL_PRE_FETCH_MIN_AFTER_NEXT_UPDATE_SECONDS_VALUE_NAME"]/*' />
    [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_MIN_AFTER_NEXT_UPDATE_SECONDS_VALUE_NAME L\"MinAfterNextUpdateSeconds\"")]
    public const string CRYPTNET_CRL_PRE_FETCH_MIN_AFTER_NEXT_UPDATE_SECONDS_VALUE_NAME = "MinAfterNextUpdateSeconds";

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_CRL_PRE_FETCH_MIN_AFTER_NEXT_UPDATE_SECONDS_DEFAULT"]/*' />
    [NativeTypeName("#define CRYPTNET_CRL_PRE_FETCH_MIN_AFTER_NEXT_UPDATE_SECONDS_DEFAULT (5 * 60)")]
    public const int CRYPTNET_CRL_PRE_FETCH_MIN_AFTER_NEXT_UPDATE_SECONDS_DEFAULT = (5 * 60);

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_CACHED_OCSP_SWITCH_TO_CRL_COUNT_VALUE_NAME"]/*' />
    [NativeTypeName("#define CRYPTNET_CACHED_OCSP_SWITCH_TO_CRL_COUNT_VALUE_NAME L\"CryptnetCachedOcspSwitchToCrlCount\"")]
    public const string CRYPTNET_CACHED_OCSP_SWITCH_TO_CRL_COUNT_VALUE_NAME = "CryptnetCachedOcspSwitchToCrlCount";

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_CACHED_OCSP_SWITCH_TO_CRL_COUNT_DEFAULT"]/*' />
    [NativeTypeName("#define CRYPTNET_CACHED_OCSP_SWITCH_TO_CRL_COUNT_DEFAULT 50")]
    public const int CRYPTNET_CACHED_OCSP_SWITCH_TO_CRL_COUNT_DEFAULT = 50;

    /// <include file='CRYPTNET.xml' path='doc/member[@name="CRYPTNET.CRYPTNET_CRL_BEFORE_OCSP_ENABLE"]/*' />
    [NativeTypeName("#define CRYPTNET_CRL_BEFORE_OCSP_ENABLE 0xFFFFFFFF")]
    public const uint CRYPTNET_CRL_BEFORE_OCSP_ENABLE = 0xFFFFFFFF;
}
