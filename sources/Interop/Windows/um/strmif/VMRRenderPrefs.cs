// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum VMRRenderPrefs
    {
        RenderPrefs_RestrictToInitialMonitor = 0,
        RenderPrefs_ForceOffscreen = 0x1,
        RenderPrefs_ForceOverlays = 0x2,
        RenderPrefs_AllowOverlays = 0,
        RenderPrefs_AllowOffscreen = 0,
        RenderPrefs_DoNotRenderColorKeyAndBorder = 0x8,
        RenderPrefs_Reserved = 0x10,
        RenderPrefs_PreferAGPMemWhenMixing = 0x20,
        RenderPrefs_Mask = 0x3f,
    }
}
