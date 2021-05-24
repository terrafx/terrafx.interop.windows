// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static bool SUCCEEDED(int hr)
        {
            return hr >= 0;
        }

        public static bool FAILED(int hr)
        {
            return hr < 0;
        }

        public static bool IS_ERROR(int Status)
        {
            return ((uint)Status >> 31) == SEVERITY_ERROR;
        }

        public static int HRESULT_CODE(int hr)
        {
            return hr & 0xFFFF;
        }

        public static int SCODE_CODE(int sc)
        {
            return sc & 0xFFFF;
        }

        public static int HRESULT_FACILITY(int hr)
        {
            return (hr >> 16) & 0x1FFF;
        }

        public static int SCODE_FACILITY(int sc)
        {
            return (sc >> 16) & 0x1FFF;
        }

        public static int HRESULT_SEVERITY(int hr)
        {
            return (hr >> 31) & 0x1;
        }

        public static int SCODE_SEVERITY(int sc)
        {
            return (sc >> 31) & 0x1;
        }

        public static int MAKE_HRESULT(int sev, int fac, int code)
        {
            return (int)(((uint)sev << 31) | ((uint)fac << 16) | (uint)code);
        }

        public static int MAKE_SCODE(int sev, int fac, int code)
        {
            return (int)(((uint)sev << 31) | ((uint)fac << 16) | (uint)code);
        }

        public static int __HRESULT_FROM_WIN32(int x)
        {
            return (x <= 0) ? x : ((x & 0x0000FFFF) | (FACILITY_WIN32 << 16) | unchecked((int)0x80000000));
        }

        public static int HRESULT_FROM_WIN32(int x)
        {
            return __HRESULT_FROM_WIN32(x);
        }

        public static int __HRESULT_FROM_NT(int x)
        {
            return ((HRESULT)((x) | FACILITY_NT_BIT));
        }

        public static int HRESULT_FROM_NT(int x)
        {
            return __HRESULT_FROM_NT(x);
        }
    }
}
