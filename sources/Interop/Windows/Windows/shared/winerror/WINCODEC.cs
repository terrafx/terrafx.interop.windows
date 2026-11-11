// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WINCODEC
{
    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_WRONGSTATE"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_WRONGSTATE _HRESULT_TYPEDEF_(0x88982F04L)")]
    public const int WINCODEC_ERR_WRONGSTATE = unchecked((int)(0x88982F04));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_VALUEOUTOFRANGE"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_VALUEOUTOFRANGE _HRESULT_TYPEDEF_(0x88982F05L)")]
    public const int WINCODEC_ERR_VALUEOUTOFRANGE = unchecked((int)(0x88982F05));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_UNKNOWNIMAGEFORMAT"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_UNKNOWNIMAGEFORMAT _HRESULT_TYPEDEF_(0x88982F07L)")]
    public const int WINCODEC_ERR_UNKNOWNIMAGEFORMAT = unchecked((int)(0x88982F07));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_UNSUPPORTEDVERSION"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_UNSUPPORTEDVERSION _HRESULT_TYPEDEF_(0x88982F0BL)")]
    public const int WINCODEC_ERR_UNSUPPORTEDVERSION = unchecked((int)(0x88982F0B));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_NOTINITIALIZED"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_NOTINITIALIZED _HRESULT_TYPEDEF_(0x88982F0CL)")]
    public const int WINCODEC_ERR_NOTINITIALIZED = unchecked((int)(0x88982F0C));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_ALREADYLOCKED"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_ALREADYLOCKED _HRESULT_TYPEDEF_(0x88982F0DL)")]
    public const int WINCODEC_ERR_ALREADYLOCKED = unchecked((int)(0x88982F0D));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_PROPERTYNOTFOUND"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_PROPERTYNOTFOUND _HRESULT_TYPEDEF_(0x88982F40L)")]
    public const int WINCODEC_ERR_PROPERTYNOTFOUND = unchecked((int)(0x88982F40));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_PROPERTYNOTSUPPORTED"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_PROPERTYNOTSUPPORTED _HRESULT_TYPEDEF_(0x88982F41L)")]
    public const int WINCODEC_ERR_PROPERTYNOTSUPPORTED = unchecked((int)(0x88982F41));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_PROPERTYSIZE"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_PROPERTYSIZE _HRESULT_TYPEDEF_(0x88982F42L)")]
    public const int WINCODEC_ERR_PROPERTYSIZE = unchecked((int)(0x88982F42));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_CODECPRESENT"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_CODECPRESENT _HRESULT_TYPEDEF_(0x88982F43L)")]
    public const int WINCODEC_ERR_CODECPRESENT = unchecked((int)(0x88982F43));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_CODECNOTHUMBNAIL"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_CODECNOTHUMBNAIL _HRESULT_TYPEDEF_(0x88982F44L)")]
    public const int WINCODEC_ERR_CODECNOTHUMBNAIL = unchecked((int)(0x88982F44));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_PALETTEUNAVAILABLE"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_PALETTEUNAVAILABLE _HRESULT_TYPEDEF_(0x88982F45L)")]
    public const int WINCODEC_ERR_PALETTEUNAVAILABLE = unchecked((int)(0x88982F45));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_CODECTOOMANYSCANLINES"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_CODECTOOMANYSCANLINES _HRESULT_TYPEDEF_(0x88982F46L)")]
    public const int WINCODEC_ERR_CODECTOOMANYSCANLINES = unchecked((int)(0x88982F46));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_INTERNALERROR"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_INTERNALERROR _HRESULT_TYPEDEF_(0x88982F48L)")]
    public const int WINCODEC_ERR_INTERNALERROR = unchecked((int)(0x88982F48));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_SOURCERECTDOESNOTMATCHDIMENSIONS"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_SOURCERECTDOESNOTMATCHDIMENSIONS _HRESULT_TYPEDEF_(0x88982F49L)")]
    public const int WINCODEC_ERR_SOURCERECTDOESNOTMATCHDIMENSIONS = unchecked((int)(0x88982F49));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_COMPONENTNOTFOUND"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_COMPONENTNOTFOUND _HRESULT_TYPEDEF_(0x88982F50L)")]
    public const int WINCODEC_ERR_COMPONENTNOTFOUND = unchecked((int)(0x88982F50));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_IMAGESIZEOUTOFRANGE"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_IMAGESIZEOUTOFRANGE _HRESULT_TYPEDEF_(0x88982F51L)")]
    public const int WINCODEC_ERR_IMAGESIZEOUTOFRANGE = unchecked((int)(0x88982F51));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_TOOMUCHMETADATA"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_TOOMUCHMETADATA _HRESULT_TYPEDEF_(0x88982F52L)")]
    public const int WINCODEC_ERR_TOOMUCHMETADATA = unchecked((int)(0x88982F52));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_BADIMAGE"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_BADIMAGE _HRESULT_TYPEDEF_(0x88982F60L)")]
    public const int WINCODEC_ERR_BADIMAGE = unchecked((int)(0x88982F60));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_BADHEADER"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_BADHEADER _HRESULT_TYPEDEF_(0x88982F61L)")]
    public const int WINCODEC_ERR_BADHEADER = unchecked((int)(0x88982F61));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_FRAMEMISSING"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_FRAMEMISSING _HRESULT_TYPEDEF_(0x88982F62L)")]
    public const int WINCODEC_ERR_FRAMEMISSING = unchecked((int)(0x88982F62));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_BADMETADATAHEADER"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_BADMETADATAHEADER _HRESULT_TYPEDEF_(0x88982F63L)")]
    public const int WINCODEC_ERR_BADMETADATAHEADER = unchecked((int)(0x88982F63));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_BADSTREAMDATA"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_BADSTREAMDATA _HRESULT_TYPEDEF_(0x88982F70L)")]
    public const int WINCODEC_ERR_BADSTREAMDATA = unchecked((int)(0x88982F70));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_STREAMWRITE"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_STREAMWRITE _HRESULT_TYPEDEF_(0x88982F71L)")]
    public const int WINCODEC_ERR_STREAMWRITE = unchecked((int)(0x88982F71));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_STREAMREAD"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_STREAMREAD _HRESULT_TYPEDEF_(0x88982F72L)")]
    public const int WINCODEC_ERR_STREAMREAD = unchecked((int)(0x88982F72));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_STREAMNOTAVAILABLE"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_STREAMNOTAVAILABLE _HRESULT_TYPEDEF_(0x88982F73L)")]
    public const int WINCODEC_ERR_STREAMNOTAVAILABLE = unchecked((int)(0x88982F73));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_UNSUPPORTEDPIXELFORMAT"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_UNSUPPORTEDPIXELFORMAT _HRESULT_TYPEDEF_(0x88982F80L)")]
    public const int WINCODEC_ERR_UNSUPPORTEDPIXELFORMAT = unchecked((int)(0x88982F80));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_UNSUPPORTEDOPERATION"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_UNSUPPORTEDOPERATION _HRESULT_TYPEDEF_(0x88982F81L)")]
    public const int WINCODEC_ERR_UNSUPPORTEDOPERATION = unchecked((int)(0x88982F81));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_INVALIDREGISTRATION"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_INVALIDREGISTRATION _HRESULT_TYPEDEF_(0x88982F8AL)")]
    public const int WINCODEC_ERR_INVALIDREGISTRATION = unchecked((int)(0x88982F8A));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_COMPONENTINITIALIZEFAILURE"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_COMPONENTINITIALIZEFAILURE _HRESULT_TYPEDEF_(0x88982F8BL)")]
    public const int WINCODEC_ERR_COMPONENTINITIALIZEFAILURE = unchecked((int)(0x88982F8B));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_INSUFFICIENTBUFFER"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_INSUFFICIENTBUFFER _HRESULT_TYPEDEF_(0x88982F8CL)")]
    public const int WINCODEC_ERR_INSUFFICIENTBUFFER = unchecked((int)(0x88982F8C));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_DUPLICATEMETADATAPRESENT"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_DUPLICATEMETADATAPRESENT _HRESULT_TYPEDEF_(0x88982F8DL)")]
    public const int WINCODEC_ERR_DUPLICATEMETADATAPRESENT = unchecked((int)(0x88982F8D));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_PROPERTYUNEXPECTEDTYPE"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_PROPERTYUNEXPECTEDTYPE _HRESULT_TYPEDEF_(0x88982F8EL)")]
    public const int WINCODEC_ERR_PROPERTYUNEXPECTEDTYPE = unchecked((int)(0x88982F8E));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_UNEXPECTEDSIZE"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_UNEXPECTEDSIZE _HRESULT_TYPEDEF_(0x88982F8FL)")]
    public const int WINCODEC_ERR_UNEXPECTEDSIZE = unchecked((int)(0x88982F8F));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_INVALIDQUERYREQUEST"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_INVALIDQUERYREQUEST _HRESULT_TYPEDEF_(0x88982F90L)")]
    public const int WINCODEC_ERR_INVALIDQUERYREQUEST = unchecked((int)(0x88982F90));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_UNEXPECTEDMETADATATYPE"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_UNEXPECTEDMETADATATYPE _HRESULT_TYPEDEF_(0x88982F91L)")]
    public const int WINCODEC_ERR_UNEXPECTEDMETADATATYPE = unchecked((int)(0x88982F91));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_REQUESTONLYVALIDATMETADATAROOT"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_REQUESTONLYVALIDATMETADATAROOT _HRESULT_TYPEDEF_(0x88982F92L)")]
    public const int WINCODEC_ERR_REQUESTONLYVALIDATMETADATAROOT = unchecked((int)(0x88982F92));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_INVALIDQUERYCHARACTER"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_INVALIDQUERYCHARACTER _HRESULT_TYPEDEF_(0x88982F93L)")]
    public const int WINCODEC_ERR_INVALIDQUERYCHARACTER = unchecked((int)(0x88982F93));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_WIN32ERROR"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_WIN32ERROR _HRESULT_TYPEDEF_(0x88982F94L)")]
    public const int WINCODEC_ERR_WIN32ERROR = unchecked((int)(0x88982F94));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_INVALIDPROGRESSIVELEVEL"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_INVALIDPROGRESSIVELEVEL _HRESULT_TYPEDEF_(0x88982F95L)")]
    public const int WINCODEC_ERR_INVALIDPROGRESSIVELEVEL = unchecked((int)(0x88982F95));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_INVALIDJPEGSCANINDEX"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_INVALIDJPEGSCANINDEX _HRESULT_TYPEDEF_(0x88982F96L)")]
    public const int WINCODEC_ERR_INVALIDJPEGSCANINDEX = unchecked((int)(0x88982F96));

    /// <include file='WINCODEC.xml' path='doc/member[@name="WINCODEC.WINCODEC_ERR_UNSUPPORTEDTONEMAPPING"]/*' />
    [NativeTypeName("#define WINCODEC_ERR_UNSUPPORTEDTONEMAPPING _HRESULT_TYPEDEF_(0x88982F97L)")]
    public const int WINCODEC_ERR_UNSUPPORTEDTONEMAPPING = unchecked((int)(0x88982F97));
}
