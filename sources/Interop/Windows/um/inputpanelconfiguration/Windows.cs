// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/inputpanelconfiguration.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IInputPanelConfiguration = new Guid(0x41C81592, 0x514C, 0x48BD, 0xA2, 0x2E, 0xE6, 0xAF, 0x63, 0x85, 0x21, 0xA6);

        public static readonly Guid IID_IInputPanelInvocationConfiguration = new Guid(0xA213F136, 0x3B45, 0x4362, 0xA3, 0x32, 0xEF, 0xB6, 0x54, 0x7C, 0xD4, 0x32);

        public static readonly Guid IID_InputPanelConfiguration = new Guid(0x2853ADD3, 0xF096, 0x4C63, 0xA7, 0x8F, 0x7F, 0xA3, 0xEA, 0x83, 0x7F, 0xB7);
    }
}
