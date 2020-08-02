// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
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
    }
}
