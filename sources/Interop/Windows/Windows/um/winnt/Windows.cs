// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.POWER_PLATFORM_ROLE;
using static TerraFX.Interop.Windows.SECURITY_IMPERSONATION_LEVEL;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MAX_POWER_SAVINGS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x08, 0x13, 0x84, 0xA1,
                    0x41, 0x35,
                    0xAB, 0x4F,
                    0xBC,
                    0x81,
                    0xF7,
                    0x15,
                    0x56,
                    0xF2,
                    0x0B,
                    0x4A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MIN_POWER_SAVINGS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDA, 0x7F, 0x5E, 0x8C,
                    0xBF, 0xE8,
                    0x96, 0x4A,
                    0x9A,
                    0x85,
                    0xA6,
                    0xE2,
                    0x3A,
                    0x8C,
                    0x63,
                    0x5C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_TYPICAL_POWER_SAVINGS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x22, 0x42, 0x1B, 0x38,
                    0x94, 0xF6,
                    0xF0, 0x41,
                    0x96,
                    0x85,
                    0xFF,
                    0x5B,
                    0xB2,
                    0x60,
                    0xDF,
                    0x2E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid NO_SUBGROUP_GUID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3E, 0x41, 0xA3, 0xFE,
                    0x05, 0x7E,
                    0x11, 0x49,
                    0x9A,
                    0x71,
                    0x70,
                    0x03,
                    0x31,
                    0xF1,
                    0xC2,
                    0x94
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid ALL_POWERSCHEMES_GUID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5E, 0xE9, 0xA1, 0x68,
                    0xEA, 0x13,
                    0xE1, 0x41,
                    0x80,
                    0x11,
                    0x0C,
                    0x49,
                    0x6C,
                    0xA4,
                    0x90,
                    0xB0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_POWERSCHEME_PERSONALITY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x41, 0x85, 0x5D, 0x24,
                    0x43, 0x39,
                    0x22, 0x44,
                    0xB0,
                    0x25,
                    0x13,
                    0xA7,
                    0x84,
                    0xF6,
                    0x79,
                    0xB7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_ACTIVE_POWERSCHEME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x86, 0xF2, 0xF9, 0x31,
                    0x84, 0x50,
                    0xFE, 0x42,
                    0xB7,
                    0x20,
                    0x2B,
                    0x02,
                    0x64,
                    0x99,
                    0x37,
                    0x63
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_IDLE_RESILIENCY_SUBGROUP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x30, 0x11, 0x60, 0x2E,
                    0x51, 0x53,
                    0x9D, 0x4D,
                    0x8E,
                    0x04,
                    0x25,
                    0x29,
                    0x66,
                    0xBA,
                    0xD0,
                    0x54
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_IDLE_RESILIENCY_PERIOD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAA, 0x79, 0x2B, 0xC4,
                    0x3A, 0xAA,
                    0x4B, 0x48,
                    0xA9,
                    0x8F,
                    0x2C,
                    0xF3,
                    0x2A,
                    0xA9,
                    0x0A,
                    0x28
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_DEEP_SLEEP_ENABLED
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEE, 0xF7, 0x02, 0xD5,
                    0xC7, 0x1D,
                    0xFD, 0x4E,
                    0xA5,
                    0x5D,
                    0xF0,
                    0x4B,
                    0x6F,
                    0x5C,
                    0x05,
                    0x45
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_DEEP_SLEEP_PLATFORM_STATE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB8, 0x2F, 0x3F, 0xD2,
                    0x36, 0x95,
                    0x38, 0x40,
                    0x9C,
                    0x94,
                    0x1C,
                    0xE0,
                    0x2E,
                    0x5C,
                    0x21,
                    0x52
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_DISK_COALESCING_POWERDOWN_TIMEOUT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB4, 0x0E, 0x6F, 0xC3,
                    0x88, 0x29,
                    0x70, 0x4A,
                    0x8E,
                    0xEE,
                    0x08,
                    0x84,
                    0xFC,
                    0x2C,
                    0x24,
                    0x33
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_EXECUTION_REQUIRED_REQUEST_TIMEOUT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x41, 0xBC, 0x66, 0x31,
                    0x98, 0x7E,
                    0x03, 0x4E,
                    0xB3,
                    0x4E,
                    0xEC,
                    0x0F,
                    0x5F,
                    0x2B,
                    0x21,
                    0x8E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_VIDEO_SUBGROUP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5F, 0xB9, 0x16, 0x75,
                    0x76, 0xF7,
                    0x64, 0x44,
                    0x8C,
                    0x53,
                    0x06,
                    0x16,
                    0x7F,
                    0x40,
                    0xCC,
                    0x99
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_VIDEO_POWERDOWN_TIMEOUT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x21, 0xC0, 0x0B, 0x3C,
                    0xA8, 0xC8,
                    0x07, 0x4E,
                    0xA9,
                    0x73,
                    0x6B,
                    0x14,
                    0xCB,
                    0xCB,
                    0x2B,
                    0x7E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_VIDEO_ANNOYANCE_TIMEOUT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2D, 0xCF, 0xDB, 0x82,
                    0x67, 0xCD,
                    0xC5, 0x40,
                    0xBF,
                    0xDC,
                    0x9F,
                    0x1A,
                    0x5C,
                    0xCD,
                    0x46,
                    0x63
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_VIDEO_ADAPTIVE_PERCENT_INCREASE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDF, 0x04, 0xD9, 0xEE,
                    0x42, 0xB1,
                    0x83, 0x41,
                    0xB1,
                    0x0B,
                    0x5A,
                    0x11,
                    0x97,
                    0xA3,
                    0x78,
                    0x64
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_VIDEO_DIM_TIMEOUT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9B, 0xA2, 0xAA, 0x17,
                    0x43, 0x8B,
                    0x94, 0x4B,
                    0xAA,
                    0xFE,
                    0x35,
                    0xF6,
                    0x4D,
                    0xAA,
                    0xF1,
                    0xEE
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_VIDEO_ADAPTIVE_POWERDOWN
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x22, 0x9D, 0x95, 0x90,
                    0xA1, 0xD6,
                    0xB9, 0x49,
                    0xAF,
                    0x93,
                    0xBC,
                    0xE8,
                    0x85,
                    0xAD,
                    0x33,
                    0x5B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MONITOR_POWER_ON
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x15, 0x10, 0x73, 0x02,
                    0x10, 0x45,
                    0x26, 0x45,
                    0x99,
                    0xE6,
                    0xE5,
                    0xA1,
                    0x7E,
                    0xBD,
                    0x1A,
                    0xEA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_DEVICE_POWER_POLICY_VIDEO_BRIGHTNESS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x82, 0x5E, 0xED, 0xAD,
                    0x09, 0xB9,
                    0x19, 0x46,
                    0x99,
                    0x49,
                    0xF5,
                    0xD7,
                    0x1D,
                    0xAC,
                    0x0B,
                    0xCB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_DEVICE_POWER_POLICY_VIDEO_DIM_BRIGHTNESS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE2, 0xFD, 0xFB, 0xF1,
                    0x60, 0xA9,
                    0x65, 0x41,
                    0x9F,
                    0x88,
                    0x50,
                    0x66,
                    0x79,
                    0x11,
                    0xCE,
                    0x96
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_VIDEO_CURRENT_MONITOR_BRIGHTNESS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC6, 0xE2, 0xFE, 0x8F,
                    0x01, 0x2D,
                    0xBE, 0x46,
                    0xAD,
                    0xB9,
                    0x39,
                    0x8A,
                    0xDD,
                    0xC5,
                    0xB4,
                    0xFF
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_VIDEO_ADAPTIVE_DISPLAY_BRIGHTNESS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x66, 0xAA, 0xD9, 0xFB,
                    0x53, 0x95,
                    0x97, 0x40,
                    0xBA,
                    0x44,
                    0xED,
                    0x6E,
                    0x9D,
                    0x65,
                    0xEA,
                    0xB8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_CONSOLE_DISPLAY_STATE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x56, 0x95, 0xE6, 0x6F,
                    0x4A, 0x70,
                    0xA0, 0x47,
                    0x8F,
                    0x24,
                    0xC2,
                    0x8D,
                    0x93,
                    0x6F,
                    0xDA,
                    0x47
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_ALLOW_DISPLAY_REQUIRED
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDA, 0xB8, 0xCE, 0xA9,
                    0x46, 0xCD,
                    0xFB, 0x44,
                    0xA9,
                    0x8B,
                    0x02,
                    0xAF,
                    0x69,
                    0xDE,
                    0x46,
                    0x23
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_VIDEO_CONSOLE_LOCK_TIMEOUT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA5, 0xB3, 0xC4, 0x8E,
                    0x68, 0x68,
                    0xC2, 0x48,
                    0xBE,
                    0x75,
                    0x4F,
                    0x30,
                    0x44,
                    0xBE,
                    0x88,
                    0xA7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_ADVANCED_COLOR_QUALITY_BIAS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x69, 0x3E, 0x4C, 0x68,
                    0xF7, 0xA4,
                    0x14, 0x40,
                    0x87,
                    0x54,
                    0xD4,
                    0x51,
                    0x79,
                    0xA5,
                    0x61,
                    0x67
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_ADAPTIVE_POWER_BEHAVIOR_SUBGROUP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x16, 0xB9, 0x19, 0x86,
                    0x04, 0xE0,
                    0xD8, 0x4D,
                    0x9B,
                    0x66,
                    0xDA,
                    0xE8,
                    0x6F,
                    0x80,
                    0x66,
                    0x98
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_NON_ADAPTIVE_INPUT_TIMEOUT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBC, 0xBF, 0xDB, 0x5A,
                    0x4E, 0x07,
                    0xA1, 0x4D,
                    0xBA,
                    0x38,
                    0xDB,
                    0x8B,
                    0x36,
                    0xB2,
                    0xC8,
                    0xF3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_ADAPTIVE_INPUT_CONTROLLER_STATE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE9, 0xFA, 0x98, 0x0E,
                    0x5A, 0xF4,
                    0xE1, 0x4D,
                    0xA7,
                    0x57,
                    0x60,
                    0x31,
                    0xF1,
                    0x97,
                    0xF6,
                    0xEA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_DISK_SUBGROUP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x47, 0xEE, 0x12, 0x00,
                    0x41, 0x90,
                    0x5D, 0x4B,
                    0x9B,
                    0x77,
                    0x53,
                    0x5F,
                    0xBA,
                    0x8B,
                    0x14,
                    0x42
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_DISK_MAX_POWER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0xA5, 0xDE, 0x51,
                    0x38, 0xBB,
                    0xC4, 0x4B,
                    0x99,
                    0x1B,
                    0xEA,
                    0xCF,
                    0x37,
                    0xBE,
                    0x5E,
                    0xC8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_DISK_POWERDOWN_TIMEOUT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC4, 0xE2, 0x38, 0x67,
                    0xA5, 0xE8,
                    0x42, 0x4A,
                    0xB1,
                    0x6A,
                    0xE0,
                    0x40,
                    0xE7,
                    0x69,
                    0x75,
                    0x6E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_DISK_IDLE_TIMEOUT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA8, 0x9B, 0xE3, 0x58,
                    0xE6, 0xB8,
                    0xF6, 0x4E,
                    0x90,
                    0xD0,
                    0x89,
                    0xAE,
                    0x32,
                    0xB2,
                    0x58,
                    0xD6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_DISK_BURST_IGNORE_THRESHOLD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0E, 0xC6, 0xE3, 0x80,
                    0x94, 0xBB,
                    0xD8, 0x4A,
                    0xBB,
                    0xE0,
                    0x0D,
                    0x31,
                    0x95,
                    0xEF,
                    0xC6,
                    0x63
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_DISK_ADAPTIVE_POWERDOWN
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE1, 0x32, 0x6A, 0x39,
                    0x9A, 0x49,
                    0xB2, 0x40,
                    0x91,
                    0x24,
                    0xA9,
                    0x6A,
                    0xFE,
                    0x70,
                    0x76,
                    0x67
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_DISK_NVME_NOPPME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB6, 0x72, 0x73, 0xFC,
                    0x2D, 0xAB,
                    0xEE, 0x43,
                    0x87,
                    0x97,
                    0x15,
                    0xE9,
                    0x84,
                    0x1F,
                    0x2C,
                    0xCA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_SLEEP_SUBGROUP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA8, 0x9F, 0x8C, 0x23,
                    0xAD, 0x0A,
                    0xED, 0x41,
                    0x83,
                    0xF4,
                    0x97,
                    0xBE,
                    0x24,
                    0x2C,
                    0x8F,
                    0x20
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_SLEEP_IDLE_THRESHOLD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE0, 0x32, 0xCD, 0x81,
                    0x33, 0x78,
                    0xF3, 0x44,
                    0x87,
                    0x37,
                    0x70,
                    0x81,
                    0xF3,
                    0x8D,
                    0x1F,
                    0x70
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_STANDBY_TIMEOUT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDB, 0xC1, 0xF6, 0x29,
                    0xDA, 0x86,
                    0xC5, 0x48,
                    0x9F,
                    0xDB,
                    0xF2,
                    0xB6,
                    0x7B,
                    0x1F,
                    0x44,
                    0xDA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_UNATTEND_SLEEP_TIMEOUT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF9, 0xA2, 0xC4, 0x7B,
                    0xFC, 0xD8,
                    0x69, 0x44,
                    0xB0,
                    0x7B,
                    0x33,
                    0xEB,
                    0x78,
                    0x5A,
                    0xAC,
                    0xA0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_HIBERNATE_TIMEOUT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA6, 0x15, 0x78, 0x9D,
                    0xE4, 0x7E,
                    0x7E, 0x49,
                    0x88,
                    0x88,
                    0x51,
                    0x5A,
                    0x05,
                    0xF0,
                    0x23,
                    0x64
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_HIBERNATE_FASTS4_POLICY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x29, 0x6D, 0xAC, 0x94,
                    0xCE, 0x73,
                    0xA6, 0x41,
                    0x80,
                    0x9F,
                    0x63,
                    0x63,
                    0xBA,
                    0x21,
                    0xB4,
                    0x7E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_CRITICAL_POWER_TRANSITION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x25, 0x70, 0xA2, 0xB7,
                    0x69, 0xE5,
                    0xC2, 0x46,
                    0xA5,
                    0x04,
                    0x2B,
                    0x96,
                    0xCA,
                    0xD2,
                    0x25,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_SYSTEM_AWAYMODE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x80, 0xF5, 0xA7, 0x98,
                    0xF7, 0x01,
                    0xAA, 0x48,
                    0x9C,
                    0x0F,
                    0x44,
                    0x35,
                    0x2C,
                    0x29,
                    0xE5,
                    0xC0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_ALLOW_AWAYMODE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x49, 0xA1, 0xDF, 0x25,
                    0xD1, 0x5D,
                    0x36, 0x47,
                    0xB5,
                    0xAB,
                    0xE8,
                    0xA3,
                    0x7B,
                    0x5B,
                    0x81,
                    0x87
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_USER_PRESENCE_PREDICTION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x05, 0x17, 0x01, 0x82,
                    0x95, 0xFB,
                    0x46, 0x4D,
                    0x8D,
                    0x35,
                    0x40,
                    0x42,
                    0xB1,
                    0xD2,
                    0x0D,
                    0xEF
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_STANDBY_BUDGET_GRACE_PERIOD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE1, 0x7F, 0xC0, 0x60,
                    0x56, 0x05,
                    0xCF, 0x45,
                    0x99,
                    0x03,
                    0xD5,
                    0x6E,
                    0x32,
                    0x21,
                    0x02,
                    0x42
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_STANDBY_BUDGET_PERCENT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBE, 0x27, 0xE5, 0x9F,
                    0x70, 0x1B,
                    0xDA, 0x48,
                    0x93,
                    0x0D,
                    0x7B,
                    0xCF,
                    0x17,
                    0xB4,
                    0x49,
                    0x90
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_STANDBY_RESERVE_GRACE_PERIOD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x92, 0xEE, 0x63, 0xC7,
                    0xE8, 0x71,
                    0x27, 0x41,
                    0x84,
                    0xEB,
                    0xF6,
                    0xED,
                    0x04,
                    0x3A,
                    0x3E,
                    0x3D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_STANDBY_RESERVE_TIME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE5, 0xE7, 0x8F, 0x46,
                    0x58, 0x11,
                    0xEC, 0x46,
                    0x88,
                    0xBC,
                    0x5B,
                    0x96,
                    0xC9,
                    0xE4,
                    0x4F,
                    0xD0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_STANDBY_RESET_PERCENT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA5, 0x11, 0xCB, 0x49,
                    0xE2, 0x56,
                    0xFB, 0x4A,
                    0x9D,
                    0x38,
                    0x3D,
                    0xF4,
                    0x78,
                    0x72,
                    0xE2,
                    0x1B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_ALLOW_STANDBY_STATES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x19, 0x25, 0xFC, 0xAB,
                    0x08, 0x36,
                    0x2A, 0x4C,
                    0x94,
                    0xEA,
                    0x17,
                    0x1B,
                    0x0E,
                    0xD5,
                    0x46,
                    0xAB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_ALLOW_RTC_WAKE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8A, 0x71, 0x3B, 0xBD,
                    0x80, 0x06,
                    0x9D, 0x4D,
                    0x8A,
                    0xB2,
                    0xE1,
                    0xD2,
                    0xB4,
                    0xAC,
                    0x80,
                    0x6D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_LEGACY_RTC_MITIGATION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC3, 0xBD, 0x34, 0x1A,
                    0x6B, 0x7E,
                    0x2E, 0x44,
                    0xA9,
                    0xD0,
                    0x64,
                    0xB6,
                    0xEF,
                    0x37,
                    0x8E,
                    0x84
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_ALLOW_SYSTEM_REQUIRED
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF5, 0x95, 0xB1, 0xA4,
                    0x25, 0x82,
                    0xD8, 0x47,
                    0x80,
                    0x12,
                    0x9D,
                    0x41,
                    0x36,
                    0x97,
                    0x86,
                    0xE2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_POWER_SAVING_STATUS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC0, 0x58, 0x09, 0xE0,
                    0x13, 0xC2,
                    0xCE, 0x4A,
                    0xAC,
                    0x77,
                    0xFE,
                    0xCC,
                    0xED,
                    0x2E,
                    0xEE,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_ENERGY_SAVER_SUBGROUP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x23, 0x09, 0x83, 0xDE,
                    0x62, 0xA5,
                    0xAF, 0x41,
                    0xA0,
                    0x86,
                    0xE3,
                    0xA2,
                    0xC6,
                    0xBA,
                    0xD2,
                    0xDA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_ENERGY_SAVER_BATTERY_THRESHOLD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCA, 0x53, 0x96, 0xE6,
                    0x7F, 0xCF,
                    0x05, 0x4F,
                    0xAA,
                    0x73,
                    0xCB,
                    0x83,
                    0x3F,
                    0xA9,
                    0x0A,
                    0xD4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_ENERGY_SAVER_BRIGHTNESS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x84, 0x98, 0xD0, 0x13,
                    0x4E, 0xF7,
                    0x4A, 0x47,
                    0xA8,
                    0x52,
                    0xB6,
                    0xBD,
                    0xE8,
                    0xAD,
                    0x03,
                    0xA8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_ENERGY_SAVER_POLICY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x49, 0xB3, 0x5B, 0x5C,
                    0x29, 0xAD,
                    0xE2, 0x4E,
                    0x9D,
                    0x0B,
                    0x2B,
                    0x25,
                    0x27,
                    0x0F,
                    0x7A,
                    0x81
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_SYSTEM_BUTTON_SUBGROUP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x89, 0x1E, 0x97, 0x4F,
                    0xBD, 0xEE,
                    0x55, 0x44,
                    0xA8,
                    0xDE,
                    0x9E,
                    0x59,
                    0x04,
                    0x0E,
                    0x73,
                    0x47
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_POWERBUTTON_ACTION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA3, 0xEF, 0x48, 0x76,
                    0x9C, 0xDD,
                    0x3E, 0x4E,
                    0xB5,
                    0x66,
                    0x50,
                    0xF9,
                    0x29,
                    0x38,
                    0x62,
                    0x80
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_SLEEPBUTTON_ACTION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC0, 0x6B, 0x99, 0x96,
                    0x50, 0xAD,
                    0xEC, 0x47,
                    0x92,
                    0x3B,
                    0x6F,
                    0x41,
                    0x87,
                    0x4D,
                    0xD9,
                    0xEB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_USERINTERFACEBUTTON_ACTION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x53, 0x66, 0x06, 0xA7,
                    0x6C, 0x8D,
                    0xA8, 0x40,
                    0x91,
                    0x0E,
                    0xA1,
                    0xF5,
                    0x4B,
                    0x84,
                    0xC7,
                    0xE5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_LIDCLOSE_ACTION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x67, 0x33, 0xA8, 0x5C,
                    0x45, 0x6E,
                    0x9F, 0x45,
                    0xA2,
                    0x7B,
                    0x47,
                    0x6B,
                    0x1D,
                    0x01,
                    0xC9,
                    0x36
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_LIDOPEN_POWERSTATE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE7, 0x10, 0xFF, 0x99,
                    0xB1, 0x23,
                    0x07, 0x4C,
                    0xA9,
                    0xD1,
                    0x5C,
                    0x32,
                    0x06,
                    0xD7,
                    0x41,
                    0xB4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_BATTERY_SUBGROUP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8D, 0x04, 0x3A, 0xE7,
                    0x27, 0xBF,
                    0x12, 0x4F,
                    0x97,
                    0x31,
                    0x8B,
                    0x20,
                    0x76,
                    0xE8,
                    0x89,
                    0x1F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_BATTERY_DISCHARGE_ACTION_0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2F, 0xA0, 0x7E, 0x63,
                    0xCB, 0xBB,
                    0x15, 0x40,
                    0x8E,
                    0x2C,
                    0xA1,
                    0xC7,
                    0xB9,
                    0xC0,
                    0xB5,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_BATTERY_DISCHARGE_LEVEL_0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD7, 0xD8, 0x66, 0x9A,
                    0xF7, 0x4F,
                    0xF9, 0x4E,
                    0xB5,
                    0xA2,
                    0x5A,
                    0x32,
                    0x6C,
                    0xA2,
                    0xA4,
                    0x69
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_BATTERY_DISCHARGE_FLAGS_0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9F, 0x7C, 0xBB, 0x5D,
                    0xE9, 0x38,
                    0xD2, 0x40,
                    0x97,
                    0x49,
                    0x4F,
                    0x8A,
                    0x0E,
                    0x9F,
                    0x64,
                    0x0F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_BATTERY_DISCHARGE_ACTION_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCB, 0x2D, 0x74, 0xD8,
                    0x6A, 0x3E,
                    0x3C, 0x4B,
                    0xB3,
                    0xFE,
                    0x37,
                    0x46,
                    0x23,
                    0xCD,
                    0xCF,
                    0x06
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_BATTERY_DISCHARGE_LEVEL_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9A, 0xBA, 0x83, 0x81,
                    0x10, 0xE9,
                    0xDA, 0x48,
                    0x87,
                    0x69,
                    0x14,
                    0xAE,
                    0x6D,
                    0xC1,
                    0x17,
                    0x0A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_BATTERY_DISCHARGE_FLAGS_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x51, 0xD9, 0xDE, 0xBC,
                    0x7B, 0x18,
                    0x05, 0x4D,
                    0xBC,
                    0xCC,
                    0xF7,
                    0xE5,
                    0x19,
                    0x60,
                    0xC2,
                    0x58
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_BATTERY_DISCHARGE_ACTION_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x38, 0xBA, 0x1C, 0x42,
                    0x8E, 0x1A,
                    0x81, 0x48,
                    0xAC,
                    0x89,
                    0xE3,
                    0x3A,
                    0x8B,
                    0x04,
                    0xEC,
                    0xE4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_BATTERY_DISCHARGE_LEVEL_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA2, 0x7C, 0xA0, 0x07,
                    0xAF, 0xAD,
                    0xD7, 0x40,
                    0xB0,
                    0x77,
                    0x53,
                    0x3A,
                    0xAD,
                    0xED,
                    0x1B,
                    0xFA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_BATTERY_DISCHARGE_FLAGS_2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC4, 0xF0, 0xD2, 0x7F,
                    0xB7, 0xFE,
                    0xA3, 0x4D,
                    0x81,
                    0x17,
                    0xE3,
                    0xFB,
                    0xED,
                    0xC4,
                    0x65,
                    0x82
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_BATTERY_DISCHARGE_ACTION_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x13, 0x26, 0x47, 0x80,
                    0x80, 0x97,
                    0x5E, 0x45,
                    0xB3,
                    0x08,
                    0x72,
                    0xD3,
                    0x00,
                    0x3C,
                    0xF2,
                    0xF8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_BATTERY_DISCHARGE_LEVEL_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA6, 0xD5, 0xAF, 0x58,
                    0xDD, 0xC2,
                    0xD2, 0x47,
                    0x9F,
                    0xBF,
                    0xEF,
                    0x70,
                    0xCC,
                    0x5C,
                    0x59,
                    0x65
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_BATTERY_DISCHARGE_FLAGS_3
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCF, 0x3C, 0x61, 0x73,
                    0xFA, 0xDB,
                    0x79, 0x42,
                    0x83,
                    0x56,
                    0x49,
                    0x35,
                    0xF6,
                    0xBF,
                    0x62,
                    0xF3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_SETTINGS_SUBGROUP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x51, 0x32, 0x53, 0x54,
                    0xBE, 0x82,
                    0x24, 0x48,
                    0x96,
                    0xC1,
                    0x47,
                    0xB6,
                    0x0B,
                    0x74,
                    0x0D,
                    0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_THROTTLE_POLICY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x04, 0x73, 0x02, 0x57,
                    0xF6, 0x4A,
                    0x04, 0x41,
                    0x92,
                    0x60,
                    0xE3,
                    0xD9,
                    0x52,
                    0x48,
                    0xFC,
                    0x36
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_THROTTLE_MAXIMUM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF7, 0x38, 0x50, 0xBC,
                    0xE0, 0x23,
                    0x60, 0x49,
                    0x96,
                    0xDA,
                    0x33,
                    0xAB,
                    0xAF,
                    0x59,
                    0x35,
                    0xEC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_THROTTLE_MAXIMUM_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF7, 0x38, 0x50, 0xBC,
                    0xE0, 0x23,
                    0x60, 0x49,
                    0x96,
                    0xDA,
                    0x33,
                    0xAB,
                    0xAF,
                    0x59,
                    0x35,
                    0xED
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_THROTTLE_MINIMUM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8E, 0xEE, 0x3D, 0x89,
                    0xEF, 0x2B,
                    0xE0, 0x41,
                    0x89,
                    0xC6,
                    0xB5,
                    0x5D,
                    0x09,
                    0x29,
                    0x96,
                    0x4C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_THROTTLE_MINIMUM_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8E, 0xEE, 0x3D, 0x89,
                    0xEF, 0x2B,
                    0xE0, 0x41,
                    0x89,
                    0xC6,
                    0xB5,
                    0x5D,
                    0x09,
                    0x29,
                    0x96,
                    0x4D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_FREQUENCY_LIMIT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3F, 0xAE, 0xB0, 0x75,
                    0xE0, 0xBC,
                    0xA7, 0x45,
                    0x8C,
                    0x89,
                    0xC9,
                    0x61,
                    0x1C,
                    0x25,
                    0xE1,
                    0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_FREQUENCY_LIMIT_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3F, 0xAE, 0xB0, 0x75,
                    0xE0, 0xBC,
                    0xA7, 0x45,
                    0x8C,
                    0x89,
                    0xC9,
                    0x61,
                    0x1C,
                    0x25,
                    0xE1,
                    0x01
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_ALLOW_THROTTLING
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFD, 0xD4, 0x04, 0x3B,
                    0xC7, 0x1C,
                    0x23, 0x4F,
                    0xAB,
                    0x1C,
                    0xD1,
                    0x33,
                    0x78,
                    0x19,
                    0xC4,
                    0xBB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_IDLESTATE_POLICY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA7, 0x62, 0xF2, 0x68,
                    0x21, 0xF6,
                    0x69, 0x40,
                    0xB9,
                    0xA5,
                    0x48,
                    0x74,
                    0x16,
                    0x9B,
                    0xE2,
                    0x3C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERFSTATE_POLICY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x14, 0x38, 0xDC, 0xBB,
                    0xE9, 0x18,
                    0x63, 0x44,
                    0x8A,
                    0x55,
                    0xD1,
                    0x97,
                    0x32,
                    0x7C,
                    0x45,
                    0xC0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERF_INCREASE_THRESHOLD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0E, 0xDF, 0xCA, 0x06,
                    0xED, 0x64,
                    0x8A, 0x44,
                    0x89,
                    0x27,
                    0xCE,
                    0x7B,
                    0xF9,
                    0x0E,
                    0xB3,
                    0x5D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERF_INCREASE_THRESHOLD_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0E, 0xDF, 0xCA, 0x06,
                    0xED, 0x64,
                    0x8A, 0x44,
                    0x89,
                    0x27,
                    0xCE,
                    0x7B,
                    0xF9,
                    0x0E,
                    0xB3,
                    0x5E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERF_DECREASE_THRESHOLD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x44, 0xAB, 0xA0, 0x12,
                    0x28, 0xFE,
                    0xA9, 0x4F,
                    0xB3,
                    0xBD,
                    0x4B,
                    0x64,
                    0xF4,
                    0x49,
                    0x60,
                    0xA6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERF_DECREASE_THRESHOLD_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x44, 0xAB, 0xA0, 0x12,
                    0x28, 0xFE,
                    0xA9, 0x4F,
                    0xB3,
                    0xBD,
                    0x4B,
                    0x64,
                    0xF4,
                    0x49,
                    0x60,
                    0xA7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERF_INCREASE_POLICY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x1F, 0x5E, 0x46,
                    0x10, 0xB6,
                    0x3A, 0x47,
                    0xAB,
                    0x58,
                    0x00,
                    0xD1,
                    0x07,
                    0x7D,
                    0xC4,
                    0x18
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERF_INCREASE_POLICY_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x1F, 0x5E, 0x46,
                    0x10, 0xB6,
                    0x3A, 0x47,
                    0xAB,
                    0x58,
                    0x00,
                    0xD1,
                    0x07,
                    0x7D,
                    0xC4,
                    0x19
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERF_DECREASE_POLICY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC7, 0xEF, 0xFB, 0x40,
                    0x9D, 0x2E,
                    0x25, 0x4D,
                    0xA1,
                    0x85,
                    0x0C,
                    0xFD,
                    0x85,
                    0x74,
                    0xBA,
                    0xC6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERF_DECREASE_POLICY_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC7, 0xEF, 0xFB, 0x40,
                    0x9D, 0x2E,
                    0x25, 0x4D,
                    0xA1,
                    0x85,
                    0x0C,
                    0xFD,
                    0x85,
                    0x74,
                    0xBA,
                    0xC7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERF_INCREASE_TIME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x92, 0xF4, 0x4C, 0x98,
                    0xED, 0x3B,
                    0x88, 0x44,
                    0xA8,
                    0xF9,
                    0x42,
                    0x86,
                    0xC9,
                    0x7B,
                    0xF5,
                    0xAA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERF_INCREASE_TIME_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x92, 0xF4, 0x4C, 0x98,
                    0xED, 0x3B,
                    0x88, 0x44,
                    0xA8,
                    0xF9,
                    0x42,
                    0x86,
                    0xC9,
                    0x7B,
                    0xF5,
                    0xAB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERF_DECREASE_TIME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9B, 0xEB, 0xED, 0xD8,
                    0xCF, 0x95,
                    0x95, 0x4F,
                    0xA7,
                    0x3C,
                    0xB0,
                    0x61,
                    0x97,
                    0x36,
                    0x93,
                    0xC8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERF_DECREASE_TIME_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9B, 0xEB, 0xED, 0xD8,
                    0xCF, 0x95,
                    0x95, 0x4F,
                    0xA7,
                    0x3C,
                    0xB0,
                    0x61,
                    0x97,
                    0x36,
                    0x93,
                    0xC9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERF_TIME_CHECK
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x52, 0x01, 0x2B, 0x4D,
                    0x5C, 0x7D,
                    0x8B, 0x49,
                    0x88,
                    0xE2,
                    0x34,
                    0x34,
                    0x53,
                    0x92,
                    0xA2,
                    0xC5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERF_BOOST_POLICY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x44, 0xC0, 0xBC, 0x45,
                    0x85, 0xD8,
                    0xE2, 0x43,
                    0x86,
                    0x05,
                    0xEE,
                    0x0E,
                    0xC6,
                    0xE9,
                    0x6B,
                    0x59
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERF_BOOST_MODE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x38, 0x72, 0x33, 0xBE,
                    0x82, 0x0D,
                    0x46, 0x41,
                    0xA9,
                    0x60,
                    0x4F,
                    0x37,
                    0x49,
                    0xD4,
                    0x70,
                    0xC7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERF_AUTONOMOUS_MODE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8A, 0x4A, 0xAA, 0x8B,
                    0xC6, 0x14,
                    0x51, 0x44,
                    0x8E,
                    0x8B,
                    0x14,
                    0xBD,
                    0xBD,
                    0x19,
                    0x75,
                    0x37
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERF_ENERGY_PERFORMANCE_PREFERENCE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9E, 0x7F, 0x68, 0x36,
                    0xA5, 0xE3,
                    0xBF, 0x4D,
                    0xB1,
                    0xDC,
                    0x15,
                    0xEB,
                    0x38,
                    0x1C,
                    0x68,
                    0x63
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERF_ENERGY_PERFORMANCE_PREFERENCE_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9E, 0x7F, 0x68, 0x36,
                    0xA5, 0xE3,
                    0xBF, 0x4D,
                    0xB1,
                    0xDC,
                    0x15,
                    0xEB,
                    0x38,
                    0x1C,
                    0x68,
                    0x64
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERF_AUTONOMOUS_ACTIVITY_WINDOW
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD0, 0xA3, 0xED, 0xCF,
                    0x97, 0x76,
                    0x66, 0x45,
                    0xA9,
                    0x22,
                    0xA9,
                    0x08,
                    0x6C,
                    0xD4,
                    0x9D,
                    0xFA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_DUTY_CYCLING
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB3, 0x50, 0x44, 0x4E,
                    0x79, 0x61,
                    0x91, 0x4E,
                    0xB8,
                    0xF1,
                    0x5B,
                    0xB9,
                    0x93,
                    0x8F,
                    0x81,
                    0xA1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_IDLE_ALLOW_SCALING
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB0, 0x93, 0x29, 0x6C,
                    0x48, 0x8F,
                    0x1F, 0x48,
                    0xBC,
                    0xC6,
                    0x00,
                    0xDD,
                    0x27,
                    0x42,
                    0xAA,
                    0x06
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_IDLE_DISABLE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCA, 0xA2, 0x76, 0x5D,
                    0xC0, 0xE8,
                    0x2F, 0x40,
                    0xA1,
                    0x33,
                    0x21,
                    0x58,
                    0x49,
                    0x2D,
                    0x58,
                    0xAD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_IDLE_STATE_MAXIMUM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x05, 0xE9, 0x43, 0x99,
                    0x30, 0x9A,
                    0xC1, 0x4E,
                    0x9B,
                    0x99,
                    0x44,
                    0xDD,
                    0x3B,
                    0x76,
                    0xF7,
                    0xA2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_IDLE_TIME_CHECK
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x31, 0x1C, 0x58, 0xC4,
                    0xAB, 0x89,
                    0x97, 0x45,
                    0x8E,
                    0x2B,
                    0x9C,
                    0x9C,
                    0xAB,
                    0x44,
                    0x0E,
                    0x6B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_IDLE_DEMOTE_THRESHOLD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x58, 0xD7, 0x92, 0x4B,
                    0x24, 0x5A,
                    0x51, 0x48,
                    0xA4,
                    0x70,
                    0x81,
                    0x5D,
                    0x78,
                    0xAE,
                    0xE1,
                    0x19
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_IDLE_PROMOTE_THRESHOLD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x83, 0x48, 0x22, 0x7B,
                    0xCC, 0xB3,
                    0x79, 0x4D,
                    0x81,
                    0x9F,
                    0x83,
                    0x74,
                    0x15,
                    0x2C,
                    0xBE,
                    0x7C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_INCREASE_THRESHOLD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x41, 0x29, 0x14, 0xDF,
                    0xF3, 0x20,
                    0xDF, 0x4E,
                    0x9A,
                    0x4A,
                    0x9C,
                    0x83,
                    0xD3,
                    0xD7,
                    0x17,
                    0xD1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_DECREASE_THRESHOLD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x27, 0x2F, 0xDD, 0x68,
                    0xCE, 0xA4,
                    0x11, 0x4E,
                    0x84,
                    0x87,
                    0x37,
                    0x94,
                    0xE4,
                    0x13,
                    0x5D,
                    0xFA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_INCREASE_POLICY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x79, 0x06, 0xBE, 0xC7,
                    0x17, 0x28,
                    0x69, 0x4D,
                    0x9D,
                    0x02,
                    0x51,
                    0x9A,
                    0x53,
                    0x7E,
                    0xD0,
                    0xC6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_DECREASE_POLICY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x41, 0x1B, 0x02, 0x71,
                    0x49, 0xC7,
                    0x21, 0x4D,
                    0xBE,
                    0x74,
                    0xA0,
                    0x0F,
                    0x33,
                    0x5D,
                    0x58,
                    0x2B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_MAX_CORES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x31, 0x20, 0x06, 0xEA,
                    0x34, 0x0E,
                    0xF1, 0x4F,
                    0x9B,
                    0x6D,
                    0xEB,
                    0x10,
                    0x59,
                    0x33,
                    0x40,
                    0x28
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_MAX_CORES_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x31, 0x20, 0x06, 0xEA,
                    0x34, 0x0E,
                    0xF1, 0x4F,
                    0x9B,
                    0x6D,
                    0xEB,
                    0x10,
                    0x59,
                    0x33,
                    0x40,
                    0x29
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_MIN_CORES
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x47, 0xB6, 0xC5, 0x0C,
                    0xDF, 0xC1,
                    0x37, 0x46,
                    0x89,
                    0x1A,
                    0xDE,
                    0xC3,
                    0x5C,
                    0x31,
                    0x85,
                    0x83
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_MIN_CORES_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x47, 0xB6, 0xC5, 0x0C,
                    0xDF, 0xC1,
                    0x37, 0x46,
                    0x89,
                    0x1A,
                    0xDE,
                    0xC3,
                    0x5C,
                    0x31,
                    0x85,
                    0x84
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_INCREASE_TIME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x84, 0x5A, 0xDD, 0x2D,
                    0x71, 0x5A,
                    0x7E, 0x43,
                    0x91,
                    0x2A,
                    0xDB,
                    0x0B,
                    0x8C,
                    0x78,
                    0x87,
                    0x32
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_DECREASE_TIME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x17, 0x0D, 0xD1, 0xDF,
                    0xEB, 0xD5,
                    0xDD, 0x45,
                    0x87,
                    0x7A,
                    0x9A,
                    0x34,
                    0xDD,
                    0xD1,
                    0x5C,
                    0x82
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_AFFINITY_HISTORY_DECREASE_FACTOR
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE3, 0x45, 0x7B, 0x8F,
                    0x93, 0xC3,
                    0x0A, 0x48,
                    0x87,
                    0x8C,
                    0xF6,
                    0x7A,
                    0xC3,
                    0xD0,
                    0x70,
                    0x82
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_AFFINITY_HISTORY_THRESHOLD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7B, 0x69, 0x33, 0x5B,
                    0x9D, 0xE8,
                    0x38, 0x4D,
                    0xAA,
                    0x46,
                    0x9E,
                    0x7D,
                    0xFB,
                    0x7C,
                    0xD2,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_AFFINITY_WEIGHTING
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF1, 0x67, 0x08, 0xE7,
                    0x2F, 0xFA,
                    0x4E, 0x4F,
                    0xAE,
                    0xA1,
                    0x4D,
                    0x8A,
                    0x0B,
                    0xA2,
                    0x3B,
                    0x20
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_HISTORY_DECREASE_FACTOR
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3C, 0x02, 0x99, 0x12,
                    0x28, 0xBC,
                    0x0A, 0x4F,
                    0x81,
                    0xEC,
                    0xD3,
                    0x29,
                    0x5A,
                    0x8D,
                    0x81,
                    0x5D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_HISTORY_THRESHOLD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x92, 0x8E, 0xC1, 0x9A,
                    0x3C, 0xAA,
                    0x27, 0x4E,
                    0xB3,
                    0x07,
                    0x01,
                    0xAE,
                    0x37,
                    0x30,
                    0x71,
                    0x29
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_WEIGHTING
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD8, 0xC2, 0x09, 0x88,
                    0x55, 0xB1,
                    0xD4, 0x42,
                    0xBC,
                    0xDA,
                    0x0D,
                    0x34,
                    0x56,
                    0x51,
                    0xB1,
                    0xDB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_CORE_PARKING_OVER_UTILIZATION_THRESHOLD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB6, 0x8C, 0x3C, 0x94,
                    0x93, 0x6F,
                    0x27, 0x42,
                    0xAD,
                    0x87,
                    0xE9,
                    0xA3,
                    0xFE,
                    0xEC,
                    0x08,
                    0xD1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PARKING_CORE_OVERRIDE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAA, 0x12, 0x56, 0xA5,
                    0x24, 0xF6,
                    0xC6, 0x42,
                    0xA4,
                    0x43,
                    0x73,
                    0x97,
                    0xD0,
                    0x64,
                    0xC0,
                    0x4F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PARKING_PERF_STATE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC7, 0x35, 0x72, 0x44,
                    0x8D, 0x6A,
                    0xC0, 0x4C,
                    0x8E,
                    0x24,
                    0x9E,
                    0xAF,
                    0x70,
                    0xB9,
                    0x6E,
                    0x2B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PARKING_PERF_STATE_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC7, 0x35, 0x72, 0x44,
                    0x8D, 0x6A,
                    0xC0, 0x4C,
                    0x8E,
                    0x24,
                    0x9E,
                    0xAF,
                    0x70,
                    0xB9,
                    0x6E,
                    0x2C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PARKING_CONCURRENCY_THRESHOLD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x6F, 0xAB, 0x30, 0x24,
                    0x20, 0xA5,
                    0xA2, 0x44,
                    0x96,
                    0x01,
                    0xF7,
                    0xF2,
                    0x3B,
                    0x51,
                    0x34,
                    0xB1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PARKING_HEADROOM_THRESHOLD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x73, 0xA6, 0x35, 0xF7,
                    0x66, 0x20,
                    0x80, 0x4F,
                    0xA0,
                    0xC5,
                    0xDD,
                    0xEE,
                    0x0C,
                    0xF1,
                    0xBF,
                    0x5D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PARKING_DISTRIBUTION_THRESHOLD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE9, 0xF4, 0xDA, 0x4B,
                    0x03, 0xD1,
                    0xD7, 0x46,
                    0xA5,
                    0xF0,
                    0x62,
                    0x80,
                    0x12,
                    0x16,
                    0x16,
                    0xEF
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_SOFT_PARKING_LATENCY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x41, 0xAC, 0xCF, 0x97,
                    0x17, 0x22,
                    0xEB, 0x47,
                    0x99,
                    0x2D,
                    0x61,
                    0x8B,
                    0x19,
                    0x77,
                    0xC9,
                    0x07
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERF_HISTORY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA7, 0xBA, 0x24, 0x7D,
                    0x84, 0x0B,
                    0x0F, 0x48,
                    0x84,
                    0x0C,
                    0x1B,
                    0x07,
                    0x43,
                    0xC0,
                    0x0F,
                    0x5F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERF_HISTORY_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA7, 0xBA, 0x24, 0x7D,
                    0x84, 0x0B,
                    0x0F, 0x48,
                    0x84,
                    0x0C,
                    0x1B,
                    0x07,
                    0x43,
                    0xC0,
                    0x0F,
                    0x60
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERF_INCREASE_HISTORY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x01, 0xEF, 0xB3, 0x99,
                    0x2F, 0x75,
                    0xA1, 0x46,
                    0x80,
                    0xFB,
                    0x77,
                    0x30,
                    0x01,
                    0x1F,
                    0x23,
                    0x54
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERF_DECREASE_HISTORY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF8, 0xF6, 0x00, 0x03,
                    0xD6, 0xAB,
                    0xA9, 0x45,
                    0xB7,
                    0x4F,
                    0x49,
                    0x08,
                    0x69,
                    0x1A,
                    0x40,
                    0xB5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERF_CORE_PARKING_HISTORY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x82, 0xF2, 0xD7, 0x77,
                    0x1A, 0x8F,
                    0xCD, 0x42,
                    0x85,
                    0x37,
                    0x45,
                    0x45,
                    0x0A,
                    0x83,
                    0x9B,
                    0xE8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERF_LATENCY_HINT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x31, 0xDF, 0x22, 0x08,
                    0x83, 0x9C,
                    0x1C, 0x44,
                    0xA0,
                    0x79,
                    0x0D,
                    0xE4,
                    0xCF,
                    0x00,
                    0x9C,
                    0x7B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERF_LATENCY_HINT_PERF
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x05, 0x75, 0x9B, 0x61,
                    0x3B, 0x00,
                    0x82, 0x4E,
                    0xB7,
                    0xA6,
                    0x4D,
                    0xD2,
                    0x9C,
                    0x30,
                    0x09,
                    0x71
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_PERF_LATENCY_HINT_PERF_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x05, 0x75, 0x9B, 0x61,
                    0x3B, 0x00,
                    0x82, 0x4E,
                    0xB7,
                    0xA6,
                    0x4D,
                    0xD2,
                    0x9C,
                    0x30,
                    0x09,
                    0x72
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_LATENCY_HINT_MIN_UNPARK
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA5, 0xDA, 0x6C, 0x61,
                    0x5E, 0x69,
                    0x45, 0x45,
                    0x97,
                    0xAD,
                    0x97,
                    0xDC,
                    0x2D,
                    0x1B,
                    0xDD,
                    0x88
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_LATENCY_HINT_MIN_UNPARK_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA5, 0xDA, 0x6C, 0x61,
                    0x5E, 0x69,
                    0x45, 0x45,
                    0x97,
                    0xAD,
                    0x97,
                    0xDC,
                    0x2D,
                    0x1B,
                    0xDD,
                    0x89
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_DISTRIBUTE_UTILITY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x30, 0x73, 0x00, 0xE0,
                    0x89, 0xF5,
                    0xED, 0x42,
                    0xA4,
                    0x01,
                    0x5D,
                    0xDB,
                    0x10,
                    0xE7,
                    0x85,
                    0xD3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_HETEROGENEOUS_POLICY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFA, 0x5C, 0x2F, 0x7F,
                    0x0C, 0xF1,
                    0x23, 0x48,
                    0xB5,
                    0xE1,
                    0xE9,
                    0x3A,
                    0xE8,
                    0x5F,
                    0x46,
                    0xB5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_HETERO_DECREASE_TIME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB6, 0x92, 0x24, 0x7F,
                    0xB1, 0x60,
                    0xE5, 0x45,
                    0xAE,
                    0x55,
                    0x77,
                    0x3F,
                    0x8C,
                    0xD5,
                    0xCA,
                    0xEC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_HETERO_INCREASE_TIME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA7, 0xEF, 0x09, 0x40,
                    0x2D, 0xE7,
                    0xBA, 0x4C,
                    0x9E,
                    0xDF,
                    0x91,
                    0x08,
                    0x4E,
                    0xA8,
                    0xCB,
                    0xC3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_HETERO_DECREASE_THRESHOLD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x27, 0x1C, 0x86, 0xF8,
                    0xE7, 0x95,
                    0x5C, 0x47,
                    0x86,
                    0x5B,
                    0x13,
                    0xC0,
                    0xCB,
                    0x3F,
                    0x9D,
                    0x6B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_HETERO_INCREASE_THRESHOLD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7D, 0x39, 0x00, 0xB0,
                    0x0B, 0x9B,
                    0x3D, 0x48,
                    0x98,
                    0xC9,
                    0x69,
                    0x2A,
                    0x60,
                    0x60,
                    0xCF,
                    0xBF
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_CLASS0_FLOOR_PERF
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2B, 0x84, 0xDC, 0xFD,
                    0x64, 0x83,
                    0xDC, 0x4E,
                    0x94,
                    0xCF,
                    0xC1,
                    0x7F,
                    0x60,
                    0xDE,
                    0x1C,
                    0x80
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_CLASS1_INITIAL_PERF
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x65, 0xFC, 0xAC, 0x1F,
                    0x30, 0xA9,
                    0xC5, 0x4B,
                    0x9F,
                    0x38,
                    0x50,
                    0x4E,
                    0xC0,
                    0x97,
                    0xBB,
                    0xC0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_THREAD_SCHEDULING_POLICY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDC, 0xB6, 0xB8, 0x93,
                    0x98, 0x06,
                    0x1C, 0x4D,
                    0x9E,
                    0xE4,
                    0x06,
                    0x44,
                    0xE9,
                    0x00,
                    0xC8,
                    0x5D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_SHORT_THREAD_SCHEDULING_POLICY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x81, 0x8B, 0xE0, 0xBA,
                    0x5E, 0x2D,
                    0x88, 0x46,
                    0xAD,
                    0x6A,
                    0x13,
                    0x24,
                    0x33,
                    0x56,
                    0x65,
                    0x4B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_SYSTEM_COOLING_POLICY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x15, 0xA6, 0xD3, 0x94,
                    0x99, 0xA8,
                    0xC5, 0x4A,
                    0xAE,
                    0x2B,
                    0xE4,
                    0xD8,
                    0xF6,
                    0x34,
                    0x36,
                    0x7F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_RESPONSIVENESS_DISABLE_THRESHOLD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3D, 0x38, 0xB8, 0x38,
                    0xE0, 0xCC,
                    0x79, 0x4C,
                    0x9E,
                    0x3E,
                    0x56,
                    0xA4,
                    0xF1,
                    0x7C,
                    0xC4,
                    0x80
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_RESPONSIVENESS_DISABLE_THRESHOLD_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3D, 0x38, 0xB8, 0x38,
                    0xE0, 0xCC,
                    0x79, 0x4C,
                    0x9E,
                    0x3E,
                    0x56,
                    0xA4,
                    0xF1,
                    0x7C,
                    0xC4,
                    0x81
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_RESPONSIVENESS_ENABLE_THRESHOLD
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x56, 0xE2, 0x44, 0x3D,
                    0x22, 0x72,
                    0x15, 0x44,
                    0xA9,
                    0xED,
                    0x9C,
                    0x45,
                    0xFA,
                    0x3D,
                    0xD8,
                    0x30
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_RESPONSIVENESS_ENABLE_THRESHOLD_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x56, 0xE2, 0x44, 0x3D,
                    0x22, 0x72,
                    0x15, 0x44,
                    0xA9,
                    0xED,
                    0x9C,
                    0x45,
                    0xFA,
                    0x3D,
                    0xD8,
                    0x31
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_RESPONSIVENESS_DISABLE_TIME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9F, 0x99, 0x65, 0xF5,
                    0xB0, 0x3F,
                    0x1A, 0x41,
                    0xA2,
                    0x26,
                    0x3F,
                    0x01,
                    0x98,
                    0xDE,
                    0xC1,
                    0x30
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_RESPONSIVENESS_DISABLE_TIME_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9F, 0x99, 0x65, 0xF5,
                    0xB0, 0x3F,
                    0x1A, 0x41,
                    0xA2,
                    0x26,
                    0x3F,
                    0x01,
                    0x98,
                    0xDE,
                    0xC1,
                    0x31
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_RESPONSIVENESS_ENABLE_TIME
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x88, 0x51, 0x91, 0x3D,
                    0x30, 0x78,
                    0xAE, 0x49,
                    0xA7,
                    0x9A,
                    0x0F,
                    0xB0,
                    0xA1,
                    0xE5,
                    0xA2,
                    0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_RESPONSIVENESS_ENABLE_TIME_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x88, 0x51, 0x91, 0x3D,
                    0x30, 0x78,
                    0xAE, 0x49,
                    0xA7,
                    0x9A,
                    0x0F,
                    0xB0,
                    0xA1,
                    0xE5,
                    0xA2,
                    0x01
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_RESPONSIVENESS_EPP_CEILING
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3B, 0xC7, 0x27, 0x44,
                    0x56, 0x97,
                    0x5C, 0x4A,
                    0xB8,
                    0x4B,
                    0xC7,
                    0xBD,
                    0xA7,
                    0x9C,
                    0x73,
                    0x20
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_RESPONSIVENESS_EPP_CEILING_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3B, 0xC7, 0x27, 0x44,
                    0x56, 0x97,
                    0x5C, 0x4A,
                    0xB8,
                    0x4B,
                    0xC7,
                    0xBD,
                    0xA7,
                    0x9C,
                    0x73,
                    0x21
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_RESPONSIVENESS_PERF_FLOOR
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEE, 0x92, 0x8E, 0xCE,
                    0x86, 0x6A,
                    0x72, 0x45,
                    0xBF,
                    0xE0,
                    0x20,
                    0xC2,
                    0x1D,
                    0x03,
                    0xCD,
                    0x40
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PROCESSOR_RESPONSIVENESS_PERF_FLOOR_1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEE, 0x92, 0x8E, 0xCE,
                    0x86, 0x6A,
                    0x72, 0x45,
                    0xBF,
                    0xE0,
                    0x20,
                    0xC2,
                    0x1D,
                    0x03,
                    0xCD,
                    0x41
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_LOCK_CONSOLE_ON_WAKE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDB, 0x6B, 0x79, 0x0E,
                    0x0D, 0x10,
                    0xD6, 0x47,
                    0xA2,
                    0xD5,
                    0xF7,
                    0xD2,
                    0xDA,
                    0xA5,
                    0x1F,
                    0x51
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_DEVICE_IDLE_POLICY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1A, 0xB7, 0xAA, 0x4F,
                    0xE5, 0x92,
                    0x26, 0x47,
                    0xB5,
                    0x31,
                    0x22,
                    0x45,
                    0x59,
                    0x67,
                    0x2D,
                    0x19
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_CONNECTIVITY_IN_STANDBY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE8, 0x76, 0x55, 0xF1,
                    0xB7, 0x98,
                    0x86, 0x41,
                    0xB9,
                    0x44,
                    0xEA,
                    0xFA,
                    0x66,
                    0x44,
                    0x02,
                    0xD9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_DISCONNECTED_STANDBY_MODE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD9, 0xB2, 0xAF, 0x68,
                    0x95, 0xEE,
                    0xA8, 0x47,
                    0x8F,
                    0x50,
                    0x41,
                    0x15,
                    0x08,
                    0x80,
                    0x73,
                    0xB1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_ACDC_POWER_SOURCE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x59, 0x9A, 0x3E, 0x5D,
                    0xD5, 0xE9,
                    0x00, 0x4B,
                    0xA6,
                    0xBD,
                    0xFF,
                    0x34,
                    0xFF,
                    0x51,
                    0x65,
                    0x48
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_LIDSWITCH_STATE_CHANGE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4D, 0x0F, 0x3E, 0xBA,
                    0x17, 0xB8,
                    0x94, 0x40,
                    0xA2,
                    0xD1,
                    0xD5,
                    0x63,
                    0x79,
                    0xE6,
                    0xA0,
                    0xF3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_BATTERY_PERCENTAGE_REMAINING
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x41, 0x80, 0xAD, 0xA7,
                    0x5A, 0xB4,
                    0xAE, 0x4C,
                    0x87,
                    0xA3,
                    0xEE,
                    0xCB,
                    0xB4,
                    0x68,
                    0xA9,
                    0xE1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_BATTERY_COUNT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x15, 0x3F, 0x26, 0x7D,
                    0xA4, 0xFC,
                    0xE5, 0x49,
                    0x85,
                    0x4B,
                    0xA9,
                    0xF2,
                    0xBF,
                    0xBD,
                    0x5C,
                    0x24
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_GLOBAL_USER_PRESENCE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1D, 0x8A, 0x6E, 0x78,
                    0x27, 0xB4,
                    0x44, 0x43,
                    0x92,
                    0x07,
                    0x09,
                    0xE7,
                    0x0B,
                    0xDC,
                    0xBE,
                    0xA9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_SESSION_DISPLAY_STATUS
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x0E, 0xC2, 0x84, 0x2B,
                    0x23, 0xAD,
                    0xDF, 0x4D,
                    0x93,
                    0xDB,
                    0x05,
                    0xFF,
                    0xBD,
                    0x7E,
                    0xFC,
                    0xA5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_SESSION_USER_PRESENCE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x48, 0x45, 0x0F, 0x3C,
                    0x3F, 0xC0,
                    0x4D, 0x4C,
                    0xB9,
                    0xF2,
                    0x23,
                    0x7E,
                    0xDE,
                    0x68,
                    0x63,
                    0x76
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_IDLE_BACKGROUND_TASK
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD8, 0x31, 0x5C, 0x51,
                    0x34, 0xF7,
                    0x3D, 0x16,
                    0xA0,
                    0xFD,
                    0x11,
                    0xA0,
                    0x8C,
                    0x91,
                    0xE8,
                    0xF1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_BACKGROUND_TASK_NOTIFICATION
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0xF2, 0x23, 0xCF,
                    0x54, 0x2A,
                    0xD8, 0x48,
                    0xB1,
                    0x14,
                    0xDE,
                    0x15,
                    0x18,
                    0xFF,
                    0x05,
                    0x2E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_APPLAUNCH_BUTTON
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x31, 0x92, 0x68, 0x1A,
                    0x99, 0x73,
                    0x9A, 0x4E,
                    0x8F,
                    0x99,
                    0xB7,
                    0x1F,
                    0x99,
                    0x9D,
                    0xB3,
                    0xFA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PCIEXPRESS_SETTINGS_SUBGROUP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x13, 0x4D, 0x1A, 0x50,
                    0xAF, 0x42,
                    0x29, 0x44,
                    0x9F,
                    0xD1,
                    0xA8,
                    0x21,
                    0x8C,
                    0x26,
                    0x8E,
                    0x20
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_PCIEXPRESS_ASPM_POLICY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x06, 0xF9, 0x12, 0xEE,
                    0x77, 0xD2,
                    0x4B, 0x40,
                    0xB6,
                    0xDA,
                    0xE5,
                    0xFA,
                    0x1A,
                    0x57,
                    0x6D,
                    0xF5
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_ENABLE_SWITCH_FORCED_SHUTDOWN
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x62, 0x6B, 0x3A, 0x83,
                    0xA4, 0xDF,
                    0xD1, 0x46,
                    0x82,
                    0xF8,
                    0xE0,
                    0x9E,
                    0x34,
                    0xD0,
                    0x29,
                    0xD6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_INTSTEER_SUBGROUP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x38, 0x2F, 0x67, 0x48,
                    0x9A, 0x7A,
                    0xB2, 0x4B,
                    0x8B,
                    0xF8,
                    0x3D,
                    0x85,
                    0xBE,
                    0x19,
                    0xDE,
                    0x4E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_INTSTEER_MODE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xF9, 0x24, 0xFC, 0x2B,
                    0xA2, 0x5E,
                    0x01, 0x48,
                    0x82,
                    0x13,
                    0x3D,
                    0xBA,
                    0xE0,
                    0x1A,
                    0xA3,
                    0x9D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_INTSTEER_LOAD_PER_PROC_TRIGGER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4D, 0xE6, 0xCD, 0x73,
                    0x20, 0xD7,
                    0xB2, 0x4B,
                    0xA8,
                    0x60,
                    0xC7,
                    0x55,
                    0xAF,
                    0xE7,
                    0x7E,
                    0xF2
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_INTSTEER_TIME_UNPARK_TRIGGER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x03, 0x49, 0xBA, 0xD6,
                    0x6F, 0x38,
                    0x2C, 0x4C,
                    0x8A,
                    0xDB,
                    0x5C,
                    0x21,
                    0xB3,
                    0x32,
                    0x8D,
                    0x25
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_GRAPHICS_SUBGROUP
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x8D, 0x93, 0xB4, 0x5F,
                    0xE8, 0x1E,
                    0x0F, 0x4B,
                    0x9A,
                    0x3C,
                    0x50,
                    0x36,
                    0xB0,
                    0xAB,
                    0x99,
                    0x5C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_GPU_PREFERENCE_POLICY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2A, 0x8B, 0x84, 0xDD,
                    0x5D, 0x8A,
                    0x51, 0x44,
                    0x9A,
                    0xE2,
                    0x39,
                    0xCD,
                    0x41,
                    0x65,
                    0x8F,
                    0x6C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_MIXED_REALITY_MODE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4E, 0x6B, 0x62, 0x1E,
                    0x04, 0xCF,
                    0x8D, 0x4F,
                    0x9C,
                    0xC7,
                    0xC9,
                    0x7C,
                    0x5B,
                    0x0F,
                    0x23,
                    0x91
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid GUID_SPR_ACTIVE_SESSION_CHANGE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x38, 0xCE, 0x24, 0x0E,
                    0x93, 0xC3,
                    0x42, 0x47,
                    0xBD,
                    0xB1,
                    0x74,
                    0x4F,
                    0x4B,
                    0x9E,
                    0xE0,
                    0x8E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid PPM_PERFSTATE_CHANGE_GUID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDD, 0x2D, 0xB3, 0xA5,
                    0x39, 0x7F,
                    0xBC, 0x4A,
                    0xB8,
                    0x92,
                    0x90,
                    0x0E,
                    0x43,
                    0xB5,
                    0x9E,
                    0xBB
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid PPM_PERFSTATE_DOMAIN_CHANGE_GUID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7F, 0x6B, 0x5E, 0x99,
                    0x53, 0xD6,
                    0x7A, 0x49,
                    0xB9,
                    0x78,
                    0x36,
                    0xA3,
                    0x0C,
                    0x29,
                    0xBF,
                    0x01
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid PPM_IDLESTATE_CHANGE_GUID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4F, 0xFE, 0x38, 0x48,
                    0x1C, 0xF7,
                    0x51, 0x4E,
                    0x9E,
                    0xCC,
                    0x84,
                    0x30,
                    0xA7,
                    0xAC,
                    0x4C,
                    0x6C
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid PPM_PERFSTATES_DATA_GUID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x20, 0xCC, 0x08, 0x57,
                    0x40, 0x7D,
                    0xF4, 0x4B,
                    0xB4,
                    0xAA,
                    0x2B,
                    0x01,
                    0x33,
                    0x8D,
                    0x01,
                    0x26
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid PPM_IDLESTATES_DATA_GUID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x10, 0x8E, 0x13, 0xBA,
                    0x50, 0xE2,
                    0xD7, 0x4A,
                    0x86,
                    0x16,
                    0xCF,
                    0x1A,
                    0x7A,
                    0xD4,
                    0x10,
                    0xE7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid PPM_IDLE_ACCOUNTING_GUID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x78, 0x6F, 0xA2, 0xE2,
                    0x07, 0xAE,
                    0xE0, 0x4E,
                    0xA3,
                    0x0F,
                    0xCE,
                    0x54,
                    0xF5,
                    0x5A,
                    0x94,
                    0xCD
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid PPM_IDLE_ACCOUNTING_EX_GUID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x39, 0xBD, 0x7A, 0xD6,
                    0xF8, 0x81,
                    0x5E, 0x4A,
                    0x81,
                    0x52,
                    0x72,
                    0xE3,
                    0x1E,
                    0xC9,
                    0x12,
                    0xEE
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid PPM_THERMALCONSTRAINT_GUID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC8, 0xC2, 0x52, 0xA8,
                    0x4C, 0x1A,
                    0x3B, 0x42,
                    0x8C,
                    0x2C,
                    0xF3,
                    0x0D,
                    0x82,
                    0x93,
                    0x1A,
                    0x88
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid PPM_PERFMON_PERFSTATE_GUID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x52, 0x86, 0xD1, 0x7F,
                    0xFE, 0x0C,
                    0xD2, 0x40,
                    0xB0,
                    0xA1,
                    0x0B,
                    0x06,
                    0x6A,
                    0x87,
                    0x75,
                    0x9E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid PPM_THERMAL_POLICY_CHANGE_GUID
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB8, 0x77, 0xF3, 0x48,
                    0x80, 0x68,
                    0x7B, 0x4C,
                    0x8B,
                    0xDC,
                    0x38,
                    0x01,
                    0x76,
                    0xC6,
                    0x65,
                    0x4D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [return: NativeTypeName("DWORD")]
        public static uint HEAP_MAKE_TAG_FLAGS([NativeTypeName("DWORD")] uint TagBase, [NativeTypeName("DWORD")] uint Tag)
        {
            return ((uint)((TagBase) + ((Tag) << 18)));
        }

        [NativeTypeName("#define ANYSIZE_ARRAY 1")]
        public const int ANYSIZE_ARRAY = 1;

        [NativeTypeName("#define PRAGMA_DEPRECATED_DDK 0")]
        public const int PRAGMA_DEPRECATED_DDK = 0;

        [NativeTypeName("#define UCSCHAR_INVALID_CHARACTER (0xffffffff)")]
        public const uint UCSCHAR_INVALID_CHARACTER = (0xffffffff);

        [NativeTypeName("#define MIN_UCSCHAR (0)")]
        public const int MIN_UCSCHAR = (0);

        [NativeTypeName("#define ALL_PROCESSOR_GROUPS 0xffff")]
        public const int ALL_PROCESSOR_GROUPS = 0xffff;

        [NativeTypeName("#define APPLICATION_ERROR_MASK 0x20000000")]
        public const int APPLICATION_ERROR_MASK = 0x20000000;

        [NativeTypeName("#define MAXLONGLONG (0x7fffffffffffffff)")]
        public const long MAXLONGLONG = (0x7fffffffffffffff);

        [NativeTypeName("#define ANSI_NULL ((CHAR)0)")]
        public const sbyte ANSI_NULL = ((sbyte)(0));

        [NativeTypeName("#define UNICODE_NULL ((WCHAR)0)")]
        public const ushort UNICODE_NULL = ((ushort)(0));

        [NativeTypeName("#define UNICODE_STRING_MAX_BYTES ((WORD  ) 65534)")]
        public const ushort UNICODE_STRING_MAX_BYTES = ((ushort)(65534));

        [NativeTypeName("#define UNICODE_STRING_MAX_CHARS (32767)")]
        public const int UNICODE_STRING_MAX_CHARS = (32767);

        [NativeTypeName("#define MINCHAR 0x80")]
        public const int MINCHAR = 0x80;

        [NativeTypeName("#define MAXCHAR 0x7f")]
        public const int MAXCHAR = 0x7f;

        [NativeTypeName("#define MINSHORT 0x8000")]
        public const int MINSHORT = 0x8000;

        [NativeTypeName("#define MAXSHORT 0x7fff")]
        public const int MAXSHORT = 0x7fff;

        [NativeTypeName("#define MINLONG 0x80000000")]
        public const uint MINLONG = 0x80000000;

        [NativeTypeName("#define MAXLONG 0x7fffffff")]
        public const int MAXLONG = 0x7fffffff;

        [NativeTypeName("#define MAXBYTE 0xff")]
        public const int MAXBYTE = 0xff;

        [NativeTypeName("#define MAXWORD 0xffff")]
        public const int MAXWORD = 0xffff;

        [NativeTypeName("#define MAXDWORD 0xffffffff")]
        public const uint MAXDWORD = 0xffffffff;

        [NativeTypeName("#define ENCLAVE_SHORT_ID_LENGTH 16")]
        public const int ENCLAVE_SHORT_ID_LENGTH = 16;

        [NativeTypeName("#define ENCLAVE_LONG_ID_LENGTH 32")]
        public const int ENCLAVE_LONG_ID_LENGTH = 32;

        [NativeTypeName("#define VER_SERVER_NT 0x80000000")]
        public const uint VER_SERVER_NT = 0x80000000;

        [NativeTypeName("#define VER_WORKSTATION_NT 0x40000000")]
        public const int VER_WORKSTATION_NT = 0x40000000;

        [NativeTypeName("#define VER_SUITE_SMALLBUSINESS 0x00000001")]
        public const int VER_SUITE_SMALLBUSINESS = 0x00000001;

        [NativeTypeName("#define VER_SUITE_ENTERPRISE 0x00000002")]
        public const int VER_SUITE_ENTERPRISE = 0x00000002;

        [NativeTypeName("#define VER_SUITE_BACKOFFICE 0x00000004")]
        public const int VER_SUITE_BACKOFFICE = 0x00000004;

        [NativeTypeName("#define VER_SUITE_COMMUNICATIONS 0x00000008")]
        public const int VER_SUITE_COMMUNICATIONS = 0x00000008;

        [NativeTypeName("#define VER_SUITE_TERMINAL 0x00000010")]
        public const int VER_SUITE_TERMINAL = 0x00000010;

        [NativeTypeName("#define VER_SUITE_SMALLBUSINESS_RESTRICTED 0x00000020")]
        public const int VER_SUITE_SMALLBUSINESS_RESTRICTED = 0x00000020;

        [NativeTypeName("#define VER_SUITE_EMBEDDEDNT 0x00000040")]
        public const int VER_SUITE_EMBEDDEDNT = 0x00000040;

        [NativeTypeName("#define VER_SUITE_DATACENTER 0x00000080")]
        public const int VER_SUITE_DATACENTER = 0x00000080;

        [NativeTypeName("#define VER_SUITE_SINGLEUSERTS 0x00000100")]
        public const int VER_SUITE_SINGLEUSERTS = 0x00000100;

        [NativeTypeName("#define VER_SUITE_PERSONAL 0x00000200")]
        public const int VER_SUITE_PERSONAL = 0x00000200;

        [NativeTypeName("#define VER_SUITE_BLADE 0x00000400")]
        public const int VER_SUITE_BLADE = 0x00000400;

        [NativeTypeName("#define VER_SUITE_EMBEDDED_RESTRICTED 0x00000800")]
        public const int VER_SUITE_EMBEDDED_RESTRICTED = 0x00000800;

        [NativeTypeName("#define VER_SUITE_SECURITY_APPLIANCE 0x00001000")]
        public const int VER_SUITE_SECURITY_APPLIANCE = 0x00001000;

        [NativeTypeName("#define VER_SUITE_STORAGE_SERVER 0x00002000")]
        public const int VER_SUITE_STORAGE_SERVER = 0x00002000;

        [NativeTypeName("#define VER_SUITE_COMPUTE_SERVER 0x00004000")]
        public const int VER_SUITE_COMPUTE_SERVER = 0x00004000;

        [NativeTypeName("#define VER_SUITE_WH_SERVER 0x00008000")]
        public const int VER_SUITE_WH_SERVER = 0x00008000;

        [NativeTypeName("#define VER_SUITE_MULTIUSERTS 0x00020000")]
        public const int VER_SUITE_MULTIUSERTS = 0x00020000;

        [NativeTypeName("#define SORT_DEFAULT 0x0")]
        public const int SORT_DEFAULT = 0x0;

        [NativeTypeName("#define SORT_INVARIANT_MATH 0x1")]
        public const int SORT_INVARIANT_MATH = 0x1;

        [NativeTypeName("#define SORT_JAPANESE_XJIS 0x0")]
        public const int SORT_JAPANESE_XJIS = 0x0;

        [NativeTypeName("#define SORT_JAPANESE_UNICODE 0x1")]
        public const int SORT_JAPANESE_UNICODE = 0x1;

        [NativeTypeName("#define SORT_JAPANESE_RADICALSTROKE 0x4")]
        public const int SORT_JAPANESE_RADICALSTROKE = 0x4;

        [NativeTypeName("#define SORT_CHINESE_BIG5 0x0")]
        public const int SORT_CHINESE_BIG5 = 0x0;

        [NativeTypeName("#define SORT_CHINESE_PRCP 0x0")]
        public const int SORT_CHINESE_PRCP = 0x0;

        [NativeTypeName("#define SORT_CHINESE_UNICODE 0x1")]
        public const int SORT_CHINESE_UNICODE = 0x1;

        [NativeTypeName("#define SORT_CHINESE_PRC 0x2")]
        public const int SORT_CHINESE_PRC = 0x2;

        [NativeTypeName("#define SORT_CHINESE_BOPOMOFO 0x3")]
        public const int SORT_CHINESE_BOPOMOFO = 0x3;

        [NativeTypeName("#define SORT_CHINESE_RADICALSTROKE 0x4")]
        public const int SORT_CHINESE_RADICALSTROKE = 0x4;

        [NativeTypeName("#define SORT_KOREAN_KSC 0x0")]
        public const int SORT_KOREAN_KSC = 0x0;

        [NativeTypeName("#define SORT_KOREAN_UNICODE 0x1")]
        public const int SORT_KOREAN_UNICODE = 0x1;

        [NativeTypeName("#define SORT_GERMAN_PHONE_BOOK 0x1")]
        public const int SORT_GERMAN_PHONE_BOOK = 0x1;

        [NativeTypeName("#define SORT_HUNGARIAN_DEFAULT 0x0")]
        public const int SORT_HUNGARIAN_DEFAULT = 0x0;

        [NativeTypeName("#define SORT_HUNGARIAN_TECHNICAL 0x1")]
        public const int SORT_HUNGARIAN_TECHNICAL = 0x1;

        [NativeTypeName("#define SORT_GEORGIAN_TRADITIONAL 0x0")]
        public const int SORT_GEORGIAN_TRADITIONAL = 0x0;

        [NativeTypeName("#define SORT_GEORGIAN_MODERN 0x1")]
        public const int SORT_GEORGIAN_MODERN = 0x1;

        [NativeTypeName("#define NLS_VALID_LOCALE_MASK 0x000fffff")]
        public const int NLS_VALID_LOCALE_MASK = 0x000fffff;

        [NativeTypeName("#define LOCALE_NAME_MAX_LENGTH 85")]
        public const int LOCALE_NAME_MAX_LENGTH = 85;

        [NativeTypeName("#define LOCALE_SYSTEM_DEFAULT (MAKELCID(LANG_SYSTEM_DEFAULT, SORT_DEFAULT))")]
        public const uint LOCALE_SYSTEM_DEFAULT = (((uint)((((uint)((ushort)(0x0))) << 16) | ((uint)((ushort)(unchecked(((((ushort)(0x02)) << 10) | (ushort)(0x00)))))))));

        [NativeTypeName("#define LOCALE_USER_DEFAULT (MAKELCID(LANG_USER_DEFAULT, SORT_DEFAULT))")]
        public const uint LOCALE_USER_DEFAULT = (((uint)((((uint)((ushort)(0x0))) << 16) | ((uint)((ushort)(unchecked(((((ushort)(0x01)) << 10) | (ushort)(0x00)))))))));

        [NativeTypeName("#define LOCALE_CUSTOM_DEFAULT (MAKELCID(MAKELANGID(LANG_NEUTRAL, SUBLANG_CUSTOM_DEFAULT), SORT_DEFAULT))")]
        public const uint LOCALE_CUSTOM_DEFAULT = (((uint)((((uint)((ushort)(0x0))) << 16) | ((uint)((ushort)(unchecked((((ushort)(0x03)) << 10) | (ushort)(0x00))))))));

        [NativeTypeName("#define LOCALE_CUSTOM_UNSPECIFIED (MAKELCID(MAKELANGID(LANG_NEUTRAL, SUBLANG_CUSTOM_UNSPECIFIED), SORT_DEFAULT))")]
        public const uint LOCALE_CUSTOM_UNSPECIFIED = (((uint)((((uint)((ushort)(0x0))) << 16) | ((uint)((ushort)(unchecked((((ushort)(0x04)) << 10) | (ushort)(0x00))))))));

        [NativeTypeName("#define LOCALE_CUSTOM_UI_DEFAULT (MAKELCID(MAKELANGID(LANG_NEUTRAL, SUBLANG_UI_CUSTOM_DEFAULT), SORT_DEFAULT))")]
        public const uint LOCALE_CUSTOM_UI_DEFAULT = (((uint)((((uint)((ushort)(0x0))) << 16) | ((uint)((ushort)(unchecked((((ushort)(0x05)) << 10) | (ushort)(0x00))))))));

        [NativeTypeName("#define LOCALE_NEUTRAL (MAKELCID(MAKELANGID(LANG_NEUTRAL, SUBLANG_NEUTRAL), SORT_DEFAULT))")]
        public const uint LOCALE_NEUTRAL = (((uint)((((uint)((ushort)(0x0))) << 16) | ((uint)((ushort)(unchecked((((ushort)(0x00)) << 10) | (ushort)(0x00))))))));

        [NativeTypeName("#define LOCALE_INVARIANT (MAKELCID(MAKELANGID(LANG_INVARIANT, SUBLANG_NEUTRAL), SORT_DEFAULT))")]
        public const uint LOCALE_INVARIANT = (((uint)((((uint)((ushort)(0x0))) << 16) | ((uint)((ushort)(unchecked((((ushort)(0x00)) << 10) | (ushort)(0x7f))))))));

        [NativeTypeName("#define LOCALE_TRANSIENT_KEYBOARD1 0x2000")]
        public const int LOCALE_TRANSIENT_KEYBOARD1 = 0x2000;

        [NativeTypeName("#define LOCALE_TRANSIENT_KEYBOARD2 0x2400")]
        public const int LOCALE_TRANSIENT_KEYBOARD2 = 0x2400;

        [NativeTypeName("#define LOCALE_TRANSIENT_KEYBOARD3 0x2800")]
        public const int LOCALE_TRANSIENT_KEYBOARD3 = 0x2800;

        [NativeTypeName("#define LOCALE_TRANSIENT_KEYBOARD4 0x2c00")]
        public const int LOCALE_TRANSIENT_KEYBOARD4 = 0x2c00;

        [NativeTypeName("#define LOCALE_UNASSIGNED_LCID LOCALE_CUSTOM_UNSPECIFIED")]
        public const uint LOCALE_UNASSIGNED_LCID = (((uint)((((uint)((ushort)(0x0))) << 16) | ((uint)((ushort)(unchecked((((ushort)(0x04)) << 10) | (ushort)(0x00))))))));

        [NativeTypeName("#define DBG_EXCEPTION_HANDLED ((DWORD   )0x00010001L)")]
        public const uint DBG_EXCEPTION_HANDLED = ((uint)(0x00010001));

        [NativeTypeName("#define DBG_CONTINUE ((DWORD   )0x00010002L)")]
        public const uint DBG_CONTINUE = ((uint)(0x00010002));

        [NativeTypeName("#define DBG_REPLY_LATER ((DWORD   )0x40010001L)")]
        public const uint DBG_REPLY_LATER = ((uint)(0x40010001));

        [NativeTypeName("#define DBG_TERMINATE_THREAD ((DWORD   )0x40010003L)")]
        public const uint DBG_TERMINATE_THREAD = ((uint)(0x40010003));

        [NativeTypeName("#define DBG_TERMINATE_PROCESS ((DWORD   )0x40010004L)")]
        public const uint DBG_TERMINATE_PROCESS = ((uint)(0x40010004));

        [NativeTypeName("#define DBG_CONTROL_C ((DWORD   )0x40010005L)")]
        public const uint DBG_CONTROL_C = ((uint)(0x40010005));

        [NativeTypeName("#define DBG_PRINTEXCEPTION_C ((DWORD   )0x40010006L)")]
        public const uint DBG_PRINTEXCEPTION_C = ((uint)(0x40010006));

        [NativeTypeName("#define DBG_RIPEXCEPTION ((DWORD   )0x40010007L)")]
        public const uint DBG_RIPEXCEPTION = ((uint)(0x40010007));

        [NativeTypeName("#define DBG_CONTROL_BREAK ((DWORD   )0x40010008L)")]
        public const uint DBG_CONTROL_BREAK = ((uint)(0x40010008));

        [NativeTypeName("#define DBG_COMMAND_EXCEPTION ((DWORD   )0x40010009L)")]
        public const uint DBG_COMMAND_EXCEPTION = ((uint)(0x40010009));

        [NativeTypeName("#define DBG_PRINTEXCEPTION_WIDE_C ((DWORD   )0x4001000AL)")]
        public const uint DBG_PRINTEXCEPTION_WIDE_C = ((uint)(0x4001000A));

        [NativeTypeName("#define DBG_EXCEPTION_NOT_HANDLED ((DWORD   )0x80010001L)")]
        public const uint DBG_EXCEPTION_NOT_HANDLED = ((uint)(0x80010001));

        [NativeTypeName("#define MAXIMUM_WAIT_OBJECTS 64")]
        public const int MAXIMUM_WAIT_OBJECTS = 64;

        [NativeTypeName("#define MAXIMUM_SUSPEND_COUNT MAXCHAR")]
        public const int MAXIMUM_SUSPEND_COUNT = 0x7f;

        [NativeTypeName("#define _MM_HINT_T0 1")]
        public const int _MM_HINT_T0 = 1;

        [NativeTypeName("#define _MM_HINT_T1 2")]
        public const int _MM_HINT_T1 = 2;

        [NativeTypeName("#define _MM_HINT_T2 3")]
        public const int _MM_HINT_T2 = 3;

        [NativeTypeName("#define _MM_HINT_NTA 0")]
        public const int _MM_HINT_NTA = 0;

        [NativeTypeName("#define PF_TEMPORAL_LEVEL_1 _MM_HINT_T0")]
        public const int PF_TEMPORAL_LEVEL_1 = 1;

        [NativeTypeName("#define PF_TEMPORAL_LEVEL_2 _MM_HINT_T1")]
        public const int PF_TEMPORAL_LEVEL_2 = 2;

        [NativeTypeName("#define PF_TEMPORAL_LEVEL_3 _MM_HINT_T2")]
        public const int PF_TEMPORAL_LEVEL_3 = 3;

        [NativeTypeName("#define PF_NON_TEMPORAL_LEVEL_ALL _MM_HINT_NTA")]
        public const int PF_NON_TEMPORAL_LEVEL_ALL = 0;

        [NativeTypeName("#define EXCEPTION_READ_FAULT 0")]
        public const int EXCEPTION_READ_FAULT = 0;

        [NativeTypeName("#define EXCEPTION_WRITE_FAULT 1")]
        public const int EXCEPTION_WRITE_FAULT = 1;

        [NativeTypeName("#define EXCEPTION_EXECUTE_FAULT 8")]
        public const int EXCEPTION_EXECUTE_FAULT = 8;

        [NativeTypeName("#define WOW64_CONTEXT_i386 0x00010000")]
        public const int WOW64_CONTEXT_i386 = 0x00010000;

        [NativeTypeName("#define WOW64_CONTEXT_i486 0x00010000")]
        public const int WOW64_CONTEXT_i486 = 0x00010000;

        [NativeTypeName("#define WOW64_CONTEXT_CONTROL (WOW64_CONTEXT_i386 | 0x00000001L)")]
        public const int WOW64_CONTEXT_CONTROL = (0x00010000 | 0x00000001);

        [NativeTypeName("#define WOW64_CONTEXT_INTEGER (WOW64_CONTEXT_i386 | 0x00000002L)")]
        public const int WOW64_CONTEXT_INTEGER = (0x00010000 | 0x00000002);

        [NativeTypeName("#define WOW64_CONTEXT_SEGMENTS (WOW64_CONTEXT_i386 | 0x00000004L)")]
        public const int WOW64_CONTEXT_SEGMENTS = (0x00010000 | 0x00000004);

        [NativeTypeName("#define WOW64_CONTEXT_FLOATING_POINT (WOW64_CONTEXT_i386 | 0x00000008L)")]
        public const int WOW64_CONTEXT_FLOATING_POINT = (0x00010000 | 0x00000008);

        [NativeTypeName("#define WOW64_CONTEXT_DEBUG_REGISTERS (WOW64_CONTEXT_i386 | 0x00000010L)")]
        public const int WOW64_CONTEXT_DEBUG_REGISTERS = (0x00010000 | 0x00000010);

        [NativeTypeName("#define WOW64_CONTEXT_EXTENDED_REGISTERS (WOW64_CONTEXT_i386 | 0x00000020L)")]
        public const int WOW64_CONTEXT_EXTENDED_REGISTERS = (0x00010000 | 0x00000020);

        [NativeTypeName("#define WOW64_CONTEXT_FULL (WOW64_CONTEXT_CONTROL | WOW64_CONTEXT_INTEGER | WOW64_CONTEXT_SEGMENTS)")]
        public const int WOW64_CONTEXT_FULL = ((0x00010000 | 0x00000001) | (0x00010000 | 0x00000002) | (0x00010000 | 0x00000004));

        [NativeTypeName("#define WOW64_CONTEXT_ALL (WOW64_CONTEXT_CONTROL | WOW64_CONTEXT_INTEGER | WOW64_CONTEXT_SEGMENTS | \\\r\n                                 WOW64_CONTEXT_FLOATING_POINT | WOW64_CONTEXT_DEBUG_REGISTERS | \\\r\n                                 WOW64_CONTEXT_EXTENDED_REGISTERS)")]
        public const int WOW64_CONTEXT_ALL = ((0x00010000 | 0x00000001) | (0x00010000 | 0x00000002) | (0x00010000 | 0x00000004) | (0x00010000 | 0x00000008) | (0x00010000 | 0x00000010) | (0x00010000 | 0x00000020));

        [NativeTypeName("#define WOW64_CONTEXT_XSTATE (WOW64_CONTEXT_i386 | 0x00000040L)")]
        public const int WOW64_CONTEXT_XSTATE = (0x00010000 | 0x00000040);

        [NativeTypeName("#define WOW64_CONTEXT_EXCEPTION_ACTIVE 0x08000000")]
        public const int WOW64_CONTEXT_EXCEPTION_ACTIVE = 0x08000000;

        [NativeTypeName("#define WOW64_CONTEXT_SERVICE_ACTIVE 0x10000000")]
        public const int WOW64_CONTEXT_SERVICE_ACTIVE = 0x10000000;

        [NativeTypeName("#define WOW64_CONTEXT_EXCEPTION_REQUEST 0x40000000")]
        public const int WOW64_CONTEXT_EXCEPTION_REQUEST = 0x40000000;

        [NativeTypeName("#define WOW64_CONTEXT_EXCEPTION_REPORTING 0x80000000")]
        public const uint WOW64_CONTEXT_EXCEPTION_REPORTING = 0x80000000;

        [NativeTypeName("#define WOW64_SIZE_OF_80387_REGISTERS 80")]
        public const int WOW64_SIZE_OF_80387_REGISTERS = 80;

        [NativeTypeName("#define WOW64_MAXIMUM_SUPPORTED_EXTENSION 512")]
        public const int WOW64_MAXIMUM_SUPPORTED_EXTENSION = 512;

        [NativeTypeName("#define EXCEPTION_NONCONTINUABLE 0x1")]
        public const int EXCEPTION_NONCONTINUABLE = 0x1;

        [NativeTypeName("#define EXCEPTION_UNWINDING 0x2")]
        public const int EXCEPTION_UNWINDING = 0x2;

        [NativeTypeName("#define EXCEPTION_EXIT_UNWIND 0x4")]
        public const int EXCEPTION_EXIT_UNWIND = 0x4;

        [NativeTypeName("#define EXCEPTION_STACK_INVALID 0x8")]
        public const int EXCEPTION_STACK_INVALID = 0x8;

        [NativeTypeName("#define EXCEPTION_NESTED_CALL 0x10")]
        public const int EXCEPTION_NESTED_CALL = 0x10;

        [NativeTypeName("#define EXCEPTION_TARGET_UNWIND 0x20")]
        public const int EXCEPTION_TARGET_UNWIND = 0x20;

        [NativeTypeName("#define EXCEPTION_COLLIDED_UNWIND 0x40")]
        public const int EXCEPTION_COLLIDED_UNWIND = 0x40;

        [NativeTypeName("#define EXCEPTION_SOFTWARE_ORIGINATE 0x80")]
        public const int EXCEPTION_SOFTWARE_ORIGINATE = 0x80;

        [NativeTypeName("#define EXCEPTION_UNWIND (EXCEPTION_UNWINDING | EXCEPTION_EXIT_UNWIND | \\\r\n                          EXCEPTION_TARGET_UNWIND | EXCEPTION_COLLIDED_UNWIND)")]
        public const int EXCEPTION_UNWIND = (0x2 | 0x4 | 0x20 | 0x40);

        [NativeTypeName("#define EXCEPTION_MAXIMUM_PARAMETERS 15")]
        public const int EXCEPTION_MAXIMUM_PARAMETERS = 15;

        [NativeTypeName("#define DELETE (0x00010000L)")]
        public const int DELETE = (0x00010000);

        [NativeTypeName("#define READ_CONTROL (0x00020000L)")]
        public const int READ_CONTROL = (0x00020000);

        [NativeTypeName("#define WRITE_DAC (0x00040000L)")]
        public const int WRITE_DAC = (0x00040000);

        [NativeTypeName("#define WRITE_OWNER (0x00080000L)")]
        public const int WRITE_OWNER = (0x00080000);

        [NativeTypeName("#define SYNCHRONIZE (0x00100000L)")]
        public const int SYNCHRONIZE = (0x00100000);

        [NativeTypeName("#define STANDARD_RIGHTS_REQUIRED (0x000F0000L)")]
        public const int STANDARD_RIGHTS_REQUIRED = (0x000F0000);

        [NativeTypeName("#define STANDARD_RIGHTS_READ (READ_CONTROL)")]
        public const int STANDARD_RIGHTS_READ = ((0x00020000));

        [NativeTypeName("#define STANDARD_RIGHTS_WRITE (READ_CONTROL)")]
        public const int STANDARD_RIGHTS_WRITE = ((0x00020000));

        [NativeTypeName("#define STANDARD_RIGHTS_EXECUTE (READ_CONTROL)")]
        public const int STANDARD_RIGHTS_EXECUTE = ((0x00020000));

        [NativeTypeName("#define STANDARD_RIGHTS_ALL (0x001F0000L)")]
        public const int STANDARD_RIGHTS_ALL = (0x001F0000);

        [NativeTypeName("#define SPECIFIC_RIGHTS_ALL (0x0000FFFFL)")]
        public const int SPECIFIC_RIGHTS_ALL = (0x0000FFFF);

        [NativeTypeName("#define ACCESS_SYSTEM_SECURITY (0x01000000L)")]
        public const int ACCESS_SYSTEM_SECURITY = (0x01000000);

        [NativeTypeName("#define MAXIMUM_ALLOWED (0x02000000L)")]
        public const int MAXIMUM_ALLOWED = (0x02000000);

        [NativeTypeName("#define GENERIC_READ (0x80000000L)")]
        public const uint GENERIC_READ = (0x80000000);

        [NativeTypeName("#define GENERIC_WRITE (0x40000000L)")]
        public const int GENERIC_WRITE = (0x40000000);

        [NativeTypeName("#define GENERIC_EXECUTE (0x20000000L)")]
        public const int GENERIC_EXECUTE = (0x20000000);

        [NativeTypeName("#define GENERIC_ALL (0x10000000L)")]
        public const int GENERIC_ALL = (0x10000000);

        [NativeTypeName("#define SID_REVISION (1)")]
        public const int SID_REVISION = (1);

        [NativeTypeName("#define SID_MAX_SUB_AUTHORITIES (15)")]
        public const int SID_MAX_SUB_AUTHORITIES = (15);

        [NativeTypeName("#define SID_RECOMMENDED_SUB_AUTHORITIES (1)")]
        public const int SID_RECOMMENDED_SUB_AUTHORITIES = (1);

        [NativeTypeName("#define SID_HASH_SIZE 32")]
        public const int SID_HASH_SIZE = 32;

        [NativeTypeName("#define FOREST_USER_RID_MAX (0x000001F3L)")]
        public const int FOREST_USER_RID_MAX = (0x000001F3);

        [NativeTypeName("#define ACL_REVISION (2)")]
        public const int ACL_REVISION = (2);

        [NativeTypeName("#define ACL_REVISION_DS (4)")]
        public const int ACL_REVISION_DS = (4);

        [NativeTypeName("#define ACL_REVISION1 (1)")]
        public const int ACL_REVISION1 = (1);

        [NativeTypeName("#define MIN_ACL_REVISION ACL_REVISION2")]
        public const int MIN_ACL_REVISION = (2);

        [NativeTypeName("#define ACL_REVISION2 (2)")]
        public const int ACL_REVISION2 = (2);

        [NativeTypeName("#define ACL_REVISION3 (3)")]
        public const int ACL_REVISION3 = (3);

        [NativeTypeName("#define ACL_REVISION4 (4)")]
        public const int ACL_REVISION4 = (4);

        [NativeTypeName("#define ACCESS_MIN_MS_ACE_TYPE (0x0)")]
        public const int ACCESS_MIN_MS_ACE_TYPE = (0x0);

        [NativeTypeName("#define ACCESS_ALLOWED_ACE_TYPE (0x0)")]
        public const int ACCESS_ALLOWED_ACE_TYPE = (0x0);

        [NativeTypeName("#define ACCESS_DENIED_ACE_TYPE (0x1)")]
        public const int ACCESS_DENIED_ACE_TYPE = (0x1);

        [NativeTypeName("#define SYSTEM_AUDIT_ACE_TYPE (0x2)")]
        public const int SYSTEM_AUDIT_ACE_TYPE = (0x2);

        [NativeTypeName("#define SYSTEM_ALARM_ACE_TYPE (0x3)")]
        public const int SYSTEM_ALARM_ACE_TYPE = (0x3);

        [NativeTypeName("#define ACCESS_MAX_MS_V2_ACE_TYPE (0x3)")]
        public const int ACCESS_MAX_MS_V2_ACE_TYPE = (0x3);

        [NativeTypeName("#define ACCESS_ALLOWED_COMPOUND_ACE_TYPE (0x4)")]
        public const int ACCESS_ALLOWED_COMPOUND_ACE_TYPE = (0x4);

        [NativeTypeName("#define ACCESS_MAX_MS_V3_ACE_TYPE (0x4)")]
        public const int ACCESS_MAX_MS_V3_ACE_TYPE = (0x4);

        [NativeTypeName("#define ACCESS_MIN_MS_OBJECT_ACE_TYPE (0x5)")]
        public const int ACCESS_MIN_MS_OBJECT_ACE_TYPE = (0x5);

        [NativeTypeName("#define ACCESS_ALLOWED_OBJECT_ACE_TYPE (0x5)")]
        public const int ACCESS_ALLOWED_OBJECT_ACE_TYPE = (0x5);

        [NativeTypeName("#define ACCESS_DENIED_OBJECT_ACE_TYPE (0x6)")]
        public const int ACCESS_DENIED_OBJECT_ACE_TYPE = (0x6);

        [NativeTypeName("#define SYSTEM_AUDIT_OBJECT_ACE_TYPE (0x7)")]
        public const int SYSTEM_AUDIT_OBJECT_ACE_TYPE = (0x7);

        [NativeTypeName("#define SYSTEM_ALARM_OBJECT_ACE_TYPE (0x8)")]
        public const int SYSTEM_ALARM_OBJECT_ACE_TYPE = (0x8);

        [NativeTypeName("#define ACCESS_MAX_MS_OBJECT_ACE_TYPE (0x8)")]
        public const int ACCESS_MAX_MS_OBJECT_ACE_TYPE = (0x8);

        [NativeTypeName("#define ACCESS_MAX_MS_V4_ACE_TYPE (0x8)")]
        public const int ACCESS_MAX_MS_V4_ACE_TYPE = (0x8);

        [NativeTypeName("#define ACCESS_MAX_MS_ACE_TYPE (0x8)")]
        public const int ACCESS_MAX_MS_ACE_TYPE = (0x8);

        [NativeTypeName("#define ACCESS_ALLOWED_CALLBACK_ACE_TYPE (0x9)")]
        public const int ACCESS_ALLOWED_CALLBACK_ACE_TYPE = (0x9);

        [NativeTypeName("#define ACCESS_DENIED_CALLBACK_ACE_TYPE (0xA)")]
        public const int ACCESS_DENIED_CALLBACK_ACE_TYPE = (0xA);

        [NativeTypeName("#define ACCESS_ALLOWED_CALLBACK_OBJECT_ACE_TYPE (0xB)")]
        public const int ACCESS_ALLOWED_CALLBACK_OBJECT_ACE_TYPE = (0xB);

        [NativeTypeName("#define ACCESS_DENIED_CALLBACK_OBJECT_ACE_TYPE (0xC)")]
        public const int ACCESS_DENIED_CALLBACK_OBJECT_ACE_TYPE = (0xC);

        [NativeTypeName("#define SYSTEM_AUDIT_CALLBACK_ACE_TYPE (0xD)")]
        public const int SYSTEM_AUDIT_CALLBACK_ACE_TYPE = (0xD);

        [NativeTypeName("#define SYSTEM_ALARM_CALLBACK_ACE_TYPE (0xE)")]
        public const int SYSTEM_ALARM_CALLBACK_ACE_TYPE = (0xE);

        [NativeTypeName("#define SYSTEM_AUDIT_CALLBACK_OBJECT_ACE_TYPE (0xF)")]
        public const int SYSTEM_AUDIT_CALLBACK_OBJECT_ACE_TYPE = (0xF);

        [NativeTypeName("#define SYSTEM_ALARM_CALLBACK_OBJECT_ACE_TYPE (0x10)")]
        public const int SYSTEM_ALARM_CALLBACK_OBJECT_ACE_TYPE = (0x10);

        [NativeTypeName("#define SYSTEM_MANDATORY_LABEL_ACE_TYPE (0x11)")]
        public const int SYSTEM_MANDATORY_LABEL_ACE_TYPE = (0x11);

        [NativeTypeName("#define SYSTEM_RESOURCE_ATTRIBUTE_ACE_TYPE (0x12)")]
        public const int SYSTEM_RESOURCE_ATTRIBUTE_ACE_TYPE = (0x12);

        [NativeTypeName("#define SYSTEM_SCOPED_POLICY_ID_ACE_TYPE (0x13)")]
        public const int SYSTEM_SCOPED_POLICY_ID_ACE_TYPE = (0x13);

        [NativeTypeName("#define SYSTEM_PROCESS_TRUST_LABEL_ACE_TYPE (0x14)")]
        public const int SYSTEM_PROCESS_TRUST_LABEL_ACE_TYPE = (0x14);

        [NativeTypeName("#define SYSTEM_ACCESS_FILTER_ACE_TYPE (0x15)")]
        public const int SYSTEM_ACCESS_FILTER_ACE_TYPE = (0x15);

        [NativeTypeName("#define ACCESS_MAX_MS_V5_ACE_TYPE (0x15)")]
        public const int ACCESS_MAX_MS_V5_ACE_TYPE = (0x15);

        [NativeTypeName("#define OBJECT_INHERIT_ACE (0x1)")]
        public const int OBJECT_INHERIT_ACE = (0x1);

        [NativeTypeName("#define CONTAINER_INHERIT_ACE (0x2)")]
        public const int CONTAINER_INHERIT_ACE = (0x2);

        [NativeTypeName("#define NO_PROPAGATE_INHERIT_ACE (0x4)")]
        public const int NO_PROPAGATE_INHERIT_ACE = (0x4);

        [NativeTypeName("#define INHERIT_ONLY_ACE (0x8)")]
        public const int INHERIT_ONLY_ACE = (0x8);

        [NativeTypeName("#define INHERITED_ACE (0x10)")]
        public const int INHERITED_ACE = (0x10);

        [NativeTypeName("#define VALID_INHERIT_FLAGS (0x1F)")]
        public const int VALID_INHERIT_FLAGS = (0x1F);

        [NativeTypeName("#define CRITICAL_ACE_FLAG (0x20)")]
        public const int CRITICAL_ACE_FLAG = (0x20);

        [NativeTypeName("#define SUCCESSFUL_ACCESS_ACE_FLAG (0x40)")]
        public const int SUCCESSFUL_ACCESS_ACE_FLAG = (0x40);

        [NativeTypeName("#define FAILED_ACCESS_ACE_FLAG (0x80)")]
        public const int FAILED_ACCESS_ACE_FLAG = (0x80);

        [NativeTypeName("#define TRUST_PROTECTED_FILTER_ACE_FLAG (0x40)")]
        public const int TRUST_PROTECTED_FILTER_ACE_FLAG = (0x40);

        [NativeTypeName("#define SYSTEM_MANDATORY_LABEL_NO_WRITE_UP 0x1")]
        public const int SYSTEM_MANDATORY_LABEL_NO_WRITE_UP = 0x1;

        [NativeTypeName("#define SYSTEM_MANDATORY_LABEL_NO_READ_UP 0x2")]
        public const int SYSTEM_MANDATORY_LABEL_NO_READ_UP = 0x2;

        [NativeTypeName("#define SYSTEM_MANDATORY_LABEL_NO_EXECUTE_UP 0x4")]
        public const int SYSTEM_MANDATORY_LABEL_NO_EXECUTE_UP = 0x4;

        [NativeTypeName("#define SYSTEM_MANDATORY_LABEL_VALID_MASK (SYSTEM_MANDATORY_LABEL_NO_WRITE_UP   | \\\r\n                                           SYSTEM_MANDATORY_LABEL_NO_READ_UP    | \\\r\n                                           SYSTEM_MANDATORY_LABEL_NO_EXECUTE_UP)")]
        public const int SYSTEM_MANDATORY_LABEL_VALID_MASK = (0x1 | 0x2 | 0x4);

        [NativeTypeName("#define SYSTEM_PROCESS_TRUST_LABEL_VALID_MASK 0x00ffffff")]
        public const int SYSTEM_PROCESS_TRUST_LABEL_VALID_MASK = 0x00ffffff;

        [NativeTypeName("#define SYSTEM_PROCESS_TRUST_NOCONSTRAINT_MASK 0xffffffff")]
        public const uint SYSTEM_PROCESS_TRUST_NOCONSTRAINT_MASK = 0xffffffff;

        [NativeTypeName("#define SYSTEM_ACCESS_FILTER_VALID_MASK 0x00ffffff")]
        public const int SYSTEM_ACCESS_FILTER_VALID_MASK = 0x00ffffff;

        [NativeTypeName("#define SYSTEM_ACCESS_FILTER_NOCONSTRAINT_MASK 0xffffffff")]
        public const uint SYSTEM_ACCESS_FILTER_NOCONSTRAINT_MASK = 0xffffffff;

        [NativeTypeName("#define ACE_OBJECT_TYPE_PRESENT 0x1")]
        public const int ACE_OBJECT_TYPE_PRESENT = 0x1;

        [NativeTypeName("#define ACE_INHERITED_OBJECT_TYPE_PRESENT 0x2")]
        public const int ACE_INHERITED_OBJECT_TYPE_PRESENT = 0x2;

        [NativeTypeName("#define ACCESS_OBJECT_GUID 0")]
        public const int ACCESS_OBJECT_GUID = 0;

        [NativeTypeName("#define ACCESS_PROPERTY_SET_GUID 1")]
        public const int ACCESS_PROPERTY_SET_GUID = 1;

        [NativeTypeName("#define ACCESS_PROPERTY_GUID 2")]
        public const int ACCESS_PROPERTY_GUID = 2;

        [NativeTypeName("#define ACCESS_MAX_LEVEL 4")]
        public const int ACCESS_MAX_LEVEL = 4;

        [NativeTypeName("#define AUDIT_ALLOW_NO_PRIVILEGE 0x1")]
        public const int AUDIT_ALLOW_NO_PRIVILEGE = 0x1;

        [NativeTypeName("#define ACCESS_DS_SOURCE_A \"DS\"")]
        public static ReadOnlySpan<byte> ACCESS_DS_SOURCE_A => new byte[] { 0x44, 0x53, 0x00 };

        [NativeTypeName("#define ACCESS_DS_SOURCE_W L\"DS\"")]
        public const string ACCESS_DS_SOURCE_W = "DS";

        [NativeTypeName("#define ACCESS_DS_OBJECT_TYPE_NAME_A \"Directory Service Object\"")]
        public static ReadOnlySpan<byte> ACCESS_DS_OBJECT_TYPE_NAME_A => new byte[] { 0x44, 0x69, 0x72, 0x65, 0x63, 0x74, 0x6F, 0x72, 0x79, 0x20, 0x53, 0x65, 0x72, 0x76, 0x69, 0x63, 0x65, 0x20, 0x4F, 0x62, 0x6A, 0x65, 0x63, 0x74, 0x00 };

        [NativeTypeName("#define ACCESS_DS_OBJECT_TYPE_NAME_W L\"Directory Service Object\"")]
        public const string ACCESS_DS_OBJECT_TYPE_NAME_W = "Directory Service Object";

        [NativeTypeName("#define PRIVILEGE_SET_ALL_NECESSARY (1)")]
        public const int PRIVILEGE_SET_ALL_NECESSARY = (1);

        [NativeTypeName("#define ACCESS_REASON_TYPE_MASK 0x00ff0000")]
        public const int ACCESS_REASON_TYPE_MASK = 0x00ff0000;

        [NativeTypeName("#define ACCESS_REASON_DATA_MASK 0x0000ffff")]
        public const int ACCESS_REASON_DATA_MASK = 0x0000ffff;

        [NativeTypeName("#define ACCESS_REASON_STAGING_MASK 0x80000000")]
        public const uint ACCESS_REASON_STAGING_MASK = 0x80000000;

        [NativeTypeName("#define ACCESS_REASON_EXDATA_MASK 0x7f000000")]
        public const int ACCESS_REASON_EXDATA_MASK = 0x7f000000;

        [NativeTypeName("#define DEFAULT_IMPERSONATION_LEVEL SecurityImpersonation")]
        public const SECURITY_IMPERSONATION_LEVEL DEFAULT_IMPERSONATION_LEVEL = SecurityImpersonation;

        [NativeTypeName("#define TOKEN_ASSIGN_PRIMARY (0x0001)")]
        public const int TOKEN_ASSIGN_PRIMARY = (0x0001);

        [NativeTypeName("#define TOKEN_DUPLICATE (0x0002)")]
        public const int TOKEN_DUPLICATE = (0x0002);

        [NativeTypeName("#define TOKEN_IMPERSONATE (0x0004)")]
        public const int TOKEN_IMPERSONATE = (0x0004);

        [NativeTypeName("#define TOKEN_QUERY (0x0008)")]
        public const int TOKEN_QUERY = (0x0008);

        [NativeTypeName("#define TOKEN_QUERY_SOURCE (0x0010)")]
        public const int TOKEN_QUERY_SOURCE = (0x0010);

        [NativeTypeName("#define TOKEN_ADJUST_PRIVILEGES (0x0020)")]
        public const int TOKEN_ADJUST_PRIVILEGES = (0x0020);

        [NativeTypeName("#define TOKEN_ADJUST_GROUPS (0x0040)")]
        public const int TOKEN_ADJUST_GROUPS = (0x0040);

        [NativeTypeName("#define TOKEN_ADJUST_DEFAULT (0x0080)")]
        public const int TOKEN_ADJUST_DEFAULT = (0x0080);

        [NativeTypeName("#define TOKEN_ADJUST_SESSIONID (0x0100)")]
        public const int TOKEN_ADJUST_SESSIONID = (0x0100);

        [NativeTypeName("#define TOKEN_ALL_ACCESS_P (STANDARD_RIGHTS_REQUIRED  |\\\r\n                          TOKEN_ASSIGN_PRIMARY      |\\\r\n                          TOKEN_DUPLICATE           |\\\r\n                          TOKEN_IMPERSONATE         |\\\r\n                          TOKEN_QUERY               |\\\r\n                          TOKEN_QUERY_SOURCE        |\\\r\n                          TOKEN_ADJUST_PRIVILEGES   |\\\r\n                          TOKEN_ADJUST_GROUPS       |\\\r\n                          TOKEN_ADJUST_DEFAULT )")]
        public const int TOKEN_ALL_ACCESS_P = ((0x000F0000) | (0x0001) | (0x0002) | (0x0004) | (0x0008) | (0x0010) | (0x0020) | (0x0040) | (0x0080));

        [NativeTypeName("#define TOKEN_ALL_ACCESS (TOKEN_ALL_ACCESS_P |\\\r\n                          TOKEN_ADJUST_SESSIONID )")]
        public const int TOKEN_ALL_ACCESS = (((0x000F0000) | (0x0001) | (0x0002) | (0x0004) | (0x0008) | (0x0010) | (0x0020) | (0x0040) | (0x0080)) | (0x0100));

        [NativeTypeName("#define TOKEN_READ (STANDARD_RIGHTS_READ      |\\\r\n                          TOKEN_QUERY)")]
        public const int TOKEN_READ = (((0x00020000)) | (0x0008));

        [NativeTypeName("#define TOKEN_WRITE (STANDARD_RIGHTS_WRITE     |\\\r\n                          TOKEN_ADJUST_PRIVILEGES   |\\\r\n                          TOKEN_ADJUST_GROUPS       |\\\r\n                          TOKEN_ADJUST_DEFAULT)")]
        public const int TOKEN_WRITE = (((0x00020000)) | (0x0020) | (0x0040) | (0x0080));

        [NativeTypeName("#define TOKEN_EXECUTE (STANDARD_RIGHTS_EXECUTE)")]
        public const int TOKEN_EXECUTE = (((0x00020000)));

        [NativeTypeName("#define TOKEN_TRUST_CONSTRAINT_MASK (STANDARD_RIGHTS_READ  | \\\r\n                                       TOKEN_QUERY  |\\\r\n                                       TOKEN_QUERY_SOURCE )")]
        public const int TOKEN_TRUST_CONSTRAINT_MASK = (((0x00020000)) | (0x0008) | (0x0010));

        [NativeTypeName("#define TOKEN_ACCESS_PSEUDO_HANDLE_WIN8 (TOKEN_QUERY | TOKEN_QUERY_SOURCE)")]
        public const int TOKEN_ACCESS_PSEUDO_HANDLE_WIN8 = ((0x0008) | (0x0010));

        [NativeTypeName("#define TOKEN_ACCESS_PSEUDO_HANDLE TOKEN_ACCESS_PSEUDO_HANDLE_WIN8")]
        public const int TOKEN_ACCESS_PSEUDO_HANDLE = ((0x0008) | (0x0010));

        [NativeTypeName("#define TOKEN_USER_MAX_SIZE (sizeof(TOKEN_USER) + SECURITY_MAX_SID_SIZE)")]
        public static uint TOKEN_USER_MAX_SIZE => unchecked((uint)(sizeof(TOKEN_USER)) + (12 - 4 + ((15) * 4)));

        [NativeTypeName("#define TOKEN_OWNER_MAX_SIZE (sizeof(TOKEN_OWNER) + SECURITY_MAX_SID_SIZE)")]
        public static uint TOKEN_OWNER_MAX_SIZE => unchecked((uint)(sizeof(TOKEN_OWNER)) + (12 - 4 + ((15) * 4)));

        [NativeTypeName("#define TOKEN_MANDATORY_POLICY_OFF 0x0")]
        public const int TOKEN_MANDATORY_POLICY_OFF = 0x0;

        [NativeTypeName("#define TOKEN_MANDATORY_POLICY_NO_WRITE_UP 0x1")]
        public const int TOKEN_MANDATORY_POLICY_NO_WRITE_UP = 0x1;

        [NativeTypeName("#define TOKEN_MANDATORY_POLICY_NEW_PROCESS_MIN 0x2")]
        public const int TOKEN_MANDATORY_POLICY_NEW_PROCESS_MIN = 0x2;

        [NativeTypeName("#define TOKEN_MANDATORY_POLICY_VALID_MASK (TOKEN_MANDATORY_POLICY_NO_WRITE_UP | \\\r\n                                                TOKEN_MANDATORY_POLICY_NEW_PROCESS_MIN)")]
        public const int TOKEN_MANDATORY_POLICY_VALID_MASK = (0x1 | 0x2);

        [NativeTypeName("#define TOKEN_INTEGRITY_LEVEL_MAX_SIZE ((((DWORD)(sizeof(TOKEN_MANDATORY_LABEL)) + sizeof(PVOID) - 1) & ~(sizeof(PVOID)-1)) + SECURITY_MAX_SID_SIZE)")]
        public static uint TOKEN_INTEGRITY_LEVEL_MAX_SIZE => unchecked((((uint)((uint)(sizeof(TOKEN_MANDATORY_LABEL))) + (uint)(sizeof(void*)) - 1) & ~((uint)(sizeof(void*)) - 1)) + (12 - 4 + ((15) * 4)));

        [NativeTypeName("#define POLICY_AUDIT_SUBCATEGORY_COUNT (59)")]
        public const int POLICY_AUDIT_SUBCATEGORY_COUNT = (59);

        [NativeTypeName("#define TOKEN_SOURCE_LENGTH 8")]
        public const int TOKEN_SOURCE_LENGTH = 8;

        [NativeTypeName("#define TOKEN_APPCONTAINER_SID_MAX_SIZE (sizeof(TOKEN_APPCONTAINER_INFORMATION) + SECURITY_MAX_SID_SIZE)")]
        public static uint TOKEN_APPCONTAINER_SID_MAX_SIZE => unchecked((uint)(sizeof(TOKEN_APPCONTAINER_INFORMATION)) + (12 - 4 + ((15) * 4)));

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_TYPE_INVALID 0x00")]
        public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_INVALID = 0x00;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_TYPE_INT64 0x01")]
        public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_INT64 = 0x01;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_TYPE_UINT64 0x02")]
        public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_UINT64 = 0x02;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_TYPE_STRING 0x03")]
        public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_STRING = 0x03;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_TYPE_FQBN 0x04")]
        public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_FQBN = 0x04;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_TYPE_SID 0x05")]
        public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_SID = 0x05;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_TYPE_BOOLEAN 0x06")]
        public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_BOOLEAN = 0x06;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_TYPE_OCTET_STRING 0x10")]
        public const int CLAIM_SECURITY_ATTRIBUTE_TYPE_OCTET_STRING = 0x10;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_NON_INHERITABLE 0x0001")]
        public const int CLAIM_SECURITY_ATTRIBUTE_NON_INHERITABLE = 0x0001;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_VALUE_CASE_SENSITIVE 0x0002")]
        public const int CLAIM_SECURITY_ATTRIBUTE_VALUE_CASE_SENSITIVE = 0x0002;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_USE_FOR_DENY_ONLY 0x0004")]
        public const int CLAIM_SECURITY_ATTRIBUTE_USE_FOR_DENY_ONLY = 0x0004;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_DISABLED_BY_DEFAULT 0x0008")]
        public const int CLAIM_SECURITY_ATTRIBUTE_DISABLED_BY_DEFAULT = 0x0008;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_DISABLED 0x0010")]
        public const int CLAIM_SECURITY_ATTRIBUTE_DISABLED = 0x0010;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_MANDATORY 0x0020")]
        public const int CLAIM_SECURITY_ATTRIBUTE_MANDATORY = 0x0020;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_VALID_FLAGS (    \\\r\n                        CLAIM_SECURITY_ATTRIBUTE_NON_INHERITABLE       |  \\\r\n                        CLAIM_SECURITY_ATTRIBUTE_VALUE_CASE_SENSITIVE  |  \\\r\n                        CLAIM_SECURITY_ATTRIBUTE_USE_FOR_DENY_ONLY     |  \\\r\n                        CLAIM_SECURITY_ATTRIBUTE_DISABLED_BY_DEFAULT   |  \\\r\n                        CLAIM_SECURITY_ATTRIBUTE_DISABLED              |  \\\r\n                        CLAIM_SECURITY_ATTRIBUTE_MANDATORY )")]
        public const int CLAIM_SECURITY_ATTRIBUTE_VALID_FLAGS = (0x0001 | 0x0002 | 0x0004 | 0x0008 | 0x0010 | 0x0020);

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTE_CUSTOM_FLAGS 0xFFFF0000")]
        public const uint CLAIM_SECURITY_ATTRIBUTE_CUSTOM_FLAGS = 0xFFFF0000;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTES_INFORMATION_VERSION_V1 1")]
        public const int CLAIM_SECURITY_ATTRIBUTES_INFORMATION_VERSION_V1 = 1;

        [NativeTypeName("#define CLAIM_SECURITY_ATTRIBUTES_INFORMATION_VERSION CLAIM_SECURITY_ATTRIBUTES_INFORMATION_VERSION_V1")]
        public const int CLAIM_SECURITY_ATTRIBUTES_INFORMATION_VERSION = 1;

        [NativeTypeName("#define DISABLE_MAX_PRIVILEGE 0x1")]
        public const int DISABLE_MAX_PRIVILEGE = 0x1;

        [NativeTypeName("#define SANDBOX_INERT 0x2")]
        public const int SANDBOX_INERT = 0x2;

        [NativeTypeName("#define LUA_TOKEN 0x4")]
        public const int LUA_TOKEN = 0x4;

        [NativeTypeName("#define WRITE_RESTRICTED 0x8")]
        public const int WRITE_RESTRICTED = 0x8;

        [NativeTypeName("#define OWNER_SECURITY_INFORMATION (0x00000001L)")]
        public const int OWNER_SECURITY_INFORMATION = (0x00000001);

        [NativeTypeName("#define GROUP_SECURITY_INFORMATION (0x00000002L)")]
        public const int GROUP_SECURITY_INFORMATION = (0x00000002);

        [NativeTypeName("#define DACL_SECURITY_INFORMATION (0x00000004L)")]
        public const int DACL_SECURITY_INFORMATION = (0x00000004);

        [NativeTypeName("#define SACL_SECURITY_INFORMATION (0x00000008L)")]
        public const int SACL_SECURITY_INFORMATION = (0x00000008);

        [NativeTypeName("#define LABEL_SECURITY_INFORMATION (0x00000010L)")]
        public const int LABEL_SECURITY_INFORMATION = (0x00000010);

        [NativeTypeName("#define ATTRIBUTE_SECURITY_INFORMATION (0x00000020L)")]
        public const int ATTRIBUTE_SECURITY_INFORMATION = (0x00000020);

        [NativeTypeName("#define SCOPE_SECURITY_INFORMATION (0x00000040L)")]
        public const int SCOPE_SECURITY_INFORMATION = (0x00000040);

        [NativeTypeName("#define ACCESS_FILTER_SECURITY_INFORMATION (0x00000100L)")]
        public const int ACCESS_FILTER_SECURITY_INFORMATION = (0x00000100);

        [NativeTypeName("#define BACKUP_SECURITY_INFORMATION (0x00010000L)")]
        public const int BACKUP_SECURITY_INFORMATION = (0x00010000);

        [NativeTypeName("#define PROTECTED_DACL_SECURITY_INFORMATION (0x80000000L)")]
        public const uint PROTECTED_DACL_SECURITY_INFORMATION = (0x80000000);

        [NativeTypeName("#define PROTECTED_SACL_SECURITY_INFORMATION (0x40000000L)")]
        public const int PROTECTED_SACL_SECURITY_INFORMATION = (0x40000000);

        [NativeTypeName("#define UNPROTECTED_DACL_SECURITY_INFORMATION (0x20000000L)")]
        public const int UNPROTECTED_DACL_SECURITY_INFORMATION = (0x20000000);

        [NativeTypeName("#define UNPROTECTED_SACL_SECURITY_INFORMATION (0x10000000L)")]
        public const int UNPROTECTED_SACL_SECURITY_INFORMATION = (0x10000000);

        [NativeTypeName("#define THREAD_TERMINATE (0x0001)")]
        public const int THREAD_TERMINATE = (0x0001);

        [NativeTypeName("#define THREAD_SUSPEND_RESUME (0x0002)")]
        public const int THREAD_SUSPEND_RESUME = (0x0002);

        [NativeTypeName("#define THREAD_GET_CONTEXT (0x0008)")]
        public const int THREAD_GET_CONTEXT = (0x0008);

        [NativeTypeName("#define THREAD_SET_CONTEXT (0x0010)")]
        public const int THREAD_SET_CONTEXT = (0x0010);

        [NativeTypeName("#define THREAD_QUERY_INFORMATION (0x0040)")]
        public const int THREAD_QUERY_INFORMATION = (0x0040);

        [NativeTypeName("#define THREAD_SET_INFORMATION (0x0020)")]
        public const int THREAD_SET_INFORMATION = (0x0020);

        [NativeTypeName("#define THREAD_SET_THREAD_TOKEN (0x0080)")]
        public const int THREAD_SET_THREAD_TOKEN = (0x0080);

        [NativeTypeName("#define THREAD_IMPERSONATE (0x0100)")]
        public const int THREAD_IMPERSONATE = (0x0100);

        [NativeTypeName("#define THREAD_DIRECT_IMPERSONATION (0x0200)")]
        public const int THREAD_DIRECT_IMPERSONATION = (0x0200);

        [NativeTypeName("#define THREAD_SET_LIMITED_INFORMATION (0x0400)")]
        public const int THREAD_SET_LIMITED_INFORMATION = (0x0400);

        [NativeTypeName("#define THREAD_QUERY_LIMITED_INFORMATION (0x0800)")]
        public const int THREAD_QUERY_LIMITED_INFORMATION = (0x0800);

        [NativeTypeName("#define THREAD_RESUME (0x1000)")]
        public const int THREAD_RESUME = (0x1000);

        [NativeTypeName("#define THREAD_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | \\\r\n                                   0xFFFF)")]
        public const int THREAD_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0xFFFF);

        [NativeTypeName("#define FLS_MAXIMUM_AVAILABLE 4080")]
        public const int FLS_MAXIMUM_AVAILABLE = 4080;

        [NativeTypeName("#define TLS_MINIMUM_AVAILABLE 64")]
        public const int TLS_MINIMUM_AVAILABLE = 64;

        [NativeTypeName("#define THREAD_DYNAMIC_CODE_ALLOW 1")]
        public const int THREAD_DYNAMIC_CODE_ALLOW = 1;

        [NativeTypeName("#define THREAD_BASE_PRIORITY_LOWRT 15")]
        public const int THREAD_BASE_PRIORITY_LOWRT = 15;

        [NativeTypeName("#define THREAD_BASE_PRIORITY_MAX 2")]
        public const int THREAD_BASE_PRIORITY_MAX = 2;

        [NativeTypeName("#define THREAD_BASE_PRIORITY_MIN (-2)")]
        public const int THREAD_BASE_PRIORITY_MIN = (-2);

        [NativeTypeName("#define THREAD_BASE_PRIORITY_IDLE (-15)")]
        public const int THREAD_BASE_PRIORITY_IDLE = (-15);

        [NativeTypeName("#define COMPONENT_KTM 0x01")]
        public const int COMPONENT_KTM = 0x01;

        [NativeTypeName("#define COMPONENT_VALID_FLAGS (COMPONENT_KTM)")]
        public const int COMPONENT_VALID_FLAGS = (0x01);

        [NativeTypeName("#define MEMORY_PRIORITY_LOWEST 0")]
        public const int MEMORY_PRIORITY_LOWEST = 0;

        [NativeTypeName("#define MEMORY_PRIORITY_VERY_LOW 1")]
        public const int MEMORY_PRIORITY_VERY_LOW = 1;

        [NativeTypeName("#define MEMORY_PRIORITY_LOW 2")]
        public const int MEMORY_PRIORITY_LOW = 2;

        [NativeTypeName("#define MEMORY_PRIORITY_MEDIUM 3")]
        public const int MEMORY_PRIORITY_MEDIUM = 3;

        [NativeTypeName("#define MEMORY_PRIORITY_BELOW_NORMAL 4")]
        public const int MEMORY_PRIORITY_BELOW_NORMAL = 4;

        [NativeTypeName("#define MEMORY_PRIORITY_NORMAL 5")]
        public const int MEMORY_PRIORITY_NORMAL = 5;

        [NativeTypeName("#define DYNAMIC_EH_CONTINUATION_TARGET_ADD (0x00000001)")]
        public const int DYNAMIC_EH_CONTINUATION_TARGET_ADD = (0x00000001);

        [NativeTypeName("#define DYNAMIC_EH_CONTINUATION_TARGET_PROCESSED (0x00000002)")]
        public const int DYNAMIC_EH_CONTINUATION_TARGET_PROCESSED = (0x00000002);

        [NativeTypeName("#define DYNAMIC_ENFORCED_ADDRESS_RANGE_ADD (0x00000001)")]
        public const int DYNAMIC_ENFORCED_ADDRESS_RANGE_ADD = (0x00000001);

        [NativeTypeName("#define DYNAMIC_ENFORCED_ADDRESS_RANGE_PROCESSED (0x00000002)")]
        public const int DYNAMIC_ENFORCED_ADDRESS_RANGE_PROCESSED = (0x00000002);

        [NativeTypeName("#define QUOTA_LIMITS_HARDWS_MIN_ENABLE 0x00000001")]
        public const int QUOTA_LIMITS_HARDWS_MIN_ENABLE = 0x00000001;

        [NativeTypeName("#define QUOTA_LIMITS_HARDWS_MIN_DISABLE 0x00000002")]
        public const int QUOTA_LIMITS_HARDWS_MIN_DISABLE = 0x00000002;

        [NativeTypeName("#define QUOTA_LIMITS_HARDWS_MAX_ENABLE 0x00000004")]
        public const int QUOTA_LIMITS_HARDWS_MAX_ENABLE = 0x00000004;

        [NativeTypeName("#define QUOTA_LIMITS_HARDWS_MAX_DISABLE 0x00000008")]
        public const int QUOTA_LIMITS_HARDWS_MAX_DISABLE = 0x00000008;

        [NativeTypeName("#define QUOTA_LIMITS_USE_DEFAULT_LIMITS 0x00000010")]
        public const int QUOTA_LIMITS_USE_DEFAULT_LIMITS = 0x00000010;

        [NativeTypeName("#define THREAD_PROFILING_FLAG_DISPATCH 0x00000001")]
        public const int THREAD_PROFILING_FLAG_DISPATCH = 0x00000001;

        [NativeTypeName("#define MEMORY_PARTITION_QUERY_ACCESS 0x0001")]
        public const int MEMORY_PARTITION_QUERY_ACCESS = 0x0001;

        [NativeTypeName("#define MEMORY_PARTITION_MODIFY_ACCESS 0x0002")]
        public const int MEMORY_PARTITION_MODIFY_ACCESS = 0x0002;

        [NativeTypeName("#define MEMORY_PARTITION_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED |      \\\r\n                                     SYNCHRONIZE |                   \\\r\n                                     MEMORY_PARTITION_QUERY_ACCESS | \\\r\n                                     MEMORY_PARTITION_MODIFY_ACCESS)")]
        public const int MEMORY_PARTITION_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0x0001 | 0x0002);

        [NativeTypeName("#define MUTANT_QUERY_STATE 0x0001")]
        public const int MUTANT_QUERY_STATE = 0x0001;

        [NativeTypeName("#define MUTANT_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED|SYNCHRONIZE|\\\r\n                          MUTANT_QUERY_STATE)")]
        public const int MUTANT_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0x0001);

        [NativeTypeName("#define SEMAPHORE_MODIFY_STATE 0x0002")]
        public const int SEMAPHORE_MODIFY_STATE = 0x0002;

        [NativeTypeName("#define SEMAPHORE_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED|SYNCHRONIZE|0x3)")]
        public const int SEMAPHORE_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0x3);

        [NativeTypeName("#define TIMER_QUERY_STATE 0x0001")]
        public const int TIMER_QUERY_STATE = 0x0001;

        [NativeTypeName("#define TIMER_MODIFY_STATE 0x0002")]
        public const int TIMER_MODIFY_STATE = 0x0002;

        [NativeTypeName("#define TIMER_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED|SYNCHRONIZE|\\\r\n                          TIMER_QUERY_STATE|TIMER_MODIFY_STATE)")]
        public const int TIMER_ALL_ACCESS = ((0x000F0000) | (0x00100000) | 0x0001 | 0x0002);

        [NativeTypeName("#define TIME_ZONE_ID_UNKNOWN 0")]
        public const int TIME_ZONE_ID_UNKNOWN = 0;

        [NativeTypeName("#define TIME_ZONE_ID_STANDARD 1")]
        public const int TIME_ZONE_ID_STANDARD = 1;

        [NativeTypeName("#define TIME_ZONE_ID_DAYLIGHT 2")]
        public const int TIME_ZONE_ID_DAYLIGHT = 2;

        [NativeTypeName("#define LTP_PC_SMT 0x1")]
        public const int LTP_PC_SMT = 0x1;

        [NativeTypeName("#define CACHE_FULLY_ASSOCIATIVE 0xFF")]
        public const int CACHE_FULLY_ASSOCIATIVE = 0xFF;

        [NativeTypeName("#define SYSTEM_CPU_SET_INFORMATION_PARKED 0x1")]
        public const int SYSTEM_CPU_SET_INFORMATION_PARKED = 0x1;

        [NativeTypeName("#define SYSTEM_CPU_SET_INFORMATION_ALLOCATED 0x2")]
        public const int SYSTEM_CPU_SET_INFORMATION_ALLOCATED = 0x2;

        [NativeTypeName("#define SYSTEM_CPU_SET_INFORMATION_ALLOCATED_TO_TARGET_PROCESS 0x4")]
        public const int SYSTEM_CPU_SET_INFORMATION_ALLOCATED_TO_TARGET_PROCESS = 0x4;

        [NativeTypeName("#define SYSTEM_CPU_SET_INFORMATION_REALTIME 0x8")]
        public const int SYSTEM_CPU_SET_INFORMATION_REALTIME = 0x8;

        [NativeTypeName("#define PF_FLOATING_POINT_PRECISION_ERRATA 0")]
        public const int PF_FLOATING_POINT_PRECISION_ERRATA = 0;

        [NativeTypeName("#define PF_FLOATING_POINT_EMULATED 1")]
        public const int PF_FLOATING_POINT_EMULATED = 1;

        [NativeTypeName("#define PF_COMPARE_EXCHANGE_DOUBLE 2")]
        public const int PF_COMPARE_EXCHANGE_DOUBLE = 2;

        [NativeTypeName("#define PF_MMX_INSTRUCTIONS_AVAILABLE 3")]
        public const int PF_MMX_INSTRUCTIONS_AVAILABLE = 3;

        [NativeTypeName("#define PF_PPC_MOVEMEM_64BIT_OK 4")]
        public const int PF_PPC_MOVEMEM_64BIT_OK = 4;

        [NativeTypeName("#define PF_ALPHA_BYTE_INSTRUCTIONS 5")]
        public const int PF_ALPHA_BYTE_INSTRUCTIONS = 5;

        [NativeTypeName("#define PF_XMMI_INSTRUCTIONS_AVAILABLE 6")]
        public const int PF_XMMI_INSTRUCTIONS_AVAILABLE = 6;

        [NativeTypeName("#define PF_3DNOW_INSTRUCTIONS_AVAILABLE 7")]
        public const int PF_3DNOW_INSTRUCTIONS_AVAILABLE = 7;

        [NativeTypeName("#define PF_RDTSC_INSTRUCTION_AVAILABLE 8")]
        public const int PF_RDTSC_INSTRUCTION_AVAILABLE = 8;

        [NativeTypeName("#define PF_PAE_ENABLED 9")]
        public const int PF_PAE_ENABLED = 9;

        [NativeTypeName("#define PF_XMMI64_INSTRUCTIONS_AVAILABLE 10")]
        public const int PF_XMMI64_INSTRUCTIONS_AVAILABLE = 10;

        [NativeTypeName("#define PF_SSE_DAZ_MODE_AVAILABLE 11")]
        public const int PF_SSE_DAZ_MODE_AVAILABLE = 11;

        [NativeTypeName("#define PF_NX_ENABLED 12")]
        public const int PF_NX_ENABLED = 12;

        [NativeTypeName("#define PF_SSE3_INSTRUCTIONS_AVAILABLE 13")]
        public const int PF_SSE3_INSTRUCTIONS_AVAILABLE = 13;

        [NativeTypeName("#define PF_COMPARE_EXCHANGE128 14")]
        public const int PF_COMPARE_EXCHANGE128 = 14;

        [NativeTypeName("#define PF_COMPARE64_EXCHANGE128 15")]
        public const int PF_COMPARE64_EXCHANGE128 = 15;

        [NativeTypeName("#define PF_CHANNELS_ENABLED 16")]
        public const int PF_CHANNELS_ENABLED = 16;

        [NativeTypeName("#define PF_XSAVE_ENABLED 17")]
        public const int PF_XSAVE_ENABLED = 17;

        [NativeTypeName("#define PF_ARM_VFP_32_REGISTERS_AVAILABLE 18")]
        public const int PF_ARM_VFP_32_REGISTERS_AVAILABLE = 18;

        [NativeTypeName("#define PF_ARM_NEON_INSTRUCTIONS_AVAILABLE 19")]
        public const int PF_ARM_NEON_INSTRUCTIONS_AVAILABLE = 19;

        [NativeTypeName("#define PF_SECOND_LEVEL_ADDRESS_TRANSLATION 20")]
        public const int PF_SECOND_LEVEL_ADDRESS_TRANSLATION = 20;

        [NativeTypeName("#define PF_VIRT_FIRMWARE_ENABLED 21")]
        public const int PF_VIRT_FIRMWARE_ENABLED = 21;

        [NativeTypeName("#define PF_RDWRFSGSBASE_AVAILABLE 22")]
        public const int PF_RDWRFSGSBASE_AVAILABLE = 22;

        [NativeTypeName("#define PF_FASTFAIL_AVAILABLE 23")]
        public const int PF_FASTFAIL_AVAILABLE = 23;

        [NativeTypeName("#define PF_ARM_DIVIDE_INSTRUCTION_AVAILABLE 24")]
        public const int PF_ARM_DIVIDE_INSTRUCTION_AVAILABLE = 24;

        [NativeTypeName("#define PF_ARM_64BIT_LOADSTORE_ATOMIC 25")]
        public const int PF_ARM_64BIT_LOADSTORE_ATOMIC = 25;

        [NativeTypeName("#define PF_ARM_EXTERNAL_CACHE_AVAILABLE 26")]
        public const int PF_ARM_EXTERNAL_CACHE_AVAILABLE = 26;

        [NativeTypeName("#define PF_ARM_FMAC_INSTRUCTIONS_AVAILABLE 27")]
        public const int PF_ARM_FMAC_INSTRUCTIONS_AVAILABLE = 27;

        [NativeTypeName("#define PF_RDRAND_INSTRUCTION_AVAILABLE 28")]
        public const int PF_RDRAND_INSTRUCTION_AVAILABLE = 28;

        [NativeTypeName("#define PF_ARM_V8_INSTRUCTIONS_AVAILABLE 29")]
        public const int PF_ARM_V8_INSTRUCTIONS_AVAILABLE = 29;

        [NativeTypeName("#define PF_ARM_V8_CRYPTO_INSTRUCTIONS_AVAILABLE 30")]
        public const int PF_ARM_V8_CRYPTO_INSTRUCTIONS_AVAILABLE = 30;

        [NativeTypeName("#define PF_ARM_V8_CRC32_INSTRUCTIONS_AVAILABLE 31")]
        public const int PF_ARM_V8_CRC32_INSTRUCTIONS_AVAILABLE = 31;

        [NativeTypeName("#define PF_RDTSCP_INSTRUCTION_AVAILABLE 32")]
        public const int PF_RDTSCP_INSTRUCTION_AVAILABLE = 32;

        [NativeTypeName("#define PF_RDPID_INSTRUCTION_AVAILABLE 33")]
        public const int PF_RDPID_INSTRUCTION_AVAILABLE = 33;

        [NativeTypeName("#define PF_ARM_V81_ATOMIC_INSTRUCTIONS_AVAILABLE 34")]
        public const int PF_ARM_V81_ATOMIC_INSTRUCTIONS_AVAILABLE = 34;

        [NativeTypeName("#define PF_MONITORX_INSTRUCTION_AVAILABLE 35")]
        public const int PF_MONITORX_INSTRUCTION_AVAILABLE = 35;

        [NativeTypeName("#define PF_SSSE3_INSTRUCTIONS_AVAILABLE 36")]
        public const int PF_SSSE3_INSTRUCTIONS_AVAILABLE = 36;

        [NativeTypeName("#define PF_SSE4_1_INSTRUCTIONS_AVAILABLE 37")]
        public const int PF_SSE4_1_INSTRUCTIONS_AVAILABLE = 37;

        [NativeTypeName("#define PF_SSE4_2_INSTRUCTIONS_AVAILABLE 38")]
        public const int PF_SSE4_2_INSTRUCTIONS_AVAILABLE = 38;

        [NativeTypeName("#define PF_AVX_INSTRUCTIONS_AVAILABLE 39")]
        public const int PF_AVX_INSTRUCTIONS_AVAILABLE = 39;

        [NativeTypeName("#define PF_AVX2_INSTRUCTIONS_AVAILABLE 40")]
        public const int PF_AVX2_INSTRUCTIONS_AVAILABLE = 40;

        [NativeTypeName("#define PF_AVX512F_INSTRUCTIONS_AVAILABLE 41")]
        public const int PF_AVX512F_INSTRUCTIONS_AVAILABLE = 41;

        [NativeTypeName("#define PF_ERMS_AVAILABLE 42")]
        public const int PF_ERMS_AVAILABLE = 42;

        [NativeTypeName("#define PF_ARM_V82_DP_INSTRUCTIONS_AVAILABLE 43")]
        public const int PF_ARM_V82_DP_INSTRUCTIONS_AVAILABLE = 43;

        [NativeTypeName("#define PF_ARM_V83_JSCVT_INSTRUCTIONS_AVAILABLE 44")]
        public const int PF_ARM_V83_JSCVT_INSTRUCTIONS_AVAILABLE = 44;

        [NativeTypeName("#define XSTATE_LEGACY_FLOATING_POINT (0)")]
        public const int XSTATE_LEGACY_FLOATING_POINT = (0);

        [NativeTypeName("#define XSTATE_LEGACY_SSE (1)")]
        public const int XSTATE_LEGACY_SSE = (1);

        [NativeTypeName("#define XSTATE_GSSE (2)")]
        public const int XSTATE_GSSE = (2);

        [NativeTypeName("#define XSTATE_AVX (XSTATE_GSSE)")]
        public const int XSTATE_AVX = ((2));

        [NativeTypeName("#define XSTATE_MPX_BNDREGS (3)")]
        public const int XSTATE_MPX_BNDREGS = (3);

        [NativeTypeName("#define XSTATE_MPX_BNDCSR (4)")]
        public const int XSTATE_MPX_BNDCSR = (4);

        [NativeTypeName("#define XSTATE_AVX512_KMASK (5)")]
        public const int XSTATE_AVX512_KMASK = (5);

        [NativeTypeName("#define XSTATE_AVX512_ZMM_H (6)")]
        public const int XSTATE_AVX512_ZMM_H = (6);

        [NativeTypeName("#define XSTATE_AVX512_ZMM (7)")]
        public const int XSTATE_AVX512_ZMM = (7);

        [NativeTypeName("#define XSTATE_IPT (8)")]
        public const int XSTATE_IPT = (8);

        [NativeTypeName("#define XSTATE_CET_U (11)")]
        public const int XSTATE_CET_U = (11);

        [NativeTypeName("#define XSTATE_CET_S (12)")]
        public const int XSTATE_CET_S = (12);

        [NativeTypeName("#define XSTATE_AMX_TILE_CONFIG (17)")]
        public const int XSTATE_AMX_TILE_CONFIG = (17);

        [NativeTypeName("#define XSTATE_AMX_TILE_DATA (18)")]
        public const int XSTATE_AMX_TILE_DATA = (18);

        [NativeTypeName("#define XSTATE_LWP (62)")]
        public const int XSTATE_LWP = (62);

        [NativeTypeName("#define MAXIMUM_XSTATE_FEATURES (64)")]
        public const int MAXIMUM_XSTATE_FEATURES = (64);

        [NativeTypeName("#define XSTATE_MASK_LEGACY_FLOATING_POINT (1ui64 << (XSTATE_LEGACY_FLOATING_POINT))")]
        public const ulong XSTATE_MASK_LEGACY_FLOATING_POINT = (1UL << ((0)));

        [NativeTypeName("#define XSTATE_MASK_LEGACY_SSE (1ui64 << (XSTATE_LEGACY_SSE))")]
        public const ulong XSTATE_MASK_LEGACY_SSE = (1UL << ((1)));

        [NativeTypeName("#define XSTATE_MASK_LEGACY (XSTATE_MASK_LEGACY_FLOATING_POINT | \\\r\n                                             XSTATE_MASK_LEGACY_SSE)")]
        public const ulong XSTATE_MASK_LEGACY = ((1UL << ((0))) | (1UL << ((1))));

        [NativeTypeName("#define XSTATE_MASK_GSSE (1ui64 << (XSTATE_GSSE))")]
        public const ulong XSTATE_MASK_GSSE = (1UL << ((2)));

        [NativeTypeName("#define XSTATE_MASK_AVX (XSTATE_MASK_GSSE)")]
        public const ulong XSTATE_MASK_AVX = ((1UL << ((2))));

        [NativeTypeName("#define XSTATE_MASK_MPX ((1ui64 << (XSTATE_MPX_BNDREGS)) | \\\r\n                                             (1ui64 << (XSTATE_MPX_BNDCSR)))")]
        public const ulong XSTATE_MASK_MPX = ((1UL << ((3))) | (1UL << ((4))));

        [NativeTypeName("#define XSTATE_MASK_AVX512 ((1ui64 << (XSTATE_AVX512_KMASK)) | \\\r\n                                             (1ui64 << (XSTATE_AVX512_ZMM_H)) | \\\r\n                                             (1ui64 << (XSTATE_AVX512_ZMM)))")]
        public const ulong XSTATE_MASK_AVX512 = ((1UL << ((5))) | (1UL << ((6))) | (1UL << ((7))));

        [NativeTypeName("#define XSTATE_MASK_IPT (1ui64 << (XSTATE_IPT))")]
        public const ulong XSTATE_MASK_IPT = (1UL << ((8)));

        [NativeTypeName("#define XSTATE_MASK_CET_U (1ui64 << (XSTATE_CET_U))")]
        public const ulong XSTATE_MASK_CET_U = (1UL << ((11)));

        [NativeTypeName("#define XSTATE_MASK_CET_S (1ui64 << (XSTATE_CET_S))")]
        public const ulong XSTATE_MASK_CET_S = (1UL << ((12)));

        [NativeTypeName("#define XSTATE_MASK_AMX_TILE_CONFIG (1ui64 << (XSTATE_AMX_TILE_CONFIG))")]
        public const ulong XSTATE_MASK_AMX_TILE_CONFIG = (1UL << ((17)));

        [NativeTypeName("#define XSTATE_MASK_AMX_TILE_DATA (1ui64 << (XSTATE_AMX_TILE_DATA))")]
        public const ulong XSTATE_MASK_AMX_TILE_DATA = (1UL << ((18)));

        [NativeTypeName("#define XSTATE_MASK_LWP (1ui64 << (XSTATE_LWP))")]
        public const ulong XSTATE_MASK_LWP = (1UL << ((62)));

        [NativeTypeName("#define XSTATE_MASK_PERSISTENT ((1ui64 << (XSTATE_MPX_BNDCSR)) | \\\r\n                                             XSTATE_MASK_LWP)")]
        public const ulong XSTATE_MASK_PERSISTENT = ((1UL << ((4))) | (1UL << ((62))));

        [NativeTypeName("#define XSTATE_MASK_USER_VISIBLE_SUPERVISOR (XSTATE_MASK_CET_U)")]
        public const ulong XSTATE_MASK_USER_VISIBLE_SUPERVISOR = ((1UL << ((11))));

        [NativeTypeName("#define XSTATE_MASK_LARGE_FEATURES (XSTATE_MASK_AMX_TILE_DATA)")]
        public const ulong XSTATE_MASK_LARGE_FEATURES = ((1UL << ((18))));

        [NativeTypeName("#define XSTATE_COMPACTION_ENABLE (63)")]
        public const int XSTATE_COMPACTION_ENABLE = (63);

        [NativeTypeName("#define XSTATE_COMPACTION_ENABLE_MASK (1ui64 << (XSTATE_COMPACTION_ENABLE))")]
        public const ulong XSTATE_COMPACTION_ENABLE_MASK = (1UL << ((63)));

        [NativeTypeName("#define XSTATE_ALIGN_BIT (1)")]
        public const int XSTATE_ALIGN_BIT = (1);

        [NativeTypeName("#define XSTATE_ALIGN_MASK (1ui64 << (XSTATE_ALIGN_BIT))")]
        public const ulong XSTATE_ALIGN_MASK = (1UL << ((1)));

        [NativeTypeName("#define XSTATE_XFD_BIT (2)")]
        public const int XSTATE_XFD_BIT = (2);

        [NativeTypeName("#define XSTATE_XFD_MASK (1ui64 << (XSTATE_XFD_BIT))")]
        public const ulong XSTATE_XFD_MASK = (1UL << ((2)));

        [NativeTypeName("#define XSTATE_CONTROLFLAG_XSAVEOPT_MASK (1)")]
        public const int XSTATE_CONTROLFLAG_XSAVEOPT_MASK = (1);

        [NativeTypeName("#define XSTATE_CONTROLFLAG_XSAVEC_MASK (2)")]
        public const int XSTATE_CONTROLFLAG_XSAVEC_MASK = (2);

        [NativeTypeName("#define XSTATE_CONTROLFLAG_XFD_MASK (4)")]
        public const int XSTATE_CONTROLFLAG_XFD_MASK = (4);

        [NativeTypeName("#define XSTATE_CONTROLFLAG_VALID_MASK (XSTATE_CONTROLFLAG_XSAVEOPT_MASK | \\\r\n                                             XSTATE_CONTROLFLAG_XSAVEC_MASK | \\\r\n                                             XSTATE_CONTROLFLAG_XFD_MASK)")]
        public const int XSTATE_CONTROLFLAG_VALID_MASK = ((1) | (2) | (4));

        [NativeTypeName("#define CFG_CALL_TARGET_VALID (0x00000001)")]
        public const int CFG_CALL_TARGET_VALID = (0x00000001);

        [NativeTypeName("#define CFG_CALL_TARGET_PROCESSED (0x00000002)")]
        public const int CFG_CALL_TARGET_PROCESSED = (0x00000002);

        [NativeTypeName("#define CFG_CALL_TARGET_CONVERT_EXPORT_SUPPRESSED_TO_VALID (0x00000004)")]
        public const int CFG_CALL_TARGET_CONVERT_EXPORT_SUPPRESSED_TO_VALID = (0x00000004);

        [NativeTypeName("#define CFG_CALL_TARGET_VALID_XFG (0x00000008)")]
        public const int CFG_CALL_TARGET_VALID_XFG = (0x00000008);

        [NativeTypeName("#define CFG_CALL_TARGET_CONVERT_XFG_TO_CFG (0x00000010)")]
        public const int CFG_CALL_TARGET_CONVERT_XFG_TO_CFG = (0x00000010);

        [NativeTypeName("#define SECTION_QUERY 0x0001")]
        public const int SECTION_QUERY = 0x0001;

        [NativeTypeName("#define SECTION_MAP_WRITE 0x0002")]
        public const int SECTION_MAP_WRITE = 0x0002;

        [NativeTypeName("#define SECTION_MAP_READ 0x0004")]
        public const int SECTION_MAP_READ = 0x0004;

        [NativeTypeName("#define SECTION_MAP_EXECUTE 0x0008")]
        public const int SECTION_MAP_EXECUTE = 0x0008;

        [NativeTypeName("#define SECTION_EXTEND_SIZE 0x0010")]
        public const int SECTION_EXTEND_SIZE = 0x0010;

        [NativeTypeName("#define SECTION_MAP_EXECUTE_EXPLICIT 0x0020")]
        public const int SECTION_MAP_EXECUTE_EXPLICIT = 0x0020;

        [NativeTypeName("#define SECTION_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED|SECTION_QUERY|\\\r\n                            SECTION_MAP_WRITE |      \\\r\n                            SECTION_MAP_READ |       \\\r\n                            SECTION_MAP_EXECUTE |    \\\r\n                            SECTION_EXTEND_SIZE)")]
        public const int SECTION_ALL_ACCESS = ((0x000F0000) | 0x0001 | 0x0002 | 0x0004 | 0x0008 | 0x0010);

        [NativeTypeName("#define SESSION_QUERY_ACCESS 0x0001")]
        public const int SESSION_QUERY_ACCESS = 0x0001;

        [NativeTypeName("#define SESSION_MODIFY_ACCESS 0x0002")]
        public const int SESSION_MODIFY_ACCESS = 0x0002;

        [NativeTypeName("#define SESSION_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED |  \\\r\n                            SESSION_QUERY_ACCESS |             \\\r\n                            SESSION_MODIFY_ACCESS)")]
        public const int SESSION_ALL_ACCESS = ((0x000F0000) | 0x0001 | 0x0002);

        [NativeTypeName("#define PAGE_NOACCESS 0x01")]
        public const int PAGE_NOACCESS = 0x01;

        [NativeTypeName("#define PAGE_READONLY 0x02")]
        public const int PAGE_READONLY = 0x02;

        [NativeTypeName("#define PAGE_READWRITE 0x04")]
        public const int PAGE_READWRITE = 0x04;

        [NativeTypeName("#define PAGE_WRITECOPY 0x08")]
        public const int PAGE_WRITECOPY = 0x08;

        [NativeTypeName("#define PAGE_EXECUTE 0x10")]
        public const int PAGE_EXECUTE = 0x10;

        [NativeTypeName("#define PAGE_EXECUTE_READ 0x20")]
        public const int PAGE_EXECUTE_READ = 0x20;

        [NativeTypeName("#define PAGE_EXECUTE_READWRITE 0x40")]
        public const int PAGE_EXECUTE_READWRITE = 0x40;

        [NativeTypeName("#define PAGE_EXECUTE_WRITECOPY 0x80")]
        public const int PAGE_EXECUTE_WRITECOPY = 0x80;

        [NativeTypeName("#define PAGE_GUARD 0x100")]
        public const int PAGE_GUARD = 0x100;

        [NativeTypeName("#define PAGE_NOCACHE 0x200")]
        public const int PAGE_NOCACHE = 0x200;

        [NativeTypeName("#define PAGE_WRITECOMBINE 0x400")]
        public const int PAGE_WRITECOMBINE = 0x400;

        [NativeTypeName("#define PAGE_GRAPHICS_NOACCESS 0x0800")]
        public const int PAGE_GRAPHICS_NOACCESS = 0x0800;

        [NativeTypeName("#define PAGE_GRAPHICS_READONLY 0x1000")]
        public const int PAGE_GRAPHICS_READONLY = 0x1000;

        [NativeTypeName("#define PAGE_GRAPHICS_READWRITE 0x2000")]
        public const int PAGE_GRAPHICS_READWRITE = 0x2000;

        [NativeTypeName("#define PAGE_GRAPHICS_EXECUTE 0x4000")]
        public const int PAGE_GRAPHICS_EXECUTE = 0x4000;

        [NativeTypeName("#define PAGE_GRAPHICS_EXECUTE_READ 0x8000")]
        public const int PAGE_GRAPHICS_EXECUTE_READ = 0x8000;

        [NativeTypeName("#define PAGE_GRAPHICS_EXECUTE_READWRITE 0x10000")]
        public const int PAGE_GRAPHICS_EXECUTE_READWRITE = 0x10000;

        [NativeTypeName("#define PAGE_GRAPHICS_COHERENT 0x20000")]
        public const int PAGE_GRAPHICS_COHERENT = 0x20000;

        [NativeTypeName("#define PAGE_GRAPHICS_NOCACHE 0x40000")]
        public const int PAGE_GRAPHICS_NOCACHE = 0x40000;

        [NativeTypeName("#define PAGE_ENCLAVE_THREAD_CONTROL 0x80000000")]
        public const uint PAGE_ENCLAVE_THREAD_CONTROL = 0x80000000;

        [NativeTypeName("#define PAGE_REVERT_TO_FILE_MAP 0x80000000")]
        public const uint PAGE_REVERT_TO_FILE_MAP = 0x80000000;

        [NativeTypeName("#define PAGE_TARGETS_NO_UPDATE 0x40000000")]
        public const int PAGE_TARGETS_NO_UPDATE = 0x40000000;

        [NativeTypeName("#define PAGE_TARGETS_INVALID 0x40000000")]
        public const int PAGE_TARGETS_INVALID = 0x40000000;

        [NativeTypeName("#define PAGE_ENCLAVE_UNVALIDATED 0x20000000")]
        public const int PAGE_ENCLAVE_UNVALIDATED = 0x20000000;

        [NativeTypeName("#define PAGE_ENCLAVE_MASK 0x10000000")]
        public const int PAGE_ENCLAVE_MASK = 0x10000000;

        [NativeTypeName("#define PAGE_ENCLAVE_DECOMMIT (PAGE_ENCLAVE_MASK | 0)")]
        public const int PAGE_ENCLAVE_DECOMMIT = (0x10000000 | 0);

        [NativeTypeName("#define PAGE_ENCLAVE_SS_FIRST (PAGE_ENCLAVE_MASK | 1)")]
        public const int PAGE_ENCLAVE_SS_FIRST = (0x10000000 | 1);

        [NativeTypeName("#define PAGE_ENCLAVE_SS_REST (PAGE_ENCLAVE_MASK | 2)")]
        public const int PAGE_ENCLAVE_SS_REST = (0x10000000 | 2);

        [NativeTypeName("#define MEM_COMMIT 0x00001000")]
        public const int MEM_COMMIT = 0x00001000;

        [NativeTypeName("#define MEM_RESERVE 0x00002000")]
        public const int MEM_RESERVE = 0x00002000;

        [NativeTypeName("#define MEM_REPLACE_PLACEHOLDER 0x00004000")]
        public const int MEM_REPLACE_PLACEHOLDER = 0x00004000;

        [NativeTypeName("#define MEM_RESERVE_PLACEHOLDER 0x00040000")]
        public const int MEM_RESERVE_PLACEHOLDER = 0x00040000;

        [NativeTypeName("#define MEM_RESET 0x00080000")]
        public const int MEM_RESET = 0x00080000;

        [NativeTypeName("#define MEM_TOP_DOWN 0x00100000")]
        public const int MEM_TOP_DOWN = 0x00100000;

        [NativeTypeName("#define MEM_WRITE_WATCH 0x00200000")]
        public const int MEM_WRITE_WATCH = 0x00200000;

        [NativeTypeName("#define MEM_PHYSICAL 0x00400000")]
        public const int MEM_PHYSICAL = 0x00400000;

        [NativeTypeName("#define MEM_ROTATE 0x00800000")]
        public const int MEM_ROTATE = 0x00800000;

        [NativeTypeName("#define MEM_DIFFERENT_IMAGE_BASE_OK 0x00800000")]
        public const int MEM_DIFFERENT_IMAGE_BASE_OK = 0x00800000;

        [NativeTypeName("#define MEM_RESET_UNDO 0x01000000")]
        public const int MEM_RESET_UNDO = 0x01000000;

        [NativeTypeName("#define MEM_LARGE_PAGES 0x20000000")]
        public const int MEM_LARGE_PAGES = 0x20000000;

        [NativeTypeName("#define MEM_4MB_PAGES 0x80000000")]
        public const uint MEM_4MB_PAGES = 0x80000000;

        [NativeTypeName("#define MEM_64K_PAGES (MEM_LARGE_PAGES | MEM_PHYSICAL)")]
        public const int MEM_64K_PAGES = (0x20000000 | 0x00400000);

        [NativeTypeName("#define MEM_UNMAP_WITH_TRANSIENT_BOOST 0x00000001")]
        public const int MEM_UNMAP_WITH_TRANSIENT_BOOST = 0x00000001;

        [NativeTypeName("#define MEM_COALESCE_PLACEHOLDERS 0x00000001")]
        public const int MEM_COALESCE_PLACEHOLDERS = 0x00000001;

        [NativeTypeName("#define MEM_PRESERVE_PLACEHOLDER 0x00000002")]
        public const int MEM_PRESERVE_PLACEHOLDER = 0x00000002;

        [NativeTypeName("#define MEM_DECOMMIT 0x00004000")]
        public const int MEM_DECOMMIT = 0x00004000;

        [NativeTypeName("#define MEM_RELEASE 0x00008000")]
        public const int MEM_RELEASE = 0x00008000;

        [NativeTypeName("#define MEM_FREE 0x00010000")]
        public const int MEM_FREE = 0x00010000;

        [NativeTypeName("#define MEM_EXTENDED_PARAMETER_GRAPHICS 0x00000001")]
        public const int MEM_EXTENDED_PARAMETER_GRAPHICS = 0x00000001;

        [NativeTypeName("#define MEM_EXTENDED_PARAMETER_NONPAGED 0x00000002")]
        public const int MEM_EXTENDED_PARAMETER_NONPAGED = 0x00000002;

        [NativeTypeName("#define MEM_EXTENDED_PARAMETER_ZERO_PAGES_OPTIONAL 0x00000004")]
        public const int MEM_EXTENDED_PARAMETER_ZERO_PAGES_OPTIONAL = 0x00000004;

        [NativeTypeName("#define MEM_EXTENDED_PARAMETER_NONPAGED_LARGE 0x00000008")]
        public const int MEM_EXTENDED_PARAMETER_NONPAGED_LARGE = 0x00000008;

        [NativeTypeName("#define MEM_EXTENDED_PARAMETER_NONPAGED_HUGE 0x00000010")]
        public const int MEM_EXTENDED_PARAMETER_NONPAGED_HUGE = 0x00000010;

        [NativeTypeName("#define MEM_EXTENDED_PARAMETER_SOFT_FAULT_PAGES 0x00000020")]
        public const int MEM_EXTENDED_PARAMETER_SOFT_FAULT_PAGES = 0x00000020;

        [NativeTypeName("#define MEM_EXTENDED_PARAMETER_EC_CODE 0x00000040")]
        public const int MEM_EXTENDED_PARAMETER_EC_CODE = 0x00000040;

        [NativeTypeName("#define MEM_EXTENDED_PARAMETER_NUMA_NODE_MANDATORY MINLONG64")]
        public const long MEM_EXTENDED_PARAMETER_NUMA_NODE_MANDATORY = unchecked((long)(~((long)(((ulong)(~((ulong)(0)))) >> 1))));

        [NativeTypeName("#define MEM_EXTENDED_PARAMETER_TYPE_BITS 8")]
        public const int MEM_EXTENDED_PARAMETER_TYPE_BITS = 8;

        [NativeTypeName("#define MEM_DEDICATED_ATTRIBUTE_NOT_SPECIFIED ((DWORD64) -1)")]
        public const ulong MEM_DEDICATED_ATTRIBUTE_NOT_SPECIFIED = unchecked((ulong)(-1));

        [NativeTypeName("#define MEM_PRIVATE 0x00020000")]
        public const int MEM_PRIVATE = 0x00020000;

        [NativeTypeName("#define MEM_MAPPED 0x00040000")]
        public const int MEM_MAPPED = 0x00040000;

        [NativeTypeName("#define MEM_IMAGE 0x01000000")]
        public const int MEM_IMAGE = 0x01000000;

        [NativeTypeName("#define WRITE_WATCH_FLAG_RESET 0x01")]
        public const int WRITE_WATCH_FLAG_RESET = 0x01;

        [NativeTypeName("#define ENCLAVE_TYPE_SGX 0x00000001")]
        public const int ENCLAVE_TYPE_SGX = 0x00000001;

        [NativeTypeName("#define ENCLAVE_TYPE_SGX2 0x00000002")]
        public const int ENCLAVE_TYPE_SGX2 = 0x00000002;

        [NativeTypeName("#define ENCLAVE_TYPE_VBS 0x00000010")]
        public const int ENCLAVE_TYPE_VBS = 0x00000010;

        [NativeTypeName("#define ENCLAVE_VBS_FLAG_DEBUG 0x00000001")]
        public const int ENCLAVE_VBS_FLAG_DEBUG = 0x00000001;

        [NativeTypeName("#define ENCLAVE_TYPE_VBS_BASIC 0x00000011")]
        public const int ENCLAVE_TYPE_VBS_BASIC = 0x00000011;

        [NativeTypeName("#define VBS_BASIC_PAGE_MEASURED_DATA 0x00000001")]
        public const int VBS_BASIC_PAGE_MEASURED_DATA = 0x00000001;

        [NativeTypeName("#define VBS_BASIC_PAGE_UNMEASURED_DATA 0x00000002")]
        public const int VBS_BASIC_PAGE_UNMEASURED_DATA = 0x00000002;

        [NativeTypeName("#define VBS_BASIC_PAGE_ZERO_FILL 0x00000003")]
        public const int VBS_BASIC_PAGE_ZERO_FILL = 0x00000003;

        [NativeTypeName("#define VBS_BASIC_PAGE_THREAD_DESCRIPTOR 0x00000004")]
        public const int VBS_BASIC_PAGE_THREAD_DESCRIPTOR = 0x00000004;

        [NativeTypeName("#define VBS_BASIC_PAGE_SYSTEM_CALL 0x00000005")]
        public const int VBS_BASIC_PAGE_SYSTEM_CALL = 0x00000005;

        [NativeTypeName("#define DEDICATED_MEMORY_CACHE_ELIGIBLE 0x1")]
        public const int DEDICATED_MEMORY_CACHE_ELIGIBLE = 0x1;

        [NativeTypeName("#define TREE_CONNECT_ATTRIBUTE_PRIVACY 0x00004000")]
        public const int TREE_CONNECT_ATTRIBUTE_PRIVACY = 0x00004000;

        [NativeTypeName("#define TREE_CONNECT_ATTRIBUTE_INTEGRITY 0x00008000")]
        public const int TREE_CONNECT_ATTRIBUTE_INTEGRITY = 0x00008000;

        [NativeTypeName("#define TREE_CONNECT_ATTRIBUTE_GLOBAL 0x00000004")]
        public const int TREE_CONNECT_ATTRIBUTE_GLOBAL = 0x00000004;

        [NativeTypeName("#define TREE_CONNECT_ATTRIBUTE_PINNED 0x00000002")]
        public const int TREE_CONNECT_ATTRIBUTE_PINNED = 0x00000002;

        [NativeTypeName("#define MAILSLOT_NO_MESSAGE ((DWORD)-1)")]
        public const uint MAILSLOT_NO_MESSAGE = unchecked((uint)(-1));

        [NativeTypeName("#define MAILSLOT_WAIT_FOREVER ((DWORD)-1)")]
        public const uint MAILSLOT_WAIT_FOREVER = unchecked((uint)(-1));

        [NativeTypeName("#define FLUSH_FLAGS_FILE_DATA_ONLY 0x00000001")]
        public const int FLUSH_FLAGS_FILE_DATA_ONLY = 0x00000001;

        [NativeTypeName("#define FLUSH_FLAGS_NO_SYNC 0x00000002")]
        public const int FLUSH_FLAGS_NO_SYNC = 0x00000002;

        [NativeTypeName("#define FLUSH_FLAGS_FILE_DATA_SYNC_ONLY 0x00000004")]
        public const int FLUSH_FLAGS_FILE_DATA_SYNC_ONLY = 0x00000004;

        [NativeTypeName("#define MAXIMUM_REPARSE_DATA_BUFFER_SIZE ( 16 * 1024 )")]
        public const int MAXIMUM_REPARSE_DATA_BUFFER_SIZE = (16 * 1024);

        [NativeTypeName("#define SCRUB_DATA_INPUT_FLAG_RESUME 0x00000001")]
        public const int SCRUB_DATA_INPUT_FLAG_RESUME = 0x00000001;

        [NativeTypeName("#define SCRUB_DATA_INPUT_FLAG_SKIP_IN_SYNC 0x00000002")]
        public const int SCRUB_DATA_INPUT_FLAG_SKIP_IN_SYNC = 0x00000002;

        [NativeTypeName("#define SCRUB_DATA_INPUT_FLAG_SKIP_NON_INTEGRITY_DATA 0x00000004")]
        public const int SCRUB_DATA_INPUT_FLAG_SKIP_NON_INTEGRITY_DATA = 0x00000004;

        [NativeTypeName("#define SCRUB_DATA_INPUT_FLAG_IGNORE_REDUNDANCY 0x00000008")]
        public const int SCRUB_DATA_INPUT_FLAG_IGNORE_REDUNDANCY = 0x00000008;

        [NativeTypeName("#define SCRUB_DATA_INPUT_FLAG_SKIP_DATA 0x00000010")]
        public const int SCRUB_DATA_INPUT_FLAG_SKIP_DATA = 0x00000010;

        [NativeTypeName("#define SCRUB_DATA_INPUT_FLAG_SCRUB_BY_OBJECT_ID 0x00000020")]
        public const int SCRUB_DATA_INPUT_FLAG_SCRUB_BY_OBJECT_ID = 0x00000020;

        [NativeTypeName("#define SCRUB_DATA_INPUT_FLAG_OPLOCK_NOT_ACQUIRED 0x00000040")]
        public const int SCRUB_DATA_INPUT_FLAG_OPLOCK_NOT_ACQUIRED = 0x00000040;

        [NativeTypeName("#define SCRUB_DATA_OUTPUT_FLAG_INCOMPLETE 0x00000001")]
        public const int SCRUB_DATA_OUTPUT_FLAG_INCOMPLETE = 0x00000001;

        [NativeTypeName("#define SCRUB_DATA_OUTPUT_FLAG_NON_USER_DATA_RANGE 0x00010000")]
        public const int SCRUB_DATA_OUTPUT_FLAG_NON_USER_DATA_RANGE = 0x00010000;

        [NativeTypeName("#define SCRUB_DATA_OUTPUT_FLAG_PARITY_EXTENT_DATA_RETURNED 0x00020000")]
        public const int SCRUB_DATA_OUTPUT_FLAG_PARITY_EXTENT_DATA_RETURNED = 0x00020000;

        [NativeTypeName("#define SCRUB_DATA_OUTPUT_FLAG_RESUME_CONTEXT_LENGTH_SPECIFIED 0x00040000")]
        public const int SCRUB_DATA_OUTPUT_FLAG_RESUME_CONTEXT_LENGTH_SPECIFIED = 0x00040000;

        [NativeTypeName("#define SHUFFLE_FILE_FLAG_SKIP_INITIALIZING_NEW_CLUSTERS (0x00000001)")]
        public const int SHUFFLE_FILE_FLAG_SKIP_INITIALIZING_NEW_CLUSTERS = (0x00000001);

        [NativeTypeName("#define SMB_CCF_APP_INSTANCE_EA_NAME \"ClusteredApplicationInstance\"")]
        public static ReadOnlySpan<byte> SMB_CCF_APP_INSTANCE_EA_NAME => new byte[] { 0x43, 0x6C, 0x75, 0x73, 0x74, 0x65, 0x72, 0x65, 0x64, 0x41, 0x70, 0x70, 0x6C, 0x69, 0x63, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x49, 0x6E, 0x73, 0x74, 0x61, 0x6E, 0x63, 0x65, 0x00 };

        [NativeTypeName("#define NETWORK_APP_INSTANCE_CSV_FLAGS_VALID_ONLY_IF_CSV_COORDINATOR 0x00000001")]
        public const int NETWORK_APP_INSTANCE_CSV_FLAGS_VALID_ONLY_IF_CSV_COORDINATOR = 0x00000001;

        [NativeTypeName("#define DUPLICATE_CLOSE_SOURCE 0x00000001")]
        public const int DUPLICATE_CLOSE_SOURCE = 0x00000001;

        [NativeTypeName("#define DUPLICATE_SAME_ACCESS 0x00000002")]
        public const int DUPLICATE_SAME_ACCESS = 0x00000002;

        [NativeTypeName("#define POWERBUTTON_ACTION_INDEX_NOTHING 0")]
        public const int POWERBUTTON_ACTION_INDEX_NOTHING = 0;

        [NativeTypeName("#define POWERBUTTON_ACTION_INDEX_SLEEP 1")]
        public const int POWERBUTTON_ACTION_INDEX_SLEEP = 1;

        [NativeTypeName("#define POWERBUTTON_ACTION_INDEX_HIBERNATE 2")]
        public const int POWERBUTTON_ACTION_INDEX_HIBERNATE = 2;

        [NativeTypeName("#define POWERBUTTON_ACTION_INDEX_SHUTDOWN 3")]
        public const int POWERBUTTON_ACTION_INDEX_SHUTDOWN = 3;

        [NativeTypeName("#define POWERBUTTON_ACTION_INDEX_TURN_OFF_THE_DISPLAY 4")]
        public const int POWERBUTTON_ACTION_INDEX_TURN_OFF_THE_DISPLAY = 4;

        [NativeTypeName("#define POWERBUTTON_ACTION_VALUE_NOTHING 0")]
        public const int POWERBUTTON_ACTION_VALUE_NOTHING = 0;

        [NativeTypeName("#define POWERBUTTON_ACTION_VALUE_SLEEP 2")]
        public const int POWERBUTTON_ACTION_VALUE_SLEEP = 2;

        [NativeTypeName("#define POWERBUTTON_ACTION_VALUE_HIBERNATE 3")]
        public const int POWERBUTTON_ACTION_VALUE_HIBERNATE = 3;

        [NativeTypeName("#define POWERBUTTON_ACTION_VALUE_SHUTDOWN 6")]
        public const int POWERBUTTON_ACTION_VALUE_SHUTDOWN = 6;

        [NativeTypeName("#define POWERBUTTON_ACTION_VALUE_TURN_OFF_THE_DISPLAY 8")]
        public const int POWERBUTTON_ACTION_VALUE_TURN_OFF_THE_DISPLAY = 8;

        [NativeTypeName("#define PERFSTATE_POLICY_CHANGE_IDEAL 0")]
        public const int PERFSTATE_POLICY_CHANGE_IDEAL = 0;

        [NativeTypeName("#define PERFSTATE_POLICY_CHANGE_SINGLE 1")]
        public const int PERFSTATE_POLICY_CHANGE_SINGLE = 1;

        [NativeTypeName("#define PERFSTATE_POLICY_CHANGE_ROCKET 2")]
        public const int PERFSTATE_POLICY_CHANGE_ROCKET = 2;

        [NativeTypeName("#define PERFSTATE_POLICY_CHANGE_IDEAL_AGGRESSIVE 3")]
        public const int PERFSTATE_POLICY_CHANGE_IDEAL_AGGRESSIVE = 3;

        [NativeTypeName("#define PERFSTATE_POLICY_CHANGE_DECREASE_MAX PERFSTATE_POLICY_CHANGE_ROCKET")]
        public const int PERFSTATE_POLICY_CHANGE_DECREASE_MAX = 2;

        [NativeTypeName("#define PERFSTATE_POLICY_CHANGE_INCREASE_MAX PERFSTATE_POLICY_CHANGE_IDEAL_AGGRESSIVE")]
        public const int PERFSTATE_POLICY_CHANGE_INCREASE_MAX = 3;

        [NativeTypeName("#define CORE_PARKING_POLICY_CHANGE_IDEAL 0")]
        public const int CORE_PARKING_POLICY_CHANGE_IDEAL = 0;

        [NativeTypeName("#define CORE_PARKING_POLICY_CHANGE_SINGLE 1")]
        public const int CORE_PARKING_POLICY_CHANGE_SINGLE = 1;

        [NativeTypeName("#define CORE_PARKING_POLICY_CHANGE_ROCKET 2")]
        public const int CORE_PARKING_POLICY_CHANGE_ROCKET = 2;

        [NativeTypeName("#define CORE_PARKING_POLICY_CHANGE_MULTISTEP 3")]
        public const int CORE_PARKING_POLICY_CHANGE_MULTISTEP = 3;

        [NativeTypeName("#define CORE_PARKING_POLICY_CHANGE_MAX CORE_PARKING_POLICY_CHANGE_MULTISTEP")]
        public const int CORE_PARKING_POLICY_CHANGE_MAX = 3;

        [NativeTypeName("#define POWER_DEVICE_IDLE_POLICY_PERFORMANCE 0")]
        public const int POWER_DEVICE_IDLE_POLICY_PERFORMANCE = 0;

        [NativeTypeName("#define POWER_DEVICE_IDLE_POLICY_CONSERVATIVE 1")]
        public const int POWER_DEVICE_IDLE_POLICY_CONSERVATIVE = 1;

        [NativeTypeName("#define POWER_CONNECTIVITY_IN_STANDBY_DISABLED 0")]
        public const int POWER_CONNECTIVITY_IN_STANDBY_DISABLED = 0;

        [NativeTypeName("#define POWER_CONNECTIVITY_IN_STANDBY_ENABLED 1")]
        public const int POWER_CONNECTIVITY_IN_STANDBY_ENABLED = 1;

        [NativeTypeName("#define POWER_CONNECTIVITY_IN_STANDBY_SYSTEM_MANAGED 2")]
        public const int POWER_CONNECTIVITY_IN_STANDBY_SYSTEM_MANAGED = 2;

        [NativeTypeName("#define POWER_DISCONNECTED_STANDBY_MODE_NORMAL 0")]
        public const int POWER_DISCONNECTED_STANDBY_MODE_NORMAL = 0;

        [NativeTypeName("#define POWER_DISCONNECTED_STANDBY_MODE_AGGRESSIVE 1")]
        public const int POWER_DISCONNECTED_STANDBY_MODE_AGGRESSIVE = 1;

        [NativeTypeName("#define POWER_SYSTEM_MAXIMUM 7")]
        public const int POWER_SYSTEM_MAXIMUM = 7;

        [NativeTypeName("#define ES_SYSTEM_REQUIRED ((DWORD)0x00000001)")]
        public const uint ES_SYSTEM_REQUIRED = ((uint)(0x00000001));

        [NativeTypeName("#define ES_DISPLAY_REQUIRED ((DWORD)0x00000002)")]
        public const uint ES_DISPLAY_REQUIRED = ((uint)(0x00000002));

        [NativeTypeName("#define ES_USER_PRESENT ((DWORD)0x00000004)")]
        public const uint ES_USER_PRESENT = ((uint)(0x00000004));

        [NativeTypeName("#define ES_AWAYMODE_REQUIRED ((DWORD)0x00000040)")]
        public const uint ES_AWAYMODE_REQUIRED = ((uint)(0x00000040));

        [NativeTypeName("#define ES_CONTINUOUS ((DWORD)0x80000000)")]
        public const uint ES_CONTINUOUS = ((uint)(0x80000000));

        [NativeTypeName("#define DIAGNOSTIC_REASON_VERSION 0")]
        public const int DIAGNOSTIC_REASON_VERSION = 0;

        [NativeTypeName("#define DIAGNOSTIC_REASON_SIMPLE_STRING 0x00000001")]
        public const int DIAGNOSTIC_REASON_SIMPLE_STRING = 0x00000001;

        [NativeTypeName("#define DIAGNOSTIC_REASON_DETAILED_STRING 0x00000002")]
        public const int DIAGNOSTIC_REASON_DETAILED_STRING = 0x00000002;

        [NativeTypeName("#define DIAGNOSTIC_REASON_NOT_SPECIFIED 0x80000000")]
        public const uint DIAGNOSTIC_REASON_NOT_SPECIFIED = 0x80000000;

        [NativeTypeName("#define DIAGNOSTIC_REASON_INVALID_FLAGS (~0x80000007)")]
        public const uint DIAGNOSTIC_REASON_INVALID_FLAGS = (~0x80000007);

        [NativeTypeName("#define POWER_REQUEST_CONTEXT_VERSION DIAGNOSTIC_REASON_VERSION")]
        public const int POWER_REQUEST_CONTEXT_VERSION = 0;

        [NativeTypeName("#define POWER_REQUEST_CONTEXT_SIMPLE_STRING DIAGNOSTIC_REASON_SIMPLE_STRING")]
        public const int POWER_REQUEST_CONTEXT_SIMPLE_STRING = 0x00000001;

        [NativeTypeName("#define POWER_REQUEST_CONTEXT_DETAILED_STRING DIAGNOSTIC_REASON_DETAILED_STRING")]
        public const int POWER_REQUEST_CONTEXT_DETAILED_STRING = 0x00000002;

        [NativeTypeName("#define PDCAP_D0_SUPPORTED 0x00000001")]
        public const int PDCAP_D0_SUPPORTED = 0x00000001;

        [NativeTypeName("#define PDCAP_D1_SUPPORTED 0x00000002")]
        public const int PDCAP_D1_SUPPORTED = 0x00000002;

        [NativeTypeName("#define PDCAP_D2_SUPPORTED 0x00000004")]
        public const int PDCAP_D2_SUPPORTED = 0x00000004;

        [NativeTypeName("#define PDCAP_D3_SUPPORTED 0x00000008")]
        public const int PDCAP_D3_SUPPORTED = 0x00000008;

        [NativeTypeName("#define PDCAP_WAKE_FROM_D0_SUPPORTED 0x00000010")]
        public const int PDCAP_WAKE_FROM_D0_SUPPORTED = 0x00000010;

        [NativeTypeName("#define PDCAP_WAKE_FROM_D1_SUPPORTED 0x00000020")]
        public const int PDCAP_WAKE_FROM_D1_SUPPORTED = 0x00000020;

        [NativeTypeName("#define PDCAP_WAKE_FROM_D2_SUPPORTED 0x00000040")]
        public const int PDCAP_WAKE_FROM_D2_SUPPORTED = 0x00000040;

        [NativeTypeName("#define PDCAP_WAKE_FROM_D3_SUPPORTED 0x00000080")]
        public const int PDCAP_WAKE_FROM_D3_SUPPORTED = 0x00000080;

        [NativeTypeName("#define PDCAP_WARM_EJECT_SUPPORTED 0x00000100")]
        public const int PDCAP_WARM_EJECT_SUPPORTED = 0x00000100;

        [NativeTypeName("#define POWER_SETTING_VALUE_VERSION (0x1)")]
        public const int POWER_SETTING_VALUE_VERSION = (0x1);

        [NativeTypeName("#define POWER_PLATFORM_ROLE_V1 (0x00000001)")]
        public const int POWER_PLATFORM_ROLE_V1 = (0x00000001);

        [NativeTypeName("#define POWER_PLATFORM_ROLE_V1_MAX (PlatformRolePerformanceServer + 1)")]
        public const int POWER_PLATFORM_ROLE_V1_MAX = ((int)(PlatformRolePerformanceServer) + 1);

        [NativeTypeName("#define POWER_PLATFORM_ROLE_V2 (0x00000002)")]
        public const int POWER_PLATFORM_ROLE_V2 = (0x00000002);

        [NativeTypeName("#define POWER_PLATFORM_ROLE_V2_MAX (PlatformRoleSlate + 1)")]
        public const int POWER_PLATFORM_ROLE_V2_MAX = ((int)(PlatformRoleSlate) + 1);

        [NativeTypeName("#define POWER_PLATFORM_ROLE_VERSION POWER_PLATFORM_ROLE_V2")]
        public const int POWER_PLATFORM_ROLE_VERSION = (0x00000002);

        [NativeTypeName("#define POWER_PLATFORM_ROLE_VERSION_MAX POWER_PLATFORM_ROLE_V2_MAX")]
        public const int POWER_PLATFORM_ROLE_VERSION_MAX = ((int)(PlatformRoleSlate) + 1);

        [NativeTypeName("#define PROC_IDLE_BUCKET_COUNT 6")]
        public const int PROC_IDLE_BUCKET_COUNT = 6;

        [NativeTypeName("#define PROC_IDLE_BUCKET_COUNT_EX 16")]
        public const int PROC_IDLE_BUCKET_COUNT_EX = 16;

        [NativeTypeName("#define ACPI_PPM_SOFTWARE_ALL 0xFC")]
        public const int ACPI_PPM_SOFTWARE_ALL = 0xFC;

        [NativeTypeName("#define ACPI_PPM_SOFTWARE_ANY 0xFD")]
        public const int ACPI_PPM_SOFTWARE_ANY = 0xFD;

        [NativeTypeName("#define ACPI_PPM_HARDWARE_ALL 0xFE")]
        public const int ACPI_PPM_HARDWARE_ALL = 0xFE;

        [NativeTypeName("#define MS_PPM_SOFTWARE_ALL 0x1")]
        public const int MS_PPM_SOFTWARE_ALL = 0x1;

        [NativeTypeName("#define PPM_FIRMWARE_ACPI1C2 0x00000001")]
        public const int PPM_FIRMWARE_ACPI1C2 = 0x00000001;

        [NativeTypeName("#define PPM_FIRMWARE_ACPI1C3 0x00000002")]
        public const int PPM_FIRMWARE_ACPI1C3 = 0x00000002;

        [NativeTypeName("#define PPM_FIRMWARE_ACPI1TSTATES 0x00000004")]
        public const int PPM_FIRMWARE_ACPI1TSTATES = 0x00000004;

        [NativeTypeName("#define PPM_FIRMWARE_CST 0x00000008")]
        public const int PPM_FIRMWARE_CST = 0x00000008;

        [NativeTypeName("#define PPM_FIRMWARE_CSD 0x00000010")]
        public const int PPM_FIRMWARE_CSD = 0x00000010;

        [NativeTypeName("#define PPM_FIRMWARE_PCT 0x00000020")]
        public const int PPM_FIRMWARE_PCT = 0x00000020;

        [NativeTypeName("#define PPM_FIRMWARE_PSS 0x00000040")]
        public const int PPM_FIRMWARE_PSS = 0x00000040;

        [NativeTypeName("#define PPM_FIRMWARE_XPSS 0x00000080")]
        public const int PPM_FIRMWARE_XPSS = 0x00000080;

        [NativeTypeName("#define PPM_FIRMWARE_PPC 0x00000100")]
        public const int PPM_FIRMWARE_PPC = 0x00000100;

        [NativeTypeName("#define PPM_FIRMWARE_PSD 0x00000200")]
        public const int PPM_FIRMWARE_PSD = 0x00000200;

        [NativeTypeName("#define PPM_FIRMWARE_PTC 0x00000400")]
        public const int PPM_FIRMWARE_PTC = 0x00000400;

        [NativeTypeName("#define PPM_FIRMWARE_TSS 0x00000800")]
        public const int PPM_FIRMWARE_TSS = 0x00000800;

        [NativeTypeName("#define PPM_FIRMWARE_TPC 0x00001000")]
        public const int PPM_FIRMWARE_TPC = 0x00001000;

        [NativeTypeName("#define PPM_FIRMWARE_TSD 0x00002000")]
        public const int PPM_FIRMWARE_TSD = 0x00002000;

        [NativeTypeName("#define PPM_FIRMWARE_PCCH 0x00004000")]
        public const int PPM_FIRMWARE_PCCH = 0x00004000;

        [NativeTypeName("#define PPM_FIRMWARE_PCCP 0x00008000")]
        public const int PPM_FIRMWARE_PCCP = 0x00008000;

        [NativeTypeName("#define PPM_FIRMWARE_OSC 0x00010000")]
        public const int PPM_FIRMWARE_OSC = 0x00010000;

        [NativeTypeName("#define PPM_FIRMWARE_PDC 0x00020000")]
        public const int PPM_FIRMWARE_PDC = 0x00020000;

        [NativeTypeName("#define PPM_FIRMWARE_CPC 0x00040000")]
        public const int PPM_FIRMWARE_CPC = 0x00040000;

        [NativeTypeName("#define PPM_FIRMWARE_LPI 0x00080000")]
        public const int PPM_FIRMWARE_LPI = 0x00080000;

        [NativeTypeName("#define PPM_PERFORMANCE_IMPLEMENTATION_NONE 0x00000000")]
        public const int PPM_PERFORMANCE_IMPLEMENTATION_NONE = 0x00000000;

        [NativeTypeName("#define PPM_PERFORMANCE_IMPLEMENTATION_PSTATES 0x00000001")]
        public const int PPM_PERFORMANCE_IMPLEMENTATION_PSTATES = 0x00000001;

        [NativeTypeName("#define PPM_PERFORMANCE_IMPLEMENTATION_PCCV1 0x00000002")]
        public const int PPM_PERFORMANCE_IMPLEMENTATION_PCCV1 = 0x00000002;

        [NativeTypeName("#define PPM_PERFORMANCE_IMPLEMENTATION_CPPC 0x00000003")]
        public const int PPM_PERFORMANCE_IMPLEMENTATION_CPPC = 0x00000003;

        [NativeTypeName("#define PPM_PERFORMANCE_IMPLEMENTATION_PEP 0x00000004")]
        public const int PPM_PERFORMANCE_IMPLEMENTATION_PEP = 0x00000004;

        [NativeTypeName("#define PPM_IDLE_IMPLEMENTATION_NONE 0x00000000")]
        public const int PPM_IDLE_IMPLEMENTATION_NONE = 0x00000000;

        [NativeTypeName("#define PPM_IDLE_IMPLEMENTATION_CSTATES 0x00000001")]
        public const int PPM_IDLE_IMPLEMENTATION_CSTATES = 0x00000001;

        [NativeTypeName("#define PPM_IDLE_IMPLEMENTATION_PEP 0x00000002")]
        public const int PPM_IDLE_IMPLEMENTATION_PEP = 0x00000002;

        [NativeTypeName("#define PPM_IDLE_IMPLEMENTATION_MICROPEP 0x00000003")]
        public const int PPM_IDLE_IMPLEMENTATION_MICROPEP = 0x00000003;

        [NativeTypeName("#define PPM_IDLE_IMPLEMENTATION_LPISTATES 0x00000004")]
        public const int PPM_IDLE_IMPLEMENTATION_LPISTATES = 0x00000004;

        [NativeTypeName("#define POWER_ACTION_QUERY_ALLOWED 0x00000001")]
        public const int POWER_ACTION_QUERY_ALLOWED = 0x00000001;

        [NativeTypeName("#define POWER_ACTION_UI_ALLOWED 0x00000002")]
        public const int POWER_ACTION_UI_ALLOWED = 0x00000002;

        [NativeTypeName("#define POWER_ACTION_OVERRIDE_APPS 0x00000004")]
        public const int POWER_ACTION_OVERRIDE_APPS = 0x00000004;

        [NativeTypeName("#define POWER_ACTION_HIBERBOOT 0x00000008")]
        public const int POWER_ACTION_HIBERBOOT = 0x00000008;

        [NativeTypeName("#define POWER_ACTION_USER_NOTIFY 0x00000010")]
        public const int POWER_ACTION_USER_NOTIFY = 0x00000010;

        [NativeTypeName("#define POWER_ACTION_DOZE_TO_HIBERNATE 0x00000020")]
        public const int POWER_ACTION_DOZE_TO_HIBERNATE = 0x00000020;

        [NativeTypeName("#define POWER_ACTION_ACPI_CRITICAL 0x01000000")]
        public const int POWER_ACTION_ACPI_CRITICAL = 0x01000000;

        [NativeTypeName("#define POWER_ACTION_ACPI_USER_NOTIFY 0x02000000")]
        public const int POWER_ACTION_ACPI_USER_NOTIFY = 0x02000000;

        [NativeTypeName("#define POWER_ACTION_DIRECTED_DRIPS 0x04000000")]
        public const int POWER_ACTION_DIRECTED_DRIPS = 0x04000000;

        [NativeTypeName("#define POWER_ACTION_PSEUDO_TRANSITION 0x08000000")]
        public const int POWER_ACTION_PSEUDO_TRANSITION = 0x08000000;

        [NativeTypeName("#define POWER_ACTION_LIGHTEST_FIRST 0x10000000")]
        public const int POWER_ACTION_LIGHTEST_FIRST = 0x10000000;

        [NativeTypeName("#define POWER_ACTION_LOCK_CONSOLE 0x20000000")]
        public const int POWER_ACTION_LOCK_CONSOLE = 0x20000000;

        [NativeTypeName("#define POWER_ACTION_DISABLE_WAKES 0x40000000")]
        public const int POWER_ACTION_DISABLE_WAKES = 0x40000000;

        [NativeTypeName("#define POWER_ACTION_CRITICAL 0x80000000")]
        public const uint POWER_ACTION_CRITICAL = 0x80000000;

        [NativeTypeName("#define POWER_LEVEL_USER_NOTIFY_TEXT 0x00000001")]
        public const int POWER_LEVEL_USER_NOTIFY_TEXT = 0x00000001;

        [NativeTypeName("#define POWER_LEVEL_USER_NOTIFY_SOUND 0x00000002")]
        public const int POWER_LEVEL_USER_NOTIFY_SOUND = 0x00000002;

        [NativeTypeName("#define POWER_LEVEL_USER_NOTIFY_EXEC 0x00000004")]
        public const int POWER_LEVEL_USER_NOTIFY_EXEC = 0x00000004;

        [NativeTypeName("#define POWER_USER_NOTIFY_BUTTON 0x00000008")]
        public const int POWER_USER_NOTIFY_BUTTON = 0x00000008;

        [NativeTypeName("#define POWER_USER_NOTIFY_SHUTDOWN 0x00000010")]
        public const int POWER_USER_NOTIFY_SHUTDOWN = 0x00000010;

        [NativeTypeName("#define POWER_USER_NOTIFY_FORCED_SHUTDOWN 0x00000020")]
        public const int POWER_USER_NOTIFY_FORCED_SHUTDOWN = 0x00000020;

        [NativeTypeName("#define POWER_FORCE_TRIGGER_RESET 0x80000000")]
        public const uint POWER_FORCE_TRIGGER_RESET = 0x80000000;

        [NativeTypeName("#define BATTERY_DISCHARGE_FLAGS_EVENTCODE_MASK 0x00000007")]
        public const int BATTERY_DISCHARGE_FLAGS_EVENTCODE_MASK = 0x00000007;

        [NativeTypeName("#define BATTERY_DISCHARGE_FLAGS_ENABLE 0x80000000")]
        public const uint BATTERY_DISCHARGE_FLAGS_ENABLE = 0x80000000;

        [NativeTypeName("#define NUM_DISCHARGE_POLICIES 4")]
        public const int NUM_DISCHARGE_POLICIES = 4;

        [NativeTypeName("#define DISCHARGE_POLICY_CRITICAL 0")]
        public const int DISCHARGE_POLICY_CRITICAL = 0;

        [NativeTypeName("#define DISCHARGE_POLICY_LOW 1")]
        public const int DISCHARGE_POLICY_LOW = 1;

        [NativeTypeName("#define PO_THROTTLE_NONE 0")]
        public const int PO_THROTTLE_NONE = 0;

        [NativeTypeName("#define PO_THROTTLE_CONSTANT 1")]
        public const int PO_THROTTLE_CONSTANT = 1;

        [NativeTypeName("#define PO_THROTTLE_DEGRADE 2")]
        public const int PO_THROTTLE_DEGRADE = 2;

        [NativeTypeName("#define PO_THROTTLE_ADAPTIVE 3")]
        public const int PO_THROTTLE_ADAPTIVE = 3;

        [NativeTypeName("#define PO_THROTTLE_MAXIMUM 4")]
        public const int PO_THROTTLE_MAXIMUM = 4;

        [NativeTypeName("#define HIBERFILE_TYPE_NONE 0x00")]
        public const int HIBERFILE_TYPE_NONE = 0x00;

        [NativeTypeName("#define HIBERFILE_TYPE_REDUCED 0x01")]
        public const int HIBERFILE_TYPE_REDUCED = 0x01;

        [NativeTypeName("#define HIBERFILE_TYPE_FULL 0x02")]
        public const int HIBERFILE_TYPE_FULL = 0x02;

        [NativeTypeName("#define HIBERFILE_TYPE_MAX 0x03")]
        public const int HIBERFILE_TYPE_MAX = 0x03;

        [NativeTypeName("#define N_BTMASK 0x000F")]
        public const int N_BTMASK = 0x000F;

        [NativeTypeName("#define N_TMASK 0x0030")]
        public const int N_TMASK = 0x0030;

        [NativeTypeName("#define N_TMASK1 0x00C0")]
        public const int N_TMASK1 = 0x00C0;

        [NativeTypeName("#define N_TMASK2 0x00F0")]
        public const int N_TMASK2 = 0x00F0;

        [NativeTypeName("#define N_BTSHFT 4")]
        public const int N_BTSHFT = 4;

        [NativeTypeName("#define N_TSHIFT 2")]
        public const int N_TSHIFT = 2;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM7B_INST_WORD_X 3")]
        public const int EMARCH_ENC_I17_IMM7B_INST_WORD_X = 3;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM7B_SIZE_X 7")]
        public const int EMARCH_ENC_I17_IMM7B_SIZE_X = 7;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM7B_INST_WORD_POS_X 4")]
        public const int EMARCH_ENC_I17_IMM7B_INST_WORD_POS_X = 4;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM7B_VAL_POS_X 0")]
        public const int EMARCH_ENC_I17_IMM7B_VAL_POS_X = 0;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM9D_INST_WORD_X 3")]
        public const int EMARCH_ENC_I17_IMM9D_INST_WORD_X = 3;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM9D_SIZE_X 9")]
        public const int EMARCH_ENC_I17_IMM9D_SIZE_X = 9;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM9D_INST_WORD_POS_X 18")]
        public const int EMARCH_ENC_I17_IMM9D_INST_WORD_POS_X = 18;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM9D_VAL_POS_X 7")]
        public const int EMARCH_ENC_I17_IMM9D_VAL_POS_X = 7;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM5C_INST_WORD_X 3")]
        public const int EMARCH_ENC_I17_IMM5C_INST_WORD_X = 3;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM5C_SIZE_X 5")]
        public const int EMARCH_ENC_I17_IMM5C_SIZE_X = 5;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM5C_INST_WORD_POS_X 13")]
        public const int EMARCH_ENC_I17_IMM5C_INST_WORD_POS_X = 13;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM5C_VAL_POS_X 16")]
        public const int EMARCH_ENC_I17_IMM5C_VAL_POS_X = 16;

        [NativeTypeName("#define EMARCH_ENC_I17_IC_INST_WORD_X 3")]
        public const int EMARCH_ENC_I17_IC_INST_WORD_X = 3;

        [NativeTypeName("#define EMARCH_ENC_I17_IC_SIZE_X 1")]
        public const int EMARCH_ENC_I17_IC_SIZE_X = 1;

        [NativeTypeName("#define EMARCH_ENC_I17_IC_INST_WORD_POS_X 12")]
        public const int EMARCH_ENC_I17_IC_INST_WORD_POS_X = 12;

        [NativeTypeName("#define EMARCH_ENC_I17_IC_VAL_POS_X 21")]
        public const int EMARCH_ENC_I17_IC_VAL_POS_X = 21;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM41a_INST_WORD_X 1")]
        public const int EMARCH_ENC_I17_IMM41a_INST_WORD_X = 1;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM41a_SIZE_X 10")]
        public const int EMARCH_ENC_I17_IMM41a_SIZE_X = 10;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM41a_INST_WORD_POS_X 14")]
        public const int EMARCH_ENC_I17_IMM41a_INST_WORD_POS_X = 14;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM41a_VAL_POS_X 22")]
        public const int EMARCH_ENC_I17_IMM41a_VAL_POS_X = 22;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM41b_INST_WORD_X 1")]
        public const int EMARCH_ENC_I17_IMM41b_INST_WORD_X = 1;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM41b_SIZE_X 8")]
        public const int EMARCH_ENC_I17_IMM41b_SIZE_X = 8;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM41b_INST_WORD_POS_X 24")]
        public const int EMARCH_ENC_I17_IMM41b_INST_WORD_POS_X = 24;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM41b_VAL_POS_X 32")]
        public const int EMARCH_ENC_I17_IMM41b_VAL_POS_X = 32;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM41c_INST_WORD_X 2")]
        public const int EMARCH_ENC_I17_IMM41c_INST_WORD_X = 2;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM41c_SIZE_X 23")]
        public const int EMARCH_ENC_I17_IMM41c_SIZE_X = 23;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM41c_INST_WORD_POS_X 0")]
        public const int EMARCH_ENC_I17_IMM41c_INST_WORD_POS_X = 0;

        [NativeTypeName("#define EMARCH_ENC_I17_IMM41c_VAL_POS_X 40")]
        public const int EMARCH_ENC_I17_IMM41c_VAL_POS_X = 40;

        [NativeTypeName("#define EMARCH_ENC_I17_SIGN_INST_WORD_X 3")]
        public const int EMARCH_ENC_I17_SIGN_INST_WORD_X = 3;

        [NativeTypeName("#define EMARCH_ENC_I17_SIGN_SIZE_X 1")]
        public const int EMARCH_ENC_I17_SIGN_SIZE_X = 1;

        [NativeTypeName("#define EMARCH_ENC_I17_SIGN_INST_WORD_POS_X 27")]
        public const int EMARCH_ENC_I17_SIGN_INST_WORD_POS_X = 27;

        [NativeTypeName("#define EMARCH_ENC_I17_SIGN_VAL_POS_X 63")]
        public const int EMARCH_ENC_I17_SIGN_VAL_POS_X = 63;

        [NativeTypeName("#define X3_OPCODE_INST_WORD_X 3")]
        public const int X3_OPCODE_INST_WORD_X = 3;

        [NativeTypeName("#define X3_OPCODE_SIZE_X 4")]
        public const int X3_OPCODE_SIZE_X = 4;

        [NativeTypeName("#define X3_OPCODE_INST_WORD_POS_X 28")]
        public const int X3_OPCODE_INST_WORD_POS_X = 28;

        [NativeTypeName("#define X3_OPCODE_SIGN_VAL_POS_X 0")]
        public const int X3_OPCODE_SIGN_VAL_POS_X = 0;

        [NativeTypeName("#define X3_I_INST_WORD_X 3")]
        public const int X3_I_INST_WORD_X = 3;

        [NativeTypeName("#define X3_I_SIZE_X 1")]
        public const int X3_I_SIZE_X = 1;

        [NativeTypeName("#define X3_I_INST_WORD_POS_X 27")]
        public const int X3_I_INST_WORD_POS_X = 27;

        [NativeTypeName("#define X3_I_SIGN_VAL_POS_X 59")]
        public const int X3_I_SIGN_VAL_POS_X = 59;

        [NativeTypeName("#define X3_D_WH_INST_WORD_X 3")]
        public const int X3_D_WH_INST_WORD_X = 3;

        [NativeTypeName("#define X3_D_WH_SIZE_X 3")]
        public const int X3_D_WH_SIZE_X = 3;

        [NativeTypeName("#define X3_D_WH_INST_WORD_POS_X 24")]
        public const int X3_D_WH_INST_WORD_POS_X = 24;

        [NativeTypeName("#define X3_D_WH_SIGN_VAL_POS_X 0")]
        public const int X3_D_WH_SIGN_VAL_POS_X = 0;

        [NativeTypeName("#define X3_IMM20_INST_WORD_X 3")]
        public const int X3_IMM20_INST_WORD_X = 3;

        [NativeTypeName("#define X3_IMM20_SIZE_X 20")]
        public const int X3_IMM20_SIZE_X = 20;

        [NativeTypeName("#define X3_IMM20_INST_WORD_POS_X 4")]
        public const int X3_IMM20_INST_WORD_POS_X = 4;

        [NativeTypeName("#define X3_IMM20_SIGN_VAL_POS_X 0")]
        public const int X3_IMM20_SIGN_VAL_POS_X = 0;

        [NativeTypeName("#define X3_IMM39_1_INST_WORD_X 2")]
        public const int X3_IMM39_1_INST_WORD_X = 2;

        [NativeTypeName("#define X3_IMM39_1_SIZE_X 23")]
        public const int X3_IMM39_1_SIZE_X = 23;

        [NativeTypeName("#define X3_IMM39_1_INST_WORD_POS_X 0")]
        public const int X3_IMM39_1_INST_WORD_POS_X = 0;

        [NativeTypeName("#define X3_IMM39_1_SIGN_VAL_POS_X 36")]
        public const int X3_IMM39_1_SIGN_VAL_POS_X = 36;

        [NativeTypeName("#define X3_IMM39_2_INST_WORD_X 1")]
        public const int X3_IMM39_2_INST_WORD_X = 1;

        [NativeTypeName("#define X3_IMM39_2_SIZE_X 16")]
        public const int X3_IMM39_2_SIZE_X = 16;

        [NativeTypeName("#define X3_IMM39_2_INST_WORD_POS_X 16")]
        public const int X3_IMM39_2_INST_WORD_POS_X = 16;

        [NativeTypeName("#define X3_IMM39_2_SIGN_VAL_POS_X 20")]
        public const int X3_IMM39_2_SIGN_VAL_POS_X = 20;

        [NativeTypeName("#define X3_P_INST_WORD_X 3")]
        public const int X3_P_INST_WORD_X = 3;

        [NativeTypeName("#define X3_P_SIZE_X 4")]
        public const int X3_P_SIZE_X = 4;

        [NativeTypeName("#define X3_P_INST_WORD_POS_X 0")]
        public const int X3_P_INST_WORD_POS_X = 0;

        [NativeTypeName("#define X3_P_SIGN_VAL_POS_X 0")]
        public const int X3_P_SIGN_VAL_POS_X = 0;

        [NativeTypeName("#define X3_TMPLT_INST_WORD_X 0")]
        public const int X3_TMPLT_INST_WORD_X = 0;

        [NativeTypeName("#define X3_TMPLT_SIZE_X 4")]
        public const int X3_TMPLT_SIZE_X = 4;

        [NativeTypeName("#define X3_TMPLT_INST_WORD_POS_X 0")]
        public const int X3_TMPLT_INST_WORD_POS_X = 0;

        [NativeTypeName("#define X3_TMPLT_SIGN_VAL_POS_X 0")]
        public const int X3_TMPLT_SIGN_VAL_POS_X = 0;

        [NativeTypeName("#define X3_BTYPE_QP_INST_WORD_X 2")]
        public const int X3_BTYPE_QP_INST_WORD_X = 2;

        [NativeTypeName("#define X3_BTYPE_QP_SIZE_X 9")]
        public const int X3_BTYPE_QP_SIZE_X = 9;

        [NativeTypeName("#define X3_BTYPE_QP_INST_WORD_POS_X 23")]
        public const int X3_BTYPE_QP_INST_WORD_POS_X = 23;

        [NativeTypeName("#define X3_BTYPE_QP_INST_VAL_POS_X 0")]
        public const int X3_BTYPE_QP_INST_VAL_POS_X = 0;

        [NativeTypeName("#define X3_EMPTY_INST_WORD_X 1")]
        public const int X3_EMPTY_INST_WORD_X = 1;

        [NativeTypeName("#define X3_EMPTY_SIZE_X 2")]
        public const int X3_EMPTY_SIZE_X = 2;

        [NativeTypeName("#define X3_EMPTY_INST_WORD_POS_X 14")]
        public const int X3_EMPTY_INST_WORD_POS_X = 14;

        [NativeTypeName("#define X3_EMPTY_INST_VAL_POS_X 0")]
        public const int X3_EMPTY_INST_VAL_POS_X = 0;

        [NativeTypeName("#define FRAME_FPO 0")]
        public const int FRAME_FPO = 0;

        [NativeTypeName("#define FRAME_TRAP 1")]
        public const int FRAME_TRAP = 1;

        [NativeTypeName("#define FRAME_TSS 2")]
        public const int FRAME_TSS = 2;

        [NativeTypeName("#define FRAME_NONFPO 3")]
        public const int FRAME_NONFPO = 3;

        [NativeTypeName("#define SIZEOF_RFPO_DATA 16")]
        public const int SIZEOF_RFPO_DATA = 16;

        [NativeTypeName("#define NON_PAGED_DEBUG_SIGNATURE 0x494E")]
        public const int NON_PAGED_DEBUG_SIGNATURE = 0x494E;

        [NativeTypeName("#define IMPORT_OBJECT_HDR_SIG2 0xffff")]
        public const int IMPORT_OBJECT_HDR_SIG2 = 0xffff;

        [NativeTypeName("#define UNWIND_HISTORY_TABLE_SIZE 12")]
        public const int UNWIND_HISTORY_TABLE_SIZE = 12;

        [NativeTypeName("#define HEAP_NO_SERIALIZE 0x00000001")]
        public const int HEAP_NO_SERIALIZE = 0x00000001;

        [NativeTypeName("#define HEAP_GROWABLE 0x00000002")]
        public const int HEAP_GROWABLE = 0x00000002;

        [NativeTypeName("#define HEAP_GENERATE_EXCEPTIONS 0x00000004")]
        public const int HEAP_GENERATE_EXCEPTIONS = 0x00000004;

        [NativeTypeName("#define HEAP_ZERO_MEMORY 0x00000008")]
        public const int HEAP_ZERO_MEMORY = 0x00000008;

        [NativeTypeName("#define HEAP_REALLOC_IN_PLACE_ONLY 0x00000010")]
        public const int HEAP_REALLOC_IN_PLACE_ONLY = 0x00000010;

        [NativeTypeName("#define HEAP_TAIL_CHECKING_ENABLED 0x00000020")]
        public const int HEAP_TAIL_CHECKING_ENABLED = 0x00000020;

        [NativeTypeName("#define HEAP_FREE_CHECKING_ENABLED 0x00000040")]
        public const int HEAP_FREE_CHECKING_ENABLED = 0x00000040;

        [NativeTypeName("#define HEAP_DISABLE_COALESCE_ON_FREE 0x00000080")]
        public const int HEAP_DISABLE_COALESCE_ON_FREE = 0x00000080;

        [NativeTypeName("#define HEAP_CREATE_ALIGN_16 0x00010000")]
        public const int HEAP_CREATE_ALIGN_16 = 0x00010000;

        [NativeTypeName("#define HEAP_CREATE_ENABLE_TRACING 0x00020000")]
        public const int HEAP_CREATE_ENABLE_TRACING = 0x00020000;

        [NativeTypeName("#define HEAP_CREATE_ENABLE_EXECUTE 0x00040000")]
        public const int HEAP_CREATE_ENABLE_EXECUTE = 0x00040000;

        [NativeTypeName("#define HEAP_MAXIMUM_TAG 0x0FFF")]
        public const int HEAP_MAXIMUM_TAG = 0x0FFF;

        [NativeTypeName("#define HEAP_PSEUDO_TAG_FLAG 0x8000")]
        public const int HEAP_PSEUDO_TAG_FLAG = 0x8000;

        [NativeTypeName("#define HEAP_TAG_SHIFT 18")]
        public const int HEAP_TAG_SHIFT = 18;

        [NativeTypeName("#define HEAP_CREATE_SEGMENT_HEAP 0x00000100")]
        public const int HEAP_CREATE_SEGMENT_HEAP = 0x00000100;

        [NativeTypeName("#define HEAP_CREATE_HARDENED 0x00000200")]
        public const int HEAP_CREATE_HARDENED = 0x00000200;

        [NativeTypeName("#define IS_TEXT_UNICODE_ASCII16 0x0001")]
        public const int IS_TEXT_UNICODE_ASCII16 = 0x0001;

        [NativeTypeName("#define IS_TEXT_UNICODE_REVERSE_ASCII16 0x0010")]
        public const int IS_TEXT_UNICODE_REVERSE_ASCII16 = 0x0010;

        [NativeTypeName("#define IS_TEXT_UNICODE_STATISTICS 0x0002")]
        public const int IS_TEXT_UNICODE_STATISTICS = 0x0002;

        [NativeTypeName("#define IS_TEXT_UNICODE_REVERSE_STATISTICS 0x0020")]
        public const int IS_TEXT_UNICODE_REVERSE_STATISTICS = 0x0020;

        [NativeTypeName("#define IS_TEXT_UNICODE_CONTROLS 0x0004")]
        public const int IS_TEXT_UNICODE_CONTROLS = 0x0004;

        [NativeTypeName("#define IS_TEXT_UNICODE_REVERSE_CONTROLS 0x0040")]
        public const int IS_TEXT_UNICODE_REVERSE_CONTROLS = 0x0040;

        [NativeTypeName("#define IS_TEXT_UNICODE_SIGNATURE 0x0008")]
        public const int IS_TEXT_UNICODE_SIGNATURE = 0x0008;

        [NativeTypeName("#define IS_TEXT_UNICODE_REVERSE_SIGNATURE 0x0080")]
        public const int IS_TEXT_UNICODE_REVERSE_SIGNATURE = 0x0080;

        [NativeTypeName("#define IS_TEXT_UNICODE_ILLEGAL_CHARS 0x0100")]
        public const int IS_TEXT_UNICODE_ILLEGAL_CHARS = 0x0100;

        [NativeTypeName("#define IS_TEXT_UNICODE_ODD_LENGTH 0x0200")]
        public const int IS_TEXT_UNICODE_ODD_LENGTH = 0x0200;

        [NativeTypeName("#define IS_TEXT_UNICODE_DBCS_LEADBYTE 0x0400")]
        public const int IS_TEXT_UNICODE_DBCS_LEADBYTE = 0x0400;

        [NativeTypeName("#define IS_TEXT_UNICODE_UTF8 0x0800")]
        public const int IS_TEXT_UNICODE_UTF8 = 0x0800;

        [NativeTypeName("#define IS_TEXT_UNICODE_NULL_BYTES 0x1000")]
        public const int IS_TEXT_UNICODE_NULL_BYTES = 0x1000;

        [NativeTypeName("#define IS_TEXT_UNICODE_UNICODE_MASK 0x000F")]
        public const int IS_TEXT_UNICODE_UNICODE_MASK = 0x000F;

        [NativeTypeName("#define IS_TEXT_UNICODE_REVERSE_MASK 0x00F0")]
        public const int IS_TEXT_UNICODE_REVERSE_MASK = 0x00F0;

        [NativeTypeName("#define IS_TEXT_UNICODE_NOT_UNICODE_MASK 0x0F00")]
        public const int IS_TEXT_UNICODE_NOT_UNICODE_MASK = 0x0F00;

        [NativeTypeName("#define IS_TEXT_UNICODE_NOT_ASCII_MASK 0xF000")]
        public const int IS_TEXT_UNICODE_NOT_ASCII_MASK = 0xF000;

        [NativeTypeName("#define COMPRESSION_FORMAT_NONE (0x0000)")]
        public const int COMPRESSION_FORMAT_NONE = (0x0000);

        [NativeTypeName("#define COMPRESSION_FORMAT_DEFAULT (0x0001)")]
        public const int COMPRESSION_FORMAT_DEFAULT = (0x0001);

        [NativeTypeName("#define COMPRESSION_FORMAT_LZNT1 (0x0002)")]
        public const int COMPRESSION_FORMAT_LZNT1 = (0x0002);

        [NativeTypeName("#define COMPRESSION_FORMAT_XPRESS (0x0003)")]
        public const int COMPRESSION_FORMAT_XPRESS = (0x0003);

        [NativeTypeName("#define COMPRESSION_FORMAT_XPRESS_HUFF (0x0004)")]
        public const int COMPRESSION_FORMAT_XPRESS_HUFF = (0x0004);

        [NativeTypeName("#define COMPRESSION_FORMAT_XP10 (0x0005)")]
        public const int COMPRESSION_FORMAT_XP10 = (0x0005);

        [NativeTypeName("#define COMPRESSION_ENGINE_STANDARD (0x0000)")]
        public const int COMPRESSION_ENGINE_STANDARD = (0x0000);

        [NativeTypeName("#define COMPRESSION_ENGINE_MAXIMUM (0x0100)")]
        public const int COMPRESSION_ENGINE_MAXIMUM = (0x0100);

        [NativeTypeName("#define COMPRESSION_ENGINE_HIBER (0x0200)")]
        public const int COMPRESSION_ENGINE_HIBER = (0x0200);

        [NativeTypeName("#define SEF_DACL_AUTO_INHERIT 0x01")]
        public const int SEF_DACL_AUTO_INHERIT = 0x01;

        [NativeTypeName("#define SEF_SACL_AUTO_INHERIT 0x02")]
        public const int SEF_SACL_AUTO_INHERIT = 0x02;

        [NativeTypeName("#define SEF_DEFAULT_DESCRIPTOR_FOR_OBJECT 0x04")]
        public const int SEF_DEFAULT_DESCRIPTOR_FOR_OBJECT = 0x04;

        [NativeTypeName("#define SEF_AVOID_PRIVILEGE_CHECK 0x08")]
        public const int SEF_AVOID_PRIVILEGE_CHECK = 0x08;

        [NativeTypeName("#define SEF_AVOID_OWNER_CHECK 0x10")]
        public const int SEF_AVOID_OWNER_CHECK = 0x10;

        [NativeTypeName("#define SEF_DEFAULT_OWNER_FROM_PARENT 0x20")]
        public const int SEF_DEFAULT_OWNER_FROM_PARENT = 0x20;

        [NativeTypeName("#define SEF_DEFAULT_GROUP_FROM_PARENT 0x40")]
        public const int SEF_DEFAULT_GROUP_FROM_PARENT = 0x40;

        [NativeTypeName("#define SEF_MACL_NO_WRITE_UP 0x100")]
        public const int SEF_MACL_NO_WRITE_UP = 0x100;

        [NativeTypeName("#define SEF_MACL_NO_READ_UP 0x200")]
        public const int SEF_MACL_NO_READ_UP = 0x200;

        [NativeTypeName("#define SEF_MACL_NO_EXECUTE_UP 0x400")]
        public const int SEF_MACL_NO_EXECUTE_UP = 0x400;

        [NativeTypeName("#define SEF_AI_USE_EXTRA_PARAMS 0x800")]
        public const int SEF_AI_USE_EXTRA_PARAMS = 0x800;

        [NativeTypeName("#define SEF_AVOID_OWNER_RESTRICTION 0x1000")]
        public const int SEF_AVOID_OWNER_RESTRICTION = 0x1000;

        [NativeTypeName("#define SEF_FORCE_USER_MODE 0x2000")]
        public const int SEF_FORCE_USER_MODE = 0x2000;

        [NativeTypeName("#define SEF_MACL_VALID_FLAGS (SEF_MACL_NO_WRITE_UP   | \\\r\n                                           SEF_MACL_NO_READ_UP    | \\\r\n                                           SEF_MACL_NO_EXECUTE_UP)")]
        public const int SEF_MACL_VALID_FLAGS = (0x100 | 0x200 | 0x400);

        [NativeTypeName("#define MESSAGE_RESOURCE_UNICODE 0x0001")]
        public const int MESSAGE_RESOURCE_UNICODE = 0x0001;

        [NativeTypeName("#define MESSAGE_RESOURCE_UTF8 0x0002")]
        public const int MESSAGE_RESOURCE_UTF8 = 0x0002;

        [NativeTypeName("#define VER_EQUAL 1")]
        public const int VER_EQUAL = 1;

        [NativeTypeName("#define VER_GREATER 2")]
        public const int VER_GREATER = 2;

        [NativeTypeName("#define VER_GREATER_EQUAL 3")]
        public const int VER_GREATER_EQUAL = 3;

        [NativeTypeName("#define VER_LESS 4")]
        public const int VER_LESS = 4;

        [NativeTypeName("#define VER_LESS_EQUAL 5")]
        public const int VER_LESS_EQUAL = 5;

        [NativeTypeName("#define VER_AND 6")]
        public const int VER_AND = 6;

        [NativeTypeName("#define VER_OR 7")]
        public const int VER_OR = 7;

        [NativeTypeName("#define VER_CONDITION_MASK 7")]
        public const int VER_CONDITION_MASK = 7;

        [NativeTypeName("#define VER_NUM_BITS_PER_CONDITION_MASK 3")]
        public const int VER_NUM_BITS_PER_CONDITION_MASK = 3;

        [NativeTypeName("#define VER_MINORVERSION 0x0000001")]
        public const int VER_MINORVERSION = 0x0000001;

        [NativeTypeName("#define VER_MAJORVERSION 0x0000002")]
        public const int VER_MAJORVERSION = 0x0000002;

        [NativeTypeName("#define VER_BUILDNUMBER 0x0000004")]
        public const int VER_BUILDNUMBER = 0x0000004;

        [NativeTypeName("#define VER_PLATFORMID 0x0000008")]
        public const int VER_PLATFORMID = 0x0000008;

        [NativeTypeName("#define VER_SERVICEPACKMINOR 0x0000010")]
        public const int VER_SERVICEPACKMINOR = 0x0000010;

        [NativeTypeName("#define VER_SERVICEPACKMAJOR 0x0000020")]
        public const int VER_SERVICEPACKMAJOR = 0x0000020;

        [NativeTypeName("#define VER_SUITENAME 0x0000040")]
        public const int VER_SUITENAME = 0x0000040;

        [NativeTypeName("#define VER_PRODUCT_TYPE 0x0000080")]
        public const int VER_PRODUCT_TYPE = 0x0000080;

        [NativeTypeName("#define VER_NT_WORKSTATION 0x0000001")]
        public const int VER_NT_WORKSTATION = 0x0000001;

        [NativeTypeName("#define VER_NT_DOMAIN_CONTROLLER 0x0000002")]
        public const int VER_NT_DOMAIN_CONTROLLER = 0x0000002;

        [NativeTypeName("#define VER_NT_SERVER 0x0000003")]
        public const int VER_NT_SERVER = 0x0000003;

        [NativeTypeName("#define VER_PLATFORM_WIN32s 0")]
        public const int VER_PLATFORM_WIN32s = 0;

        [NativeTypeName("#define VER_PLATFORM_WIN32_WINDOWS 1")]
        public const int VER_PLATFORM_WIN32_WINDOWS = 1;

        [NativeTypeName("#define VER_PLATFORM_WIN32_NT 2")]
        public const int VER_PLATFORM_WIN32_NT = 2;

        [NativeTypeName("#define VRL_PREDEFINED_CLASS_BEGIN (1 << 0)")]
        public const int VRL_PREDEFINED_CLASS_BEGIN = (1 << 0);

        [NativeTypeName("#define VRL_CUSTOM_CLASS_BEGIN (1 << 8)")]
        public const int VRL_CUSTOM_CLASS_BEGIN = (1 << 8);

        [NativeTypeName("#define VRL_CLASS_CONSISTENCY (VRL_PREDEFINED_CLASS_BEGIN << 0)")]
        public const int VRL_CLASS_CONSISTENCY = ((1 << 0) << 0);

        [NativeTypeName("#define VRL_ENABLE_KERNEL_BREAKS (1 << 31)")]
        public const int VRL_ENABLE_KERNEL_BREAKS = (1 << 31);

        [NativeTypeName("#define CTMF_INCLUDE_APPCONTAINER 0x00000001UL")]
        public const uint CTMF_INCLUDE_APPCONTAINER = 0x00000001U;

        [NativeTypeName("#define CTMF_INCLUDE_LPAC 0x00000002UL")]
        public const uint CTMF_INCLUDE_LPAC = 0x00000002U;

        [NativeTypeName("#define CTMF_VALID_FLAGS (CTMF_INCLUDE_APPCONTAINER | CTMF_INCLUDE_LPAC)")]
        public const uint CTMF_VALID_FLAGS = (0x00000001U | 0x00000002U);

        [NativeTypeName("#define FLUSH_NV_MEMORY_IN_FLAG_NO_DRAIN (0x00000001)")]
        public const int FLUSH_NV_MEMORY_IN_FLAG_NO_DRAIN = (0x00000001);

        [NativeTypeName("#define FLUSH_NV_MEMORY_DEFAULT_TOKEN (ULONG_PTR)(-1)")]
        public static nuint FLUSH_NV_MEMORY_DEFAULT_TOKEN => unchecked((nuint)(-1));

        [NativeTypeName("#define WRITE_NV_MEMORY_FLAG_FLUSH (0x00000001)")]
        public const int WRITE_NV_MEMORY_FLAG_FLUSH = (0x00000001);

        [NativeTypeName("#define WRITE_NV_MEMORY_FLAG_NON_TEMPORAL (0x00000002)")]
        public const int WRITE_NV_MEMORY_FLAG_NON_TEMPORAL = (0x00000002);

        [NativeTypeName("#define WRITE_NV_MEMORY_FLAG_PERSIST (WRITE_NV_MEMORY_FLAG_FLUSH \\\r\n                                              | WRITE_NV_MEMORY_FLAG_NON_TEMPORAL)")]
        public const int WRITE_NV_MEMORY_FLAG_PERSIST = ((0x00000001) | (0x00000002));

        [NativeTypeName("#define WRITE_NV_MEMORY_FLAG_NO_DRAIN (0x00000100)")]
        public const int WRITE_NV_MEMORY_FLAG_NO_DRAIN = (0x00000100);

        [NativeTypeName("#define FILL_NV_MEMORY_FLAG_FLUSH (0x00000001)")]
        public const int FILL_NV_MEMORY_FLAG_FLUSH = (0x00000001);

        [NativeTypeName("#define FILL_NV_MEMORY_FLAG_NON_TEMPORAL (0x00000002)")]
        public const int FILL_NV_MEMORY_FLAG_NON_TEMPORAL = (0x00000002);

        [NativeTypeName("#define FILL_NV_MEMORY_FLAG_PERSIST (FILL_NV_MEMORY_FLAG_FLUSH \\\r\n                                              | FILL_NV_MEMORY_FLAG_NON_TEMPORAL)")]
        public const int FILL_NV_MEMORY_FLAG_PERSIST = ((0x00000001) | (0x00000002));

        [NativeTypeName("#define FILL_NV_MEMORY_FLAG_NO_DRAIN (0x00000100)")]
        public const int FILL_NV_MEMORY_FLAG_NO_DRAIN = (0x00000100);

        [NativeTypeName("#define HEAP_OPTIMIZE_RESOURCES_CURRENT_VERSION 1")]
        public const int HEAP_OPTIMIZE_RESOURCES_CURRENT_VERSION = 1;

        [NativeTypeName("#define WT_EXECUTEDEFAULT 0x00000000")]
        public const int WT_EXECUTEDEFAULT = 0x00000000;

        [NativeTypeName("#define WT_EXECUTEINIOTHREAD 0x00000001")]
        public const int WT_EXECUTEINIOTHREAD = 0x00000001;

        [NativeTypeName("#define WT_EXECUTEINUITHREAD 0x00000002")]
        public const int WT_EXECUTEINUITHREAD = 0x00000002;

        [NativeTypeName("#define WT_EXECUTEINWAITTHREAD 0x00000004")]
        public const int WT_EXECUTEINWAITTHREAD = 0x00000004;

        [NativeTypeName("#define WT_EXECUTEONLYONCE 0x00000008")]
        public const int WT_EXECUTEONLYONCE = 0x00000008;

        [NativeTypeName("#define WT_EXECUTEINTIMERTHREAD 0x00000020")]
        public const int WT_EXECUTEINTIMERTHREAD = 0x00000020;

        [NativeTypeName("#define WT_EXECUTELONGFUNCTION 0x00000010")]
        public const int WT_EXECUTELONGFUNCTION = 0x00000010;

        [NativeTypeName("#define WT_EXECUTEINPERSISTENTIOTHREAD 0x00000040")]
        public const int WT_EXECUTEINPERSISTENTIOTHREAD = 0x00000040;

        [NativeTypeName("#define WT_EXECUTEINPERSISTENTTHREAD 0x00000080")]
        public const int WT_EXECUTEINPERSISTENTTHREAD = 0x00000080;

        [NativeTypeName("#define WT_TRANSFER_IMPERSONATION 0x00000100")]
        public const int WT_TRANSFER_IMPERSONATION = 0x00000100;

        [NativeTypeName("#define WT_EXECUTEINLONGTHREAD 0x00000010")]
        public const int WT_EXECUTEINLONGTHREAD = 0x00000010;

        [NativeTypeName("#define WT_EXECUTEDELETEWAIT 0x00000008")]
        public const int WT_EXECUTEDELETEWAIT = 0x00000008;

        [NativeTypeName("#define ACTIVATION_CONTEXT_PATH_TYPE_NONE (1)")]
        public const int ACTIVATION_CONTEXT_PATH_TYPE_NONE = (1);

        [NativeTypeName("#define ACTIVATION_CONTEXT_PATH_TYPE_WIN32_FILE (2)")]
        public const int ACTIVATION_CONTEXT_PATH_TYPE_WIN32_FILE = (2);

        [NativeTypeName("#define ACTIVATION_CONTEXT_PATH_TYPE_URL (3)")]
        public const int ACTIVATION_CONTEXT_PATH_TYPE_URL = (3);

        [NativeTypeName("#define ACTIVATION_CONTEXT_PATH_TYPE_ASSEMBLYREF (4)")]
        public const int ACTIVATION_CONTEXT_PATH_TYPE_ASSEMBLYREF = (4);

        [NativeTypeName("#define CREATE_BOUNDARY_DESCRIPTOR_ADD_APPCONTAINER_SID 0x1")]
        public const int CREATE_BOUNDARY_DESCRIPTOR_ADD_APPCONTAINER_SID = 0x1;

        [NativeTypeName("#define PERFORMANCE_DATA_VERSION 1")]
        public const int PERFORMANCE_DATA_VERSION = 1;

        [NativeTypeName("#define READ_THREAD_PROFILING_FLAG_DISPATCHING 0x00000001")]
        public const int READ_THREAD_PROFILING_FLAG_DISPATCHING = 0x00000001;

        [NativeTypeName("#define READ_THREAD_PROFILING_FLAG_HARDWARE_COUNTERS 0x00000002")]
        public const int READ_THREAD_PROFILING_FLAG_HARDWARE_COUNTERS = 0x00000002;

        [NativeTypeName("#define UNIFIEDBUILDREVISION_KEY L\"\\\\Registry\\\\Machine\\\\Software\\\\Microsoft\\\\Windows NT\\\\CurrentVersion\"")]
        public const string UNIFIEDBUILDREVISION_KEY = "\\Registry\\Machine\\Software\\Microsoft\\Windows NT\\CurrentVersion";

        [NativeTypeName("#define UNIFIEDBUILDREVISION_VALUE L\"UBR\"")]
        public const string UNIFIEDBUILDREVISION_VALUE = "UBR";

        [NativeTypeName("#define UNIFIEDBUILDREVISION_MIN 0x00000000")]
        public const int UNIFIEDBUILDREVISION_MIN = 0x00000000;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_KEY L\"\\\\Registry\\\\Machine\\\\Software\\\\Microsoft\\\\Windows NT\\\\CurrentVersion\\\\OEM\"")]
        public const string DEVICEFAMILYDEVICEFORM_KEY = "\\Registry\\Machine\\Software\\Microsoft\\Windows NT\\CurrentVersion\\OEM";

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_VALUE L\"DeviceForm\"")]
        public const string DEVICEFAMILYDEVICEFORM_VALUE = "DeviceForm";

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_UAP 0x00000000")]
        public const int DEVICEFAMILYINFOENUM_UAP = 0x00000000;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_WINDOWS_8X 0x00000001")]
        public const int DEVICEFAMILYINFOENUM_WINDOWS_8X = 0x00000001;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_WINDOWS_PHONE_8X 0x00000002")]
        public const int DEVICEFAMILYINFOENUM_WINDOWS_PHONE_8X = 0x00000002;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_DESKTOP 0x00000003")]
        public const int DEVICEFAMILYINFOENUM_DESKTOP = 0x00000003;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_MOBILE 0x00000004")]
        public const int DEVICEFAMILYINFOENUM_MOBILE = 0x00000004;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_XBOX 0x00000005")]
        public const int DEVICEFAMILYINFOENUM_XBOX = 0x00000005;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_TEAM 0x00000006")]
        public const int DEVICEFAMILYINFOENUM_TEAM = 0x00000006;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_IOT 0x00000007")]
        public const int DEVICEFAMILYINFOENUM_IOT = 0x00000007;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_IOT_HEADLESS 0x00000008")]
        public const int DEVICEFAMILYINFOENUM_IOT_HEADLESS = 0x00000008;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_SERVER 0x00000009")]
        public const int DEVICEFAMILYINFOENUM_SERVER = 0x00000009;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_HOLOGRAPHIC 0x0000000A")]
        public const int DEVICEFAMILYINFOENUM_HOLOGRAPHIC = 0x0000000A;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_XBOXSRA 0x0000000B")]
        public const int DEVICEFAMILYINFOENUM_XBOXSRA = 0x0000000B;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_XBOXERA 0x0000000C")]
        public const int DEVICEFAMILYINFOENUM_XBOXERA = 0x0000000C;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_SERVER_NANO 0x0000000D")]
        public const int DEVICEFAMILYINFOENUM_SERVER_NANO = 0x0000000D;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_8828080 0x0000000E")]
        public const int DEVICEFAMILYINFOENUM_8828080 = 0x0000000E;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_7067329 0x0000000F")]
        public const int DEVICEFAMILYINFOENUM_7067329 = 0x0000000F;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_WINDOWS_CORE 0x00000010")]
        public const int DEVICEFAMILYINFOENUM_WINDOWS_CORE = 0x00000010;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_WINDOWS_CORE_HEADLESS 0x00000011")]
        public const int DEVICEFAMILYINFOENUM_WINDOWS_CORE_HEADLESS = 0x00000011;

        [NativeTypeName("#define DEVICEFAMILYINFOENUM_MAX 0x00000011")]
        public const int DEVICEFAMILYINFOENUM_MAX = 0x00000011;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_UNKNOWN 0x00000000")]
        public const int DEVICEFAMILYDEVICEFORM_UNKNOWN = 0x00000000;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_PHONE 0x00000001")]
        public const int DEVICEFAMILYDEVICEFORM_PHONE = 0x00000001;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_TABLET 0x00000002")]
        public const int DEVICEFAMILYDEVICEFORM_TABLET = 0x00000002;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_DESKTOP 0x00000003")]
        public const int DEVICEFAMILYDEVICEFORM_DESKTOP = 0x00000003;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_NOTEBOOK 0x00000004")]
        public const int DEVICEFAMILYDEVICEFORM_NOTEBOOK = 0x00000004;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_CONVERTIBLE 0x00000005")]
        public const int DEVICEFAMILYDEVICEFORM_CONVERTIBLE = 0x00000005;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_DETACHABLE 0x00000006")]
        public const int DEVICEFAMILYDEVICEFORM_DETACHABLE = 0x00000006;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_ALLINONE 0x00000007")]
        public const int DEVICEFAMILYDEVICEFORM_ALLINONE = 0x00000007;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_STICKPC 0x00000008")]
        public const int DEVICEFAMILYDEVICEFORM_STICKPC = 0x00000008;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_PUCK 0x00000009")]
        public const int DEVICEFAMILYDEVICEFORM_PUCK = 0x00000009;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_LARGESCREEN 0x0000000A")]
        public const int DEVICEFAMILYDEVICEFORM_LARGESCREEN = 0x0000000A;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_HMD 0x0000000B")]
        public const int DEVICEFAMILYDEVICEFORM_HMD = 0x0000000B;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_INDUSTRY_HANDHELD 0x0000000C")]
        public const int DEVICEFAMILYDEVICEFORM_INDUSTRY_HANDHELD = 0x0000000C;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_INDUSTRY_TABLET 0x0000000D")]
        public const int DEVICEFAMILYDEVICEFORM_INDUSTRY_TABLET = 0x0000000D;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_BANKING 0x0000000E")]
        public const int DEVICEFAMILYDEVICEFORM_BANKING = 0x0000000E;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_BUILDING_AUTOMATION 0x0000000F")]
        public const int DEVICEFAMILYDEVICEFORM_BUILDING_AUTOMATION = 0x0000000F;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_DIGITAL_SIGNAGE 0x00000010")]
        public const int DEVICEFAMILYDEVICEFORM_DIGITAL_SIGNAGE = 0x00000010;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_GAMING 0x00000011")]
        public const int DEVICEFAMILYDEVICEFORM_GAMING = 0x00000011;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_HOME_AUTOMATION 0x00000012")]
        public const int DEVICEFAMILYDEVICEFORM_HOME_AUTOMATION = 0x00000012;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_INDUSTRIAL_AUTOMATION 0x00000013")]
        public const int DEVICEFAMILYDEVICEFORM_INDUSTRIAL_AUTOMATION = 0x00000013;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_KIOSK 0x00000014")]
        public const int DEVICEFAMILYDEVICEFORM_KIOSK = 0x00000014;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_MAKER_BOARD 0x00000015")]
        public const int DEVICEFAMILYDEVICEFORM_MAKER_BOARD = 0x00000015;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_MEDICAL 0x00000016")]
        public const int DEVICEFAMILYDEVICEFORM_MEDICAL = 0x00000016;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_NETWORKING 0x00000017")]
        public const int DEVICEFAMILYDEVICEFORM_NETWORKING = 0x00000017;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_POINT_OF_SERVICE 0x00000018")]
        public const int DEVICEFAMILYDEVICEFORM_POINT_OF_SERVICE = 0x00000018;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_PRINTING 0x00000019")]
        public const int DEVICEFAMILYDEVICEFORM_PRINTING = 0x00000019;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_THIN_CLIENT 0x0000001A")]
        public const int DEVICEFAMILYDEVICEFORM_THIN_CLIENT = 0x0000001A;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_TOY 0x0000001B")]
        public const int DEVICEFAMILYDEVICEFORM_TOY = 0x0000001B;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_VENDING 0x0000001C")]
        public const int DEVICEFAMILYDEVICEFORM_VENDING = 0x0000001C;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_INDUSTRY_OTHER 0x0000001D")]
        public const int DEVICEFAMILYDEVICEFORM_INDUSTRY_OTHER = 0x0000001D;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_XBOX_ONE 0x0000001E")]
        public const int DEVICEFAMILYDEVICEFORM_XBOX_ONE = 0x0000001E;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_XBOX_ONE_S 0x0000001F")]
        public const int DEVICEFAMILYDEVICEFORM_XBOX_ONE_S = 0x0000001F;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_XBOX_ONE_X 0x00000020")]
        public const int DEVICEFAMILYDEVICEFORM_XBOX_ONE_X = 0x00000020;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_XBOX_ONE_X_DEVKIT 0x00000021")]
        public const int DEVICEFAMILYDEVICEFORM_XBOX_ONE_X_DEVKIT = 0x00000021;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_XBOX_SERIES_X 0x00000022")]
        public const int DEVICEFAMILYDEVICEFORM_XBOX_SERIES_X = 0x00000022;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_XBOX_SERIES_X_DEVKIT 0x00000023")]
        public const int DEVICEFAMILYDEVICEFORM_XBOX_SERIES_X_DEVKIT = 0x00000023;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_00 0x00000024")]
        public const int DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_00 = 0x00000024;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_01 0x00000025")]
        public const int DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_01 = 0x00000025;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_02 0x00000026")]
        public const int DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_02 = 0x00000026;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_03 0x00000027")]
        public const int DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_03 = 0x00000027;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_04 0x00000028")]
        public const int DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_04 = 0x00000028;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_05 0x00000029")]
        public const int DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_05 = 0x00000029;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_06 0x0000002A")]
        public const int DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_06 = 0x0000002A;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_07 0x0000002B")]
        public const int DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_07 = 0x0000002B;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_08 0x0000002C")]
        public const int DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_08 = 0x0000002C;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_09 0x0000002D")]
        public const int DEVICEFAMILYDEVICEFORM_XBOX_RESERVED_09 = 0x0000002D;

        [NativeTypeName("#define DEVICEFAMILYDEVICEFORM_MAX 0x0000002D")]
        public const int DEVICEFAMILYDEVICEFORM_MAX = 0x0000002D;

        [NativeTypeName("#define DLL_PROCESS_ATTACH 1")]
        public const int DLL_PROCESS_ATTACH = 1;

        [NativeTypeName("#define DLL_THREAD_ATTACH 2")]
        public const int DLL_THREAD_ATTACH = 2;

        [NativeTypeName("#define DLL_THREAD_DETACH 3")]
        public const int DLL_THREAD_DETACH = 3;

        [NativeTypeName("#define DLL_PROCESS_DETACH 0")]
        public const int DLL_PROCESS_DETACH = 0;

        [NativeTypeName("#define EVENTLOG_SEQUENTIAL_READ 0x0001")]
        public const int EVENTLOG_SEQUENTIAL_READ = 0x0001;

        [NativeTypeName("#define EVENTLOG_SEEK_READ 0x0002")]
        public const int EVENTLOG_SEEK_READ = 0x0002;

        [NativeTypeName("#define EVENTLOG_FORWARDS_READ 0x0004")]
        public const int EVENTLOG_FORWARDS_READ = 0x0004;

        [NativeTypeName("#define EVENTLOG_BACKWARDS_READ 0x0008")]
        public const int EVENTLOG_BACKWARDS_READ = 0x0008;

        [NativeTypeName("#define EVENTLOG_SUCCESS 0x0000")]
        public const int EVENTLOG_SUCCESS = 0x0000;

        [NativeTypeName("#define EVENTLOG_ERROR_TYPE 0x0001")]
        public const int EVENTLOG_ERROR_TYPE = 0x0001;

        [NativeTypeName("#define EVENTLOG_WARNING_TYPE 0x0002")]
        public const int EVENTLOG_WARNING_TYPE = 0x0002;

        [NativeTypeName("#define EVENTLOG_INFORMATION_TYPE 0x0004")]
        public const int EVENTLOG_INFORMATION_TYPE = 0x0004;

        [NativeTypeName("#define EVENTLOG_AUDIT_SUCCESS 0x0008")]
        public const int EVENTLOG_AUDIT_SUCCESS = 0x0008;

        [NativeTypeName("#define EVENTLOG_AUDIT_FAILURE 0x0010")]
        public const int EVENTLOG_AUDIT_FAILURE = 0x0010;

        [NativeTypeName("#define EVENTLOG_START_PAIRED_EVENT 0x0001")]
        public const int EVENTLOG_START_PAIRED_EVENT = 0x0001;

        [NativeTypeName("#define EVENTLOG_END_PAIRED_EVENT 0x0002")]
        public const int EVENTLOG_END_PAIRED_EVENT = 0x0002;

        [NativeTypeName("#define EVENTLOG_END_ALL_PAIRED_EVENTS 0x0004")]
        public const int EVENTLOG_END_ALL_PAIRED_EVENTS = 0x0004;

        [NativeTypeName("#define EVENTLOG_PAIRED_EVENT_ACTIVE 0x0008")]
        public const int EVENTLOG_PAIRED_EVENT_ACTIVE = 0x0008;

        [NativeTypeName("#define EVENTLOG_PAIRED_EVENT_INACTIVE 0x0010")]
        public const int EVENTLOG_PAIRED_EVENT_INACTIVE = 0x0010;

        [NativeTypeName("#define MAXLOGICALLOGNAMESIZE 256")]
        public const int MAXLOGICALLOGNAMESIZE = 256;

        [NativeTypeName("#define KEY_QUERY_VALUE (0x0001)")]
        public const int KEY_QUERY_VALUE = (0x0001);

        [NativeTypeName("#define KEY_SET_VALUE (0x0002)")]
        public const int KEY_SET_VALUE = (0x0002);

        [NativeTypeName("#define KEY_CREATE_SUB_KEY (0x0004)")]
        public const int KEY_CREATE_SUB_KEY = (0x0004);

        [NativeTypeName("#define KEY_ENUMERATE_SUB_KEYS (0x0008)")]
        public const int KEY_ENUMERATE_SUB_KEYS = (0x0008);

        [NativeTypeName("#define KEY_NOTIFY (0x0010)")]
        public const int KEY_NOTIFY = (0x0010);

        [NativeTypeName("#define KEY_CREATE_LINK (0x0020)")]
        public const int KEY_CREATE_LINK = (0x0020);

        [NativeTypeName("#define KEY_WOW64_32KEY (0x0200)")]
        public const int KEY_WOW64_32KEY = (0x0200);

        [NativeTypeName("#define KEY_WOW64_64KEY (0x0100)")]
        public const int KEY_WOW64_64KEY = (0x0100);

        [NativeTypeName("#define KEY_WOW64_RES (0x0300)")]
        public const int KEY_WOW64_RES = (0x0300);

        [NativeTypeName("#define KEY_READ ((STANDARD_RIGHTS_READ       |\\\r\n                                  KEY_QUERY_VALUE            |\\\r\n                                  KEY_ENUMERATE_SUB_KEYS     |\\\r\n                                  KEY_NOTIFY)                 \\\r\n                                  &                           \\\r\n                                 (~SYNCHRONIZE))")]
        public const int KEY_READ = ((((0x00020000)) | (0x0001) | (0x0008) | (0x0010)) & (~(0x00100000)));

        [NativeTypeName("#define KEY_WRITE ((STANDARD_RIGHTS_WRITE      |\\\r\n                                  KEY_SET_VALUE              |\\\r\n                                  KEY_CREATE_SUB_KEY)         \\\r\n                                  &                           \\\r\n                                 (~SYNCHRONIZE))")]
        public const int KEY_WRITE = ((((0x00020000)) | (0x0002) | (0x0004)) & (~(0x00100000)));

        [NativeTypeName("#define KEY_EXECUTE ((KEY_READ)                   \\\r\n                                  &                           \\\r\n                                 (~SYNCHRONIZE))")]
        public const int KEY_EXECUTE = ((((((0x00020000)) | (0x0001) | (0x0008) | (0x0010)) & (~(0x00100000)))) & (~(0x00100000)));

        [NativeTypeName("#define KEY_ALL_ACCESS ((STANDARD_RIGHTS_ALL        |\\\r\n                                  KEY_QUERY_VALUE            |\\\r\n                                  KEY_SET_VALUE              |\\\r\n                                  KEY_CREATE_SUB_KEY         |\\\r\n                                  KEY_ENUMERATE_SUB_KEYS     |\\\r\n                                  KEY_NOTIFY                 |\\\r\n                                  KEY_CREATE_LINK)            \\\r\n                                  &                           \\\r\n                                 (~SYNCHRONIZE))")]
        public const int KEY_ALL_ACCESS = (((0x001F0000) | (0x0001) | (0x0002) | (0x0004) | (0x0008) | (0x0010) | (0x0020)) & (~(0x00100000)));

        [NativeTypeName("#define SERVICE_KERNEL_DRIVER 0x00000001")]
        public const int SERVICE_KERNEL_DRIVER = 0x00000001;

        [NativeTypeName("#define SERVICE_FILE_SYSTEM_DRIVER 0x00000002")]
        public const int SERVICE_FILE_SYSTEM_DRIVER = 0x00000002;

        [NativeTypeName("#define SERVICE_ADAPTER 0x00000004")]
        public const int SERVICE_ADAPTER = 0x00000004;

        [NativeTypeName("#define SERVICE_RECOGNIZER_DRIVER 0x00000008")]
        public const int SERVICE_RECOGNIZER_DRIVER = 0x00000008;

        [NativeTypeName("#define SERVICE_DRIVER (SERVICE_KERNEL_DRIVER | \\\r\n                                        SERVICE_FILE_SYSTEM_DRIVER | \\\r\n                                        SERVICE_RECOGNIZER_DRIVER)")]
        public const int SERVICE_DRIVER = (0x00000001 | 0x00000002 | 0x00000008);

        [NativeTypeName("#define SERVICE_WIN32_OWN_PROCESS 0x00000010")]
        public const int SERVICE_WIN32_OWN_PROCESS = 0x00000010;

        [NativeTypeName("#define SERVICE_WIN32_SHARE_PROCESS 0x00000020")]
        public const int SERVICE_WIN32_SHARE_PROCESS = 0x00000020;

        [NativeTypeName("#define SERVICE_WIN32 (SERVICE_WIN32_OWN_PROCESS | \\\r\n                                        SERVICE_WIN32_SHARE_PROCESS)")]
        public const int SERVICE_WIN32 = (0x00000010 | 0x00000020);

        [NativeTypeName("#define SERVICE_USER_SERVICE 0x00000040")]
        public const int SERVICE_USER_SERVICE = 0x00000040;

        [NativeTypeName("#define SERVICE_USERSERVICE_INSTANCE 0x00000080")]
        public const int SERVICE_USERSERVICE_INSTANCE = 0x00000080;

        [NativeTypeName("#define SERVICE_USER_SHARE_PROCESS (SERVICE_USER_SERVICE | \\\r\n                                        SERVICE_WIN32_SHARE_PROCESS)")]
        public const int SERVICE_USER_SHARE_PROCESS = (0x00000040 | 0x00000020);

        [NativeTypeName("#define SERVICE_USER_OWN_PROCESS (SERVICE_USER_SERVICE | \\\r\n                                        SERVICE_WIN32_OWN_PROCESS)")]
        public const int SERVICE_USER_OWN_PROCESS = (0x00000040 | 0x00000010);

        [NativeTypeName("#define SERVICE_INTERACTIVE_PROCESS 0x00000100")]
        public const int SERVICE_INTERACTIVE_PROCESS = 0x00000100;

        [NativeTypeName("#define SERVICE_PKG_SERVICE 0x00000200")]
        public const int SERVICE_PKG_SERVICE = 0x00000200;

        [NativeTypeName("#define SERVICE_TYPE_ALL (SERVICE_WIN32  | \\\r\n                                        SERVICE_ADAPTER | \\\r\n                                        SERVICE_DRIVER  | \\\r\n                                        SERVICE_INTERACTIVE_PROCESS | \\\r\n                                        SERVICE_USER_SERVICE | \\\r\n                                        SERVICE_USERSERVICE_INSTANCE | \\\r\n                                        SERVICE_PKG_SERVICE)")]
        public const int SERVICE_TYPE_ALL = ((0x00000010 | 0x00000020) | 0x00000004 | (0x00000001 | 0x00000002 | 0x00000008) | 0x00000100 | 0x00000040 | 0x00000080 | 0x00000200);

        [NativeTypeName("#define SERVICE_BOOT_START 0x00000000")]
        public const int SERVICE_BOOT_START = 0x00000000;

        [NativeTypeName("#define SERVICE_SYSTEM_START 0x00000001")]
        public const int SERVICE_SYSTEM_START = 0x00000001;

        [NativeTypeName("#define SERVICE_AUTO_START 0x00000002")]
        public const int SERVICE_AUTO_START = 0x00000002;

        [NativeTypeName("#define SERVICE_DEMAND_START 0x00000003")]
        public const int SERVICE_DEMAND_START = 0x00000003;

        [NativeTypeName("#define SERVICE_DISABLED 0x00000004")]
        public const int SERVICE_DISABLED = 0x00000004;

        [NativeTypeName("#define SERVICE_ERROR_IGNORE 0x00000000")]
        public const int SERVICE_ERROR_IGNORE = 0x00000000;

        [NativeTypeName("#define SERVICE_ERROR_NORMAL 0x00000001")]
        public const int SERVICE_ERROR_NORMAL = 0x00000001;

        [NativeTypeName("#define SERVICE_ERROR_SEVERE 0x00000002")]
        public const int SERVICE_ERROR_SEVERE = 0x00000002;

        [NativeTypeName("#define SERVICE_ERROR_CRITICAL 0x00000003")]
        public const int SERVICE_ERROR_CRITICAL = 0x00000003;

        [NativeTypeName("#define CM_SERVICE_NETWORK_BOOT_LOAD 0x00000001")]
        public const int CM_SERVICE_NETWORK_BOOT_LOAD = 0x00000001;

        [NativeTypeName("#define CM_SERVICE_VIRTUAL_DISK_BOOT_LOAD 0x00000002")]
        public const int CM_SERVICE_VIRTUAL_DISK_BOOT_LOAD = 0x00000002;

        [NativeTypeName("#define CM_SERVICE_USB_DISK_BOOT_LOAD 0x00000004")]
        public const int CM_SERVICE_USB_DISK_BOOT_LOAD = 0x00000004;

        [NativeTypeName("#define CM_SERVICE_SD_DISK_BOOT_LOAD 0x00000008")]
        public const int CM_SERVICE_SD_DISK_BOOT_LOAD = 0x00000008;

        [NativeTypeName("#define CM_SERVICE_USB3_DISK_BOOT_LOAD 0x00000010")]
        public const int CM_SERVICE_USB3_DISK_BOOT_LOAD = 0x00000010;

        [NativeTypeName("#define CM_SERVICE_MEASURED_BOOT_LOAD 0x00000020")]
        public const int CM_SERVICE_MEASURED_BOOT_LOAD = 0x00000020;

        [NativeTypeName("#define CM_SERVICE_VERIFIER_BOOT_LOAD 0x00000040")]
        public const int CM_SERVICE_VERIFIER_BOOT_LOAD = 0x00000040;

        [NativeTypeName("#define CM_SERVICE_WINPE_BOOT_LOAD 0x00000080")]
        public const int CM_SERVICE_WINPE_BOOT_LOAD = 0x00000080;

        [NativeTypeName("#define CM_SERVICE_RAM_DISK_BOOT_LOAD 0x00000100")]
        public const int CM_SERVICE_RAM_DISK_BOOT_LOAD = 0x00000100;

        [NativeTypeName("#define CM_SERVICE_VALID_PROMOTION_MASK (CM_SERVICE_NETWORK_BOOT_LOAD |       \\\r\n                                         CM_SERVICE_VIRTUAL_DISK_BOOT_LOAD |  \\\r\n                                         CM_SERVICE_USB_DISK_BOOT_LOAD |      \\\r\n                                         CM_SERVICE_SD_DISK_BOOT_LOAD |       \\\r\n                                         CM_SERVICE_USB3_DISK_BOOT_LOAD |     \\\r\n                                         CM_SERVICE_MEASURED_BOOT_LOAD |      \\\r\n                                         CM_SERVICE_VERIFIER_BOOT_LOAD |      \\\r\n                                         CM_SERVICE_WINPE_BOOT_LOAD |         \\\r\n                                         CM_SERVICE_RAM_DISK_BOOT_LOAD)")]
        public const int CM_SERVICE_VALID_PROMOTION_MASK = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008 | 0x00000010 | 0x00000020 | 0x00000040 | 0x00000080 | 0x00000100);

        [NativeTypeName("#define TRANSACTIONMANAGER_QUERY_INFORMATION ( 0x0001 )")]
        public const int TRANSACTIONMANAGER_QUERY_INFORMATION = (0x0001);

        [NativeTypeName("#define TRANSACTIONMANAGER_SET_INFORMATION ( 0x0002 )")]
        public const int TRANSACTIONMANAGER_SET_INFORMATION = (0x0002);

        [NativeTypeName("#define TRANSACTIONMANAGER_RECOVER ( 0x0004 )")]
        public const int TRANSACTIONMANAGER_RECOVER = (0x0004);

        [NativeTypeName("#define TRANSACTIONMANAGER_RENAME ( 0x0008 )")]
        public const int TRANSACTIONMANAGER_RENAME = (0x0008);

        [NativeTypeName("#define TRANSACTIONMANAGER_CREATE_RM ( 0x0010 )")]
        public const int TRANSACTIONMANAGER_CREATE_RM = (0x0010);

        [NativeTypeName("#define TRANSACTIONMANAGER_BIND_TRANSACTION ( 0x0020 )")]
        public const int TRANSACTIONMANAGER_BIND_TRANSACTION = (0x0020);

        [NativeTypeName("#define TRANSACTIONMANAGER_GENERIC_READ (STANDARD_RIGHTS_READ            |\\\r\n                                                    TRANSACTIONMANAGER_QUERY_INFORMATION)")]
        public const int TRANSACTIONMANAGER_GENERIC_READ = (((0x00020000)) | (0x0001));

        [NativeTypeName("#define TRANSACTIONMANAGER_GENERIC_WRITE (STANDARD_RIGHTS_WRITE           |\\\r\n                                                    TRANSACTIONMANAGER_SET_INFORMATION     |\\\r\n                                                    TRANSACTIONMANAGER_RECOVER             |\\\r\n                                                    TRANSACTIONMANAGER_RENAME              |\\\r\n                                                    TRANSACTIONMANAGER_CREATE_RM)")]
        public const int TRANSACTIONMANAGER_GENERIC_WRITE = (((0x00020000)) | (0x0002) | (0x0004) | (0x0008) | (0x0010));

        [NativeTypeName("#define TRANSACTIONMANAGER_GENERIC_EXECUTE (STANDARD_RIGHTS_EXECUTE)")]
        public const int TRANSACTIONMANAGER_GENERIC_EXECUTE = (((0x00020000)));

        [NativeTypeName("#define TRANSACTIONMANAGER_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED        |\\\r\n                                                    TRANSACTIONMANAGER_GENERIC_READ        |\\\r\n                                                    TRANSACTIONMANAGER_GENERIC_WRITE       |\\\r\n                                                    TRANSACTIONMANAGER_GENERIC_EXECUTE     |\\\r\n                                                    TRANSACTIONMANAGER_BIND_TRANSACTION)")]
        public const int TRANSACTIONMANAGER_ALL_ACCESS = ((0x000F0000) | (((0x00020000)) | (0x0001)) | (((0x00020000)) | (0x0002) | (0x0004) | (0x0008) | (0x0010)) | (((0x00020000))) | (0x0020));

        [NativeTypeName("#define RESOURCEMANAGER_QUERY_INFORMATION ( 0x0001 )")]
        public const int RESOURCEMANAGER_QUERY_INFORMATION = (0x0001);

        [NativeTypeName("#define RESOURCEMANAGER_SET_INFORMATION ( 0x0002 )")]
        public const int RESOURCEMANAGER_SET_INFORMATION = (0x0002);

        [NativeTypeName("#define RESOURCEMANAGER_RECOVER ( 0x0004 )")]
        public const int RESOURCEMANAGER_RECOVER = (0x0004);

        [NativeTypeName("#define RESOURCEMANAGER_ENLIST ( 0x0008 )")]
        public const int RESOURCEMANAGER_ENLIST = (0x0008);

        [NativeTypeName("#define RESOURCEMANAGER_GET_NOTIFICATION ( 0x0010 )")]
        public const int RESOURCEMANAGER_GET_NOTIFICATION = (0x0010);

        [NativeTypeName("#define RESOURCEMANAGER_REGISTER_PROTOCOL ( 0x0020 )")]
        public const int RESOURCEMANAGER_REGISTER_PROTOCOL = (0x0020);

        [NativeTypeName("#define RESOURCEMANAGER_COMPLETE_PROPAGATION ( 0x0040 )")]
        public const int RESOURCEMANAGER_COMPLETE_PROPAGATION = (0x0040);

        [NativeTypeName("#define RESOURCEMANAGER_GENERIC_READ (STANDARD_RIGHTS_READ                 |\\\r\n                                             RESOURCEMANAGER_QUERY_INFORMATION    |\\\r\n                                             SYNCHRONIZE)")]
        public const int RESOURCEMANAGER_GENERIC_READ = (((0x00020000)) | (0x0001) | (0x00100000));

        [NativeTypeName("#define RESOURCEMANAGER_GENERIC_WRITE (STANDARD_RIGHTS_WRITE                |\\\r\n                                             RESOURCEMANAGER_SET_INFORMATION      |\\\r\n                                             RESOURCEMANAGER_RECOVER              |\\\r\n                                             RESOURCEMANAGER_ENLIST               |\\\r\n                                             RESOURCEMANAGER_GET_NOTIFICATION     |\\\r\n                                             RESOURCEMANAGER_REGISTER_PROTOCOL    |\\\r\n                                             RESOURCEMANAGER_COMPLETE_PROPAGATION |\\\r\n                                             SYNCHRONIZE)")]
        public const int RESOURCEMANAGER_GENERIC_WRITE = (((0x00020000)) | (0x0002) | (0x0004) | (0x0008) | (0x0010) | (0x0020) | (0x0040) | (0x00100000));

        [NativeTypeName("#define RESOURCEMANAGER_GENERIC_EXECUTE (STANDARD_RIGHTS_EXECUTE              |\\\r\n                                             RESOURCEMANAGER_RECOVER              |\\\r\n                                             RESOURCEMANAGER_ENLIST               |\\\r\n                                             RESOURCEMANAGER_GET_NOTIFICATION     |\\\r\n                                             RESOURCEMANAGER_COMPLETE_PROPAGATION |\\\r\n                                             SYNCHRONIZE)")]
        public const int RESOURCEMANAGER_GENERIC_EXECUTE = (((0x00020000)) | (0x0004) | (0x0008) | (0x0010) | (0x0040) | (0x00100000));

        [NativeTypeName("#define RESOURCEMANAGER_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED             |\\\r\n                                             RESOURCEMANAGER_GENERIC_READ         |\\\r\n                                             RESOURCEMANAGER_GENERIC_WRITE        |\\\r\n                                             RESOURCEMANAGER_GENERIC_EXECUTE)")]
        public const int RESOURCEMANAGER_ALL_ACCESS = ((0x000F0000) | (((0x00020000)) | (0x0001) | (0x00100000)) | (((0x00020000)) | (0x0002) | (0x0004) | (0x0008) | (0x0010) | (0x0020) | (0x0040) | (0x00100000)) | (((0x00020000)) | (0x0004) | (0x0008) | (0x0010) | (0x0040) | (0x00100000)));

        [NativeTypeName("#define ENLISTMENT_QUERY_INFORMATION ( 0x0001 )")]
        public const int ENLISTMENT_QUERY_INFORMATION = (0x0001);

        [NativeTypeName("#define ENLISTMENT_SET_INFORMATION ( 0x0002 )")]
        public const int ENLISTMENT_SET_INFORMATION = (0x0002);

        [NativeTypeName("#define ENLISTMENT_RECOVER ( 0x0004 )")]
        public const int ENLISTMENT_RECOVER = (0x0004);

        [NativeTypeName("#define ENLISTMENT_SUBORDINATE_RIGHTS ( 0x0008 )")]
        public const int ENLISTMENT_SUBORDINATE_RIGHTS = (0x0008);

        [NativeTypeName("#define ENLISTMENT_SUPERIOR_RIGHTS ( 0x0010 )")]
        public const int ENLISTMENT_SUPERIOR_RIGHTS = (0x0010);

        [NativeTypeName("#define ENLISTMENT_GENERIC_READ (STANDARD_RIGHTS_READ           |\\\r\n                                        ENLISTMENT_QUERY_INFORMATION)")]
        public const int ENLISTMENT_GENERIC_READ = (((0x00020000)) | (0x0001));

        [NativeTypeName("#define ENLISTMENT_GENERIC_WRITE (STANDARD_RIGHTS_WRITE          |\\\r\n                                        ENLISTMENT_SET_INFORMATION     |\\\r\n                                        ENLISTMENT_RECOVER             |\\\r\n                                        ENLISTMENT_SUBORDINATE_RIGHTS  |\\\r\n                                        ENLISTMENT_SUPERIOR_RIGHTS)")]
        public const int ENLISTMENT_GENERIC_WRITE = (((0x00020000)) | (0x0002) | (0x0004) | (0x0008) | (0x0010));

        [NativeTypeName("#define ENLISTMENT_GENERIC_EXECUTE (STANDARD_RIGHTS_EXECUTE        |\\\r\n                                        ENLISTMENT_RECOVER             |\\\r\n                                        ENLISTMENT_SUBORDINATE_RIGHTS  |\\\r\n                                        ENLISTMENT_SUPERIOR_RIGHTS)")]
        public const int ENLISTMENT_GENERIC_EXECUTE = (((0x00020000)) | (0x0004) | (0x0008) | (0x0010));

        [NativeTypeName("#define ENLISTMENT_ALL_ACCESS (STANDARD_RIGHTS_REQUIRED       |\\\r\n                                        ENLISTMENT_GENERIC_READ        |\\\r\n                                        ENLISTMENT_GENERIC_WRITE       |\\\r\n                                        ENLISTMENT_GENERIC_EXECUTE)")]
        public const int ENLISTMENT_ALL_ACCESS = ((0x000F0000) | (((0x00020000)) | (0x0001)) | (((0x00020000)) | (0x0002) | (0x0004) | (0x0008) | (0x0010)) | (((0x00020000)) | (0x0004) | (0x0008) | (0x0010)));

        [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_ASSEMBLY_INFORMATION (1)")]
        public const int ACTIVATION_CONTEXT_SECTION_ASSEMBLY_INFORMATION = (1);

        [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_DLL_REDIRECTION (2)")]
        public const int ACTIVATION_CONTEXT_SECTION_DLL_REDIRECTION = (2);

        [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_WINDOW_CLASS_REDIRECTION (3)")]
        public const int ACTIVATION_CONTEXT_SECTION_WINDOW_CLASS_REDIRECTION = (3);

        [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_COM_SERVER_REDIRECTION (4)")]
        public const int ACTIVATION_CONTEXT_SECTION_COM_SERVER_REDIRECTION = (4);

        [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_COM_INTERFACE_REDIRECTION (5)")]
        public const int ACTIVATION_CONTEXT_SECTION_COM_INTERFACE_REDIRECTION = (5);

        [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_COM_TYPE_LIBRARY_REDIRECTION (6)")]
        public const int ACTIVATION_CONTEXT_SECTION_COM_TYPE_LIBRARY_REDIRECTION = (6);

        [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_COM_PROGID_REDIRECTION (7)")]
        public const int ACTIVATION_CONTEXT_SECTION_COM_PROGID_REDIRECTION = (7);

        [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_GLOBAL_OBJECT_RENAME_TABLE (8)")]
        public const int ACTIVATION_CONTEXT_SECTION_GLOBAL_OBJECT_RENAME_TABLE = (8);

        [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_CLR_SURROGATES (9)")]
        public const int ACTIVATION_CONTEXT_SECTION_CLR_SURROGATES = (9);

        [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_APPLICATION_SETTINGS (10)")]
        public const int ACTIVATION_CONTEXT_SECTION_APPLICATION_SETTINGS = (10);

        [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_COMPATIBILITY_INFO (11)")]
        public const int ACTIVATION_CONTEXT_SECTION_COMPATIBILITY_INFO = (11);

        [NativeTypeName("#define ACTIVATION_CONTEXT_SECTION_WINRT_ACTIVATABLE_CLASSES (12)")]
        public const int ACTIVATION_CONTEXT_SECTION_WINRT_ACTIVATABLE_CLASSES = (12);
    }
}
