// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class DNS
{
    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RESPONSE_CODES_BASE"]/*' />
    [NativeTypeName("#define DNS_ERROR_RESPONSE_CODES_BASE 9000")]
    public const int DNS_ERROR_RESPONSE_CODES_BASE = 9000;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RCODE_NO_ERROR"]/*' />
    [NativeTypeName("#define DNS_ERROR_RCODE_NO_ERROR NO_ERROR")]
    public const int DNS_ERROR_RCODE_NO_ERROR = 0;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_MASK"]/*' />
    [NativeTypeName("#define DNS_ERROR_MASK 0x00002328")]
    public const int DNS_ERROR_MASK = 0x00002328;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RCODE_FORMAT_ERROR"]/*' />
    [NativeTypeName("#define DNS_ERROR_RCODE_FORMAT_ERROR 9001L")]
    public const int DNS_ERROR_RCODE_FORMAT_ERROR = 9001;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RCODE_SERVER_FAILURE"]/*' />
    [NativeTypeName("#define DNS_ERROR_RCODE_SERVER_FAILURE 9002L")]
    public const int DNS_ERROR_RCODE_SERVER_FAILURE = 9002;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RCODE_NAME_ERROR"]/*' />
    [NativeTypeName("#define DNS_ERROR_RCODE_NAME_ERROR 9003L")]
    public const int DNS_ERROR_RCODE_NAME_ERROR = 9003;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RCODE_NOT_IMPLEMENTED"]/*' />
    [NativeTypeName("#define DNS_ERROR_RCODE_NOT_IMPLEMENTED 9004L")]
    public const int DNS_ERROR_RCODE_NOT_IMPLEMENTED = 9004;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RCODE_REFUSED"]/*' />
    [NativeTypeName("#define DNS_ERROR_RCODE_REFUSED 9005L")]
    public const int DNS_ERROR_RCODE_REFUSED = 9005;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RCODE_YXDOMAIN"]/*' />
    [NativeTypeName("#define DNS_ERROR_RCODE_YXDOMAIN 9006L")]
    public const int DNS_ERROR_RCODE_YXDOMAIN = 9006;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RCODE_YXRRSET"]/*' />
    [NativeTypeName("#define DNS_ERROR_RCODE_YXRRSET 9007L")]
    public const int DNS_ERROR_RCODE_YXRRSET = 9007;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RCODE_NXRRSET"]/*' />
    [NativeTypeName("#define DNS_ERROR_RCODE_NXRRSET 9008L")]
    public const int DNS_ERROR_RCODE_NXRRSET = 9008;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RCODE_NOTAUTH"]/*' />
    [NativeTypeName("#define DNS_ERROR_RCODE_NOTAUTH 9009L")]
    public const int DNS_ERROR_RCODE_NOTAUTH = 9009;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RCODE_NOTZONE"]/*' />
    [NativeTypeName("#define DNS_ERROR_RCODE_NOTZONE 9010L")]
    public const int DNS_ERROR_RCODE_NOTZONE = 9010;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RCODE_BADSIG"]/*' />
    [NativeTypeName("#define DNS_ERROR_RCODE_BADSIG 9016L")]
    public const int DNS_ERROR_RCODE_BADSIG = 9016;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RCODE_BADKEY"]/*' />
    [NativeTypeName("#define DNS_ERROR_RCODE_BADKEY 9017L")]
    public const int DNS_ERROR_RCODE_BADKEY = 9017;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RCODE_BADTIME"]/*' />
    [NativeTypeName("#define DNS_ERROR_RCODE_BADTIME 9018L")]
    public const int DNS_ERROR_RCODE_BADTIME = 9018;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RCODE_LAST"]/*' />
    [NativeTypeName("#define DNS_ERROR_RCODE_LAST DNS_ERROR_RCODE_BADTIME")]
    public const int DNS_ERROR_RCODE_LAST = 9018;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_DNSSEC_BASE"]/*' />
    [NativeTypeName("#define DNS_ERROR_DNSSEC_BASE 9100")]
    public const int DNS_ERROR_DNSSEC_BASE = 9100;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_KEYMASTER_REQUIRED"]/*' />
    [NativeTypeName("#define DNS_ERROR_KEYMASTER_REQUIRED 9101L")]
    public const int DNS_ERROR_KEYMASTER_REQUIRED = 9101;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NOT_ALLOWED_ON_SIGNED_ZONE"]/*' />
    [NativeTypeName("#define DNS_ERROR_NOT_ALLOWED_ON_SIGNED_ZONE 9102L")]
    public const int DNS_ERROR_NOT_ALLOWED_ON_SIGNED_ZONE = 9102;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NSEC3_INCOMPATIBLE_WITH_RSA_SHA1"]/*' />
    [NativeTypeName("#define DNS_ERROR_NSEC3_INCOMPATIBLE_WITH_RSA_SHA1 9103L")]
    public const int DNS_ERROR_NSEC3_INCOMPATIBLE_WITH_RSA_SHA1 = 9103;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NOT_ENOUGH_SIGNING_KEY_DESCRIPTORS"]/*' />
    [NativeTypeName("#define DNS_ERROR_NOT_ENOUGH_SIGNING_KEY_DESCRIPTORS 9104L")]
    public const int DNS_ERROR_NOT_ENOUGH_SIGNING_KEY_DESCRIPTORS = 9104;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_UNSUPPORTED_ALGORITHM"]/*' />
    [NativeTypeName("#define DNS_ERROR_UNSUPPORTED_ALGORITHM 9105L")]
    public const int DNS_ERROR_UNSUPPORTED_ALGORITHM = 9105;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_INVALID_KEY_SIZE"]/*' />
    [NativeTypeName("#define DNS_ERROR_INVALID_KEY_SIZE 9106L")]
    public const int DNS_ERROR_INVALID_KEY_SIZE = 9106;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_SIGNING_KEY_NOT_ACCESSIBLE"]/*' />
    [NativeTypeName("#define DNS_ERROR_SIGNING_KEY_NOT_ACCESSIBLE 9107L")]
    public const int DNS_ERROR_SIGNING_KEY_NOT_ACCESSIBLE = 9107;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_KSP_DOES_NOT_SUPPORT_PROTECTION"]/*' />
    [NativeTypeName("#define DNS_ERROR_KSP_DOES_NOT_SUPPORT_PROTECTION 9108L")]
    public const int DNS_ERROR_KSP_DOES_NOT_SUPPORT_PROTECTION = 9108;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_UNEXPECTED_DATA_PROTECTION_ERROR"]/*' />
    [NativeTypeName("#define DNS_ERROR_UNEXPECTED_DATA_PROTECTION_ERROR 9109L")]
    public const int DNS_ERROR_UNEXPECTED_DATA_PROTECTION_ERROR = 9109;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_UNEXPECTED_CNG_ERROR"]/*' />
    [NativeTypeName("#define DNS_ERROR_UNEXPECTED_CNG_ERROR 9110L")]
    public const int DNS_ERROR_UNEXPECTED_CNG_ERROR = 9110;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_UNKNOWN_SIGNING_PARAMETER_VERSION"]/*' />
    [NativeTypeName("#define DNS_ERROR_UNKNOWN_SIGNING_PARAMETER_VERSION 9111L")]
    public const int DNS_ERROR_UNKNOWN_SIGNING_PARAMETER_VERSION = 9111;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_KSP_NOT_ACCESSIBLE"]/*' />
    [NativeTypeName("#define DNS_ERROR_KSP_NOT_ACCESSIBLE 9112L")]
    public const int DNS_ERROR_KSP_NOT_ACCESSIBLE = 9112;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_TOO_MANY_SKDS"]/*' />
    [NativeTypeName("#define DNS_ERROR_TOO_MANY_SKDS 9113L")]
    public const int DNS_ERROR_TOO_MANY_SKDS = 9113;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_INVALID_ROLLOVER_PERIOD"]/*' />
    [NativeTypeName("#define DNS_ERROR_INVALID_ROLLOVER_PERIOD 9114L")]
    public const int DNS_ERROR_INVALID_ROLLOVER_PERIOD = 9114;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_INVALID_INITIAL_ROLLOVER_OFFSET"]/*' />
    [NativeTypeName("#define DNS_ERROR_INVALID_INITIAL_ROLLOVER_OFFSET 9115L")]
    public const int DNS_ERROR_INVALID_INITIAL_ROLLOVER_OFFSET = 9115;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_ROLLOVER_IN_PROGRESS"]/*' />
    [NativeTypeName("#define DNS_ERROR_ROLLOVER_IN_PROGRESS 9116L")]
    public const int DNS_ERROR_ROLLOVER_IN_PROGRESS = 9116;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_STANDBY_KEY_NOT_PRESENT"]/*' />
    [NativeTypeName("#define DNS_ERROR_STANDBY_KEY_NOT_PRESENT 9117L")]
    public const int DNS_ERROR_STANDBY_KEY_NOT_PRESENT = 9117;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NOT_ALLOWED_ON_ZSK"]/*' />
    [NativeTypeName("#define DNS_ERROR_NOT_ALLOWED_ON_ZSK 9118L")]
    public const int DNS_ERROR_NOT_ALLOWED_ON_ZSK = 9118;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NOT_ALLOWED_ON_ACTIVE_SKD"]/*' />
    [NativeTypeName("#define DNS_ERROR_NOT_ALLOWED_ON_ACTIVE_SKD 9119L")]
    public const int DNS_ERROR_NOT_ALLOWED_ON_ACTIVE_SKD = 9119;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_ROLLOVER_ALREADY_QUEUED"]/*' />
    [NativeTypeName("#define DNS_ERROR_ROLLOVER_ALREADY_QUEUED 9120L")]
    public const int DNS_ERROR_ROLLOVER_ALREADY_QUEUED = 9120;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NOT_ALLOWED_ON_UNSIGNED_ZONE"]/*' />
    [NativeTypeName("#define DNS_ERROR_NOT_ALLOWED_ON_UNSIGNED_ZONE 9121L")]
    public const int DNS_ERROR_NOT_ALLOWED_ON_UNSIGNED_ZONE = 9121;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_BAD_KEYMASTER"]/*' />
    [NativeTypeName("#define DNS_ERROR_BAD_KEYMASTER 9122L")]
    public const int DNS_ERROR_BAD_KEYMASTER = 9122;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_INVALID_SIGNATURE_VALIDITY_PERIOD"]/*' />
    [NativeTypeName("#define DNS_ERROR_INVALID_SIGNATURE_VALIDITY_PERIOD 9123L")]
    public const int DNS_ERROR_INVALID_SIGNATURE_VALIDITY_PERIOD = 9123;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_INVALID_NSEC3_ITERATION_COUNT"]/*' />
    [NativeTypeName("#define DNS_ERROR_INVALID_NSEC3_ITERATION_COUNT 9124L")]
    public const int DNS_ERROR_INVALID_NSEC3_ITERATION_COUNT = 9124;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_DNSSEC_IS_DISABLED"]/*' />
    [NativeTypeName("#define DNS_ERROR_DNSSEC_IS_DISABLED 9125L")]
    public const int DNS_ERROR_DNSSEC_IS_DISABLED = 9125;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_INVALID_XML"]/*' />
    [NativeTypeName("#define DNS_ERROR_INVALID_XML 9126L")]
    public const int DNS_ERROR_INVALID_XML = 9126;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NO_VALID_TRUST_ANCHORS"]/*' />
    [NativeTypeName("#define DNS_ERROR_NO_VALID_TRUST_ANCHORS 9127L")]
    public const int DNS_ERROR_NO_VALID_TRUST_ANCHORS = 9127;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_ROLLOVER_NOT_POKEABLE"]/*' />
    [NativeTypeName("#define DNS_ERROR_ROLLOVER_NOT_POKEABLE 9128L")]
    public const int DNS_ERROR_ROLLOVER_NOT_POKEABLE = 9128;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NSEC3_NAME_COLLISION"]/*' />
    [NativeTypeName("#define DNS_ERROR_NSEC3_NAME_COLLISION 9129L")]
    public const int DNS_ERROR_NSEC3_NAME_COLLISION = 9129;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NSEC_INCOMPATIBLE_WITH_NSEC3_RSA_SHA1"]/*' />
    [NativeTypeName("#define DNS_ERROR_NSEC_INCOMPATIBLE_WITH_NSEC3_RSA_SHA1 9130L")]
    public const int DNS_ERROR_NSEC_INCOMPATIBLE_WITH_NSEC3_RSA_SHA1 = 9130;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_PACKET_FMT_BASE"]/*' />
    [NativeTypeName("#define DNS_ERROR_PACKET_FMT_BASE 9500")]
    public const int DNS_ERROR_PACKET_FMT_BASE = 9500;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_INFO_NO_RECORDS"]/*' />
    [NativeTypeName("#define DNS_INFO_NO_RECORDS 9501L")]
    public const int DNS_INFO_NO_RECORDS = 9501;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_BAD_PACKET"]/*' />
    [NativeTypeName("#define DNS_ERROR_BAD_PACKET 9502L")]
    public const int DNS_ERROR_BAD_PACKET = 9502;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NO_PACKET"]/*' />
    [NativeTypeName("#define DNS_ERROR_NO_PACKET 9503L")]
    public const int DNS_ERROR_NO_PACKET = 9503;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RCODE"]/*' />
    [NativeTypeName("#define DNS_ERROR_RCODE 9504L")]
    public const int DNS_ERROR_RCODE = 9504;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_UNSECURE_PACKET"]/*' />
    [NativeTypeName("#define DNS_ERROR_UNSECURE_PACKET 9505L")]
    public const int DNS_ERROR_UNSECURE_PACKET = 9505;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_STATUS_PACKET_UNSECURE"]/*' />
    [NativeTypeName("#define DNS_STATUS_PACKET_UNSECURE DNS_ERROR_UNSECURE_PACKET")]
    public const int DNS_STATUS_PACKET_UNSECURE = 9505;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_REQUEST_PENDING"]/*' />
    [NativeTypeName("#define DNS_REQUEST_PENDING 9506L")]
    public const int DNS_REQUEST_PENDING = 9506;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NO_MEMORY"]/*' />
    [NativeTypeName("#define DNS_ERROR_NO_MEMORY ERROR_OUTOFMEMORY")]
    public const int DNS_ERROR_NO_MEMORY = 14;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_INVALID_NAME"]/*' />
    [NativeTypeName("#define DNS_ERROR_INVALID_NAME ERROR_INVALID_NAME")]
    public const int DNS_ERROR_INVALID_NAME = 123;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_INVALID_DATA"]/*' />
    [NativeTypeName("#define DNS_ERROR_INVALID_DATA ERROR_INVALID_DATA")]
    public const int DNS_ERROR_INVALID_DATA = 13;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_GENERAL_API_BASE"]/*' />
    [NativeTypeName("#define DNS_ERROR_GENERAL_API_BASE 9550")]
    public const int DNS_ERROR_GENERAL_API_BASE = 9550;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_INVALID_TYPE"]/*' />
    [NativeTypeName("#define DNS_ERROR_INVALID_TYPE 9551L")]
    public const int DNS_ERROR_INVALID_TYPE = 9551;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_INVALID_IP_ADDRESS"]/*' />
    [NativeTypeName("#define DNS_ERROR_INVALID_IP_ADDRESS 9552L")]
    public const int DNS_ERROR_INVALID_IP_ADDRESS = 9552;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_INVALID_PROPERTY"]/*' />
    [NativeTypeName("#define DNS_ERROR_INVALID_PROPERTY 9553L")]
    public const int DNS_ERROR_INVALID_PROPERTY = 9553;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_TRY_AGAIN_LATER"]/*' />
    [NativeTypeName("#define DNS_ERROR_TRY_AGAIN_LATER 9554L")]
    public const int DNS_ERROR_TRY_AGAIN_LATER = 9554;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NOT_UNIQUE"]/*' />
    [NativeTypeName("#define DNS_ERROR_NOT_UNIQUE 9555L")]
    public const int DNS_ERROR_NOT_UNIQUE = 9555;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NON_RFC_NAME"]/*' />
    [NativeTypeName("#define DNS_ERROR_NON_RFC_NAME 9556L")]
    public const int DNS_ERROR_NON_RFC_NAME = 9556;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_STATUS_FQDN"]/*' />
    [NativeTypeName("#define DNS_STATUS_FQDN 9557L")]
    public const int DNS_STATUS_FQDN = 9557;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_STATUS_DOTTED_NAME"]/*' />
    [NativeTypeName("#define DNS_STATUS_DOTTED_NAME 9558L")]
    public const int DNS_STATUS_DOTTED_NAME = 9558;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_STATUS_SINGLE_PART_NAME"]/*' />
    [NativeTypeName("#define DNS_STATUS_SINGLE_PART_NAME 9559L")]
    public const int DNS_STATUS_SINGLE_PART_NAME = 9559;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_INVALID_NAME_CHAR"]/*' />
    [NativeTypeName("#define DNS_ERROR_INVALID_NAME_CHAR 9560L")]
    public const int DNS_ERROR_INVALID_NAME_CHAR = 9560;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NUMERIC_NAME"]/*' />
    [NativeTypeName("#define DNS_ERROR_NUMERIC_NAME 9561L")]
    public const int DNS_ERROR_NUMERIC_NAME = 9561;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NOT_ALLOWED_ON_ROOT_SERVER"]/*' />
    [NativeTypeName("#define DNS_ERROR_NOT_ALLOWED_ON_ROOT_SERVER 9562L")]
    public const int DNS_ERROR_NOT_ALLOWED_ON_ROOT_SERVER = 9562;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NOT_ALLOWED_UNDER_DELEGATION"]/*' />
    [NativeTypeName("#define DNS_ERROR_NOT_ALLOWED_UNDER_DELEGATION 9563L")]
    public const int DNS_ERROR_NOT_ALLOWED_UNDER_DELEGATION = 9563;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_CANNOT_FIND_ROOT_HINTS"]/*' />
    [NativeTypeName("#define DNS_ERROR_CANNOT_FIND_ROOT_HINTS 9564L")]
    public const int DNS_ERROR_CANNOT_FIND_ROOT_HINTS = 9564;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_INCONSISTENT_ROOT_HINTS"]/*' />
    [NativeTypeName("#define DNS_ERROR_INCONSISTENT_ROOT_HINTS 9565L")]
    public const int DNS_ERROR_INCONSISTENT_ROOT_HINTS = 9565;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_DWORD_VALUE_TOO_SMALL"]/*' />
    [NativeTypeName("#define DNS_ERROR_DWORD_VALUE_TOO_SMALL 9566L")]
    public const int DNS_ERROR_DWORD_VALUE_TOO_SMALL = 9566;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_DWORD_VALUE_TOO_LARGE"]/*' />
    [NativeTypeName("#define DNS_ERROR_DWORD_VALUE_TOO_LARGE 9567L")]
    public const int DNS_ERROR_DWORD_VALUE_TOO_LARGE = 9567;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_BACKGROUND_LOADING"]/*' />
    [NativeTypeName("#define DNS_ERROR_BACKGROUND_LOADING 9568L")]
    public const int DNS_ERROR_BACKGROUND_LOADING = 9568;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NOT_ALLOWED_ON_RODC"]/*' />
    [NativeTypeName("#define DNS_ERROR_NOT_ALLOWED_ON_RODC 9569L")]
    public const int DNS_ERROR_NOT_ALLOWED_ON_RODC = 9569;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NOT_ALLOWED_UNDER_DNAME"]/*' />
    [NativeTypeName("#define DNS_ERROR_NOT_ALLOWED_UNDER_DNAME 9570L")]
    public const int DNS_ERROR_NOT_ALLOWED_UNDER_DNAME = 9570;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_DELEGATION_REQUIRED"]/*' />
    [NativeTypeName("#define DNS_ERROR_DELEGATION_REQUIRED 9571L")]
    public const int DNS_ERROR_DELEGATION_REQUIRED = 9571;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_INVALID_POLICY_TABLE"]/*' />
    [NativeTypeName("#define DNS_ERROR_INVALID_POLICY_TABLE 9572L")]
    public const int DNS_ERROR_INVALID_POLICY_TABLE = 9572;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_ADDRESS_REQUIRED"]/*' />
    [NativeTypeName("#define DNS_ERROR_ADDRESS_REQUIRED 9573L")]
    public const int DNS_ERROR_ADDRESS_REQUIRED = 9573;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_ZONE_BASE"]/*' />
    [NativeTypeName("#define DNS_ERROR_ZONE_BASE 9600")]
    public const int DNS_ERROR_ZONE_BASE = 9600;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_ZONE_DOES_NOT_EXIST"]/*' />
    [NativeTypeName("#define DNS_ERROR_ZONE_DOES_NOT_EXIST 9601L")]
    public const int DNS_ERROR_ZONE_DOES_NOT_EXIST = 9601;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NO_ZONE_INFO"]/*' />
    [NativeTypeName("#define DNS_ERROR_NO_ZONE_INFO 9602L")]
    public const int DNS_ERROR_NO_ZONE_INFO = 9602;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_INVALID_ZONE_OPERATION"]/*' />
    [NativeTypeName("#define DNS_ERROR_INVALID_ZONE_OPERATION 9603L")]
    public const int DNS_ERROR_INVALID_ZONE_OPERATION = 9603;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_ZONE_CONFIGURATION_ERROR"]/*' />
    [NativeTypeName("#define DNS_ERROR_ZONE_CONFIGURATION_ERROR 9604L")]
    public const int DNS_ERROR_ZONE_CONFIGURATION_ERROR = 9604;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_ZONE_HAS_NO_SOA_RECORD"]/*' />
    [NativeTypeName("#define DNS_ERROR_ZONE_HAS_NO_SOA_RECORD 9605L")]
    public const int DNS_ERROR_ZONE_HAS_NO_SOA_RECORD = 9605;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_ZONE_HAS_NO_NS_RECORDS"]/*' />
    [NativeTypeName("#define DNS_ERROR_ZONE_HAS_NO_NS_RECORDS 9606L")]
    public const int DNS_ERROR_ZONE_HAS_NO_NS_RECORDS = 9606;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_ZONE_LOCKED"]/*' />
    [NativeTypeName("#define DNS_ERROR_ZONE_LOCKED 9607L")]
    public const int DNS_ERROR_ZONE_LOCKED = 9607;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_ZONE_CREATION_FAILED"]/*' />
    [NativeTypeName("#define DNS_ERROR_ZONE_CREATION_FAILED 9608L")]
    public const int DNS_ERROR_ZONE_CREATION_FAILED = 9608;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_ZONE_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define DNS_ERROR_ZONE_ALREADY_EXISTS 9609L")]
    public const int DNS_ERROR_ZONE_ALREADY_EXISTS = 9609;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_AUTOZONE_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define DNS_ERROR_AUTOZONE_ALREADY_EXISTS 9610L")]
    public const int DNS_ERROR_AUTOZONE_ALREADY_EXISTS = 9610;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_INVALID_ZONE_TYPE"]/*' />
    [NativeTypeName("#define DNS_ERROR_INVALID_ZONE_TYPE 9611L")]
    public const int DNS_ERROR_INVALID_ZONE_TYPE = 9611;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_SECONDARY_REQUIRES_MASTER_IP"]/*' />
    [NativeTypeName("#define DNS_ERROR_SECONDARY_REQUIRES_MASTER_IP 9612L")]
    public const int DNS_ERROR_SECONDARY_REQUIRES_MASTER_IP = 9612;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_ZONE_NOT_SECONDARY"]/*' />
    [NativeTypeName("#define DNS_ERROR_ZONE_NOT_SECONDARY 9613L")]
    public const int DNS_ERROR_ZONE_NOT_SECONDARY = 9613;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NEED_SECONDARY_ADDRESSES"]/*' />
    [NativeTypeName("#define DNS_ERROR_NEED_SECONDARY_ADDRESSES 9614L")]
    public const int DNS_ERROR_NEED_SECONDARY_ADDRESSES = 9614;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_WINS_INIT_FAILED"]/*' />
    [NativeTypeName("#define DNS_ERROR_WINS_INIT_FAILED 9615L")]
    public const int DNS_ERROR_WINS_INIT_FAILED = 9615;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NEED_WINS_SERVERS"]/*' />
    [NativeTypeName("#define DNS_ERROR_NEED_WINS_SERVERS 9616L")]
    public const int DNS_ERROR_NEED_WINS_SERVERS = 9616;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NBSTAT_INIT_FAILED"]/*' />
    [NativeTypeName("#define DNS_ERROR_NBSTAT_INIT_FAILED 9617L")]
    public const int DNS_ERROR_NBSTAT_INIT_FAILED = 9617;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_SOA_DELETE_INVALID"]/*' />
    [NativeTypeName("#define DNS_ERROR_SOA_DELETE_INVALID 9618L")]
    public const int DNS_ERROR_SOA_DELETE_INVALID = 9618;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_FORWARDER_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define DNS_ERROR_FORWARDER_ALREADY_EXISTS 9619L")]
    public const int DNS_ERROR_FORWARDER_ALREADY_EXISTS = 9619;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_ZONE_REQUIRES_MASTER_IP"]/*' />
    [NativeTypeName("#define DNS_ERROR_ZONE_REQUIRES_MASTER_IP 9620L")]
    public const int DNS_ERROR_ZONE_REQUIRES_MASTER_IP = 9620;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_ZONE_IS_SHUTDOWN"]/*' />
    [NativeTypeName("#define DNS_ERROR_ZONE_IS_SHUTDOWN 9621L")]
    public const int DNS_ERROR_ZONE_IS_SHUTDOWN = 9621;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_ZONE_LOCKED_FOR_SIGNING"]/*' />
    [NativeTypeName("#define DNS_ERROR_ZONE_LOCKED_FOR_SIGNING 9622L")]
    public const int DNS_ERROR_ZONE_LOCKED_FOR_SIGNING = 9622;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_DATAFILE_BASE"]/*' />
    [NativeTypeName("#define DNS_ERROR_DATAFILE_BASE 9650")]
    public const int DNS_ERROR_DATAFILE_BASE = 9650;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_PRIMARY_REQUIRES_DATAFILE"]/*' />
    [NativeTypeName("#define DNS_ERROR_PRIMARY_REQUIRES_DATAFILE 9651L")]
    public const int DNS_ERROR_PRIMARY_REQUIRES_DATAFILE = 9651;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_INVALID_DATAFILE_NAME"]/*' />
    [NativeTypeName("#define DNS_ERROR_INVALID_DATAFILE_NAME 9652L")]
    public const int DNS_ERROR_INVALID_DATAFILE_NAME = 9652;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_DATAFILE_OPEN_FAILURE"]/*' />
    [NativeTypeName("#define DNS_ERROR_DATAFILE_OPEN_FAILURE 9653L")]
    public const int DNS_ERROR_DATAFILE_OPEN_FAILURE = 9653;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_FILE_WRITEBACK_FAILED"]/*' />
    [NativeTypeName("#define DNS_ERROR_FILE_WRITEBACK_FAILED 9654L")]
    public const int DNS_ERROR_FILE_WRITEBACK_FAILED = 9654;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_DATAFILE_PARSING"]/*' />
    [NativeTypeName("#define DNS_ERROR_DATAFILE_PARSING 9655L")]
    public const int DNS_ERROR_DATAFILE_PARSING = 9655;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_DATABASE_BASE"]/*' />
    [NativeTypeName("#define DNS_ERROR_DATABASE_BASE 9700")]
    public const int DNS_ERROR_DATABASE_BASE = 9700;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RECORD_DOES_NOT_EXIST"]/*' />
    [NativeTypeName("#define DNS_ERROR_RECORD_DOES_NOT_EXIST 9701L")]
    public const int DNS_ERROR_RECORD_DOES_NOT_EXIST = 9701;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RECORD_FORMAT"]/*' />
    [NativeTypeName("#define DNS_ERROR_RECORD_FORMAT 9702L")]
    public const int DNS_ERROR_RECORD_FORMAT = 9702;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NODE_CREATION_FAILED"]/*' />
    [NativeTypeName("#define DNS_ERROR_NODE_CREATION_FAILED 9703L")]
    public const int DNS_ERROR_NODE_CREATION_FAILED = 9703;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_UNKNOWN_RECORD_TYPE"]/*' />
    [NativeTypeName("#define DNS_ERROR_UNKNOWN_RECORD_TYPE 9704L")]
    public const int DNS_ERROR_UNKNOWN_RECORD_TYPE = 9704;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RECORD_TIMED_OUT"]/*' />
    [NativeTypeName("#define DNS_ERROR_RECORD_TIMED_OUT 9705L")]
    public const int DNS_ERROR_RECORD_TIMED_OUT = 9705;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NAME_NOT_IN_ZONE"]/*' />
    [NativeTypeName("#define DNS_ERROR_NAME_NOT_IN_ZONE 9706L")]
    public const int DNS_ERROR_NAME_NOT_IN_ZONE = 9706;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_CNAME_LOOP"]/*' />
    [NativeTypeName("#define DNS_ERROR_CNAME_LOOP 9707L")]
    public const int DNS_ERROR_CNAME_LOOP = 9707;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NODE_IS_CNAME"]/*' />
    [NativeTypeName("#define DNS_ERROR_NODE_IS_CNAME 9708L")]
    public const int DNS_ERROR_NODE_IS_CNAME = 9708;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_CNAME_COLLISION"]/*' />
    [NativeTypeName("#define DNS_ERROR_CNAME_COLLISION 9709L")]
    public const int DNS_ERROR_CNAME_COLLISION = 9709;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RECORD_ONLY_AT_ZONE_ROOT"]/*' />
    [NativeTypeName("#define DNS_ERROR_RECORD_ONLY_AT_ZONE_ROOT 9710L")]
    public const int DNS_ERROR_RECORD_ONLY_AT_ZONE_ROOT = 9710;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RECORD_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define DNS_ERROR_RECORD_ALREADY_EXISTS 9711L")]
    public const int DNS_ERROR_RECORD_ALREADY_EXISTS = 9711;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_SECONDARY_DATA"]/*' />
    [NativeTypeName("#define DNS_ERROR_SECONDARY_DATA 9712L")]
    public const int DNS_ERROR_SECONDARY_DATA = 9712;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NO_CREATE_CACHE_DATA"]/*' />
    [NativeTypeName("#define DNS_ERROR_NO_CREATE_CACHE_DATA 9713L")]
    public const int DNS_ERROR_NO_CREATE_CACHE_DATA = 9713;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NAME_DOES_NOT_EXIST"]/*' />
    [NativeTypeName("#define DNS_ERROR_NAME_DOES_NOT_EXIST 9714L")]
    public const int DNS_ERROR_NAME_DOES_NOT_EXIST = 9714;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_WARNING_PTR_CREATE_FAILED"]/*' />
    [NativeTypeName("#define DNS_WARNING_PTR_CREATE_FAILED 9715L")]
    public const int DNS_WARNING_PTR_CREATE_FAILED = 9715;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_WARNING_DOMAIN_UNDELETED"]/*' />
    [NativeTypeName("#define DNS_WARNING_DOMAIN_UNDELETED 9716L")]
    public const int DNS_WARNING_DOMAIN_UNDELETED = 9716;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_DS_UNAVAILABLE"]/*' />
    [NativeTypeName("#define DNS_ERROR_DS_UNAVAILABLE 9717L")]
    public const int DNS_ERROR_DS_UNAVAILABLE = 9717;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_DS_ZONE_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define DNS_ERROR_DS_ZONE_ALREADY_EXISTS 9718L")]
    public const int DNS_ERROR_DS_ZONE_ALREADY_EXISTS = 9718;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NO_BOOTFILE_IF_DS_ZONE"]/*' />
    [NativeTypeName("#define DNS_ERROR_NO_BOOTFILE_IF_DS_ZONE 9719L")]
    public const int DNS_ERROR_NO_BOOTFILE_IF_DS_ZONE = 9719;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NODE_IS_DNAME"]/*' />
    [NativeTypeName("#define DNS_ERROR_NODE_IS_DNAME 9720L")]
    public const int DNS_ERROR_NODE_IS_DNAME = 9720;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_DNAME_COLLISION"]/*' />
    [NativeTypeName("#define DNS_ERROR_DNAME_COLLISION 9721L")]
    public const int DNS_ERROR_DNAME_COLLISION = 9721;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_ALIAS_LOOP"]/*' />
    [NativeTypeName("#define DNS_ERROR_ALIAS_LOOP 9722L")]
    public const int DNS_ERROR_ALIAS_LOOP = 9722;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_OPERATION_BASE"]/*' />
    [NativeTypeName("#define DNS_ERROR_OPERATION_BASE 9750")]
    public const int DNS_ERROR_OPERATION_BASE = 9750;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_INFO_AXFR_COMPLETE"]/*' />
    [NativeTypeName("#define DNS_INFO_AXFR_COMPLETE 9751L")]
    public const int DNS_INFO_AXFR_COMPLETE = 9751;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_AXFR"]/*' />
    [NativeTypeName("#define DNS_ERROR_AXFR 9752L")]
    public const int DNS_ERROR_AXFR = 9752;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_INFO_ADDED_LOCAL_WINS"]/*' />
    [NativeTypeName("#define DNS_INFO_ADDED_LOCAL_WINS 9753L")]
    public const int DNS_INFO_ADDED_LOCAL_WINS = 9753;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_SECURE_BASE"]/*' />
    [NativeTypeName("#define DNS_ERROR_SECURE_BASE 9800")]
    public const int DNS_ERROR_SECURE_BASE = 9800;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_STATUS_CONTINUE_NEEDED"]/*' />
    [NativeTypeName("#define DNS_STATUS_CONTINUE_NEEDED 9801L")]
    public const int DNS_STATUS_CONTINUE_NEEDED = 9801;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_SETUP_BASE"]/*' />
    [NativeTypeName("#define DNS_ERROR_SETUP_BASE 9850")]
    public const int DNS_ERROR_SETUP_BASE = 9850;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NO_TCPIP"]/*' />
    [NativeTypeName("#define DNS_ERROR_NO_TCPIP 9851L")]
    public const int DNS_ERROR_NO_TCPIP = 9851;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NO_DNS_SERVERS"]/*' />
    [NativeTypeName("#define DNS_ERROR_NO_DNS_SERVERS 9852L")]
    public const int DNS_ERROR_NO_DNS_SERVERS = 9852;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_DP_BASE"]/*' />
    [NativeTypeName("#define DNS_ERROR_DP_BASE 9900")]
    public const int DNS_ERROR_DP_BASE = 9900;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_DP_DOES_NOT_EXIST"]/*' />
    [NativeTypeName("#define DNS_ERROR_DP_DOES_NOT_EXIST 9901L")]
    public const int DNS_ERROR_DP_DOES_NOT_EXIST = 9901;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_DP_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define DNS_ERROR_DP_ALREADY_EXISTS 9902L")]
    public const int DNS_ERROR_DP_ALREADY_EXISTS = 9902;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_DP_NOT_ENLISTED"]/*' />
    [NativeTypeName("#define DNS_ERROR_DP_NOT_ENLISTED 9903L")]
    public const int DNS_ERROR_DP_NOT_ENLISTED = 9903;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_DP_ALREADY_ENLISTED"]/*' />
    [NativeTypeName("#define DNS_ERROR_DP_ALREADY_ENLISTED 9904L")]
    public const int DNS_ERROR_DP_ALREADY_ENLISTED = 9904;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_DP_NOT_AVAILABLE"]/*' />
    [NativeTypeName("#define DNS_ERROR_DP_NOT_AVAILABLE 9905L")]
    public const int DNS_ERROR_DP_NOT_AVAILABLE = 9905;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_DP_FSMO_ERROR"]/*' />
    [NativeTypeName("#define DNS_ERROR_DP_FSMO_ERROR 9906L")]
    public const int DNS_ERROR_DP_FSMO_ERROR = 9906;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RRL_NOT_ENABLED"]/*' />
    [NativeTypeName("#define DNS_ERROR_RRL_NOT_ENABLED 9911L")]
    public const int DNS_ERROR_RRL_NOT_ENABLED = 9911;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RRL_INVALID_WINDOW_SIZE"]/*' />
    [NativeTypeName("#define DNS_ERROR_RRL_INVALID_WINDOW_SIZE 9912L")]
    public const int DNS_ERROR_RRL_INVALID_WINDOW_SIZE = 9912;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RRL_INVALID_IPV4_PREFIX"]/*' />
    [NativeTypeName("#define DNS_ERROR_RRL_INVALID_IPV4_PREFIX 9913L")]
    public const int DNS_ERROR_RRL_INVALID_IPV4_PREFIX = 9913;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RRL_INVALID_IPV6_PREFIX"]/*' />
    [NativeTypeName("#define DNS_ERROR_RRL_INVALID_IPV6_PREFIX 9914L")]
    public const int DNS_ERROR_RRL_INVALID_IPV6_PREFIX = 9914;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RRL_INVALID_TC_RATE"]/*' />
    [NativeTypeName("#define DNS_ERROR_RRL_INVALID_TC_RATE 9915L")]
    public const int DNS_ERROR_RRL_INVALID_TC_RATE = 9915;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RRL_INVALID_LEAK_RATE"]/*' />
    [NativeTypeName("#define DNS_ERROR_RRL_INVALID_LEAK_RATE 9916L")]
    public const int DNS_ERROR_RRL_INVALID_LEAK_RATE = 9916;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_RRL_LEAK_RATE_LESSTHAN_TC_RATE"]/*' />
    [NativeTypeName("#define DNS_ERROR_RRL_LEAK_RATE_LESSTHAN_TC_RATE 9917L")]
    public const int DNS_ERROR_RRL_LEAK_RATE_LESSTHAN_TC_RATE = 9917;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_VIRTUALIZATION_INSTANCE_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define DNS_ERROR_VIRTUALIZATION_INSTANCE_ALREADY_EXISTS 9921L")]
    public const int DNS_ERROR_VIRTUALIZATION_INSTANCE_ALREADY_EXISTS = 9921;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_VIRTUALIZATION_INSTANCE_DOES_NOT_EXIST"]/*' />
    [NativeTypeName("#define DNS_ERROR_VIRTUALIZATION_INSTANCE_DOES_NOT_EXIST 9922L")]
    public const int DNS_ERROR_VIRTUALIZATION_INSTANCE_DOES_NOT_EXIST = 9922;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_VIRTUALIZATION_TREE_LOCKED"]/*' />
    [NativeTypeName("#define DNS_ERROR_VIRTUALIZATION_TREE_LOCKED 9923L")]
    public const int DNS_ERROR_VIRTUALIZATION_TREE_LOCKED = 9923;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_INVAILD_VIRTUALIZATION_INSTANCE_NAME"]/*' />
    [NativeTypeName("#define DNS_ERROR_INVAILD_VIRTUALIZATION_INSTANCE_NAME 9924L")]
    public const int DNS_ERROR_INVAILD_VIRTUALIZATION_INSTANCE_NAME = 9924;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_DEFAULT_VIRTUALIZATION_INSTANCE"]/*' />
    [NativeTypeName("#define DNS_ERROR_DEFAULT_VIRTUALIZATION_INSTANCE 9925L")]
    public const int DNS_ERROR_DEFAULT_VIRTUALIZATION_INSTANCE = 9925;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_ZONESCOPE_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define DNS_ERROR_ZONESCOPE_ALREADY_EXISTS 9951L")]
    public const int DNS_ERROR_ZONESCOPE_ALREADY_EXISTS = 9951;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_ZONESCOPE_DOES_NOT_EXIST"]/*' />
    [NativeTypeName("#define DNS_ERROR_ZONESCOPE_DOES_NOT_EXIST 9952L")]
    public const int DNS_ERROR_ZONESCOPE_DOES_NOT_EXIST = 9952;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_DEFAULT_ZONESCOPE"]/*' />
    [NativeTypeName("#define DNS_ERROR_DEFAULT_ZONESCOPE 9953L")]
    public const int DNS_ERROR_DEFAULT_ZONESCOPE = 9953;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_INVALID_ZONESCOPE_NAME"]/*' />
    [NativeTypeName("#define DNS_ERROR_INVALID_ZONESCOPE_NAME 9954L")]
    public const int DNS_ERROR_INVALID_ZONESCOPE_NAME = 9954;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_NOT_ALLOWED_WITH_ZONESCOPES"]/*' />
    [NativeTypeName("#define DNS_ERROR_NOT_ALLOWED_WITH_ZONESCOPES 9955L")]
    public const int DNS_ERROR_NOT_ALLOWED_WITH_ZONESCOPES = 9955;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_LOAD_ZONESCOPE_FAILED"]/*' />
    [NativeTypeName("#define DNS_ERROR_LOAD_ZONESCOPE_FAILED 9956L")]
    public const int DNS_ERROR_LOAD_ZONESCOPE_FAILED = 9956;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_ZONESCOPE_FILE_WRITEBACK_FAILED"]/*' />
    [NativeTypeName("#define DNS_ERROR_ZONESCOPE_FILE_WRITEBACK_FAILED 9957L")]
    public const int DNS_ERROR_ZONESCOPE_FILE_WRITEBACK_FAILED = 9957;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_INVALID_SCOPE_NAME"]/*' />
    [NativeTypeName("#define DNS_ERROR_INVALID_SCOPE_NAME 9958L")]
    public const int DNS_ERROR_INVALID_SCOPE_NAME = 9958;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_SCOPE_DOES_NOT_EXIST"]/*' />
    [NativeTypeName("#define DNS_ERROR_SCOPE_DOES_NOT_EXIST 9959L")]
    public const int DNS_ERROR_SCOPE_DOES_NOT_EXIST = 9959;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_DEFAULT_SCOPE"]/*' />
    [NativeTypeName("#define DNS_ERROR_DEFAULT_SCOPE 9960L")]
    public const int DNS_ERROR_DEFAULT_SCOPE = 9960;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_INVALID_SCOPE_OPERATION"]/*' />
    [NativeTypeName("#define DNS_ERROR_INVALID_SCOPE_OPERATION 9961L")]
    public const int DNS_ERROR_INVALID_SCOPE_OPERATION = 9961;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_SCOPE_LOCKED"]/*' />
    [NativeTypeName("#define DNS_ERROR_SCOPE_LOCKED 9962L")]
    public const int DNS_ERROR_SCOPE_LOCKED = 9962;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_SCOPE_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define DNS_ERROR_SCOPE_ALREADY_EXISTS 9963L")]
    public const int DNS_ERROR_SCOPE_ALREADY_EXISTS = 9963;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_POLICY_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define DNS_ERROR_POLICY_ALREADY_EXISTS 9971L")]
    public const int DNS_ERROR_POLICY_ALREADY_EXISTS = 9971;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_POLICY_DOES_NOT_EXIST"]/*' />
    [NativeTypeName("#define DNS_ERROR_POLICY_DOES_NOT_EXIST 9972L")]
    public const int DNS_ERROR_POLICY_DOES_NOT_EXIST = 9972;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_POLICY_INVALID_CRITERIA"]/*' />
    [NativeTypeName("#define DNS_ERROR_POLICY_INVALID_CRITERIA 9973L")]
    public const int DNS_ERROR_POLICY_INVALID_CRITERIA = 9973;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_POLICY_INVALID_SETTINGS"]/*' />
    [NativeTypeName("#define DNS_ERROR_POLICY_INVALID_SETTINGS 9974L")]
    public const int DNS_ERROR_POLICY_INVALID_SETTINGS = 9974;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_CLIENT_SUBNET_IS_ACCESSED"]/*' />
    [NativeTypeName("#define DNS_ERROR_CLIENT_SUBNET_IS_ACCESSED 9975L")]
    public const int DNS_ERROR_CLIENT_SUBNET_IS_ACCESSED = 9975;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_CLIENT_SUBNET_DOES_NOT_EXIST"]/*' />
    [NativeTypeName("#define DNS_ERROR_CLIENT_SUBNET_DOES_NOT_EXIST 9976L")]
    public const int DNS_ERROR_CLIENT_SUBNET_DOES_NOT_EXIST = 9976;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_CLIENT_SUBNET_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define DNS_ERROR_CLIENT_SUBNET_ALREADY_EXISTS 9977L")]
    public const int DNS_ERROR_CLIENT_SUBNET_ALREADY_EXISTS = 9977;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_SUBNET_DOES_NOT_EXIST"]/*' />
    [NativeTypeName("#define DNS_ERROR_SUBNET_DOES_NOT_EXIST 9978L")]
    public const int DNS_ERROR_SUBNET_DOES_NOT_EXIST = 9978;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_SUBNET_ALREADY_EXISTS"]/*' />
    [NativeTypeName("#define DNS_ERROR_SUBNET_ALREADY_EXISTS 9979L")]
    public const int DNS_ERROR_SUBNET_ALREADY_EXISTS = 9979;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_POLICY_LOCKED"]/*' />
    [NativeTypeName("#define DNS_ERROR_POLICY_LOCKED 9980L")]
    public const int DNS_ERROR_POLICY_LOCKED = 9980;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_POLICY_INVALID_WEIGHT"]/*' />
    [NativeTypeName("#define DNS_ERROR_POLICY_INVALID_WEIGHT 9981L")]
    public const int DNS_ERROR_POLICY_INVALID_WEIGHT = 9981;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_POLICY_INVALID_NAME"]/*' />
    [NativeTypeName("#define DNS_ERROR_POLICY_INVALID_NAME 9982L")]
    public const int DNS_ERROR_POLICY_INVALID_NAME = 9982;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_POLICY_MISSING_CRITERIA"]/*' />
    [NativeTypeName("#define DNS_ERROR_POLICY_MISSING_CRITERIA 9983L")]
    public const int DNS_ERROR_POLICY_MISSING_CRITERIA = 9983;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_INVALID_CLIENT_SUBNET_NAME"]/*' />
    [NativeTypeName("#define DNS_ERROR_INVALID_CLIENT_SUBNET_NAME 9984L")]
    public const int DNS_ERROR_INVALID_CLIENT_SUBNET_NAME = 9984;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_POLICY_PROCESSING_ORDER_INVALID"]/*' />
    [NativeTypeName("#define DNS_ERROR_POLICY_PROCESSING_ORDER_INVALID 9985L")]
    public const int DNS_ERROR_POLICY_PROCESSING_ORDER_INVALID = 9985;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_POLICY_SCOPE_MISSING"]/*' />
    [NativeTypeName("#define DNS_ERROR_POLICY_SCOPE_MISSING 9986L")]
    public const int DNS_ERROR_POLICY_SCOPE_MISSING = 9986;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_POLICY_SCOPE_NOT_ALLOWED"]/*' />
    [NativeTypeName("#define DNS_ERROR_POLICY_SCOPE_NOT_ALLOWED 9987L")]
    public const int DNS_ERROR_POLICY_SCOPE_NOT_ALLOWED = 9987;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_SERVERSCOPE_IS_REFERENCED"]/*' />
    [NativeTypeName("#define DNS_ERROR_SERVERSCOPE_IS_REFERENCED 9988L")]
    public const int DNS_ERROR_SERVERSCOPE_IS_REFERENCED = 9988;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_ZONESCOPE_IS_REFERENCED"]/*' />
    [NativeTypeName("#define DNS_ERROR_ZONESCOPE_IS_REFERENCED 9989L")]
    public const int DNS_ERROR_ZONESCOPE_IS_REFERENCED = 9989;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_POLICY_INVALID_CRITERIA_CLIENT_SUBNET"]/*' />
    [NativeTypeName("#define DNS_ERROR_POLICY_INVALID_CRITERIA_CLIENT_SUBNET 9990L")]
    public const int DNS_ERROR_POLICY_INVALID_CRITERIA_CLIENT_SUBNET = 9990;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_POLICY_INVALID_CRITERIA_TRANSPORT_PROTOCOL"]/*' />
    [NativeTypeName("#define DNS_ERROR_POLICY_INVALID_CRITERIA_TRANSPORT_PROTOCOL 9991L")]
    public const int DNS_ERROR_POLICY_INVALID_CRITERIA_TRANSPORT_PROTOCOL = 9991;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_POLICY_INVALID_CRITERIA_NETWORK_PROTOCOL"]/*' />
    [NativeTypeName("#define DNS_ERROR_POLICY_INVALID_CRITERIA_NETWORK_PROTOCOL 9992L")]
    public const int DNS_ERROR_POLICY_INVALID_CRITERIA_NETWORK_PROTOCOL = 9992;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_POLICY_INVALID_CRITERIA_INTERFACE"]/*' />
    [NativeTypeName("#define DNS_ERROR_POLICY_INVALID_CRITERIA_INTERFACE 9993L")]
    public const int DNS_ERROR_POLICY_INVALID_CRITERIA_INTERFACE = 9993;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_POLICY_INVALID_CRITERIA_FQDN"]/*' />
    [NativeTypeName("#define DNS_ERROR_POLICY_INVALID_CRITERIA_FQDN 9994L")]
    public const int DNS_ERROR_POLICY_INVALID_CRITERIA_FQDN = 9994;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_POLICY_INVALID_CRITERIA_QUERY_TYPE"]/*' />
    [NativeTypeName("#define DNS_ERROR_POLICY_INVALID_CRITERIA_QUERY_TYPE 9995L")]
    public const int DNS_ERROR_POLICY_INVALID_CRITERIA_QUERY_TYPE = 9995;

    /// <include file='DNS.xml' path='doc/member[@name="DNS.DNS_ERROR_POLICY_INVALID_CRITERIA_TIME_OF_DAY"]/*' />
    [NativeTypeName("#define DNS_ERROR_POLICY_INVALID_CRITERIA_TIME_OF_DAY 9996L")]
    public const int DNS_ERROR_POLICY_INVALID_CRITERIA_TIME_OF_DAY = 9996;
}
