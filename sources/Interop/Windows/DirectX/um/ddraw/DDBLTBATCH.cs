// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

public unsafe partial struct DDBLTBATCH
{
    [NativeTypeName("LPRECT")]
    public RECT* lprDest;

    [NativeTypeName("LPDIRECTDRAWSURFACE")]
    public IDirectDrawSurface* lpDDSSrc;

    [NativeTypeName("LPRECT")]
    public RECT* lprSrc;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("LPDDBLTFX")]
    public DDBLTFX* lpDDBltFx;
}
