// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DirectDraw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE0, 0x0E, 0xB7, 0xD7,
                    0x40, 0x43,
                    0xCF, 0x11,
                    0xB0,
                    0x63,
                    0x00,
                    0x20,
                    0xAF,
                    0xC2,
                    0xCD,
                    0x35
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DirectDraw7
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x96, 0x51, 0x30, 0x3C,
                    0xDB, 0x50,
                    0xD3, 0x11,
                    0x9C,
                    0xFE,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD9,
                    0x30,
                    0xC5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DirectDrawClipper
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0x17, 0x38, 0x59,
                    0xB3, 0x7D,
                    0xCF, 0x11,
                    0xA2,
                    0xDE,
                    0x00,
                    0xAA,
                    0x00,
                    0xB9,
                    0x33,
                    0x56
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDirectDraw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0xDB, 0x14, 0x6C,
                    0x33, 0xA7,
                    0xCE, 0x11,
                    0xA5,
                    0x21,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xE5,
                    0x60
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDirectDraw2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE0, 0xF3, 0xA6, 0xB3,
                    0x43, 0x2B,
                    0xCF, 0x11,
                    0xA2,
                    0xDE,
                    0x00,
                    0xAA,
                    0x00,
                    0xB9,
                    0x33,
                    0x56
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDirectDraw4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9A, 0x50, 0x59, 0x9C,
                    0xBD, 0x39,
                    0xD1, 0x11,
                    0x8C,
                    0x4A,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD9,
                    0x30,
                    0xC5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDirectDraw7
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC0, 0x5E, 0xE6, 0x15,
                    0x9C, 0x3B,
                    0xD2, 0x11,
                    0xB9,
                    0x2F,
                    0x00,
                    0x60,
                    0x97,
                    0x97,
                    0xEA,
                    0x5B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDirectDrawSurface
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x81, 0xDB, 0x14, 0x6C,
                    0x33, 0xA7,
                    0xCE, 0x11,
                    0xA5,
                    0x21,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xE5,
                    0x60
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDirectDrawSurface2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x85, 0x58, 0x80, 0x57,
                    0xEC, 0x6E,
                    0xCF, 0x11,
                    0x94,
                    0x41,
                    0xA8,
                    0x23,
                    0x03,
                    0xC1,
                    0x0E,
                    0x27
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDirectDrawSurface3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x4E, 0x04, 0xDA,
                    0xB2, 0x69,
                    0xD0, 0x11,
                    0xA1,
                    0xD5,
                    0x00,
                    0xAA,
                    0x00,
                    0xB8,
                    0xDF,
                    0xBB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDirectDrawSurface4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x30, 0x86, 0x2B, 0x0B,
                    0x35, 0xAD,
                    0xD0, 0x11,
                    0x8E,
                    0xA6,
                    0x00,
                    0x60,
                    0x97,
                    0x97,
                    0xEA,
                    0x5B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDirectDrawSurface7
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0x5A, 0x67, 0x06,
                    0x9B, 0x3B,
                    0xD2, 0x11,
                    0xB9,
                    0x2F,
                    0x00,
                    0x60,
                    0x97,
                    0x97,
                    0xEA,
                    0x5B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDirectDrawPalette
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x84, 0xDB, 0x14, 0x6C,
                    0x33, 0xA7,
                    0xCE, 0x11,
                    0xA5,
                    0x21,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xE5,
                    0x60
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDirectDrawClipper
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x85, 0xDB, 0x14, 0x6C,
                    0x33, 0xA7,
                    0xCE, 0x11,
                    0xA5,
                    0x21,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xE5,
                    0x60
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDirectDrawColorControl
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE0, 0x0E, 0x9F, 0x4B,
                    0x7E, 0x0D,
                    0xD0, 0x11,
                    0x9B,
                    0x06,
                    0x00,
                    0xA0,
                    0xC9,
                    0x03,
                    0xA3,
                    0xB8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDirectDrawGammaControl
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3E, 0x1C, 0xC1, 0x69,
                    0x6B, 0xB4,
                    0xD1, 0x11,
                    0xAD,
                    0x7A,
                    0x00,
                    0xC0,
                    0x4F,
                    0xC2,
                    0x9B,
                    0x4E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("ddraw", ExactSpelling = true)]
        public static extern HRESULT DirectDrawEnumerateW([NativeTypeName("LPDDENUMCALLBACKW")] delegate* unmanaged<Guid*, ushort*, ushort*, void*, BOOL> lpCallback, [NativeTypeName("LPVOID")] void* lpContext);

        [DllImport("ddraw", ExactSpelling = true)]
        public static extern HRESULT DirectDrawEnumerateA([NativeTypeName("LPDDENUMCALLBACKA")] delegate* unmanaged<Guid*, sbyte*, sbyte*, void*, BOOL> lpCallback, [NativeTypeName("LPVOID")] void* lpContext);

        [DllImport("ddraw", ExactSpelling = true)]
        public static extern HRESULT DirectDrawEnumerateExW([NativeTypeName("LPDDENUMCALLBACKEXW")] delegate* unmanaged<Guid*, ushort*, ushort*, void*, IntPtr, BOOL> lpCallback, [NativeTypeName("LPVOID")] void* lpContext, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("ddraw", ExactSpelling = true)]
        public static extern HRESULT DirectDrawEnumerateExA([NativeTypeName("LPDDENUMCALLBACKEXA")] delegate* unmanaged<Guid*, sbyte*, sbyte*, void*, IntPtr, BOOL> lpCallback, [NativeTypeName("LPVOID")] void* lpContext, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("ddraw", ExactSpelling = true)]
        public static extern HRESULT DirectDrawCreate([NativeTypeName("GUID *")] Guid* lpGUID, [NativeTypeName("LPDIRECTDRAW *")] IDirectDraw** lplpDD, IUnknown* pUnkOuter);

        [DllImport("ddraw", ExactSpelling = true)]
        public static extern HRESULT DirectDrawCreateEx([NativeTypeName("GUID *")] Guid* lpGuid, [NativeTypeName("LPVOID *")] void** lplpDD, [NativeTypeName("const IID &")] Guid* iid, IUnknown* pUnkOuter);

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
        public static delegate*<delegate* unmanaged<Guid*, ushort*, ushort*, void*, IntPtr, BOOL>, void*, uint, HRESULT> DirectDrawEnumerateEx => &DirectDrawEnumerateExW;

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

        [NativeTypeName("#define MAX_DDDEVICEID_STRING 512")]
        public const int MAX_DDDEVICEID_STRING = 512;

        [NativeTypeName("#define DDGDI_GETHOSTIDENTIFIER 0x00000001L")]
        public const int DDGDI_GETHOSTIDENTIFIER = 0x00000001;

        [NativeTypeName("#define DDSD_CAPS 0x00000001l")]
        public const int DDSD_CAPS = 0x00000001;

        [NativeTypeName("#define DDSD_HEIGHT 0x00000002l")]
        public const int DDSD_HEIGHT = 0x00000002;

        [NativeTypeName("#define DDSD_WIDTH 0x00000004l")]
        public const int DDSD_WIDTH = 0x00000004;

        [NativeTypeName("#define DDSD_PITCH 0x00000008l")]
        public const int DDSD_PITCH = 0x00000008;

        [NativeTypeName("#define DDSD_BACKBUFFERCOUNT 0x00000020l")]
        public const int DDSD_BACKBUFFERCOUNT = 0x00000020;

        [NativeTypeName("#define DDSD_ZBUFFERBITDEPTH 0x00000040l")]
        public const int DDSD_ZBUFFERBITDEPTH = 0x00000040;

        [NativeTypeName("#define DDSD_ALPHABITDEPTH 0x00000080l")]
        public const int DDSD_ALPHABITDEPTH = 0x00000080;

        [NativeTypeName("#define DDSD_LPSURFACE 0x00000800l")]
        public const int DDSD_LPSURFACE = 0x00000800;

        [NativeTypeName("#define DDSD_PIXELFORMAT 0x00001000l")]
        public const int DDSD_PIXELFORMAT = 0x00001000;

        [NativeTypeName("#define DDSD_CKDESTOVERLAY 0x00002000l")]
        public const int DDSD_CKDESTOVERLAY = 0x00002000;

        [NativeTypeName("#define DDSD_CKDESTBLT 0x00004000l")]
        public const int DDSD_CKDESTBLT = 0x00004000;

        [NativeTypeName("#define DDSD_CKSRCOVERLAY 0x00008000l")]
        public const int DDSD_CKSRCOVERLAY = 0x00008000;

        [NativeTypeName("#define DDSD_CKSRCBLT 0x00010000l")]
        public const int DDSD_CKSRCBLT = 0x00010000;

        [NativeTypeName("#define DDSD_MIPMAPCOUNT 0x00020000l")]
        public const int DDSD_MIPMAPCOUNT = 0x00020000;

        [NativeTypeName("#define DDSD_REFRESHRATE 0x00040000l")]
        public const int DDSD_REFRESHRATE = 0x00040000;

        [NativeTypeName("#define DDSD_LINEARSIZE 0x00080000l")]
        public const int DDSD_LINEARSIZE = 0x00080000;

        [NativeTypeName("#define DDSD_TEXTURESTAGE 0x00100000l")]
        public const int DDSD_TEXTURESTAGE = 0x00100000;

        [NativeTypeName("#define DDSD_FVF 0x00200000l")]
        public const int DDSD_FVF = 0x00200000;

        [NativeTypeName("#define DDSD_SRCVBHANDLE 0x00400000l")]
        public const int DDSD_SRCVBHANDLE = 0x00400000;

        [NativeTypeName("#define DDSD_DEPTH 0x00800000l")]
        public const int DDSD_DEPTH = 0x00800000;

        [NativeTypeName("#define DDSD_ALL 0x00fff9eel")]
        public const int DDSD_ALL = 0x00fff9ee;

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

        [NativeTypeName("#define DDSCAPS_RESERVED1 0x00000001l")]
        public const int DDSCAPS_RESERVED1 = 0x00000001;

        [NativeTypeName("#define DDSCAPS_ALPHA 0x00000002l")]
        public const int DDSCAPS_ALPHA = 0x00000002;

        [NativeTypeName("#define DDSCAPS_BACKBUFFER 0x00000004l")]
        public const int DDSCAPS_BACKBUFFER = 0x00000004;

        [NativeTypeName("#define DDSCAPS_COMPLEX 0x00000008l")]
        public const int DDSCAPS_COMPLEX = 0x00000008;

        [NativeTypeName("#define DDSCAPS_FLIP 0x00000010l")]
        public const int DDSCAPS_FLIP = 0x00000010;

        [NativeTypeName("#define DDSCAPS_FRONTBUFFER 0x00000020l")]
        public const int DDSCAPS_FRONTBUFFER = 0x00000020;

        [NativeTypeName("#define DDSCAPS_OFFSCREENPLAIN 0x00000040l")]
        public const int DDSCAPS_OFFSCREENPLAIN = 0x00000040;

        [NativeTypeName("#define DDSCAPS_OVERLAY 0x00000080l")]
        public const int DDSCAPS_OVERLAY = 0x00000080;

        [NativeTypeName("#define DDSCAPS_PALETTE 0x00000100l")]
        public const int DDSCAPS_PALETTE = 0x00000100;

        [NativeTypeName("#define DDSCAPS_PRIMARYSURFACE 0x00000200l")]
        public const int DDSCAPS_PRIMARYSURFACE = 0x00000200;

        [NativeTypeName("#define DDSCAPS_RESERVED3 0x00000400l")]
        public const int DDSCAPS_RESERVED3 = 0x00000400;

        [NativeTypeName("#define DDSCAPS_PRIMARYSURFACELEFT 0x00000000l")]
        public const int DDSCAPS_PRIMARYSURFACELEFT = 0x00000000;

        [NativeTypeName("#define DDSCAPS_SYSTEMMEMORY 0x00000800l")]
        public const int DDSCAPS_SYSTEMMEMORY = 0x00000800;

        [NativeTypeName("#define DDSCAPS_TEXTURE 0x00001000l")]
        public const int DDSCAPS_TEXTURE = 0x00001000;

        [NativeTypeName("#define DDSCAPS_3DDEVICE 0x00002000l")]
        public const int DDSCAPS_3DDEVICE = 0x00002000;

        [NativeTypeName("#define DDSCAPS_VIDEOMEMORY 0x00004000l")]
        public const int DDSCAPS_VIDEOMEMORY = 0x00004000;

        [NativeTypeName("#define DDSCAPS_VISIBLE 0x00008000l")]
        public const int DDSCAPS_VISIBLE = 0x00008000;

        [NativeTypeName("#define DDSCAPS_WRITEONLY 0x00010000l")]
        public const int DDSCAPS_WRITEONLY = 0x00010000;

        [NativeTypeName("#define DDSCAPS_ZBUFFER 0x00020000l")]
        public const int DDSCAPS_ZBUFFER = 0x00020000;

        [NativeTypeName("#define DDSCAPS_OWNDC 0x00040000l")]
        public const int DDSCAPS_OWNDC = 0x00040000;

        [NativeTypeName("#define DDSCAPS_LIVEVIDEO 0x00080000l")]
        public const int DDSCAPS_LIVEVIDEO = 0x00080000;

        [NativeTypeName("#define DDSCAPS_HWCODEC 0x00100000l")]
        public const int DDSCAPS_HWCODEC = 0x00100000;

        [NativeTypeName("#define DDSCAPS_MODEX 0x00200000l")]
        public const int DDSCAPS_MODEX = 0x00200000;

        [NativeTypeName("#define DDSCAPS_MIPMAP 0x00400000l")]
        public const int DDSCAPS_MIPMAP = 0x00400000;

        [NativeTypeName("#define DDSCAPS_RESERVED2 0x00800000l")]
        public const int DDSCAPS_RESERVED2 = 0x00800000;

        [NativeTypeName("#define DDSCAPS_ALLOCONLOAD 0x04000000l")]
        public const int DDSCAPS_ALLOCONLOAD = 0x04000000;

        [NativeTypeName("#define DDSCAPS_VIDEOPORT 0x08000000l")]
        public const int DDSCAPS_VIDEOPORT = 0x08000000;

        [NativeTypeName("#define DDSCAPS_LOCALVIDMEM 0x10000000l")]
        public const int DDSCAPS_LOCALVIDMEM = 0x10000000;

        [NativeTypeName("#define DDSCAPS_NONLOCALVIDMEM 0x20000000l")]
        public const int DDSCAPS_NONLOCALVIDMEM = 0x20000000;

        [NativeTypeName("#define DDSCAPS_STANDARDVGAMODE 0x40000000l")]
        public const int DDSCAPS_STANDARDVGAMODE = 0x40000000;

        [NativeTypeName("#define DDSCAPS_OPTIMIZED 0x80000000l")]
        public const uint DDSCAPS_OPTIMIZED = 0x80000000;

        [NativeTypeName("#define DDSCAPS2_RESERVED4 0x00000002L")]
        public const int DDSCAPS2_RESERVED4 = 0x00000002;

        [NativeTypeName("#define DDSCAPS2_HARDWAREDEINTERLACE 0x00000000L")]
        public const int DDSCAPS2_HARDWAREDEINTERLACE = 0x00000000;

        [NativeTypeName("#define DDSCAPS2_HINTDYNAMIC 0x00000004L")]
        public const int DDSCAPS2_HINTDYNAMIC = 0x00000004;

        [NativeTypeName("#define DDSCAPS2_HINTSTATIC 0x00000008L")]
        public const int DDSCAPS2_HINTSTATIC = 0x00000008;

        [NativeTypeName("#define DDSCAPS2_TEXTUREMANAGE 0x00000010L")]
        public const int DDSCAPS2_TEXTUREMANAGE = 0x00000010;

        [NativeTypeName("#define DDSCAPS2_RESERVED1 0x00000020L")]
        public const int DDSCAPS2_RESERVED1 = 0x00000020;

        [NativeTypeName("#define DDSCAPS2_RESERVED2 0x00000040L")]
        public const int DDSCAPS2_RESERVED2 = 0x00000040;

        [NativeTypeName("#define DDSCAPS2_OPAQUE 0x00000080L")]
        public const int DDSCAPS2_OPAQUE = 0x00000080;

        [NativeTypeName("#define DDSCAPS2_HINTANTIALIASING 0x00000100L")]
        public const int DDSCAPS2_HINTANTIALIASING = 0x00000100;

        [NativeTypeName("#define DDSCAPS2_CUBEMAP 0x00000200L")]
        public const int DDSCAPS2_CUBEMAP = 0x00000200;

        [NativeTypeName("#define DDSCAPS2_CUBEMAP_POSITIVEX 0x00000400L")]
        public const int DDSCAPS2_CUBEMAP_POSITIVEX = 0x00000400;

        [NativeTypeName("#define DDSCAPS2_CUBEMAP_NEGATIVEX 0x00000800L")]
        public const int DDSCAPS2_CUBEMAP_NEGATIVEX = 0x00000800;

        [NativeTypeName("#define DDSCAPS2_CUBEMAP_POSITIVEY 0x00001000L")]
        public const int DDSCAPS2_CUBEMAP_POSITIVEY = 0x00001000;

        [NativeTypeName("#define DDSCAPS2_CUBEMAP_NEGATIVEY 0x00002000L")]
        public const int DDSCAPS2_CUBEMAP_NEGATIVEY = 0x00002000;

        [NativeTypeName("#define DDSCAPS2_CUBEMAP_POSITIVEZ 0x00004000L")]
        public const int DDSCAPS2_CUBEMAP_POSITIVEZ = 0x00004000;

        [NativeTypeName("#define DDSCAPS2_CUBEMAP_NEGATIVEZ 0x00008000L")]
        public const int DDSCAPS2_CUBEMAP_NEGATIVEZ = 0x00008000;

        [NativeTypeName("#define DDSCAPS2_CUBEMAP_ALLFACES ( DDSCAPS2_CUBEMAP_POSITIVEX |\\\r\n                                    DDSCAPS2_CUBEMAP_NEGATIVEX |\\\r\n                                    DDSCAPS2_CUBEMAP_POSITIVEY |\\\r\n                                    DDSCAPS2_CUBEMAP_NEGATIVEY |\\\r\n                                    DDSCAPS2_CUBEMAP_POSITIVEZ |\\\r\n                                    DDSCAPS2_CUBEMAP_NEGATIVEZ )")]
        public const int DDSCAPS2_CUBEMAP_ALLFACES = (0x00000400 | 0x00000800 | 0x00001000 | 0x00002000 | 0x00004000 | 0x00008000);

        [NativeTypeName("#define DDSCAPS2_MIPMAPSUBLEVEL 0x00010000L")]
        public const int DDSCAPS2_MIPMAPSUBLEVEL = 0x00010000;

        [NativeTypeName("#define DDSCAPS2_D3DTEXTUREMANAGE 0x00020000L")]
        public const int DDSCAPS2_D3DTEXTUREMANAGE = 0x00020000;

        [NativeTypeName("#define DDSCAPS2_DONOTPERSIST 0x00040000L")]
        public const int DDSCAPS2_DONOTPERSIST = 0x00040000;

        [NativeTypeName("#define DDSCAPS2_STEREOSURFACELEFT 0x00080000L")]
        public const int DDSCAPS2_STEREOSURFACELEFT = 0x00080000;

        [NativeTypeName("#define DDSCAPS2_VOLUME 0x00200000L")]
        public const int DDSCAPS2_VOLUME = 0x00200000;

        [NativeTypeName("#define DDSCAPS2_NOTUSERLOCKABLE 0x00400000L")]
        public const int DDSCAPS2_NOTUSERLOCKABLE = 0x00400000;

        [NativeTypeName("#define DDSCAPS2_POINTS 0x00800000L")]
        public const int DDSCAPS2_POINTS = 0x00800000;

        [NativeTypeName("#define DDSCAPS2_RTPATCHES 0x01000000L")]
        public const int DDSCAPS2_RTPATCHES = 0x01000000;

        [NativeTypeName("#define DDSCAPS2_NPATCHES 0x02000000L")]
        public const int DDSCAPS2_NPATCHES = 0x02000000;

        [NativeTypeName("#define DDSCAPS2_RESERVED3 0x04000000L")]
        public const int DDSCAPS2_RESERVED3 = 0x04000000;

        [NativeTypeName("#define DDSCAPS2_DISCARDBACKBUFFER 0x10000000L")]
        public const int DDSCAPS2_DISCARDBACKBUFFER = 0x10000000;

        [NativeTypeName("#define DDSCAPS2_ENABLEALPHACHANNEL 0x20000000L")]
        public const int DDSCAPS2_ENABLEALPHACHANNEL = 0x20000000;

        [NativeTypeName("#define DDSCAPS2_EXTENDEDFORMATPRIMARY 0x40000000L")]
        public const int DDSCAPS2_EXTENDEDFORMATPRIMARY = 0x40000000;

        [NativeTypeName("#define DDSCAPS2_ADDITIONALPRIMARY 0x80000000L")]
        public const uint DDSCAPS2_ADDITIONALPRIMARY = 0x80000000;

        [NativeTypeName("#define DDSCAPS3_MULTISAMPLE_MASK 0x0000001FL")]
        public const int DDSCAPS3_MULTISAMPLE_MASK = 0x0000001F;

        [NativeTypeName("#define DDSCAPS3_MULTISAMPLE_QUALITY_MASK 0x000000E0L")]
        public const int DDSCAPS3_MULTISAMPLE_QUALITY_MASK = 0x000000E0;

        [NativeTypeName("#define DDSCAPS3_MULTISAMPLE_QUALITY_SHIFT 5")]
        public const int DDSCAPS3_MULTISAMPLE_QUALITY_SHIFT = 5;

        [NativeTypeName("#define DDSCAPS3_RESERVED1 0x00000100L")]
        public const int DDSCAPS3_RESERVED1 = 0x00000100;

        [NativeTypeName("#define DDSCAPS3_RESERVED2 0x00000200L")]
        public const int DDSCAPS3_RESERVED2 = 0x00000200;

        [NativeTypeName("#define DDSCAPS3_LIGHTWEIGHTMIPMAP 0x00000400L")]
        public const int DDSCAPS3_LIGHTWEIGHTMIPMAP = 0x00000400;

        [NativeTypeName("#define DDSCAPS3_AUTOGENMIPMAP 0x00000800L")]
        public const int DDSCAPS3_AUTOGENMIPMAP = 0x00000800;

        [NativeTypeName("#define DDSCAPS3_DMAP 0x00001000L")]
        public const int DDSCAPS3_DMAP = 0x00001000;

        [NativeTypeName("#define DDSCAPS3_CREATESHAREDRESOURCE 0x00002000L")]
        public const int DDSCAPS3_CREATESHAREDRESOURCE = 0x00002000;

        [NativeTypeName("#define DDSCAPS3_READONLYRESOURCE 0x00004000L")]
        public const int DDSCAPS3_READONLYRESOURCE = 0x00004000;

        [NativeTypeName("#define DDSCAPS3_OPENSHAREDRESOURCE 0x00008000L")]
        public const int DDSCAPS3_OPENSHAREDRESOURCE = 0x00008000;

        [NativeTypeName("#define DDCAPS_3D 0x00000001l")]
        public const int DDCAPS_3D = 0x00000001;

        [NativeTypeName("#define DDCAPS_ALIGNBOUNDARYDEST 0x00000002l")]
        public const int DDCAPS_ALIGNBOUNDARYDEST = 0x00000002;

        [NativeTypeName("#define DDCAPS_ALIGNSIZEDEST 0x00000004l")]
        public const int DDCAPS_ALIGNSIZEDEST = 0x00000004;

        [NativeTypeName("#define DDCAPS_ALIGNBOUNDARYSRC 0x00000008l")]
        public const int DDCAPS_ALIGNBOUNDARYSRC = 0x00000008;

        [NativeTypeName("#define DDCAPS_ALIGNSIZESRC 0x00000010l")]
        public const int DDCAPS_ALIGNSIZESRC = 0x00000010;

        [NativeTypeName("#define DDCAPS_ALIGNSTRIDE 0x00000020l")]
        public const int DDCAPS_ALIGNSTRIDE = 0x00000020;

        [NativeTypeName("#define DDCAPS_BLT 0x00000040l")]
        public const int DDCAPS_BLT = 0x00000040;

        [NativeTypeName("#define DDCAPS_BLTQUEUE 0x00000080l")]
        public const int DDCAPS_BLTQUEUE = 0x00000080;

        [NativeTypeName("#define DDCAPS_BLTFOURCC 0x00000100l")]
        public const int DDCAPS_BLTFOURCC = 0x00000100;

        [NativeTypeName("#define DDCAPS_BLTSTRETCH 0x00000200l")]
        public const int DDCAPS_BLTSTRETCH = 0x00000200;

        [NativeTypeName("#define DDCAPS_GDI 0x00000400l")]
        public const int DDCAPS_GDI = 0x00000400;

        [NativeTypeName("#define DDCAPS_OVERLAY 0x00000800l")]
        public const int DDCAPS_OVERLAY = 0x00000800;

        [NativeTypeName("#define DDCAPS_OVERLAYCANTCLIP 0x00001000l")]
        public const int DDCAPS_OVERLAYCANTCLIP = 0x00001000;

        [NativeTypeName("#define DDCAPS_OVERLAYFOURCC 0x00002000l")]
        public const int DDCAPS_OVERLAYFOURCC = 0x00002000;

        [NativeTypeName("#define DDCAPS_OVERLAYSTRETCH 0x00004000l")]
        public const int DDCAPS_OVERLAYSTRETCH = 0x00004000;

        [NativeTypeName("#define DDCAPS_PALETTE 0x00008000l")]
        public const int DDCAPS_PALETTE = 0x00008000;

        [NativeTypeName("#define DDCAPS_PALETTEVSYNC 0x00010000l")]
        public const int DDCAPS_PALETTEVSYNC = 0x00010000;

        [NativeTypeName("#define DDCAPS_READSCANLINE 0x00020000l")]
        public const int DDCAPS_READSCANLINE = 0x00020000;

        [NativeTypeName("#define DDCAPS_RESERVED1 0x00040000l")]
        public const int DDCAPS_RESERVED1 = 0x00040000;

        [NativeTypeName("#define DDCAPS_VBI 0x00080000l")]
        public const int DDCAPS_VBI = 0x00080000;

        [NativeTypeName("#define DDCAPS_ZBLTS 0x00100000l")]
        public const int DDCAPS_ZBLTS = 0x00100000;

        [NativeTypeName("#define DDCAPS_ZOVERLAYS 0x00200000l")]
        public const int DDCAPS_ZOVERLAYS = 0x00200000;

        [NativeTypeName("#define DDCAPS_COLORKEY 0x00400000l")]
        public const int DDCAPS_COLORKEY = 0x00400000;

        [NativeTypeName("#define DDCAPS_ALPHA 0x00800000l")]
        public const int DDCAPS_ALPHA = 0x00800000;

        [NativeTypeName("#define DDCAPS_COLORKEYHWASSIST 0x01000000l")]
        public const int DDCAPS_COLORKEYHWASSIST = 0x01000000;

        [NativeTypeName("#define DDCAPS_NOHARDWARE 0x02000000l")]
        public const int DDCAPS_NOHARDWARE = 0x02000000;

        [NativeTypeName("#define DDCAPS_BLTCOLORFILL 0x04000000l")]
        public const int DDCAPS_BLTCOLORFILL = 0x04000000;

        [NativeTypeName("#define DDCAPS_BANKSWITCHED 0x08000000l")]
        public const int DDCAPS_BANKSWITCHED = 0x08000000;

        [NativeTypeName("#define DDCAPS_BLTDEPTHFILL 0x10000000l")]
        public const int DDCAPS_BLTDEPTHFILL = 0x10000000;

        [NativeTypeName("#define DDCAPS_CANCLIP 0x20000000l")]
        public const int DDCAPS_CANCLIP = 0x20000000;

        [NativeTypeName("#define DDCAPS_CANCLIPSTRETCHED 0x40000000l")]
        public const int DDCAPS_CANCLIPSTRETCHED = 0x40000000;

        [NativeTypeName("#define DDCAPS_CANBLTSYSMEM 0x80000000l")]
        public const uint DDCAPS_CANBLTSYSMEM = 0x80000000;

        [NativeTypeName("#define DDCAPS2_CERTIFIED 0x00000001l")]
        public const int DDCAPS2_CERTIFIED = 0x00000001;

        [NativeTypeName("#define DDCAPS2_NO2DDURING3DSCENE 0x00000002l")]
        public const int DDCAPS2_NO2DDURING3DSCENE = 0x00000002;

        [NativeTypeName("#define DDCAPS2_VIDEOPORT 0x00000004l")]
        public const int DDCAPS2_VIDEOPORT = 0x00000004;

        [NativeTypeName("#define DDCAPS2_AUTOFLIPOVERLAY 0x00000008l")]
        public const int DDCAPS2_AUTOFLIPOVERLAY = 0x00000008;

        [NativeTypeName("#define DDCAPS2_CANBOBINTERLEAVED 0x00000010l")]
        public const int DDCAPS2_CANBOBINTERLEAVED = 0x00000010;

        [NativeTypeName("#define DDCAPS2_CANBOBNONINTERLEAVED 0x00000020l")]
        public const int DDCAPS2_CANBOBNONINTERLEAVED = 0x00000020;

        [NativeTypeName("#define DDCAPS2_COLORCONTROLOVERLAY 0x00000040l")]
        public const int DDCAPS2_COLORCONTROLOVERLAY = 0x00000040;

        [NativeTypeName("#define DDCAPS2_COLORCONTROLPRIMARY 0x00000080l")]
        public const int DDCAPS2_COLORCONTROLPRIMARY = 0x00000080;

        [NativeTypeName("#define DDCAPS2_CANDROPZ16BIT 0x00000100l")]
        public const int DDCAPS2_CANDROPZ16BIT = 0x00000100;

        [NativeTypeName("#define DDCAPS2_NONLOCALVIDMEM 0x00000200l")]
        public const int DDCAPS2_NONLOCALVIDMEM = 0x00000200;

        [NativeTypeName("#define DDCAPS2_NONLOCALVIDMEMCAPS 0x00000400l")]
        public const int DDCAPS2_NONLOCALVIDMEMCAPS = 0x00000400;

        [NativeTypeName("#define DDCAPS2_NOPAGELOCKREQUIRED 0x00000800l")]
        public const int DDCAPS2_NOPAGELOCKREQUIRED = 0x00000800;

        [NativeTypeName("#define DDCAPS2_WIDESURFACES 0x00001000l")]
        public const int DDCAPS2_WIDESURFACES = 0x00001000;

        [NativeTypeName("#define DDCAPS2_CANFLIPODDEVEN 0x00002000l")]
        public const int DDCAPS2_CANFLIPODDEVEN = 0x00002000;

        [NativeTypeName("#define DDCAPS2_CANBOBHARDWARE 0x00004000l")]
        public const int DDCAPS2_CANBOBHARDWARE = 0x00004000;

        [NativeTypeName("#define DDCAPS2_COPYFOURCC 0x00008000l")]
        public const int DDCAPS2_COPYFOURCC = 0x00008000;

        [NativeTypeName("#define DDCAPS2_PRIMARYGAMMA 0x00020000l")]
        public const int DDCAPS2_PRIMARYGAMMA = 0x00020000;

        [NativeTypeName("#define DDCAPS2_CANRENDERWINDOWED 0x00080000l")]
        public const int DDCAPS2_CANRENDERWINDOWED = 0x00080000;

        [NativeTypeName("#define DDCAPS2_CANCALIBRATEGAMMA 0x00100000l")]
        public const int DDCAPS2_CANCALIBRATEGAMMA = 0x00100000;

        [NativeTypeName("#define DDCAPS2_FLIPINTERVAL 0x00200000l")]
        public const int DDCAPS2_FLIPINTERVAL = 0x00200000;

        [NativeTypeName("#define DDCAPS2_FLIPNOVSYNC 0x00400000l")]
        public const int DDCAPS2_FLIPNOVSYNC = 0x00400000;

        [NativeTypeName("#define DDCAPS2_CANMANAGETEXTURE 0x00800000l")]
        public const int DDCAPS2_CANMANAGETEXTURE = 0x00800000;

        [NativeTypeName("#define DDCAPS2_TEXMANINNONLOCALVIDMEM 0x01000000l")]
        public const int DDCAPS2_TEXMANINNONLOCALVIDMEM = 0x01000000;

        [NativeTypeName("#define DDCAPS2_STEREO 0x02000000L")]
        public const int DDCAPS2_STEREO = 0x02000000;

        [NativeTypeName("#define DDCAPS2_SYSTONONLOCAL_AS_SYSTOLOCAL 0x04000000L")]
        public const int DDCAPS2_SYSTONONLOCAL_AS_SYSTOLOCAL = 0x04000000;

        [NativeTypeName("#define DDCAPS2_RESERVED1 0x08000000L")]
        public const int DDCAPS2_RESERVED1 = 0x08000000;

        [NativeTypeName("#define DDCAPS2_CANMANAGERESOURCE 0x10000000L")]
        public const int DDCAPS2_CANMANAGERESOURCE = 0x10000000;

        [NativeTypeName("#define DDCAPS2_DYNAMICTEXTURES 0x20000000L")]
        public const int DDCAPS2_DYNAMICTEXTURES = 0x20000000;

        [NativeTypeName("#define DDCAPS2_CANAUTOGENMIPMAP 0x40000000L")]
        public const int DDCAPS2_CANAUTOGENMIPMAP = 0x40000000;

        [NativeTypeName("#define DDCAPS2_CANSHARERESOURCE 0x80000000L")]
        public const uint DDCAPS2_CANSHARERESOURCE = 0x80000000;

        [NativeTypeName("#define DDFXALPHACAPS_BLTALPHAEDGEBLEND 0x00000001l")]
        public const int DDFXALPHACAPS_BLTALPHAEDGEBLEND = 0x00000001;

        [NativeTypeName("#define DDFXALPHACAPS_BLTALPHAPIXELS 0x00000002l")]
        public const int DDFXALPHACAPS_BLTALPHAPIXELS = 0x00000002;

        [NativeTypeName("#define DDFXALPHACAPS_BLTALPHAPIXELSNEG 0x00000004l")]
        public const int DDFXALPHACAPS_BLTALPHAPIXELSNEG = 0x00000004;

        [NativeTypeName("#define DDFXALPHACAPS_BLTALPHASURFACES 0x00000008l")]
        public const int DDFXALPHACAPS_BLTALPHASURFACES = 0x00000008;

        [NativeTypeName("#define DDFXALPHACAPS_BLTALPHASURFACESNEG 0x00000010l")]
        public const int DDFXALPHACAPS_BLTALPHASURFACESNEG = 0x00000010;

        [NativeTypeName("#define DDFXALPHACAPS_OVERLAYALPHAEDGEBLEND 0x00000020l")]
        public const int DDFXALPHACAPS_OVERLAYALPHAEDGEBLEND = 0x00000020;

        [NativeTypeName("#define DDFXALPHACAPS_OVERLAYALPHAPIXELS 0x00000040l")]
        public const int DDFXALPHACAPS_OVERLAYALPHAPIXELS = 0x00000040;

        [NativeTypeName("#define DDFXALPHACAPS_OVERLAYALPHAPIXELSNEG 0x00000080l")]
        public const int DDFXALPHACAPS_OVERLAYALPHAPIXELSNEG = 0x00000080;

        [NativeTypeName("#define DDFXALPHACAPS_OVERLAYALPHASURFACES 0x00000100l")]
        public const int DDFXALPHACAPS_OVERLAYALPHASURFACES = 0x00000100;

        [NativeTypeName("#define DDFXALPHACAPS_OVERLAYALPHASURFACESNEG 0x00000200l")]
        public const int DDFXALPHACAPS_OVERLAYALPHASURFACESNEG = 0x00000200;

        [NativeTypeName("#define DDFXCAPS_BLTARITHSTRETCHY 0x00000020l")]
        public const int DDFXCAPS_BLTARITHSTRETCHY = 0x00000020;

        [NativeTypeName("#define DDFXCAPS_BLTARITHSTRETCHYN 0x00000010l")]
        public const int DDFXCAPS_BLTARITHSTRETCHYN = 0x00000010;

        [NativeTypeName("#define DDFXCAPS_BLTMIRRORLEFTRIGHT 0x00000040l")]
        public const int DDFXCAPS_BLTMIRRORLEFTRIGHT = 0x00000040;

        [NativeTypeName("#define DDFXCAPS_BLTMIRRORUPDOWN 0x00000080l")]
        public const int DDFXCAPS_BLTMIRRORUPDOWN = 0x00000080;

        [NativeTypeName("#define DDFXCAPS_BLTROTATION 0x00000100l")]
        public const int DDFXCAPS_BLTROTATION = 0x00000100;

        [NativeTypeName("#define DDFXCAPS_BLTROTATION90 0x00000200l")]
        public const int DDFXCAPS_BLTROTATION90 = 0x00000200;

        [NativeTypeName("#define DDFXCAPS_BLTSHRINKX 0x00000400l")]
        public const int DDFXCAPS_BLTSHRINKX = 0x00000400;

        [NativeTypeName("#define DDFXCAPS_BLTSHRINKXN 0x00000800l")]
        public const int DDFXCAPS_BLTSHRINKXN = 0x00000800;

        [NativeTypeName("#define DDFXCAPS_BLTSHRINKY 0x00001000l")]
        public const int DDFXCAPS_BLTSHRINKY = 0x00001000;

        [NativeTypeName("#define DDFXCAPS_BLTSHRINKYN 0x00002000l")]
        public const int DDFXCAPS_BLTSHRINKYN = 0x00002000;

        [NativeTypeName("#define DDFXCAPS_BLTSTRETCHX 0x00004000l")]
        public const int DDFXCAPS_BLTSTRETCHX = 0x00004000;

        [NativeTypeName("#define DDFXCAPS_BLTSTRETCHXN 0x00008000l")]
        public const int DDFXCAPS_BLTSTRETCHXN = 0x00008000;

        [NativeTypeName("#define DDFXCAPS_BLTSTRETCHY 0x00010000l")]
        public const int DDFXCAPS_BLTSTRETCHY = 0x00010000;

        [NativeTypeName("#define DDFXCAPS_BLTSTRETCHYN 0x00020000l")]
        public const int DDFXCAPS_BLTSTRETCHYN = 0x00020000;

        [NativeTypeName("#define DDFXCAPS_OVERLAYARITHSTRETCHY 0x00040000l")]
        public const int DDFXCAPS_OVERLAYARITHSTRETCHY = 0x00040000;

        [NativeTypeName("#define DDFXCAPS_OVERLAYARITHSTRETCHYN 0x00000008l")]
        public const int DDFXCAPS_OVERLAYARITHSTRETCHYN = 0x00000008;

        [NativeTypeName("#define DDFXCAPS_OVERLAYSHRINKX 0x00080000l")]
        public const int DDFXCAPS_OVERLAYSHRINKX = 0x00080000;

        [NativeTypeName("#define DDFXCAPS_OVERLAYSHRINKXN 0x00100000l")]
        public const int DDFXCAPS_OVERLAYSHRINKXN = 0x00100000;

        [NativeTypeName("#define DDFXCAPS_OVERLAYSHRINKY 0x00200000l")]
        public const int DDFXCAPS_OVERLAYSHRINKY = 0x00200000;

        [NativeTypeName("#define DDFXCAPS_OVERLAYSHRINKYN 0x00400000l")]
        public const int DDFXCAPS_OVERLAYSHRINKYN = 0x00400000;

        [NativeTypeName("#define DDFXCAPS_OVERLAYSTRETCHX 0x00800000l")]
        public const int DDFXCAPS_OVERLAYSTRETCHX = 0x00800000;

        [NativeTypeName("#define DDFXCAPS_OVERLAYSTRETCHXN 0x01000000l")]
        public const int DDFXCAPS_OVERLAYSTRETCHXN = 0x01000000;

        [NativeTypeName("#define DDFXCAPS_OVERLAYSTRETCHY 0x02000000l")]
        public const int DDFXCAPS_OVERLAYSTRETCHY = 0x02000000;

        [NativeTypeName("#define DDFXCAPS_OVERLAYSTRETCHYN 0x04000000l")]
        public const int DDFXCAPS_OVERLAYSTRETCHYN = 0x04000000;

        [NativeTypeName("#define DDFXCAPS_OVERLAYMIRRORLEFTRIGHT 0x08000000l")]
        public const int DDFXCAPS_OVERLAYMIRRORLEFTRIGHT = 0x08000000;

        [NativeTypeName("#define DDFXCAPS_OVERLAYMIRRORUPDOWN 0x10000000l")]
        public const int DDFXCAPS_OVERLAYMIRRORUPDOWN = 0x10000000;

        [NativeTypeName("#define DDFXCAPS_OVERLAYDEINTERLACE 0x20000000l")]
        public const int DDFXCAPS_OVERLAYDEINTERLACE = 0x20000000;

        [NativeTypeName("#define DDFXCAPS_BLTALPHA 0x00000001l")]
        public const int DDFXCAPS_BLTALPHA = 0x00000001;

        [NativeTypeName("#define DDFXCAPS_BLTFILTER DDFXCAPS_BLTARITHSTRETCHY")]
        public const int DDFXCAPS_BLTFILTER = 0x00000020;

        [NativeTypeName("#define DDFXCAPS_OVERLAYALPHA 0x00000004l")]
        public const int DDFXCAPS_OVERLAYALPHA = 0x00000004;

        [NativeTypeName("#define DDFXCAPS_OVERLAYFILTER DDFXCAPS_OVERLAYARITHSTRETCHY")]
        public const int DDFXCAPS_OVERLAYFILTER = 0x00040000;

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

        [NativeTypeName("#define DDPCAPS_4BIT 0x00000001l")]
        public const int DDPCAPS_4BIT = 0x00000001;

        [NativeTypeName("#define DDPCAPS_8BITENTRIES 0x00000002l")]
        public const int DDPCAPS_8BITENTRIES = 0x00000002;

        [NativeTypeName("#define DDPCAPS_8BIT 0x00000004l")]
        public const int DDPCAPS_8BIT = 0x00000004;

        [NativeTypeName("#define DDPCAPS_INITIALIZE 0x00000000l")]
        public const int DDPCAPS_INITIALIZE = 0x00000000;

        [NativeTypeName("#define DDPCAPS_PRIMARYSURFACE 0x00000010l")]
        public const int DDPCAPS_PRIMARYSURFACE = 0x00000010;

        [NativeTypeName("#define DDPCAPS_PRIMARYSURFACELEFT 0x00000020l")]
        public const int DDPCAPS_PRIMARYSURFACELEFT = 0x00000020;

        [NativeTypeName("#define DDPCAPS_ALLOW256 0x00000040l")]
        public const int DDPCAPS_ALLOW256 = 0x00000040;

        [NativeTypeName("#define DDPCAPS_VSYNC 0x00000080l")]
        public const int DDPCAPS_VSYNC = 0x00000080;

        [NativeTypeName("#define DDPCAPS_1BIT 0x00000100l")]
        public const int DDPCAPS_1BIT = 0x00000100;

        [NativeTypeName("#define DDPCAPS_2BIT 0x00000200l")]
        public const int DDPCAPS_2BIT = 0x00000200;

        [NativeTypeName("#define DDPCAPS_ALPHA 0x00000400l")]
        public const int DDPCAPS_ALPHA = 0x00000400;

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

        [NativeTypeName("#define DDCKEYCAPS_DESTBLT 0x00000001l")]
        public const int DDCKEYCAPS_DESTBLT = 0x00000001;

        [NativeTypeName("#define DDCKEYCAPS_DESTBLTCLRSPACE 0x00000002l")]
        public const int DDCKEYCAPS_DESTBLTCLRSPACE = 0x00000002;

        [NativeTypeName("#define DDCKEYCAPS_DESTBLTCLRSPACEYUV 0x00000004l")]
        public const int DDCKEYCAPS_DESTBLTCLRSPACEYUV = 0x00000004;

        [NativeTypeName("#define DDCKEYCAPS_DESTBLTYUV 0x00000008l")]
        public const int DDCKEYCAPS_DESTBLTYUV = 0x00000008;

        [NativeTypeName("#define DDCKEYCAPS_DESTOVERLAY 0x00000010l")]
        public const int DDCKEYCAPS_DESTOVERLAY = 0x00000010;

        [NativeTypeName("#define DDCKEYCAPS_DESTOVERLAYCLRSPACE 0x00000020l")]
        public const int DDCKEYCAPS_DESTOVERLAYCLRSPACE = 0x00000020;

        [NativeTypeName("#define DDCKEYCAPS_DESTOVERLAYCLRSPACEYUV 0x00000040l")]
        public const int DDCKEYCAPS_DESTOVERLAYCLRSPACEYUV = 0x00000040;

        [NativeTypeName("#define DDCKEYCAPS_DESTOVERLAYONEACTIVE 0x00000080l")]
        public const int DDCKEYCAPS_DESTOVERLAYONEACTIVE = 0x00000080;

        [NativeTypeName("#define DDCKEYCAPS_DESTOVERLAYYUV 0x00000100l")]
        public const int DDCKEYCAPS_DESTOVERLAYYUV = 0x00000100;

        [NativeTypeName("#define DDCKEYCAPS_SRCBLT 0x00000200l")]
        public const int DDCKEYCAPS_SRCBLT = 0x00000200;

        [NativeTypeName("#define DDCKEYCAPS_SRCBLTCLRSPACE 0x00000400l")]
        public const int DDCKEYCAPS_SRCBLTCLRSPACE = 0x00000400;

        [NativeTypeName("#define DDCKEYCAPS_SRCBLTCLRSPACEYUV 0x00000800l")]
        public const int DDCKEYCAPS_SRCBLTCLRSPACEYUV = 0x00000800;

        [NativeTypeName("#define DDCKEYCAPS_SRCBLTYUV 0x00001000l")]
        public const int DDCKEYCAPS_SRCBLTYUV = 0x00001000;

        [NativeTypeName("#define DDCKEYCAPS_SRCOVERLAY 0x00002000l")]
        public const int DDCKEYCAPS_SRCOVERLAY = 0x00002000;

        [NativeTypeName("#define DDCKEYCAPS_SRCOVERLAYCLRSPACE 0x00004000l")]
        public const int DDCKEYCAPS_SRCOVERLAYCLRSPACE = 0x00004000;

        [NativeTypeName("#define DDCKEYCAPS_SRCOVERLAYCLRSPACEYUV 0x00008000l")]
        public const int DDCKEYCAPS_SRCOVERLAYCLRSPACEYUV = 0x00008000;

        [NativeTypeName("#define DDCKEYCAPS_SRCOVERLAYONEACTIVE 0x00010000l")]
        public const int DDCKEYCAPS_SRCOVERLAYONEACTIVE = 0x00010000;

        [NativeTypeName("#define DDCKEYCAPS_SRCOVERLAYYUV 0x00020000l")]
        public const int DDCKEYCAPS_SRCOVERLAYYUV = 0x00020000;

        [NativeTypeName("#define DDCKEYCAPS_NOCOSTOVERLAY 0x00040000l")]
        public const int DDCKEYCAPS_NOCOSTOVERLAY = 0x00040000;

        [NativeTypeName("#define DDPF_ALPHAPIXELS 0x00000001l")]
        public const int DDPF_ALPHAPIXELS = 0x00000001;

        [NativeTypeName("#define DDPF_ALPHA 0x00000002l")]
        public const int DDPF_ALPHA = 0x00000002;

        [NativeTypeName("#define DDPF_FOURCC 0x00000004l")]
        public const int DDPF_FOURCC = 0x00000004;

        [NativeTypeName("#define DDPF_PALETTEINDEXED4 0x00000008l")]
        public const int DDPF_PALETTEINDEXED4 = 0x00000008;

        [NativeTypeName("#define DDPF_PALETTEINDEXEDTO8 0x00000010l")]
        public const int DDPF_PALETTEINDEXEDTO8 = 0x00000010;

        [NativeTypeName("#define DDPF_PALETTEINDEXED8 0x00000020l")]
        public const int DDPF_PALETTEINDEXED8 = 0x00000020;

        [NativeTypeName("#define DDPF_RGB 0x00000040l")]
        public const int DDPF_RGB = 0x00000040;

        [NativeTypeName("#define DDPF_COMPRESSED 0x00000080l")]
        public const int DDPF_COMPRESSED = 0x00000080;

        [NativeTypeName("#define DDPF_RGBTOYUV 0x00000100l")]
        public const int DDPF_RGBTOYUV = 0x00000100;

        [NativeTypeName("#define DDPF_YUV 0x00000200l")]
        public const int DDPF_YUV = 0x00000200;

        [NativeTypeName("#define DDPF_ZBUFFER 0x00000400l")]
        public const int DDPF_ZBUFFER = 0x00000400;

        [NativeTypeName("#define DDPF_PALETTEINDEXED1 0x00000800l")]
        public const int DDPF_PALETTEINDEXED1 = 0x00000800;

        [NativeTypeName("#define DDPF_PALETTEINDEXED2 0x00001000l")]
        public const int DDPF_PALETTEINDEXED2 = 0x00001000;

        [NativeTypeName("#define DDPF_ZPIXELS 0x00002000l")]
        public const int DDPF_ZPIXELS = 0x00002000;

        [NativeTypeName("#define DDPF_STENCILBUFFER 0x00004000l")]
        public const int DDPF_STENCILBUFFER = 0x00004000;

        [NativeTypeName("#define DDPF_ALPHAPREMULT 0x00008000l")]
        public const int DDPF_ALPHAPREMULT = 0x00008000;

        [NativeTypeName("#define DDPF_LUMINANCE 0x00020000l")]
        public const int DDPF_LUMINANCE = 0x00020000;

        [NativeTypeName("#define DDPF_BUMPLUMINANCE 0x00040000l")]
        public const int DDPF_BUMPLUMINANCE = 0x00040000;

        [NativeTypeName("#define DDPF_BUMPDUDV 0x00080000l")]
        public const int DDPF_BUMPDUDV = 0x00080000;

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

        [NativeTypeName("#define DDSCL_FULLSCREEN 0x00000001l")]
        public const int DDSCL_FULLSCREEN = 0x00000001;

        [NativeTypeName("#define DDSCL_ALLOWREBOOT 0x00000002l")]
        public const int DDSCL_ALLOWREBOOT = 0x00000002;

        [NativeTypeName("#define DDSCL_NOWINDOWCHANGES 0x00000004l")]
        public const int DDSCL_NOWINDOWCHANGES = 0x00000004;

        [NativeTypeName("#define DDSCL_NORMAL 0x00000008l")]
        public const int DDSCL_NORMAL = 0x00000008;

        [NativeTypeName("#define DDSCL_EXCLUSIVE 0x00000010l")]
        public const int DDSCL_EXCLUSIVE = 0x00000010;

        [NativeTypeName("#define DDSCL_ALLOWMODEX 0x00000040l")]
        public const int DDSCL_ALLOWMODEX = 0x00000040;

        [NativeTypeName("#define DDSCL_SETFOCUSWINDOW 0x00000080l")]
        public const int DDSCL_SETFOCUSWINDOW = 0x00000080;

        [NativeTypeName("#define DDSCL_SETDEVICEWINDOW 0x00000100l")]
        public const int DDSCL_SETDEVICEWINDOW = 0x00000100;

        [NativeTypeName("#define DDSCL_CREATEDEVICEWINDOW 0x00000200l")]
        public const int DDSCL_CREATEDEVICEWINDOW = 0x00000200;

        [NativeTypeName("#define DDSCL_MULTITHREADED 0x00000400l")]
        public const int DDSCL_MULTITHREADED = 0x00000400;

        [NativeTypeName("#define DDSCL_FPUSETUP 0x00000800l")]
        public const int DDSCL_FPUSETUP = 0x00000800;

        [NativeTypeName("#define DDSCL_FPUPRESERVE 0x00001000l")]
        public const int DDSCL_FPUPRESERVE = 0x00001000;

        [NativeTypeName("#define DDBLT_ALPHADEST 0x00000001l")]
        public const int DDBLT_ALPHADEST = 0x00000001;

        [NativeTypeName("#define DDBLT_ALPHADESTCONSTOVERRIDE 0x00000002l")]
        public const int DDBLT_ALPHADESTCONSTOVERRIDE = 0x00000002;

        [NativeTypeName("#define DDBLT_ALPHADESTNEG 0x00000004l")]
        public const int DDBLT_ALPHADESTNEG = 0x00000004;

        [NativeTypeName("#define DDBLT_ALPHADESTSURFACEOVERRIDE 0x00000008l")]
        public const int DDBLT_ALPHADESTSURFACEOVERRIDE = 0x00000008;

        [NativeTypeName("#define DDBLT_ALPHAEDGEBLEND 0x00000010l")]
        public const int DDBLT_ALPHAEDGEBLEND = 0x00000010;

        [NativeTypeName("#define DDBLT_ALPHASRC 0x00000020l")]
        public const int DDBLT_ALPHASRC = 0x00000020;

        [NativeTypeName("#define DDBLT_ALPHASRCCONSTOVERRIDE 0x00000040l")]
        public const int DDBLT_ALPHASRCCONSTOVERRIDE = 0x00000040;

        [NativeTypeName("#define DDBLT_ALPHASRCNEG 0x00000080l")]
        public const int DDBLT_ALPHASRCNEG = 0x00000080;

        [NativeTypeName("#define DDBLT_ALPHASRCSURFACEOVERRIDE 0x00000100l")]
        public const int DDBLT_ALPHASRCSURFACEOVERRIDE = 0x00000100;

        [NativeTypeName("#define DDBLT_ASYNC 0x00000200l")]
        public const int DDBLT_ASYNC = 0x00000200;

        [NativeTypeName("#define DDBLT_COLORFILL 0x00000400l")]
        public const int DDBLT_COLORFILL = 0x00000400;

        [NativeTypeName("#define DDBLT_DDFX 0x00000800l")]
        public const int DDBLT_DDFX = 0x00000800;

        [NativeTypeName("#define DDBLT_DDROPS 0x00001000l")]
        public const int DDBLT_DDROPS = 0x00001000;

        [NativeTypeName("#define DDBLT_KEYDEST 0x00002000l")]
        public const int DDBLT_KEYDEST = 0x00002000;

        [NativeTypeName("#define DDBLT_KEYDESTOVERRIDE 0x00004000l")]
        public const int DDBLT_KEYDESTOVERRIDE = 0x00004000;

        [NativeTypeName("#define DDBLT_KEYSRC 0x00008000l")]
        public const int DDBLT_KEYSRC = 0x00008000;

        [NativeTypeName("#define DDBLT_KEYSRCOVERRIDE 0x00010000l")]
        public const int DDBLT_KEYSRCOVERRIDE = 0x00010000;

        [NativeTypeName("#define DDBLT_ROP 0x00020000l")]
        public const int DDBLT_ROP = 0x00020000;

        [NativeTypeName("#define DDBLT_ROTATIONANGLE 0x00040000l")]
        public const int DDBLT_ROTATIONANGLE = 0x00040000;

        [NativeTypeName("#define DDBLT_ZBUFFER 0x00080000l")]
        public const int DDBLT_ZBUFFER = 0x00080000;

        [NativeTypeName("#define DDBLT_ZBUFFERDESTCONSTOVERRIDE 0x00100000l")]
        public const int DDBLT_ZBUFFERDESTCONSTOVERRIDE = 0x00100000;

        [NativeTypeName("#define DDBLT_ZBUFFERDESTOVERRIDE 0x00200000l")]
        public const int DDBLT_ZBUFFERDESTOVERRIDE = 0x00200000;

        [NativeTypeName("#define DDBLT_ZBUFFERSRCCONSTOVERRIDE 0x00400000l")]
        public const int DDBLT_ZBUFFERSRCCONSTOVERRIDE = 0x00400000;

        [NativeTypeName("#define DDBLT_ZBUFFERSRCOVERRIDE 0x00800000l")]
        public const int DDBLT_ZBUFFERSRCOVERRIDE = 0x00800000;

        [NativeTypeName("#define DDBLT_WAIT 0x01000000l")]
        public const int DDBLT_WAIT = 0x01000000;

        [NativeTypeName("#define DDBLT_DEPTHFILL 0x02000000l")]
        public const int DDBLT_DEPTHFILL = 0x02000000;

        [NativeTypeName("#define DDBLT_DONOTWAIT 0x08000000l")]
        public const int DDBLT_DONOTWAIT = 0x08000000;

        [NativeTypeName("#define DDBLT_PRESENTATION 0x10000000l")]
        public const int DDBLT_PRESENTATION = 0x10000000;

        [NativeTypeName("#define DDBLT_LAST_PRESENTATION 0x20000000l")]
        public const int DDBLT_LAST_PRESENTATION = 0x20000000;

        [NativeTypeName("#define DDBLT_EXTENDED_FLAGS 0x40000000l")]
        public const int DDBLT_EXTENDED_FLAGS = 0x40000000;

        [NativeTypeName("#define DDBLT_EXTENDED_LINEAR_CONTENT 0x00000004l")]
        public const int DDBLT_EXTENDED_LINEAR_CONTENT = 0x00000004;

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

        [NativeTypeName("#define DDOVER_ALPHADEST 0x00000001l")]
        public const int DDOVER_ALPHADEST = 0x00000001;

        [NativeTypeName("#define DDOVER_ALPHADESTCONSTOVERRIDE 0x00000002l")]
        public const int DDOVER_ALPHADESTCONSTOVERRIDE = 0x00000002;

        [NativeTypeName("#define DDOVER_ALPHADESTNEG 0x00000004l")]
        public const int DDOVER_ALPHADESTNEG = 0x00000004;

        [NativeTypeName("#define DDOVER_ALPHADESTSURFACEOVERRIDE 0x00000008l")]
        public const int DDOVER_ALPHADESTSURFACEOVERRIDE = 0x00000008;

        [NativeTypeName("#define DDOVER_ALPHAEDGEBLEND 0x00000010l")]
        public const int DDOVER_ALPHAEDGEBLEND = 0x00000010;

        [NativeTypeName("#define DDOVER_ALPHASRC 0x00000020l")]
        public const int DDOVER_ALPHASRC = 0x00000020;

        [NativeTypeName("#define DDOVER_ALPHASRCCONSTOVERRIDE 0x00000040l")]
        public const int DDOVER_ALPHASRCCONSTOVERRIDE = 0x00000040;

        [NativeTypeName("#define DDOVER_ALPHASRCNEG 0x00000080l")]
        public const int DDOVER_ALPHASRCNEG = 0x00000080;

        [NativeTypeName("#define DDOVER_ALPHASRCSURFACEOVERRIDE 0x00000100l")]
        public const int DDOVER_ALPHASRCSURFACEOVERRIDE = 0x00000100;

        [NativeTypeName("#define DDOVER_HIDE 0x00000200l")]
        public const int DDOVER_HIDE = 0x00000200;

        [NativeTypeName("#define DDOVER_KEYDEST 0x00000400l")]
        public const int DDOVER_KEYDEST = 0x00000400;

        [NativeTypeName("#define DDOVER_KEYDESTOVERRIDE 0x00000800l")]
        public const int DDOVER_KEYDESTOVERRIDE = 0x00000800;

        [NativeTypeName("#define DDOVER_KEYSRC 0x00001000l")]
        public const int DDOVER_KEYSRC = 0x00001000;

        [NativeTypeName("#define DDOVER_KEYSRCOVERRIDE 0x00002000l")]
        public const int DDOVER_KEYSRCOVERRIDE = 0x00002000;

        [NativeTypeName("#define DDOVER_SHOW 0x00004000l")]
        public const int DDOVER_SHOW = 0x00004000;

        [NativeTypeName("#define DDOVER_ADDDIRTYRECT 0x00008000l")]
        public const int DDOVER_ADDDIRTYRECT = 0x00008000;

        [NativeTypeName("#define DDOVER_REFRESHDIRTYRECTS 0x00010000l")]
        public const int DDOVER_REFRESHDIRTYRECTS = 0x00010000;

        [NativeTypeName("#define DDOVER_REFRESHALL 0x00020000l")]
        public const int DDOVER_REFRESHALL = 0x00020000;

        [NativeTypeName("#define DDOVER_DDFX 0x00080000l")]
        public const int DDOVER_DDFX = 0x00080000;

        [NativeTypeName("#define DDOVER_AUTOFLIP 0x00100000l")]
        public const int DDOVER_AUTOFLIP = 0x00100000;

        [NativeTypeName("#define DDOVER_BOB 0x00200000l")]
        public const int DDOVER_BOB = 0x00200000;

        [NativeTypeName("#define DDOVER_OVERRIDEBOBWEAVE 0x00400000l")]
        public const int DDOVER_OVERRIDEBOBWEAVE = 0x00400000;

        [NativeTypeName("#define DDOVER_INTERLEAVED 0x00800000l")]
        public const int DDOVER_INTERLEAVED = 0x00800000;

        [NativeTypeName("#define DDOVER_BOBHARDWARE 0x01000000l")]
        public const int DDOVER_BOBHARDWARE = 0x01000000;

        [NativeTypeName("#define DDOVER_ARGBSCALEFACTORS 0x02000000l")]
        public const int DDOVER_ARGBSCALEFACTORS = 0x02000000;

        [NativeTypeName("#define DDOVER_DEGRADEARGBSCALING 0x04000000l")]
        public const int DDOVER_DEGRADEARGBSCALING = 0x04000000;

        [NativeTypeName("#define DDLOCK_SURFACEMEMORYPTR 0x00000000L")]
        public const int DDLOCK_SURFACEMEMORYPTR = 0x00000000;

        [NativeTypeName("#define DDLOCK_WAIT 0x00000001L")]
        public const int DDLOCK_WAIT = 0x00000001;

        [NativeTypeName("#define DDLOCK_EVENT 0x00000002L")]
        public const int DDLOCK_EVENT = 0x00000002;

        [NativeTypeName("#define DDLOCK_READONLY 0x00000010L")]
        public const int DDLOCK_READONLY = 0x00000010;

        [NativeTypeName("#define DDLOCK_WRITEONLY 0x00000020L")]
        public const int DDLOCK_WRITEONLY = 0x00000020;

        [NativeTypeName("#define DDLOCK_NOSYSLOCK 0x00000800L")]
        public const int DDLOCK_NOSYSLOCK = 0x00000800;

        [NativeTypeName("#define DDLOCK_NOOVERWRITE 0x00001000L")]
        public const int DDLOCK_NOOVERWRITE = 0x00001000;

        [NativeTypeName("#define DDLOCK_DISCARDCONTENTS 0x00002000L")]
        public const int DDLOCK_DISCARDCONTENTS = 0x00002000;

        [NativeTypeName("#define DDLOCK_OKTOSWAP 0x00002000L")]
        public const int DDLOCK_OKTOSWAP = 0x00002000;

        [NativeTypeName("#define DDLOCK_DONOTWAIT 0x00004000L")]
        public const int DDLOCK_DONOTWAIT = 0x00004000;

        [NativeTypeName("#define DDLOCK_HASVOLUMETEXTUREBOXRECT 0x00008000L")]
        public const int DDLOCK_HASVOLUMETEXTUREBOXRECT = 0x00008000;

        [NativeTypeName("#define DDLOCK_NODIRTYUPDATE 0x00010000L")]
        public const int DDLOCK_NODIRTYUPDATE = 0x00010000;

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

        [NativeTypeName("#define DDERR_ALREADYINITIALIZED MAKE_DDHRESULT( 5 )")]
        public const int DDERR_ALREADYINITIALIZED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(5))));

        [NativeTypeName("#define DDERR_CANNOTATTACHSURFACE MAKE_DDHRESULT( 10 )")]
        public const int DDERR_CANNOTATTACHSURFACE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(10))));

        [NativeTypeName("#define DDERR_CANNOTDETACHSURFACE MAKE_DDHRESULT( 20 )")]
        public const int DDERR_CANNOTDETACHSURFACE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(20))));

        [NativeTypeName("#define DDERR_CURRENTLYNOTAVAIL MAKE_DDHRESULT( 40 )")]
        public const int DDERR_CURRENTLYNOTAVAIL = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(40))));

        [NativeTypeName("#define DDERR_EXCEPTION MAKE_DDHRESULT( 55 )")]
        public const int DDERR_EXCEPTION = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(55))));

        [NativeTypeName("#define DDERR_GENERIC E_FAIL")]
        public const int DDERR_GENERIC = unchecked((int)(0x80004005));

        [NativeTypeName("#define DDERR_HEIGHTALIGN MAKE_DDHRESULT( 90 )")]
        public const int DDERR_HEIGHTALIGN = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(90))));

        [NativeTypeName("#define DDERR_INCOMPATIBLEPRIMARY MAKE_DDHRESULT( 95 )")]
        public const int DDERR_INCOMPATIBLEPRIMARY = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(95))));

        [NativeTypeName("#define DDERR_INVALIDCAPS MAKE_DDHRESULT( 100 )")]
        public const int DDERR_INVALIDCAPS = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(100))));

        [NativeTypeName("#define DDERR_INVALIDCLIPLIST MAKE_DDHRESULT( 110 )")]
        public const int DDERR_INVALIDCLIPLIST = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(110))));

        [NativeTypeName("#define DDERR_INVALIDMODE MAKE_DDHRESULT( 120 )")]
        public const int DDERR_INVALIDMODE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(120))));

        [NativeTypeName("#define DDERR_INVALIDOBJECT MAKE_DDHRESULT( 130 )")]
        public const int DDERR_INVALIDOBJECT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(130))));

        [NativeTypeName("#define DDERR_INVALIDPARAMS E_INVALIDARG")]
        public const int DDERR_INVALIDPARAMS = unchecked((int)(0x80070057));

        [NativeTypeName("#define DDERR_INVALIDPIXELFORMAT MAKE_DDHRESULT( 145 )")]
        public const int DDERR_INVALIDPIXELFORMAT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(145))));

        [NativeTypeName("#define DDERR_INVALIDRECT MAKE_DDHRESULT( 150 )")]
        public const int DDERR_INVALIDRECT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(150))));

        [NativeTypeName("#define DDERR_LOCKEDSURFACES MAKE_DDHRESULT( 160 )")]
        public const int DDERR_LOCKEDSURFACES = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(160))));

        [NativeTypeName("#define DDERR_NO3D MAKE_DDHRESULT( 170 )")]
        public const int DDERR_NO3D = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(170))));

        [NativeTypeName("#define DDERR_NOALPHAHW MAKE_DDHRESULT( 180 )")]
        public const int DDERR_NOALPHAHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(180))));

        [NativeTypeName("#define DDERR_NOSTEREOHARDWARE MAKE_DDHRESULT( 181 )")]
        public const int DDERR_NOSTEREOHARDWARE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(181))));

        [NativeTypeName("#define DDERR_NOSURFACELEFT MAKE_DDHRESULT( 182 )")]
        public const int DDERR_NOSURFACELEFT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(182))));

        [NativeTypeName("#define DDERR_NOCLIPLIST MAKE_DDHRESULT( 205 )")]
        public const int DDERR_NOCLIPLIST = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(205))));

        [NativeTypeName("#define DDERR_NOCOLORCONVHW MAKE_DDHRESULT( 210 )")]
        public const int DDERR_NOCOLORCONVHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(210))));

        [NativeTypeName("#define DDERR_NOCOOPERATIVELEVELSET MAKE_DDHRESULT( 212 )")]
        public const int DDERR_NOCOOPERATIVELEVELSET = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(212))));

        [NativeTypeName("#define DDERR_NOCOLORKEY MAKE_DDHRESULT( 215 )")]
        public const int DDERR_NOCOLORKEY = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(215))));

        [NativeTypeName("#define DDERR_NOCOLORKEYHW MAKE_DDHRESULT( 220 )")]
        public const int DDERR_NOCOLORKEYHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(220))));

        [NativeTypeName("#define DDERR_NODIRECTDRAWSUPPORT MAKE_DDHRESULT( 222 )")]
        public const int DDERR_NODIRECTDRAWSUPPORT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(222))));

        [NativeTypeName("#define DDERR_NOEXCLUSIVEMODE MAKE_DDHRESULT( 225 )")]
        public const int DDERR_NOEXCLUSIVEMODE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(225))));

        [NativeTypeName("#define DDERR_NOFLIPHW MAKE_DDHRESULT( 230 )")]
        public const int DDERR_NOFLIPHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(230))));

        [NativeTypeName("#define DDERR_NOGDI MAKE_DDHRESULT( 240 )")]
        public const int DDERR_NOGDI = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(240))));

        [NativeTypeName("#define DDERR_NOMIRRORHW MAKE_DDHRESULT( 250 )")]
        public const int DDERR_NOMIRRORHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(250))));

        [NativeTypeName("#define DDERR_NOTFOUND MAKE_DDHRESULT( 255 )")]
        public const int DDERR_NOTFOUND = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(255))));

        [NativeTypeName("#define DDERR_NOOVERLAYHW MAKE_DDHRESULT( 260 )")]
        public const int DDERR_NOOVERLAYHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(260))));

        [NativeTypeName("#define DDERR_OVERLAPPINGRECTS MAKE_DDHRESULT( 270 )")]
        public const int DDERR_OVERLAPPINGRECTS = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(270))));

        [NativeTypeName("#define DDERR_NORASTEROPHW MAKE_DDHRESULT( 280 )")]
        public const int DDERR_NORASTEROPHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(280))));

        [NativeTypeName("#define DDERR_NOROTATIONHW MAKE_DDHRESULT( 290 )")]
        public const int DDERR_NOROTATIONHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(290))));

        [NativeTypeName("#define DDERR_NOSTRETCHHW MAKE_DDHRESULT( 310 )")]
        public const int DDERR_NOSTRETCHHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(310))));

        [NativeTypeName("#define DDERR_NOT4BITCOLOR MAKE_DDHRESULT( 316 )")]
        public const int DDERR_NOT4BITCOLOR = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(316))));

        [NativeTypeName("#define DDERR_NOT4BITCOLORINDEX MAKE_DDHRESULT( 317 )")]
        public const int DDERR_NOT4BITCOLORINDEX = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(317))));

        [NativeTypeName("#define DDERR_NOT8BITCOLOR MAKE_DDHRESULT( 320 )")]
        public const int DDERR_NOT8BITCOLOR = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(320))));

        [NativeTypeName("#define DDERR_NOTEXTUREHW MAKE_DDHRESULT( 330 )")]
        public const int DDERR_NOTEXTUREHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(330))));

        [NativeTypeName("#define DDERR_NOVSYNCHW MAKE_DDHRESULT( 335 )")]
        public const int DDERR_NOVSYNCHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(335))));

        [NativeTypeName("#define DDERR_NOZBUFFERHW MAKE_DDHRESULT( 340 )")]
        public const int DDERR_NOZBUFFERHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(340))));

        [NativeTypeName("#define DDERR_NOZOVERLAYHW MAKE_DDHRESULT( 350 )")]
        public const int DDERR_NOZOVERLAYHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(350))));

        [NativeTypeName("#define DDERR_OUTOFCAPS MAKE_DDHRESULT( 360 )")]
        public const int DDERR_OUTOFCAPS = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(360))));

        [NativeTypeName("#define DDERR_OUTOFMEMORY E_OUTOFMEMORY")]
        public const int DDERR_OUTOFMEMORY = unchecked((int)(0x8007000E));

        [NativeTypeName("#define DDERR_OUTOFVIDEOMEMORY MAKE_DDHRESULT( 380 )")]
        public const int DDERR_OUTOFVIDEOMEMORY = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(380))));

        [NativeTypeName("#define DDERR_OVERLAYCANTCLIP MAKE_DDHRESULT( 382 )")]
        public const int DDERR_OVERLAYCANTCLIP = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(382))));

        [NativeTypeName("#define DDERR_OVERLAYCOLORKEYONLYONEACTIVE MAKE_DDHRESULT( 384 )")]
        public const int DDERR_OVERLAYCOLORKEYONLYONEACTIVE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(384))));

        [NativeTypeName("#define DDERR_PALETTEBUSY MAKE_DDHRESULT( 387 )")]
        public const int DDERR_PALETTEBUSY = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(387))));

        [NativeTypeName("#define DDERR_COLORKEYNOTSET MAKE_DDHRESULT( 400 )")]
        public const int DDERR_COLORKEYNOTSET = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(400))));

        [NativeTypeName("#define DDERR_SURFACEALREADYATTACHED MAKE_DDHRESULT( 410 )")]
        public const int DDERR_SURFACEALREADYATTACHED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(410))));

        [NativeTypeName("#define DDERR_SURFACEALREADYDEPENDENT MAKE_DDHRESULT( 420 )")]
        public const int DDERR_SURFACEALREADYDEPENDENT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(420))));

        [NativeTypeName("#define DDERR_SURFACEBUSY MAKE_DDHRESULT( 430 )")]
        public const int DDERR_SURFACEBUSY = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(430))));

        [NativeTypeName("#define DDERR_CANTLOCKSURFACE MAKE_DDHRESULT( 435 )")]
        public const int DDERR_CANTLOCKSURFACE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(435))));

        [NativeTypeName("#define DDERR_SURFACEISOBSCURED MAKE_DDHRESULT( 440 )")]
        public const int DDERR_SURFACEISOBSCURED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(440))));

        [NativeTypeName("#define DDERR_SURFACELOST MAKE_DDHRESULT( 450 )")]
        public const int DDERR_SURFACELOST = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(450))));

        [NativeTypeName("#define DDERR_SURFACENOTATTACHED MAKE_DDHRESULT( 460 )")]
        public const int DDERR_SURFACENOTATTACHED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(460))));

        [NativeTypeName("#define DDERR_TOOBIGHEIGHT MAKE_DDHRESULT( 470 )")]
        public const int DDERR_TOOBIGHEIGHT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(470))));

        [NativeTypeName("#define DDERR_TOOBIGSIZE MAKE_DDHRESULT( 480 )")]
        public const int DDERR_TOOBIGSIZE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(480))));

        [NativeTypeName("#define DDERR_TOOBIGWIDTH MAKE_DDHRESULT( 490 )")]
        public const int DDERR_TOOBIGWIDTH = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(490))));

        [NativeTypeName("#define DDERR_UNSUPPORTED E_NOTIMPL")]
        public const int DDERR_UNSUPPORTED = unchecked((int)(0x80004001));

        [NativeTypeName("#define DDERR_UNSUPPORTEDFORMAT MAKE_DDHRESULT( 510 )")]
        public const int DDERR_UNSUPPORTEDFORMAT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(510))));

        [NativeTypeName("#define DDERR_UNSUPPORTEDMASK MAKE_DDHRESULT( 520 )")]
        public const int DDERR_UNSUPPORTEDMASK = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(520))));

        [NativeTypeName("#define DDERR_INVALIDSTREAM MAKE_DDHRESULT( 521 )")]
        public const int DDERR_INVALIDSTREAM = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(521))));

        [NativeTypeName("#define DDERR_VERTICALBLANKINPROGRESS MAKE_DDHRESULT( 537 )")]
        public const int DDERR_VERTICALBLANKINPROGRESS = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(537))));

        [NativeTypeName("#define DDERR_WASSTILLDRAWING MAKE_DDHRESULT( 540 )")]
        public const int DDERR_WASSTILLDRAWING = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(540))));

        [NativeTypeName("#define DDERR_DDSCAPSCOMPLEXREQUIRED MAKE_DDHRESULT( 542 )")]
        public const int DDERR_DDSCAPSCOMPLEXREQUIRED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(542))));

        [NativeTypeName("#define DDERR_XALIGN MAKE_DDHRESULT( 560 )")]
        public const int DDERR_XALIGN = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(560))));

        [NativeTypeName("#define DDERR_INVALIDDIRECTDRAWGUID MAKE_DDHRESULT( 561 )")]
        public const int DDERR_INVALIDDIRECTDRAWGUID = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(561))));

        [NativeTypeName("#define DDERR_DIRECTDRAWALREADYCREATED MAKE_DDHRESULT( 562 )")]
        public const int DDERR_DIRECTDRAWALREADYCREATED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(562))));

        [NativeTypeName("#define DDERR_NODIRECTDRAWHW MAKE_DDHRESULT( 563 )")]
        public const int DDERR_NODIRECTDRAWHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(563))));

        [NativeTypeName("#define DDERR_PRIMARYSURFACEALREADYEXISTS MAKE_DDHRESULT( 564 )")]
        public const int DDERR_PRIMARYSURFACEALREADYEXISTS = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(564))));

        [NativeTypeName("#define DDERR_NOEMULATION MAKE_DDHRESULT( 565 )")]
        public const int DDERR_NOEMULATION = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(565))));

        [NativeTypeName("#define DDERR_REGIONTOOSMALL MAKE_DDHRESULT( 566 )")]
        public const int DDERR_REGIONTOOSMALL = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(566))));

        [NativeTypeName("#define DDERR_CLIPPERISUSINGHWND MAKE_DDHRESULT( 567 )")]
        public const int DDERR_CLIPPERISUSINGHWND = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(567))));

        [NativeTypeName("#define DDERR_NOCLIPPERATTACHED MAKE_DDHRESULT( 568 )")]
        public const int DDERR_NOCLIPPERATTACHED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(568))));

        [NativeTypeName("#define DDERR_NOHWND MAKE_DDHRESULT( 569 )")]
        public const int DDERR_NOHWND = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(569))));

        [NativeTypeName("#define DDERR_HWNDSUBCLASSED MAKE_DDHRESULT( 570 )")]
        public const int DDERR_HWNDSUBCLASSED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(570))));

        [NativeTypeName("#define DDERR_HWNDALREADYSET MAKE_DDHRESULT( 571 )")]
        public const int DDERR_HWNDALREADYSET = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(571))));

        [NativeTypeName("#define DDERR_NOPALETTEATTACHED MAKE_DDHRESULT( 572 )")]
        public const int DDERR_NOPALETTEATTACHED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(572))));

        [NativeTypeName("#define DDERR_NOPALETTEHW MAKE_DDHRESULT( 573 )")]
        public const int DDERR_NOPALETTEHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(573))));

        [NativeTypeName("#define DDERR_BLTFASTCANTCLIP MAKE_DDHRESULT( 574 )")]
        public const int DDERR_BLTFASTCANTCLIP = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(574))));

        [NativeTypeName("#define DDERR_NOBLTHW MAKE_DDHRESULT( 575 )")]
        public const int DDERR_NOBLTHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(575))));

        [NativeTypeName("#define DDERR_NODDROPSHW MAKE_DDHRESULT( 576 )")]
        public const int DDERR_NODDROPSHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(576))));

        [NativeTypeName("#define DDERR_OVERLAYNOTVISIBLE MAKE_DDHRESULT( 577 )")]
        public const int DDERR_OVERLAYNOTVISIBLE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(577))));

        [NativeTypeName("#define DDERR_NOOVERLAYDEST MAKE_DDHRESULT( 578 )")]
        public const int DDERR_NOOVERLAYDEST = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(578))));

        [NativeTypeName("#define DDERR_INVALIDPOSITION MAKE_DDHRESULT( 579 )")]
        public const int DDERR_INVALIDPOSITION = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(579))));

        [NativeTypeName("#define DDERR_NOTAOVERLAYSURFACE MAKE_DDHRESULT( 580 )")]
        public const int DDERR_NOTAOVERLAYSURFACE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(580))));

        [NativeTypeName("#define DDERR_EXCLUSIVEMODEALREADYSET MAKE_DDHRESULT( 581 )")]
        public const int DDERR_EXCLUSIVEMODEALREADYSET = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(581))));

        [NativeTypeName("#define DDERR_NOTFLIPPABLE MAKE_DDHRESULT( 582 )")]
        public const int DDERR_NOTFLIPPABLE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(582))));

        [NativeTypeName("#define DDERR_CANTDUPLICATE MAKE_DDHRESULT( 583 )")]
        public const int DDERR_CANTDUPLICATE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(583))));

        [NativeTypeName("#define DDERR_NOTLOCKED MAKE_DDHRESULT( 584 )")]
        public const int DDERR_NOTLOCKED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(584))));

        [NativeTypeName("#define DDERR_CANTCREATEDC MAKE_DDHRESULT( 585 )")]
        public const int DDERR_CANTCREATEDC = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(585))));

        [NativeTypeName("#define DDERR_NODC MAKE_DDHRESULT( 586 )")]
        public const int DDERR_NODC = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(586))));

        [NativeTypeName("#define DDERR_WRONGMODE MAKE_DDHRESULT( 587 )")]
        public const int DDERR_WRONGMODE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(587))));

        [NativeTypeName("#define DDERR_IMPLICITLYCREATED MAKE_DDHRESULT( 588 )")]
        public const int DDERR_IMPLICITLYCREATED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(588))));

        [NativeTypeName("#define DDERR_NOTPALETTIZED MAKE_DDHRESULT( 589 )")]
        public const int DDERR_NOTPALETTIZED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(589))));

        [NativeTypeName("#define DDERR_UNSUPPORTEDMODE MAKE_DDHRESULT( 590 )")]
        public const int DDERR_UNSUPPORTEDMODE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(590))));

        [NativeTypeName("#define DDERR_NOMIPMAPHW MAKE_DDHRESULT( 591 )")]
        public const int DDERR_NOMIPMAPHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(591))));

        [NativeTypeName("#define DDERR_INVALIDSURFACETYPE MAKE_DDHRESULT( 592 )")]
        public const int DDERR_INVALIDSURFACETYPE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(592))));

        [NativeTypeName("#define DDERR_NOOPTIMIZEHW MAKE_DDHRESULT( 600 )")]
        public const int DDERR_NOOPTIMIZEHW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(600))));

        [NativeTypeName("#define DDERR_NOTLOADED MAKE_DDHRESULT( 601 )")]
        public const int DDERR_NOTLOADED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(601))));

        [NativeTypeName("#define DDERR_NOFOCUSWINDOW MAKE_DDHRESULT( 602 )")]
        public const int DDERR_NOFOCUSWINDOW = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(602))));

        [NativeTypeName("#define DDERR_NOTONMIPMAPSUBLEVEL MAKE_DDHRESULT( 603 )")]
        public const int DDERR_NOTONMIPMAPSUBLEVEL = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(603))));

        [NativeTypeName("#define DDERR_DCALREADYCREATED MAKE_DDHRESULT( 620 )")]
        public const int DDERR_DCALREADYCREATED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(620))));

        [NativeTypeName("#define DDERR_NONONLOCALVIDMEM MAKE_DDHRESULT( 630 )")]
        public const int DDERR_NONONLOCALVIDMEM = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(630))));

        [NativeTypeName("#define DDERR_CANTPAGELOCK MAKE_DDHRESULT( 640 )")]
        public const int DDERR_CANTPAGELOCK = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(640))));

        [NativeTypeName("#define DDERR_CANTPAGEUNLOCK MAKE_DDHRESULT( 660 )")]
        public const int DDERR_CANTPAGEUNLOCK = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(660))));

        [NativeTypeName("#define DDERR_NOTPAGELOCKED MAKE_DDHRESULT( 680 )")]
        public const int DDERR_NOTPAGELOCKED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(680))));

        [NativeTypeName("#define DDERR_MOREDATA MAKE_DDHRESULT( 690 )")]
        public const int DDERR_MOREDATA = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(690))));

        [NativeTypeName("#define DDERR_EXPIRED MAKE_DDHRESULT( 691 )")]
        public const int DDERR_EXPIRED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(691))));

        [NativeTypeName("#define DDERR_TESTFINISHED MAKE_DDHRESULT( 692 )")]
        public const int DDERR_TESTFINISHED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(692))));

        [NativeTypeName("#define DDERR_NEWMODE MAKE_DDHRESULT( 693 )")]
        public const int DDERR_NEWMODE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(693))));

        [NativeTypeName("#define DDERR_D3DNOTINITIALIZED MAKE_DDHRESULT( 694 )")]
        public const int DDERR_D3DNOTINITIALIZED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(694))));

        [NativeTypeName("#define DDERR_VIDEONOTACTIVE MAKE_DDHRESULT( 695 )")]
        public const int DDERR_VIDEONOTACTIVE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(695))));

        [NativeTypeName("#define DDERR_NOMONITORINFORMATION MAKE_DDHRESULT( 696 )")]
        public const int DDERR_NOMONITORINFORMATION = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(696))));

        [NativeTypeName("#define DDERR_NODRIVERSUPPORT MAKE_DDHRESULT( 697 )")]
        public const int DDERR_NODRIVERSUPPORT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(697))));

        [NativeTypeName("#define DDERR_DEVICEDOESNTOWNSURFACE MAKE_DDHRESULT( 699 )")]
        public const int DDERR_DEVICEDOESNTOWNSURFACE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(699))));

        [NativeTypeName("#define DDERR_NOTINITIALIZED CO_E_NOTINITIALIZED")]
        public const int DDERR_NOTINITIALIZED = unchecked((int)(0x800401F0));
    }
}
