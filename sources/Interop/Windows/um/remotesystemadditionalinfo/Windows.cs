// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/remotesystemadditionalinfo.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IRemoteSystemAdditionalInfoProvider = new Guid(0xEEAA3D5F, 0xEC63, 0x4D27, 0xAF, 0x38, 0xE8, 0x6B, 0x1D, 0x72, 0x92, 0xCB);
    }
}
