// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appserviceinterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IAppServiceConnectionExtendedExecution = new Guid(0x65219584, 0xF9CB, 0x4AE3, 0x81, 0xF9, 0xA2, 0x8A, 0x6C, 0xA4, 0x50, 0xD9);

        public static readonly Guid IID_ICorrelationVectorSource = new Guid(0x152B8A3B, 0xB9B9, 0x4685, 0xB5, 0x6E, 0x97, 0x48, 0x47, 0xBC, 0x75, 0x45);
    }
}
