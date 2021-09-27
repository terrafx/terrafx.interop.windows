// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_MPEG2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7F, 0x41, 0x27, 0xEE,
                    0x28, 0x5E,
                    0x65, 0x4E,
                    0xBE,
                    0xEA,
                    0x1D,
                    0x26,
                    0xB5,
                    0x08,
                    0xAD,
                    0xC9
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_MPEG1_AND_MPEG2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x12, 0x5F, 0x69, 0x86,
                    0x0E, 0x34,
                    0x04, 0x4F,
                    0x9F,
                    0xD3,
                    0x92,
                    0x53,
                    0xDD,
                    0x32,
                    0x74,
                    0x60
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_H264
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x68, 0xBE, 0x81, 0x1B,
                    0xC7, 0xA0,
                    0xD3, 0x11,
                    0xB9,
                    0x84,
                    0x00,
                    0xC0,
                    0x4F,
                    0x2E,
                    0x73,
                    0xC5
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_H264_STEREO_PROGRESSIVE
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDA, 0xE8, 0x9B, 0xD7,
                    0xF1, 0x0C,
                    0x81, 0x4C,
                    0xB8,
                    0x2A,
                    0x69,
                    0xA4,
                    0xE2,
                    0x36,
                    0xF4,
                    0x3D
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_H264_STEREO
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBB, 0xCC, 0xAA, 0xF9,
                    0xB6, 0xC2,
                    0xFC, 0x4C,
                    0x87,
                    0x79,
                    0x57,
                    0x07,
                    0xB1,
                    0x76,
                    0x05,
                    0x52
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_H264_MULTIVIEW
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x82, 0x9D, 0x5B, 0x70,
                    0xCF, 0x76,
                    0xD6, 0x49,
                    0xB7,
                    0xE6,
                    0xAC,
                    0x88,
                    0x72,
                    0xDB,
                    0x01,
                    0x3C
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_VC1
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA3, 0xBE, 0x81, 0x1B,
                    0xC7, 0xA0,
                    0xD3, 0x11,
                    0xB9,
                    0x84,
                    0x00,
                    0xC0,
                    0x4F,
                    0x2E,
                    0x73,
                    0xC5
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_VC1_D2010
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA4, 0xBE, 0x81, 0x1B,
                    0xC7, 0xA0,
                    0xD3, 0x11,
                    0xB9,
                    0x84,
                    0x00,
                    0xC0,
                    0x4F,
                    0x2E,
                    0x73,
                    0xC5
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_MPEG4PT2_SIMPLE
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x74, 0x4D, 0xD6, 0xEF,
                    0xE8, 0xC9,
                    0xD7, 0x41,
                    0xA5,
                    0xE9,
                    0xE9,
                    0xB0,
                    0xE3,
                    0x9F,
                    0xA3,
                    0x19
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_MPEG4PT2_ADVSIMPLE_NOGMC
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9F, 0x8A, 0x41, 0xED,
                    0x0D, 0x01,
                    0xDA, 0x4E,
                    0x9A,
                    0xE3,
                    0x9A,
                    0x65,
                    0x35,
                    0x8D,
                    0x8D,
                    0x2E
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1B, 0xD5, 0x11, 0x5B,
                    0x4C, 0x2F,
                    0x52, 0x44,
                    0xBC,
                    0xC3,
                    0x09,
                    0xF2,
                    0xA1,
                    0x16,
                    0x0C,
                    0xC0
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_HEVC_MAIN10
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE0, 0xF0, 0x7A, 0x10,
                    0x1A, 0xEF,
                    0x19, 0x4D,
                    0xAB,
                    0xA8,
                    0x67,
                    0xA1,
                    0x63,
                    0x07,
                    0x3D,
                    0x13
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_VP9
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF8, 0x07, 0x37, 0x46,
                    0xD0, 0xA1,
                    0x85, 0x45,
                    0x87,
                    0x6D,
                    0x83,
                    0xAA,
                    0x6D,
                    0x60,
                    0xB8,
                    0x9E
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_VP9_10BIT_PROFILE2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEF, 0x49, 0xC7, 0xA4,
                    0xCF, 0x6E,
                    0xAA, 0x48,
                    0x84,
                    0x48,
                    0x50,
                    0xA7,
                    0xA1,
                    0x16,
                    0x5F,
                    0xF7
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_VP8
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEA, 0x99, 0xB8, 0x90,
                    0x62, 0x3A,
                    0x05, 0x47,
                    0x88,
                    0xB3,
                    0x8D,
                    0xF0,
                    0x4B,
                    0x27,
                    0x44,
                    0xE7
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_AV1_PROFILE0
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCB, 0x4C, 0xBE, 0xB8,
                    0x53, 0xCF,
                    0xBA, 0x46,
                    0x8D,
                    0x59,
                    0xD6,
                    0xB8,
                    0xA6,
                    0xDA,
                    0x5D,
                    0x2A
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_AV1_PROFILE1
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0F, 0xFF, 0x36, 0x69,
                    0xB1, 0x45,
                    0x63, 0x41,
                    0x9C,
                    0xC1,
                    0x64,
                    0x6E,
                    0xF6,
                    0x94,
                    0x61,
                    0x08
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_AV1_PROFILE2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA1, 0x2A, 0x5F, 0x0C,
                    0x41, 0xE5,
                    0x89, 0x40,
                    0xBB,
                    0x7B,
                    0x98,
                    0x11,
                    0x0A,
                    0x19,
                    0xD7,
                    0xC8
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_AV1_12BIT_PROFILE2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x09, 0x70, 0x12, 0x17,
                    0x0F, 0xA0,
                    0xE1, 0x4C,
                    0x99,
                    0x4E,
                    0xBF,
                    0x40,
                    0x81,
                    0xF6,
                    0xF3,
                    0xF0
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid D3D12_VIDEO_DECODE_PROFILE_AV1_12BIT_PROFILE2_420
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD6, 0xBE, 0x80, 0x2D,
                    0xAC, 0x9C,
                    0x35, 0x48,
                    0x9E,
                    0x91,
                    0x32,
                    0x7B,
                    0xBC,
                    0x4F,
                    0x9E,
                    0xE8
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12VideoDecoderHeap
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC9, 0xB7, 0x46, 0x09,
                    0xF6, 0xEB,
                    0x47, 0x40,
                    0xBB,
                    0x73,
                    0x86,
                    0x83,
                    0xE2,
                    0x7D,
                    0xBB,
                    0x1F
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12VideoDevice
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x07, 0x28, 0x05, 0x1F,
                    0x46, 0x0B,
                    0xCC, 0x4A,
                    0x8A,
                    0x89,
                    0x36,
                    0x4F,
                    0x79,
                    0x37,
                    0x18,
                    0xA4
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12VideoDecoder
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDC, 0x6B, 0x9B, 0xC5,
                    0x20, 0x77,
                    0x74, 0x40,
                    0xA1,
                    0x36,
                    0x17,
                    0xA1,
                    0x56,
                    0x03,
                    0x74,
                    0x70
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12VideoProcessor
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x32, 0xDB, 0x4F, 0x30,
                    0xDE, 0xBE,
                    0x0A, 0x41,
                    0x85,
                    0x45,
                    0x94,
                    0x3A,
                    0xC6,
                    0xA4,
                    0x61,
                    0x38
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12VideoDecodeCommandList
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6E, 0x53, 0x60, 0x3B,
                    0x29, 0xAD,
                    0x64, 0x4E,
                    0xA2,
                    0x69,
                    0xF8,
                    0x53,
                    0x83,
                    0x7E,
                    0x5E,
                    0x53
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12VideoProcessCommandList
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3A, 0x54, 0xB2, 0xAE,
                    0x7F, 0x16,
                    0x82, 0x46,
                    0xAC,
                    0xC8,
                    0xD1,
                    0x59,
                    0xED,
                    0x4A,
                    0x62,
                    0x09
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12VideoDecodeCommandList1
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1B, 0x01, 0x2F, 0xD5,
                    0x6E, 0xB5,
                    0x3C, 0x45,
                    0xA0,
                    0x5A,
                    0xA7,
                    0xF3,
                    0x11,
                    0xC8,
                    0xF4,
                    0x72
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12VideoProcessCommandList1
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4D, 0x5C, 0x2C, 0x54,
                    0x96, 0x75,
                    0x4F, 0x43,
                    0x8C,
                    0x93,
                    0x4E,
                    0xFA,
                    0x67,
                    0x66,
                    0xF2,
                    0x67
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12VideoMotionEstimator
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0E, 0xAE, 0xFD, 0x33,
                    0x8B, 0x09,
                    0x8F, 0x42,
                    0x87,
                    0xBB,
                    0x34,
                    0xB6,
                    0x95,
                    0xDE,
                    0x08,
                    0xF8
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12VideoMotionVectorHeap
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x87, 0x79, 0xE1, 0x5B,
                    0x3A, 0x74,
                    0x61, 0x40,
                    0x83,
                    0x4B,
                    0x23,
                    0xD2,
                    0x2D,
                    0xAE,
                    0xA5,
                    0x05
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12VideoDevice1
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAD, 0x11, 0x16, 0x98,
                    0x44, 0xA1,
                    0x83, 0x4C,
                    0x98,
                    0x90,
                    0xF3,
                    0x0E,
                    0x26,
                    0xD6,
                    0x58,
                    0xAB
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12VideoEncodeCommandList
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3A, 0x29, 0x55, 0x84,
                    0xBD, 0x0C,
                    0x31, 0x48,
                    0x9B,
                    0x39,
                    0xFB,
                    0xDB,
                    0xAB,
                    0x72,
                    0x47,
                    0x23
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12VideoDecoder1
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFB, 0xE5, 0xA2, 0x79,
                    0xD2, 0xCC,
                    0x9A, 0x46,
                    0x9F,
                    0xDE,
                    0x19,
                    0x5D,
                    0x10,
                    0x95,
                    0x1F,
                    0x7E
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12VideoDecoderHeap1
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC5, 0x98, 0x1D, 0xDA,
                    0x9F, 0x53,
                    0xB2, 0x41,
                    0xBF,
                    0x6B,
                    0x11,
                    0x98,
                    0xA0,
                    0x3B,
                    0x6D,
                    0x26
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12VideoProcessor1
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x15, 0xE6, 0xCF, 0xF3,
                    0x3F, 0x55,
                    0x5C, 0x42,
                    0x86,
                    0xD8,
                    0xEE,
                    0x8C,
                    0x1B,
                    0x1F,
                    0xB0,
                    0x1C
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12VideoExtensionCommand
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE8, 0x41, 0x4E, 0x55,
                    0x8E, 0xAE,
                    0x8C, 0x4A,
                    0xB7,
                    0xD2,
                    0x5B,
                    0x4F,
                    0x27,
                    0x4A,
                    0x30,
                    0xE4
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12VideoDevice2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x49, 0xAC, 0x19, 0xF0,
                    0x38, 0xF8,
                    0x95, 0x4A,
                    0x9B,
                    0x17,
                    0x57,
                    0x94,
                    0x37,
                    0xC8,
                    0xF5,
                    0x13
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12VideoDecodeCommandList2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0x08, 0x12, 0x6E,
                    0x14, 0xC1,
                    0x53, 0x41,
                    0x80,
                    0x36,
                    0xD2,
                    0x47,
                    0x05,
                    0x1E,
                    0x17,
                    0x29
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12VideoProcessCommandList2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE4, 0x5A, 0x52, 0xDB,
                    0xD6, 0x6A,
                    0x3C, 0x47,
                    0xBA,
                    0xA7,
                    0x59,
                    0xB2,
                    0xE3,
                    0x70,
                    0x82,
                    0xE4
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12VideoEncodeCommandList1
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCA, 0x1E, 0x97, 0x94,
                    0xDB, 0x2B,
                    0x69, 0x47,
                    0x88,
                    0xCF,
                    0x36,
                    0x75,
                    0xEA,
                    0x75,
                    0x7E,
                    0xBC
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
