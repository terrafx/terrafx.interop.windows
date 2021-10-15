// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusinit.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    [NativeTypeName("struct GdiplusStartupInputEx : GdiplusStartupInput")]
    [NativeInheritance("GdiplusStartupInput")]
    public partial struct GdiplusStartupInputEx
    {
        public GdiplusStartupInput __AnonymousBase_GdiplusInit_L68_C32;

        [NativeTypeName("INT")]
        public int StartupParameters;

        public unsafe GdiplusStartupInputEx([NativeTypeName("INT")] int startupParameters = 0, [NativeTypeName("Gdiplus::DebugEventProc")] delegate* unmanaged<DebugEventLevel, sbyte*, void> debugEventCallback = null, [NativeTypeName("BOOL")] int suppressBackgroundThread = 0, [NativeTypeName("BOOL")] int suppressExternalCodecs = 0)
        {
            __AnonymousBase_GdiplusInit_L68_C32.GdiplusVersion = 2;
            __AnonymousBase_GdiplusInit_L68_C32.DebugEventCallback = debugEventCallback;
            __AnonymousBase_GdiplusInit_L68_C32.SuppressBackgroundThread = suppressBackgroundThread;
            __AnonymousBase_GdiplusInit_L68_C32.SuppressExternalCodecs = suppressExternalCodecs;
            StartupParameters = startupParameters;
        }
    }
}
