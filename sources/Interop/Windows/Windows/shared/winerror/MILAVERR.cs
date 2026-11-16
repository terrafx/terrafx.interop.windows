// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class MILAVERR
{
    /// <include file='MILAVERR.xml' path='doc/member[@name="MILAVERR.MILAVERR_NOCLOCK"]/*' />
    [NativeTypeName("#define MILAVERR_NOCLOCK _HRESULT_TYPEDEF_(0x88980500L)")]
    public const int MILAVERR_NOCLOCK = unchecked((int)(0x88980500));

    /// <include file='MILAVERR.xml' path='doc/member[@name="MILAVERR.MILAVERR_NOMEDIATYPE"]/*' />
    [NativeTypeName("#define MILAVERR_NOMEDIATYPE _HRESULT_TYPEDEF_(0x88980501L)")]
    public const int MILAVERR_NOMEDIATYPE = unchecked((int)(0x88980501));

    /// <include file='MILAVERR.xml' path='doc/member[@name="MILAVERR.MILAVERR_NOVIDEOMIXER"]/*' />
    [NativeTypeName("#define MILAVERR_NOVIDEOMIXER _HRESULT_TYPEDEF_(0x88980502L)")]
    public const int MILAVERR_NOVIDEOMIXER = unchecked((int)(0x88980502));

    /// <include file='MILAVERR.xml' path='doc/member[@name="MILAVERR.MILAVERR_NOVIDEOPRESENTER"]/*' />
    [NativeTypeName("#define MILAVERR_NOVIDEOPRESENTER _HRESULT_TYPEDEF_(0x88980503L)")]
    public const int MILAVERR_NOVIDEOPRESENTER = unchecked((int)(0x88980503));

    /// <include file='MILAVERR.xml' path='doc/member[@name="MILAVERR.MILAVERR_NOREADYFRAMES"]/*' />
    [NativeTypeName("#define MILAVERR_NOREADYFRAMES _HRESULT_TYPEDEF_(0x88980504L)")]
    public const int MILAVERR_NOREADYFRAMES = unchecked((int)(0x88980504));

    /// <include file='MILAVERR.xml' path='doc/member[@name="MILAVERR.MILAVERR_MODULENOTLOADED"]/*' />
    [NativeTypeName("#define MILAVERR_MODULENOTLOADED _HRESULT_TYPEDEF_(0x88980505L)")]
    public const int MILAVERR_MODULENOTLOADED = unchecked((int)(0x88980505));

    /// <include file='MILAVERR.xml' path='doc/member[@name="MILAVERR.MILAVERR_WMPFACTORYNOTREGISTERED"]/*' />
    [NativeTypeName("#define MILAVERR_WMPFACTORYNOTREGISTERED _HRESULT_TYPEDEF_(0x88980506L)")]
    public const int MILAVERR_WMPFACTORYNOTREGISTERED = unchecked((int)(0x88980506));

    /// <include file='MILAVERR.xml' path='doc/member[@name="MILAVERR.MILAVERR_INVALIDWMPVERSION"]/*' />
    [NativeTypeName("#define MILAVERR_INVALIDWMPVERSION _HRESULT_TYPEDEF_(0x88980507L)")]
    public const int MILAVERR_INVALIDWMPVERSION = unchecked((int)(0x88980507));

    /// <include file='MILAVERR.xml' path='doc/member[@name="MILAVERR.MILAVERR_INSUFFICIENTVIDEORESOURCES"]/*' />
    [NativeTypeName("#define MILAVERR_INSUFFICIENTVIDEORESOURCES _HRESULT_TYPEDEF_(0x88980508L)")]
    public const int MILAVERR_INSUFFICIENTVIDEORESOURCES = unchecked((int)(0x88980508));

    /// <include file='MILAVERR.xml' path='doc/member[@name="MILAVERR.MILAVERR_VIDEOACCELERATIONNOTAVAILABLE"]/*' />
    [NativeTypeName("#define MILAVERR_VIDEOACCELERATIONNOTAVAILABLE _HRESULT_TYPEDEF_(0x88980509L)")]
    public const int MILAVERR_VIDEOACCELERATIONNOTAVAILABLE = unchecked((int)(0x88980509));

    /// <include file='MILAVERR.xml' path='doc/member[@name="MILAVERR.MILAVERR_REQUESTEDTEXTURETOOBIG"]/*' />
    [NativeTypeName("#define MILAVERR_REQUESTEDTEXTURETOOBIG _HRESULT_TYPEDEF_(0x8898050AL)")]
    public const int MILAVERR_REQUESTEDTEXTURETOOBIG = unchecked((int)(0x8898050A));

    /// <include file='MILAVERR.xml' path='doc/member[@name="MILAVERR.MILAVERR_SEEKFAILED"]/*' />
    [NativeTypeName("#define MILAVERR_SEEKFAILED _HRESULT_TYPEDEF_(0x8898050BL)")]
    public const int MILAVERR_SEEKFAILED = unchecked((int)(0x8898050B));

    /// <include file='MILAVERR.xml' path='doc/member[@name="MILAVERR.MILAVERR_UNEXPECTEDWMPFAILURE"]/*' />
    [NativeTypeName("#define MILAVERR_UNEXPECTEDWMPFAILURE _HRESULT_TYPEDEF_(0x8898050CL)")]
    public const int MILAVERR_UNEXPECTEDWMPFAILURE = unchecked((int)(0x8898050C));

    /// <include file='MILAVERR.xml' path='doc/member[@name="MILAVERR.MILAVERR_MEDIAPLAYERCLOSED"]/*' />
    [NativeTypeName("#define MILAVERR_MEDIAPLAYERCLOSED _HRESULT_TYPEDEF_(0x8898050DL)")]
    public const int MILAVERR_MEDIAPLAYERCLOSED = unchecked((int)(0x8898050D));

    /// <include file='MILAVERR.xml' path='doc/member[@name="MILAVERR.MILAVERR_UNKNOWNHARDWAREERROR"]/*' />
    [NativeTypeName("#define MILAVERR_UNKNOWNHARDWAREERROR _HRESULT_TYPEDEF_(0x8898050EL)")]
    public const int MILAVERR_UNKNOWNHARDWAREERROR = unchecked((int)(0x8898050E));
}
