// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/RadialControllerInterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IRadialControllerInterop = new Guid(0x1B0535C9, 0x57AD, 0x45C1, 0x9D, 0x79, 0xAD, 0x5C, 0x34, 0x36, 0x05, 0x13);

        public static readonly Guid IID_IRadialControllerConfigurationInterop = new Guid(0x787CDAAC, 0x3186, 0x476D, 0x87, 0xE4, 0xB9, 0x37, 0x4A, 0x7B, 0x99, 0x70);

        public static readonly Guid IID_IRadialControllerIndependentInputSourceInterop = new Guid(0x3D577EFF, 0x4CEE, 0x11E6, 0xB5, 0x35, 0x00, 0x1B, 0xDC, 0x06, 0xAB, 0x3B);
    }
}
