// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    [NativeTypeName("#define NOTIFYICONDATAA_V1_SIZE FIELD_OFFSET(NOTIFYICONDATAA, szTip[64])")]
    public static int NOTIFYICONDATAA_V1_SIZE
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ((int)(Marshal.OffsetOf<NOTIFYICONDATA32A>("szTip")));
            }
            else
            {
                return ((int)(Marshal.OffsetOf<NOTIFYICONDATA64A>("szTip")));
            }
        }
    }

    [NativeTypeName("#define NOTIFYICONDATAW_V1_SIZE FIELD_OFFSET(NOTIFYICONDATAW, szTip[64])")]
    public static int NOTIFYICONDATAW_V1_SIZE
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ((int)(Marshal.OffsetOf<NOTIFYICONDATA32W>("szTip")));
            }
            else
            {
                return ((int)(Marshal.OffsetOf<NOTIFYICONDATA64W>("szTip")));
            }
        }
    }

    [NativeTypeName("#define NOTIFYICONDATA_V1_SIZE NOTIFYICONDATAW_V1_SIZE")]
    public static int NOTIFYICONDATA_V1_SIZE => NOTIFYICONDATAW_V1_SIZE;

    [NativeTypeName("#define NOTIFYICONDATAA_V2_SIZE FIELD_OFFSET(NOTIFYICONDATAA, guidItem)")]
    public static int NOTIFYICONDATAA_V2_SIZE
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ((int)(Marshal.OffsetOf<NOTIFYICONDATA32A>("guidItem")));
            }
            else
            {
                return ((int)(Marshal.OffsetOf<NOTIFYICONDATA64A>("guidItem")));
            }
        }
    }

    [NativeTypeName("#define NOTIFYICONDATAW_V2_SIZE FIELD_OFFSET(NOTIFYICONDATAW, guidItem)")]
    public static int NOTIFYICONDATAW_V2_SIZE
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ((int)(Marshal.OffsetOf<NOTIFYICONDATA32W>("guidItem")));
            }
            else
            {
                return ((int)(Marshal.OffsetOf<NOTIFYICONDATA64W>("guidItem")));
            }
        }
    }

    [NativeTypeName("#define NOTIFYICONDATA_V2_SIZE NOTIFYICONDATAW_V2_SIZE")]
    public static int NOTIFYICONDATA_V2_SIZE => NOTIFYICONDATAW_V2_SIZE;

    [NativeTypeName("#define NOTIFYICONDATAA_V3_SIZE FIELD_OFFSET(NOTIFYICONDATAA, hBalloonIcon)")]
    public static int NOTIFYICONDATAA_V3_SIZE
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ((int)(Marshal.OffsetOf<NOTIFYICONDATA32A>("hBalloonIcon")));
            }
            else
            {
                return ((int)(Marshal.OffsetOf<NOTIFYICONDATA64A>("hBalloonIcon")));
            }
        }
    }

    [NativeTypeName("#define NOTIFYICONDATAW_V3_SIZE FIELD_OFFSET(NOTIFYICONDATAW, hBalloonIcon)")]
    public static int NOTIFYICONDATAW_V3_SIZE
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ((int)(Marshal.OffsetOf<NOTIFYICONDATA32W>("hBalloonIcon")));
            }
            else
            {
                return ((int)(Marshal.OffsetOf<NOTIFYICONDATA64W>("hBalloonIcon")));
            }
        }
    }

    [NativeTypeName("#define NOTIFYICONDATA_V3_SIZE NOTIFYICONDATAW_V3_SIZE")]
    public static int NOTIFYICONDATA_V3_SIZE => NOTIFYICONDATAW_V3_SIZE;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ShellMessageBoxW"]/*' />
    [DllImport("shlwapi", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ShellMessageBoxW", ExactSpelling = true)]
    [SetsLastSystemError]
    public static extern int ShellMessageBox(HINSTANCE hAppInst, HWND hWnd, [NativeTypeName("LPCWSTR")] ushort* lpcText, [NativeTypeName("LPCWSTR")] ushort* lpcTitle, uint fuStyle, __arglist);
}
