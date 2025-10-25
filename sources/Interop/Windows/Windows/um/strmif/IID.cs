// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static partial class IID
{
    [NativeTypeName("const IID")]
    public static ref readonly Guid IID_IAMFilterGraphCallback
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICreateDevEnum
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPin
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumPins
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumMediaTypes
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFilterGraph
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumFilters
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMediaFilter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IBaseFilter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IReferenceClock
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IReferenceClockTimerControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IReferenceClock2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMediaSample
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMediaSample2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMediaSample2Config
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMemAllocator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMemAllocatorCallbackTemp
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMemAllocatorNotifyCallbackTemp
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMemInputPin
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMovieSetup
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMediaSeeking
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICodecAPI
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumRegFilters
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFilterMapper
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFilterMapper2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFilterMapper3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IQualityControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IOverlayNotify
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IOverlayNotify2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IOverlay
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMediaEventSink
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFileSourceFilter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFileSinkFilter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFileSinkFilter2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IGraphBuilder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICaptureGraphBuilder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMCopyCaptureFileProgress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ICaptureGraphBuilder2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFilterGraph2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFilterGraph3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IStreamBuilder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAsyncReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IGraphVersion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IResourceConsumer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IResourceManager
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDistributorNotify
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMStreamControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_ISeekingPassThru
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMStreamConfig
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IConfigInterleaving
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IConfigAviMux
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMVideoCompression
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMVfwCaptureDialogs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMVfwCompressDialogs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMDroppedFrames
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMAudioInputMixer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMBufferNegotiation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMAnalogVideoDecoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMVideoProcAmp
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMCameraControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMVideoControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMCrossbar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMTuner
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMTunerNotification
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMTVTuner
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IBPCSatelliteTuner
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMTVAudio
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMTVAudioNotification
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMAnalogVideoEncoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IKsPropertySet
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMediaPropertyBag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPersistMediaPropertyBag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMPhysicalPinInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMExtDevice
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMExtTransport
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMTimecodeReader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMTimecodeGenerator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMTimecodeDisplay
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMDevMemoryAllocator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMDevMemoryControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMStreamSelect
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMResourceControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMClockAdjust
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMFilterMiscFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDrawVideoImage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDecimateVideoImage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMVideoDecimationProperties
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVideoFrameStep
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMLatency
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMPushSource
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMDeviceRemoval
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDVEnc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IIPDVDec
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDVRGB219
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDVSplitter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMAudioRendererStats
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMGraphStreams
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMOverlayFX
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMOpenProgress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMpeg2Demultiplexer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEnumStreamIdMap
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IMPEG2StreamIdMap
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IRegisterServiceProvider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMClockSlave
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMGraphBuilderCallback
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IGetCapabilitiesKey
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IEncoderAPI
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVideoEncoder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMDecoderCaps
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMCertifiedOutputProtection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMAsyncReaderTimestampScaling
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IAMPluginControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPinConnection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IPinFlowControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IGraphConfig
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IGraphConfigCallback
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IFilterChain
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVMRImagePresenter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVMRSurfaceAllocator
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVMRSurfaceAllocatorNotify
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVMRWindowlessControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVMRMixerControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVMRMonitorConfig
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVMRFilterConfig
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVMRAspectRatioControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVMRDeinterlaceControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVMRMixerBitmap
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVMRImageCompositor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVMRVideoStreamControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVMRSurface
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVMRImagePresenterConfig
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVMRImagePresenterExclModeConfig
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IVPManager
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDvdControl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDvdInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDvdCmd
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDvdState
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDvdControl2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDvdInfo2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDvdGraphBuilder
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDDrawExclModeVideo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    public static ref readonly Guid IID_IDDrawExclModeVideoCallback
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }
}
