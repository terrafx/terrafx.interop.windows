// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int CTL_CODE(int DeviceType, int Function, int Method, int Access) => (DeviceType << 16) | (Access << 14) | (Function << 2) | Method;
    }
}
