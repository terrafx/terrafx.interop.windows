// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const IID")]
        public static ref readonly Guid IID_IAMFilterGraphCallback
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFD, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0xA3,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("#define CDEF_CLASS_DEFAULT 0x0001")]
        public const int CDEF_CLASS_DEFAULT = 0x0001;

        [NativeTypeName("#define CDEF_BYPASS_CLASS_MANAGER 0x0002")]
        public const int CDEF_BYPASS_CLASS_MANAGER = 0x0002;

        [NativeTypeName("#define CDEF_MERIT_ABOVE_DO_NOT_USE 0x0008")]
        public const int CDEF_MERIT_ABOVE_DO_NOT_USE = 0x0008;

        [NativeTypeName("#define CDEF_DEVMON_CMGR_DEVICE 0x0010")]
        public const int CDEF_DEVMON_CMGR_DEVICE = 0x0010;

        [NativeTypeName("#define CDEF_DEVMON_DMO 0x0020")]
        public const int CDEF_DEVMON_DMO = 0x0020;

        [NativeTypeName("#define CDEF_DEVMON_PNP_DEVICE 0x0040")]
        public const int CDEF_DEVMON_PNP_DEVICE = 0x0040;

        [NativeTypeName("#define CDEF_DEVMON_FILTER 0x0080")]
        public const int CDEF_DEVMON_FILTER = 0x0080;

        [NativeTypeName("#define CDEF_DEVMON_SELECTIVE_MASK 0x00f0")]
        public const int CDEF_DEVMON_SELECTIVE_MASK = 0x00f0;

        [NativeTypeName("#define CHARS_IN_GUID 39")]
        public const int CHARS_IN_GUID = 39;

        [NativeTypeName("#define MAX_PIN_NAME 128")]
        public const int MAX_PIN_NAME = 128;

        [NativeTypeName("#define MAX_FILTER_NAME 128")]
        public const int MAX_FILTER_NAME = 128;

        [NativeTypeName("#define AM_GBF_PREVFRAMESKIPPED 1")]
        public const int AM_GBF_PREVFRAMESKIPPED = 1;

        [NativeTypeName("#define AM_GBF_NOTASYNCPOINT 2")]
        public const int AM_GBF_NOTASYNCPOINT = 2;

        [NativeTypeName("#define AM_GBF_NOWAIT 4")]
        public const int AM_GBF_NOWAIT = 4;

        [NativeTypeName("#define AM_GBF_NODDSURFACELOCK 8")]
        public const int AM_GBF_NODDSURFACELOCK = 8;

        [NativeTypeName("#define ADVISE_ALL ( ( ( ( ADVISE_CLIPPING | ADVISE_PALETTE )  | ADVISE_COLORKEY )  | ADVISE_POSITION )  )")]
        public const int ADVISE_ALL = (((((int)(ADVISE_CLIPPING) | (int)(ADVISE_PALETTE)) | (int)(ADVISE_COLORKEY)) | (int)(ADVISE_POSITION)));

        [NativeTypeName("#define ADVISE_ALL2 ( ( ADVISE_ALL | ADVISE_DISPLAY_CHANGE )  )")]
        public const int ADVISE_ALL2 = (((((((int)(ADVISE_CLIPPING) | (int)(ADVISE_PALETTE)) | (int)(ADVISE_COLORKEY)) | (int)(ADVISE_POSITION))) | (int)(ADVISE_DISPLAY_CHANGE)));

        [NativeTypeName("#define AMF_AUTOMATICGAIN -1.0")]
        public const double AMF_AUTOMATICGAIN = -1.0;

        [NativeTypeName("#define AnalogVideo_NTSC_Mask 0x00000007")]
        public const int AnalogVideo_NTSC_Mask = 0x00000007;

        [NativeTypeName("#define AnalogVideo_PAL_Mask 0x00100FF0")]
        public const int AnalogVideo_PAL_Mask = 0x00100FF0;

        [NativeTypeName("#define AnalogVideo_SECAM_Mask 0x000FF000")]
        public const int AnalogVideo_SECAM_Mask = 0x000FF000;

        [NativeTypeName("#define KSPROPERTY_SUPPORT_GET 1")]
        public const int KSPROPERTY_SUPPORT_GET = 1;

        [NativeTypeName("#define KSPROPERTY_SUPPORT_SET 2")]
        public const int KSPROPERTY_SUPPORT_SET = 2;

        [NativeTypeName("#define MPEG2_PROGRAM_STREAM_MAP 0x00000000")]
        public const int MPEG2_PROGRAM_STREAM_MAP = 0x00000000;

        [NativeTypeName("#define MPEG2_PROGRAM_ELEMENTARY_STREAM 0x00000001")]
        public const int MPEG2_PROGRAM_ELEMENTARY_STREAM = 0x00000001;

        [NativeTypeName("#define MPEG2_PROGRAM_DIRECTORY_PES_PACKET 0x00000002")]
        public const int MPEG2_PROGRAM_DIRECTORY_PES_PACKET = 0x00000002;

        [NativeTypeName("#define MPEG2_PROGRAM_PACK_HEADER 0x00000003")]
        public const int MPEG2_PROGRAM_PACK_HEADER = 0x00000003;

        [NativeTypeName("#define MPEG2_PROGRAM_PES_STREAM 0x00000004")]
        public const int MPEG2_PROGRAM_PES_STREAM = 0x00000004;

        [NativeTypeName("#define MPEG2_PROGRAM_SYSTEM_HEADER 0x00000005")]
        public const int MPEG2_PROGRAM_SYSTEM_HEADER = 0x00000005;

        [NativeTypeName("#define SUBSTREAM_FILTER_VAL_NONE 0x10000000")]
        public const int SUBSTREAM_FILTER_VAL_NONE = 0x10000000;

        [NativeTypeName("#define AM_GETDECODERCAP_QUERY_VMR_SUPPORT 0x00000001")]
        public const int AM_GETDECODERCAP_QUERY_VMR_SUPPORT = 0x00000001;

        [NativeTypeName("#define VMR_NOTSUPPORTED 0x00000000")]
        public const int VMR_NOTSUPPORTED = 0x00000000;

        [NativeTypeName("#define VMR_SUPPORTED 0x00000001")]
        public const int VMR_SUPPORTED = 0x00000001;

        [NativeTypeName("#define AM_QUERY_DECODER_VMR_SUPPORT 0x00000001")]
        public const int AM_QUERY_DECODER_VMR_SUPPORT = 0x00000001;

        [NativeTypeName("#define AM_QUERY_DECODER_DXVA_1_SUPPORT 0x00000002")]
        public const int AM_QUERY_DECODER_DXVA_1_SUPPORT = 0x00000002;

        [NativeTypeName("#define AM_QUERY_DECODER_DVD_SUPPORT 0x00000003")]
        public const int AM_QUERY_DECODER_DVD_SUPPORT = 0x00000003;

        [NativeTypeName("#define AM_QUERY_DECODER_ATSC_SD_SUPPORT 0x00000004")]
        public const int AM_QUERY_DECODER_ATSC_SD_SUPPORT = 0x00000004;

        [NativeTypeName("#define AM_QUERY_DECODER_ATSC_HD_SUPPORT 0x00000005")]
        public const int AM_QUERY_DECODER_ATSC_HD_SUPPORT = 0x00000005;

        [NativeTypeName("#define AM_GETDECODERCAP_QUERY_VMR9_SUPPORT 0x00000006")]
        public const int AM_GETDECODERCAP_QUERY_VMR9_SUPPORT = 0x00000006;

        [NativeTypeName("#define AM_GETDECODERCAP_QUERY_EVR_SUPPORT 0x00000007")]
        public const int AM_GETDECODERCAP_QUERY_EVR_SUPPORT = 0x00000007;

        [NativeTypeName("#define DECODER_CAP_NOTSUPPORTED 0x00000000")]
        public const int DECODER_CAP_NOTSUPPORTED = 0x00000000;

        [NativeTypeName("#define DECODER_CAP_SUPPORTED 0x00000001")]
        public const int DECODER_CAP_SUPPORTED = 0x00000001;

        [NativeTypeName("#define VMRBITMAP_DISABLE 0x00000001")]
        public const int VMRBITMAP_DISABLE = 0x00000001;

        [NativeTypeName("#define VMRBITMAP_HDC 0x00000002")]
        public const int VMRBITMAP_HDC = 0x00000002;

        [NativeTypeName("#define VMRBITMAP_ENTIREDDS 0x00000004")]
        public const int VMRBITMAP_ENTIREDDS = 0x00000004;

        [NativeTypeName("#define VMRBITMAP_SRCCOLORKEY 0x00000008")]
        public const int VMRBITMAP_SRCCOLORKEY = 0x00000008;

        [NativeTypeName("#define VMRBITMAP_SRCRECT 0x00000010")]
        public const int VMRBITMAP_SRCRECT = 0x00000010;

        [NativeTypeName("#define DVD_TITLE_MENU 0x000")]
        public const int DVD_TITLE_MENU = 0x000;

        [NativeTypeName("#define DVD_STREAM_DATA_CURRENT 0x800")]
        public const int DVD_STREAM_DATA_CURRENT = 0x800;

        [NativeTypeName("#define DVD_STREAM_DATA_VMGM 0x400")]
        public const int DVD_STREAM_DATA_VMGM = 0x400;

        [NativeTypeName("#define DVD_STREAM_DATA_VTSM 0x401")]
        public const int DVD_STREAM_DATA_VTSM = 0x401;

        [NativeTypeName("#define DVD_DEFAULT_AUDIO_STREAM 0x0f")]
        public const int DVD_DEFAULT_AUDIO_STREAM = 0x0f;

        [NativeTypeName("#define DVD_AUDIO_CAPS_AC3 0x00000001")]
        public const int DVD_AUDIO_CAPS_AC3 = 0x00000001;

        [NativeTypeName("#define DVD_AUDIO_CAPS_MPEG2 0x00000002")]
        public const int DVD_AUDIO_CAPS_MPEG2 = 0x00000002;

        [NativeTypeName("#define DVD_AUDIO_CAPS_LPCM 0x00000004")]
        public const int DVD_AUDIO_CAPS_LPCM = 0x00000004;

        [NativeTypeName("#define DVD_AUDIO_CAPS_DTS 0x00000008")]
        public const int DVD_AUDIO_CAPS_DTS = 0x00000008;

        [NativeTypeName("#define DVD_AUDIO_CAPS_SDDS 0x00000010")]
        public const int DVD_AUDIO_CAPS_SDDS = 0x00000010;

        public static ref readonly Guid IID_ICreateDevEnum
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x22, 0x08, 0x84, 0x29,
                    0x84, 0x5B,
                    0xD0, 0x11,
                    0xBD,
                    0x3B,
                    0x00,
                    0xA0,
                    0xC9,
                    0x11,
                    0xCE,
                    0x86
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IPin
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x91, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IEnumPins
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x92, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IEnumMediaTypes
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0x10, 0xC3, 0x89,
                    0x6B, 0x84,
                    0xCE, 0x11,
                    0x97,
                    0xD3,
                    0x00,
                    0xAA,
                    0x00,
                    0x55,
                    0x59,
                    0x5A
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IFilterGraph
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9F, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IEnumFilters
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x93, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMediaFilter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x99, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IBaseFilter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x95, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IReferenceClock
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x97, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IReferenceClockTimerControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9C, 0x45, 0xEC, 0xEB,
                    0xCA, 0x2E,
                    0x42, 0x4D,
                    0xA8,
                    0xAF,
                    0x30,
                    0xDF,
                    0x55,
                    0x76,
                    0x14,
                    0xB8
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IReferenceClock2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x85, 0x38, 0xB7, 0x36,
                    0xC8, 0xC2,
                    0xCF, 0x11,
                    0x8B,
                    0x46,
                    0x00,
                    0x80,
                    0x5F,
                    0x6C,
                    0xEF,
                    0x60
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMediaSample
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9A, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMediaSample2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x84, 0x38, 0xB7, 0x36,
                    0xC8, 0xC2,
                    0xCF, 0x11,
                    0x8B,
                    0x46,
                    0x00,
                    0x80,
                    0x5F,
                    0x6C,
                    0xEF,
                    0x60
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMediaSample2Config
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x68, 0x1E, 0x96, 0x68,
                    0x2B, 0x83,
                    0xEA, 0x41,
                    0xBC,
                    0x91,
                    0x63,
                    0x59,
                    0x3F,
                    0x3E,
                    0x70,
                    0xE3
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMemAllocator
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9C, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMemAllocatorCallbackTemp
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF0, 0x0C, 0x9A, 0x37,
                    0xDE, 0xC1,
                    0xD2, 0x11,
                    0xAB,
                    0xF5,
                    0x00,
                    0xA0,
                    0xC9,
                    0x05,
                    0xF3,
                    0x75
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMemAllocatorNotifyCallbackTemp
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x30, 0x0B, 0x98, 0x92,
                    0xDE, 0xC1,
                    0xD2, 0x11,
                    0xAB,
                    0xF5,
                    0x00,
                    0xA0,
                    0xC9,
                    0x05,
                    0xF3,
                    0x75
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMemInputPin
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9D, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMovieSetup
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC0, 0xCE, 0xD8, 0xA3,
                    0x5A, 0x7E,
                    0xCF, 0x11,
                    0xBB,
                    0xC5,
                    0x00,
                    0x80,
                    0x5F,
                    0x6C,
                    0xEF,
                    0x20
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMediaSeeking
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0x38, 0xB7, 0x36,
                    0xC8, 0xC2,
                    0xCF, 0x11,
                    0x8B,
                    0x46,
                    0x00,
                    0x80,
                    0x5F,
                    0x6C,
                    0xEF,
                    0x60
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ICodecAPI
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC7, 0xB4, 0x1D, 0x90,
                    0xCE, 0x31,
                    0xA2, 0x41,
                    0x85,
                    0xDC,
                    0x8F,
                    0xA0,
                    0xBF,
                    0x41,
                    0xB8,
                    0xDA
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IEnumRegFilters
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA4, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IFilterMapper
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA3, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IFilterMapper2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB0, 0xB0, 0x9B, 0xB7,
                    0xC1, 0x33,
                    0xD1, 0x11,
                    0xAB,
                    0xE1,
                    0x00,
                    0xA0,
                    0xC9,
                    0x05,
                    0xF3,
                    0x75
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IFilterMapper3
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB1, 0xB0, 0x9B, 0xB7,
                    0xC1, 0x33,
                    0xD1, 0x11,
                    0xAB,
                    0xE1,
                    0x00,
                    0xA0,
                    0xC9,
                    0x05,
                    0xF3,
                    0x75
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IQualityControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA5, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IOverlayNotify
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IOverlayNotify2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x10, 0xFA, 0x0E, 0x68,
                    0x35, 0xD5,
                    0xD1, 0x11,
                    0x87,
                    0xC8,
                    0x00,
                    0xA0,
                    0xC9,
                    0x22,
                    0x31,
                    0x96
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IOverlay
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA1, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMediaEventSink
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA2, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IFileSourceFilter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA6, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IFileSinkFilter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x30, 0x48, 0x10, 0xA2,
                    0x70, 0x7C,
                    0xCF, 0x11,
                    0x8B,
                    0xCE,
                    0x00,
                    0xAA,
                    0x00,
                    0xA3,
                    0xF1,
                    0xA6
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IFileSinkFilter2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x90, 0x5B, 0x85, 0x00,
                    0x1B, 0xCE,
                    0xD0, 0x11,
                    0xBD,
                    0x4F,
                    0x00,
                    0xA0,
                    0xC9,
                    0x11,
                    0xCE,
                    0x86
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IGraphBuilder
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA9, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ICaptureGraphBuilder
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE0, 0xB6, 0x87, 0xBF,
                    0x27, 0x8C,
                    0xD0, 0x11,
                    0xB3,
                    0xF0,
                    0x00,
                    0xAA,
                    0x00,
                    0x37,
                    0x61,
                    0xC5
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMCopyCaptureFileProgress
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x20, 0x1D, 0x0D, 0x67,
                    0x68, 0xA0,
                    0xD0, 0x11,
                    0xB3,
                    0xF0,
                    0x00,
                    0xAA,
                    0x00,
                    0x37,
                    0x61,
                    0xC5
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ICaptureGraphBuilder2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE0, 0xA4, 0xE5, 0x93,
                    0x50, 0x2D,
                    0xD2, 0x11,
                    0xAB,
                    0xFA,
                    0x00,
                    0xA0,
                    0xC9,
                    0xC6,
                    0xE3,
                    0x8D
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IFilterGraph2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x82, 0x38, 0xB7, 0x36,
                    0xC8, 0xC2,
                    0xCF, 0x11,
                    0x8B,
                    0x46,
                    0x00,
                    0x80,
                    0x5F,
                    0x6C,
                    0xEF,
                    0x60
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IFilterGraph3
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x54, 0x81, 0xF3, 0xAA,
                    0x0B, 0xB8,
                    0x2F, 0x42,
                    0x91,
                    0xE6,
                    0xB6,
                    0x64,
                    0x67,
                    0x50,
                    0x9A,
                    0x07
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IStreamBuilder
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBF, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAsyncReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAA, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IGraphVersion
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAB, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IResourceConsumer
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAD, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IResourceManager
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAC, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDistributorNotify
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAF, 0x68, 0xA8, 0x56,
                    0xD4, 0x0A,
                    0xCE, 0x11,
                    0xB0,
                    0x3A,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMStreamControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x81, 0x38, 0xB7, 0x36,
                    0xC8, 0xC2,
                    0xCF, 0x11,
                    0x8B,
                    0x46,
                    0x00,
                    0x80,
                    0x5F,
                    0x6C,
                    0xEF,
                    0x60
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISeekingPassThru
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x83, 0x38, 0xB7, 0x36,
                    0xC8, 0xC2,
                    0xCF, 0x11,
                    0x8B,
                    0x46,
                    0x00,
                    0x80,
                    0x5F,
                    0x6C,
                    0xEF,
                    0x60
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMStreamConfig
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0x33, 0xE1, 0xC6,
                    0xAC, 0x30,
                    0xD0, 0x11,
                    0xA1,
                    0x8C,
                    0x00,
                    0xA0,
                    0xC9,
                    0x11,
                    0x89,
                    0x56
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IConfigInterleaving
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x20, 0xD2, 0xE3, 0xBE,
                    0x7B, 0x15,
                    0xD0, 0x11,
                    0xBD,
                    0x23,
                    0x00,
                    0xA0,
                    0xC9,
                    0x11,
                    0xCE,
                    0x86
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IConfigAviMux
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0x6A, 0xCD, 0x5A,
                    0x82, 0xF4,
                    0xCE, 0x11,
                    0x8B,
                    0x67,
                    0x00,
                    0xAA,
                    0x00,
                    0xA3,
                    0xF1,
                    0xA6
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMVideoCompression
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x43, 0x33, 0xE1, 0xC6,
                    0xAC, 0x30,
                    0xD0, 0x11,
                    0xA1,
                    0x8C,
                    0x00,
                    0xA0,
                    0xC9,
                    0x11,
                    0x89,
                    0x56
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMVfwCaptureDialogs
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0x15, 0xD7, 0xD8,
                    0x5E, 0x6E,
                    0xD0, 0x11,
                    0xB3,
                    0xF0,
                    0x00,
                    0xAA,
                    0x00,
                    0x37,
                    0x61,
                    0xC5
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMVfwCompressDialogs
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA3, 0x15, 0xD7, 0xD8,
                    0x5E, 0x6E,
                    0xD0, 0x11,
                    0xB3,
                    0xF0,
                    0x00,
                    0xAA,
                    0x00,
                    0x37,
                    0x61,
                    0xC5
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMDroppedFrames
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x44, 0x33, 0xE1, 0xC6,
                    0xAC, 0x30,
                    0xD0, 0x11,
                    0xA1,
                    0x8C,
                    0x00,
                    0xA0,
                    0xC9,
                    0x11,
                    0x89,
                    0x56
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMAudioInputMixer
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x21, 0x92, 0xC3, 0x54,
                    0x80, 0x83,
                    0xD0, 0x11,
                    0xB3,
                    0xF0,
                    0x00,
                    0xAA,
                    0x00,
                    0x37,
                    0x61,
                    0xC5
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMBufferNegotiation
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0x71, 0xED, 0x56,
                    0x5F, 0xAF,
                    0xD0, 0x11,
                    0xB3,
                    0xF0,
                    0x00,
                    0xAA,
                    0x00,
                    0x37,
                    0x61,
                    0xC5
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMAnalogVideoDecoder
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x33, 0xE1, 0xC6,
                    0xAC, 0x30,
                    0xD0, 0x11,
                    0xA1,
                    0x8C,
                    0x00,
                    0xA0,
                    0xC9,
                    0x11,
                    0x89,
                    0x56
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMVideoProcAmp
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x60, 0x33, 0xE1, 0xC6,
                    0xAC, 0x30,
                    0xD0, 0x11,
                    0xA1,
                    0x8C,
                    0x00,
                    0xA0,
                    0xC9,
                    0x11,
                    0x89,
                    0x56
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMCameraControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x70, 0x33, 0xE1, 0xC6,
                    0xAC, 0x30,
                    0xD0, 0x11,
                    0xA1,
                    0x8C,
                    0x00,
                    0xA0,
                    0xC9,
                    0x11,
                    0x89,
                    0x56
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMVideoControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x70, 0x06, 0x2E, 0x6A,
                    0xE4, 0x28,
                    0xD0, 0x11,
                    0xA1,
                    0x8C,
                    0x00,
                    0xA0,
                    0xC9,
                    0x11,
                    0x89,
                    0x56
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMCrossbar
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0x33, 0xE1, 0xC6,
                    0xAC, 0x30,
                    0xD0, 0x11,
                    0xA1,
                    0x8C,
                    0x00,
                    0xA0,
                    0xC9,
                    0x11,
                    0x89,
                    0x56
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMTuner
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x61, 0x87, 0x1A, 0x21,
                    0xAC, 0x03,
                    0xD1, 0x11,
                    0x8D,
                    0x13,
                    0x00,
                    0xAA,
                    0x00,
                    0xBD,
                    0x83,
                    0x39
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMTunerNotification
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x60, 0x87, 0x1A, 0x21,
                    0xAC, 0x03,
                    0xD1, 0x11,
                    0x8D,
                    0x13,
                    0x00,
                    0xAA,
                    0x00,
                    0xBD,
                    0x83,
                    0x39
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMTVTuner
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x66, 0x87, 0x1A, 0x21,
                    0xAC, 0x03,
                    0xD1, 0x11,
                    0x8D,
                    0x13,
                    0x00,
                    0xAA,
                    0x00,
                    0xBD,
                    0x83,
                    0x39
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IBPCSatelliteTuner
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x65, 0x87, 0x1A, 0x21,
                    0xAC, 0x03,
                    0xD1, 0x11,
                    0x8D,
                    0x13,
                    0x00,
                    0xAA,
                    0x00,
                    0xBD,
                    0x83,
                    0x39
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMTVAudio
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x30, 0x1C, 0xEC, 0x83,
                    0xD1, 0x23,
                    0xD1, 0x11,
                    0x99,
                    0xE6,
                    0x00,
                    0xA0,
                    0xC9,
                    0x56,
                    0x02,
                    0x66
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMTVAudioNotification
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x33, 0x1C, 0xEC, 0x83,
                    0xD1, 0x23,
                    0xD1, 0x11,
                    0x99,
                    0xE6,
                    0x00,
                    0xA0,
                    0xC9,
                    0x56,
                    0x02,
                    0x66
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMAnalogVideoEncoder
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB0, 0x33, 0xE1, 0xC6,
                    0xAC, 0x30,
                    0xD0, 0x11,
                    0xA1,
                    0x8C,
                    0x00,
                    0xA0,
                    0xC9,
                    0x11,
                    0x89,
                    0x56
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IKsPropertySet
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x30, 0xAC, 0xEF, 0x31,
                    0x5C, 0x51,
                    0xD0, 0x11,
                    0xA9,
                    0xAA,
                    0x00,
                    0xAA,
                    0x00,
                    0x61,
                    0xBE,
                    0x93
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMediaPropertyBag
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0xA8, 0x25, 0x60,
                    0xD5, 0xC0,
                    0xD0, 0x11,
                    0xBD,
                    0x4E,
                    0x00,
                    0xA0,
                    0xC9,
                    0x11,
                    0xCE,
                    0x86
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IPersistMediaPropertyBag
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0xE0, 0x38, 0x57,
                    0x7F, 0xB6,
                    0xD0, 0x11,
                    0xBD,
                    0x4D,
                    0x00,
                    0xA0,
                    0xC9,
                    0x11,
                    0xCE,
                    0x86
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMPhysicalPinInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x91, 0xC9, 0x38, 0xF9,
                    0x29, 0x30,
                    0xCF, 0x11,
                    0x8C,
                    0x44,
                    0x00,
                    0xAA,
                    0x00,
                    0x6B,
                    0x68,
                    0x14
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMExtDevice
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x90, 0x0A, 0x73, 0xB5,
                    0x2C, 0x1A,
                    0xCF, 0x11,
                    0x8C,
                    0x23,
                    0x00,
                    0xAA,
                    0x00,
                    0x6B,
                    0x68,
                    0x14
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMExtTransport
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF0, 0xD5, 0x3C, 0xA0,
                    0x45, 0x30,
                    0xCF, 0x11,
                    0x8C,
                    0x44,
                    0x00,
                    0xAA,
                    0x00,
                    0x6B,
                    0x68,
                    0x14
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMTimecodeReader
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE1, 0x6C, 0x49, 0x9B,
                    0x1B, 0x81,
                    0xCF, 0x11,
                    0x8C,
                    0x77,
                    0x00,
                    0xAA,
                    0x00,
                    0x6B,
                    0x68,
                    0x14
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMTimecodeGenerator
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE0, 0x6C, 0x49, 0x9B,
                    0x1B, 0x81,
                    0xCF, 0x11,
                    0x8C,
                    0x77,
                    0x00,
                    0xAA,
                    0x00,
                    0x6B,
                    0x68,
                    0x14
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMTimecodeDisplay
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE2, 0x6C, 0x49, 0x9B,
                    0x1B, 0x81,
                    0xCF, 0x11,
                    0x8C,
                    0x77,
                    0x00,
                    0xAA,
                    0x00,
                    0x6B,
                    0x68,
                    0x14
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMDevMemoryAllocator
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF0, 0x5B, 0x54, 0xC6,
                    0x6B, 0xE7,
                    0xD0, 0x11,
                    0xBD,
                    0x52,
                    0x00,
                    0xA0,
                    0xC9,
                    0x11,
                    0xCE,
                    0x86
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMDevMemoryControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF1, 0x5B, 0x54, 0xC6,
                    0x6B, 0xE7,
                    0xD0, 0x11,
                    0xBD,
                    0x52,
                    0x00,
                    0xA0,
                    0xC9,
                    0x11,
                    0xCE,
                    0x86
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMStreamSelect
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x60, 0x09, 0x96, 0xC1,
                    0xF5, 0x17,
                    0xD1, 0x11,
                    0xAB,
                    0xE1,
                    0x00,
                    0xA0,
                    0xC9,
                    0x05,
                    0xF3,
                    0x75
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMResourceControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD0, 0xD2, 0x89, 0x83,
                    0xD7, 0x77,
                    0xD1, 0x11,
                    0xAB,
                    0xE6,
                    0x00,
                    0xA0,
                    0xC9,
                    0x05,
                    0xF3,
                    0x75
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMClockAdjust
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB0, 0x66, 0x54, 0x4D,
                    0x9C, 0xA4,
                    0xD1, 0x11,
                    0xAB,
                    0xE8,
                    0x00,
                    0xA0,
                    0xC9,
                    0x05,
                    0xF3,
                    0x75
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMFilterMiscFlags
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x49, 0xD7, 0x2D,
                    0x90, 0xA8,
                    0xD1, 0x11,
                    0xAB,
                    0xE8,
                    0x00,
                    0xA0,
                    0xC9,
                    0x05,
                    0xF3,
                    0x75
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDrawVideoImage
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x20, 0xB1, 0xEF, 0x48,
                    0x49, 0xAB,
                    0xD2, 0x11,
                    0xAE,
                    0xD2,
                    0x00,
                    0xA0,
                    0xC9,
                    0x95,
                    0xE8,
                    0xD5
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDecimateVideoImage
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE0, 0xA3, 0x5E, 0x2E,
                    0x24, 0xE9,
                    0xD2, 0x11,
                    0xB6,
                    0xDA,
                    0x00,
                    0xA0,
                    0xC9,
                    0x95,
                    0xE8,
                    0xDF
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMVideoDecimationProperties
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x30, 0x29, 0xD3, 0x60,
                    0xDA, 0x13,
                    0xD3, 0x11,
                    0x9E,
                    0xC6,
                    0xC4,
                    0xFC,
                    0xAE,
                    0xF5,
                    0xC7,
                    0xBE
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IVideoFrameStep
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x87, 0x97, 0x6A, 0xE4,
                    0x71, 0x2B,
                    0x4D, 0x44,
                    0xA4,
                    0xB5,
                    0x1F,
                    0xAB,
                    0x7B,
                    0x70,
                    0x8D,
                    0x6A
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMLatency
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBA, 0x93, 0xEA, 0x62,
                    0x62, 0xEC,
                    0xD2, 0x11,
                    0xB7,
                    0x70,
                    0x00,
                    0xC0,
                    0x4F,
                    0xB6,
                    0xBD,
                    0x3D
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMPushSource
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x76, 0xFE, 0x85, 0xF1,
                    0x4E, 0xE6,
                    0xD2, 0x11,
                    0xB7,
                    0x6E,
                    0x00,
                    0xC0,
                    0x4F,
                    0xB6,
                    0xBD,
                    0x3D
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMDeviceRemoval
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x30, 0x61, 0x0A, 0xF9,
                    0x58, 0xB6,
                    0xD2, 0x11,
                    0xAE,
                    0x49,
                    0x00,
                    0x00,
                    0xF8,
                    0x75,
                    0x4B,
                    0x99
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDVEnc
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0x17, 0x8E, 0xD1,
                    0xCB, 0xAA,
                    0xD0, 0x11,
                    0xAF,
                    0xB0,
                    0x00,
                    0xAA,
                    0x00,
                    0xB6,
                    0x7A,
                    0x42
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IIPDVDec
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x60, 0xBD, 0xE8, 0xB8,
                    0xFE, 0x0B,
                    0xD0, 0x11,
                    0xAF,
                    0x91,
                    0x00,
                    0xAA,
                    0x00,
                    0xB6,
                    0x7A,
                    0x42
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDVRGB219
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x19, 0x3A, 0x47, 0x58,
                    0xC8, 0x2B,
                    0x63, 0x46,
                    0x80,
                    0x12,
                    0x25,
                    0xF8,
                    0x1B,
                    0xAB,
                    0xDD,
                    0xD1
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDVSplitter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x02, 0xA3, 0xA3, 0x92,
                    0x7C, 0xDA,
                    0x1F, 0x4A,
                    0xBA,
                    0x7E,
                    0x18,
                    0x02,
                    0xBB,
                    0x5D,
                    0x2D,
                    0x02
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMAudioRendererStats
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB2, 0x0C, 0x32, 0x22,
                    0x1A, 0xD4,
                    0xD2, 0x11,
                    0xBF,
                    0x7C,
                    0xD7,
                    0xCB,
                    0x9D,
                    0xF0,
                    0xBF,
                    0x93
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMGraphStreams
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFA, 0x05, 0x21, 0x63,
                    0x2E, 0x07,
                    0xD3, 0x11,
                    0x8A,
                    0xF9,
                    0x00,
                    0xC0,
                    0x4F,
                    0xB6,
                    0xBD,
                    0x3D
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMOverlayFX
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0xE2, 0xFA, 0x62,
                    0x65, 0x7E,
                    0x60, 0x44,
                    0xBF,
                    0xC9,
                    0x63,
                    0x98,
                    0xB3,
                    0x22,
                    0x07,
                    0x3C
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMOpenProgress
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA1, 0x39, 0x1C, 0x8E,
                    0x53, 0xDE,
                    0xCF, 0x11,
                    0xAA,
                    0x63,
                    0x00,
                    0x80,
                    0xC7,
                    0x44,
                    0x52,
                    0x8D
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMpeg2Demultiplexer
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9C, 0xEE, 0x6E, 0x43,
                    0x4F, 0x26,
                    0x42, 0x42,
                    0x90,
                    0xE1,
                    0x4E,
                    0x33,
                    0x0C,
                    0x10,
                    0x75,
                    0x12
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IEnumStreamIdMap
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x66, 0x15, 0x5C, 0x94,
                    0x02, 0x62,
                    0xFC, 0x46,
                    0x96,
                    0xC7,
                    0xD8,
                    0x7F,
                    0x28,
                    0x9C,
                    0x65,
                    0x34
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMPEG2StreamIdMap
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x47, 0x4C, 0xE0, 0xD0,
                    0xB8, 0x25,
                    0x69, 0x43,
                    0x92,
                    0x5A,
                    0x36,
                    0x2A,
                    0x01,
                    0xD9,
                    0x54,
                    0x44
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IRegisterServiceProvider
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x01, 0x2F, 0x3A, 0x7B,
                    0x51, 0x07,
                    0xDD, 0x48,
                    0xB5,
                    0x56,
                    0x00,
                    0x47,
                    0x85,
                    0x17,
                    0x1C,
                    0x54
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMClockSlave
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x41, 0x27, 0xD5, 0x9F,
                    0x6D, 0x17,
                    0x36, 0x4B,
                    0x8F,
                    0x51,
                    0xCA,
                    0x8F,
                    0x93,
                    0x32,
                    0x23,
                    0xBE
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMGraphBuilderCallback
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x11, 0xF5, 0x95, 0x49,
                    0xDB, 0x9D,
                    0x12, 0x4F,
                    0xBD,
                    0x3B,
                    0xF0,
                    0x46,
                    0x11,
                    0x80,
                    0x7B,
                    0x79
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IGetCapabilitiesKey
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x22, 0x92, 0x80, 0xA8,
                    0xBB, 0x07,
                    0xEA, 0x48,
                    0x95,
                    0x1C,
                    0x33,
                    0x15,
                    0x81,
                    0x00,
                    0x62,
                    0x5B
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IEncoderAPI
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x39, 0x38, 0x42, 0x70,
                    0xCC, 0x6A,
                    0x23, 0x4B,
                    0xB0,
                    0x79,
                    0x21,
                    0xDB,
                    0xF0,
                    0x81,
                    0x56,
                    0xA5
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IVideoEncoder
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3B, 0x7C, 0x99, 0x02,
                    0x1B, 0x8E,
                    0x0E, 0x46,
                    0x92,
                    0x70,
                    0x54,
                    0x5E,
                    0x0D,
                    0xE9,
                    0x56,
                    0x3E
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMDecoderCaps
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x67, 0xF4, 0xDF, 0xC0,
                    0x99, 0xD4,
                    0x86, 0x49,
                    0x97,
                    0x2B,
                    0xE1,
                    0xD9,
                    0x09,
                    0x0F,
                    0xA9,
                    0x41
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMCertifiedOutputProtection
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3E, 0xED, 0xED, 0x6F,
                    0xF1, 0x0F,
                    0x01, 0x49,
                    0xA2,
                    0xF1,
                    0x43,
                    0xF7,
                    0x01,
                    0x2C,
                    0x85,
                    0x15
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMAsyncReaderTimestampScaling
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFC, 0x26, 0x7B, 0xCF,
                    0x00, 0x9A,
                    0x5B, 0x48,
                    0x81,
                    0x47,
                    0x3E,
                    0x78,
                    0x9D,
                    0x5E,
                    0x8F,
                    0x67
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAMPluginControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x81, 0xA1, 0x26, 0x0E,
                    0x0C, 0xF4,
                    0x35, 0x46,
                    0x87,
                    0x86,
                    0x97,
                    0x62,
                    0x84,
                    0xB5,
                    0x29,
                    0x81
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IPinConnection
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD3, 0x62, 0x9A, 0x4A,
                    0xD4, 0x27,
                    0x3D, 0x40,
                    0x91,
                    0xE9,
                    0x89,
                    0xF5,
                    0x40,
                    0xE5,
                    0x55,
                    0x34
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IPinFlowControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x58, 0x98, 0x6E, 0xC5,
                    0xF3, 0xDB,
                    0x6B, 0x4F,
                    0x81,
                    0x19,
                    0x38,
                    0x4A,
                    0xF2,
                    0x06,
                    0x0D,
                    0xEB
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IGraphConfig
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8E, 0xEB, 0xA1, 0x03,
                    0xBF, 0x32,
                    0x45, 0x42,
                    0x85,
                    0x02,
                    0x11,
                    0x4D,
                    0x08,
                    0xA9,
                    0xCB,
                    0x88
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IGraphConfigCallback
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x60, 0xFD, 0xE0, 0xAD,
                    0x9D, 0xD1,
                    0xD2, 0x11,
                    0xAB,
                    0xF6,
                    0x00,
                    0xA0,
                    0xC9,
                    0x05,
                    0xF3,
                    0x75
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IFilterChain
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF6, 0xDC, 0xFB, 0xDC,
                    0xC2, 0x0D,
                    0xF5, 0x45,
                    0x9A,
                    0xB2,
                    0x7C,
                    0x33,
                    0x0E,
                    0xA0,
                    0x9C,
                    0x29
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IVMRImagePresenter
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE7, 0x4F, 0x70, 0xCE,
                    0x1E, 0xE7,
                    0xFB, 0x41,
                    0xBA,
                    0xA2,
                    0xC4,
                    0x40,
                    0x3E,
                    0x11,
                    0x82,
                    0xF5
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IVMRSurfaceAllocator
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2E, 0x83, 0xCE, 0x31,
                    0x84, 0x44,
                    0x8B, 0x45,
                    0x8C,
                    0xCA,
                    0xF4,
                    0xD7,
                    0xE3,
                    0xDB,
                    0x0B,
                    0x52
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IVMRSurfaceAllocatorNotify
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA8, 0x05, 0xDA, 0xAA,
                    0x4E, 0x5A,
                    0x29, 0x47,
                    0xAF,
                    0x0B,
                    0xCE,
                    0xA2,
                    0x7A,
                    0xED,
                    0x51,
                    0xE2
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IVMRWindowlessControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8C, 0x08, 0xB1, 0x0E,
                    0xCD, 0x4D,
                    0xF0, 0x46,
                    0x87,
                    0x8F,
                    0x39,
                    0xDA,
                    0xE8,
                    0x6A,
                    0x51,
                    0xB7
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IVMRMixerControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB0, 0x17, 0x1A, 0x1C,
                    0xD0, 0xBE,
                    0x5D, 0x41,
                    0x97,
                    0x4B,
                    0xDC,
                    0x66,
                    0x96,
                    0x13,
                    0x15,
                    0x99
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IVMRMonitorConfig
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB6, 0xB1, 0xF0, 0x9C,
                    0xAA, 0xFB,
                    0x7F, 0x4B,
                    0x88,
                    0xCF,
                    0xCF,
                    0x1F,
                    0x13,
                    0x0A,
                    0x0D,
                    0xCE
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IVMRFilterConfig
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC5, 0x30, 0x55, 0x9E,
                    0x34, 0x70,
                    0xB4, 0x48,
                    0xBB,
                    0x46,
                    0x0B,
                    0x8A,
                    0x6E,
                    0xFC,
                    0x8E,
                    0x36
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IVMRAspectRatioControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5C, 0x0B, 0xE8, 0xED,
                    0xD6, 0xBA,
                    0x23, 0x46,
                    0xB5,
                    0x37,
                    0x65,
                    0x58,
                    0x6C,
                    0x9F,
                    0x8D,
                    0xFD
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IVMRDeinterlaceControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x77, 0x75, 0x05, 0xBB,
                    0xB8, 0x0D,
                    0x6A, 0x4E,
                    0x87,
                    0xA7,
                    0x1A,
                    0x8C,
                    0x9A,
                    0x50,
                    0x5A,
                    0x0F
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IVMRMixerBitmap
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x75, 0x32, 0x67, 0x1E,
                    0x57, 0x02,
                    0xAA, 0x40,
                    0xAF,
                    0x20,
                    0x7C,
                    0x60,
                    0x8D,
                    0x4A,
                    0x04,
                    0x28
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IVMRImageCompositor
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAF, 0xB5, 0x4F, 0x7A,
                    0x9F, 0x47,
                    0x74, 0x40,
                    0xBB,
                    0x40,
                    0xCE,
                    0x67,
                    0x22,
                    0xE4,
                    0x3C,
                    0x82
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IVMRVideoStreamControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x11, 0x1F, 0x8D, 0x05,
                    0x54, 0x2A,
                    0xEF, 0x4B,
                    0xBD,
                    0x54,
                    0xDF,
                    0x70,
                    0x66,
                    0x26,
                    0xB7,
                    0x27
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IVMRSurface
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBE, 0x9B, 0x84, 0xA9,
                    0xC8, 0x9E,
                    0x63, 0x42,
                    0xB7,
                    0x64,
                    0x62,
                    0x73,
                    0x0F,
                    0x0D,
                    0x15,
                    0xD0
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IVMRImagePresenterConfig
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x85, 0x1C, 0x3A, 0x9F,
                    0x55, 0x85,
                    0xBA, 0x49,
                    0x93,
                    0x5F,
                    0xBE,
                    0x5B,
                    0x5B,
                    0x29,
                    0xD1,
                    0x78
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IVMRImagePresenterExclModeConfig
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0xCE, 0xF7, 0xE6,
                    0x73, 0x46,
                    0xF1, 0x44,
                    0x8F,
                    0x77,
                    0x54,
                    0x99,
                    0xD6,
                    0x8C,
                    0xB4,
                    0xEA
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IVPManager
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x18, 0x8C, 0xC1, 0xAA,
                    0x86, 0xE1,
                    0xD2, 0x46,
                    0x82,
                    0x5D,
                    0xA1,
                    0xF8,
                    0xDC,
                    0x8E,
                    0x39,
                    0x5A
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDvdControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x61, 0xFE, 0x0E, 0xA7,
                    0xA3, 0xE2,
                    0xD0, 0x11,
                    0xA9,
                    0xBE,
                    0x00,
                    0xAA,
                    0x00,
                    0x61,
                    0xBE,
                    0x93
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDvdInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x60, 0xFE, 0x0E, 0xA7,
                    0xA3, 0xE2,
                    0xD0, 0x11,
                    0xA9,
                    0xBE,
                    0x00,
                    0xAA,
                    0x00,
                    0x61,
                    0xBE,
                    0x93
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDvdCmd
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE4, 0x97, 0x4A, 0x5A,
                    0xEE, 0x94,
                    0x55, 0x4A,
                    0x97,
                    0x51,
                    0x74,
                    0xB5,
                    0x64,
                    0x3A,
                    0xA2,
                    0x7D
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDvdState
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6D, 0x3D, 0x30, 0x86,
                    0x4A, 0x1C,
                    0x87, 0x40,
                    0xAB,
                    0x42,
                    0xF7,
                    0x11,
                    0x16,
                    0x70,
                    0x48,
                    0xEF
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDvdControl2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x30, 0x74, 0xBC, 0x33,
                    0xC0, 0xEE,
                    0xD2, 0x11,
                    0x82,
                    0x01,
                    0x00,
                    0xA0,
                    0xC9,
                    0xD7,
                    0x48,
                    0x42
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDvdInfo2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x10, 0x15, 0x15, 0x34,
                    0xC0, 0xEE,
                    0xD2, 0x11,
                    0x82,
                    0x01,
                    0x00,
                    0xA0,
                    0xC9,
                    0xD7,
                    0x48,
                    0x42
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDvdGraphBuilder
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB6, 0x52, 0xC1, 0xFC,
                    0x72, 0xF3,
                    0xD0, 0x11,
                    0x8E,
                    0x00,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD7,
                    0xC0,
                    0x8B
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDDrawExclModeVideo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x21, 0xCC, 0x3A, 0x15,
                    0x3B, 0xD8,
                    0xD1, 0x11,
                    0x82,
                    0xBF,
                    0x00,
                    0xA0,
                    0xC9,
                    0x69,
                    0x6C,
                    0x8F
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDDrawExclModeVideoCallback
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0x24, 0x3C, 0x91,
                    0xAB, 0x20,
                    0xD2, 0x11,
                    0x90,
                    0x38,
                    0x00,
                    0xA0,
                    0xC9,
                    0x69,
                    0x72,
                    0x98
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
