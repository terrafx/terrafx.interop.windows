// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/inkrenderer.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IInkD2DRenderer = new Guid(0x407FB1DE, 0xF85A, 0x4150, 0x97, 0xCF, 0xB7, 0xFB, 0x27, 0x4F, 0xB4, 0xF8);

        public static readonly Guid IID_IInkD2DRenderer2 = new Guid(0x0A95DCD9, 0x4578, 0x4B71, 0xB2, 0x0B, 0xBF, 0x66, 0x4D, 0x4B, 0xFE, 0xEE);

        public static readonly Guid CLSID_InkD2DRenderer = new Guid(0x4044E60C, 0x7B01, 0x4671, 0xA9, 0x7C, 0x04, 0xE0, 0x21, 0x0A, 0x07, 0xA5);
    }
}
