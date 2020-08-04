// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static readonly Guid IID_IMFTransform = new Guid(0xBF94C121, 0x5B05, 0x4E6F, 0x80, 0x00, 0xBA, 0x59, 0x89, 0x61, 0x41, 0x4D);

        public static readonly Guid IID_IMFDeviceTransform = new Guid(0xD818FBD8, 0xFC46, 0x42F2, 0x87, 0xAC, 0x1E, 0xA2, 0xD1, 0xF9, 0xBF, 0x32);

        public static readonly Guid IID_IMFDeviceTransformCallback = new Guid(0x6D5CB646, 0x29EC, 0x41FB, 0x81, 0x79, 0x8C, 0x4C, 0x6D, 0x75, 0x08, 0x11);
    }
}
