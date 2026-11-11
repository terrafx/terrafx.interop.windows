// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10sdklayers.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3D10
{
    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_SDK_LAYERS_VERSION"]/*' />
    [NativeTypeName("#define D3D10_SDK_LAYERS_VERSION ( 11 )")]
    public const int D3D10_SDK_LAYERS_VERSION = (11);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEBUG_FEATURE_FLUSH_PER_RENDER_OP"]/*' />
    [NativeTypeName("#define D3D10_DEBUG_FEATURE_FLUSH_PER_RENDER_OP ( 0x1 )")]
    public const int D3D10_DEBUG_FEATURE_FLUSH_PER_RENDER_OP = (0x1);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEBUG_FEATURE_FINISH_PER_RENDER_OP"]/*' />
    [NativeTypeName("#define D3D10_DEBUG_FEATURE_FINISH_PER_RENDER_OP ( 0x2 )")]
    public const int D3D10_DEBUG_FEATURE_FINISH_PER_RENDER_OP = (0x2);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_DEBUG_FEATURE_PRESENT_PER_RENDER_OP"]/*' />
    [NativeTypeName("#define D3D10_DEBUG_FEATURE_PRESENT_PER_RENDER_OP ( 0x4 )")]
    public const int D3D10_DEBUG_FEATURE_PRESENT_PER_RENDER_OP = (0x4);

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_REGKEY_PATH"]/*' />
    [NativeTypeName("#define D3D10_REGKEY_PATH __TEXT(\"Software\\Microsoft\\Direct3D\")")]
    public const string D3D10_REGKEY_PATH = "Software\\Microsoft\\Direct3D";

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_MUTE_DEBUG_OUTPUT"]/*' />
    [NativeTypeName("#define D3D10_MUTE_DEBUG_OUTPUT __TEXT(\"MuteDebugOutput\")")]
    public const string D3D10_MUTE_DEBUG_OUTPUT = "MuteDebugOutput";

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_ENABLE_BREAK_ON_MESSAGE"]/*' />
    [NativeTypeName("#define D3D10_ENABLE_BREAK_ON_MESSAGE __TEXT(\"EnableBreakOnMessage\")")]
    public const string D3D10_ENABLE_BREAK_ON_MESSAGE = "EnableBreakOnMessage";

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_INFOQUEUE_STORAGE_FILTER_OVERRIDE"]/*' />
    [NativeTypeName("#define D3D10_INFOQUEUE_STORAGE_FILTER_OVERRIDE __TEXT(\"InfoQueueStorageFilterOverride\")")]
    public const string D3D10_INFOQUEUE_STORAGE_FILTER_OVERRIDE = "InfoQueueStorageFilterOverride";

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_MUTE_CATEGORY"]/*' />
    [NativeTypeName("#define D3D10_MUTE_CATEGORY __TEXT(\"Mute_CATEGORY_%s\")")]
    public const string D3D10_MUTE_CATEGORY = "Mute_CATEGORY_%s";

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_MUTE_SEVERITY"]/*' />
    [NativeTypeName("#define D3D10_MUTE_SEVERITY __TEXT(\"Mute_SEVERITY_%s\")")]
    public const string D3D10_MUTE_SEVERITY = "Mute_SEVERITY_%s";

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_MUTE_ID_STRING"]/*' />
    [NativeTypeName("#define D3D10_MUTE_ID_STRING __TEXT(\"Mute_ID_%s\")")]
    public const string D3D10_MUTE_ID_STRING = "Mute_ID_%s";

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_MUTE_ID_DECIMAL"]/*' />
    [NativeTypeName("#define D3D10_MUTE_ID_DECIMAL __TEXT(\"Mute_ID_%d\")")]
    public const string D3D10_MUTE_ID_DECIMAL = "Mute_ID_%d";

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_UNMUTE_SEVERITY_INFO"]/*' />
    [NativeTypeName("#define D3D10_UNMUTE_SEVERITY_INFO __TEXT(\"Unmute_SEVERITY_INFO\")")]
    public const string D3D10_UNMUTE_SEVERITY_INFO = "Unmute_SEVERITY_INFO";

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_BREAKON_CATEGORY"]/*' />
    [NativeTypeName("#define D3D10_BREAKON_CATEGORY __TEXT(\"BreakOn_CATEGORY_%s\")")]
    public const string D3D10_BREAKON_CATEGORY = "BreakOn_CATEGORY_%s";

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_BREAKON_SEVERITY"]/*' />
    [NativeTypeName("#define D3D10_BREAKON_SEVERITY __TEXT(\"BreakOn_SEVERITY_%s\")")]
    public const string D3D10_BREAKON_SEVERITY = "BreakOn_SEVERITY_%s";

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_BREAKON_ID_STRING"]/*' />
    [NativeTypeName("#define D3D10_BREAKON_ID_STRING __TEXT(\"BreakOn_ID_%s\")")]
    public const string D3D10_BREAKON_ID_STRING = "BreakOn_ID_%s";

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_BREAKON_ID_DECIMAL"]/*' />
    [NativeTypeName("#define D3D10_BREAKON_ID_DECIMAL __TEXT(\"BreakOn_ID_%d\")")]
    public const string D3D10_BREAKON_ID_DECIMAL = "BreakOn_ID_%d";

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_APPSIZE_STRING"]/*' />
    [NativeTypeName("#define D3D10_APPSIZE_STRING __TEXT(\"Size\")")]
    public const string D3D10_APPSIZE_STRING = "Size";

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_APPNAME_STRING"]/*' />
    [NativeTypeName("#define D3D10_APPNAME_STRING __TEXT(\"Name\")")]
    public const string D3D10_APPNAME_STRING = "Name";

    /// <include file='D3D10.xml' path='doc/member[@name="D3D10.D3D10_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT"]/*' />
    [NativeTypeName("#define D3D10_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT 1024")]
    public const int D3D10_INFO_QUEUE_DEFAULT_MESSAGE_COUNT_LIMIT = 1024;
}
