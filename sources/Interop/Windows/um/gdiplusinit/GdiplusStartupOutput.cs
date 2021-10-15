// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusinit.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct GdiplusStartupOutput
    {
        [NativeTypeName("Gdiplus::NotificationHookProc")]
        public delegate* unmanaged<nuint*, Status> NotificationHook;

        [NativeTypeName("Gdiplus::NotificationUnhookProc")]
        public delegate* unmanaged<nuint, void> NotificationUnhook;
    }
}
