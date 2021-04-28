// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/NotificationActivationCallback.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_INotificationActivationCallback = new Guid(0x53E31837, 0x6600, 0x4A81, 0x93, 0x95, 0x75, 0xCF, 0xFE, 0x74, 0x6F, 0x94);
    }
}
