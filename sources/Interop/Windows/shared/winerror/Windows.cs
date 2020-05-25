// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [return: NativeTypeName("HRESULT")]
        public static int HRESULT_FROM_WIN32([NativeTypeName("unsigned long")] uint x)
        {
            return (int)(x) <= 0 ? (int)(x) : (int)(((x) & 0x0000FFFF) | (7 << 16) | 0x80000000);
        }
    }
}
