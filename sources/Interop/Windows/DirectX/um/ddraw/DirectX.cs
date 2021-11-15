// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    public static unsafe partial class DirectX
    {
        [DllImport("ddraw", ExactSpelling = true)]
        public static extern HRESULT DirectDrawEnumerateW([NativeTypeName("LPDDENUMCALLBACKW")] delegate* unmanaged<Guid*, ushort*, ushort*, void*, BOOL> lpCallback, [NativeTypeName("LPVOID")] void* lpContext);

        [DllImport("ddraw", ExactSpelling = true)]
        public static extern HRESULT DirectDrawEnumerateA([NativeTypeName("LPDDENUMCALLBACKA")] delegate* unmanaged<Guid*, sbyte*, sbyte*, void*, BOOL> lpCallback, [NativeTypeName("LPVOID")] void* lpContext);

        [DllImport("ddraw", ExactSpelling = true)]
        public static extern HRESULT DirectDrawEnumerateExW([NativeTypeName("LPDDENUMCALLBACKEXW")] delegate* unmanaged<Guid*, ushort*, ushort*, void*, HMONITOR, BOOL> lpCallback, [NativeTypeName("LPVOID")] void* lpContext, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("ddraw", ExactSpelling = true)]
        public static extern HRESULT DirectDrawEnumerateExA([NativeTypeName("LPDDENUMCALLBACKEXA")] delegate* unmanaged<Guid*, sbyte*, sbyte*, void*, HMONITOR, BOOL> lpCallback, [NativeTypeName("LPVOID")] void* lpContext, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("ddraw", ExactSpelling = true)]
        public static extern HRESULT DirectDrawCreate(Guid* lpGUID, [NativeTypeName("LPDIRECTDRAW *")] IDirectDraw** lplpDD, IUnknown* pUnkOuter);

        [DllImport("ddraw", ExactSpelling = true)]
        public static extern HRESULT DirectDrawCreateEx(Guid* lpGuid, [NativeTypeName("LPVOID *")] void** lplpDD, [NativeTypeName("const IID &")] Guid* iid, IUnknown* pUnkOuter);

        [DllImport("ddraw", ExactSpelling = true)]
        public static extern HRESULT DirectDrawCreateClipper([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPDIRECTDRAWCLIPPER *")] IDirectDrawClipper** lplpDDClipper, IUnknown* pUnkOuter);

        [NativeTypeName("#define DIRECTDRAW_VERSION 0x0700")]
        public const int DIRECTDRAW_VERSION = 0x0700;

        [NativeTypeName("#define _FACDD 0x876")]
        public const int _FACDD = 0x876;

        [NativeTypeName("#define FOURCC_DXT1 (MAKEFOURCC('D','X','T','1'))")]
        public const uint FOURCC_DXT1 = (((uint)((byte)('D')) | ((uint)((byte)('X')) << 8) | ((uint)((byte)('T')) << 16) | ((uint)((byte)('1')) << 24)));

        [NativeTypeName("#define FOURCC_DXT2 (MAKEFOURCC('D','X','T','2'))")]
        public const uint FOURCC_DXT2 = (((uint)((byte)('D')) | ((uint)((byte)('X')) << 8) | ((uint)((byte)('T')) << 16) | ((uint)((byte)('2')) << 24)));

        [NativeTypeName("#define FOURCC_DXT3 (MAKEFOURCC('D','X','T','3'))")]
        public const uint FOURCC_DXT3 = (((uint)((byte)('D')) | ((uint)((byte)('X')) << 8) | ((uint)((byte)('T')) << 16) | ((uint)((byte)('3')) << 24)));

        [NativeTypeName("#define FOURCC_DXT4 (MAKEFOURCC('D','X','T','4'))")]
        public const uint FOURCC_DXT4 = (((uint)((byte)('D')) | ((uint)((byte)('X')) << 8) | ((uint)((byte)('T')) << 16) | ((uint)((byte)('4')) << 24)));

        [NativeTypeName("#define FOURCC_DXT5 (MAKEFOURCC('D','X','T','5'))")]
        public const uint FOURCC_DXT5 = (((uint)((byte)('D')) | ((uint)((byte)('X')) << 8) | ((uint)((byte)('T')) << 16) | ((uint)((byte)('5')) << 24)));

        [NativeTypeName("#define DirectDrawEnumerate DirectDrawEnumerateW")]
        public static delegate*<delegate* unmanaged<Guid*, ushort*, ushort*, void*, BOOL>, void*, HRESULT> DirectDrawEnumerate => &DirectDrawEnumerateW;

        [NativeTypeName("#define DirectDrawEnumerateEx DirectDrawEnumerateExW")]
        public static delegate*<delegate* unmanaged<Guid*, ushort*, ushort*, void*, HMONITOR, BOOL>, void*, uint, HRESULT> DirectDrawEnumerateEx => &DirectDrawEnumerateExW;

        [NativeTypeName("#define DDENUM_ATTACHEDSECONDARYDEVICES 0x00000001L")]
        public const int DDENUM_ATTACHEDSECONDARYDEVICES = 0x00000001;

        [NativeTypeName("#define DDENUM_DETACHEDSECONDARYDEVICES 0x00000002L")]
        public const int DDENUM_DETACHEDSECONDARYDEVICES = 0x00000002;

        [NativeTypeName("#define DDENUM_NONDISPLAYDEVICES 0x00000004L")]
        public const int DDENUM_NONDISPLAYDEVICES = 0x00000004;

        [NativeTypeName("#define REGSTR_KEY_DDHW_DESCRIPTION \"Description\"")]
        public static ReadOnlySpan<byte> REGSTR_KEY_DDHW_DESCRIPTION => new byte[] { 0x44, 0x65, 0x73, 0x63, 0x72, 0x69, 0x70, 0x74, 0x69, 0x6F, 0x6E, 0x00 };

        [NativeTypeName("#define REGSTR_KEY_DDHW_DRIVERNAME \"DriverName\"")]
        public static ReadOnlySpan<byte> REGSTR_KEY_DDHW_DRIVERNAME => new byte[] { 0x44, 0x72, 0x69, 0x76, 0x65, 0x72, 0x4E, 0x61, 0x6D, 0x65, 0x00 };

        [NativeTypeName("#define REGSTR_PATH_DDHW \"Hardware\\\\DirectDrawDrivers\"")]
        public static ReadOnlySpan<byte> REGSTR_PATH_DDHW => new byte[] { 0x48, 0x61, 0x72, 0x64, 0x77, 0x61, 0x72, 0x65, 0x5C, 0x44, 0x69, 0x72, 0x65, 0x63, 0x74, 0x44, 0x72, 0x61, 0x77, 0x44, 0x72, 0x69, 0x76, 0x65, 0x72, 0x73, 0x00 };

        [NativeTypeName("#define DDCREATE_HARDWAREONLY 0x00000001l")]
        public const int DDCREATE_HARDWAREONLY = 0x00000001;

        [NativeTypeName("#define DDCREATE_EMULATIONONLY 0x00000002l")]
        public const int DDCREATE_EMULATIONONLY = 0x00000002;

        [NativeTypeName("#define DD_ROP_SPACE (256/32)")]
        public const int DD_ROP_SPACE = (256 / 32);

        [NativeTypeName("#define DDGDI_GETHOSTIDENTIFIER 0x00000001L")]
        public const int DDGDI_GETHOSTIDENTIFIER = 0x00000001;

        [NativeTypeName("#define DDOSD_GUID 0x00000001l")]
        public const int DDOSD_GUID = 0x00000001;

        [NativeTypeName("#define DDOSD_COMPRESSION_RATIO 0x00000002l")]
        public const int DDOSD_COMPRESSION_RATIO = 0x00000002;

        [NativeTypeName("#define DDOSD_SCAPS 0x00000004l")]
        public const int DDOSD_SCAPS = 0x00000004;

        [NativeTypeName("#define DDOSD_OSCAPS 0x00000008l")]
        public const int DDOSD_OSCAPS = 0x00000008;

        [NativeTypeName("#define DDOSD_ALL 0x0000000fl")]
        public const int DDOSD_ALL = 0x0000000f;

        [NativeTypeName("#define DDOSDCAPS_OPTCOMPRESSED 0x00000001l")]
        public const int DDOSDCAPS_OPTCOMPRESSED = 0x00000001;

        [NativeTypeName("#define DDOSDCAPS_OPTREORDERED 0x00000002l")]
        public const int DDOSDCAPS_OPTREORDERED = 0x00000002;

        [NativeTypeName("#define DDOSDCAPS_MONOLITHICMIPMAP 0x00000004l")]
        public const int DDOSDCAPS_MONOLITHICMIPMAP = 0x00000004;

        [NativeTypeName("#define DDOSDCAPS_VALIDSCAPS 0x30004800l")]
        public const int DDOSDCAPS_VALIDSCAPS = 0x30004800;

        [NativeTypeName("#define DDOSDCAPS_VALIDOSCAPS 0x00000007l")]
        public const int DDOSDCAPS_VALIDOSCAPS = 0x00000007;

        [NativeTypeName("#define DDCOLOR_BRIGHTNESS 0x00000001l")]
        public const int DDCOLOR_BRIGHTNESS = 0x00000001;

        [NativeTypeName("#define DDCOLOR_CONTRAST 0x00000002l")]
        public const int DDCOLOR_CONTRAST = 0x00000002;

        [NativeTypeName("#define DDCOLOR_HUE 0x00000004l")]
        public const int DDCOLOR_HUE = 0x00000004;

        [NativeTypeName("#define DDCOLOR_SATURATION 0x00000008l")]
        public const int DDCOLOR_SATURATION = 0x00000008;

        [NativeTypeName("#define DDCOLOR_SHARPNESS 0x00000010l")]
        public const int DDCOLOR_SHARPNESS = 0x00000010;

        [NativeTypeName("#define DDCOLOR_GAMMA 0x00000020l")]
        public const int DDCOLOR_GAMMA = 0x00000020;

        [NativeTypeName("#define DDCOLOR_COLORENABLE 0x00000040l")]
        public const int DDCOLOR_COLORENABLE = 0x00000040;

        [NativeTypeName("#define DDSVCAPS_RESERVED1 0x00000001l")]
        public const int DDSVCAPS_RESERVED1 = 0x00000001;

        [NativeTypeName("#define DDSVCAPS_RESERVED2 0x00000002l")]
        public const int DDSVCAPS_RESERVED2 = 0x00000002;

        [NativeTypeName("#define DDSVCAPS_RESERVED3 0x00000004l")]
        public const int DDSVCAPS_RESERVED3 = 0x00000004;

        [NativeTypeName("#define DDSVCAPS_RESERVED4 0x00000008l")]
        public const int DDSVCAPS_RESERVED4 = 0x00000008;

        [NativeTypeName("#define DDSVCAPS_STEREOSEQUENTIAL 0x00000010L")]
        public const int DDSVCAPS_STEREOSEQUENTIAL = 0x00000010;

        [NativeTypeName("#define DDSPD_IUNKNOWNPOINTER 0x00000001L")]
        public const int DDSPD_IUNKNOWNPOINTER = 0x00000001;

        [NativeTypeName("#define DDSPD_VOLATILE 0x00000002L")]
        public const int DDSPD_VOLATILE = 0x00000002;

        [NativeTypeName("#define DDBD_1 0x00004000l")]
        public const int DDBD_1 = 0x00004000;

        [NativeTypeName("#define DDBD_2 0x00002000l")]
        public const int DDBD_2 = 0x00002000;

        [NativeTypeName("#define DDBD_4 0x00001000l")]
        public const int DDBD_4 = 0x00001000;

        [NativeTypeName("#define DDBD_8 0x00000800l")]
        public const int DDBD_8 = 0x00000800;

        [NativeTypeName("#define DDBD_16 0x00000400l")]
        public const int DDBD_16 = 0x00000400;

        [NativeTypeName("#define DDBD_24 0X00000200l")]
        public const int DDBD_24 = 0X00000200;

        [NativeTypeName("#define DDBD_32 0x00000100l")]
        public const int DDBD_32 = 0x00000100;

        [NativeTypeName("#define DDCKEY_COLORSPACE 0x00000001l")]
        public const int DDCKEY_COLORSPACE = 0x00000001;

        [NativeTypeName("#define DDCKEY_DESTBLT 0x00000002l")]
        public const int DDCKEY_DESTBLT = 0x00000002;

        [NativeTypeName("#define DDCKEY_DESTOVERLAY 0x00000004l")]
        public const int DDCKEY_DESTOVERLAY = 0x00000004;

        [NativeTypeName("#define DDCKEY_SRCBLT 0x00000008l")]
        public const int DDCKEY_SRCBLT = 0x00000008;

        [NativeTypeName("#define DDCKEY_SRCOVERLAY 0x00000010l")]
        public const int DDCKEY_SRCOVERLAY = 0x00000010;

        [NativeTypeName("#define DDENUMSURFACES_ALL 0x00000001l")]
        public const int DDENUMSURFACES_ALL = 0x00000001;

        [NativeTypeName("#define DDENUMSURFACES_MATCH 0x00000002l")]
        public const int DDENUMSURFACES_MATCH = 0x00000002;

        [NativeTypeName("#define DDENUMSURFACES_NOMATCH 0x00000004l")]
        public const int DDENUMSURFACES_NOMATCH = 0x00000004;

        [NativeTypeName("#define DDENUMSURFACES_CANBECREATED 0x00000008l")]
        public const int DDENUMSURFACES_CANBECREATED = 0x00000008;

        [NativeTypeName("#define DDENUMSURFACES_DOESEXIST 0x00000010l")]
        public const int DDENUMSURFACES_DOESEXIST = 0x00000010;

        [NativeTypeName("#define DDSDM_STANDARDVGAMODE 0x00000001l")]
        public const int DDSDM_STANDARDVGAMODE = 0x00000001;

        [NativeTypeName("#define DDEDM_REFRESHRATES 0x00000001l")]
        public const int DDEDM_REFRESHRATES = 0x00000001;

        [NativeTypeName("#define DDEDM_STANDARDVGAMODES 0x00000002L")]
        public const int DDEDM_STANDARDVGAMODES = 0x00000002;

        [NativeTypeName("#define DDBLTFAST_NOCOLORKEY 0x00000000")]
        public const int DDBLTFAST_NOCOLORKEY = 0x00000000;

        [NativeTypeName("#define DDBLTFAST_SRCCOLORKEY 0x00000001")]
        public const int DDBLTFAST_SRCCOLORKEY = 0x00000001;

        [NativeTypeName("#define DDBLTFAST_DESTCOLORKEY 0x00000002")]
        public const int DDBLTFAST_DESTCOLORKEY = 0x00000002;

        [NativeTypeName("#define DDBLTFAST_WAIT 0x00000010")]
        public const int DDBLTFAST_WAIT = 0x00000010;

        [NativeTypeName("#define DDBLTFAST_DONOTWAIT 0x00000020")]
        public const int DDBLTFAST_DONOTWAIT = 0x00000020;

        [NativeTypeName("#define DDFLIP_WAIT 0x00000001L")]
        public const int DDFLIP_WAIT = 0x00000001;

        [NativeTypeName("#define DDFLIP_EVEN 0x00000002L")]
        public const int DDFLIP_EVEN = 0x00000002;

        [NativeTypeName("#define DDFLIP_ODD 0x00000004L")]
        public const int DDFLIP_ODD = 0x00000004;

        [NativeTypeName("#define DDFLIP_NOVSYNC 0x00000008L")]
        public const int DDFLIP_NOVSYNC = 0x00000008;

        [NativeTypeName("#define DDFLIP_INTERVAL2 0x02000000L")]
        public const int DDFLIP_INTERVAL2 = 0x02000000;

        [NativeTypeName("#define DDFLIP_INTERVAL3 0x03000000L")]
        public const int DDFLIP_INTERVAL3 = 0x03000000;

        [NativeTypeName("#define DDFLIP_INTERVAL4 0x04000000L")]
        public const int DDFLIP_INTERVAL4 = 0x04000000;

        [NativeTypeName("#define DDFLIP_STEREO 0x00000010L")]
        public const int DDFLIP_STEREO = 0x00000010;

        [NativeTypeName("#define DDFLIP_DONOTWAIT 0x00000020L")]
        public const int DDFLIP_DONOTWAIT = 0x00000020;

        [NativeTypeName("#define DDBLTFX_ARITHSTRETCHY 0x00000001l")]
        public const int DDBLTFX_ARITHSTRETCHY = 0x00000001;

        [NativeTypeName("#define DDBLTFX_MIRRORLEFTRIGHT 0x00000002l")]
        public const int DDBLTFX_MIRRORLEFTRIGHT = 0x00000002;

        [NativeTypeName("#define DDBLTFX_MIRRORUPDOWN 0x00000004l")]
        public const int DDBLTFX_MIRRORUPDOWN = 0x00000004;

        [NativeTypeName("#define DDBLTFX_NOTEARING 0x00000008l")]
        public const int DDBLTFX_NOTEARING = 0x00000008;

        [NativeTypeName("#define DDBLTFX_ROTATE180 0x00000010l")]
        public const int DDBLTFX_ROTATE180 = 0x00000010;

        [NativeTypeName("#define DDBLTFX_ROTATE270 0x00000020l")]
        public const int DDBLTFX_ROTATE270 = 0x00000020;

        [NativeTypeName("#define DDBLTFX_ROTATE90 0x00000040l")]
        public const int DDBLTFX_ROTATE90 = 0x00000040;

        [NativeTypeName("#define DDBLTFX_ZBUFFERRANGE 0x00000080l")]
        public const int DDBLTFX_ZBUFFERRANGE = 0x00000080;

        [NativeTypeName("#define DDBLTFX_ZBUFFERBASEDEST 0x00000100l")]
        public const int DDBLTFX_ZBUFFERBASEDEST = 0x00000100;

        [NativeTypeName("#define DDOVERFX_ARITHSTRETCHY 0x00000001l")]
        public const int DDOVERFX_ARITHSTRETCHY = 0x00000001;

        [NativeTypeName("#define DDOVERFX_MIRRORLEFTRIGHT 0x00000002l")]
        public const int DDOVERFX_MIRRORLEFTRIGHT = 0x00000002;

        [NativeTypeName("#define DDOVERFX_MIRRORUPDOWN 0x00000004l")]
        public const int DDOVERFX_MIRRORUPDOWN = 0x00000004;

        [NativeTypeName("#define DDOVERFX_DEINTERLACE 0x00000008l")]
        public const int DDOVERFX_DEINTERLACE = 0x00000008;

        [NativeTypeName("#define DDWAITVB_BLOCKBEGIN 0x00000001l")]
        public const int DDWAITVB_BLOCKBEGIN = 0x00000001;

        [NativeTypeName("#define DDWAITVB_BLOCKBEGINEVENT 0x00000002l")]
        public const int DDWAITVB_BLOCKBEGINEVENT = 0x00000002;

        [NativeTypeName("#define DDWAITVB_BLOCKEND 0x00000004l")]
        public const int DDWAITVB_BLOCKEND = 0x00000004;

        [NativeTypeName("#define DDGFS_CANFLIP 0x00000001l")]
        public const int DDGFS_CANFLIP = 0x00000001;

        [NativeTypeName("#define DDGFS_ISFLIPDONE 0x00000002l")]
        public const int DDGFS_ISFLIPDONE = 0x00000002;

        [NativeTypeName("#define DDGBS_CANBLT 0x00000001l")]
        public const int DDGBS_CANBLT = 0x00000001;

        [NativeTypeName("#define DDGBS_ISBLTDONE 0x00000002l")]
        public const int DDGBS_ISBLTDONE = 0x00000002;

        [NativeTypeName("#define DDENUMOVERLAYZ_BACKTOFRONT 0x00000000l")]
        public const int DDENUMOVERLAYZ_BACKTOFRONT = 0x00000000;

        [NativeTypeName("#define DDENUMOVERLAYZ_FRONTTOBACK 0x00000001l")]
        public const int DDENUMOVERLAYZ_FRONTTOBACK = 0x00000001;

        [NativeTypeName("#define DDOVERZ_SENDTOFRONT 0x00000000l")]
        public const int DDOVERZ_SENDTOFRONT = 0x00000000;

        [NativeTypeName("#define DDOVERZ_SENDTOBACK 0x00000001l")]
        public const int DDOVERZ_SENDTOBACK = 0x00000001;

        [NativeTypeName("#define DDOVERZ_MOVEFORWARD 0x00000002l")]
        public const int DDOVERZ_MOVEFORWARD = 0x00000002;

        [NativeTypeName("#define DDOVERZ_MOVEBACKWARD 0x00000003l")]
        public const int DDOVERZ_MOVEBACKWARD = 0x00000003;

        [NativeTypeName("#define DDOVERZ_INSERTINFRONTOF 0x00000004l")]
        public const int DDOVERZ_INSERTINFRONTOF = 0x00000004;

        [NativeTypeName("#define DDOVERZ_INSERTINBACKOF 0x00000005l")]
        public const int DDOVERZ_INSERTINBACKOF = 0x00000005;

        [NativeTypeName("#define DDSGR_CALIBRATE 0x00000001L")]
        public const int DDSGR_CALIBRATE = 0x00000001;

        [NativeTypeName("#define DDSMT_ISTESTREQUIRED 0x00000001L")]
        public const int DDSMT_ISTESTREQUIRED = 0x00000001;

        [NativeTypeName("#define DDEM_MODEPASSED 0x00000001L")]
        public const int DDEM_MODEPASSED = 0x00000001;

        [NativeTypeName("#define DDEM_MODEFAILED 0x00000002L")]
        public const int DDEM_MODEFAILED = 0x00000002;

        [NativeTypeName("#define DD_OK S_OK")]
        public const int DD_OK = ((int)(0));

        [NativeTypeName("#define DD_FALSE S_FALSE")]
        public const int DD_FALSE = ((int)(1));

        [NativeTypeName("#define DDENUMRET_CANCEL 0")]
        public const int DDENUMRET_CANCEL = 0;

        [NativeTypeName("#define DDENUMRET_OK 1")]
        public const int DDENUMRET_OK = 1;
    }
}
