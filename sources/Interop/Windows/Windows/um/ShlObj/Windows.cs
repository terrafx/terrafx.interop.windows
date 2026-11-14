// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHChangeNotifyRegisterThread"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern void SHChangeNotifyRegisterThread(SCNRT_STATUS status);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathQualify"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern void PathQualify([NativeTypeName("PWSTR")] char* psz);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsSlowA"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL PathIsSlowA([NativeTypeName("LPCSTR")] sbyte* pszFile, [NativeTypeName("DWORD")] uint dwAttr);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsSlowW"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL PathIsSlowW([NativeTypeName("LPCWSTR")] char* pszFile, [NativeTypeName("DWORD")] uint dwAttr);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreatePropSheetExtArray"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HPSXA SHCreatePropSheetExtArray(HKEY hKey, [NativeTypeName("PCWSTR")] char* pszSubKey, uint max_iface);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHOpenPropSheetW"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern BOOL SHOpenPropSheetW([NativeTypeName("LPCWSTR")] char* pszCaption, [NativeTypeName("HKEY[]")] HKEY* ahkeys, uint ckeys, [NativeTypeName("const CLSID *")] Guid* pclsidDefault, IDataObject* pdtobj, IShellBrowser* psb, [NativeTypeName("LPCWSTR")] char* pStartPage);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SoftwareUpdateMessageBox"]/*' />
    [DllImport("shdocvw", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SoftwareUpdateMessageBox(HWND hWnd, [NativeTypeName("PCWSTR")] char* pszDistUnit, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPSOFTDISTINFO")] SOFTDISTINFO* psdi);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHMultiFileProperties"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHMultiFileProperties(IDataObject* pdtobj, [NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateQueryCancelAutoPlayMoniker"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateQueryCancelAutoPlayMoniker(IMoniker** ppmoniker);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PerUserInit"]/*' />
    [DllImport("mydocs", ExactSpelling = true)]
    public static extern void PerUserInit();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ImportPrivacySettings"]/*' />
    [DllImport("shdocvw", ExactSpelling = true)]
    public static extern BOOL ImportPrivacySettings([NativeTypeName("PCWSTR")] char* pszFilename, BOOL* pfParsePrivacyPreferences, BOOL* pfParsePerSiteRules);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DoPrivacyDlg"]/*' />
    [DllImport("shdocvw", ExactSpelling = true)]
    public static extern HRESULT DoPrivacyDlg(HWND hwndOwner, [NativeTypeName("PCWSTR")] char* pszUrl, IEnumPrivacyRecords* pPrivacyEnum, BOOL fReportAllSites);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PANE_NONE"]/*' />
    [NativeTypeName("#define PANE_NONE ((DWORD)-1)")]
    public const uint PANE_NONE = unchecked((uint)(-1));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PANE_ZONE"]/*' />
    [NativeTypeName("#define PANE_ZONE 1")]
    public const int PANE_ZONE = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PANE_OFFLINE"]/*' />
    [NativeTypeName("#define PANE_OFFLINE 2")]
    public const int PANE_OFFLINE = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PANE_PRINTER"]/*' />
    [NativeTypeName("#define PANE_PRINTER 3")]
    public const int PANE_PRINTER = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PANE_SSL"]/*' />
    [NativeTypeName("#define PANE_SSL 4")]
    public const int PANE_SSL = 4;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PANE_NAVIGATION"]/*' />
    [NativeTypeName("#define PANE_NAVIGATION 5")]
    public const int PANE_NAVIGATION = 5;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PANE_PROGRESS"]/*' />
    [NativeTypeName("#define PANE_PROGRESS 6")]
    public const int PANE_PROGRESS = 6;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PANE_PRIVACY"]/*' />
    [NativeTypeName("#define PANE_PRIVACY 7")]
    public const int PANE_PRIVACY = 7;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWFRF_NORMAL"]/*' />
    [NativeTypeName("#define DWFRF_NORMAL 0x0000")]
    public const int DWFRF_NORMAL = 0x0000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWFRF_DELETECONFIGDATA"]/*' />
    [NativeTypeName("#define DWFRF_DELETECONFIGDATA 0x0001")]
    public const int DWFRF_DELETECONFIGDATA = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWFAF_HIDDEN"]/*' />
    [NativeTypeName("#define DWFAF_HIDDEN 0x0001")]
    public const int DWFAF_HIDDEN = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWFAF_GROUP1"]/*' />
    [NativeTypeName("#define DWFAF_GROUP1 0x0002")]
    public const int DWFAF_GROUP1 = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWFAF_GROUP2"]/*' />
    [NativeTypeName("#define DWFAF_GROUP2 0x0004")]
    public const int DWFAF_GROUP2 = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DWFAF_AUTOHIDE"]/*' />
    [NativeTypeName("#define DWFAF_AUTOHIDE 0x0010")]
    public const int DWFAF_AUTOHIDE = 0x0010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ISFBVIEWMODE_SMALLICONS"]/*' />
    [NativeTypeName("#define ISFBVIEWMODE_SMALLICONS 0x0001")]
    public const int ISFBVIEWMODE_SMALLICONS = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ISFBVIEWMODE_LARGEICONS"]/*' />
    [NativeTypeName("#define ISFBVIEWMODE_LARGEICONS 0x0002")]
    public const int ISFBVIEWMODE_LARGEICONS = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DBC_GS_IDEAL"]/*' />
    [NativeTypeName("#define DBC_GS_IDEAL 0")]
    public const int DBC_GS_IDEAL = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DBC_GS_SIZEDOWN"]/*' />
    [NativeTypeName("#define DBC_GS_SIZEDOWN 1")]
    public const int DBC_GS_SIZEDOWN = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DBC_HIDE"]/*' />
    [NativeTypeName("#define DBC_HIDE 0")]
    public const int DBC_HIDE = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DBC_SHOW"]/*' />
    [NativeTypeName("#define DBC_SHOW 1")]
    public const int DBC_SHOW = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DBC_SHOWOBSCURE"]/*' />
    [NativeTypeName("#define DBC_SHOWOBSCURE 2")]
    public const int DBC_SHOWOBSCURE = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSM_CLEAR"]/*' />
    [NativeTypeName("#define SSM_CLEAR 0x0000")]
    public const int SSM_CLEAR = 0x0000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSM_SET"]/*' />
    [NativeTypeName("#define SSM_SET 0x0001")]
    public const int SSM_SET = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSM_REFRESH"]/*' />
    [NativeTypeName("#define SSM_REFRESH 0x0002")]
    public const int SSM_REFRESH = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SSM_UPDATE"]/*' />
    [NativeTypeName("#define SSM_UPDATE 0x0004")]
    public const int SSM_UPDATE = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GADOF_DIRTY"]/*' />
    [NativeTypeName("#define GADOF_DIRTY 0x00000001")]
    public const int GADOF_DIRTY = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCDF_UPDATEITEM"]/*' />
    [NativeTypeName("#define SHCDF_UPDATEITEM 0x00000001")]
    public const int SHCDF_UPDATEITEM = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PathIsSlow"]/*' />
    [NativeTypeName("#define PathIsSlow PathIsSlowW")]
    public static delegate*<char*, uint, BOOL> PathIsSlow => &PathIsSlowW;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OPENPROPS_NONE"]/*' />
    [NativeTypeName("#define OPENPROPS_NONE 0x0000")]
    public const int OPENPROPS_NONE = 0x0000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OPENPROPS_INHIBITPIF"]/*' />
    [NativeTypeName("#define OPENPROPS_INHIBITPIF 0x8000")]
    public const int OPENPROPS_INHIBITPIF = 0x8000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GETPROPS_NONE"]/*' />
    [NativeTypeName("#define GETPROPS_NONE 0x0000")]
    public const int GETPROPS_NONE = 0x0000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SETPROPS_NONE"]/*' />
    [NativeTypeName("#define SETPROPS_NONE 0x0000")]
    public const int SETPROPS_NONE = 0x0000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLOSEPROPS_NONE"]/*' />
    [NativeTypeName("#define CLOSEPROPS_NONE 0x0000")]
    public const int CLOSEPROPS_NONE = 0x0000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CLOSEPROPS_DISCARD"]/*' />
    [NativeTypeName("#define CLOSEPROPS_DISCARD 0x0001")]
    public const int CLOSEPROPS_DISCARD = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHOpenPropSheet"]/*' />
    [NativeTypeName("#define SHOpenPropSheet SHOpenPropSheetW")]
    public static delegate*<char*, HKEY*, uint, Guid*, IDataObject*, IShellBrowser*, char*, BOOL> SHOpenPropSheet => &SHOpenPropSheetW;
}
