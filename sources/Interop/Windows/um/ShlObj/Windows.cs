// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public const int SFBID_PIDLCHANGED = 0;

        public const int DBCID_EMPTY = 0;
        public const int DBCID_ONDRAG = 1;
        public const int DBCID_CLSIDOFBAR = 2;
        public const int DBCID_RESIZE = 3;
        public const int DBCID_GETBAR = 4;
        public const int DBCID_UPDATESIZE = 5;

        [DllImport("shell32", ExactSpelling = true)]
        public static extern void SHChangeNotifyRegisterThread(SCNRT_STATUS status);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern void PathQualify([NativeTypeName("PWSTR")] ushort* psz);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL PathIsSlowA([NativeTypeName("LPCSTR")] sbyte* pszFile, [NativeTypeName("DWORD")] uint dwAttr);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL PathIsSlowW([NativeTypeName("LPCWSTR")] ushort* pszFile, [NativeTypeName("DWORD")] uint dwAttr);

        [DllImport("shell32", ExactSpelling = true)]
        [return: NativeTypeName("HPSXA")]
        public static extern IntPtr SHCreatePropSheetExtArray([NativeTypeName("HKEY")] IntPtr hKey, [NativeTypeName("PCWSTR")] ushort* pszSubKey, [NativeTypeName("UINT")] uint max_iface);

        public const int BMICON_LARGE = 0;
        public const int BMICON_SMALL = 1;

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL SHOpenPropSheetW([NativeTypeName("LPCWSTR")] ushort* pszCaption, [NativeTypeName("HKEY []")] IntPtr* ahkeys, [NativeTypeName("UINT")] uint ckeys, [NativeTypeName("const CLSID *")] Guid* pclsidDefault, IDataObject* pdtobj, IShellBrowser* psb, [NativeTypeName("LPCWSTR")] ushort* pStartPage);

        [DllImport("shdocvw", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SoftwareUpdateMessageBox([NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("PCWSTR")] ushort* pszDistUnit, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPSOFTDISTINFO")] SOFTDISTINFO* psdi);

        [DllImport("shell32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHMultiFileProperties(IDataObject* pdtobj, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("shell32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHCreateQueryCancelAutoPlayMoniker(IMoniker** ppmoniker);

        [DllImport("mydocs", ExactSpelling = true)]
        public static extern void PerUserInit();

        [NativeTypeName("#define FCIDM_TOOLBAR (FCIDM_BROWSERFIRST + 0)")]
        public const int FCIDM_TOOLBAR = (0xa000 + 0);

        [NativeTypeName("#define FCIDM_STATUS (FCIDM_BROWSERFIRST + 1)")]
        public const int FCIDM_STATUS = (0xa000 + 1);

        [NativeTypeName("#define IDC_OFFLINE_HAND 103")]
        public const int IDC_OFFLINE_HAND = 103;

        [NativeTypeName("#define IDC_PANTOOL_HAND_OPEN 104")]
        public const int IDC_PANTOOL_HAND_OPEN = 104;

        [NativeTypeName("#define IDC_PANTOOL_HAND_CLOSED 105")]
        public const int IDC_PANTOOL_HAND_CLOSED = 105;

        [NativeTypeName("#define PANE_NONE ((DWORD)-1)")]
        public const uint PANE_NONE = unchecked((uint)(-1));

        [NativeTypeName("#define PANE_ZONE 1")]
        public const int PANE_ZONE = 1;

        [NativeTypeName("#define PANE_OFFLINE 2")]
        public const int PANE_OFFLINE = 2;

        [NativeTypeName("#define PANE_PRINTER 3")]
        public const int PANE_PRINTER = 3;

        [NativeTypeName("#define PANE_SSL 4")]
        public const int PANE_SSL = 4;

        [NativeTypeName("#define PANE_NAVIGATION 5")]
        public const int PANE_NAVIGATION = 5;

        [NativeTypeName("#define PANE_PROGRESS 6")]
        public const int PANE_PROGRESS = 6;

        [NativeTypeName("#define PANE_PRIVACY 7")]
        public const int PANE_PRIVACY = 7;

        [NativeTypeName("#define DWFRF_NORMAL 0x0000")]
        public const int DWFRF_NORMAL = 0x0000;

        [NativeTypeName("#define DWFRF_DELETECONFIGDATA 0x0001")]
        public const int DWFRF_DELETECONFIGDATA = 0x0001;

        [NativeTypeName("#define DWFAF_HIDDEN 0x0001")]
        public const int DWFAF_HIDDEN = 0x0001;

        [NativeTypeName("#define DWFAF_GROUP1 0x0002")]
        public const int DWFAF_GROUP1 = 0x0002;

        [NativeTypeName("#define DWFAF_GROUP2 0x0004")]
        public const int DWFAF_GROUP2 = 0x0004;

        [NativeTypeName("#define DWFAF_AUTOHIDE 0x0010")]
        public const int DWFAF_AUTOHIDE = 0x0010;

        [NativeTypeName("#define ISFB_MASK_STATE 0x00000001")]
        public const int ISFB_MASK_STATE = 0x00000001;

        [NativeTypeName("#define ISFB_MASK_BKCOLOR 0x00000002")]
        public const int ISFB_MASK_BKCOLOR = 0x00000002;

        [NativeTypeName("#define ISFB_MASK_VIEWMODE 0x00000004")]
        public const int ISFB_MASK_VIEWMODE = 0x00000004;

        [NativeTypeName("#define ISFB_MASK_SHELLFOLDER 0x00000008")]
        public const int ISFB_MASK_SHELLFOLDER = 0x00000008;

        [NativeTypeName("#define ISFB_MASK_IDLIST 0x00000010")]
        public const int ISFB_MASK_IDLIST = 0x00000010;

        [NativeTypeName("#define ISFB_MASK_COLORS 0x00000020")]
        public const int ISFB_MASK_COLORS = 0x00000020;

        [NativeTypeName("#define ISFB_STATE_DEFAULT 0x00000000")]
        public const int ISFB_STATE_DEFAULT = 0x00000000;

        [NativeTypeName("#define ISFB_STATE_DEBOSSED 0x00000001")]
        public const int ISFB_STATE_DEBOSSED = 0x00000001;

        [NativeTypeName("#define ISFB_STATE_ALLOWRENAME 0x00000002")]
        public const int ISFB_STATE_ALLOWRENAME = 0x00000002;

        [NativeTypeName("#define ISFB_STATE_NOSHOWTEXT 0x00000004")]
        public const int ISFB_STATE_NOSHOWTEXT = 0x00000004;

        [NativeTypeName("#define ISFB_STATE_CHANNELBAR 0x00000010")]
        public const int ISFB_STATE_CHANNELBAR = 0x00000010;

        [NativeTypeName("#define ISFB_STATE_QLINKSMODE 0x00000020")]
        public const int ISFB_STATE_QLINKSMODE = 0x00000020;

        [NativeTypeName("#define ISFB_STATE_FULLOPEN 0x00000040")]
        public const int ISFB_STATE_FULLOPEN = 0x00000040;

        [NativeTypeName("#define ISFB_STATE_NONAMESORT 0x00000080")]
        public const int ISFB_STATE_NONAMESORT = 0x00000080;

        [NativeTypeName("#define ISFB_STATE_BTNMINSIZE 0x00000100")]
        public const int ISFB_STATE_BTNMINSIZE = 0x00000100;

        [NativeTypeName("#define ISFBVIEWMODE_SMALLICONS 0x0001")]
        public const int ISFBVIEWMODE_SMALLICONS = 0x0001;

        [NativeTypeName("#define ISFBVIEWMODE_LARGEICONS 0x0002")]
        public const int ISFBVIEWMODE_LARGEICONS = 0x0002;

        [NativeTypeName("#define DBC_GS_IDEAL 0")]
        public const int DBC_GS_IDEAL = 0;

        [NativeTypeName("#define DBC_GS_SIZEDOWN 1")]
        public const int DBC_GS_SIZEDOWN = 1;

        [NativeTypeName("#define DBC_HIDE 0")]
        public const int DBC_HIDE = 0;

        [NativeTypeName("#define DBC_SHOW 1")]
        public const int DBC_SHOW = 1;

        [NativeTypeName("#define DBC_SHOWOBSCURE 2")]
        public const int DBC_SHOWOBSCURE = 2;

        [NativeTypeName("#define SSM_CLEAR 0x0000")]
        public const int SSM_CLEAR = 0x0000;

        [NativeTypeName("#define SSM_SET 0x0001")]
        public const int SSM_SET = 0x0001;

        [NativeTypeName("#define SSM_REFRESH 0x0002")]
        public const int SSM_REFRESH = 0x0002;

        [NativeTypeName("#define SSM_UPDATE 0x0004")]
        public const int SSM_UPDATE = 0x0004;

        [NativeTypeName("#define SCHEME_DISPLAY 0x0001")]
        public const int SCHEME_DISPLAY = 0x0001;

        [NativeTypeName("#define SCHEME_EDIT 0x0002")]
        public const int SCHEME_EDIT = 0x0002;

        [NativeTypeName("#define SCHEME_LOCAL 0x0004")]
        public const int SCHEME_LOCAL = 0x0004;

        [NativeTypeName("#define SCHEME_GLOBAL 0x0008")]
        public const int SCHEME_GLOBAL = 0x0008;

        [NativeTypeName("#define SCHEME_REFRESH 0x0010")]
        public const int SCHEME_REFRESH = 0x0010;

        [NativeTypeName("#define SCHEME_UPDATE 0x0020")]
        public const int SCHEME_UPDATE = 0x0020;

        [NativeTypeName("#define SCHEME_DONOTUSE 0x0040")]
        public const int SCHEME_DONOTUSE = 0x0040;

        [NativeTypeName("#define SCHEME_CREATE 0x0080")]
        public const int SCHEME_CREATE = 0x0080;

        [NativeTypeName("#define GADOF_DIRTY 0x00000001")]
        public const int GADOF_DIRTY = 0x00000001;

        [NativeTypeName("#define SHCDF_UPDATEITEM 0x00000001")]
        public const int SHCDF_UPDATEITEM = 0x00000001;

        [NativeTypeName("#define PathIsSlow PathIsSlowW")]
        public static delegate*<ushort*, uint, BOOL> PathIsSlow => &PathIsSlowW;

        [NativeTypeName("#define OPENPROPS_NONE 0x0000")]
        public const int OPENPROPS_NONE = 0x0000;

        [NativeTypeName("#define OPENPROPS_INHIBITPIF 0x8000")]
        public const int OPENPROPS_INHIBITPIF = 0x8000;

        [NativeTypeName("#define GETPROPS_NONE 0x0000")]
        public const int GETPROPS_NONE = 0x0000;

        [NativeTypeName("#define SETPROPS_NONE 0x0000")]
        public const int SETPROPS_NONE = 0x0000;

        [NativeTypeName("#define CLOSEPROPS_NONE 0x0000")]
        public const int CLOSEPROPS_NONE = 0x0000;

        [NativeTypeName("#define CLOSEPROPS_DISCARD 0x0001")]
        public const int CLOSEPROPS_DISCARD = 0x0001;

        [NativeTypeName("#define TBIF_APPEND 0")]
        public const int TBIF_APPEND = 0;

        [NativeTypeName("#define TBIF_PREPEND 1")]
        public const int TBIF_PREPEND = 1;

        [NativeTypeName("#define TBIF_REPLACE 2")]
        public const int TBIF_REPLACE = 2;

        [NativeTypeName("#define TBIF_DEFAULT 0x00000000")]
        public const int TBIF_DEFAULT = 0x00000000;

        [NativeTypeName("#define TBIF_INTERNETBAR 0x00010000")]
        public const int TBIF_INTERNETBAR = 0x00010000;

        [NativeTypeName("#define TBIF_STANDARDTOOLBAR 0x00020000")]
        public const int TBIF_STANDARDTOOLBAR = 0x00020000;

        [NativeTypeName("#define TBIF_NOTOOLBAR 0x00030000")]
        public const int TBIF_NOTOOLBAR = 0x00030000;

        [NativeTypeName("#define SHOpenPropSheet SHOpenPropSheetW")]
        public static delegate*<ushort*, IntPtr*, uint, Guid*, IDataObject*, IShellBrowser*, ushort*, BOOL> SHOpenPropSheet => &SHOpenPropSheetW;

        [NativeTypeName("#define SFVM_REARRANGE 0x00000001")]
        public const int SFVM_REARRANGE = 0x00000001;

        [NativeTypeName("#define SFVM_ADDOBJECT 0x00000003")]
        public const int SFVM_ADDOBJECT = 0x00000003;

        [NativeTypeName("#define SFVM_REMOVEOBJECT 0x00000006")]
        public const int SFVM_REMOVEOBJECT = 0x00000006;

        [NativeTypeName("#define SFVM_UPDATEOBJECT 0x00000007")]
        public const int SFVM_UPDATEOBJECT = 0x00000007;

        [NativeTypeName("#define SFVM_GETSELECTEDOBJECTS 0x00000009")]
        public const int SFVM_GETSELECTEDOBJECTS = 0x00000009;

        [NativeTypeName("#define SFVM_SETITEMPOS 0x0000000e")]
        public const int SFVM_SETITEMPOS = 0x0000000e;

        [NativeTypeName("#define SFVM_SETCLIPBOARD 0x00000010")]
        public const int SFVM_SETCLIPBOARD = 0x00000010;

        [NativeTypeName("#define SFVM_SETPOINTS 0x00000017")]
        public const int SFVM_SETPOINTS = 0x00000017;

        public static ref readonly Guid IID_IDeskBarClient
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x75, 0xE1, 0x0F, 0xEB,
                    0x3A, 0x1A,
                    0xD0, 0x11,
                    0x89,
                    0xB3,
                    0x00,
                    0xA0,
                    0xC9,
                    0x0A,
                    0x90,
                    0xAC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IInitializeObject
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x16, 0xAD, 0x22, 0x46,
                    0x23, 0xFF,
                    0xD0, 0x11,
                    0x8D,
                    0x34,
                    0x00,
                    0xA0,
                    0xC9,
                    0x0F,
                    0x27,
                    0x19
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
