// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusinit.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct GdiplusStartupInput
    {
        [NativeTypeName("UINT32")]
        public uint GdiplusVersion;

        [NativeTypeName("Gdiplus::DebugEventProc")]
        public delegate* unmanaged<DebugEventLevel, sbyte*, void> DebugEventCallback;

        [NativeTypeName("BOOL")]
        public int SuppressBackgroundThread;

        [NativeTypeName("BOOL")]
        public int SuppressExternalCodecs;

        public GdiplusStartupInput([NativeTypeName("Gdiplus::DebugEventProc")] delegate* unmanaged<DebugEventLevel, sbyte*, void> debugEventCallback = null, [NativeTypeName("BOOL")] int suppressBackgroundThread = 0, [NativeTypeName("BOOL")] int suppressExternalCodecs = 0)
        {
            GdiplusVersion = 1;
            DebugEventCallback = debugEventCallback;
            SuppressBackgroundThread = suppressBackgroundThread;
            SuppressExternalCodecs = suppressExternalCodecs;
        }
    }
}
