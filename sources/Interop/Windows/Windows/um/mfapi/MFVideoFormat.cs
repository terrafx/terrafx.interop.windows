// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static partial class MFVideoFormat
{
    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_Base"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_Base
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x00, 0x00, 0x00, 0x00,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_RGB32"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_RGB32
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x16, 0x00, 0x00, 0x00,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_ARGB32"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_ARGB32
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x15, 0x00, 0x00, 0x00,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_RGB24"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_RGB24
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x14, 0x00, 0x00, 0x00,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_RGB555"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_RGB555
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x18, 0x00, 0x00, 0x00,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_RGB565"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_RGB565
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x17, 0x00, 0x00, 0x00,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_RGB8"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_RGB8
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x29, 0x00, 0x00, 0x00,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_L8"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_L8
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x32, 0x00, 0x00, 0x00,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_L16"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_L16
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x51, 0x00, 0x00, 0x00,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_D16"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_D16
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_AI44"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_AI44
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_AYUV"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_AYUV
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_YUY2"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_YUY2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_YVYU"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_YVYU
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_YVU9"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_YVU9
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_UYVY"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_UYVY
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_NV11"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_NV11
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_NV12"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_NV12
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_NV21"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_NV21
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4E, 0x56, 0x32, 0x31,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_YV12"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_YV12
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_I420"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_I420
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x49, 0x34, 0x32, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_I422"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_I422
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x49, 0x34, 0x32, 0x32,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_I444"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_I444
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x49, 0x34, 0x34, 0x34,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_IYUV"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_IYUV
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_Y210"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_Y210
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_Y216"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_Y216
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_Y410"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_Y410
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x59, 0x34, 0x31, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_Y416"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_Y416
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x59, 0x34, 0x31, 0x36,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_Y41P"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_Y41P
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_Y41T"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_Y41T
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x59, 0x34, 0x31, 0x54,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_Y42T"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_Y42T
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x59, 0x34, 0x32, 0x54,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_P210"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_P210
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_P216"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_P216
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_P010"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_P010
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_P016"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_P016
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_v210"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_v210
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x76, 0x32, 0x31, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_v216"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_v216
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x76, 0x32, 0x31, 0x36,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_v410"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_v410
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x76, 0x34, 0x31, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_MP43"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_MP43
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4D, 0x50, 0x34, 0x33,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_MP4S"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_MP4S
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4D, 0x50, 0x34, 0x53,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_M4S2"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_M4S2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4D, 0x34, 0x53, 0x32,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_MP4V"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_MP4V
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4D, 0x50, 0x34, 0x56,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_WMV1"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_WMV1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x57, 0x4D, 0x56, 0x31,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_WMV2"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_WMV2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x57, 0x4D, 0x56, 0x32,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_WMV3"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_WMV3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x57, 0x4D, 0x56, 0x33,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_WVC1"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_WVC1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x57, 0x56, 0x43, 0x31,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_MSS1"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_MSS1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4D, 0x53, 0x53, 0x31,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_MSS2"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_MSS2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4D, 0x53, 0x53, 0x32,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_MPG1"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_MPG1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4D, 0x50, 0x47, 0x31,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_DVSL"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_DVSL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_DVSD"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_DVSD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_DVHD"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_DVHD
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_DV25"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_DV25
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_DV50"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_DV50
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_DVH1"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_DVH1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_DVC"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_DVC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x64, 0x76, 0x63, 0x20,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_H264"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_H264
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_H265"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_H265
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x48, 0x32, 0x36, 0x35,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_MJPG"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_MJPG
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_420O"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_420O
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_HEVC"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_HEVC
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x48, 0x45, 0x56, 0x43,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_HEVC_ES"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_HEVC_ES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x48, 0x45, 0x56, 0x53,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_VP80"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_VP80
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x56, 0x50, 0x38, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_VP90"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_VP90
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x56, 0x50, 0x39, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_ORAW"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_ORAW
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x4F, 0x52, 0x41, 0x57,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_H263"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_H263
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x48, 0x32, 0x36, 0x33,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_A2R10G10B10"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_A2R10G10B10
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x1F, 0x00, 0x00, 0x00,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_A16B16G16R16F"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_A16B16G16R16F
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x71, 0x00, 0x00, 0x00,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_VP10"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_VP10
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x56, 0x50, 0x31, 0x30,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_AV1"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_AV1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x41, 0x56, 0x30, 0x31,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_Theora"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_Theora
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x74, 0x68, 0x65, 0x6F,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_APV"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_APV
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x41, 0x50, 0x56, 0x20,
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
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_H264_ES"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_H264_ES
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xF0, 0xF4, 0x40, 0x3F,
                0x22, 0x56,
                0xF8, 0x4F,
                0xB6,
                0xD8,
                0xA1,
                0x7A,
                0x58,
                0x4B,
                0xEE,
                0x5E
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_MPEG2"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_MPEG2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x26, 0x80, 0x6D, 0xE0,
                0x46, 0xDB,
                0xCF, 0x11,
                0xB4,
                0xD1,
                0x00,
                0x80,
                0x5F,
                0x6C,
                0xBB,
                0xEA
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_H264_HDCP"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_H264_HDCP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xDD, 0xE9, 0x0C, 0x5D,
                0x17, 0x98,
                0xDA, 0x49,
                0xBD,
                0xFD,
                0xF5,
                0xF5,
                0xB9,
                0x8F,
                0x18,
                0xA6
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_HEVC_HDCP"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_HEVC_HDCP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xE6, 0x0F, 0xFE, 0x3C,
                0xC4, 0x05,
                0xDC, 0x47,
                0x9D,
                0x70,
                0x4B,
                0xDB,
                0x29,
                0x59,
                0x72,
                0x0F
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_Base_HDCP"]/*' />
    [NativeTypeName("const GUID")]
    public static ref readonly Guid MFVideoFormat_Base_HDCP
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0xD5, 0xB9, 0xC3, 0xEA,
                0x14, 0xBD,
                0x37, 0x42,
                0x8F,
                0x1F,
                0xBA,
                0xB4,
                0x28,
                0xE4,
                0x93,
                0x12
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='MFVideoFormat.xml' path='doc/member[@name="MFVideoFormat.MFVideoFormat_MPG2"]/*' />
    [NativeTypeName("#define MFVideoFormat_MPG2 MFVideoFormat_MPEG2")]
    public static ref readonly Guid MFVideoFormat_MPG2 => ref MFVideoFormat_MPEG2;
}
