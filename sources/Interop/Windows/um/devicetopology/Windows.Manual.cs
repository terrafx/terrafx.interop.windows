// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static readonly Guid CLSID_DeviceTopology = new Guid(0X1DF639D0, 0X5EC1, 0X47AA, 0X93, 0X79, 0X82, 0X8D, 0XC1, 0XAA, 0X8C, 0X59);

        public static readonly Guid LIBID_DevTopologyLib = new Guid(0X51B9A01D, 0X8181, 0X4363, 0XB5, 0X9C, 0XE6, 0X78, 0XF4, 0X76, 0XDD, 0X0E);
    }
}
