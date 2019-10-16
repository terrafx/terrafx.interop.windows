// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class D3D11
    {
        public const uint D3D11_DEBUG_FEATURE_FLUSH_PER_RENDER_OP = 0x1;

        public const uint D3D11_DEBUG_FEATURE_FINISH_PER_RENDER_OP = 0x2;

        public const uint D3D11_DEBUG_FEATURE_PRESENT_PER_RENDER_OP = 0x4;

        public const uint D3D11_DEBUG_FEATURE_ALWAYS_DISCARD_OFFERED_RESOURCE = 0x8;

        public const uint D3D11_DEBUG_FEATURE_NEVER_DISCARD_OFFERED_RESOURCE = 0x10;

        public const uint D3D11_DEBUG_FEATURE_AVOID_BEHAVIOR_CHANGING_DEBUG_AIDS = 0x40;

        public const uint D3D11_DEBUG_FEATURE_DISABLE_TILED_RESOURCE_MAPPING_TRACKING_AND_VALIDATION = 0x80;

        public const uint D3D11_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT = 1024;

        public const string D3D11_REGKEY_PATH = "Software\\Microsoft\\Direct3D";

        public const string D3D11_MUTE_DEBUG_OUTPUT = "MuteDebugOutput";

        public const string D3D11_ENABLE_BREAK_ON_MESSAGE = "EnableBreakOnMessage";

        public const string D3D11_INFOQUEUE_STORAGE_FILTER_OVERRIDE = "InfoQueueStorageFilterOverride";

        public const string D3D11_MUTE_CATEGORY = "Mute_CATEGORY_%s";

        public const string D3D11_MUTE_SEVERITY = "Mute_SEVERITY_%s";

        public const string D3D11_MUTE_ID_STRING = "Mute_ID_%s";

        public const string D3D11_MUTE_ID_DECIMAL = "Mute_ID_%d";

        public const string D3D11_UNMUTE_SEVERITY_INFO = "Unmute_SEVERITY_INFO";

        public const string D3D11_BREAKON_CATEGORY = "BreakOn_CATEGORY_%s";

        public const string D3D11_BREAKON_SEVERITY = "BreakOn_SEVERITY_%s";

        public const string D3D11_BREAKON_ID_STRING = "BreakOn_ID_%s";

        public const string D3D11_BREAKON_ID_DECIMAL = "BreakOn_ID_%d";

        public const string D3D11_APPSIZE_STRING = "Size";

        public const string D3D11_APPNAME_STRING = "Name";

        public const string D3D11_FORCE_DEBUGGABLE = "ForceDebuggable";

        public const string D3D11_FORCE_SHADER_SKIP_OPTIMIZATION = "ForceShaderSkipOptimization";

        public static readonly Guid DXGI_DEBUG_D3D11 = new Guid(0x4B99317B, 0xAC39, 0x4AA6, 0xBB, 0xB, 0xBA, 0xA0, 0x47, 0x84, 0x79, 0x8F);

        public static readonly Guid IID_ID3D11Debug = new Guid(0x79CF2233, 0x7536, 0x4948, 0x9D, 0x36, 0x1E, 0x46, 0x92, 0xDC, 0x57, 0x60);

        public static readonly Guid IID_ID3D11SwitchToRef = new Guid(0x1EF337E3, 0x58E7, 0x4F83, 0xA6, 0x92, 0xDB, 0x22, 0x1F, 0x5E, 0xD4, 0x7E);

        public static readonly Guid IID_ID3D11TracingDevice = new Guid(0x1911C771, 0x1587, 0x413E, 0xA7, 0xE0, 0xFB, 0x26, 0xC3, 0xDE, 0x02, 0x68);

        public static readonly Guid IID_ID3D11RefTrackingOptions = new Guid(0x193DACDF, 0x0DB2, 0x4C05, 0xA5, 0x5C, 0xEF, 0x06, 0xCA, 0xC5, 0x6F, 0xD9);

        public static readonly Guid IID_ID3D11RefDefaultTrackingOptions = new Guid(0x03916615, 0xC644, 0x418C, 0x9B, 0xF4, 0x75, 0xDB, 0x5B, 0xE6, 0x3C, 0xA0);

        public static readonly Guid IID_ID3D11InfoQueue = new Guid(0x6543DBB6, 0x1B48, 0x42F5, 0xAB, 0x82, 0xE9, 0x7E, 0xC7, 0x43, 0x26, 0xF6);
    }
}
