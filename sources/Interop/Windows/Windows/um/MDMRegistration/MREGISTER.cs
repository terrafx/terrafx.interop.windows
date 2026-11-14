// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MDMRegistration.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MREGISTER
{
    /// <include file='MREGISTER.xml' path='doc/member[@name="MREGISTER.MREGISTER_E_DEVICE_MESSAGE_FORMAT_ERROR"]/*' />
    [NativeTypeName("#define MREGISTER_E_DEVICE_MESSAGE_FORMAT_ERROR MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 1)")]
    public const int MREGISTER_E_DEVICE_MESSAGE_FORMAT_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(1))));

    /// <include file='MREGISTER.xml' path='doc/member[@name="MREGISTER.MREGISTER_E_DEVICE_AUTHENTICATION_ERROR"]/*' />
    [NativeTypeName("#define MREGISTER_E_DEVICE_AUTHENTICATION_ERROR MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 2)")]
    public const int MREGISTER_E_DEVICE_AUTHENTICATION_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(2))));

    /// <include file='MREGISTER.xml' path='doc/member[@name="MREGISTER.MREGISTER_E_DEVICE_AUTHORIZATION_ERROR"]/*' />
    [NativeTypeName("#define MREGISTER_E_DEVICE_AUTHORIZATION_ERROR MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 3)")]
    public const int MREGISTER_E_DEVICE_AUTHORIZATION_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(3))));

    /// <include file='MREGISTER.xml' path='doc/member[@name="MREGISTER.MREGISTER_E_DEVICE_CERTIFCATEREQUEST_ERROR"]/*' />
    [NativeTypeName("#define MREGISTER_E_DEVICE_CERTIFCATEREQUEST_ERROR MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 4)")]
    public const int MREGISTER_E_DEVICE_CERTIFCATEREQUEST_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(4))));

    /// <include file='MREGISTER.xml' path='doc/member[@name="MREGISTER.MREGISTER_E_DEVICE_CONFIGMGRSERVER_ERROR"]/*' />
    [NativeTypeName("#define MREGISTER_E_DEVICE_CONFIGMGRSERVER_ERROR MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 5)")]
    public const int MREGISTER_E_DEVICE_CONFIGMGRSERVER_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(5))));

    /// <include file='MREGISTER.xml' path='doc/member[@name="MREGISTER.MREGISTER_E_DEVICE_INTERNALSERVICE_ERROR"]/*' />
    [NativeTypeName("#define MREGISTER_E_DEVICE_INTERNALSERVICE_ERROR MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 6)")]
    public const int MREGISTER_E_DEVICE_INTERNALSERVICE_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(6))));

    /// <include file='MREGISTER.xml' path='doc/member[@name="MREGISTER.MREGISTER_E_DEVICE_INVALIDSECURITY_ERROR"]/*' />
    [NativeTypeName("#define MREGISTER_E_DEVICE_INVALIDSECURITY_ERROR MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 7)")]
    public const int MREGISTER_E_DEVICE_INVALIDSECURITY_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(7))));

    /// <include file='MREGISTER.xml' path='doc/member[@name="MREGISTER.MREGISTER_E_DEVICE_UNKNOWN_ERROR"]/*' />
    [NativeTypeName("#define MREGISTER_E_DEVICE_UNKNOWN_ERROR MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 8)")]
    public const int MREGISTER_E_DEVICE_UNKNOWN_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(8))));

    /// <include file='MREGISTER.xml' path='doc/member[@name="MREGISTER.MREGISTER_E_REGISTRATION_IN_PROGRESS"]/*' />
    [NativeTypeName("#define MREGISTER_E_REGISTRATION_IN_PROGRESS MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 9)")]
    public const int MREGISTER_E_REGISTRATION_IN_PROGRESS = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(9))));

    /// <include file='MREGISTER.xml' path='doc/member[@name="MREGISTER.MREGISTER_E_DEVICE_ALREADY_REGISTERED"]/*' />
    [NativeTypeName("#define MREGISTER_E_DEVICE_ALREADY_REGISTERED MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 10)")]
    public const int MREGISTER_E_DEVICE_ALREADY_REGISTERED = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(10))));

    /// <include file='MREGISTER.xml' path='doc/member[@name="MREGISTER.MREGISTER_E_DEVICE_NOT_REGISTERED"]/*' />
    [NativeTypeName("#define MREGISTER_E_DEVICE_NOT_REGISTERED MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 11)")]
    public const int MREGISTER_E_DEVICE_NOT_REGISTERED = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(11))));

    /// <include file='MREGISTER.xml' path='doc/member[@name="MREGISTER.MREGISTER_E_DISCOVERY_REDIRECTED"]/*' />
    [NativeTypeName("#define MREGISTER_E_DISCOVERY_REDIRECTED MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 12)")]
    public const int MREGISTER_E_DISCOVERY_REDIRECTED = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(12))));

    /// <include file='MREGISTER.xml' path='doc/member[@name="MREGISTER.MREGISTER_E_DEVICE_NOT_AD_REGISTERED_ERROR"]/*' />
    [NativeTypeName("#define MREGISTER_E_DEVICE_NOT_AD_REGISTERED_ERROR MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 13)")]
    public const int MREGISTER_E_DEVICE_NOT_AD_REGISTERED_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(13))));

    /// <include file='MREGISTER.xml' path='doc/member[@name="MREGISTER.MREGISTER_E_DISCOVERY_FAILED"]/*' />
    [NativeTypeName("#define MREGISTER_E_DISCOVERY_FAILED MAKE_HRESULT(SEVERITY_ERROR, MDM_REGISTRATION_FACILITY_CODE, 14)")]
    public const int MREGISTER_E_DISCOVERY_FAILED = unchecked((int)(((uint)(1) << 31) | ((uint)(25) << 16) | ((uint)(14))));
}
