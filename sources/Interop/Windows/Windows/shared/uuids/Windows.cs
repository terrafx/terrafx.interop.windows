// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/uuids.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_None
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8E, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIATYPE_Video
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x76, 0x69, 0x64, 0x73,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIATYPE_Audio
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x61, 0x75, 0x64, 0x73,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIATYPE_Text
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x74, 0x78, 0x74, 0x73,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIATYPE_Midi
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6D, 0x69, 0x64, 0x73,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIATYPE_Stream
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x83, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIATYPE_Interleaved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x69, 0x61, 0x76, 0x73,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIATYPE_File
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x66, 0x69, 0x6C, 0x65,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIATYPE_ScriptCommand
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0x6D, 0x63, 0x73,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIATYPE_AUXLine21Data
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0xEA, 0x0A, 0x67,
                    0x82, 0x3A,
                    0xD0, 0x11,
                    0xB7,
                    0x9B,
                    0x00,
                    0xAA,
                    0x00,
                    0x37,
                    0x67,
                    0xA7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIATYPE_AUXTeletextPage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCB, 0x4A, 0x26, 0x11,
                    0xDE, 0x37,
                    0xBA, 0x4E,
                    0x8C,
                    0x35,
                    0x7F,
                    0x04,
                    0xA1,
                    0xA6,
                    0x83,
                    0x32
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIATYPE_CC_CONTAINER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE9, 0x12, 0xB3, 0xAE,
                    0x57, 0x33,
                    0xCA, 0x43,
                    0xB7,
                    0x01,
                    0x97,
                    0xEC,
                    0x19,
                    0x8E,
                    0x2B,
                    0x62
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIATYPE_DTVCCData
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x52, 0xE1, 0x77, 0xFB,
                    0xB2, 0x53,
                    0x9C, 0x49,
                    0xB4,
                    0x6B,
                    0x50,
                    0x9F,
                    0xC3,
                    0x3E,
                    0xDF,
                    0xD7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIATYPE_MSTVCaption
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x89, 0x8A, 0x8B, 0xB8,
                    0x49, 0xB0,
                    0x80, 0x4C,
                    0xAD,
                    0xCF,
                    0x58,
                    0x98,
                    0x98,
                    0x5E,
                    0x22,
                    0xC1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIATYPE_VBI
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE1, 0x76, 0x2A, 0xF7,
                    0x0A, 0xEB,
                    0xD0, 0x11,
                    0xAC,
                    0xE4,
                    0x00,
                    0x00,
                    0xC0,
                    0xCC,
                    0x16,
                    0xBA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_DVB_SUBTITLES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC3, 0xCB, 0xFF, 0x34,
                    0xB3, 0xD5,
                    0x71, 0x41,
                    0x90,
                    0x02,
                    0xD4,
                    0xC6,
                    0x03,
                    0x01,
                    0x69,
                    0x7F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_ISDB_CAPTIONS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7D, 0xD6, 0x9D, 0x05,
                    0x55, 0x2E,
                    0x41, 0x4D,
                    0x8D,
                    0x1B,
                    0x01,
                    0xF5,
                    0xE4,
                    0xF5,
                    0x06,
                    0x07
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_ISDB_SUPERIMPOSE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x28, 0x6D, 0xDC, 0x36,
                    0xA6, 0xF1,
                    0x16, 0x42,
                    0x90,
                    0x48,
                    0x9C,
                    0xFC,
                    0xEF,
                    0xEB,
                    0x5E,
                    0xBA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIATYPE_Timecode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE3, 0xDE, 0x82, 0x04,
                    0x17, 0x78,
                    0xCF, 0x11,
                    0x8A,
                    0x03,
                    0x00,
                    0xAA,
                    0x00,
                    0x6E,
                    0xCB,
                    0x65
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIATYPE_LMRT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6D, 0x6C, 0x72, 0x74,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIATYPE_URL_STREAM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x75, 0x72, 0x6C, 0x73,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_CLPL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x43, 0x4C, 0x50, 0x4C,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_YUYV
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x55, 0x59, 0x56,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_IYUV
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x49, 0x59, 0x55, 0x56,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_YVU9
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x56, 0x55, 0x39,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_Y411
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x34, 0x31, 0x31,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_Y41P
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x34, 0x31, 0x50,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_YUY2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x55, 0x59, 0x32,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_YVYU
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x56, 0x59, 0x55,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_UYVY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x55, 0x59, 0x56, 0x59,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_Y211
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x32, 0x31, 0x31,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_CLJR
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x43, 0x4C, 0x4A, 0x52,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_IF09
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x49, 0x46, 0x30, 0x39,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_CPLA
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x43, 0x50, 0x4C, 0x41,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_MJPG
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4D, 0x4A, 0x50, 0x47,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_TVMJ
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x54, 0x56, 0x4D, 0x4A,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_WAKE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x57, 0x41, 0x4B, 0x45,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_CFCC
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x43, 0x46, 0x43, 0x43,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_IJPG
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x49, 0x4A, 0x50, 0x47,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_Plum
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x6C, 0x75, 0x6D,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_DVCS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x44, 0x56, 0x43, 0x53,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_H264
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x48, 0x32, 0x36, 0x34,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_DVSD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x44, 0x56, 0x53, 0x44,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_MDVF
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4D, 0x44, 0x56, 0x46,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_RGB1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x78, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_RGB4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x79, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_RGB8
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7A, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_RGB565
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7B, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_RGB555
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7C, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_RGB24
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7D, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_RGB32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7E, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_ARGB1555
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAF, 0x55, 0x7C, 0x29,
                    0x09, 0xE2,
                    0xB3, 0x4C,
                    0xB7,
                    0x57,
                    0xC7,
                    0x6D,
                    0x6B,
                    0x9C,
                    0x88,
                    0xA8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_ARGB4444
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE6, 0x15, 0x64, 0x6E,
                    0x24, 0x5C,
                    0x5F, 0x42,
                    0x93,
                    0xCD,
                    0x80,
                    0x10,
                    0x2B,
                    0x3D,
                    0x1C,
                    0xCA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_ARGB32
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC0, 0x9A, 0x3C, 0x77,
                    0x74, 0x32,
                    0xD0, 0x11,
                    0xB7,
                    0x24,
                    0x00,
                    0xAA,
                    0x00,
                    0x6C,
                    0x1A,
                    0x01
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_A2R10G10B10
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6D, 0xB7, 0x8B, 0x2F,
                    0x44, 0xB6,
                    0x50, 0x45,
                    0xAC,
                    0xF3,
                    0xD3,
                    0x0C,
                    0xAA,
                    0x65,
                    0xD5,
                    0xC5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_A2B10G10R10
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x93, 0x78, 0x6F, 0x57,
                    0xF6, 0xBD,
                    0xC4, 0x48,
                    0x87,
                    0x5F,
                    0xAE,
                    0x7B,
                    0x81,
                    0x83,
                    0x45,
                    0x67
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_AYUV
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x41, 0x59, 0x55, 0x56,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_AI44
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x41, 0x49, 0x34, 0x34,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_IA44
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x49, 0x41, 0x34, 0x34,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_RGB32_D3D_DX7_RT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x37, 0x52, 0x33, 0x32,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_RGB16_D3D_DX7_RT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x37, 0x52, 0x31, 0x36,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_ARGB32_D3D_DX7_RT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x37, 0x41, 0x38, 0x38,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_ARGB4444_D3D_DX7_RT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x37, 0x41, 0x34, 0x34,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_ARGB1555_D3D_DX7_RT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x37, 0x41, 0x31, 0x35,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_RGB32_D3D_DX9_RT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x39, 0x52, 0x33, 0x32,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_RGB16_D3D_DX9_RT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x39, 0x52, 0x31, 0x36,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_ARGB32_D3D_DX9_RT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x39, 0x41, 0x38, 0x38,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_ARGB4444_D3D_DX9_RT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x39, 0x41, 0x34, 0x34,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_ARGB1555_D3D_DX9_RT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x39, 0x41, 0x31, 0x35,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_YV12
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x56, 0x31, 0x32,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_NV12
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4E, 0x56, 0x31, 0x32,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_NV11
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4E, 0x56, 0x31, 0x31,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_P208
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x32, 0x30, 0x38,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_P210
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x32, 0x31, 0x30,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_P216
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x32, 0x31, 0x36,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_P010
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x30, 0x31, 0x30,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_P016
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x30, 0x31, 0x36,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_Y210
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x32, 0x31, 0x30,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_Y216
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x32, 0x31, 0x36,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_P408
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x34, 0x30, 0x38,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_NV24
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4E, 0x56, 0x32, 0x34,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_420O
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x34, 0x32, 0x30, 0x4F,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_IMC1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x49, 0x4D, 0x43, 0x31,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_IMC2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x49, 0x4D, 0x43, 0x32,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_IMC3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x49, 0x4D, 0x43, 0x33,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_IMC4
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x49, 0x4D, 0x43, 0x34,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_S340
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x53, 0x33, 0x34, 0x30,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_S342
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x53, 0x33, 0x34, 0x32,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_Overlay
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7F, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_MPEG1Packet
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_MPEG1Payload
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x81, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_MPEG1AudioPayload
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIATYPE_MPEG1SystemStream
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x82, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_MPEG1System
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x84, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_MPEG1VideoCD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x85, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_MPEG1Video
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x86, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_MPEG1Audio
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x87, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_Avi
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x88, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_Asf
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x90, 0x0F, 0xB8, 0x3D,
                    0x12, 0x94,
                    0xD1, 0x11,
                    0xAD,
                    0xED,
                    0x00,
                    0x00,
                    0xF8,
                    0x75,
                    0x4B,
                    0x99
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_QTMovie
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x89, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_QTRpza
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x72, 0x70, 0x7A, 0x61,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_QTSmc
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x73, 0x6D, 0x63, 0x20,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_QTRle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x72, 0x6C, 0x65, 0x20,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_QTJpeg
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6A, 0x70, 0x65, 0x67,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_PCMAudio_Obsolete
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8A, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_PCM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x01, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_WAVE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8B, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_AU
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8C, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_AIFF
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8D, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_dvsd
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0x76, 0x73, 0x64,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_dvhd
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0x76, 0x68, 0x64,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_dvsl
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0x76, 0x73, 0x6C,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_dv25
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0x76, 0x32, 0x35,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_dv50
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0x76, 0x35, 0x30,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_dvh1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0x76, 0x68, 0x31,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_Line21_BytePair
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x22, 0x4A, 0x8D, 0x6E,
                    0x0C, 0x31,
                    0xD0, 0x11,
                    0xB7,
                    0x9A,
                    0x00,
                    0xAA,
                    0x00,
                    0x37,
                    0x67,
                    0xA7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_Line21_GOPPacket
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x23, 0x4A, 0x8D, 0x6E,
                    0x0C, 0x31,
                    0xD0, 0x11,
                    0xB7,
                    0x9A,
                    0x00,
                    0xAA,
                    0x00,
                    0x37,
                    0x67,
                    0xA7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_Line21_VBIRawData
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0x4A, 0x8D, 0x6E,
                    0x0C, 0x31,
                    0xD0, 0x11,
                    0xB7,
                    0x9A,
                    0x00,
                    0xAA,
                    0x00,
                    0x37,
                    0x67,
                    0xA7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_708_608Data
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBC, 0x14, 0xF4, 0x0A,
                    0xD2, 0x4E,
                    0x5E, 0x44,
                    0x98,
                    0x39,
                    0x8F,
                    0x09,
                    0x55,
                    0x68,
                    0xAB,
                    0x3C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_DtvCcData
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAA, 0xDD, 0x2A, 0xF5,
                    0xF0, 0x36,
                    0xF5, 0x43,
                    0x95,
                    0xEA,
                    0x6D,
                    0x86,
                    0x64,
                    0x84,
                    0x26,
                    0x2A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_CC_CONTAINER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDB, 0x26, 0xA6, 0x7E,
                    0xDA, 0x54,
                    0x7B, 0x43,
                    0xBE,
                    0x9F,
                    0xF7,
                    0x30,
                    0x73,
                    0xAD,
                    0xFA,
                    0x3C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_TELETEXT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE3, 0x76, 0x2A, 0xF7,
                    0x0A, 0xEB,
                    0xD0, 0x11,
                    0xAC,
                    0xE4,
                    0x00,
                    0x00,
                    0xC0,
                    0xCC,
                    0x16,
                    0xBA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_VBI
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3C, 0xA4, 0x3D, 0x66,
                    0xE8, 0x03,
                    0x9A, 0x4E,
                    0x9C,
                    0xD5,
                    0xBF,
                    0x11,
                    0xED,
                    0x0D,
                    0xEF,
                    0x76
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_WSS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x76, 0xD5, 0x91, 0x27,
                    0x7A, 0x8E,
                    0x6F, 0x46,
                    0x9E,
                    0x90,
                    0x5D,
                    0x3F,
                    0x30,
                    0x83,
                    0x73,
                    0x8B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_XDS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE3, 0x73, 0xCA, 0x01,
                    0xE6, 0xDC,
                    0x75, 0x45,
                    0xAF,
                    0xE1,
                    0x2B,
                    0xF1,
                    0xC9,
                    0x02,
                    0xCA,
                    0xF3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_VPS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x20, 0xF6, 0xB3, 0xA1,
                    0x92, 0x97,
                    0x8D, 0x4D,
                    0x81,
                    0xA4,
                    0x86,
                    0xAF,
                    0x25,
                    0x77,
                    0x20,
                    0x90
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_DRM_Audio
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x09, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_IEEE_FLOAT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x03, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_DOLBY_AC3_SPDIF
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x92, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_RAW_SPORT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0x02, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_SPDIF_TAG_241h
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x41, 0x02, 0x00, 0x00,
                    0x00, 0x00,
                    0x10, 0x00,
                    0x80,
                    0x00,
                    0x00,
                    0xAA,
                    0x00,
                    0x38,
                    0x9B,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_DssVideo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x81, 0x4F, 0xAF, 0xA0,
                    0x63, 0xE1,
                    0xD0, 0x11,
                    0xBA,
                    0xD9,
                    0x00,
                    0x60,
                    0x97,
                    0x44,
                    0x11,
                    0x1A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_DssAudio
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x82, 0x4F, 0xAF, 0xA0,
                    0x63, 0xE1,
                    0xD0, 0x11,
                    0xBA,
                    0xD9,
                    0x00,
                    0x60,
                    0x97,
                    0x44,
                    0x11,
                    0x1A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_VPVideo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0x6A, 0x9B, 0x5A,
                    0x22, 0x1A,
                    0xD1, 0x11,
                    0xBA,
                    0xD9,
                    0x00,
                    0x60,
                    0x97,
                    0x44,
                    0x11,
                    0x1A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_VPVBI
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x41, 0x6A, 0x9B, 0x5A,
                    0x22, 0x1A,
                    0xD1, 0x11,
                    0xBA,
                    0xD9,
                    0x00,
                    0x60,
                    0x97,
                    0x44,
                    0x11,
                    0x1A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_CaptureGraphBuilder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_CaptureGraphBuilder2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE1, 0xB6, 0x87, 0xBF,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_ProtoFilterGraph
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB0, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_SystemClock
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB1, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_FilterMapper
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB2, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_FilterGraph
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB3, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_FilterGraphNoThread
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB8, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_FilterGraphPrivateThread
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x41, 0xBC, 0xEC, 0xA3,
                    0x1A, 0x58,
                    0x76, 0x44,
                    0xB6,
                    0x93,
                    0xA6,
                    0x33,
                    0x40,
                    0x46,
                    0x2D,
                    0x8B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_MPEG1Doc
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x60, 0xD1, 0xBB, 0xE4,
                    0x69, 0x42,
                    0xCE, 0x11,
                    0x83,
                    0x8D,
                    0x00,
                    0xAA,
                    0x00,
                    0x55,
                    0x59,
                    0x5A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_FileSource
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE0, 0x22, 0x17, 0x70,
                    0xE3, 0x8A,
                    0xCE, 0x11,
                    0xA8,
                    0x5C,
                    0x00,
                    0xAA,
                    0x00,
                    0x2F,
                    0xEA,
                    0xB5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_MPEG1PacketPlayer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0x59, 0xC2, 0x26,
                    0xA9, 0x4C,
                    0xCE, 0x11,
                    0xA8,
                    0x28,
                    0x00,
                    0xAA,
                    0x00,
                    0x2F,
                    0xEA,
                    0xB5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_MPEG1Splitter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD0, 0x75, 0x64, 0x33,
                    0x2A, 0x94,
                    0xCE, 0x11,
                    0xA8,
                    0x70,
                    0x00,
                    0xAA,
                    0x00,
                    0x2F,
                    0xEA,
                    0xB5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_CMpegVideoCodec
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0x07, 0xB5, 0xFE,
                    0xEF, 0x7B,
                    0xCE, 0x11,
                    0x9B,
                    0xD9,
                    0x00,
                    0x00,
                    0xE2,
                    0x02,
                    0x59,
                    0x9C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_CMpegAudioCodec
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE0, 0x86, 0x22, 0x4A,
                    0xEF, 0x7B,
                    0xCE, 0x11,
                    0x9B,
                    0xD9,
                    0x00,
                    0x00,
                    0xE2,
                    0x02,
                    0x59,
                    0x9C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_TextRender
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD3, 0x29, 0x06, 0xE3,
                    0xE5, 0x27,
                    0xCE, 0x11,
                    0x87,
                    0x5D,
                    0x00,
                    0x60,
                    0x8C,
                    0xB7,
                    0x80,
                    0x66
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_InfTee
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0x8A, 0x38, 0xF8,
                    0xBB, 0xD5,
                    0xD0, 0x11,
                    0xBE,
                    0x5A,
                    0x00,
                    0x80,
                    0xC7,
                    0x06,
                    0x56,
                    0x8E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_AviSplitter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x20, 0x4C, 0x54, 0x1B,
                    0x0B, 0xFD,
                    0xCE, 0x11,
                    0x8C,
                    0x63,
                    0x00,
                    0xAA,
                    0x00,
                    0x44,
                    0xB5,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_AviReader
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x21, 0x4C, 0x54, 0x1B,
                    0x0B, 0xFD,
                    0xCE, 0x11,
                    0x8C,
                    0x63,
                    0x00,
                    0xAA,
                    0x00,
                    0x44,
                    0xB5,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_VfwCapture
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x22, 0x4C, 0x54, 0x1B,
                    0x0B, 0xFD,
                    0xCE, 0x11,
                    0x8C,
                    0x63,
                    0x00,
                    0xAA,
                    0x00,
                    0x44,
                    0xB5,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_CaptureProperties
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x22, 0x4C, 0x54, 0x1B,
                    0x0B, 0xFD,
                    0xCE, 0x11,
                    0x8C,
                    0x63,
                    0x00,
                    0xAA,
                    0x00,
                    0x44,
                    0xB5,
                    0x1F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_FGControl
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB4, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_MOVReader
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x48, 0x58, 0x44,
                    0xEE, 0xF8,
                    0xCE, 0x11,
                    0xB2,
                    0xD4,
                    0x00,
                    0xDD,
                    0x01,
                    0x10,
                    0x1B,
                    0x85
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_QuickTimeParser
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0xD5, 0x1B, 0xD5,
                    0x48, 0x75,
                    0xCF, 0x11,
                    0xA5,
                    0x20,
                    0x00,
                    0x80,
                    0xC7,
                    0x7E,
                    0xF5,
                    0x8A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_QTDec
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x81, 0x96, 0xFE, 0xFD,
                    0xA3, 0x74,
                    0xD0, 0x11,
                    0xAF,
                    0xA7,
                    0x00,
                    0xAA,
                    0x00,
                    0xB6,
                    0x7A,
                    0x42
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_AVIDoc
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB0, 0x8A, 0x58, 0xD3,
                    0x81, 0x07,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_VideoRenderer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB0, 0x02, 0xE1, 0x70,
                    0x56, 0x55,
                    0xCE, 0x11,
                    0x97,
                    0xC0,
                    0x00,
                    0xAA,
                    0x00,
                    0x55,
                    0x59,
                    0x5A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_Colour
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0xE1, 0x43, 0x16,
                    0xF5, 0x90,
                    0xCE, 0x11,
                    0x97,
                    0xD5,
                    0x00,
                    0xAA,
                    0x00,
                    0x55,
                    0x59,
                    0x5A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_Dither
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x85, 0xA0, 0x1D,
                    0xDC, 0x9E,
                    0xCF, 0x11,
                    0xBC,
                    0x10,
                    0x00,
                    0xAA,
                    0x00,
                    0xAC,
                    0x74,
                    0xF6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_ModexRenderer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x65, 0x76, 0x16, 0x07,
                    0x11, 0x50,
                    0xCF, 0x11,
                    0xBF,
                    0x33,
                    0x00,
                    0xAA,
                    0x00,
                    0x55,
                    0x59,
                    0x5A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_AudioRender
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD1, 0x29, 0x06, 0xE3,
                    0xE5, 0x27,
                    0xCE, 0x11,
                    0x87,
                    0x5D,
                    0x00,
                    0x60,
                    0x8C,
                    0xB7,
                    0x80,
                    0x66
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_AudioProperties
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAF, 0x9F, 0x58, 0x05,
                    0x56, 0xC3,
                    0xCE, 0x11,
                    0xBF,
                    0x01,
                    0x00,
                    0xAA,
                    0x00,
                    0x55,
                    0x59,
                    0x5A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DSoundRender
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x20, 0x68, 0x37, 0x79,
                    0xD0, 0x07,
                    0xCF, 0x11,
                    0xA2,
                    0x4D,
                    0x00,
                    0x20,
                    0xAF,
                    0xD7,
                    0x97,
                    0x67
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_AudioRecord
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD2, 0x29, 0x06, 0xE3,
                    0xE5, 0x27,
                    0xCE, 0x11,
                    0x87,
                    0x5D,
                    0x00,
                    0x60,
                    0x8C,
                    0xB7,
                    0x80,
                    0x66
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_AudioInputMixerProperties
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x52, 0xCA, 0xA8, 0x2C,
                    0x3F, 0x3C,
                    0xD2, 0x11,
                    0xB7,
                    0x3D,
                    0x00,
                    0xC0,
                    0x4F,
                    0xB6,
                    0xBD,
                    0x3D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_AVIDec
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE0, 0xD4, 0x49, 0xCF,
                    0x15, 0x11,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_AVIDraw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x60, 0xDF, 0x88, 0xA8,
                    0x90, 0x1E,
                    0xCF, 0x11,
                    0xAC,
                    0x98,
                    0x00,
                    0xAA,
                    0x00,
                    0x4C,
                    0x0F,
                    0xA9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_ACMWrapper
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0xCF, 0x08, 0x6A,
                    0x18, 0x0E,
                    0xCF, 0x11,
                    0xA2,
                    0x4D,
                    0x00,
                    0x20,
                    0xAF,
                    0xD7,
                    0x97,
                    0x67
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_AsyncReader
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB5, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_URLReader
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB6, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_PersistMonikerPID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB7, 0xEB, 0x36, 0xE4,
                    0x4F, 0x52,
                    0xCE, 0x11,
                    0x9F,
                    0x53,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0xA7,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_AVICo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x20, 0x28, 0x6E, 0xD7,
                    0x63, 0x15,
                    0xCF, 0x11,
                    0xAC,
                    0x98,
                    0x00,
                    0xAA,
                    0x00,
                    0x4C,
                    0x0F,
                    0xA9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_FileWriter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF0, 0xE5, 0x96, 0x85,
                    0xA5, 0x0D,
                    0xD0, 0x11,
                    0xBD,
                    0x21,
                    0x00,
                    0xA0,
                    0xC9,
                    0x11,
                    0xCE,
                    0x86
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_AviDest
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x70, 0x09, 0x51, 0xE2,
                    0x37, 0xF1,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_AviMuxProptyPage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC0, 0xB5, 0x47, 0xC6,
                    0x7C, 0x15,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_AviMuxProptyPage1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x10, 0xE9, 0x9A, 0x0A,
                    0xC0, 0x85,
                    0xD0, 0x11,
                    0xBD,
                    0x42,
                    0x00,
                    0xA0,
                    0xC9,
                    0x11,
                    0xCE,
                    0x86
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_AVIMIDIRender
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x60, 0x53, 0xB6, 0x07,
                    0x45, 0xC4,
                    0xCE, 0x11,
                    0xAF,
                    0xDE,
                    0x00,
                    0xAA,
                    0x00,
                    0x6C,
                    0x14,
                    0xF4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WMAsfReader
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0x63, 0x74, 0x18,
                    0xB7, 0x5B,
                    0xD3, 0x11,
                    0xAC,
                    0xBE,
                    0x00,
                    0x80,
                    0xC7,
                    0x5E,
                    0x24,
                    0x6E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WMAsfWriter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0E, 0x22, 0x23, 0x7C,
                    0xBB, 0x55,
                    0xD3, 0x11,
                    0x8B,
                    0x16,
                    0x00,
                    0xC0,
                    0x4F,
                    0xB6,
                    0xBD,
                    0x3D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_MPEG2Demultiplexer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0xC2, 0xB6, 0xAF,
                    0x41, 0x2C,
                    0xD3, 0x11,
                    0x8A,
                    0x60,
                    0x00,
                    0x00,
                    0xF8,
                    0x1E,
                    0x0E,
                    0x4A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_MPEG2Demultiplexer_NoClock
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x67, 0x33, 0x7D, 0x68,
                    0x44, 0x36,
                    0x7A, 0x46,
                    0xAD,
                    0xFE,
                    0x6C,
                    0xD7,
                    0xA8,
                    0x5C,
                    0x4A,
                    0x2C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_MMSPLITTER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x20, 0x6B, 0xE8, 0x3A,
                    0xE8, 0x7B,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_StreamBufferSink
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE5, 0x7A, 0xB4, 0x2D,
                    0x39, 0xCF,
                    0xC2, 0x43,
                    0xB4,
                    0xD6,
                    0x0C,
                    0xD8,
                    0xD9,
                    0x09,
                    0x46,
                    0xF4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_SBE2Sink
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x08, 0x85, 0x44, 0xE2,
                    0xDA, 0x95,
                    0x05, 0x42,
                    0x9A,
                    0x27,
                    0x7E,
                    0xC8,
                    0x1E,
                    0x72,
                    0x3B,
                    0x1A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_StreamBufferSource
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x02, 0xFE, 0xF5, 0xC9,
                    0x51, 0xF8,
                    0xB5, 0x4E,
                    0x99,
                    0xEE,
                    0xAD,
                    0x60,
                    0x2A,
                    0xF1,
                    0xE6,
                    0x19
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_StreamBufferConfig
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB2, 0x68, 0x8A, 0xFA,
                    0x64, 0xC8,
                    0xA2, 0x4B,
                    0xAD,
                    0x53,
                    0xD3,
                    0x87,
                    0x6A,
                    0x87,
                    0x49,
                    0x4B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_StreamBufferPropertyHandler
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF8, 0x73, 0x7A, 0xE3,
                    0x01, 0xFB,
                    0xDC, 0x43,
                    0x91,
                    0x4E,
                    0xAA,
                    0xEE,
                    0x76,
                    0x09,
                    0x5A,
                    0xB9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_StreamBufferThumbnailHandler
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEE, 0x90, 0x37, 0x71,
                    0xE1, 0x5E,
                    0xBA, 0x45,
                    0x80,
                    0x70,
                    0xA1,
                    0x33,
                    0x7D,
                    0x27,
                    0x62,
                    0xFA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_Mpeg2VideoStreamAnalyzer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x61, 0xD7, 0xFA, 0x6C,
                    0x5D, 0x73,
                    0xA5, 0x4A,
                    0x8A,
                    0xFC,
                    0xAF,
                    0x91,
                    0xA7,
                    0xD6,
                    0x1E,
                    0xBA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_StreamBufferRecordingAttributes
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAC, 0x63, 0xAA, 0xCC,
                    0x57, 0x10,
                    0x78, 0x47,
                    0xAE,
                    0x92,
                    0x12,
                    0x06,
                    0xAB,
                    0x9A,
                    0xCE,
                    0xE6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_StreamBufferComposeRecording
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBA, 0xC4, 0x82, 0xD6,
                    0x0A, 0xA9,
                    0xFE, 0x42,
                    0xB9,
                    0xE1,
                    0x03,
                    0x10,
                    0x98,
                    0x49,
                    0xC4,
                    0x23
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_SBE2File
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD7, 0x94, 0xA0, 0x93,
                    0xE8, 0x51,
                    0x5B, 0x48,
                    0x90,
                    0x4A,
                    0x8D,
                    0x6B,
                    0x97,
                    0xDC,
                    0x6B,
                    0x39
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DVVideoCodec
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x7C, 0xB7, 0xB1,
                    0xE4, 0xC3,
                    0xCF, 0x11,
                    0xAF,
                    0x79,
                    0x00,
                    0xAA,
                    0x00,
                    0xB6,
                    0x7A,
                    0x42
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DVVideoEnc
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x36, 0xAA, 0x13,
                    0x6F, 0xBB,
                    0xD0, 0x11,
                    0xAF,
                    0xB9,
                    0x00,
                    0xAA,
                    0x00,
                    0xB6,
                    0x7A,
                    0x42
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DVSplitter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x70, 0x16, 0xB3, 0x4E,
                    0xC6, 0x9F,
                    0xCF, 0x11,
                    0xAF,
                    0x6E,
                    0x00,
                    0xAA,
                    0x00,
                    0xB6,
                    0x7A,
                    0x42
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DVMux
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0x7E, 0x9D, 0x12,
                    0x0D, 0xC1,
                    0xD0, 0x11,
                    0xAF,
                    0xB9,
                    0x00,
                    0xAA,
                    0x00,
                    0xB6,
                    0x7A,
                    0x42
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_SeekingPassThru
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6C, 0xF7, 0x0A, 0x06,
                    0xDD, 0x68,
                    0xD0, 0x11,
                    0x8F,
                    0xC1,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD9,
                    0x18,
                    0x9D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_Line21Decoder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x20, 0x4A, 0x8D, 0x6E,
                    0x0C, 0x31,
                    0xD0, 0x11,
                    0xB7,
                    0x9A,
                    0x00,
                    0xAA,
                    0x00,
                    0x37,
                    0x67,
                    0xA7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_Line21Decoder2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x32, 0x64, 0x20, 0xE4,
                    0xA1, 0x01,
                    0xEE, 0x4B,
                    0xB3,
                    0xE1,
                    0x37,
                    0x02,
                    0xC8,
                    0xED,
                    0xC5,
                    0x74
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_CCAFilter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x39, 0xA5, 0x07, 0x3D,
                    0xCA, 0x35,
                    0x7C, 0x44,
                    0x9B,
                    0x05,
                    0x8D,
                    0x85,
                    0xCE,
                    0x92,
                    0x4F,
                    0x9E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_OverlayMixer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA1, 0x43, 0x87, 0xCD,
                    0x36, 0x37,
                    0xD0, 0x11,
                    0x9E,
                    0x69,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD7,
                    0xC1,
                    0x5B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_VBISurfaces
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x98, 0x4B, 0x81,
                    0x88, 0x1C,
                    0xD1, 0x11,
                    0xBA,
                    0xD9,
                    0x00,
                    0x60,
                    0x97,
                    0x44,
                    0x11,
                    0x1A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WSTDecoder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE0, 0x06, 0xBC, 0x70,
                    0x66, 0x56,
                    0xD3, 0x11,
                    0xA1,
                    0x84,
                    0x00,
                    0x10,
                    0x5A,
                    0xEF,
                    0x9F,
                    0x33
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_MjpegDec
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD0, 0x56, 0x10, 0x30,
                    0xFF, 0x6D,
                    0xD2, 0x11,
                    0x9E,
                    0xEB,
                    0x00,
                    0x60,
                    0x08,
                    0x03,
                    0x9E,
                    0x37
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_MJPGEnc
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0xB0, 0x0A, 0xB8,
                    0x16, 0x74,
                    0xD2, 0x11,
                    0x9E,
                    0xEB,
                    0x00,
                    0x60,
                    0x08,
                    0x03,
                    0x9E,
                    0x37
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_SystemDeviceEnum
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x10, 0x5D, 0xBE, 0x62,
                    0xEB, 0x60,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_CDeviceMoniker
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x37, 0xD4, 0x15, 0x43,
                    0x8C, 0x5B,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_VideoInputDeviceCategory
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x10, 0xB3, 0x0B, 0x86,
                    0x01, 0x5D,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_CVidCapClassManager
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x10, 0xB3, 0x0B, 0x86,
                    0x01, 0x5D,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_LegacyAmFilterCategory
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF1, 0x63, 0x38, 0x08,
                    0xDE, 0x70,
                    0xD0, 0x11,
                    0xBD,
                    0x40,
                    0x00,
                    0xA0,
                    0xC9,
                    0x11,
                    0xCE,
                    0x86
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_CQzFilterClassManager
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF1, 0x63, 0x38, 0x08,
                    0xDE, 0x70,
                    0xD0, 0x11,
                    0xBD,
                    0x40,
                    0x00,
                    0xA0,
                    0xC9,
                    0x11,
                    0xCE,
                    0x86
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_VideoCompressorCategory
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x60, 0xA7, 0xD9, 0x33,
                    0xC8, 0x90,
                    0xD0, 0x11,
                    0xBD,
                    0x43,
                    0x00,
                    0xA0,
                    0xC9,
                    0x11,
                    0xCE,
                    0x86
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_CIcmCoClassManager
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x60, 0xA7, 0xD9, 0x33,
                    0xC8, 0x90,
                    0xD0, 0x11,
                    0xBD,
                    0x43,
                    0x00,
                    0xA0,
                    0xC9,
                    0x11,
                    0xCE,
                    0x86
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_AudioCompressorCategory
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x61, 0xA7, 0xD9, 0x33,
                    0xC8, 0x90,
                    0xD0, 0x11,
                    0xBD,
                    0x43,
                    0x00,
                    0xA0,
                    0xC9,
                    0x11,
                    0xCE,
                    0x86
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_CAcmCoClassManager
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x61, 0xA7, 0xD9, 0x33,
                    0xC8, 0x90,
                    0xD0, 0x11,
                    0xBD,
                    0x43,
                    0x00,
                    0xA0,
                    0xC9,
                    0x11,
                    0xCE,
                    0x86
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_AudioInputDeviceCategory
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x62, 0xA7, 0xD9, 0x33,
                    0xC8, 0x90,
                    0xD0, 0x11,
                    0xBD,
                    0x43,
                    0x00,
                    0xA0,
                    0xC9,
                    0x11,
                    0xCE,
                    0x86
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_CWaveinClassManager
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x62, 0xA7, 0xD9, 0x33,
                    0xC8, 0x90,
                    0xD0, 0x11,
                    0xBD,
                    0x43,
                    0x00,
                    0xA0,
                    0xC9,
                    0x11,
                    0xCE,
                    0x86
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_AudioRendererCategory
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE1, 0x58, 0xF1, 0xE0,
                    0x04, 0xCB,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_CWaveOutClassManager
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE1, 0x58, 0xF1, 0xE0,
                    0x04, 0xCB,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_MidiRendererCategory
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x52, 0x24, 0xFE, 0x4E,
                    0x8A, 0x16,
                    0xD1, 0x11,
                    0xBC,
                    0x76,
                    0x00,
                    0xC0,
                    0x4F,
                    0xB9,
                    0x45,
                    0x3B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_CMidiOutClassManager
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x52, 0x24, 0xFE, 0x4E,
                    0x8A, 0x16,
                    0xD1, 0x11,
                    0xBC,
                    0x76,
                    0x00,
                    0xC0,
                    0x4F,
                    0xB9,
                    0x45,
                    0x3B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_TransmitCategory
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x41, 0xFB, 0x7B, 0xCC,
                    0x75, 0xF1,
                    0xD1, 0x11,
                    0xA3,
                    0x92,
                    0x00,
                    0xE0,
                    0x29,
                    0x1F,
                    0x39,
                    0x59
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DeviceControlCategory
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x46, 0xFB, 0x7B, 0xCC,
                    0x75, 0xF1,
                    0xD1, 0x11,
                    0xA3,
                    0x92,
                    0x00,
                    0xE0,
                    0x29,
                    0x1F,
                    0x39,
                    0x59
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_ActiveMovieCategories
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0x3D, 0x4E, 0xDA,
                    0x7D, 0xD0,
                    0xD0, 0x11,
                    0xBD,
                    0x50,
                    0x00,
                    0xA0,
                    0xC9,
                    0x11,
                    0xCE,
                    0x86
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DVDHWDecodersCategory
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x20, 0xAE, 0x21, 0x27,
                    0x70, 0x7E,
                    0xD0, 0x11,
                    0xA5,
                    0xD6,
                    0x28,
                    0xDB,
                    0x04,
                    0xC1,
                    0x00,
                    0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_MediaEncoderCategory
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x20, 0xE9, 0x22, 0x7D,
                    0xA9, 0x5C,
                    0x87, 0x47,
                    0x8C,
                    0x2B,
                    0xA6,
                    0x77,
                    0x9B,
                    0xD1,
                    0x17,
                    0x81
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_MediaMultiplexerCategory
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x95, 0x6C, 0x23,
                    0xCE, 0xAD,
                    0x36, 0x47,
                    0xBF,
                    0x72,
                    0xBA,
                    0xB3,
                    0x4E,
                    0x39,
                    0x21,
                    0x96
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_FilterMapper2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x22, 0xA4, 0xCD,
                    0x88, 0xBD,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_MemoryAllocator
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC0, 0x1C, 0x65, 0x1E,
                    0x99, 0xB1,
                    0xD0, 0x11,
                    0x82,
                    0x12,
                    0x00,
                    0xC0,
                    0x4F,
                    0xC3,
                    0x2C,
                    0x45
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_MediaPropertyBag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x8D, 0xBD, 0xCD,
                    0x93, 0xC1,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DvdGraphBuilder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB7, 0x52, 0xC1, 0xFC,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DVDNavigator
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x20, 0x46, 0x8C, 0x9B,
                    0x1A, 0x2C,
                    0xD0, 0x11,
                    0x84,
                    0x93,
                    0x00,
                    0xA0,
                    0x24,
                    0x38,
                    0xAD,
                    0x48
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DVDState
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCF, 0xC5, 0x63, 0xF9,
                    0x59, 0xA6,
                    0x93, 0x4A,
                    0x96,
                    0x38,
                    0xCA,
                    0xF3,
                    0xCD,
                    0x27,
                    0x7D,
                    0x13
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_SmartTee
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0xE2, 0x58, 0xCC,
                    0xA1, 0x8A,
                    0xD1, 0x11,
                    0xB3,
                    0xF1,
                    0x00,
                    0xAA,
                    0x00,
                    0x37,
                    0x61,
                    0xC5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DtvCcFilter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0x6B, 0x05, 0xFB,
                    0x02, 0x25,
                    0xB9, 0x45,
                    0x8E,
                    0x86,
                    0x2B,
                    0x40,
                    0xDE,
                    0x84,
                    0xAD,
                    0x29
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_CaptionsFilter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB6, 0xE4, 0x7E, 0x2F,
                    0xF5, 0x6F,
                    0xB4, 0x4E,
                    0xB2,
                    0x4A,
                    0x2B,
                    0xFC,
                    0x41,
                    0x11,
                    0x71,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_SubtitlesFilter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEA, 0xCF, 0x22, 0x9F,
                    0x07, 0xCE,
                    0xAB, 0x41,
                    0x8B,
                    0xA0,
                    0xC7,
                    0x36,
                    0x4A,
                    0xF9,
                    0x0A,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DirectShowPluginControl
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x36, 0xC7, 0x70, 0x86,
                    0x14, 0xF6,
                    0x7B, 0x42,
                    0x8A,
                    0xDA,
                    0xBB,
                    0xAD,
                    0xC5,
                    0x87,
                    0x19,
                    0x4B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FORMAT_None
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD6, 0x17, 0x64, 0x0F,
                    0x18, 0xC3,
                    0xD0, 0x11,
                    0xA4,
                    0x3F,
                    0x00,
                    0xA0,
                    0xC9,
                    0x22,
                    0x31,
                    0x96
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FORMAT_VideoInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0x9F, 0x58, 0x05,
                    0x56, 0xC3,
                    0xCE, 0x11,
                    0xBF,
                    0x01,
                    0x00,
                    0xAA,
                    0x00,
                    0x55,
                    0x59,
                    0x5A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FORMAT_VideoInfo2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0x76, 0x2A, 0xF7,
                    0x0A, 0xEB,
                    0xD0, 0x11,
                    0xAC,
                    0xE4,
                    0x00,
                    0x00,
                    0xC0,
                    0xCC,
                    0x16,
                    0xBA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FORMAT_WaveFormatEx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x81, 0x9F, 0x58, 0x05,
                    0x56, 0xC3,
                    0xCE, 0x11,
                    0xBF,
                    0x01,
                    0x00,
                    0xAA,
                    0x00,
                    0x55,
                    0x59,
                    0x5A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FORMAT_MPEGVideo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x82, 0x9F, 0x58, 0x05,
                    0x56, 0xC3,
                    0xCE, 0x11,
                    0xBF,
                    0x01,
                    0x00,
                    0xAA,
                    0x00,
                    0x55,
                    0x59,
                    0x5A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FORMAT_MPEGStreams
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x83, 0x9F, 0x58, 0x05,
                    0x56, 0xC3,
                    0xCE, 0x11,
                    0xBF,
                    0x01,
                    0x00,
                    0xAA,
                    0x00,
                    0x55,
                    0x59,
                    0x5A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FORMAT_DvInfo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x84, 0x9F, 0x58, 0x05,
                    0x56, 0xC3,
                    0xCE, 0x11,
                    0xBF,
                    0x01,
                    0x00,
                    0xAA,
                    0x00,
                    0x55,
                    0x59,
                    0x5A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FORMAT_525WSS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4D, 0xF0, 0xEC, 0xC7,
                    0x82, 0x45,
                    0x69, 0x48,
                    0x9A,
                    0xBB,
                    0xBF,
                    0xB5,
                    0x23,
                    0xB6,
                    0x2E,
                    0xDF
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DirectDrawProperties
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x4C, 0x4D, 0x94,
                    0x52, 0xDD,
                    0xCE, 0x11,
                    0xBF,
                    0x0E,
                    0x00,
                    0xAA,
                    0x00,
                    0x55,
                    0x59,
                    0x5A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_PerformanceProperties
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0x68, 0xCE, 0x59,
                    0xF8, 0xAC,
                    0xCF, 0x11,
                    0xB5,
                    0x6E,
                    0x00,
                    0x80,
                    0xC7,
                    0xC4,
                    0xB6,
                    0x8A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_QualityProperties
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x70, 0xFB, 0x8A, 0x41,
                    0xB8, 0xF8,
                    0xCE, 0x11,
                    0xAA,
                    0xC6,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0x99,
                    0xA3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IBaseVideoMixer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0xD6, 0xDE, 0x61,
                    0x12, 0xE9,
                    0xCE, 0x11,
                    0xA0,
                    0x99,
                    0x00,
                    0xAA,
                    0x00,
                    0x47,
                    0x9A,
                    0x58
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDirectDrawVideo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB0, 0x9E, 0xD3, 0x36,
                    0x75, 0xDD,
                    0xCE, 0x11,
                    0xBF,
                    0x0E,
                    0x00,
                    0xAA,
                    0x00,
                    0x55,
                    0x59,
                    0x5A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IQualProp
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB0, 0xEC, 0xD0, 0x1B,
                    0xE2, 0xF8,
                    0xCE, 0x11,
                    0xAA,
                    0xC6,
                    0x00,
                    0x20,
                    0xAF,
                    0x0B,
                    0x99,
                    0xA3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_VPObject
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x61, 0x28, 0x29, 0xCE,
                    0x88, 0xFC,
                    0xD0, 0x11,
                    0x9E,
                    0x69,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD7,
                    0xC1,
                    0x5B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IVPObject
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x62, 0x28, 0x29, 0xCE,
                    0x88, 0xFC,
                    0xD0, 0x11,
                    0x9E,
                    0x69,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD7,
                    0xC1,
                    0x5B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IVPControl
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC1, 0x12, 0xDF, 0x25,
                    0xE0, 0x3D,
                    0xD1, 0x11,
                    0x9E,
                    0x69,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD7,
                    0xC1,
                    0x5B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_VPVBIObject
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x01, 0x98, 0x4B, 0x81,
                    0x88, 0x1C,
                    0xD1, 0x11,
                    0xBA,
                    0xD9,
                    0x00,
                    0x60,
                    0x97,
                    0x44,
                    0x11,
                    0x1A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IVPVBIObject
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x02, 0x98, 0x4B, 0x81,
                    0x88, 0x1C,
                    0xD1, 0x11,
                    0xBA,
                    0xD9,
                    0x00,
                    0x60,
                    0x97,
                    0x44,
                    0x11,
                    0x1A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IVPConfig
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x60, 0xA6, 0x29, 0xBC,
                    0xE3, 0x30,
                    0xD0, 0x11,
                    0x9E,
                    0x69,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD7,
                    0xC1,
                    0x5B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IVPNotify
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA1, 0x94, 0x67, 0xC7,
                    0xC5, 0xD6,
                    0xD0, 0x11,
                    0x9E,
                    0x69,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD7,
                    0xC1,
                    0x5B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IVPNotify2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x83, 0x71, 0xF4, 0xEB,
                    0x64, 0x87,
                    0xD1, 0x11,
                    0x9E,
                    0x69,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD7,
                    0xC1,
                    0x5B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IVPVBIConfig
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x9B, 0x52, 0xEC,
                    0x1F, 0x1A,
                    0xD1, 0x11,
                    0xBA,
                    0xD9,
                    0x00,
                    0x60,
                    0x97,
                    0x44,
                    0x11,
                    0x1A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IVPVBINotify
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x01, 0x9B, 0x52, 0xEC,
                    0x1F, 0x1A,
                    0xD1, 0x11,
                    0xBA,
                    0xD9,
                    0x00,
                    0x60,
                    0x97,
                    0x44,
                    0x11,
                    0x1A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IMixerPinConfig
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE1, 0xDD, 0x3C, 0x59,
                    0x59, 0x07,
                    0xD1, 0x11,
                    0x9E,
                    0x69,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD7,
                    0xC1,
                    0x5B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IMixerPinConfig2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x82, 0x71, 0xF4, 0xEB,
                    0x64, 0x87,
                    0xD1, 0x11,
                    0x9E,
                    0x69,
                    0x00,
                    0xC0,
                    0x4F,
                    0xD7,
                    0xC1,
                    0x5B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IDDVideoPortContainer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x60, 0x27, 0x14, 0x6C,
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
        public static ref readonly Guid IID_IDirectDrawKernel
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x20, 0xC1, 0x56, 0x8D,
                    0x08, 0x6A,
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
        public static ref readonly Guid IID_IDirectDrawSurfaceKernel
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0x5D, 0x75, 0x60,
                    0x40, 0x6A,
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
        public static ref readonly Guid CLSID_ModexProperties
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x30, 0xAA, 0x18, 0x06,
                    0xC4, 0x6B,
                    0xCF, 0x11,
                    0xBF,
                    0x36,
                    0x00,
                    0xAA,
                    0x00,
                    0x55,
                    0x59,
                    0x5A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IFullScreenVideo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x10, 0x71, 0x1D, 0xDD,
                    0x36, 0x78,
                    0xCF, 0x11,
                    0xBF,
                    0x47,
                    0x00,
                    0xAA,
                    0x00,
                    0x55,
                    0x59,
                    0x5A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IFullScreenVideoEx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x70, 0x94, 0x47, 0x53,
                    0xDD, 0xF1,
                    0xCF, 0x11,
                    0xBC,
                    0x42,
                    0x00,
                    0xAA,
                    0x00,
                    0xAC,
                    0x74,
                    0xF6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DVDecPropertiesPage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC0, 0x93, 0x11, 0x10,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DVEncPropertiesPage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0xF0, 0x50, 0x41,
                    0x6F, 0xBB,
                    0xD0, 0x11,
                    0xAF,
                    0xB9,
                    0x00,
                    0xAA,
                    0x00,
                    0xB6,
                    0x7A,
                    0x42
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DVMuxPropertyPage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE0, 0x80, 0xB8, 0x4D,
                    0x0D, 0xC1,
                    0xD0, 0x11,
                    0xAF,
                    0xB9,
                    0x00,
                    0xAA,
                    0x00,
                    0xB6,
                    0x7A,
                    0x42
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IAMDirectSound
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x60, 0x42, 0x6F, 0x54,
                    0x3E, 0xD5,
                    0xCF, 0x11,
                    0xB3,
                    0xF0,
                    0x00,
                    0xAA,
                    0x00,
                    0x37,
                    0x61,
                    0xC5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IMpegAudioDecoder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x70, 0xD5, 0x5D, 0xB4,
                    0x77, 0x3C,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IAMLine21Decoder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x21, 0x4A, 0x8D, 0x6E,
                    0x0C, 0x31,
                    0xD0, 0x11,
                    0xB7,
                    0x9A,
                    0x00,
                    0xAA,
                    0x00,
                    0x37,
                    0x67,
                    0xA7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_IAMWstDecoder
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x21, 0xDE, 0x56, 0xC0,
                    0xC2, 0x75,
                    0xD3, 0x11,
                    0xA1,
                    0x84,
                    0x00,
                    0x10,
                    0x5A,
                    0xEF,
                    0x9F,
                    0x33
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_WstDecoderPropertyPage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0x7F, 0xE2, 0x04,
                    0xE4, 0x91,
                    0xD3, 0x11,
                    0xA1,
                    0x84,
                    0x00,
                    0x10,
                    0x5A,
                    0xEF,
                    0x9F,
                    0x33
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FORMAT_AnalogVideo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE0, 0xDD, 0x82, 0x04,
                    0x17, 0x78,
                    0xCF, 0x11,
                    0x8A,
                    0x03,
                    0x00,
                    0xAA,
                    0x00,
                    0x6E,
                    0xCB,
                    0x65
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIATYPE_AnalogVideo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE1, 0xDD, 0x82, 0x04,
                    0x17, 0x78,
                    0xCF, 0x11,
                    0x8A,
                    0x03,
                    0x00,
                    0xAA,
                    0x00,
                    0x6E,
                    0xCB,
                    0x65
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_NTSC_M
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE2, 0xDD, 0x82, 0x04,
                    0x17, 0x78,
                    0xCF, 0x11,
                    0x8A,
                    0x03,
                    0x00,
                    0xAA,
                    0x00,
                    0x6E,
                    0xCB,
                    0x65
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_PAL_B
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE5, 0xDD, 0x82, 0x04,
                    0x17, 0x78,
                    0xCF, 0x11,
                    0x8A,
                    0x03,
                    0x00,
                    0xAA,
                    0x00,
                    0x6E,
                    0xCB,
                    0x65
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_PAL_D
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE6, 0xDD, 0x82, 0x04,
                    0x17, 0x78,
                    0xCF, 0x11,
                    0x8A,
                    0x03,
                    0x00,
                    0xAA,
                    0x00,
                    0x6E,
                    0xCB,
                    0x65
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_PAL_G
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE7, 0xDD, 0x82, 0x04,
                    0x17, 0x78,
                    0xCF, 0x11,
                    0x8A,
                    0x03,
                    0x00,
                    0xAA,
                    0x00,
                    0x6E,
                    0xCB,
                    0x65
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_PAL_H
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE8, 0xDD, 0x82, 0x04,
                    0x17, 0x78,
                    0xCF, 0x11,
                    0x8A,
                    0x03,
                    0x00,
                    0xAA,
                    0x00,
                    0x6E,
                    0xCB,
                    0x65
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_PAL_I
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE9, 0xDD, 0x82, 0x04,
                    0x17, 0x78,
                    0xCF, 0x11,
                    0x8A,
                    0x03,
                    0x00,
                    0xAA,
                    0x00,
                    0x6E,
                    0xCB,
                    0x65
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_PAL_M
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEA, 0xDD, 0x82, 0x04,
                    0x17, 0x78,
                    0xCF, 0x11,
                    0x8A,
                    0x03,
                    0x00,
                    0xAA,
                    0x00,
                    0x6E,
                    0xCB,
                    0x65
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_PAL_N
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEB, 0xDD, 0x82, 0x04,
                    0x17, 0x78,
                    0xCF, 0x11,
                    0x8A,
                    0x03,
                    0x00,
                    0xAA,
                    0x00,
                    0x6E,
                    0xCB,
                    0x65
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_PAL_N_COMBO
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEC, 0xDD, 0x82, 0x04,
                    0x17, 0x78,
                    0xCF, 0x11,
                    0x8A,
                    0x03,
                    0x00,
                    0xAA,
                    0x00,
                    0x6E,
                    0xCB,
                    0x65
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_SECAM_B
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF0, 0xDD, 0x82, 0x04,
                    0x17, 0x78,
                    0xCF, 0x11,
                    0x8A,
                    0x03,
                    0x00,
                    0xAA,
                    0x00,
                    0x6E,
                    0xCB,
                    0x65
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_SECAM_D
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF1, 0xDD, 0x82, 0x04,
                    0x17, 0x78,
                    0xCF, 0x11,
                    0x8A,
                    0x03,
                    0x00,
                    0xAA,
                    0x00,
                    0x6E,
                    0xCB,
                    0x65
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_SECAM_G
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF2, 0xDD, 0x82, 0x04,
                    0x17, 0x78,
                    0xCF, 0x11,
                    0x8A,
                    0x03,
                    0x00,
                    0xAA,
                    0x00,
                    0x6E,
                    0xCB,
                    0x65
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_SECAM_H
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF3, 0xDD, 0x82, 0x04,
                    0x17, 0x78,
                    0xCF, 0x11,
                    0x8A,
                    0x03,
                    0x00,
                    0xAA,
                    0x00,
                    0x6E,
                    0xCB,
                    0x65
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_SECAM_K
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF4, 0xDD, 0x82, 0x04,
                    0x17, 0x78,
                    0xCF, 0x11,
                    0x8A,
                    0x03,
                    0x00,
                    0xAA,
                    0x00,
                    0x6E,
                    0xCB,
                    0x65
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_SECAM_K1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF5, 0xDD, 0x82, 0x04,
                    0x17, 0x78,
                    0xCF, 0x11,
                    0x8A,
                    0x03,
                    0x00,
                    0xAA,
                    0x00,
                    0x6E,
                    0xCB,
                    0x65
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIASUBTYPE_AnalogVideo_SECAM_L
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF6, 0xDD, 0x82, 0x04,
                    0x17, 0x78,
                    0xCF, 0x11,
                    0x8A,
                    0x03,
                    0x00,
                    0xAA,
                    0x00,
                    0x6E,
                    0xCB,
                    0x65
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MEDIATYPE_AnalogAudio
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE1, 0xDE, 0x82, 0x04,
                    0x17, 0x78,
                    0xCF, 0x11,
                    0x8A,
                    0x03,
                    0x00,
                    0xAA,
                    0x00,
                    0x6E,
                    0xCB,
                    0x65
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FORMAT_CAPTIONED_H264VIDEO
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xC0, 0xEF, 0xA4,
                    0x3E, 0x87,
                    0xA3, 0x4D,
                    0x89,
                    0x8B,
                    0x47,
                    0x4D,
                    0xDB,
                    0xD7,
                    0x9F,
                    0xD0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FORMAT_CC_CONTAINER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4A, 0x7A, 0x99, 0x50,
                    0x08, 0xE5,
                    0x54, 0x40,
                    0xA2,
                    0xB2,
                    0x10,
                    0xFF,
                    0x0A,
                    0xC1,
                    0xA6,
                    0x9A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CAPTION_FORMAT_ATSC
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x31, 0xCB, 0xD9, 0x3E,
                    0x10, 0xFD,
                    0xDE, 0x4A,
                    0xBC,
                    0xCC,
                    0xFB,
                    0x91,
                    0x05,
                    0xD2,
                    0xF3,
                    0xEF
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CAPTION_FORMAT_DVB
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB4, 0x0D, 0x23, 0x12,
                    0x2A, 0xFF,
                    0x7E, 0x44,
                    0xBB,
                    0x88,
                    0x68,
                    0x41,
                    0xC4,
                    0x16,
                    0xD0,
                    0x68
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CAPTION_FORMAT_DIRECTV
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE7, 0x1C, 0xCA, 0xE9,
                    0x5E, 0x91,
                    0xBE, 0x47,
                    0x9B,
                    0xB9,
                    0xBF,
                    0x1D,
                    0x8A,
                    0x13,
                    0xA5,
                    0xEC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CAPTION_FORMAT_ECHOSTAR
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x62, 0xA2, 0xB1, 0xEB,
                    0x58, 0x11,
                    0x99, 0x4B,
                    0xAE,
                    0x80,
                    0x92,
                    0xAC,
                    0x77,
                    0x69,
                    0x52,
                    0xC4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid FORMAT_CAPTIONED_MPEG2VIDEO
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA2, 0xAD, 0xB2, 0x7A,
                    0xB6, 0x81,
                    0x14, 0x4F,
                    0xB3,
                    0xC8,
                    0xD0,
                    0xC4,
                    0x86,
                    0x39,
                    0x3B,
                    0x67
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid TIME_FORMAT_NONE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00,
                    0x00, 0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00,
                    0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid TIME_FORMAT_FRAME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x70, 0x55, 0x78, 0x7B,
                    0x82, 0x8C,
                    0xCF, 0x11,
                    0xBC,
                    0x0C,
                    0x00,
                    0xAA,
                    0x00,
                    0xAC,
                    0x74,
                    0xF6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid TIME_FORMAT_BYTE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x71, 0x55, 0x78, 0x7B,
                    0x82, 0x8C,
                    0xCF, 0x11,
                    0xBC,
                    0x0C,
                    0x00,
                    0xAA,
                    0x00,
                    0xAC,
                    0x74,
                    0xF6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid TIME_FORMAT_SAMPLE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x72, 0x55, 0x78, 0x7B,
                    0x82, 0x8C,
                    0xCF, 0x11,
                    0xBC,
                    0x0C,
                    0x00,
                    0xAA,
                    0x00,
                    0xAC,
                    0x74,
                    0xF6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid TIME_FORMAT_FIELD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x73, 0x55, 0x78, 0x7B,
                    0x82, 0x8C,
                    0xCF, 0x11,
                    0xBC,
                    0x0C,
                    0x00,
                    0xAA,
                    0x00,
                    0xAC,
                    0x74,
                    0xF6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid TIME_FORMAT_MEDIA_TIME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x74, 0x55, 0x78, 0x7B,
                    0x82, 0x8C,
                    0xCF, 0x11,
                    0xBC,
                    0x0C,
                    0x00,
                    0xAA,
                    0x00,
                    0xAC,
                    0x74,
                    0xF6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid AMPROPSETID_Pin
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x01, 0xF1, 0x00, 0x9B,
                    0x67, 0x15,
                    0xD1, 0x11,
                    0xB3,
                    0xF1,
                    0x00,
                    0xAA,
                    0x00,
                    0x37,
                    0x61,
                    0xC5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid PIN_CATEGORY_CAPTURE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x81, 0x42, 0x6C, 0xFB,
                    0x53, 0x03,
                    0xD1, 0x11,
                    0x90,
                    0x5F,
                    0x00,
                    0x00,
                    0xC0,
                    0xCC,
                    0x16,
                    0xBA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid PIN_CATEGORY_PREVIEW
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x82, 0x42, 0x6C, 0xFB,
                    0x53, 0x03,
                    0xD1, 0x11,
                    0x90,
                    0x5F,
                    0x00,
                    0x00,
                    0xC0,
                    0xCC,
                    0x16,
                    0xBA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid PIN_CATEGORY_ANALOGVIDEOIN
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x83, 0x42, 0x6C, 0xFB,
                    0x53, 0x03,
                    0xD1, 0x11,
                    0x90,
                    0x5F,
                    0x00,
                    0x00,
                    0xC0,
                    0xCC,
                    0x16,
                    0xBA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid PIN_CATEGORY_VBI
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x84, 0x42, 0x6C, 0xFB,
                    0x53, 0x03,
                    0xD1, 0x11,
                    0x90,
                    0x5F,
                    0x00,
                    0x00,
                    0xC0,
                    0xCC,
                    0x16,
                    0xBA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid PIN_CATEGORY_VIDEOPORT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x85, 0x42, 0x6C, 0xFB,
                    0x53, 0x03,
                    0xD1, 0x11,
                    0x90,
                    0x5F,
                    0x00,
                    0x00,
                    0xC0,
                    0xCC,
                    0x16,
                    0xBA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid PIN_CATEGORY_NABTS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x86, 0x42, 0x6C, 0xFB,
                    0x53, 0x03,
                    0xD1, 0x11,
                    0x90,
                    0x5F,
                    0x00,
                    0x00,
                    0xC0,
                    0xCC,
                    0x16,
                    0xBA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid PIN_CATEGORY_EDS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x87, 0x42, 0x6C, 0xFB,
                    0x53, 0x03,
                    0xD1, 0x11,
                    0x90,
                    0x5F,
                    0x00,
                    0x00,
                    0xC0,
                    0xCC,
                    0x16,
                    0xBA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid PIN_CATEGORY_TELETEXT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x88, 0x42, 0x6C, 0xFB,
                    0x53, 0x03,
                    0xD1, 0x11,
                    0x90,
                    0x5F,
                    0x00,
                    0x00,
                    0xC0,
                    0xCC,
                    0x16,
                    0xBA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid PIN_CATEGORY_CC
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x89, 0x42, 0x6C, 0xFB,
                    0x53, 0x03,
                    0xD1, 0x11,
                    0x90,
                    0x5F,
                    0x00,
                    0x00,
                    0xC0,
                    0xCC,
                    0x16,
                    0xBA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid PIN_CATEGORY_STILL
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8A, 0x42, 0x6C, 0xFB,
                    0x53, 0x03,
                    0xD1, 0x11,
                    0x90,
                    0x5F,
                    0x00,
                    0x00,
                    0xC0,
                    0xCC,
                    0x16,
                    0xBA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid PIN_CATEGORY_TIMECODE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8B, 0x42, 0x6C, 0xFB,
                    0x53, 0x03,
                    0xD1, 0x11,
                    0x90,
                    0x5F,
                    0x00,
                    0x00,
                    0xC0,
                    0xCC,
                    0x16,
                    0xBA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid PIN_CATEGORY_VIDEOPORT_VBI
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8C, 0x42, 0x6C, 0xFB,
                    0x53, 0x03,
                    0xD1, 0x11,
                    0x90,
                    0x5F,
                    0x00,
                    0x00,
                    0xC0,
                    0xCC,
                    0x16,
                    0xBA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid LOOK_UPSTREAM_ONLY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE0, 0x8B, 0x79, 0xAC,
                    0xE3, 0x98,
                    0xD1, 0x11,
                    0xB3,
                    0xF1,
                    0x00,
                    0xAA,
                    0x00,
                    0x37,
                    0x61,
                    0xC5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid LOOK_DOWNSTREAM_ONLY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE1, 0x8B, 0x79, 0xAC,
                    0xE3, 0x98,
                    0xD1, 0x11,
                    0xB3,
                    0xF1,
                    0x00,
                    0xAA,
                    0x00,
                    0x37,
                    0x61,
                    0xC5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_TVTunerFilterPropertyPage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x41, 0xEE, 0x6E, 0x26,
                    0x63, 0x6C,
                    0xCF, 0x11,
                    0x8A,
                    0x03,
                    0x00,
                    0xAA,
                    0x00,
                    0x6E,
                    0xCB,
                    0x65
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_CrossbarFilterPropertyPage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x61, 0x64, 0xF9, 0x71,
                    0xF3, 0x78,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_TVAudioFilterPropertyPage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x63, 0x64, 0xF9, 0x71,
                    0xF3, 0x78,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_VideoProcAmpPropertyPage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0x64, 0xF9, 0x71,
                    0xF3, 0x78,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_CameraControlPropertyPage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x65, 0x64, 0xF9, 0x71,
                    0xF3, 0x78,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_AnalogVideoDecoderPropertyPage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x66, 0x64, 0xF9, 0x71,
                    0xF3, 0x78,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_VideoStreamConfigPropertyPage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x67, 0x64, 0xF9, 0x71,
                    0xF3, 0x78,
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

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_AudioRendererAdvancedProperties
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x92, 0x2A, 0xE9, 0x37,
                    0xAA, 0xD9,
                    0xD2, 0x11,
                    0xBF,
                    0x84,
                    0x8E,
                    0xF2,
                    0xB1,
                    0x55,
                    0x5A,
                    0xED
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_VideoMixingRenderer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7B, 0xEB, 0x7B, 0xB8,
                    0x29, 0x8D,
                    0x3F, 0x42,
                    0xAE,
                    0x4D,
                    0x65,
                    0x82,
                    0xC1,
                    0x01,
                    0x75,
                    0xAC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_VideoRendererDefault
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFA, 0xCF, 0xC1, 0x6B,
                    0xC1, 0x8F,
                    0x61, 0x42,
                    0xAC,
                    0x22,
                    0xCF,
                    0xB4,
                    0xCC,
                    0x38,
                    0xDB,
                    0x50
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_AllocPresenter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x63, 0x4F, 0xD5, 0x99,
                    0x69, 0x1A,
                    0xAE, 0x41,
                    0xAA,
                    0x4D,
                    0xC9,
                    0x76,
                    0xEB,
                    0x3F,
                    0x07,
                    0x13
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_AllocPresenterDDXclMode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9E, 0xAC, 0x44, 0x44,
                    0x2E, 0x24,
                    0x1B, 0x47,
                    0xA3,
                    0xC7,
                    0x45,
                    0xDC,
                    0xD4,
                    0x63,
                    0x52,
                    0xBC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_VideoPortManager
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCD, 0xA6, 0x26, 0x6F,
                    0x7B, 0x96,
                    0xFD, 0x47,
                    0x87,
                    0x4A,
                    0x7A,
                    0xED,
                    0x2C,
                    0x9D,
                    0x25,
                    0xA2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_VideoMixingRenderer9
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF3, 0xAB, 0xB4, 0x51,
                    0x8F, 0x74,
                    0x3B, 0x4E,
                    0xA2,
                    0x76,
                    0xC8,
                    0x28,
                    0x33,
                    0x0E,
                    0x92,
                    0x6A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_EnhancedVideoRenderer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6C, 0x74, 0x10, 0xFA,
                    0x63, 0x9B,
                    0x6C, 0x4B,
                    0xBC,
                    0x49,
                    0xFC,
                    0x30,
                    0x0E,
                    0xA5,
                    0xF2,
                    0x56
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_MFVideoMixer9
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5A, 0xE0, 0x74, 0xE4,
                    0x65, 0xAB,
                    0x6A, 0x4F,
                    0x82,
                    0x7C,
                    0x21,
                    0x8B,
                    0x1B,
                    0xAA,
                    0xF3,
                    0x1F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_MFVideoPresenter9
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x61, 0x55, 0x45, 0x98,
                    0x36, 0x51,
                    0x28, 0x4D,
                    0xAB,
                    0x08,
                    0x4C,
                    0xEE,
                    0x40,
                    0xEA,
                    0x27,
                    0x81
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_EVRTearlessWindowPresenter9
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7B, 0xA5, 0xA7, 0xA0,
                    0xB2, 0x59,
                    0x19, 0x49,
                    0xA6,
                    0x94,
                    0xAD,
                    0xD0,
                    0xA5,
                    0x26,
                    0xC3,
                    0x73
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_EVRPlaybackPipelineOptimizer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0x91, 0x07, 0x62,
                    0x3B, 0x23,
                    0xF8, 0x41,
                    0xA8,
                    0x0F,
                    0xF0,
                    0x17,
                    0x05,
                    0xF5,
                    0x14,
                    0xA8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid EVRConfig_ForceBob
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x01, 0xDF, 0x47, 0xE4,
                    0xCA, 0x10,
                    0x17, 0x4D,
                    0xB1,
                    0x7E,
                    0x6A,
                    0x84,
                    0x0F,
                    0x8A,
                    0x3A,
                    0x4C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid EVRConfig_AllowDropToBob
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x02, 0xDF, 0x47, 0xE4,
                    0xCA, 0x10,
                    0x17, 0x4D,
                    0xB1,
                    0x7E,
                    0x6A,
                    0x84,
                    0x0F,
                    0x8A,
                    0x3A,
                    0x4C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid EVRConfig_ForceThrottle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x03, 0xDF, 0x47, 0xE4,
                    0xCA, 0x10,
                    0x17, 0x4D,
                    0xB1,
                    0x7E,
                    0x6A,
                    0x84,
                    0x0F,
                    0x8A,
                    0x3A,
                    0x4C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid EVRConfig_AllowDropToThrottle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x04, 0xDF, 0x47, 0xE4,
                    0xCA, 0x10,
                    0x17, 0x4D,
                    0xB1,
                    0x7E,
                    0x6A,
                    0x84,
                    0x0F,
                    0x8A,
                    0x3A,
                    0x4C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid EVRConfig_ForceHalfInterlace
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x05, 0xDF, 0x47, 0xE4,
                    0xCA, 0x10,
                    0x17, 0x4D,
                    0xB1,
                    0x7E,
                    0x6A,
                    0x84,
                    0x0F,
                    0x8A,
                    0x3A,
                    0x4C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid EVRConfig_AllowDropToHalfInterlace
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x06, 0xDF, 0x47, 0xE4,
                    0xCA, 0x10,
                    0x17, 0x4D,
                    0xB1,
                    0x7E,
                    0x6A,
                    0x84,
                    0x0F,
                    0x8A,
                    0x3A,
                    0x4C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid EVRConfig_ForceScaling
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x07, 0xDF, 0x47, 0xE4,
                    0xCA, 0x10,
                    0x17, 0x4D,
                    0xB1,
                    0x7E,
                    0x6A,
                    0x84,
                    0x0F,
                    0x8A,
                    0x3A,
                    0x4C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid EVRConfig_AllowScaling
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x08, 0xDF, 0x47, 0xE4,
                    0xCA, 0x10,
                    0x17, 0x4D,
                    0xB1,
                    0x7E,
                    0x6A,
                    0x84,
                    0x0F,
                    0x8A,
                    0x3A,
                    0x4C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid EVRConfig_ForceBatching
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x09, 0xDF, 0x47, 0xE4,
                    0xCA, 0x10,
                    0x17, 0x4D,
                    0xB1,
                    0x7E,
                    0x6A,
                    0x84,
                    0x0F,
                    0x8A,
                    0x3A,
                    0x4C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid EVRConfig_AllowBatching
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0A, 0xDF, 0x47, 0xE4,
                    0xCA, 0x10,
                    0x17, 0x4D,
                    0xB1,
                    0x7E,
                    0x6A,
                    0x84,
                    0x0F,
                    0x8A,
                    0x3A,
                    0x4C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_NetworkProvider
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7C, 0xA6, 0xF3, 0xB2,
                    0xDA, 0x29,
                    0x78, 0x4C,
                    0x88,
                    0x31,
                    0x09,
                    0x1E,
                    0xD5,
                    0x09,
                    0xA4,
                    0x75
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_ATSCNetworkProvider
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDD, 0x2F, 0xAD, 0x0D,
                    0xD7, 0x5F,
                    0xD3, 0x11,
                    0x8F,
                    0x50,
                    0x00,
                    0xC0,
                    0x4F,
                    0x79,
                    0x71,
                    0xE2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_ATSCNetworkPropertyPage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x16, 0x4D, 0x44, 0xE3,
                    0xC4, 0x5A,
                    0x86, 0x43,
                    0x88,
                    0xDF,
                    0x13,
                    0xFD,
                    0x23,
                    0x0E,
                    0x1D,
                    0xDA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DVBSNetworkProvider
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5A, 0x37, 0x4B, 0xFA,
                    0xB4, 0x45,
                    0x45, 0x4D,
                    0x84,
                    0x40,
                    0x26,
                    0x39,
                    0x57,
                    0xB1,
                    0x16,
                    0x23
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DVBTNetworkProvider
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDF, 0x62, 0x6C, 0x21,
                    0x7F, 0x6D,
                    0x9A, 0x4E,
                    0x85,
                    0x71,
                    0x05,
                    0xF1,
                    0x4E,
                    0xDB,
                    0x76,
                    0x6A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DVBCNetworkProvider
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE7, 0x0F, 0x0C, 0xDC,
                    0x85, 0x04,
                    0x66, 0x42,
                    0xB9,
                    0x3F,
                    0x68,
                    0xFB,
                    0xF8,
                    0x0E,
                    0xD8,
                    0x34
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid DSATTRIB_UDCRTag
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCA, 0x36, 0x78, 0xEB,
                    0xFF, 0x14,
                    0x19, 0x49,
                    0xBC,
                    0xE7,
                    0x3A,
                    0xF1,
                    0x23,
                    0x19,
                    0xE5,
                    0x0C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid DSATTRIB_PicSampleSeq
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x02, 0xAE, 0x5B, 0x2F,
                    0x8F, 0x7B,
                    0x60, 0x4F,
                    0x82,
                    0xD6,
                    0xE4,
                    0xEA,
                    0x2F,
                    0x1F,
                    0x4C,
                    0x99
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid DSATTRIB_OptionalVideoAttributes
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCA, 0x08, 0x5F, 0x5A,
                    0xC2, 0x55,
                    0x33, 0x40,
                    0x92,
                    0xAB,
                    0x55,
                    0xDB,
                    0x8F,
                    0x78,
                    0x12,
                    0x26
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid DSATTRIB_CC_CONTAINER_INFO
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFB, 0x50, 0xE0, 0xE7,
                    0x5D, 0xDD,
                    0xDD, 0x40,
                    0x99,
                    0x15,
                    0x35,
                    0xDC,
                    0xB8,
                    0x1B,
                    0xDC,
                    0x8A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid DSATTRIB_TRANSPORT_PROPERTIES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x12, 0xF6, 0x22, 0xB6,
                    0xAD, 0x47,
                    0x71, 0x46,
                    0xAD,
                    0x6C,
                    0x05,
                    0xA9,
                    0x8E,
                    0x65,
                    0xDE,
                    0x3A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid DSATTRIB_PBDATAG_ATTRIBUTE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x79, 0x66, 0xB5, 0xE0,
                    0xB9, 0x12,
                    0xCC, 0x43,
                    0xB7,
                    0xDF,
                    0x57,
                    0x8C,
                    0xAA,
                    0x5A,
                    0x7B,
                    0x63
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid DSATTRIB_CAPTURE_STREAMTIME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x14, 0x56, 0x1A, 0x0C,
                    0xCD, 0x30,
                    0x40, 0x4F,
                    0xBC,
                    0xBF,
                    0xD0,
                    0x3E,
                    0x52,
                    0x30,
                    0x62,
                    0x07
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid DSATTRIB_DSHOW_STREAM_DESC
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3B, 0x67, 0xB5, 0x5F,
                    0x2A, 0x0A,
                    0x65, 0x45,
                    0x82,
                    0x7B,
                    0x68,
                    0x53,
                    0xFD,
                    0x75,
                    0xE6,
                    0x11
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid DSATTRIB_SAMPLE_LIVE_STREAM_TIME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x11, 0xD1, 0x2C, 0x89,
                    0xF3, 0x72,
                    0x1D, 0x41,
                    0x8B,
                    0x91,
                    0xA9,
                    0xE9,
                    0x12,
                    0x3A,
                    0xC2,
                    0x9A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid UUID_UdriTagTables
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x74, 0x8D, 0xB9, 0xE1,
                    0x78, 0x97,
                    0x78, 0x48,
                    0xB6,
                    0x64,
                    0xEB,
                    0x20,
                    0x20,
                    0x36,
                    0x4D,
                    0x88
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid UUID_WMDRMTagTables
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x01, 0x11, 0xCD, 0x5D,
                    0x63, 0x92,
                    0xBB, 0x45,
                    0xA4,
                    0xD5,
                    0xC4,
                    0x15,
                    0xAB,
                    0x8C,
                    0x58,
                    0x9C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_DShowTVEFilter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0x02, 0x50, 0x05,
                    0xA5, 0xFA,
                    0xF9, 0x4D,
                    0x82,
                    0x46,
                    0xBF,
                    0xC2,
                    0x3A,
                    0xC5,
                    0xCE,
                    0xA8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_TVEFilterTuneProperties
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x81, 0x02, 0x50, 0x05,
                    0xA5, 0xFA,
                    0xF9, 0x4D,
                    0x82,
                    0x46,
                    0xBF,
                    0xC2,
                    0x3A,
                    0xC5,
                    0xCE,
                    0xA8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_TVEFilterCCProperties
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x82, 0x02, 0x50, 0x05,
                    0xA5, 0xFA,
                    0xF9, 0x4D,
                    0x82,
                    0x46,
                    0xBF,
                    0xC2,
                    0x3A,
                    0xC5,
                    0xCE,
                    0xA8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_TVEFilterStatsProperties
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x83, 0x02, 0x50, 0x05,
                    0xA5, 0xFA,
                    0xF9, 0x4D,
                    0x82,
                    0x46,
                    0xBF,
                    0xC2,
                    0x3A,
                    0xC5,
                    0xCE,
                    0xA8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_IVideoEncoderProxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEC, 0x4E, 0x3C, 0xB4,
                    0x32, 0x8C,
                    0x91, 0x47,
                    0x91,
                    0x02,
                    0x50,
                    0x8A,
                    0xDA,
                    0x5E,
                    0xE8,
                    0xE7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_ICodecAPIProxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7A, 0x99, 0xF0, 0x7F,
                    0x99, 0x19,
                    0x86, 0x42,
                    0xA7,
                    0x3C,
                    0x62,
                    0x2B,
                    0x88,
                    0x14,
                    0xE7,
                    0xEB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_IVideoEncoderCodecAPIProxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD9, 0xAB, 0x5D, 0xB0,
                    0xE5, 0x56,
                    0xDC, 0x4F,
                    0xAF,
                    0xA4,
                    0x8A,
                    0x47,
                    0xE9,
                    0x1F,
                    0x1C,
                    0x9C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid ENCAPIPARAM_BITRATE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x43, 0x4C, 0xCC, 0x49,
                    0x83, 0xCA,
                    0xD4, 0x4A,
                    0xA9,
                    0xAF,
                    0xF3,
                    0x69,
                    0x6A,
                    0xF6,
                    0x66,
                    0xDF
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid ENCAPIPARAM_PEAK_BITRATE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA9, 0x16, 0x3F, 0x70,
                    0x48, 0x3D,
                    0xA1, 0x44,
                    0xB0,
                    0x77,
                    0x01,
                    0x8D,
                    0xFF,
                    0x91,
                    0x5D,
                    0x19
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid ENCAPIPARAM_BITRATE_MODE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5C, 0xB2, 0x5F, 0xEE,
                    0x13, 0xC7,
                    0xD1, 0x40,
                    0x9D,
                    0x58,
                    0xC0,
                    0xD7,
                    0x24,
                    0x1E,
                    0x25,
                    0x0F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid ENCAPIPARAM_SAP_MODE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDB, 0x71, 0x01, 0x0C,
                    0xFC, 0xFE,
                    0xF7, 0x4A,
                    0x99,
                    0x91,
                    0xA5,
                    0x65,
                    0x7C,
                    0x19,
                    0x1C,
                    0xD1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CODECAPI_CHANGELISTS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCF, 0x2A, 0xB1, 0x62,
                    0xB0, 0xF6,
                    0xD9, 0x47,
                    0x94,
                    0x56,
                    0x96,
                    0xF2,
                    0x2C,
                    0x4E,
                    0x0B,
                    0x9D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CODECAPI_VIDEO_ENCODER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE1, 0xE8, 0x12, 0x71,
                    0x03, 0x3D,
                    0xEF, 0x47,
                    0x8E,
                    0x60,
                    0x03,
                    0xF1,
                    0xCF,
                    0x53,
                    0x73,
                    0x01
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CODECAPI_AUDIO_ENCODER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3E, 0x9A, 0xD1, 0xB9,
                    0x97, 0xF8,
                    0x9C, 0x42,
                    0xBC,
                    0x46,
                    0x81,
                    0x38,
                    0xB7,
                    0x27,
                    0x2B,
                    0x2D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CODECAPI_SETALLDEFAULTS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7C, 0x6A, 0x5E, 0x6C,
                    0xF8, 0xAC,
                    0x55, 0x4F,
                    0xA9,
                    0x99,
                    0x1A,
                    0x62,
                    0x81,
                    0x09,
                    0x05,
                    0x1B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CODECAPI_ALLSETTINGS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x92, 0x7E, 0x57, 0x6A,
                    0xE1, 0x83,
                    0x13, 0x41,
                    0xAD,
                    0xC2,
                    0x4F,
                    0xCE,
                    0xC3,
                    0x2F,
                    0x83,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CODECAPI_SUPPORTSEVENTS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x97, 0xAF, 0x81, 0x05,
                    0x93, 0x76,
                    0xBD, 0x4D,
                    0x9D,
                    0xCA,
                    0x3F,
                    0x9E,
                    0xBD,
                    0x65,
                    0x85,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CODECAPI_CURRENTCHANGELIST
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x83, 0x4E, 0xB1, 0x1C,
                    0x72, 0x7D,
                    0x57, 0x46,
                    0x83,
                    0xFD,
                    0x47,
                    0xA2,
                    0xC5,
                    0xB9,
                    0xD1,
                    0x3D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_SBE2MediaTypeProfile
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x02, 0xA6, 0x26, 0x1F,
                    0x5C, 0x2B,
                    0x63, 0x4B,
                    0xB8,
                    0xE8,
                    0x9E,
                    0xA5,
                    0xC1,
                    0xA7,
                    0xDC,
                    0x2E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CLSID_SBE2FileScan
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x37, 0x80, 0x45, 0x3E,
                    0xA6, 0x0C,
                    0xAA, 0x41,
                    0xA5,
                    0x94,
                    0x2A,
                    0xA6,
                    0xC0,
                    0x2D,
                    0x70,
                    0x9B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid CODECAPI_AVDecMmcssClass
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x28, 0x48, 0xAD, 0xE0,
                    0x66, 0xDF,
                    0x93, 0x48,
                    0x9F,
                    0x33,
                    0x78,
                    0x8A,
                    0xA4,
                    0xEC,
                    0x40,
                    0x82
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
