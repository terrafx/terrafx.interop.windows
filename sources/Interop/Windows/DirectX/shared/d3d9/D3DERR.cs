// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

public static partial class D3DERR
{
    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_WRONGTEXTUREFORMAT"]/*' />
    [NativeTypeName("#define D3DERR_WRONGTEXTUREFORMAT MAKE_D3DHRESULT(2072)")]
    public const int D3DERR_WRONGTEXTUREFORMAT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2072))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_UNSUPPORTEDCOLOROPERATION"]/*' />
    [NativeTypeName("#define D3DERR_UNSUPPORTEDCOLOROPERATION MAKE_D3DHRESULT(2073)")]
    public const int D3DERR_UNSUPPORTEDCOLOROPERATION = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2073))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_UNSUPPORTEDCOLORARG"]/*' />
    [NativeTypeName("#define D3DERR_UNSUPPORTEDCOLORARG MAKE_D3DHRESULT(2074)")]
    public const int D3DERR_UNSUPPORTEDCOLORARG = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2074))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_UNSUPPORTEDALPHAOPERATION"]/*' />
    [NativeTypeName("#define D3DERR_UNSUPPORTEDALPHAOPERATION MAKE_D3DHRESULT(2075)")]
    public const int D3DERR_UNSUPPORTEDALPHAOPERATION = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2075))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_UNSUPPORTEDALPHAARG"]/*' />
    [NativeTypeName("#define D3DERR_UNSUPPORTEDALPHAARG MAKE_D3DHRESULT(2076)")]
    public const int D3DERR_UNSUPPORTEDALPHAARG = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2076))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_TOOMANYOPERATIONS"]/*' />
    [NativeTypeName("#define D3DERR_TOOMANYOPERATIONS MAKE_D3DHRESULT(2077)")]
    public const int D3DERR_TOOMANYOPERATIONS = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2077))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_CONFLICTINGTEXTUREFILTER"]/*' />
    [NativeTypeName("#define D3DERR_CONFLICTINGTEXTUREFILTER MAKE_D3DHRESULT(2078)")]
    public const int D3DERR_CONFLICTINGTEXTUREFILTER = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2078))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_UNSUPPORTEDFACTORVALUE"]/*' />
    [NativeTypeName("#define D3DERR_UNSUPPORTEDFACTORVALUE MAKE_D3DHRESULT(2079)")]
    public const int D3DERR_UNSUPPORTEDFACTORVALUE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2079))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_CONFLICTINGRENDERSTATE"]/*' />
    [NativeTypeName("#define D3DERR_CONFLICTINGRENDERSTATE MAKE_D3DHRESULT(2081)")]
    public const int D3DERR_CONFLICTINGRENDERSTATE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2081))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_UNSUPPORTEDTEXTUREFILTER"]/*' />
    [NativeTypeName("#define D3DERR_UNSUPPORTEDTEXTUREFILTER MAKE_D3DHRESULT(2082)")]
    public const int D3DERR_UNSUPPORTEDTEXTUREFILTER = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2082))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_CONFLICTINGTEXTUREPALETTE"]/*' />
    [NativeTypeName("#define D3DERR_CONFLICTINGTEXTUREPALETTE MAKE_D3DHRESULT(2086)")]
    public const int D3DERR_CONFLICTINGTEXTUREPALETTE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2086))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_DRIVERINTERNALERROR"]/*' />
    [NativeTypeName("#define D3DERR_DRIVERINTERNALERROR MAKE_D3DHRESULT(2087)")]
    public const int D3DERR_DRIVERINTERNALERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2087))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_NOTFOUND"]/*' />
    [NativeTypeName("#define D3DERR_NOTFOUND MAKE_D3DHRESULT(2150)")]
    public const int D3DERR_NOTFOUND = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2150))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_MOREDATA"]/*' />
    [NativeTypeName("#define D3DERR_MOREDATA MAKE_D3DHRESULT(2151)")]
    public const int D3DERR_MOREDATA = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2151))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_DEVICELOST"]/*' />
    [NativeTypeName("#define D3DERR_DEVICELOST MAKE_D3DHRESULT(2152)")]
    public const int D3DERR_DEVICELOST = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2152))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_DEVICENOTRESET"]/*' />
    [NativeTypeName("#define D3DERR_DEVICENOTRESET MAKE_D3DHRESULT(2153)")]
    public const int D3DERR_DEVICENOTRESET = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2153))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_NOTAVAILABLE"]/*' />
    [NativeTypeName("#define D3DERR_NOTAVAILABLE MAKE_D3DHRESULT(2154)")]
    public const int D3DERR_NOTAVAILABLE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2154))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_OUTOFVIDEOMEMORY"]/*' />
    [NativeTypeName("#define D3DERR_OUTOFVIDEOMEMORY MAKE_D3DHRESULT(380)")]
    public const int D3DERR_OUTOFVIDEOMEMORY = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(380))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_INVALIDDEVICE"]/*' />
    [NativeTypeName("#define D3DERR_INVALIDDEVICE MAKE_D3DHRESULT(2155)")]
    public const int D3DERR_INVALIDDEVICE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2155))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_INVALIDCALL"]/*' />
    [NativeTypeName("#define D3DERR_INVALIDCALL MAKE_D3DHRESULT(2156)")]
    public const int D3DERR_INVALIDCALL = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2156))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_DRIVERINVALIDCALL"]/*' />
    [NativeTypeName("#define D3DERR_DRIVERINVALIDCALL MAKE_D3DHRESULT(2157)")]
    public const int D3DERR_DRIVERINVALIDCALL = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2157))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_WASSTILLDRAWING"]/*' />
    [NativeTypeName("#define D3DERR_WASSTILLDRAWING MAKE_D3DHRESULT(540)")]
    public const int D3DERR_WASSTILLDRAWING = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(540))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_DEVICEREMOVED"]/*' />
    [NativeTypeName("#define D3DERR_DEVICEREMOVED MAKE_D3DHRESULT(2160)")]
    public const int D3DERR_DEVICEREMOVED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2160))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_DEVICEHUNG"]/*' />
    [NativeTypeName("#define D3DERR_DEVICEHUNG MAKE_D3DHRESULT(2164)")]
    public const int D3DERR_DEVICEHUNG = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2164))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_UNSUPPORTEDOVERLAY"]/*' />
    [NativeTypeName("#define D3DERR_UNSUPPORTEDOVERLAY MAKE_D3DHRESULT(2171)")]
    public const int D3DERR_UNSUPPORTEDOVERLAY = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2171))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_UNSUPPORTEDOVERLAYFORMAT"]/*' />
    [NativeTypeName("#define D3DERR_UNSUPPORTEDOVERLAYFORMAT MAKE_D3DHRESULT(2172)")]
    public const int D3DERR_UNSUPPORTEDOVERLAYFORMAT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2172))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_CANNOTPROTECTCONTENT"]/*' />
    [NativeTypeName("#define D3DERR_CANNOTPROTECTCONTENT MAKE_D3DHRESULT(2173)")]
    public const int D3DERR_CANNOTPROTECTCONTENT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2173))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_UNSUPPORTEDCRYPTO"]/*' />
    [NativeTypeName("#define D3DERR_UNSUPPORTEDCRYPTO MAKE_D3DHRESULT(2174)")]
    public const int D3DERR_UNSUPPORTEDCRYPTO = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2174))));

    /// <include file='D3DERR.xml' path='doc/member[@name="D3DERR.D3DERR_PRESENT_STATISTICS_DISJOINT"]/*' />
    [NativeTypeName("#define D3DERR_PRESENT_STATISTICS_DISJOINT MAKE_D3DHRESULT(2180)")]
    public const int D3DERR_PRESENT_STATISTICS_DISJOINT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2180))));
}
