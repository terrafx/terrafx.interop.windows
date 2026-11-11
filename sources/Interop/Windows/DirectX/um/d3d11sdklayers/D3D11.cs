// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11sdklayers.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3D11
{
    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_SDK_LAYERS_VERSION"]/*' />
    [NativeTypeName("#define D3D11_SDK_LAYERS_VERSION ( 1 )")]
    public const int D3D11_SDK_LAYERS_VERSION = (1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEBUG_FEATURE_FLUSH_PER_RENDER_OP"]/*' />
    [NativeTypeName("#define D3D11_DEBUG_FEATURE_FLUSH_PER_RENDER_OP ( 0x1 )")]
    public const int D3D11_DEBUG_FEATURE_FLUSH_PER_RENDER_OP = (0x1);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEBUG_FEATURE_FINISH_PER_RENDER_OP"]/*' />
    [NativeTypeName("#define D3D11_DEBUG_FEATURE_FINISH_PER_RENDER_OP ( 0x2 )")]
    public const int D3D11_DEBUG_FEATURE_FINISH_PER_RENDER_OP = (0x2);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEBUG_FEATURE_PRESENT_PER_RENDER_OP"]/*' />
    [NativeTypeName("#define D3D11_DEBUG_FEATURE_PRESENT_PER_RENDER_OP ( 0x4 )")]
    public const int D3D11_DEBUG_FEATURE_PRESENT_PER_RENDER_OP = (0x4);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEBUG_FEATURE_ALWAYS_DISCARD_OFFERED_RESOURCE"]/*' />
    [NativeTypeName("#define D3D11_DEBUG_FEATURE_ALWAYS_DISCARD_OFFERED_RESOURCE ( 0x8 )")]
    public const int D3D11_DEBUG_FEATURE_ALWAYS_DISCARD_OFFERED_RESOURCE = (0x8);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEBUG_FEATURE_NEVER_DISCARD_OFFERED_RESOURCE"]/*' />
    [NativeTypeName("#define D3D11_DEBUG_FEATURE_NEVER_DISCARD_OFFERED_RESOURCE ( 0x10 )")]
    public const int D3D11_DEBUG_FEATURE_NEVER_DISCARD_OFFERED_RESOURCE = (0x10);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEBUG_FEATURE_AVOID_BEHAVIOR_CHANGING_DEBUG_AIDS"]/*' />
    [NativeTypeName("#define D3D11_DEBUG_FEATURE_AVOID_BEHAVIOR_CHANGING_DEBUG_AIDS ( 0x40 )")]
    public const int D3D11_DEBUG_FEATURE_AVOID_BEHAVIOR_CHANGING_DEBUG_AIDS = (0x40);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_DEBUG_FEATURE_DISABLE_TILED_RESOURCE_MAPPING_TRACKING_AND_VALIDATION"]/*' />
    [NativeTypeName("#define D3D11_DEBUG_FEATURE_DISABLE_TILED_RESOURCE_MAPPING_TRACKING_AND_VALIDATION ( 0x80 )")]
    public const int D3D11_DEBUG_FEATURE_DISABLE_TILED_RESOURCE_MAPPING_TRACKING_AND_VALIDATION = (0x80);

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_REGKEY_PATH"]/*' />
    [NativeTypeName("#define D3D11_REGKEY_PATH __TEXT(\"Software\\Microsoft\\Direct3D\")")]
    public const string D3D11_REGKEY_PATH = "Software\\Microsoft\\Direct3D";

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_MUTE_DEBUG_OUTPUT"]/*' />
    [NativeTypeName("#define D3D11_MUTE_DEBUG_OUTPUT __TEXT(\"MuteDebugOutput\")")]
    public const string D3D11_MUTE_DEBUG_OUTPUT = "MuteDebugOutput";

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_ENABLE_BREAK_ON_MESSAGE"]/*' />
    [NativeTypeName("#define D3D11_ENABLE_BREAK_ON_MESSAGE __TEXT(\"EnableBreakOnMessage\")")]
    public const string D3D11_ENABLE_BREAK_ON_MESSAGE = "EnableBreakOnMessage";

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_INFOQUEUE_STORAGE_FILTER_OVERRIDE"]/*' />
    [NativeTypeName("#define D3D11_INFOQUEUE_STORAGE_FILTER_OVERRIDE __TEXT(\"InfoQueueStorageFilterOverride\")")]
    public const string D3D11_INFOQUEUE_STORAGE_FILTER_OVERRIDE = "InfoQueueStorageFilterOverride";

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_MUTE_CATEGORY"]/*' />
    [NativeTypeName("#define D3D11_MUTE_CATEGORY __TEXT(\"Mute_CATEGORY_%s\")")]
    public const string D3D11_MUTE_CATEGORY = "Mute_CATEGORY_%s";

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_MUTE_SEVERITY"]/*' />
    [NativeTypeName("#define D3D11_MUTE_SEVERITY __TEXT(\"Mute_SEVERITY_%s\")")]
    public const string D3D11_MUTE_SEVERITY = "Mute_SEVERITY_%s";

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_MUTE_ID_STRING"]/*' />
    [NativeTypeName("#define D3D11_MUTE_ID_STRING __TEXT(\"Mute_ID_%s\")")]
    public const string D3D11_MUTE_ID_STRING = "Mute_ID_%s";

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_MUTE_ID_DECIMAL"]/*' />
    [NativeTypeName("#define D3D11_MUTE_ID_DECIMAL __TEXT(\"Mute_ID_%d\")")]
    public const string D3D11_MUTE_ID_DECIMAL = "Mute_ID_%d";

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_UNMUTE_SEVERITY_INFO"]/*' />
    [NativeTypeName("#define D3D11_UNMUTE_SEVERITY_INFO __TEXT(\"Unmute_SEVERITY_INFO\")")]
    public const string D3D11_UNMUTE_SEVERITY_INFO = "Unmute_SEVERITY_INFO";

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_BREAKON_CATEGORY"]/*' />
    [NativeTypeName("#define D3D11_BREAKON_CATEGORY __TEXT(\"BreakOn_CATEGORY_%s\")")]
    public const string D3D11_BREAKON_CATEGORY = "BreakOn_CATEGORY_%s";

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_BREAKON_SEVERITY"]/*' />
    [NativeTypeName("#define D3D11_BREAKON_SEVERITY __TEXT(\"BreakOn_SEVERITY_%s\")")]
    public const string D3D11_BREAKON_SEVERITY = "BreakOn_SEVERITY_%s";

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_BREAKON_ID_STRING"]/*' />
    [NativeTypeName("#define D3D11_BREAKON_ID_STRING __TEXT(\"BreakOn_ID_%s\")")]
    public const string D3D11_BREAKON_ID_STRING = "BreakOn_ID_%s";

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_BREAKON_ID_DECIMAL"]/*' />
    [NativeTypeName("#define D3D11_BREAKON_ID_DECIMAL __TEXT(\"BreakOn_ID_%d\")")]
    public const string D3D11_BREAKON_ID_DECIMAL = "BreakOn_ID_%d";

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_APPSIZE_STRING"]/*' />
    [NativeTypeName("#define D3D11_APPSIZE_STRING __TEXT(\"Size\")")]
    public const string D3D11_APPSIZE_STRING = "Size";

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_APPNAME_STRING"]/*' />
    [NativeTypeName("#define D3D11_APPNAME_STRING __TEXT(\"Name\")")]
    public const string D3D11_APPNAME_STRING = "Name";

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_FORCE_DEBUGGABLE"]/*' />
    [NativeTypeName("#define D3D11_FORCE_DEBUGGABLE __TEXT(\"ForceDebuggable\")")]
    public const string D3D11_FORCE_DEBUGGABLE = "ForceDebuggable";

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_FORCE_SHADER_SKIP_OPTIMIZATION"]/*' />
    [NativeTypeName("#define D3D11_FORCE_SHADER_SKIP_OPTIMIZATION __TEXT(\"ForceShaderSkipOptimization\")")]
    public const string D3D11_FORCE_SHADER_SKIP_OPTIMIZATION = "ForceShaderSkipOptimization";

    /// <include file='D3D11.xml' path='doc/member[@name="D3D11.D3D11_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT"]/*' />
    [NativeTypeName("#define D3D11_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT 1024")]
    public const int D3D11_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT = 1024;
}
