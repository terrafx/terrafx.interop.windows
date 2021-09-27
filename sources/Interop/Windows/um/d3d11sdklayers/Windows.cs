// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static ref readonly Guid DXGI_DEBUG_D3D11
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7B, 0x31, 0x99, 0x4B,
                    0x39, 0xAC,
                    0xA6, 0x4A,
                    0xBB,
                    0x0B,
                    0xBA,
                    0xA0,
                    0x47,
                    0x84,
                    0x79,
                    0x8F
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D11Debug
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x33, 0x22, 0xCF, 0x79,
                    0x36, 0x75,
                    0x48, 0x49,
                    0x9D,
                    0x36,
                    0x1E,
                    0x46,
                    0x92,
                    0xDC,
                    0x57,
                    0x60
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D11SwitchToRef
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE3, 0x37, 0xF3, 0x1E,
                    0xE7, 0x58,
                    0x83, 0x4F,
                    0xA6,
                    0x92,
                    0xDB,
                    0x22,
                    0x1F,
                    0x5E,
                    0xD4,
                    0x7E
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D11TracingDevice
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x71, 0xC7, 0x11, 0x19,
                    0x87, 0x15,
                    0x3E, 0x41,
                    0xA7,
                    0xE0,
                    0xFB,
                    0x26,
                    0xC3,
                    0xDE,
                    0x02,
                    0x68
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D11RefTrackingOptions
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDF, 0xAC, 0x3D, 0x19,
                    0xB2, 0x0D,
                    0x05, 0x4C,
                    0xA5,
                    0x5C,
                    0xEF,
                    0x06,
                    0xCA,
                    0xC5,
                    0x6F,
                    0xD9
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D11RefDefaultTrackingOptions
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x15, 0x66, 0x91, 0x03,
                    0x44, 0xC6,
                    0x8C, 0x41,
                    0x9B,
                    0xF4,
                    0x75,
                    0xDB,
                    0x5B,
                    0xE6,
                    0x3C,
                    0xA0
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D11InfoQueue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB6, 0xDB, 0x43, 0x65,
                    0x48, 0x1B,
                    0xF5, 0x42,
                    0xAB,
                    0x82,
                    0xE9,
                    0x7E,
                    0xC7,
                    0x43,
                    0x26,
                    0xF6
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("#define D3D11_SDK_LAYERS_VERSION ( 1 )")]
        public const int D3D11_SDK_LAYERS_VERSION = (1);

        [NativeTypeName("#define D3D11_DEBUG_FEATURE_FLUSH_PER_RENDER_OP ( 0x1 )")]
        public const int D3D11_DEBUG_FEATURE_FLUSH_PER_RENDER_OP = (0x1);

        [NativeTypeName("#define D3D11_DEBUG_FEATURE_FINISH_PER_RENDER_OP ( 0x2 )")]
        public const int D3D11_DEBUG_FEATURE_FINISH_PER_RENDER_OP = (0x2);

        [NativeTypeName("#define D3D11_DEBUG_FEATURE_PRESENT_PER_RENDER_OP ( 0x4 )")]
        public const int D3D11_DEBUG_FEATURE_PRESENT_PER_RENDER_OP = (0x4);

        [NativeTypeName("#define D3D11_DEBUG_FEATURE_ALWAYS_DISCARD_OFFERED_RESOURCE ( 0x8 )")]
        public const int D3D11_DEBUG_FEATURE_ALWAYS_DISCARD_OFFERED_RESOURCE = (0x8);

        [NativeTypeName("#define D3D11_DEBUG_FEATURE_NEVER_DISCARD_OFFERED_RESOURCE ( 0x10 )")]
        public const int D3D11_DEBUG_FEATURE_NEVER_DISCARD_OFFERED_RESOURCE = (0x10);

        [NativeTypeName("#define D3D11_DEBUG_FEATURE_AVOID_BEHAVIOR_CHANGING_DEBUG_AIDS ( 0x40 )")]
        public const int D3D11_DEBUG_FEATURE_AVOID_BEHAVIOR_CHANGING_DEBUG_AIDS = (0x40);

        [NativeTypeName("#define D3D11_DEBUG_FEATURE_DISABLE_TILED_RESOURCE_MAPPING_TRACKING_AND_VALIDATION ( 0x80 )")]
        public const int D3D11_DEBUG_FEATURE_DISABLE_TILED_RESOURCE_MAPPING_TRACKING_AND_VALIDATION = (0x80);

        [NativeTypeName("#define D3D11_REGKEY_PATH __TEXT(\"Software\\\\Microsoft\\\\Direct3D\")")]
        public const string D3D11_REGKEY_PATH = "Software\\Microsoft\\Direct3D";

        [NativeTypeName("#define D3D11_MUTE_DEBUG_OUTPUT __TEXT(\"MuteDebugOutput\")")]
        public const string D3D11_MUTE_DEBUG_OUTPUT = "MuteDebugOutput";

        [NativeTypeName("#define D3D11_ENABLE_BREAK_ON_MESSAGE __TEXT(\"EnableBreakOnMessage\")")]
        public const string D3D11_ENABLE_BREAK_ON_MESSAGE = "EnableBreakOnMessage";

        [NativeTypeName("#define D3D11_INFOQUEUE_STORAGE_FILTER_OVERRIDE __TEXT(\"InfoQueueStorageFilterOverride\")")]
        public const string D3D11_INFOQUEUE_STORAGE_FILTER_OVERRIDE = "InfoQueueStorageFilterOverride";

        [NativeTypeName("#define D3D11_MUTE_CATEGORY __TEXT(\"Mute_CATEGORY_%s\")")]
        public const string D3D11_MUTE_CATEGORY = "Mute_CATEGORY_%s";

        [NativeTypeName("#define D3D11_MUTE_SEVERITY __TEXT(\"Mute_SEVERITY_%s\")")]
        public const string D3D11_MUTE_SEVERITY = "Mute_SEVERITY_%s";

        [NativeTypeName("#define D3D11_MUTE_ID_STRING __TEXT(\"Mute_ID_%s\")")]
        public const string D3D11_MUTE_ID_STRING = "Mute_ID_%s";

        [NativeTypeName("#define D3D11_MUTE_ID_DECIMAL __TEXT(\"Mute_ID_%d\")")]
        public const string D3D11_MUTE_ID_DECIMAL = "Mute_ID_%d";

        [NativeTypeName("#define D3D11_UNMUTE_SEVERITY_INFO __TEXT(\"Unmute_SEVERITY_INFO\")")]
        public const string D3D11_UNMUTE_SEVERITY_INFO = "Unmute_SEVERITY_INFO";

        [NativeTypeName("#define D3D11_BREAKON_CATEGORY __TEXT(\"BreakOn_CATEGORY_%s\")")]
        public const string D3D11_BREAKON_CATEGORY = "BreakOn_CATEGORY_%s";

        [NativeTypeName("#define D3D11_BREAKON_SEVERITY __TEXT(\"BreakOn_SEVERITY_%s\")")]
        public const string D3D11_BREAKON_SEVERITY = "BreakOn_SEVERITY_%s";

        [NativeTypeName("#define D3D11_BREAKON_ID_STRING __TEXT(\"BreakOn_ID_%s\")")]
        public const string D3D11_BREAKON_ID_STRING = "BreakOn_ID_%s";

        [NativeTypeName("#define D3D11_BREAKON_ID_DECIMAL __TEXT(\"BreakOn_ID_%d\")")]
        public const string D3D11_BREAKON_ID_DECIMAL = "BreakOn_ID_%d";

        [NativeTypeName("#define D3D11_APPSIZE_STRING __TEXT(\"Size\")")]
        public const string D3D11_APPSIZE_STRING = "Size";

        [NativeTypeName("#define D3D11_APPNAME_STRING __TEXT(\"Name\")")]
        public const string D3D11_APPNAME_STRING = "Name";

        [NativeTypeName("#define D3D11_FORCE_DEBUGGABLE __TEXT(\"ForceDebuggable\")")]
        public const string D3D11_FORCE_DEBUGGABLE = "ForceDebuggable";

        [NativeTypeName("#define D3D11_FORCE_SHADER_SKIP_OPTIMIZATION __TEXT(\"ForceShaderSkipOptimization\")")]
        public const string D3D11_FORCE_SHADER_SKIP_OPTIMIZATION = "ForceShaderSkipOptimization";

        [NativeTypeName("#define D3D11_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT 1024")]
        public const int D3D11_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT = 1024;
    }
}
