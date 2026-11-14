// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

public static partial class DWRITE
{
    /// <include file='DWRITE.xml' path='doc/member[@name="DWRITE.DWRITE_E_FILEFORMAT"]/*' />
    [NativeTypeName("#define DWRITE_E_FILEFORMAT _HRESULT_TYPEDEF_(0x88985000L)")]
    public const int DWRITE_E_FILEFORMAT = unchecked((int)(0x88985000));

    /// <include file='DWRITE.xml' path='doc/member[@name="DWRITE.DWRITE_E_UNEXPECTED"]/*' />
    [NativeTypeName("#define DWRITE_E_UNEXPECTED _HRESULT_TYPEDEF_(0x88985001L)")]
    public const int DWRITE_E_UNEXPECTED = unchecked((int)(0x88985001));

    /// <include file='DWRITE.xml' path='doc/member[@name="DWRITE.DWRITE_E_NOFONT"]/*' />
    [NativeTypeName("#define DWRITE_E_NOFONT _HRESULT_TYPEDEF_(0x88985002L)")]
    public const int DWRITE_E_NOFONT = unchecked((int)(0x88985002));

    /// <include file='DWRITE.xml' path='doc/member[@name="DWRITE.DWRITE_E_FILENOTFOUND"]/*' />
    [NativeTypeName("#define DWRITE_E_FILENOTFOUND _HRESULT_TYPEDEF_(0x88985003L)")]
    public const int DWRITE_E_FILENOTFOUND = unchecked((int)(0x88985003));

    /// <include file='DWRITE.xml' path='doc/member[@name="DWRITE.DWRITE_E_FILEACCESS"]/*' />
    [NativeTypeName("#define DWRITE_E_FILEACCESS _HRESULT_TYPEDEF_(0x88985004L)")]
    public const int DWRITE_E_FILEACCESS = unchecked((int)(0x88985004));

    /// <include file='DWRITE.xml' path='doc/member[@name="DWRITE.DWRITE_E_FONTCOLLECTIONOBSOLETE"]/*' />
    [NativeTypeName("#define DWRITE_E_FONTCOLLECTIONOBSOLETE _HRESULT_TYPEDEF_(0x88985005L)")]
    public const int DWRITE_E_FONTCOLLECTIONOBSOLETE = unchecked((int)(0x88985005));

    /// <include file='DWRITE.xml' path='doc/member[@name="DWRITE.DWRITE_E_ALREADYREGISTERED"]/*' />
    [NativeTypeName("#define DWRITE_E_ALREADYREGISTERED _HRESULT_TYPEDEF_(0x88985006L)")]
    public const int DWRITE_E_ALREADYREGISTERED = unchecked((int)(0x88985006));

    /// <include file='DWRITE.xml' path='doc/member[@name="DWRITE.DWRITE_E_CACHEFORMAT"]/*' />
    [NativeTypeName("#define DWRITE_E_CACHEFORMAT _HRESULT_TYPEDEF_(0x88985007L)")]
    public const int DWRITE_E_CACHEFORMAT = unchecked((int)(0x88985007));

    /// <include file='DWRITE.xml' path='doc/member[@name="DWRITE.DWRITE_E_CACHEVERSION"]/*' />
    [NativeTypeName("#define DWRITE_E_CACHEVERSION _HRESULT_TYPEDEF_(0x88985008L)")]
    public const int DWRITE_E_CACHEVERSION = unchecked((int)(0x88985008));

    /// <include file='DWRITE.xml' path='doc/member[@name="DWRITE.DWRITE_E_UNSUPPORTEDOPERATION"]/*' />
    [NativeTypeName("#define DWRITE_E_UNSUPPORTEDOPERATION _HRESULT_TYPEDEF_(0x88985009L)")]
    public const int DWRITE_E_UNSUPPORTEDOPERATION = unchecked((int)(0x88985009));

    /// <include file='DWRITE.xml' path='doc/member[@name="DWRITE.DWRITE_E_TEXTRENDERERINCOMPATIBLE"]/*' />
    [NativeTypeName("#define DWRITE_E_TEXTRENDERERINCOMPATIBLE _HRESULT_TYPEDEF_(0x8898500AL)")]
    public const int DWRITE_E_TEXTRENDERERINCOMPATIBLE = unchecked((int)(0x8898500A));

    /// <include file='DWRITE.xml' path='doc/member[@name="DWRITE.DWRITE_E_FLOWDIRECTIONCONFLICTS"]/*' />
    [NativeTypeName("#define DWRITE_E_FLOWDIRECTIONCONFLICTS _HRESULT_TYPEDEF_(0x8898500BL)")]
    public const int DWRITE_E_FLOWDIRECTIONCONFLICTS = unchecked((int)(0x8898500B));

    /// <include file='DWRITE.xml' path='doc/member[@name="DWRITE.DWRITE_E_NOCOLOR"]/*' />
    [NativeTypeName("#define DWRITE_E_NOCOLOR _HRESULT_TYPEDEF_(0x8898500CL)")]
    public const int DWRITE_E_NOCOLOR = unchecked((int)(0x8898500C));

    /// <include file='DWRITE.xml' path='doc/member[@name="DWRITE.DWRITE_E_REMOTEFONT"]/*' />
    [NativeTypeName("#define DWRITE_E_REMOTEFONT _HRESULT_TYPEDEF_(0x8898500DL)")]
    public const int DWRITE_E_REMOTEFONT = unchecked((int)(0x8898500D));

    /// <include file='DWRITE.xml' path='doc/member[@name="DWRITE.DWRITE_E_DOWNLOADCANCELLED"]/*' />
    [NativeTypeName("#define DWRITE_E_DOWNLOADCANCELLED _HRESULT_TYPEDEF_(0x8898500EL)")]
    public const int DWRITE_E_DOWNLOADCANCELLED = unchecked((int)(0x8898500E));

    /// <include file='DWRITE.xml' path='doc/member[@name="DWRITE.DWRITE_E_DOWNLOADFAILED"]/*' />
    [NativeTypeName("#define DWRITE_E_DOWNLOADFAILED _HRESULT_TYPEDEF_(0x8898500FL)")]
    public const int DWRITE_E_DOWNLOADFAILED = unchecked((int)(0x8898500F));

    /// <include file='DWRITE.xml' path='doc/member[@name="DWRITE.DWRITE_E_TOOMANYDOWNLOADS"]/*' />
    [NativeTypeName("#define DWRITE_E_TOOMANYDOWNLOADS _HRESULT_TYPEDEF_(0x88985010L)")]
    public const int DWRITE_E_TOOMANYDOWNLOADS = unchecked((int)(0x88985010));
}
