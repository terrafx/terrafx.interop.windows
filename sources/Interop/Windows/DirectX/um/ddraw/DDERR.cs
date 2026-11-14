// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

public static partial class DDERR
{
    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_ALREADYINITIALIZED"]/*' />
    [NativeTypeName("#define DDERR_ALREADYINITIALIZED MAKE_DDHRESULT( 5 )")]
    public const int DDERR_ALREADYINITIALIZED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(5))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_CANNOTATTACHSURFACE"]/*' />
    [NativeTypeName("#define DDERR_CANNOTATTACHSURFACE MAKE_DDHRESULT( 10 )")]
    public const int DDERR_CANNOTATTACHSURFACE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(10))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_CANNOTDETACHSURFACE"]/*' />
    [NativeTypeName("#define DDERR_CANNOTDETACHSURFACE MAKE_DDHRESULT( 20 )")]
    public const int DDERR_CANNOTDETACHSURFACE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(20))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_CURRENTLYNOTAVAIL"]/*' />
    [NativeTypeName("#define DDERR_CURRENTLYNOTAVAIL MAKE_DDHRESULT( 40 )")]
    public const int DDERR_CURRENTLYNOTAVAIL = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(40))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_EXCEPTION"]/*' />
    [NativeTypeName("#define DDERR_EXCEPTION MAKE_DDHRESULT( 55 )")]
    public const int DDERR_EXCEPTION = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(55))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_GENERIC"]/*' />
    [NativeTypeName("#define DDERR_GENERIC E_FAIL")]
    public const int DDERR_GENERIC = unchecked((int)(0x80004005));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_HEIGHTALIGN"]/*' />
    [NativeTypeName("#define DDERR_HEIGHTALIGN MAKE_DDHRESULT( 90 )")]
    public const int DDERR_HEIGHTALIGN = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(90))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_INCOMPATIBLEPRIMARY"]/*' />
    [NativeTypeName("#define DDERR_INCOMPATIBLEPRIMARY MAKE_DDHRESULT( 95 )")]
    public const int DDERR_INCOMPATIBLEPRIMARY = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(95))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_INVALIDCAPS"]/*' />
    [NativeTypeName("#define DDERR_INVALIDCAPS MAKE_DDHRESULT( 100 )")]
    public const int DDERR_INVALIDCAPS = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(100))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_INVALIDCLIPLIST"]/*' />
    [NativeTypeName("#define DDERR_INVALIDCLIPLIST MAKE_DDHRESULT( 110 )")]
    public const int DDERR_INVALIDCLIPLIST = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(110))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_INVALIDMODE"]/*' />
    [NativeTypeName("#define DDERR_INVALIDMODE MAKE_DDHRESULT( 120 )")]
    public const int DDERR_INVALIDMODE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(120))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_INVALIDOBJECT"]/*' />
    [NativeTypeName("#define DDERR_INVALIDOBJECT MAKE_DDHRESULT( 130 )")]
    public const int DDERR_INVALIDOBJECT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(130))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_INVALIDPARAMS"]/*' />
    [NativeTypeName("#define DDERR_INVALIDPARAMS E_INVALIDARG")]
    public const int DDERR_INVALIDPARAMS = unchecked((int)(0x80070057));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_INVALIDPIXELFORMAT"]/*' />
    [NativeTypeName("#define DDERR_INVALIDPIXELFORMAT MAKE_DDHRESULT( 145 )")]
    public const int DDERR_INVALIDPIXELFORMAT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(145))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_INVALIDRECT"]/*' />
    [NativeTypeName("#define DDERR_INVALIDRECT MAKE_DDHRESULT( 150 )")]
    public const int DDERR_INVALIDRECT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(150))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_LOCKEDSURFACES"]/*' />
    [NativeTypeName("#define DDERR_LOCKEDSURFACES MAKE_DDHRESULT( 160 )")]
    public const int DDERR_LOCKEDSURFACES = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(160))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NO3D"]/*' />
    [NativeTypeName("#define DDERR_NO3D MAKE_DDHRESULT( 170 )")]
    public const int DDERR_NO3D = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(170))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOALPHAHW"]/*' />
    [NativeTypeName("#define DDERR_NOALPHAHW MAKE_DDHRESULT( 180 )")]
    public const int DDERR_NOALPHAHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(180))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOSTEREOHARDWARE"]/*' />
    [NativeTypeName("#define DDERR_NOSTEREOHARDWARE MAKE_DDHRESULT( 181 )")]
    public const int DDERR_NOSTEREOHARDWARE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(181))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOSURFACELEFT"]/*' />
    [NativeTypeName("#define DDERR_NOSURFACELEFT MAKE_DDHRESULT( 182 )")]
    public const int DDERR_NOSURFACELEFT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(182))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOCLIPLIST"]/*' />
    [NativeTypeName("#define DDERR_NOCLIPLIST MAKE_DDHRESULT( 205 )")]
    public const int DDERR_NOCLIPLIST = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(205))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOCOLORCONVHW"]/*' />
    [NativeTypeName("#define DDERR_NOCOLORCONVHW MAKE_DDHRESULT( 210 )")]
    public const int DDERR_NOCOLORCONVHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(210))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOCOOPERATIVELEVELSET"]/*' />
    [NativeTypeName("#define DDERR_NOCOOPERATIVELEVELSET MAKE_DDHRESULT( 212 )")]
    public const int DDERR_NOCOOPERATIVELEVELSET = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(212))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOCOLORKEY"]/*' />
    [NativeTypeName("#define DDERR_NOCOLORKEY MAKE_DDHRESULT( 215 )")]
    public const int DDERR_NOCOLORKEY = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(215))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOCOLORKEYHW"]/*' />
    [NativeTypeName("#define DDERR_NOCOLORKEYHW MAKE_DDHRESULT( 220 )")]
    public const int DDERR_NOCOLORKEYHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(220))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NODIRECTDRAWSUPPORT"]/*' />
    [NativeTypeName("#define DDERR_NODIRECTDRAWSUPPORT MAKE_DDHRESULT( 222 )")]
    public const int DDERR_NODIRECTDRAWSUPPORT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(222))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOEXCLUSIVEMODE"]/*' />
    [NativeTypeName("#define DDERR_NOEXCLUSIVEMODE MAKE_DDHRESULT( 225 )")]
    public const int DDERR_NOEXCLUSIVEMODE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(225))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOFLIPHW"]/*' />
    [NativeTypeName("#define DDERR_NOFLIPHW MAKE_DDHRESULT( 230 )")]
    public const int DDERR_NOFLIPHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(230))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOGDI"]/*' />
    [NativeTypeName("#define DDERR_NOGDI MAKE_DDHRESULT( 240 )")]
    public const int DDERR_NOGDI = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(240))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOMIRRORHW"]/*' />
    [NativeTypeName("#define DDERR_NOMIRRORHW MAKE_DDHRESULT( 250 )")]
    public const int DDERR_NOMIRRORHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(250))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOTFOUND"]/*' />
    [NativeTypeName("#define DDERR_NOTFOUND MAKE_DDHRESULT( 255 )")]
    public const int DDERR_NOTFOUND = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(255))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOOVERLAYHW"]/*' />
    [NativeTypeName("#define DDERR_NOOVERLAYHW MAKE_DDHRESULT( 260 )")]
    public const int DDERR_NOOVERLAYHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(260))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_OVERLAPPINGRECTS"]/*' />
    [NativeTypeName("#define DDERR_OVERLAPPINGRECTS MAKE_DDHRESULT( 270 )")]
    public const int DDERR_OVERLAPPINGRECTS = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(270))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NORASTEROPHW"]/*' />
    [NativeTypeName("#define DDERR_NORASTEROPHW MAKE_DDHRESULT( 280 )")]
    public const int DDERR_NORASTEROPHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(280))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOROTATIONHW"]/*' />
    [NativeTypeName("#define DDERR_NOROTATIONHW MAKE_DDHRESULT( 290 )")]
    public const int DDERR_NOROTATIONHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(290))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOSTRETCHHW"]/*' />
    [NativeTypeName("#define DDERR_NOSTRETCHHW MAKE_DDHRESULT( 310 )")]
    public const int DDERR_NOSTRETCHHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(310))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOT4BITCOLOR"]/*' />
    [NativeTypeName("#define DDERR_NOT4BITCOLOR MAKE_DDHRESULT( 316 )")]
    public const int DDERR_NOT4BITCOLOR = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(316))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOT4BITCOLORINDEX"]/*' />
    [NativeTypeName("#define DDERR_NOT4BITCOLORINDEX MAKE_DDHRESULT( 317 )")]
    public const int DDERR_NOT4BITCOLORINDEX = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(317))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOT8BITCOLOR"]/*' />
    [NativeTypeName("#define DDERR_NOT8BITCOLOR MAKE_DDHRESULT( 320 )")]
    public const int DDERR_NOT8BITCOLOR = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(320))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOTEXTUREHW"]/*' />
    [NativeTypeName("#define DDERR_NOTEXTUREHW MAKE_DDHRESULT( 330 )")]
    public const int DDERR_NOTEXTUREHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(330))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOVSYNCHW"]/*' />
    [NativeTypeName("#define DDERR_NOVSYNCHW MAKE_DDHRESULT( 335 )")]
    public const int DDERR_NOVSYNCHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(335))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOZBUFFERHW"]/*' />
    [NativeTypeName("#define DDERR_NOZBUFFERHW MAKE_DDHRESULT( 340 )")]
    public const int DDERR_NOZBUFFERHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(340))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOZOVERLAYHW"]/*' />
    [NativeTypeName("#define DDERR_NOZOVERLAYHW MAKE_DDHRESULT( 350 )")]
    public const int DDERR_NOZOVERLAYHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(350))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_OUTOFCAPS"]/*' />
    [NativeTypeName("#define DDERR_OUTOFCAPS MAKE_DDHRESULT( 360 )")]
    public const int DDERR_OUTOFCAPS = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(360))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_OUTOFMEMORY"]/*' />
    [NativeTypeName("#define DDERR_OUTOFMEMORY E_OUTOFMEMORY")]
    public const int DDERR_OUTOFMEMORY = unchecked((int)(0x8007000E));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_OUTOFVIDEOMEMORY"]/*' />
    [NativeTypeName("#define DDERR_OUTOFVIDEOMEMORY MAKE_DDHRESULT( 380 )")]
    public const int DDERR_OUTOFVIDEOMEMORY = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(380))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_OVERLAYCANTCLIP"]/*' />
    [NativeTypeName("#define DDERR_OVERLAYCANTCLIP MAKE_DDHRESULT( 382 )")]
    public const int DDERR_OVERLAYCANTCLIP = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(382))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_OVERLAYCOLORKEYONLYONEACTIVE"]/*' />
    [NativeTypeName("#define DDERR_OVERLAYCOLORKEYONLYONEACTIVE MAKE_DDHRESULT( 384 )")]
    public const int DDERR_OVERLAYCOLORKEYONLYONEACTIVE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(384))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_PALETTEBUSY"]/*' />
    [NativeTypeName("#define DDERR_PALETTEBUSY MAKE_DDHRESULT( 387 )")]
    public const int DDERR_PALETTEBUSY = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(387))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_COLORKEYNOTSET"]/*' />
    [NativeTypeName("#define DDERR_COLORKEYNOTSET MAKE_DDHRESULT( 400 )")]
    public const int DDERR_COLORKEYNOTSET = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(400))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_SURFACEALREADYATTACHED"]/*' />
    [NativeTypeName("#define DDERR_SURFACEALREADYATTACHED MAKE_DDHRESULT( 410 )")]
    public const int DDERR_SURFACEALREADYATTACHED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(410))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_SURFACEALREADYDEPENDENT"]/*' />
    [NativeTypeName("#define DDERR_SURFACEALREADYDEPENDENT MAKE_DDHRESULT( 420 )")]
    public const int DDERR_SURFACEALREADYDEPENDENT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(420))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_SURFACEBUSY"]/*' />
    [NativeTypeName("#define DDERR_SURFACEBUSY MAKE_DDHRESULT( 430 )")]
    public const int DDERR_SURFACEBUSY = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(430))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_CANTLOCKSURFACE"]/*' />
    [NativeTypeName("#define DDERR_CANTLOCKSURFACE MAKE_DDHRESULT( 435 )")]
    public const int DDERR_CANTLOCKSURFACE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(435))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_SURFACEISOBSCURED"]/*' />
    [NativeTypeName("#define DDERR_SURFACEISOBSCURED MAKE_DDHRESULT( 440 )")]
    public const int DDERR_SURFACEISOBSCURED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(440))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_SURFACELOST"]/*' />
    [NativeTypeName("#define DDERR_SURFACELOST MAKE_DDHRESULT( 450 )")]
    public const int DDERR_SURFACELOST = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(450))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_SURFACENOTATTACHED"]/*' />
    [NativeTypeName("#define DDERR_SURFACENOTATTACHED MAKE_DDHRESULT( 460 )")]
    public const int DDERR_SURFACENOTATTACHED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(460))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_TOOBIGHEIGHT"]/*' />
    [NativeTypeName("#define DDERR_TOOBIGHEIGHT MAKE_DDHRESULT( 470 )")]
    public const int DDERR_TOOBIGHEIGHT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(470))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_TOOBIGSIZE"]/*' />
    [NativeTypeName("#define DDERR_TOOBIGSIZE MAKE_DDHRESULT( 480 )")]
    public const int DDERR_TOOBIGSIZE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(480))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_TOOBIGWIDTH"]/*' />
    [NativeTypeName("#define DDERR_TOOBIGWIDTH MAKE_DDHRESULT( 490 )")]
    public const int DDERR_TOOBIGWIDTH = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(490))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_UNSUPPORTED"]/*' />
    [NativeTypeName("#define DDERR_UNSUPPORTED E_NOTIMPL")]
    public const int DDERR_UNSUPPORTED = unchecked((int)(0x80004001));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_UNSUPPORTEDFORMAT"]/*' />
    [NativeTypeName("#define DDERR_UNSUPPORTEDFORMAT MAKE_DDHRESULT( 510 )")]
    public const int DDERR_UNSUPPORTEDFORMAT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(510))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_UNSUPPORTEDMASK"]/*' />
    [NativeTypeName("#define DDERR_UNSUPPORTEDMASK MAKE_DDHRESULT( 520 )")]
    public const int DDERR_UNSUPPORTEDMASK = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(520))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_INVALIDSTREAM"]/*' />
    [NativeTypeName("#define DDERR_INVALIDSTREAM MAKE_DDHRESULT( 521 )")]
    public const int DDERR_INVALIDSTREAM = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(521))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_VERTICALBLANKINPROGRESS"]/*' />
    [NativeTypeName("#define DDERR_VERTICALBLANKINPROGRESS MAKE_DDHRESULT( 537 )")]
    public const int DDERR_VERTICALBLANKINPROGRESS = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(537))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_WASSTILLDRAWING"]/*' />
    [NativeTypeName("#define DDERR_WASSTILLDRAWING MAKE_DDHRESULT( 540 )")]
    public const int DDERR_WASSTILLDRAWING = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(540))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_DDSCAPSCOMPLEXREQUIRED"]/*' />
    [NativeTypeName("#define DDERR_DDSCAPSCOMPLEXREQUIRED MAKE_DDHRESULT( 542 )")]
    public const int DDERR_DDSCAPSCOMPLEXREQUIRED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(542))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_XALIGN"]/*' />
    [NativeTypeName("#define DDERR_XALIGN MAKE_DDHRESULT( 560 )")]
    public const int DDERR_XALIGN = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(560))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_INVALIDDIRECTDRAWGUID"]/*' />
    [NativeTypeName("#define DDERR_INVALIDDIRECTDRAWGUID MAKE_DDHRESULT( 561 )")]
    public const int DDERR_INVALIDDIRECTDRAWGUID = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(561))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_DIRECTDRAWALREADYCREATED"]/*' />
    [NativeTypeName("#define DDERR_DIRECTDRAWALREADYCREATED MAKE_DDHRESULT( 562 )")]
    public const int DDERR_DIRECTDRAWALREADYCREATED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(562))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NODIRECTDRAWHW"]/*' />
    [NativeTypeName("#define DDERR_NODIRECTDRAWHW MAKE_DDHRESULT( 563 )")]
    public const int DDERR_NODIRECTDRAWHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(563))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_PRIMARYSURFACEALREADYEXISTS"]/*' />
    [NativeTypeName("#define DDERR_PRIMARYSURFACEALREADYEXISTS MAKE_DDHRESULT( 564 )")]
    public const int DDERR_PRIMARYSURFACEALREADYEXISTS = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(564))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOEMULATION"]/*' />
    [NativeTypeName("#define DDERR_NOEMULATION MAKE_DDHRESULT( 565 )")]
    public const int DDERR_NOEMULATION = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(565))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_REGIONTOOSMALL"]/*' />
    [NativeTypeName("#define DDERR_REGIONTOOSMALL MAKE_DDHRESULT( 566 )")]
    public const int DDERR_REGIONTOOSMALL = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(566))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_CLIPPERISUSINGHWND"]/*' />
    [NativeTypeName("#define DDERR_CLIPPERISUSINGHWND MAKE_DDHRESULT( 567 )")]
    public const int DDERR_CLIPPERISUSINGHWND = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(567))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOCLIPPERATTACHED"]/*' />
    [NativeTypeName("#define DDERR_NOCLIPPERATTACHED MAKE_DDHRESULT( 568 )")]
    public const int DDERR_NOCLIPPERATTACHED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(568))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOHWND"]/*' />
    [NativeTypeName("#define DDERR_NOHWND MAKE_DDHRESULT( 569 )")]
    public const int DDERR_NOHWND = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(569))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_HWNDSUBCLASSED"]/*' />
    [NativeTypeName("#define DDERR_HWNDSUBCLASSED MAKE_DDHRESULT( 570 )")]
    public const int DDERR_HWNDSUBCLASSED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(570))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_HWNDALREADYSET"]/*' />
    [NativeTypeName("#define DDERR_HWNDALREADYSET MAKE_DDHRESULT( 571 )")]
    public const int DDERR_HWNDALREADYSET = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(571))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOPALETTEATTACHED"]/*' />
    [NativeTypeName("#define DDERR_NOPALETTEATTACHED MAKE_DDHRESULT( 572 )")]
    public const int DDERR_NOPALETTEATTACHED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(572))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOPALETTEHW"]/*' />
    [NativeTypeName("#define DDERR_NOPALETTEHW MAKE_DDHRESULT( 573 )")]
    public const int DDERR_NOPALETTEHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(573))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_BLTFASTCANTCLIP"]/*' />
    [NativeTypeName("#define DDERR_BLTFASTCANTCLIP MAKE_DDHRESULT( 574 )")]
    public const int DDERR_BLTFASTCANTCLIP = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(574))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOBLTHW"]/*' />
    [NativeTypeName("#define DDERR_NOBLTHW MAKE_DDHRESULT( 575 )")]
    public const int DDERR_NOBLTHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(575))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NODDROPSHW"]/*' />
    [NativeTypeName("#define DDERR_NODDROPSHW MAKE_DDHRESULT( 576 )")]
    public const int DDERR_NODDROPSHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(576))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_OVERLAYNOTVISIBLE"]/*' />
    [NativeTypeName("#define DDERR_OVERLAYNOTVISIBLE MAKE_DDHRESULT( 577 )")]
    public const int DDERR_OVERLAYNOTVISIBLE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(577))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOOVERLAYDEST"]/*' />
    [NativeTypeName("#define DDERR_NOOVERLAYDEST MAKE_DDHRESULT( 578 )")]
    public const int DDERR_NOOVERLAYDEST = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(578))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_INVALIDPOSITION"]/*' />
    [NativeTypeName("#define DDERR_INVALIDPOSITION MAKE_DDHRESULT( 579 )")]
    public const int DDERR_INVALIDPOSITION = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(579))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOTAOVERLAYSURFACE"]/*' />
    [NativeTypeName("#define DDERR_NOTAOVERLAYSURFACE MAKE_DDHRESULT( 580 )")]
    public const int DDERR_NOTAOVERLAYSURFACE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(580))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_EXCLUSIVEMODEALREADYSET"]/*' />
    [NativeTypeName("#define DDERR_EXCLUSIVEMODEALREADYSET MAKE_DDHRESULT( 581 )")]
    public const int DDERR_EXCLUSIVEMODEALREADYSET = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(581))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOTFLIPPABLE"]/*' />
    [NativeTypeName("#define DDERR_NOTFLIPPABLE MAKE_DDHRESULT( 582 )")]
    public const int DDERR_NOTFLIPPABLE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(582))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_CANTDUPLICATE"]/*' />
    [NativeTypeName("#define DDERR_CANTDUPLICATE MAKE_DDHRESULT( 583 )")]
    public const int DDERR_CANTDUPLICATE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(583))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOTLOCKED"]/*' />
    [NativeTypeName("#define DDERR_NOTLOCKED MAKE_DDHRESULT( 584 )")]
    public const int DDERR_NOTLOCKED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(584))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_CANTCREATEDC"]/*' />
    [NativeTypeName("#define DDERR_CANTCREATEDC MAKE_DDHRESULT( 585 )")]
    public const int DDERR_CANTCREATEDC = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(585))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NODC"]/*' />
    [NativeTypeName("#define DDERR_NODC MAKE_DDHRESULT( 586 )")]
    public const int DDERR_NODC = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(586))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_WRONGMODE"]/*' />
    [NativeTypeName("#define DDERR_WRONGMODE MAKE_DDHRESULT( 587 )")]
    public const int DDERR_WRONGMODE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(587))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_IMPLICITLYCREATED"]/*' />
    [NativeTypeName("#define DDERR_IMPLICITLYCREATED MAKE_DDHRESULT( 588 )")]
    public const int DDERR_IMPLICITLYCREATED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(588))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOTPALETTIZED"]/*' />
    [NativeTypeName("#define DDERR_NOTPALETTIZED MAKE_DDHRESULT( 589 )")]
    public const int DDERR_NOTPALETTIZED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(589))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_UNSUPPORTEDMODE"]/*' />
    [NativeTypeName("#define DDERR_UNSUPPORTEDMODE MAKE_DDHRESULT( 590 )")]
    public const int DDERR_UNSUPPORTEDMODE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(590))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOMIPMAPHW"]/*' />
    [NativeTypeName("#define DDERR_NOMIPMAPHW MAKE_DDHRESULT( 591 )")]
    public const int DDERR_NOMIPMAPHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(591))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_INVALIDSURFACETYPE"]/*' />
    [NativeTypeName("#define DDERR_INVALIDSURFACETYPE MAKE_DDHRESULT( 592 )")]
    public const int DDERR_INVALIDSURFACETYPE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(592))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOOPTIMIZEHW"]/*' />
    [NativeTypeName("#define DDERR_NOOPTIMIZEHW MAKE_DDHRESULT( 600 )")]
    public const int DDERR_NOOPTIMIZEHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(600))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOTLOADED"]/*' />
    [NativeTypeName("#define DDERR_NOTLOADED MAKE_DDHRESULT( 601 )")]
    public const int DDERR_NOTLOADED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(601))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOFOCUSWINDOW"]/*' />
    [NativeTypeName("#define DDERR_NOFOCUSWINDOW MAKE_DDHRESULT( 602 )")]
    public const int DDERR_NOFOCUSWINDOW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(602))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOTONMIPMAPSUBLEVEL"]/*' />
    [NativeTypeName("#define DDERR_NOTONMIPMAPSUBLEVEL MAKE_DDHRESULT( 603 )")]
    public const int DDERR_NOTONMIPMAPSUBLEVEL = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(603))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_DCALREADYCREATED"]/*' />
    [NativeTypeName("#define DDERR_DCALREADYCREATED MAKE_DDHRESULT( 620 )")]
    public const int DDERR_DCALREADYCREATED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(620))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NONONLOCALVIDMEM"]/*' />
    [NativeTypeName("#define DDERR_NONONLOCALVIDMEM MAKE_DDHRESULT( 630 )")]
    public const int DDERR_NONONLOCALVIDMEM = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(630))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_CANTPAGELOCK"]/*' />
    [NativeTypeName("#define DDERR_CANTPAGELOCK MAKE_DDHRESULT( 640 )")]
    public const int DDERR_CANTPAGELOCK = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(640))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_CANTPAGEUNLOCK"]/*' />
    [NativeTypeName("#define DDERR_CANTPAGEUNLOCK MAKE_DDHRESULT( 660 )")]
    public const int DDERR_CANTPAGEUNLOCK = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(660))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOTPAGELOCKED"]/*' />
    [NativeTypeName("#define DDERR_NOTPAGELOCKED MAKE_DDHRESULT( 680 )")]
    public const int DDERR_NOTPAGELOCKED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(680))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_MOREDATA"]/*' />
    [NativeTypeName("#define DDERR_MOREDATA MAKE_DDHRESULT( 690 )")]
    public const int DDERR_MOREDATA = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(690))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_EXPIRED"]/*' />
    [NativeTypeName("#define DDERR_EXPIRED MAKE_DDHRESULT( 691 )")]
    public const int DDERR_EXPIRED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(691))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_TESTFINISHED"]/*' />
    [NativeTypeName("#define DDERR_TESTFINISHED MAKE_DDHRESULT( 692 )")]
    public const int DDERR_TESTFINISHED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(692))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NEWMODE"]/*' />
    [NativeTypeName("#define DDERR_NEWMODE MAKE_DDHRESULT( 693 )")]
    public const int DDERR_NEWMODE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(693))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_D3DNOTINITIALIZED"]/*' />
    [NativeTypeName("#define DDERR_D3DNOTINITIALIZED MAKE_DDHRESULT( 694 )")]
    public const int DDERR_D3DNOTINITIALIZED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(694))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_VIDEONOTACTIVE"]/*' />
    [NativeTypeName("#define DDERR_VIDEONOTACTIVE MAKE_DDHRESULT( 695 )")]
    public const int DDERR_VIDEONOTACTIVE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(695))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOMONITORINFORMATION"]/*' />
    [NativeTypeName("#define DDERR_NOMONITORINFORMATION MAKE_DDHRESULT( 696 )")]
    public const int DDERR_NOMONITORINFORMATION = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(696))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NODRIVERSUPPORT"]/*' />
    [NativeTypeName("#define DDERR_NODRIVERSUPPORT MAKE_DDHRESULT( 697 )")]
    public const int DDERR_NODRIVERSUPPORT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(697))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_DEVICEDOESNTOWNSURFACE"]/*' />
    [NativeTypeName("#define DDERR_DEVICEDOESNTOWNSURFACE MAKE_DDHRESULT( 699 )")]
    public const int DDERR_DEVICEDOESNTOWNSURFACE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(699))));

    /// <include file='DDERR.xml' path='doc/member[@name="DDERR.DDERR_NOTINITIALIZED"]/*' />
    [NativeTypeName("#define DDERR_NOTINITIALIZED CO_E_NOTINITIALIZED")]
    public const int DDERR_NOTINITIALIZED = unchecked((int)(0x800401F0));
}
