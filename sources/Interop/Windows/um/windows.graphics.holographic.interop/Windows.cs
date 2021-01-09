// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.graphics.holographic.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IHolographicCameraInterop = new Guid(0x7CC1F9C5, 0x6D02, 0x41FA, 0x95, 0x00, 0xE1, 0x80, 0x9E, 0xB4, 0x8E, 0xEC);

        public static readonly Guid IID_IHolographicCameraRenderingParametersInterop = new Guid(0xF75B68D6, 0xD1FD, 0x4707, 0xAA, 0xFD, 0xFA, 0x6F, 0x4C, 0x0E, 0x3B, 0xF4);

        public static readonly Guid IID_IHolographicQuadLayerInterop = new Guid(0xCFA688F0, 0x639E, 0x4A47, 0x83, 0xD7, 0x6B, 0x7F, 0x5E, 0xBF, 0x7F, 0xED);

        public static readonly Guid IID_IHolographicQuadLayerUpdateParametersInterop = new Guid(0xE5F549CD, 0xC909, 0x444F, 0x88, 0x09, 0x7C, 0xC1, 0x8A, 0x9C, 0x89, 0x20);
    }
}
