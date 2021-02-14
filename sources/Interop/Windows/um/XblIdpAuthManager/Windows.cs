// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/XblIdpAuthManager.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IXblIdpAuthManager = new Guid(0xEB5DDB08, 0x8BBF, 0x449B, 0xAC, 0x21, 0xB0, 0x2D, 0xDE, 0xB3, 0xB1, 0x36);

        public static readonly Guid IID_IXblIdpAuthTokenResult = new Guid(0x46CE0225, 0xF267, 0x4D68, 0xB2, 0x99, 0xB2, 0x76, 0x25, 0x52, 0xDE, 0xC1);

        public static readonly Guid IID_IXblIdpAuthTokenResult2 = new Guid(0x75D760B0, 0x60B9, 0x412D, 0x99, 0x4F, 0x26, 0xB2, 0xCD, 0x5F, 0x78, 0x12);

        public static readonly Guid CLSID_XblIdpAuthManager = new Guid(0xCE23534B, 0x56D8, 0x4978, 0x86, 0xA2, 0x7E, 0xE5, 0x70, 0x64, 0x04, 0x68);

        public static readonly Guid CLSID_XblIdpAuthTokenResult = new Guid(0x9F493441, 0x744A, 0x410C, 0xAE, 0x2B, 0x9A, 0x22, 0xF7, 0xC7, 0x73, 0x1F);
    }
}
