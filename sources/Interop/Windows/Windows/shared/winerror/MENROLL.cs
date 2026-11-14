// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MENROLL
{
    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_DEVICE_MESSAGE_FORMAT_ERROR"]/*' />
    [NativeTypeName("#define MENROLL_E_DEVICE_MESSAGE_FORMAT_ERROR _HRESULT_TYPEDEF_(0x80180001L)")]
    public const int MENROLL_E_DEVICE_MESSAGE_FORMAT_ERROR = unchecked((int)(0x80180001));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_DEVICE_AUTHENTICATION_ERROR"]/*' />
    [NativeTypeName("#define MENROLL_E_DEVICE_AUTHENTICATION_ERROR _HRESULT_TYPEDEF_(0x80180002L)")]
    public const int MENROLL_E_DEVICE_AUTHENTICATION_ERROR = unchecked((int)(0x80180002));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_DEVICE_AUTHORIZATION_ERROR"]/*' />
    [NativeTypeName("#define MENROLL_E_DEVICE_AUTHORIZATION_ERROR _HRESULT_TYPEDEF_(0x80180003L)")]
    public const int MENROLL_E_DEVICE_AUTHORIZATION_ERROR = unchecked((int)(0x80180003));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_DEVICE_CERTIFICATEREQUEST_ERROR"]/*' />
    [NativeTypeName("#define MENROLL_E_DEVICE_CERTIFICATEREQUEST_ERROR _HRESULT_TYPEDEF_(0x80180004L)")]
    public const int MENROLL_E_DEVICE_CERTIFICATEREQUEST_ERROR = unchecked((int)(0x80180004));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_DEVICE_CONFIGMGRSERVER_ERROR"]/*' />
    [NativeTypeName("#define MENROLL_E_DEVICE_CONFIGMGRSERVER_ERROR _HRESULT_TYPEDEF_(0x80180005L)")]
    public const int MENROLL_E_DEVICE_CONFIGMGRSERVER_ERROR = unchecked((int)(0x80180005));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_DEVICE_INTERNALSERVICE_ERROR"]/*' />
    [NativeTypeName("#define MENROLL_E_DEVICE_INTERNALSERVICE_ERROR _HRESULT_TYPEDEF_(0x80180006L)")]
    public const int MENROLL_E_DEVICE_INTERNALSERVICE_ERROR = unchecked((int)(0x80180006));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_DEVICE_INVALIDSECURITY_ERROR"]/*' />
    [NativeTypeName("#define MENROLL_E_DEVICE_INVALIDSECURITY_ERROR _HRESULT_TYPEDEF_(0x80180007L)")]
    public const int MENROLL_E_DEVICE_INVALIDSECURITY_ERROR = unchecked((int)(0x80180007));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_DEVICE_UNKNOWN_ERROR"]/*' />
    [NativeTypeName("#define MENROLL_E_DEVICE_UNKNOWN_ERROR _HRESULT_TYPEDEF_(0x80180008L)")]
    public const int MENROLL_E_DEVICE_UNKNOWN_ERROR = unchecked((int)(0x80180008));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_ENROLLMENT_IN_PROGRESS"]/*' />
    [NativeTypeName("#define MENROLL_E_ENROLLMENT_IN_PROGRESS _HRESULT_TYPEDEF_(0x80180009L)")]
    public const int MENROLL_E_ENROLLMENT_IN_PROGRESS = unchecked((int)(0x80180009));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_DEVICE_ALREADY_ENROLLED"]/*' />
    [NativeTypeName("#define MENROLL_E_DEVICE_ALREADY_ENROLLED _HRESULT_TYPEDEF_(0x8018000AL)")]
    public const int MENROLL_E_DEVICE_ALREADY_ENROLLED = unchecked((int)(0x8018000A));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_DISCOVERY_SEC_CERT_DATE_INVALID"]/*' />
    [NativeTypeName("#define MENROLL_E_DISCOVERY_SEC_CERT_DATE_INVALID _HRESULT_TYPEDEF_(0x8018000DL)")]
    public const int MENROLL_E_DISCOVERY_SEC_CERT_DATE_INVALID = unchecked((int)(0x8018000D));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_PASSWORD_NEEDED"]/*' />
    [NativeTypeName("#define MENROLL_E_PASSWORD_NEEDED _HRESULT_TYPEDEF_(0x8018000EL)")]
    public const int MENROLL_E_PASSWORD_NEEDED = unchecked((int)(0x8018000E));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_WAB_ERROR"]/*' />
    [NativeTypeName("#define MENROLL_E_WAB_ERROR _HRESULT_TYPEDEF_(0x8018000FL)")]
    public const int MENROLL_E_WAB_ERROR = unchecked((int)(0x8018000F));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_CONNECTIVITY"]/*' />
    [NativeTypeName("#define MENROLL_E_CONNECTIVITY _HRESULT_TYPEDEF_(0x80180010L)")]
    public const int MENROLL_E_CONNECTIVITY = unchecked((int)(0x80180010));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_S_ENROLLMENT_SUSPENDED"]/*' />
    [NativeTypeName("#define MENROLL_S_ENROLLMENT_SUSPENDED _HRESULT_TYPEDEF_(0x00180011L)")]
    public const int MENROLL_S_ENROLLMENT_SUSPENDED = ((int)(0x00180011));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_INVALIDSSLCERT"]/*' />
    [NativeTypeName("#define MENROLL_E_INVALIDSSLCERT _HRESULT_TYPEDEF_(0x80180012L)")]
    public const int MENROLL_E_INVALIDSSLCERT = unchecked((int)(0x80180012));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_DEVICECAPREACHED"]/*' />
    [NativeTypeName("#define MENROLL_E_DEVICECAPREACHED _HRESULT_TYPEDEF_(0x80180013L)")]
    public const int MENROLL_E_DEVICECAPREACHED = unchecked((int)(0x80180013));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_DEVICENOTSUPPORTED"]/*' />
    [NativeTypeName("#define MENROLL_E_DEVICENOTSUPPORTED _HRESULT_TYPEDEF_(0x80180014L)")]
    public const int MENROLL_E_DEVICENOTSUPPORTED = unchecked((int)(0x80180014));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_NOT_SUPPORTED"]/*' />
    [NativeTypeName("#define MENROLL_E_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x80180015L)")]
    public const int MENROLL_E_NOT_SUPPORTED = unchecked((int)(0x80180015));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_NOTELIGIBLETORENEW"]/*' />
    [NativeTypeName("#define MENROLL_E_NOTELIGIBLETORENEW _HRESULT_TYPEDEF_(0x80180016L)")]
    public const int MENROLL_E_NOTELIGIBLETORENEW = unchecked((int)(0x80180016));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_INMAINTENANCE"]/*' />
    [NativeTypeName("#define MENROLL_E_INMAINTENANCE _HRESULT_TYPEDEF_(0x80180017L)")]
    public const int MENROLL_E_INMAINTENANCE = unchecked((int)(0x80180017));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_USER_LICENSE"]/*' />
    [NativeTypeName("#define MENROLL_E_USER_LICENSE _HRESULT_TYPEDEF_(0x80180018L)")]
    public const int MENROLL_E_USER_LICENSE = unchecked((int)(0x80180018));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_ENROLLMENTDATAINVALID"]/*' />
    [NativeTypeName("#define MENROLL_E_ENROLLMENTDATAINVALID _HRESULT_TYPEDEF_(0x80180019L)")]
    public const int MENROLL_E_ENROLLMENTDATAINVALID = unchecked((int)(0x80180019));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_INSECUREREDIRECT"]/*' />
    [NativeTypeName("#define MENROLL_E_INSECUREREDIRECT _HRESULT_TYPEDEF_(0x8018001AL)")]
    public const int MENROLL_E_INSECUREREDIRECT = unchecked((int)(0x8018001A));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_PLATFORM_WRONG_STATE"]/*' />
    [NativeTypeName("#define MENROLL_E_PLATFORM_WRONG_STATE _HRESULT_TYPEDEF_(0x8018001BL)")]
    public const int MENROLL_E_PLATFORM_WRONG_STATE = unchecked((int)(0x8018001B));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_PLATFORM_LICENSE_ERROR"]/*' />
    [NativeTypeName("#define MENROLL_E_PLATFORM_LICENSE_ERROR _HRESULT_TYPEDEF_(0x8018001CL)")]
    public const int MENROLL_E_PLATFORM_LICENSE_ERROR = unchecked((int)(0x8018001C));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_PLATFORM_UNKNOWN_ERROR"]/*' />
    [NativeTypeName("#define MENROLL_E_PLATFORM_UNKNOWN_ERROR _HRESULT_TYPEDEF_(0x8018001DL)")]
    public const int MENROLL_E_PLATFORM_UNKNOWN_ERROR = unchecked((int)(0x8018001D));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_PROV_CSP_CERTSTORE"]/*' />
    [NativeTypeName("#define MENROLL_E_PROV_CSP_CERTSTORE _HRESULT_TYPEDEF_(0x8018001EL)")]
    public const int MENROLL_E_PROV_CSP_CERTSTORE = unchecked((int)(0x8018001E));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_PROV_CSP_W7"]/*' />
    [NativeTypeName("#define MENROLL_E_PROV_CSP_W7 _HRESULT_TYPEDEF_(0x8018001FL)")]
    public const int MENROLL_E_PROV_CSP_W7 = unchecked((int)(0x8018001F));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_PROV_CSP_DMCLIENT"]/*' />
    [NativeTypeName("#define MENROLL_E_PROV_CSP_DMCLIENT _HRESULT_TYPEDEF_(0x80180020L)")]
    public const int MENROLL_E_PROV_CSP_DMCLIENT = unchecked((int)(0x80180020));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_PROV_CSP_PFW"]/*' />
    [NativeTypeName("#define MENROLL_E_PROV_CSP_PFW _HRESULT_TYPEDEF_(0x80180021L)")]
    public const int MENROLL_E_PROV_CSP_PFW = unchecked((int)(0x80180021));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_PROV_CSP_MISC"]/*' />
    [NativeTypeName("#define MENROLL_E_PROV_CSP_MISC _HRESULT_TYPEDEF_(0x80180022L)")]
    public const int MENROLL_E_PROV_CSP_MISC = unchecked((int)(0x80180022));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_PROV_UNKNOWN"]/*' />
    [NativeTypeName("#define MENROLL_E_PROV_UNKNOWN _HRESULT_TYPEDEF_(0x80180023L)")]
    public const int MENROLL_E_PROV_UNKNOWN = unchecked((int)(0x80180023));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_PROV_SSLCERTNOTFOUND"]/*' />
    [NativeTypeName("#define MENROLL_E_PROV_SSLCERTNOTFOUND _HRESULT_TYPEDEF_(0x80180024L)")]
    public const int MENROLL_E_PROV_SSLCERTNOTFOUND = unchecked((int)(0x80180024));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_PROV_CSP_APPMGMT"]/*' />
    [NativeTypeName("#define MENROLL_E_PROV_CSP_APPMGMT _HRESULT_TYPEDEF_(0x80180025L)")]
    public const int MENROLL_E_PROV_CSP_APPMGMT = unchecked((int)(0x80180025));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_DEVICE_MANAGEMENT_BLOCKED"]/*' />
    [NativeTypeName("#define MENROLL_E_DEVICE_MANAGEMENT_BLOCKED _HRESULT_TYPEDEF_(0x80180026L)")]
    public const int MENROLL_E_DEVICE_MANAGEMENT_BLOCKED = unchecked((int)(0x80180026));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_CERTPOLICY_PRIVATEKEYCREATION_FAILED"]/*' />
    [NativeTypeName("#define MENROLL_E_CERTPOLICY_PRIVATEKEYCREATION_FAILED _HRESULT_TYPEDEF_(0x80180027L)")]
    public const int MENROLL_E_CERTPOLICY_PRIVATEKEYCREATION_FAILED = unchecked((int)(0x80180027));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_CERTAUTH_FAILED_TO_FIND_CERT"]/*' />
    [NativeTypeName("#define MENROLL_E_CERTAUTH_FAILED_TO_FIND_CERT _HRESULT_TYPEDEF_(0x80180028L)")]
    public const int MENROLL_E_CERTAUTH_FAILED_TO_FIND_CERT = unchecked((int)(0x80180028));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_EMPTY_MESSAGE"]/*' />
    [NativeTypeName("#define MENROLL_E_EMPTY_MESSAGE _HRESULT_TYPEDEF_(0x80180029L)")]
    public const int MENROLL_E_EMPTY_MESSAGE = unchecked((int)(0x80180029));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_USER_CANCELLED"]/*' />
    [NativeTypeName("#define MENROLL_E_USER_CANCELLED _HRESULT_TYPEDEF_(0x80180030L)")]
    public const int MENROLL_E_USER_CANCELLED = unchecked((int)(0x80180030));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_MDM_NOT_CONFIGURED"]/*' />
    [NativeTypeName("#define MENROLL_E_MDM_NOT_CONFIGURED _HRESULT_TYPEDEF_(0x80180031L)")]
    public const int MENROLL_E_MDM_NOT_CONFIGURED = unchecked((int)(0x80180031));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_CUSTOMSERVERERROR"]/*' />
    [NativeTypeName("#define MENROLL_E_CUSTOMSERVERERROR _HRESULT_TYPEDEF_(0x80180032L)")]
    public const int MENROLL_E_CUSTOMSERVERERROR = unchecked((int)(0x80180032));

    /// <include file='MENROLL.xml' path='doc/member[@name="MENROLL.MENROLL_E_SERVER429"]/*' />
    [NativeTypeName("#define MENROLL_E_SERVER429 _HRESULT_TYPEDEF_(0x80180033L)")]
    public const int MENROLL_E_SERVER429 = unchecked((int)(0x80180033));
}
