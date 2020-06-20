// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxdiag.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public const uint DXDIAG_DX9_SDK_VERSION = 111;

        public const uint DXDIAG_E_INSUFFICIENT_BUFFER = 0x8007007A;

        public static readonly Guid CLSID_DxDiagProvider = new Guid(0xA65B8071, 0x3BFE, 0x4213, 0x9A, 0x5B, 0x49, 0x1D, 0xA4, 0x46, 0x1C, 0xA7);

        public static readonly Guid IID_IDxDiagProvider = new Guid(0x9C6B4CB0, 0x23F8, 0x49CC, 0xA3, 0xED, 0x45, 0xA5, 0x50, 0x00, 0xA6, 0xD2);

        public static readonly Guid IID_IDxDiagContainer = new Guid(0x7D0F462F, 0x4064, 0x4862, 0xBC, 0x7F, 0x93, 0x3E, 0x50, 0x58, 0xC1, 0x0F);
    }
}
