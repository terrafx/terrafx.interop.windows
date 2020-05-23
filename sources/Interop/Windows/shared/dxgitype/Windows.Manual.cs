// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public const int _FACDXGI = 0x87A;

        public const int DXGI_CPU_ACCESS_NONE = 0;

        public const int DXGI_CPU_ACCESS_DYNAMIC = 1;

        public const int DXGI_CPU_ACCESS_READ_WRITE = 2;

        public const int DXGI_CPU_ACCESS_SCRATCH = 3;

        public const int DXGI_CPU_ACCESS_FIELD = 15;

        public static int MAKE_DXGI_HRESULT(int code) => MAKE_HRESULT(1, _FACDXGI, code);

        public static int MAKE_DXGI_STATUS(int code) => MAKE_HRESULT(0, _FACDXGI, code);
    }
}
