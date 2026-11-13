// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.FACILITY;
using static TerraFX.Interop.Windows.E;

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    public static bool SUCCEEDED(HRESULT hr)
    {
        return hr >= 0;
    }

    public static bool FAILED(HRESULT hr)
    {
        return hr < 0;
    }

    public static bool IS_ERROR(HRESULT Status)
    {
        return ((uint)Status >> 31) == SEVERITY_ERROR;
    }

    public static int HRESULT_CODE(HRESULT hr)
    {
        return hr & 0xFFFF;
    }

    public static int SCODE_CODE(HRESULT sc)
    {
        return sc & 0xFFFF;
    }

    public static int HRESULT_FACILITY(HRESULT hr)
    {
        return (hr >> 16) & 0x1FFF;
    }

    public static int SCODE_FACILITY(HRESULT sc)
    {
        return (sc >> 16) & 0x1FFF;
    }

    public static int HRESULT_SEVERITY(HRESULT hr)
    {
        return (hr >> 31) & 0x1;
    }

    public static int SCODE_SEVERITY(HRESULT sc)
    {
        return (sc >> 31) & 0x1;
    }

    public static HRESULT MAKE_HRESULT(int sev, int fac, int code)
    {
        return unchecked((int)(((uint)sev << 31) | ((uint)fac << 16) | (uint)code));
    }

    public static HRESULT MAKE_SCODE(int sev, int fac, int code)
    {
        return unchecked((int)(((uint)sev << 31) | ((uint)fac << 16) | (uint)code));
    }

    public static HRESULT HRESULT_FROM_WIN32(int x)
    {
        return (x <= 0) ? x : ((x & 0x0000FFFF) | (FACILITY_WIN32 << 16) | unchecked((int)0x80000000));
    }

    public static HRESULT __HRESULT_FROM_WIN32(int x) => HRESULT_FROM_WIN32(x);

    public static HRESULT HRESULT_FROM_SETUPAPI(uint x)
    {
        const uint SetupApiErrorMask = 0xE0000000;

        if ((x & SetupApiErrorMask) == SetupApiErrorMask)
        {
            return (HRESULT)((x & 0x0000FFFF) | (FACILITY_SETUPAPI << 16) | 0x80000000);
        }

        return HRESULT_FROM_WIN32(unchecked((int)x));
    }

    public static HRESULT __HRESULT_FROM_SETUPAPI(uint x) => HRESULT_FROM_SETUPAPI(x);

    public static HRESULT HRESULT_FROM_NT(int x)
    {
        return ((HRESULT)((x) | FACILITY_NT_BIT));
    }

    public static HRESULT FILTER_HRESULT_FROM_FLT_NTSTATUS(int x)
        => (HRESULT)unchecked(((uint)x & 0x8000FFFFu) | ((uint)FACILITY_USERMODE_FILTER_MANAGER << 16));

    public static bool IS_CAMERA_ERROR_CODE(HRESULT xhr) => ((int)xhr >= E_CAMERA_ERROR_MIN) && ((int)xhr <= E_CAMERA_ERROR_MAX);

    public static int GetScode(HRESULT hr) => hr;

    public static HRESULT ResultFromScode(int sc) => sc;

    public static HRESULT PropagateResult(HRESULT hrPrevious, int scBase) => scBase;
}
