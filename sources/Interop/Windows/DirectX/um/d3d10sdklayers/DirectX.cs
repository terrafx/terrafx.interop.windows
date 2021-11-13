// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10sdklayers.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX
{
    public static partial class DirectX
    {
        [NativeTypeName("const GUID")]
        public static ref readonly Guid DXGI_DEBUG_D3D10
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x52, 0x4C, 0x3B, 0x24,
                    0x06, 0x36,
                    0x3A, 0x4D,
                    0x99,
                    0xD7,
                    0xA7,
                    0xE7,
                    0xB3,
                    0x3E,
                    0xD7,
                    0x06
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D10Debug
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x01, 0x4E, 0x7E, 0x9B,
                    0x2C, 0x34,
                    0x06, 0x41,
                    0xA1,
                    0x9F,
                    0x4F,
                    0x27,
                    0x04,
                    0xF6,
                    0x89,
                    0xF0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D10SwitchToRef
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x02, 0x4E, 0x7E, 0x9B,
                    0x2C, 0x34,
                    0x06, 0x41,
                    0xA1,
                    0x9F,
                    0x4F,
                    0x27,
                    0x04,
                    0xF6,
                    0x89,
                    0xF0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D10InfoQueue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x17, 0x0B, 0x94, 0x1B,
                    0x42, 0x26,
                    0x1F, 0x4D,
                    0xAB,
                    0x1F,
                    0xB9,
                    0x9B,
                    0xAD,
                    0x0C,
                    0x39,
                    0x5F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("#define D3D10_SDK_LAYERS_VERSION ( 11 )")]
        public const int D3D10_SDK_LAYERS_VERSION = (11);

        [NativeTypeName("#define D3D10_DEBUG_FEATURE_FLUSH_PER_RENDER_OP ( 0x1 )")]
        public const int D3D10_DEBUG_FEATURE_FLUSH_PER_RENDER_OP = (0x1);

        [NativeTypeName("#define D3D10_DEBUG_FEATURE_FINISH_PER_RENDER_OP ( 0x2 )")]
        public const int D3D10_DEBUG_FEATURE_FINISH_PER_RENDER_OP = (0x2);

        [NativeTypeName("#define D3D10_DEBUG_FEATURE_PRESENT_PER_RENDER_OP ( 0x4 )")]
        public const int D3D10_DEBUG_FEATURE_PRESENT_PER_RENDER_OP = (0x4);

        [NativeTypeName("#define D3D10_REGKEY_PATH __TEXT(\"Software\\\\Microsoft\\\\Direct3D\")")]
        public const string D3D10_REGKEY_PATH = "Software\\Microsoft\\Direct3D";

        [NativeTypeName("#define D3D10_MUTE_DEBUG_OUTPUT __TEXT(\"MuteDebugOutput\")")]
        public const string D3D10_MUTE_DEBUG_OUTPUT = "MuteDebugOutput";

        [NativeTypeName("#define D3D10_ENABLE_BREAK_ON_MESSAGE __TEXT(\"EnableBreakOnMessage\")")]
        public const string D3D10_ENABLE_BREAK_ON_MESSAGE = "EnableBreakOnMessage";

        [NativeTypeName("#define D3D10_INFOQUEUE_STORAGE_FILTER_OVERRIDE __TEXT(\"InfoQueueStorageFilterOverride\")")]
        public const string D3D10_INFOQUEUE_STORAGE_FILTER_OVERRIDE = "InfoQueueStorageFilterOverride";

        [NativeTypeName("#define D3D10_MUTE_CATEGORY __TEXT(\"Mute_CATEGORY_%s\")")]
        public const string D3D10_MUTE_CATEGORY = "Mute_CATEGORY_%s";

        [NativeTypeName("#define D3D10_MUTE_SEVERITY __TEXT(\"Mute_SEVERITY_%s\")")]
        public const string D3D10_MUTE_SEVERITY = "Mute_SEVERITY_%s";

        [NativeTypeName("#define D3D10_MUTE_ID_STRING __TEXT(\"Mute_ID_%s\")")]
        public const string D3D10_MUTE_ID_STRING = "Mute_ID_%s";

        [NativeTypeName("#define D3D10_MUTE_ID_DECIMAL __TEXT(\"Mute_ID_%d\")")]
        public const string D3D10_MUTE_ID_DECIMAL = "Mute_ID_%d";

        [NativeTypeName("#define D3D10_UNMUTE_SEVERITY_INFO __TEXT(\"Unmute_SEVERITY_INFO\")")]
        public const string D3D10_UNMUTE_SEVERITY_INFO = "Unmute_SEVERITY_INFO";

        [NativeTypeName("#define D3D10_BREAKON_CATEGORY __TEXT(\"BreakOn_CATEGORY_%s\")")]
        public const string D3D10_BREAKON_CATEGORY = "BreakOn_CATEGORY_%s";

        [NativeTypeName("#define D3D10_BREAKON_SEVERITY __TEXT(\"BreakOn_SEVERITY_%s\")")]
        public const string D3D10_BREAKON_SEVERITY = "BreakOn_SEVERITY_%s";

        [NativeTypeName("#define D3D10_BREAKON_ID_STRING __TEXT(\"BreakOn_ID_%s\")")]
        public const string D3D10_BREAKON_ID_STRING = "BreakOn_ID_%s";

        [NativeTypeName("#define D3D10_BREAKON_ID_DECIMAL __TEXT(\"BreakOn_ID_%d\")")]
        public const string D3D10_BREAKON_ID_DECIMAL = "BreakOn_ID_%d";

        [NativeTypeName("#define D3D10_APPSIZE_STRING __TEXT(\"Size\")")]
        public const string D3D10_APPSIZE_STRING = "Size";

        [NativeTypeName("#define D3D10_APPNAME_STRING __TEXT(\"Name\")")]
        public const string D3D10_APPNAME_STRING = "Name";

        [NativeTypeName("#define D3D10_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT 1024")]
        public const int D3D10_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT = 1024;
    }
}
