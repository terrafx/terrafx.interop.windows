// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public static partial class Windows
    {
        [NativeTypeName("#define AUDIOCLOCK_CHARACTERISTIC_FIXED_FREQ 0x00000001")]
        public const int AUDIOCLOCK_CHARACTERISTIC_FIXED_FREQ = 0x00000001;

        [NativeTypeName("#define AMBISONICS_PARAM_VERSION_1 1")]
        public const int AMBISONICS_PARAM_VERSION_1 = 1;

        [NativeTypeName("#define AUDCLNT_E_NOT_INITIALIZED AUDCLNT_ERR(0x001)")]
        public const int AUDCLNT_E_NOT_INITIALIZED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x001))));

        [NativeTypeName("#define AUDCLNT_E_ALREADY_INITIALIZED AUDCLNT_ERR(0x002)")]
        public const int AUDCLNT_E_ALREADY_INITIALIZED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x002))));

        [NativeTypeName("#define AUDCLNT_E_WRONG_ENDPOINT_TYPE AUDCLNT_ERR(0x003)")]
        public const int AUDCLNT_E_WRONG_ENDPOINT_TYPE = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x003))));

        [NativeTypeName("#define AUDCLNT_E_DEVICE_INVALIDATED AUDCLNT_ERR(0x004)")]
        public const int AUDCLNT_E_DEVICE_INVALIDATED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x004))));

        [NativeTypeName("#define AUDCLNT_E_NOT_STOPPED AUDCLNT_ERR(0x005)")]
        public const int AUDCLNT_E_NOT_STOPPED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x005))));

        [NativeTypeName("#define AUDCLNT_E_BUFFER_TOO_LARGE AUDCLNT_ERR(0x006)")]
        public const int AUDCLNT_E_BUFFER_TOO_LARGE = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x006))));

        [NativeTypeName("#define AUDCLNT_E_OUT_OF_ORDER AUDCLNT_ERR(0x007)")]
        public const int AUDCLNT_E_OUT_OF_ORDER = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x007))));

        [NativeTypeName("#define AUDCLNT_E_UNSUPPORTED_FORMAT AUDCLNT_ERR(0x008)")]
        public const int AUDCLNT_E_UNSUPPORTED_FORMAT = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x008))));

        [NativeTypeName("#define AUDCLNT_E_INVALID_SIZE AUDCLNT_ERR(0x009)")]
        public const int AUDCLNT_E_INVALID_SIZE = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x009))));

        [NativeTypeName("#define AUDCLNT_E_DEVICE_IN_USE AUDCLNT_ERR(0x00a)")]
        public const int AUDCLNT_E_DEVICE_IN_USE = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x00a))));

        [NativeTypeName("#define AUDCLNT_E_BUFFER_OPERATION_PENDING AUDCLNT_ERR(0x00b)")]
        public const int AUDCLNT_E_BUFFER_OPERATION_PENDING = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x00b))));

        [NativeTypeName("#define AUDCLNT_E_THREAD_NOT_REGISTERED AUDCLNT_ERR(0x00c)")]
        public const int AUDCLNT_E_THREAD_NOT_REGISTERED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x00c))));

        [NativeTypeName("#define AUDCLNT_E_EXCLUSIVE_MODE_NOT_ALLOWED AUDCLNT_ERR(0x00e)")]
        public const int AUDCLNT_E_EXCLUSIVE_MODE_NOT_ALLOWED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x00e))));

        [NativeTypeName("#define AUDCLNT_E_ENDPOINT_CREATE_FAILED AUDCLNT_ERR(0x00f)")]
        public const int AUDCLNT_E_ENDPOINT_CREATE_FAILED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x00f))));

        [NativeTypeName("#define AUDCLNT_E_SERVICE_NOT_RUNNING AUDCLNT_ERR(0x010)")]
        public const int AUDCLNT_E_SERVICE_NOT_RUNNING = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x010))));

        [NativeTypeName("#define AUDCLNT_E_EVENTHANDLE_NOT_EXPECTED AUDCLNT_ERR(0x011)")]
        public const int AUDCLNT_E_EVENTHANDLE_NOT_EXPECTED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x011))));

        [NativeTypeName("#define AUDCLNT_E_EXCLUSIVE_MODE_ONLY AUDCLNT_ERR(0x012)")]
        public const int AUDCLNT_E_EXCLUSIVE_MODE_ONLY = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x012))));

        [NativeTypeName("#define AUDCLNT_E_BUFDURATION_PERIOD_NOT_EQUAL AUDCLNT_ERR(0x013)")]
        public const int AUDCLNT_E_BUFDURATION_PERIOD_NOT_EQUAL = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x013))));

        [NativeTypeName("#define AUDCLNT_E_EVENTHANDLE_NOT_SET AUDCLNT_ERR(0x014)")]
        public const int AUDCLNT_E_EVENTHANDLE_NOT_SET = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x014))));

        [NativeTypeName("#define AUDCLNT_E_INCORRECT_BUFFER_SIZE AUDCLNT_ERR(0x015)")]
        public const int AUDCLNT_E_INCORRECT_BUFFER_SIZE = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x015))));

        [NativeTypeName("#define AUDCLNT_E_BUFFER_SIZE_ERROR AUDCLNT_ERR(0x016)")]
        public const int AUDCLNT_E_BUFFER_SIZE_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x016))));

        [NativeTypeName("#define AUDCLNT_E_CPUUSAGE_EXCEEDED AUDCLNT_ERR(0x017)")]
        public const int AUDCLNT_E_CPUUSAGE_EXCEEDED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x017))));

        [NativeTypeName("#define AUDCLNT_E_BUFFER_ERROR AUDCLNT_ERR(0x018)")]
        public const int AUDCLNT_E_BUFFER_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x018))));

        [NativeTypeName("#define AUDCLNT_E_BUFFER_SIZE_NOT_ALIGNED AUDCLNT_ERR(0x019)")]
        public const int AUDCLNT_E_BUFFER_SIZE_NOT_ALIGNED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x019))));

        [NativeTypeName("#define AUDCLNT_E_INVALID_DEVICE_PERIOD AUDCLNT_ERR(0x020)")]
        public const int AUDCLNT_E_INVALID_DEVICE_PERIOD = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x020))));

        [NativeTypeName("#define AUDCLNT_E_INVALID_STREAM_FLAG AUDCLNT_ERR(0x021)")]
        public const int AUDCLNT_E_INVALID_STREAM_FLAG = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x021))));

        [NativeTypeName("#define AUDCLNT_E_ENDPOINT_OFFLOAD_NOT_CAPABLE AUDCLNT_ERR(0x022)")]
        public const int AUDCLNT_E_ENDPOINT_OFFLOAD_NOT_CAPABLE = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x022))));

        [NativeTypeName("#define AUDCLNT_E_OUT_OF_OFFLOAD_RESOURCES AUDCLNT_ERR(0x023)")]
        public const int AUDCLNT_E_OUT_OF_OFFLOAD_RESOURCES = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x023))));

        [NativeTypeName("#define AUDCLNT_E_OFFLOAD_MODE_ONLY AUDCLNT_ERR(0x024)")]
        public const int AUDCLNT_E_OFFLOAD_MODE_ONLY = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x024))));

        [NativeTypeName("#define AUDCLNT_E_NONOFFLOAD_MODE_ONLY AUDCLNT_ERR(0x025)")]
        public const int AUDCLNT_E_NONOFFLOAD_MODE_ONLY = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x025))));

        [NativeTypeName("#define AUDCLNT_E_RESOURCES_INVALIDATED AUDCLNT_ERR(0x026)")]
        public const int AUDCLNT_E_RESOURCES_INVALIDATED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x026))));

        [NativeTypeName("#define AUDCLNT_E_RAW_MODE_UNSUPPORTED AUDCLNT_ERR(0x027)")]
        public const int AUDCLNT_E_RAW_MODE_UNSUPPORTED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x027))));

        [NativeTypeName("#define AUDCLNT_E_ENGINE_PERIODICITY_LOCKED AUDCLNT_ERR(0x028)")]
        public const int AUDCLNT_E_ENGINE_PERIODICITY_LOCKED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x028))));

        [NativeTypeName("#define AUDCLNT_E_ENGINE_FORMAT_LOCKED AUDCLNT_ERR(0x029)")]
        public const int AUDCLNT_E_ENGINE_FORMAT_LOCKED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x029))));

        [NativeTypeName("#define AUDCLNT_E_HEADTRACKING_ENABLED AUDCLNT_ERR(0x030)")]
        public const int AUDCLNT_E_HEADTRACKING_ENABLED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x030))));

        [NativeTypeName("#define AUDCLNT_E_HEADTRACKING_UNSUPPORTED AUDCLNT_ERR(0x040)")]
        public const int AUDCLNT_E_HEADTRACKING_UNSUPPORTED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x040))));

        [NativeTypeName("#define AUDCLNT_S_BUFFER_EMPTY AUDCLNT_SUCCESS(0x001)")]
        public const int AUDCLNT_S_BUFFER_EMPTY = unchecked((int)(((uint)(0) << 31) | ((uint)(2185) << 16) | ((uint)(0x001))));

        [NativeTypeName("#define AUDCLNT_S_THREAD_ALREADY_REGISTERED AUDCLNT_SUCCESS(0x002)")]
        public const int AUDCLNT_S_THREAD_ALREADY_REGISTERED = unchecked((int)(((uint)(0) << 31) | ((uint)(2185) << 16) | ((uint)(0x002))));

        [NativeTypeName("#define AUDCLNT_S_POSITION_STALLED AUDCLNT_SUCCESS(0x003)")]
        public const int AUDCLNT_S_POSITION_STALLED = unchecked((int)(((uint)(0) << 31) | ((uint)(2185) << 16) | ((uint)(0x003))));

        public static ref readonly Guid IID_IAudioClient
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4C, 0xAD, 0xB9, 0x1C,
                    0xFA, 0xDB,
                    0x32, 0x4C,
                    0xB1,
                    0x78,
                    0xC2,
                    0xF5,
                    0x68,
                    0xA7,
                    0x03,
                    0xB2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAudioClient2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCD, 0x78, 0x67, 0x72,
                    0x0A, 0xF6,
                    0xDA, 0x4E,
                    0x82,
                    0xDE,
                    0xE4,
                    0x76,
                    0x10,
                    0xCD,
                    0x78,
                    0xAA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAudioClient3
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x07, 0xEE, 0xD4, 0x7E,
                    0x67, 0x8E,
                    0xD4, 0x4C,
                    0x8C,
                    0x1A,
                    0x2B,
                    0x7A,
                    0x59,
                    0x87,
                    0xAD,
                    0x42
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAudioRenderClient
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFC, 0xAC, 0x94, 0xF2,
                    0x46, 0x31,
                    0x83, 0x44,
                    0xA7,
                    0xBF,
                    0xAD,
                    0xDC,
                    0xA7,
                    0xC2,
                    0x60,
                    0xE2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAudioCaptureClient
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0xBD, 0xAD, 0xC8,
                    0x1E, 0xE7,
                    0xA0, 0x48,
                    0xA4,
                    0xDE,
                    0x18,
                    0x5C,
                    0x39,
                    0x5C,
                    0xD3,
                    0x17
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAudioClock
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4F, 0x31, 0x63, 0xCD,
                    0xBA, 0x3F,
                    0x1B, 0x4A,
                    0x81,
                    0x2C,
                    0xEF,
                    0x96,
                    0x35,
                    0x87,
                    0x28,
                    0xE7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAudioClock2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x73, 0xFF, 0x49, 0x6F,
                    0x27, 0x67,
                    0xAC, 0x49,
                    0xA0,
                    0x08,
                    0xD9,
                    0x8C,
                    0xF5,
                    0xE7,
                    0x00,
                    0x48
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAudioClockAdjustment
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0xC0, 0xE4, 0xF6,
                    0xD9, 0x46,
                    0xB8, 0x4F,
                    0xBE,
                    0x21,
                    0x57,
                    0xA3,
                    0xEF,
                    0x2B,
                    0x62,
                    0x6C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ISimpleAudioVolume
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x98, 0x54, 0xCE, 0x87,
                    0xD6, 0x68,
                    0xE5, 0x44,
                    0x92,
                    0x15,
                    0x6D,
                    0xA4,
                    0x7E,
                    0xF8,
                    0x83,
                    0xD8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAudioClientDuckingControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x81, 0xD3, 0x89, 0xC7,
                    0x8C, 0xA2,
                    0x68, 0x41,
                    0xB2,
                    0x8F,
                    0xD3,
                    0xA8,
                    0x37,
                    0x92,
                    0x4D,
                    0xC3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAudioStreamVolume
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x87, 0x48, 0x01, 0x93,
                    0x2D, 0x24,
                    0x68, 0x40,
                    0x8A,
                    0x15,
                    0xCF,
                    0x5E,
                    0x93,
                    0xB9,
                    0x0F,
                    0xE3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IAudioAmbisonicsControl
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x91, 0x4C, 0x72, 0x28,
                    0x35, 0xDF,
                    0x56, 0x48,
                    0x9F,
                    0x76,
                    0xD6,
                    0xA2,
                    0x64,
                    0x13,
                    0xF3,
                    0xDF
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IChannelAudioVolume
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x61, 0x88, 0x15, 0x1C,
                    0x33, 0xB5,
                    0x30, 0x4B,
                    0xB1,
                    0xCF,
                    0xE8,
                    0x53,
                    0xE5,
                    0x1C,
                    0x59,
                    0xB8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
