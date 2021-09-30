// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static ushort PROPSETHDR_OSVER_KIND(nuint dwOSVer) => HIWORD(dwOSVer);

        public static byte PROPSETHDR_OSVER_MAJOR(nuint dwOSVer) => LOBYTE(LOWORD(dwOSVer));

        public static byte PROPSETHDR_OSVER_MINOR(nuint dwOSVer) => HIBYTE(LOWORD(dwOSVer));
    }
}
