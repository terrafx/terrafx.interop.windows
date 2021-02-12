// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static readonly Guid CLSID_MMDeviceEnumerator = new Guid(0XBCDE0395, 0XE52F, 0X467C, 0X8E, 0X3D, 0XC4, 0X57, 0X92, 0X91, 0X69, 0X2E);

        public static readonly Guid LIBID_MMDeviceAPILib = new Guid(0X2FDAAFA3, 0X7523, 0X4F66, 0X99, 0X57, 0X9D, 0X5E, 0X7F, 0XE6, 0X98, 0XF6);
    }
}
