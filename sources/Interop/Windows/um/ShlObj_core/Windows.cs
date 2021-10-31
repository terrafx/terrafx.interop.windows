// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.SHARD;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHGetMalloc(IMalloc** ppMalloc);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern void* SHAlloc([NativeTypeName("SIZE_T")] nuint cb);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern void SHFree(void* pv);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern int SHGetIconOverlayIndexA([NativeTypeName("LPCSTR")] sbyte* pszIconPath, int iIconIndex);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern int SHGetIconOverlayIndexW([NativeTypeName("LPCWSTR")] ushort* pszIconPath, int iIconIndex);

        [DllImport("shell32", ExactSpelling = true)]
        [return: NativeTypeName("LPITEMIDLIST")]
        public static extern ITEMIDLIST* ILClone([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);

        [DllImport("shell32", ExactSpelling = true)]
        [return: NativeTypeName("LPITEMIDLIST")]
        public static extern ITEMIDLIST* ILCloneFirst([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);

        [DllImport("shell32", ExactSpelling = true)]
        [return: NativeTypeName("LPITEMIDLIST")]
        public static extern ITEMIDLIST* ILCombine([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl1, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl2);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern void ILFree([NativeTypeName("LPITEMIDLIST")] ITEMIDLIST* pidl);

        [DllImport("shell32", ExactSpelling = true)]
        [return: NativeTypeName("LPITEMIDLIST")]
        public static extern ITEMIDLIST* ILGetNext([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern uint ILGetSize([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);

        [DllImport("shell32", ExactSpelling = true)]
        [return: NativeTypeName("LPITEMIDLIST")]
        public static extern ITEMIDLIST* ILFindChild([NativeTypeName("LPITEMIDLIST")] ITEMIDLIST* pidlParent, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlChild);

        [DllImport("shell32", ExactSpelling = true)]
        [return: NativeTypeName("LPITEMIDLIST")]
        public static extern ITEMIDLIST* ILFindLastID([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL ILRemoveLastID([NativeTypeName("LPITEMIDLIST")] ITEMIDLIST* pidl);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL ILIsEqual([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl1, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl2);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL ILIsParent([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl1, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl2, BOOL fImmediate);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT ILSaveToStream(IStream* pstm, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);

        [DllImport("windows.storage.dll", ExactSpelling = true)]
        public static extern HRESULT ILLoadFromStreamEx(IStream* pstm, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** pidl);

        [DllImport("shell32", ExactSpelling = true)]
        [return: NativeTypeName("LPITEMIDLIST")]
        public static extern ITEMIDLIST* ILCreateFromPathA([NativeTypeName("PCSTR")] sbyte* pszPath);

        [DllImport("shell32", ExactSpelling = true)]
        [return: NativeTypeName("LPITEMIDLIST")]
        public static extern ITEMIDLIST* ILCreateFromPathW([NativeTypeName("PCWSTR")] ushort* pszPath);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHILCreateFromPath([NativeTypeName("PCWSTR")] ushort* pszPath, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl, [NativeTypeName("DWORD *")] uint* rgfInOut);

        [DllImport("shell32", ExactSpelling = true)]
        [return: NativeTypeName("LPITEMIDLIST")]
        public static extern ITEMIDLIST* ILAppendID([NativeTypeName("LPITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPCSHITEMID")] SHITEMID* pmkid, BOOL fAppend);

        public const int GPFIDL_DEFAULT = 0x0000;
        public const int GPFIDL_ALTNAME = 0x0001;
        public const int GPFIDL_UNCPRINTER = 0x0002;

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL SHGetPathFromIDListEx([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("DWORD")] uint cchPath, [NativeTypeName("GPFIDL_FLAGS")] int uOpts);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL SHGetPathFromIDListA([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPSTR")] sbyte* pszPath);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL SHGetPathFromIDListW([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPWSTR")] ushort* pszPath);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern int SHCreateDirectory(HWND hwnd, [NativeTypeName("PCWSTR")] ushort* pszPath);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern int SHCreateDirectoryExA(HWND hwnd, [NativeTypeName("LPCSTR")] sbyte* pszPath, [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* psa);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern int SHCreateDirectoryExW(HWND hwnd, [NativeTypeName("LPCWSTR")] ushort* pszPath, [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* psa);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHOpenFolderAndSelectItems([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHCreateShellItem([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlParent, IShellFolder* psfParent, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, IShellItem** ppsi);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHGetSpecialFolderLocation(HWND hwnd, int csidl, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl);

        [DllImport("shell32", ExactSpelling = true)]
        [return: NativeTypeName("LPITEMIDLIST")]
        public static extern ITEMIDLIST* SHCloneSpecialIDList(HWND hwnd, int csidl, BOOL fCreate);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL SHGetSpecialFolderPathA(HWND hwnd, [NativeTypeName("LPSTR")] sbyte* pszPath, int csidl, BOOL fCreate);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL SHGetSpecialFolderPathW(HWND hwnd, [NativeTypeName("LPWSTR")] ushort* pszPath, int csidl, BOOL fCreate);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern void SHFlushSFCache();

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHGetFolderPathA(HWND hwnd, int csidl, HANDLE hToken, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPSTR")] sbyte* pszPath);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHGetFolderPathW(HWND hwnd, int csidl, HANDLE hToken, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPWSTR")] ushort* pszPath);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHGetFolderLocation(HWND hwnd, int csidl, HANDLE hToken, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHSetFolderPathA(int csidl, HANDLE hToken, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCSTR")] sbyte* pszPath);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHSetFolderPathW(int csidl, HANDLE hToken, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pszPath);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHGetFolderPathAndSubDirA(HWND hwnd, int csidl, HANDLE hToken, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCSTR")] sbyte* pszSubDir, [NativeTypeName("LPSTR")] sbyte* pszPath);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHGetFolderPathAndSubDirW(HWND hwnd, int csidl, HANDLE hToken, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* pszSubDir, [NativeTypeName("LPWSTR")] ushort* pszPath);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHGetKnownFolderIDList([NativeTypeName("const KNOWNFOLDERID &")] Guid* rfid, [NativeTypeName("DWORD")] uint dwFlags, HANDLE hToken, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHSetKnownFolderPath([NativeTypeName("const KNOWNFOLDERID &")] Guid* rfid, [NativeTypeName("DWORD")] uint dwFlags, HANDLE hToken, [NativeTypeName("PCWSTR")] ushort* pszPath);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHGetKnownFolderPath([NativeTypeName("const KNOWNFOLDERID &")] Guid* rfid, [NativeTypeName("DWORD")] uint dwFlags, HANDLE hToken, [NativeTypeName("PWSTR *")] ushort** ppszPath);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHGetKnownFolderItem([NativeTypeName("const KNOWNFOLDERID &")] Guid* rfid, KNOWN_FOLDER_FLAG flags, HANDLE hToken, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHGetSetFolderCustomSettings([NativeTypeName("LPSHFOLDERCUSTOMSETTINGS")] SHFOLDERCUSTOMSETTINGS* pfcs, [NativeTypeName("PCWSTR")] ushort* pszPath, [NativeTypeName("DWORD")] uint dwReadWrite);

        [DllImport("shell32", ExactSpelling = true)]
        [return: NativeTypeName("LPITEMIDLIST")]
        public static extern ITEMIDLIST* SHBrowseForFolderA([NativeTypeName("LPBROWSEINFOA")] BROWSEINFOA* lpbi);

        [DllImport("shell32", ExactSpelling = true)]
        [return: NativeTypeName("LPITEMIDLIST")]
        public static extern ITEMIDLIST* SHBrowseForFolderW([NativeTypeName("LPBROWSEINFOW")] BROWSEINFOW* lpbi);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHLoadInProc([NativeTypeName("const IID &")] Guid* rclsid);

        public const int ISHCUTCMDID_DOWNLOADICON = 0;
        public const int ISHCUTCMDID_INTSHORTCUTCREATE = 1;
        public const int ISHCUTCMDID_COMMITHISTORY = 2;
        public const int ISHCUTCMDID_SETUSERAWURL = 3;

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHGetDesktopFolder(IShellFolder** ppshf);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern void SHChangeNotify([NativeTypeName("LONG")] int wEventId, uint uFlags, [NativeTypeName("LPCVOID")] void* dwItem1, [NativeTypeName("LPCVOID")] void* dwItem2);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern void SHAddToRecentDocs(uint uFlags, [NativeTypeName("LPCVOID")] void* pv);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern int SHHandleUpdateImage([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlExtra);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern void SHUpdateImageA([NativeTypeName("LPCSTR")] sbyte* pszHashItem, int iIndex, uint uFlags, int iImageIndex);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern void SHUpdateImageW([NativeTypeName("LPCWSTR")] ushort* pszHashItem, int iIndex, uint uFlags, int iImageIndex);

        [DllImport("shell32", ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint SHChangeNotifyRegister(HWND hwnd, int fSources, [NativeTypeName("LONG")] int fEvents, uint wMsg, int cEntries, [NativeTypeName("const SHChangeNotifyEntry *")] SHChangeNotifyEntry* pshcne);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL SHChangeNotifyDeregister([NativeTypeName("ULONG")] uint ulID);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HANDLE SHChangeNotification_Lock(HANDLE hChange, [NativeTypeName("DWORD")] uint dwProcId, [NativeTypeName("LPITEMIDLIST **")] ITEMIDLIST*** pppidl, [NativeTypeName("LONG *")] int* plEvent);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL SHChangeNotification_Unlock(HANDLE hLock);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHGetRealIDL(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlSimple, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlReal);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHGetInstanceExplorer(IUnknown** ppunk);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHGetDataFromIDListA(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, int nFormat, void* pv, int cb);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHGetDataFromIDListW(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, int nFormat, void* pv, int cb);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern int RestartDialog(HWND hwnd, [NativeTypeName("PCWSTR")] ushort* pszPrompt, [NativeTypeName("DWORD")] uint dwReturn);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern int RestartDialogEx(HWND hwnd, [NativeTypeName("PCWSTR")] ushort* pszPrompt, [NativeTypeName("DWORD")] uint dwReturn, [NativeTypeName("DWORD")] uint dwReasonCode);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHCoCreateInstance([NativeTypeName("PCWSTR")] ushort* pszCLSID, [NativeTypeName("const CLSID *")] Guid* pclsid, IUnknown* pUnkOuter, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHCreateDataObject([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, IDataObject* pdtInner, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT CIDLData_CreateFromIDArray([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, IDataObject** ppdtobj);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHCreateStdEnumFmtEtc(uint cfmt, [NativeTypeName("const FORMATETC []")] FORMATETC* afmt, IEnumFORMATETC** ppenumFormatEtc);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHDoDragDrop(HWND hwnd, IDataObject* pdata, IDropSource* pdsrc, [NativeTypeName("DWORD")] uint dwEffect, [NativeTypeName("DWORD *")] uint* pdwEffect);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL DAD_SetDragImage(HIMAGELIST him, POINT* pptOffset);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL DAD_DragEnterEx(HWND hwndTarget, [NativeTypeName("const POINT")] POINT ptStart);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL DAD_DragEnterEx2(HWND hwndTarget, [NativeTypeName("const POINT")] POINT ptStart, IDataObject* pdtObject);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL DAD_ShowDragImage(BOOL fShow);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL DAD_DragMove(POINT pt);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL DAD_DragLeave();

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL DAD_AutoScroll(HWND hwnd, AUTO_SCROLL_DATA* pad, [NativeTypeName("const POINT *")] POINT* pptNow);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL ReadCabinetState(CABINETSTATE* pcs, int cLength);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL WriteCabinetState(CABINETSTATE* pcs);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL PathMakeUniqueName([NativeTypeName("PWSTR")] ushort* pszUniqueName, uint cchMax, [NativeTypeName("PCWSTR")] ushort* pszTemplate, [NativeTypeName("PCWSTR")] ushort* pszLongPlate, [NativeTypeName("PCWSTR")] ushort* pszDir);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL PathIsExe([NativeTypeName("PCWSTR")] ushort* pszPath);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern int PathCleanupSpec([NativeTypeName("PCWSTR")] ushort* pszDir, [NativeTypeName("PWSTR")] ushort* pszSpec);

        [DllImport("shell32", ExactSpelling = true, SetLastError = true)]
        public static extern int PathResolve([NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("PZPCWSTR")] ushort** dirs, uint fFlags);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL GetFileNameFromBrowse(HWND hwnd, [NativeTypeName("PWSTR")] ushort* pszFilePath, uint cchFilePath, [NativeTypeName("PCWSTR")] ushort* pszWorkingDir, [NativeTypeName("PCWSTR")] ushort* pszDefExt, [NativeTypeName("PCWSTR")] ushort* pszFilters, [NativeTypeName("PCWSTR")] ushort* pszTitle);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern int DriveType(int iDrive);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern int RealDriveType(int iDrive, BOOL fOKToHitNet);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern int IsNetDrive(int iDrive);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern uint Shell_MergeMenus(HMENU hmDst, HMENU hmSrc, uint uInsert, uint uIDAdjust, uint uIDAdjustMax, [NativeTypeName("ULONG")] uint uFlags);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL SHObjectProperties(HWND hwnd, [NativeTypeName("DWORD")] uint shopObjectType, [NativeTypeName("PCWSTR")] ushort* pszObjectName, [NativeTypeName("PCWSTR")] ushort* pszPropertyPage);

        [DllImport("shell32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SHFormatDrive(HWND hwnd, uint drive, uint fmtID, uint options);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern void SHDestroyPropSheetExtArray(HPSXA hpsxa);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern uint SHAddFromPropSheetExtArray(HPSXA hpsxa, [NativeTypeName("LPFNADDPROPSHEETPAGE")] delegate* unmanaged<HPROPSHEETPAGE, nint, BOOL> lpfnAddPage, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern uint SHReplaceFromPropSheetExtArray(HPSXA hpsxa, uint uPageID, [NativeTypeName("LPFNADDPROPSHEETPAGE")] delegate* unmanaged<HPROPSHEETPAGE, nint, BOOL> lpfnReplaceWith, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern IStream* OpenRegStream(HKEY hkey, [NativeTypeName("PCWSTR")] ushort* pszSubkey, [NativeTypeName("PCWSTR")] ushort* pszValue, [NativeTypeName("DWORD")] uint grfMode);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL SHFindFiles([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlSaveFile);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern void PathGetShortPath([NativeTypeName("PWSTR")] ushort* pszLongPath);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL PathYetAnotherMakeUniqueName([NativeTypeName("PWSTR")] ushort* pszUniqueName, [NativeTypeName("PCWSTR")] ushort* pszPath, [NativeTypeName("PCWSTR")] ushort* pszShort, [NativeTypeName("PCWSTR")] ushort* pszFileSpec);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL Win32DeleteFile([NativeTypeName("PCWSTR")] ushort* pszPath);

        [DllImport("shell32", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint SHRestricted(RESTRICTIONS rest);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL SignalFileOpen([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT AssocGetDetailsOfPropKey(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* pkey, VARIANT* pv, BOOL* pfFoundPropKey);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHStartNetConnectionDialogW(HWND hwnd, [NativeTypeName("LPCWSTR")] ushort* pszRemoteName, [NativeTypeName("DWORD")] uint dwType);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHDefExtractIconA([NativeTypeName("LPCSTR")] sbyte* pszIconFile, int iIndex, uint uFlags, HICON* phiconLarge, HICON* phiconSmall, uint nIconSize);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHDefExtractIconW([NativeTypeName("LPCWSTR")] ushort* pszIconFile, int iIndex, uint uFlags, HICON* phiconLarge, HICON* phiconSmall, uint nIconSize);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHOpenWithDialog(HWND hwndParent, [NativeTypeName("const OPENASINFO *")] OPENASINFO* poainfo);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL Shell_GetImageLists(HIMAGELIST* phiml, HIMAGELIST* phimlSmall);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern int Shell_GetCachedImageIndexA([NativeTypeName("LPCSTR")] sbyte* pszIconPath, int iIconIndex, uint uIconFlags);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern int Shell_GetCachedImageIndexW([NativeTypeName("LPCWSTR")] ushort* pszIconPath, int iIconIndex, uint uIconFlags);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL SHValidateUNC(HWND hwndOwner, [NativeTypeName("PWSTR")] ushort* pszFile, uint fConnect);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HANDLE PifMgr_OpenProperties([NativeTypeName("PCWSTR")] ushort* pszApp, [NativeTypeName("PCWSTR")] ushort* pszPIF, uint hInf, uint flOpt);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern int PifMgr_GetProperties(HANDLE hProps, [NativeTypeName("PCSTR")] sbyte* pszGroup, void* lpProps, int cbProps, uint flOpt);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern int PifMgr_SetProperties(HANDLE hProps, [NativeTypeName("PCSTR")] sbyte* pszGroup, [NativeTypeName("const void *")] void* lpProps, int cbProps, uint flOpt);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HANDLE PifMgr_CloseProperties(HANDLE hProps, uint flOpt);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern void SHSetInstanceExplorer(IUnknown* punk);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern BOOL IsUserAnAdmin();

        [DllImport("shell32", ExactSpelling = true)]
        [return: NativeTypeName("LRESULT")]
        public static extern nint SHShellFolderView_Message(HWND hwndMain, uint uMsg, [NativeTypeName("LPARAM")] nint lParam);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHCreateShellFolderView([NativeTypeName("const SFV_CREATE *")] SFV_CREATE* pcsfv, IShellView** ppsv);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT CDefFolderMenu_Create2([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, HWND hwnd, uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, IShellFolder* psf, [NativeTypeName("LPFNDFMCALLBACK")] delegate* unmanaged<IShellFolder*, HWND, IDataObject*, uint, nuint, nint, HRESULT> pfn, uint nKeys, [NativeTypeName("const HKEY *")] HKEY* ahkeys, IContextMenu** ppcm);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHCreateDefaultContextMenu([NativeTypeName("const DEFCONTEXTMENU *")] DEFCONTEXTMENU* pdcm, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern IContextMenu* SHFind_InitMenuPopup(HMENU hmenu, HWND hwndOwner, uint idCmdFirst, uint idCmdLast);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHCreateShellFolderViewEx(CSFV* pcsfv, IShellView** ppsv);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern void SHGetSetSettings([NativeTypeName("LPSHELLSTATEW")] SHELLSTATEW* lpss, [NativeTypeName("DWORD")] uint dwMask, BOOL bSet);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern void SHGetSettings(SHELLFLAGSTATE* psfs, [NativeTypeName("DWORD")] uint dwMask);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHBindToParent([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("const IID &")] Guid* riid, void** ppv, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** ppidlLast);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHBindToFolderIDListParent(IShellFolder* psfRoot, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("const IID &")] Guid* riid, void** ppv, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** ppidlLast);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHBindToFolderIDListParentEx(IShellFolder* psfRoot, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, IBindCtx* ppbc, [NativeTypeName("const IID &")] Guid* riid, void** ppv, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** ppidlLast);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHBindToObject(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        public static BOOL IDListContainerIsConsistent([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, uint cbAlloc)
        {
            uint cbPidl = 2;

            while (cbPidl <= cbAlloc && pidl->mkid.cb >= sizeof(ushort) && pidl->mkid.cb <= cbAlloc - unchecked(cbPidl))
            {
                unchecked(cbPidl) += pidl->mkid.cb;
                pidl = ((ITEMIDLIST*)((void*)(((byte*)((pidl))) + (((pidl)->mkid.cb)))));
            }

            return (cbPidl <= cbAlloc && 0 == pidl->mkid.cb) ? 1 : 0;
        }

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHParseDisplayName([NativeTypeName("PCWSTR")] ushort* pszName, IBindCtx* pbc, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl, [NativeTypeName("SFGAOF")] uint sfgaoIn, [NativeTypeName("SFGAOF *")] uint* psfgaoOut);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHPathPrepareForWriteA(HWND hwnd, IUnknown* punkEnableModless, [NativeTypeName("LPCSTR")] sbyte* pszPath, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHPathPrepareForWriteW(HWND hwnd, IUnknown* punkEnableModless, [NativeTypeName("LPCWSTR")] ushort* pszPath, [NativeTypeName("DWORD")] uint dwFlags);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHPropStgCreate(IPropertySetStorage* psstg, [NativeTypeName("const IID &")] Guid* fmtid, [NativeTypeName("const CLSID *")] Guid* pclsid, [NativeTypeName("DWORD")] uint grfFlags, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint dwDisposition, IPropertyStorage** ppstg, uint* puCodePage);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHPropStgReadMultiple(IPropertyStorage* pps, uint uCodePage, [NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC []")] PROPSPEC* rgpspec, [NativeTypeName("PROPVARIANT []")] PROPVARIANT* rgvar);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHPropStgWriteMultiple(IPropertyStorage* pps, uint* puCodePage, [NativeTypeName("ULONG")] uint cpspec, [NativeTypeName("const PROPSPEC []")] PROPSPEC* rgpspec, [NativeTypeName("PROPVARIANT []")] PROPVARIANT* rgvar, [NativeTypeName("PROPID")] uint propidNameFirst);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHCreateFileExtractIconW([NativeTypeName("LPCWSTR")] ushort* pszFile, [NativeTypeName("DWORD")] uint dwFileAttributes, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHLimitInputEdit(HWND hwndEdit, IShellFolder* psf);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHGetAttributesFromDataObject(IDataObject* pdo, [NativeTypeName("DWORD")] uint dwAttributeMask, [NativeTypeName("DWORD *")] uint* pdwAttributes, uint* pcItems);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern int SHMapPIDLToSystemImageListIndex(IShellFolder* pshf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, int* piIndexSel);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHCLSIDFromString([NativeTypeName("PCWSTR")] ushort* psz, [NativeTypeName("CLSID *")] Guid* pclsid);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern int PickIconDlg(HWND hwnd, [NativeTypeName("PWSTR")] ushort* pszIconPath, uint cchIconPath, int* piIconIndex);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT StgMakeUniqueName(IStorage* pstgParent, [NativeTypeName("PCWSTR")] ushort* pszFileSpec, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [NativeTypeName("#define GIL_OPENICON 0x0001")]
        public const int GIL_OPENICON = 0x0001;

        [NativeTypeName("#define GIL_FORSHELL 0x0002")]
        public const int GIL_FORSHELL = 0x0002;

        [NativeTypeName("#define GIL_ASYNC 0x0020")]
        public const int GIL_ASYNC = 0x0020;

        [NativeTypeName("#define GIL_DEFAULTICON 0x0040")]
        public const int GIL_DEFAULTICON = 0x0040;

        [NativeTypeName("#define GIL_FORSHORTCUT 0x0080")]
        public const int GIL_FORSHORTCUT = 0x0080;

        [NativeTypeName("#define GIL_CHECKSHIELD 0x0200")]
        public const int GIL_CHECKSHIELD = 0x0200;

        [NativeTypeName("#define GIL_SIMULATEDOC 0x0001")]
        public const int GIL_SIMULATEDOC = 0x0001;

        [NativeTypeName("#define GIL_PERINSTANCE 0x0002")]
        public const int GIL_PERINSTANCE = 0x0002;

        [NativeTypeName("#define GIL_PERCLASS 0x0004")]
        public const int GIL_PERCLASS = 0x0004;

        [NativeTypeName("#define GIL_NOTFILENAME 0x0008")]
        public const int GIL_NOTFILENAME = 0x0008;

        [NativeTypeName("#define GIL_DONTCACHE 0x0010")]
        public const int GIL_DONTCACHE = 0x0010;

        [NativeTypeName("#define GIL_SHIELD 0x0200")]
        public const int GIL_SHIELD = 0x0200;

        [NativeTypeName("#define GIL_FORCENOSHIELD 0x0400")]
        public const int GIL_FORCENOSHIELD = 0x0400;

        [NativeTypeName("#define SIOM_OVERLAYINDEX 0x1")]
        public const int SIOM_OVERLAYINDEX = 0x1;

        [NativeTypeName("#define SIOM_ICONINDEX 0x2")]
        public const int SIOM_ICONINDEX = 0x2;

        [NativeTypeName("#define SIOM_RESERVED_SHARED 0")]
        public const int SIOM_RESERVED_SHARED = 0;

        [NativeTypeName("#define SIOM_RESERVED_LINK 1")]
        public const int SIOM_RESERVED_LINK = 1;

        [NativeTypeName("#define SIOM_RESERVED_SLOWFILE 2")]
        public const int SIOM_RESERVED_SLOWFILE = 2;

        [NativeTypeName("#define SIOM_RESERVED_DEFAULT 3")]
        public const int SIOM_RESERVED_DEFAULT = 3;

        [NativeTypeName("#define OI_DEFAULT 0x00000000")]
        public const int OI_DEFAULT = 0x00000000;

        [NativeTypeName("#define OI_ASYNC 0xFFFFEEEE")]
        public const uint OI_ASYNC = 0xFFFFEEEE;

        [NativeTypeName("#define IDO_SHGIOI_SHARE 0x0FFFFFFF")]
        public const int IDO_SHGIOI_SHARE = 0x0FFFFFFF;

        [NativeTypeName("#define IDO_SHGIOI_LINK 0x0FFFFFFE")]
        public const int IDO_SHGIOI_LINK = 0x0FFFFFFE;

        [NativeTypeName("#define IDO_SHGIOI_SLOWFILE 0x0FFFFFFFD")]
        public const uint IDO_SHGIOI_SLOWFILE = 0x0FFFFFFFD;

        [NativeTypeName("#define IDO_SHGIOI_DEFAULT 0x0FFFFFFFC")]
        public const uint IDO_SHGIOI_DEFAULT = 0x0FFFFFFFC;

        [NativeTypeName("#define SHGetIconOverlayIndex SHGetIconOverlayIndexW")]
        public static delegate*<ushort*, int, int> SHGetIconOverlayIndex => &SHGetIconOverlayIndexW;

        [NativeTypeName("#define NT_CONSOLE_PROPS_SIG 0xA0000002")]
        public const uint NT_CONSOLE_PROPS_SIG = 0xA0000002;

        [NativeTypeName("#define NT_FE_CONSOLE_PROPS_SIG 0xA0000004")]
        public const uint NT_FE_CONSOLE_PROPS_SIG = 0xA0000004;

        [NativeTypeName("#define EXP_DARWIN_ID_SIG 0xA0000006")]
        public const uint EXP_DARWIN_ID_SIG = 0xA0000006;

        [NativeTypeName("#define EXP_SPECIAL_FOLDER_SIG 0xA0000005")]
        public const uint EXP_SPECIAL_FOLDER_SIG = 0xA0000005;

        [NativeTypeName("#define EXP_SZ_LINK_SIG 0xA0000001")]
        public const uint EXP_SZ_LINK_SIG = 0xA0000001;

        [NativeTypeName("#define EXP_SZ_ICON_SIG 0xA0000007")]
        public const uint EXP_SZ_ICON_SIG = 0xA0000007;

        [NativeTypeName("#define EXP_PROPERTYSTORAGE_SIG 0xA0000009")]
        public const uint EXP_PROPERTYSTORAGE_SIG = 0xA0000009;

        [NativeTypeName("#define FCIDM_SHVIEWFIRST 0x0000")]
        public const int FCIDM_SHVIEWFIRST = 0x0000;

        [NativeTypeName("#define FCIDM_SHVIEWLAST 0x7fff")]
        public const int FCIDM_SHVIEWLAST = 0x7fff;

        [NativeTypeName("#define FCIDM_BROWSERFIRST 0xa000")]
        public const int FCIDM_BROWSERFIRST = 0xa000;

        [NativeTypeName("#define FCIDM_BROWSERLAST 0xbf00")]
        public const int FCIDM_BROWSERLAST = 0xbf00;

        [NativeTypeName("#define FCIDM_GLOBALFIRST 0x8000")]
        public const int FCIDM_GLOBALFIRST = 0x8000;

        [NativeTypeName("#define FCIDM_GLOBALLAST 0x9fff")]
        public const int FCIDM_GLOBALLAST = 0x9fff;

        [NativeTypeName("#define FCIDM_MENU_FILE (FCIDM_GLOBALFIRST+0x0000)")]
        public const int FCIDM_MENU_FILE = (0x8000 + 0x0000);

        [NativeTypeName("#define FCIDM_MENU_EDIT (FCIDM_GLOBALFIRST+0x0040)")]
        public const int FCIDM_MENU_EDIT = (0x8000 + 0x0040);

        [NativeTypeName("#define FCIDM_MENU_VIEW (FCIDM_GLOBALFIRST+0x0080)")]
        public const int FCIDM_MENU_VIEW = (0x8000 + 0x0080);

        [NativeTypeName("#define FCIDM_MENU_VIEW_SEP_OPTIONS (FCIDM_GLOBALFIRST+0x0081)")]
        public const int FCIDM_MENU_VIEW_SEP_OPTIONS = (0x8000 + 0x0081);

        [NativeTypeName("#define FCIDM_MENU_TOOLS (FCIDM_GLOBALFIRST+0x00c0)")]
        public const int FCIDM_MENU_TOOLS = (0x8000 + 0x00c0);

        [NativeTypeName("#define FCIDM_MENU_TOOLS_SEP_GOTO (FCIDM_GLOBALFIRST+0x00c1)")]
        public const int FCIDM_MENU_TOOLS_SEP_GOTO = (0x8000 + 0x00c1);

        [NativeTypeName("#define FCIDM_MENU_HELP (FCIDM_GLOBALFIRST+0x0100)")]
        public const int FCIDM_MENU_HELP = (0x8000 + 0x0100);

        [NativeTypeName("#define FCIDM_MENU_FIND (FCIDM_GLOBALFIRST+0x0140)")]
        public const int FCIDM_MENU_FIND = (0x8000 + 0x0140);

        [NativeTypeName("#define FCIDM_MENU_EXPLORE (FCIDM_GLOBALFIRST+0x0150)")]
        public const int FCIDM_MENU_EXPLORE = (0x8000 + 0x0150);

        [NativeTypeName("#define FCIDM_MENU_FAVORITES (FCIDM_GLOBALFIRST+0x0170)")]
        public const int FCIDM_MENU_FAVORITES = (0x8000 + 0x0170);

        [NativeTypeName("#define ILCreateFromPath ILCreateFromPathW")]
        public static delegate*<ushort*, ITEMIDLIST*> ILCreateFromPath => &ILCreateFromPathW;

        [NativeTypeName("#define ILCloneFull ILClone")]
        public static delegate*<ITEMIDLIST*, ITEMIDLIST*> ILCloneFull => &ILClone;

        [NativeTypeName("#define ILCloneChild ILCloneFirst")]
        public static delegate*<ITEMIDLIST*, ITEMIDLIST*> ILCloneChild => &ILCloneFirst;

        [NativeTypeName("#define SHGetPathFromIDList SHGetPathFromIDListW")]
        public static delegate*<ITEMIDLIST*, ushort*, BOOL> SHGetPathFromIDList => &SHGetPathFromIDListW;

        [NativeTypeName("#define SHCreateDirectoryEx SHCreateDirectoryExW")]
        public static delegate*<HWND, ushort*, SECURITY_ATTRIBUTES*, int> SHCreateDirectoryEx => &SHCreateDirectoryExW;

        [NativeTypeName("#define OFASI_EDIT 0x0001")]
        public const int OFASI_EDIT = 0x0001;

        [NativeTypeName("#define OFASI_OPENDESKTOP 0x0002")]
        public const int OFASI_OPENDESKTOP = 0x0002;

        [NativeTypeName("#define CSIDL_DESKTOP 0x0000")]
        public const int CSIDL_DESKTOP = 0x0000;

        [NativeTypeName("#define CSIDL_INTERNET 0x0001")]
        public const int CSIDL_INTERNET = 0x0001;

        [NativeTypeName("#define CSIDL_PROGRAMS 0x0002")]
        public const int CSIDL_PROGRAMS = 0x0002;

        [NativeTypeName("#define CSIDL_CONTROLS 0x0003")]
        public const int CSIDL_CONTROLS = 0x0003;

        [NativeTypeName("#define CSIDL_PRINTERS 0x0004")]
        public const int CSIDL_PRINTERS = 0x0004;

        [NativeTypeName("#define CSIDL_PERSONAL 0x0005")]
        public const int CSIDL_PERSONAL = 0x0005;

        [NativeTypeName("#define CSIDL_FAVORITES 0x0006")]
        public const int CSIDL_FAVORITES = 0x0006;

        [NativeTypeName("#define CSIDL_STARTUP 0x0007")]
        public const int CSIDL_STARTUP = 0x0007;

        [NativeTypeName("#define CSIDL_RECENT 0x0008")]
        public const int CSIDL_RECENT = 0x0008;

        [NativeTypeName("#define CSIDL_SENDTO 0x0009")]
        public const int CSIDL_SENDTO = 0x0009;

        [NativeTypeName("#define CSIDL_BITBUCKET 0x000a")]
        public const int CSIDL_BITBUCKET = 0x000a;

        [NativeTypeName("#define CSIDL_STARTMENU 0x000b")]
        public const int CSIDL_STARTMENU = 0x000b;

        [NativeTypeName("#define CSIDL_MYDOCUMENTS CSIDL_PERSONAL")]
        public const int CSIDL_MYDOCUMENTS = 0x0005;

        [NativeTypeName("#define CSIDL_MYMUSIC 0x000d")]
        public const int CSIDL_MYMUSIC = 0x000d;

        [NativeTypeName("#define CSIDL_MYVIDEO 0x000e")]
        public const int CSIDL_MYVIDEO = 0x000e;

        [NativeTypeName("#define CSIDL_DESKTOPDIRECTORY 0x0010")]
        public const int CSIDL_DESKTOPDIRECTORY = 0x0010;

        [NativeTypeName("#define CSIDL_DRIVES 0x0011")]
        public const int CSIDL_DRIVES = 0x0011;

        [NativeTypeName("#define CSIDL_NETWORK 0x0012")]
        public const int CSIDL_NETWORK = 0x0012;

        [NativeTypeName("#define CSIDL_NETHOOD 0x0013")]
        public const int CSIDL_NETHOOD = 0x0013;

        [NativeTypeName("#define CSIDL_FONTS 0x0014")]
        public const int CSIDL_FONTS = 0x0014;

        [NativeTypeName("#define CSIDL_TEMPLATES 0x0015")]
        public const int CSIDL_TEMPLATES = 0x0015;

        [NativeTypeName("#define CSIDL_COMMON_STARTMENU 0x0016")]
        public const int CSIDL_COMMON_STARTMENU = 0x0016;

        [NativeTypeName("#define CSIDL_COMMON_PROGRAMS 0X0017")]
        public const int CSIDL_COMMON_PROGRAMS = 0X0017;

        [NativeTypeName("#define CSIDL_COMMON_STARTUP 0x0018")]
        public const int CSIDL_COMMON_STARTUP = 0x0018;

        [NativeTypeName("#define CSIDL_COMMON_DESKTOPDIRECTORY 0x0019")]
        public const int CSIDL_COMMON_DESKTOPDIRECTORY = 0x0019;

        [NativeTypeName("#define CSIDL_APPDATA 0x001a")]
        public const int CSIDL_APPDATA = 0x001a;

        [NativeTypeName("#define CSIDL_PRINTHOOD 0x001b")]
        public const int CSIDL_PRINTHOOD = 0x001b;

        [NativeTypeName("#define CSIDL_LOCAL_APPDATA 0x001c")]
        public const int CSIDL_LOCAL_APPDATA = 0x001c;

        [NativeTypeName("#define CSIDL_ALTSTARTUP 0x001d")]
        public const int CSIDL_ALTSTARTUP = 0x001d;

        [NativeTypeName("#define CSIDL_COMMON_ALTSTARTUP 0x001e")]
        public const int CSIDL_COMMON_ALTSTARTUP = 0x001e;

        [NativeTypeName("#define CSIDL_COMMON_FAVORITES 0x001f")]
        public const int CSIDL_COMMON_FAVORITES = 0x001f;

        [NativeTypeName("#define CSIDL_INTERNET_CACHE 0x0020")]
        public const int CSIDL_INTERNET_CACHE = 0x0020;

        [NativeTypeName("#define CSIDL_COOKIES 0x0021")]
        public const int CSIDL_COOKIES = 0x0021;

        [NativeTypeName("#define CSIDL_HISTORY 0x0022")]
        public const int CSIDL_HISTORY = 0x0022;

        [NativeTypeName("#define CSIDL_COMMON_APPDATA 0x0023")]
        public const int CSIDL_COMMON_APPDATA = 0x0023;

        [NativeTypeName("#define CSIDL_WINDOWS 0x0024")]
        public const int CSIDL_WINDOWS = 0x0024;

        [NativeTypeName("#define CSIDL_SYSTEM 0x0025")]
        public const int CSIDL_SYSTEM = 0x0025;

        [NativeTypeName("#define CSIDL_PROGRAM_FILES 0x0026")]
        public const int CSIDL_PROGRAM_FILES = 0x0026;

        [NativeTypeName("#define CSIDL_MYPICTURES 0x0027")]
        public const int CSIDL_MYPICTURES = 0x0027;

        [NativeTypeName("#define CSIDL_PROFILE 0x0028")]
        public const int CSIDL_PROFILE = 0x0028;

        [NativeTypeName("#define CSIDL_SYSTEMX86 0x0029")]
        public const int CSIDL_SYSTEMX86 = 0x0029;

        [NativeTypeName("#define CSIDL_PROGRAM_FILESX86 0x002a")]
        public const int CSIDL_PROGRAM_FILESX86 = 0x002a;

        [NativeTypeName("#define CSIDL_PROGRAM_FILES_COMMON 0x002b")]
        public const int CSIDL_PROGRAM_FILES_COMMON = 0x002b;

        [NativeTypeName("#define CSIDL_PROGRAM_FILES_COMMONX86 0x002c")]
        public const int CSIDL_PROGRAM_FILES_COMMONX86 = 0x002c;

        [NativeTypeName("#define CSIDL_COMMON_TEMPLATES 0x002d")]
        public const int CSIDL_COMMON_TEMPLATES = 0x002d;

        [NativeTypeName("#define CSIDL_COMMON_DOCUMENTS 0x002e")]
        public const int CSIDL_COMMON_DOCUMENTS = 0x002e;

        [NativeTypeName("#define CSIDL_COMMON_ADMINTOOLS 0x002f")]
        public const int CSIDL_COMMON_ADMINTOOLS = 0x002f;

        [NativeTypeName("#define CSIDL_ADMINTOOLS 0x0030")]
        public const int CSIDL_ADMINTOOLS = 0x0030;

        [NativeTypeName("#define CSIDL_CONNECTIONS 0x0031")]
        public const int CSIDL_CONNECTIONS = 0x0031;

        [NativeTypeName("#define CSIDL_COMMON_MUSIC 0x0035")]
        public const int CSIDL_COMMON_MUSIC = 0x0035;

        [NativeTypeName("#define CSIDL_COMMON_PICTURES 0x0036")]
        public const int CSIDL_COMMON_PICTURES = 0x0036;

        [NativeTypeName("#define CSIDL_COMMON_VIDEO 0x0037")]
        public const int CSIDL_COMMON_VIDEO = 0x0037;

        [NativeTypeName("#define CSIDL_RESOURCES 0x0038")]
        public const int CSIDL_RESOURCES = 0x0038;

        [NativeTypeName("#define CSIDL_RESOURCES_LOCALIZED 0x0039")]
        public const int CSIDL_RESOURCES_LOCALIZED = 0x0039;

        [NativeTypeName("#define CSIDL_COMMON_OEM_LINKS 0x003a")]
        public const int CSIDL_COMMON_OEM_LINKS = 0x003a;

        [NativeTypeName("#define CSIDL_CDBURN_AREA 0x003b")]
        public const int CSIDL_CDBURN_AREA = 0x003b;

        [NativeTypeName("#define CSIDL_COMPUTERSNEARME 0x003d")]
        public const int CSIDL_COMPUTERSNEARME = 0x003d;

        [NativeTypeName("#define CSIDL_FLAG_CREATE 0x8000")]
        public const int CSIDL_FLAG_CREATE = 0x8000;

        [NativeTypeName("#define CSIDL_FLAG_DONT_VERIFY 0x4000")]
        public const int CSIDL_FLAG_DONT_VERIFY = 0x4000;

        [NativeTypeName("#define CSIDL_FLAG_DONT_UNEXPAND 0x2000")]
        public const int CSIDL_FLAG_DONT_UNEXPAND = 0x2000;

        [NativeTypeName("#define CSIDL_FLAG_NO_ALIAS 0x1000")]
        public const int CSIDL_FLAG_NO_ALIAS = 0x1000;

        [NativeTypeName("#define CSIDL_FLAG_PER_USER_INIT 0x0800")]
        public const int CSIDL_FLAG_PER_USER_INIT = 0x0800;

        [NativeTypeName("#define CSIDL_FLAG_MASK 0xFF00")]
        public const int CSIDL_FLAG_MASK = 0xFF00;

        [NativeTypeName("#define SHGetSpecialFolderPath SHGetSpecialFolderPathW")]
        public static delegate*<HWND, ushort*, int, BOOL, BOOL> SHGetSpecialFolderPath => &SHGetSpecialFolderPathW;

        [NativeTypeName("#define SHGetFolderPath SHGetFolderPathW")]
        public static delegate*<HWND, int, HANDLE, uint, ushort*, HRESULT> SHGetFolderPath => &SHGetFolderPathW;

        [NativeTypeName("#define SHSetFolderPath SHSetFolderPathW")]
        public static delegate*<int, HANDLE, uint, ushort*, HRESULT> SHSetFolderPath => &SHSetFolderPathW;

        [NativeTypeName("#define SHGetFolderPathAndSubDir SHGetFolderPathAndSubDirW")]
        public static delegate*<HWND, int, HANDLE, uint, ushort*, ushort*, HRESULT> SHGetFolderPathAndSubDir => &SHGetFolderPathAndSubDirW;

        [NativeTypeName("#define FCS_READ 0x00000001")]
        public const int FCS_READ = 0x00000001;

        [NativeTypeName("#define FCS_FORCEWRITE 0x00000002")]
        public const int FCS_FORCEWRITE = 0x00000002;

        [NativeTypeName("#define FCS_WRITE (FCS_READ | FCS_FORCEWRITE)")]
        public const int FCS_WRITE = (0x00000001 | 0x00000002);

        [NativeTypeName("#define FCS_FLAG_DRAGDROP 2")]
        public const int FCS_FLAG_DRAGDROP = 2;

        [NativeTypeName("#define FCSM_VIEWID 0x00000001")]
        public const int FCSM_VIEWID = 0x00000001;

        [NativeTypeName("#define FCSM_WEBVIEWTEMPLATE 0x00000002")]
        public const int FCSM_WEBVIEWTEMPLATE = 0x00000002;

        [NativeTypeName("#define FCSM_INFOTIP 0x00000004")]
        public const int FCSM_INFOTIP = 0x00000004;

        [NativeTypeName("#define FCSM_CLSID 0x00000008")]
        public const int FCSM_CLSID = 0x00000008;

        [NativeTypeName("#define FCSM_ICONFILE 0x00000010")]
        public const int FCSM_ICONFILE = 0x00000010;

        [NativeTypeName("#define FCSM_LOGO 0x00000020")]
        public const int FCSM_LOGO = 0x00000020;

        [NativeTypeName("#define FCSM_FLAGS 0x00000040")]
        public const int FCSM_FLAGS = 0x00000040;

        [NativeTypeName("#define BIF_RETURNONLYFSDIRS 0x00000001")]
        public const int BIF_RETURNONLYFSDIRS = 0x00000001;

        [NativeTypeName("#define BIF_DONTGOBELOWDOMAIN 0x00000002")]
        public const int BIF_DONTGOBELOWDOMAIN = 0x00000002;

        [NativeTypeName("#define BIF_STATUSTEXT 0x00000004")]
        public const int BIF_STATUSTEXT = 0x00000004;

        [NativeTypeName("#define BIF_RETURNFSANCESTORS 0x00000008")]
        public const int BIF_RETURNFSANCESTORS = 0x00000008;

        [NativeTypeName("#define BIF_EDITBOX 0x00000010")]
        public const int BIF_EDITBOX = 0x00000010;

        [NativeTypeName("#define BIF_VALIDATE 0x00000020")]
        public const int BIF_VALIDATE = 0x00000020;

        [NativeTypeName("#define BIF_NEWDIALOGSTYLE 0x00000040")]
        public const int BIF_NEWDIALOGSTYLE = 0x00000040;

        [NativeTypeName("#define BIF_USENEWUI (BIF_NEWDIALOGSTYLE | BIF_EDITBOX)")]
        public const int BIF_USENEWUI = (0x00000040 | 0x00000010);

        [NativeTypeName("#define BIF_BROWSEINCLUDEURLS 0x00000080")]
        public const int BIF_BROWSEINCLUDEURLS = 0x00000080;

        [NativeTypeName("#define BIF_UAHINT 0x00000100")]
        public const int BIF_UAHINT = 0x00000100;

        [NativeTypeName("#define BIF_NONEWFOLDERBUTTON 0x00000200")]
        public const int BIF_NONEWFOLDERBUTTON = 0x00000200;

        [NativeTypeName("#define BIF_NOTRANSLATETARGETS 0x00000400")]
        public const int BIF_NOTRANSLATETARGETS = 0x00000400;

        [NativeTypeName("#define BIF_BROWSEFORCOMPUTER 0x00001000")]
        public const int BIF_BROWSEFORCOMPUTER = 0x00001000;

        [NativeTypeName("#define BIF_BROWSEFORPRINTER 0x00002000")]
        public const int BIF_BROWSEFORPRINTER = 0x00002000;

        [NativeTypeName("#define BIF_BROWSEINCLUDEFILES 0x00004000")]
        public const int BIF_BROWSEINCLUDEFILES = 0x00004000;

        [NativeTypeName("#define BIF_SHAREABLE 0x00008000")]
        public const int BIF_SHAREABLE = 0x00008000;

        [NativeTypeName("#define BIF_BROWSEFILEJUNCTIONS 0x00010000")]
        public const int BIF_BROWSEFILEJUNCTIONS = 0x00010000;

        [NativeTypeName("#define BFFM_INITIALIZED 1")]
        public const int BFFM_INITIALIZED = 1;

        [NativeTypeName("#define BFFM_SELCHANGED 2")]
        public const int BFFM_SELCHANGED = 2;

        [NativeTypeName("#define BFFM_VALIDATEFAILEDA 3")]
        public const int BFFM_VALIDATEFAILEDA = 3;

        [NativeTypeName("#define BFFM_VALIDATEFAILEDW 4")]
        public const int BFFM_VALIDATEFAILEDW = 4;

        [NativeTypeName("#define BFFM_IUNKNOWN 5")]
        public const int BFFM_IUNKNOWN = 5;

        [NativeTypeName("#define BFFM_SETSTATUSTEXTA (WM_USER + 100)")]
        public const int BFFM_SETSTATUSTEXTA = (0x0400 + 100);

        [NativeTypeName("#define BFFM_ENABLEOK (WM_USER + 101)")]
        public const int BFFM_ENABLEOK = (0x0400 + 101);

        [NativeTypeName("#define BFFM_SETSELECTIONA (WM_USER + 102)")]
        public const int BFFM_SETSELECTIONA = (0x0400 + 102);

        [NativeTypeName("#define BFFM_SETSELECTIONW (WM_USER + 103)")]
        public const int BFFM_SETSELECTIONW = (0x0400 + 103);

        [NativeTypeName("#define BFFM_SETSTATUSTEXTW (WM_USER + 104)")]
        public const int BFFM_SETSTATUSTEXTW = (0x0400 + 104);

        [NativeTypeName("#define BFFM_SETOKTEXT (WM_USER + 105)")]
        public const int BFFM_SETOKTEXT = (0x0400 + 105);

        [NativeTypeName("#define BFFM_SETEXPANDED (WM_USER + 106)")]
        public const int BFFM_SETEXPANDED = (0x0400 + 106);

        [NativeTypeName("#define SHBrowseForFolder SHBrowseForFolderW")]
        public static delegate*<BROWSEINFOW*, ITEMIDLIST*> SHBrowseForFolder => &SHBrowseForFolderW;

        [NativeTypeName("#define BFFM_SETSTATUSTEXT BFFM_SETSTATUSTEXTW")]
        public const int BFFM_SETSTATUSTEXT = (0x0400 + 104);

        [NativeTypeName("#define BFFM_SETSELECTION BFFM_SETSELECTIONW")]
        public const int BFFM_SETSELECTION = (0x0400 + 103);

        [NativeTypeName("#define BFFM_VALIDATEFAILED BFFM_VALIDATEFAILEDW")]
        public const int BFFM_VALIDATEFAILED = 4;

        [NativeTypeName("#define CMDID_INTSHORTCUTCREATE ISHCUTCMDID_INTSHORTCUTCREATE")]
        public const int CMDID_INTSHORTCUTCREATE = ISHCUTCMDID_INTSHORTCUTCREATE;

        [NativeTypeName("#define STR_PARSE_WITH_PROPERTIES L\"ParseWithProperties\"")]
        public const string STR_PARSE_WITH_PROPERTIES = "ParseWithProperties";

        [NativeTypeName("#define STR_PARSE_PARTIAL_IDLIST L\"ParseOriginalItem\"")]
        public const string STR_PARSE_PARTIAL_IDLIST = "ParseOriginalItem";

        [NativeTypeName("#define PROGDLG_NORMAL 0x00000000")]
        public const int PROGDLG_NORMAL = 0x00000000;

        [NativeTypeName("#define PROGDLG_MODAL 0x00000001")]
        public const int PROGDLG_MODAL = 0x00000001;

        [NativeTypeName("#define PROGDLG_AUTOTIME 0x00000002")]
        public const int PROGDLG_AUTOTIME = 0x00000002;

        [NativeTypeName("#define PROGDLG_NOTIME 0x00000004")]
        public const int PROGDLG_NOTIME = 0x00000004;

        [NativeTypeName("#define PROGDLG_NOMINIMIZE 0x00000008")]
        public const int PROGDLG_NOMINIMIZE = 0x00000008;

        [NativeTypeName("#define PROGDLG_NOPROGRESSBAR 0x00000010")]
        public const int PROGDLG_NOPROGRESSBAR = 0x00000010;

        [NativeTypeName("#define PROGDLG_MARQUEEPROGRESS 0x00000020")]
        public const int PROGDLG_MARQUEEPROGRESS = 0x00000020;

        [NativeTypeName("#define PROGDLG_NOCANCEL 0x00000040")]
        public const int PROGDLG_NOCANCEL = 0x00000040;

        [NativeTypeName("#define PDTIMER_RESET 0x00000001")]
        public const int PDTIMER_RESET = 0x00000001;

        [NativeTypeName("#define PDTIMER_PAUSE 0x00000002")]
        public const int PDTIMER_PAUSE = 0x00000002;

        [NativeTypeName("#define PDTIMER_RESUME 0x00000003")]
        public const int PDTIMER_RESUME = 0x00000003;

        [NativeTypeName("#define MAX_COLUMN_NAME_LEN 80")]
        public const int MAX_COLUMN_NAME_LEN = 80;

        [NativeTypeName("#define MAX_COLUMN_DESC_LEN 128")]
        public const int MAX_COLUMN_DESC_LEN = 128;

        [NativeTypeName("#define CFSTR_SHELLIDLIST TEXT(\"Shell IDList Array\")")]
        public const string CFSTR_SHELLIDLIST = "Shell IDList Array";

        [NativeTypeName("#define CFSTR_SHELLIDLISTOFFSET TEXT(\"Shell Object Offsets\")")]
        public const string CFSTR_SHELLIDLISTOFFSET = "Shell Object Offsets";

        [NativeTypeName("#define CFSTR_NETRESOURCES TEXT(\"Net Resource\")")]
        public const string CFSTR_NETRESOURCES = "Net Resource";

        [NativeTypeName("#define CFSTR_FILEDESCRIPTORA TEXT(\"FileGroupDescriptor\")")]
        public const string CFSTR_FILEDESCRIPTORA = "FileGroupDescriptor";

        [NativeTypeName("#define CFSTR_FILEDESCRIPTORW TEXT(\"FileGroupDescriptorW\")")]
        public const string CFSTR_FILEDESCRIPTORW = "FileGroupDescriptorW";

        [NativeTypeName("#define CFSTR_FILECONTENTS TEXT(\"FileContents\")")]
        public const string CFSTR_FILECONTENTS = "FileContents";

        [NativeTypeName("#define CFSTR_FILENAMEA TEXT(\"FileName\")")]
        public const string CFSTR_FILENAMEA = "FileName";

        [NativeTypeName("#define CFSTR_FILENAMEW TEXT(\"FileNameW\")")]
        public const string CFSTR_FILENAMEW = "FileNameW";

        [NativeTypeName("#define CFSTR_PRINTERGROUP TEXT(\"PrinterFriendlyName\")")]
        public const string CFSTR_PRINTERGROUP = "PrinterFriendlyName";

        [NativeTypeName("#define CFSTR_FILENAMEMAPA TEXT(\"FileNameMap\")")]
        public const string CFSTR_FILENAMEMAPA = "FileNameMap";

        [NativeTypeName("#define CFSTR_FILENAMEMAPW TEXT(\"FileNameMapW\")")]
        public const string CFSTR_FILENAMEMAPW = "FileNameMapW";

        [NativeTypeName("#define CFSTR_SHELLURL TEXT(\"UniformResourceLocator\")")]
        public const string CFSTR_SHELLURL = "UniformResourceLocator";

        [NativeTypeName("#define CFSTR_INETURLA CFSTR_SHELLURL")]
        public const string CFSTR_INETURLA = "UniformResourceLocator";

        [NativeTypeName("#define CFSTR_INETURLW TEXT(\"UniformResourceLocatorW\")")]
        public const string CFSTR_INETURLW = "UniformResourceLocatorW";

        [NativeTypeName("#define CFSTR_PREFERREDDROPEFFECT TEXT(\"Preferred DropEffect\")")]
        public const string CFSTR_PREFERREDDROPEFFECT = "Preferred DropEffect";

        [NativeTypeName("#define CFSTR_PERFORMEDDROPEFFECT TEXT(\"Performed DropEffect\")")]
        public const string CFSTR_PERFORMEDDROPEFFECT = "Performed DropEffect";

        [NativeTypeName("#define CFSTR_PASTESUCCEEDED TEXT(\"Paste Succeeded\")")]
        public const string CFSTR_PASTESUCCEEDED = "Paste Succeeded";

        [NativeTypeName("#define CFSTR_INDRAGLOOP TEXT(\"InShellDragLoop\")")]
        public const string CFSTR_INDRAGLOOP = "InShellDragLoop";

        [NativeTypeName("#define CFSTR_MOUNTEDVOLUME TEXT(\"MountedVolume\")")]
        public const string CFSTR_MOUNTEDVOLUME = "MountedVolume";

        [NativeTypeName("#define CFSTR_PERSISTEDDATAOBJECT TEXT(\"PersistedDataObject\")")]
        public const string CFSTR_PERSISTEDDATAOBJECT = "PersistedDataObject";

        [NativeTypeName("#define CFSTR_TARGETCLSID TEXT(\"TargetCLSID\")")]
        public const string CFSTR_TARGETCLSID = "TargetCLSID";

        [NativeTypeName("#define CFSTR_LOGICALPERFORMEDDROPEFFECT TEXT(\"Logical Performed DropEffect\")")]
        public const string CFSTR_LOGICALPERFORMEDDROPEFFECT = "Logical Performed DropEffect";

        [NativeTypeName("#define CFSTR_AUTOPLAY_SHELLIDLISTS TEXT(\"Autoplay Enumerated IDList Array\")")]
        public const string CFSTR_AUTOPLAY_SHELLIDLISTS = "Autoplay Enumerated IDList Array";

        [NativeTypeName("#define CFSTR_UNTRUSTEDDRAGDROP TEXT(\"UntrustedDragDrop\")")]
        public const string CFSTR_UNTRUSTEDDRAGDROP = "UntrustedDragDrop";

        [NativeTypeName("#define CFSTR_FILE_ATTRIBUTES_ARRAY TEXT(\"File Attributes Array\")")]
        public const string CFSTR_FILE_ATTRIBUTES_ARRAY = "File Attributes Array";

        [NativeTypeName("#define CFSTR_INVOKECOMMAND_DROPPARAM TEXT(\"InvokeCommand DropParam\")")]
        public const string CFSTR_INVOKECOMMAND_DROPPARAM = "InvokeCommand DropParam";

        [NativeTypeName("#define CFSTR_SHELLDROPHANDLER TEXT(\"DropHandlerCLSID\")")]
        public const string CFSTR_SHELLDROPHANDLER = "DropHandlerCLSID";

        [NativeTypeName("#define CFSTR_DROPDESCRIPTION TEXT(\"DropDescription\")")]
        public const string CFSTR_DROPDESCRIPTION = "DropDescription";

        [NativeTypeName("#define CFSTR_ZONEIDENTIFIER TEXT(\"ZoneIdentifier\")")]
        public const string CFSTR_ZONEIDENTIFIER = "ZoneIdentifier";

        [NativeTypeName("#define CFSTR_FILEDESCRIPTOR CFSTR_FILEDESCRIPTORW")]
        public const string CFSTR_FILEDESCRIPTOR = "FileGroupDescriptorW";

        [NativeTypeName("#define CFSTR_FILENAME CFSTR_FILENAMEW")]
        public const string CFSTR_FILENAME = "FileNameW";

        [NativeTypeName("#define CFSTR_FILENAMEMAP CFSTR_FILENAMEMAPW")]
        public const string CFSTR_FILENAMEMAP = "FileNameMapW";

        [NativeTypeName("#define CFSTR_INETURL CFSTR_INETURLW")]
        public const string CFSTR_INETURL = "UniformResourceLocatorW";

        [NativeTypeName("#define DVASPECT_SHORTNAME 2")]
        public const int DVASPECT_SHORTNAME = 2;

        [NativeTypeName("#define DVASPECT_COPY 3")]
        public const int DVASPECT_COPY = 3;

        [NativeTypeName("#define DVASPECT_LINK 4")]
        public const int DVASPECT_LINK = 4;

        [NativeTypeName("#define SHCNRF_InterruptLevel 0x0001")]
        public const int SHCNRF_InterruptLevel = 0x0001;

        [NativeTypeName("#define SHCNRF_ShellLevel 0x0002")]
        public const int SHCNRF_ShellLevel = 0x0002;

        [NativeTypeName("#define SHCNRF_RecursiveInterrupt 0x1000")]
        public const int SHCNRF_RecursiveInterrupt = 0x1000;

        [NativeTypeName("#define SHCNRF_NewDelivery 0x8000")]
        public const int SHCNRF_NewDelivery = 0x8000;

        [NativeTypeName("#define SHCNE_RENAMEITEM 0x00000001L")]
        public const int SHCNE_RENAMEITEM = 0x00000001;

        [NativeTypeName("#define SHCNE_CREATE 0x00000002L")]
        public const int SHCNE_CREATE = 0x00000002;

        [NativeTypeName("#define SHCNE_DELETE 0x00000004L")]
        public const int SHCNE_DELETE = 0x00000004;

        [NativeTypeName("#define SHCNE_MKDIR 0x00000008L")]
        public const int SHCNE_MKDIR = 0x00000008;

        [NativeTypeName("#define SHCNE_RMDIR 0x00000010L")]
        public const int SHCNE_RMDIR = 0x00000010;

        [NativeTypeName("#define SHCNE_MEDIAINSERTED 0x00000020L")]
        public const int SHCNE_MEDIAINSERTED = 0x00000020;

        [NativeTypeName("#define SHCNE_MEDIAREMOVED 0x00000040L")]
        public const int SHCNE_MEDIAREMOVED = 0x00000040;

        [NativeTypeName("#define SHCNE_DRIVEREMOVED 0x00000080L")]
        public const int SHCNE_DRIVEREMOVED = 0x00000080;

        [NativeTypeName("#define SHCNE_DRIVEADD 0x00000100L")]
        public const int SHCNE_DRIVEADD = 0x00000100;

        [NativeTypeName("#define SHCNE_NETSHARE 0x00000200L")]
        public const int SHCNE_NETSHARE = 0x00000200;

        [NativeTypeName("#define SHCNE_NETUNSHARE 0x00000400L")]
        public const int SHCNE_NETUNSHARE = 0x00000400;

        [NativeTypeName("#define SHCNE_ATTRIBUTES 0x00000800L")]
        public const int SHCNE_ATTRIBUTES = 0x00000800;

        [NativeTypeName("#define SHCNE_UPDATEDIR 0x00001000L")]
        public const int SHCNE_UPDATEDIR = 0x00001000;

        [NativeTypeName("#define SHCNE_UPDATEITEM 0x00002000L")]
        public const int SHCNE_UPDATEITEM = 0x00002000;

        [NativeTypeName("#define SHCNE_SERVERDISCONNECT 0x00004000L")]
        public const int SHCNE_SERVERDISCONNECT = 0x00004000;

        [NativeTypeName("#define SHCNE_UPDATEIMAGE 0x00008000L")]
        public const int SHCNE_UPDATEIMAGE = 0x00008000;

        [NativeTypeName("#define SHCNE_DRIVEADDGUI 0x00010000L")]
        public const int SHCNE_DRIVEADDGUI = 0x00010000;

        [NativeTypeName("#define SHCNE_RENAMEFOLDER 0x00020000L")]
        public const int SHCNE_RENAMEFOLDER = 0x00020000;

        [NativeTypeName("#define SHCNE_FREESPACE 0x00040000L")]
        public const int SHCNE_FREESPACE = 0x00040000;

        [NativeTypeName("#define SHCNE_EXTENDED_EVENT 0x04000000L")]
        public const int SHCNE_EXTENDED_EVENT = 0x04000000;

        [NativeTypeName("#define SHCNE_ASSOCCHANGED 0x08000000L")]
        public const int SHCNE_ASSOCCHANGED = 0x08000000;

        [NativeTypeName("#define SHCNE_DISKEVENTS 0x0002381FL")]
        public const int SHCNE_DISKEVENTS = 0x0002381F;

        [NativeTypeName("#define SHCNE_GLOBALEVENTS 0x0C0581E0L")]
        public const int SHCNE_GLOBALEVENTS = 0x0C0581E0;

        [NativeTypeName("#define SHCNE_ALLEVENTS 0x7FFFFFFFL")]
        public const int SHCNE_ALLEVENTS = 0x7FFFFFFF;

        [NativeTypeName("#define SHCNE_INTERRUPT 0x80000000L")]
        public const uint SHCNE_INTERRUPT = 0x80000000;

        [NativeTypeName("#define SHCNEE_ORDERCHANGED 2L")]
        public const int SHCNEE_ORDERCHANGED = 2;

        [NativeTypeName("#define SHCNEE_MSI_CHANGE 4L")]
        public const int SHCNEE_MSI_CHANGE = 4;

        [NativeTypeName("#define SHCNEE_MSI_UNINSTALL 5L")]
        public const int SHCNEE_MSI_UNINSTALL = 5;

        [NativeTypeName("#define SHCNF_IDLIST 0x0000")]
        public const int SHCNF_IDLIST = 0x0000;

        [NativeTypeName("#define SHCNF_PATHA 0x0001")]
        public const int SHCNF_PATHA = 0x0001;

        [NativeTypeName("#define SHCNF_PRINTERA 0x0002")]
        public const int SHCNF_PRINTERA = 0x0002;

        [NativeTypeName("#define SHCNF_DWORD 0x0003")]
        public const int SHCNF_DWORD = 0x0003;

        [NativeTypeName("#define SHCNF_PATHW 0x0005")]
        public const int SHCNF_PATHW = 0x0005;

        [NativeTypeName("#define SHCNF_PRINTERW 0x0006")]
        public const int SHCNF_PRINTERW = 0x0006;

        [NativeTypeName("#define SHCNF_TYPE 0x00FF")]
        public const int SHCNF_TYPE = 0x00FF;

        [NativeTypeName("#define SHCNF_FLUSH 0x1000")]
        public const int SHCNF_FLUSH = 0x1000;

        [NativeTypeName("#define SHCNF_FLUSHNOWAIT 0x3000")]
        public const int SHCNF_FLUSHNOWAIT = 0x3000;

        [NativeTypeName("#define SHCNF_NOTIFYRECURSIVE 0x10000")]
        public const int SHCNF_NOTIFYRECURSIVE = 0x10000;

        [NativeTypeName("#define SHCNF_PATH SHCNF_PATHW")]
        public const int SHCNF_PATH = 0x0005;

        [NativeTypeName("#define SHCNF_PRINTER SHCNF_PRINTERW")]
        public const int SHCNF_PRINTER = 0x0006;

        [NativeTypeName("#define QITIPF_DEFAULT 0x00000000")]
        public const int QITIPF_DEFAULT = 0x00000000;

        [NativeTypeName("#define QITIPF_USENAME 0x00000001")]
        public const int QITIPF_USENAME = 0x00000001;

        [NativeTypeName("#define QITIPF_LINKNOTARGET 0x00000002")]
        public const int QITIPF_LINKNOTARGET = 0x00000002;

        [NativeTypeName("#define QITIPF_LINKUSETARGET 0x00000004")]
        public const int QITIPF_LINKUSETARGET = 0x00000004;

        [NativeTypeName("#define QITIPF_USESLOWTIP 0x00000008")]
        public const int QITIPF_USESLOWTIP = 0x00000008;

        [NativeTypeName("#define QITIPF_SINGLELINE 0x00000010")]
        public const int QITIPF_SINGLELINE = 0x00000010;

        [NativeTypeName("#define QIF_CACHED 0x00000001")]
        public const int QIF_CACHED = 0x00000001;

        [NativeTypeName("#define QIF_DONTEXPANDFOLDER 0x00000002")]
        public const int QIF_DONTEXPANDFOLDER = 0x00000002;

        [NativeTypeName("#define SHARD_PATH SHARD_PATHW")]
        public const SHARD SHARD_PATH = SHARD_PATHW;

        [NativeTypeName("#define SHUpdateImage SHUpdateImageW")]
        public static delegate*<ushort*, int, uint, int, void> SHUpdateImage => &SHUpdateImageW;

        [NativeTypeName("#define SHGDFIL_FINDDATA 1")]
        public const int SHGDFIL_FINDDATA = 1;

        [NativeTypeName("#define SHGDFIL_NETRESOURCE 2")]
        public const int SHGDFIL_NETRESOURCE = 2;

        [NativeTypeName("#define SHGDFIL_DESCRIPTIONID 3")]
        public const int SHGDFIL_DESCRIPTIONID = 3;

        [NativeTypeName("#define SHDID_ROOT_REGITEM 1")]
        public const int SHDID_ROOT_REGITEM = 1;

        [NativeTypeName("#define SHDID_FS_FILE 2")]
        public const int SHDID_FS_FILE = 2;

        [NativeTypeName("#define SHDID_FS_DIRECTORY 3")]
        public const int SHDID_FS_DIRECTORY = 3;

        [NativeTypeName("#define SHDID_FS_OTHER 4")]
        public const int SHDID_FS_OTHER = 4;

        [NativeTypeName("#define SHDID_COMPUTER_DRIVE35 5")]
        public const int SHDID_COMPUTER_DRIVE35 = 5;

        [NativeTypeName("#define SHDID_COMPUTER_DRIVE525 6")]
        public const int SHDID_COMPUTER_DRIVE525 = 6;

        [NativeTypeName("#define SHDID_COMPUTER_REMOVABLE 7")]
        public const int SHDID_COMPUTER_REMOVABLE = 7;

        [NativeTypeName("#define SHDID_COMPUTER_FIXED 8")]
        public const int SHDID_COMPUTER_FIXED = 8;

        [NativeTypeName("#define SHDID_COMPUTER_NETDRIVE 9")]
        public const int SHDID_COMPUTER_NETDRIVE = 9;

        [NativeTypeName("#define SHDID_COMPUTER_CDROM 10")]
        public const int SHDID_COMPUTER_CDROM = 10;

        [NativeTypeName("#define SHDID_COMPUTER_RAMDISK 11")]
        public const int SHDID_COMPUTER_RAMDISK = 11;

        [NativeTypeName("#define SHDID_COMPUTER_OTHER 12")]
        public const int SHDID_COMPUTER_OTHER = 12;

        [NativeTypeName("#define SHDID_NET_DOMAIN 13")]
        public const int SHDID_NET_DOMAIN = 13;

        [NativeTypeName("#define SHDID_NET_SERVER 14")]
        public const int SHDID_NET_SERVER = 14;

        [NativeTypeName("#define SHDID_NET_SHARE 15")]
        public const int SHDID_NET_SHARE = 15;

        [NativeTypeName("#define SHDID_NET_RESTOFNET 16")]
        public const int SHDID_NET_RESTOFNET = 16;

        [NativeTypeName("#define SHDID_NET_OTHER 17")]
        public const int SHDID_NET_OTHER = 17;

        [NativeTypeName("#define SHDID_COMPUTER_IMAGING 18")]
        public const int SHDID_COMPUTER_IMAGING = 18;

        [NativeTypeName("#define SHDID_COMPUTER_AUDIO 19")]
        public const int SHDID_COMPUTER_AUDIO = 19;

        [NativeTypeName("#define SHDID_COMPUTER_SHAREDDOCS 20")]
        public const int SHDID_COMPUTER_SHAREDDOCS = 20;

        [NativeTypeName("#define SHDID_MOBILE_DEVICE 21")]
        public const int SHDID_MOBILE_DEVICE = 21;

        [NativeTypeName("#define SHDID_REMOTE_DESKTOP_DRIVE 22")]
        public const int SHDID_REMOTE_DESKTOP_DRIVE = 22;

        [NativeTypeName("#define SHGetDataFromIDList SHGetDataFromIDListW")]
        public static delegate*<IShellFolder*, ITEMIDLIST*, int, void*, int, HRESULT> SHGetDataFromIDList => &SHGetDataFromIDListW;

        [NativeTypeName("#define PRF_VERIFYEXISTS 0x0001")]
        public const int PRF_VERIFYEXISTS = 0x0001;

        [NativeTypeName("#define PRF_TRYPROGRAMEXTENSIONS (0x0002 | PRF_VERIFYEXISTS)")]
        public const int PRF_TRYPROGRAMEXTENSIONS = (0x0002 | 0x0001);

        [NativeTypeName("#define PRF_FIRSTDIRDEF 0x0004")]
        public const int PRF_FIRSTDIRDEF = 0x0004;

        [NativeTypeName("#define PRF_DONTFINDLNK 0x0008")]
        public const int PRF_DONTFINDLNK = 0x0008;

        [NativeTypeName("#define PRF_REQUIREABSOLUTE 0x0010")]
        public const int PRF_REQUIREABSOLUTE = 0x0010;

        [NativeTypeName("#define NUM_POINTS 3")]
        public const int NUM_POINTS = 3;

        [NativeTypeName("#define CABINETSTATE_VERSION 2")]
        public const int CABINETSTATE_VERSION = 2;

        [NativeTypeName("#define PCS_FATAL 0x80000000")]
        public const uint PCS_FATAL = 0x80000000;

        [NativeTypeName("#define PCS_REPLACEDCHAR 0x00000001")]
        public const int PCS_REPLACEDCHAR = 0x00000001;

        [NativeTypeName("#define PCS_REMOVEDCHAR 0x00000002")]
        public const int PCS_REMOVEDCHAR = 0x00000002;

        [NativeTypeName("#define PCS_TRUNCATED 0x00000004")]
        public const int PCS_TRUNCATED = 0x00000004;

        [NativeTypeName("#define PCS_PATHTOOLONG 0x00000008")]
        public const int PCS_PATHTOOLONG = 0x00000008;

        [NativeTypeName("#define MM_ADDSEPARATOR 0x00000001L")]
        public const int MM_ADDSEPARATOR = 0x00000001;

        [NativeTypeName("#define MM_SUBMENUSHAVEIDS 0x00000002L")]
        public const int MM_SUBMENUSHAVEIDS = 0x00000002;

        [NativeTypeName("#define MM_DONTREMOVESEPS 0x00000004L")]
        public const int MM_DONTREMOVESEPS = 0x00000004;

        [NativeTypeName("#define SHOP_PRINTERNAME 0x00000001")]
        public const int SHOP_PRINTERNAME = 0x00000001;

        [NativeTypeName("#define SHOP_FILEPATH 0x00000002")]
        public const int SHOP_FILEPATH = 0x00000002;

        [NativeTypeName("#define SHOP_VOLUMEGUID 0x00000004")]
        public const int SHOP_VOLUMEGUID = 0x00000004;

        [NativeTypeName("#define SHFMT_ID_DEFAULT 0xFFFF")]
        public const int SHFMT_ID_DEFAULT = 0xFFFF;

        [NativeTypeName("#define SHFMT_OPT_FULL 0x0001")]
        public const int SHFMT_OPT_FULL = 0x0001;

        [NativeTypeName("#define SHFMT_OPT_SYSONLY 0x0002")]
        public const int SHFMT_OPT_SYSONLY = 0x0002;

        [NativeTypeName("#define SHFMT_ERROR 0xFFFFFFFFL")]
        public const uint SHFMT_ERROR = 0xFFFFFFFF;

        [NativeTypeName("#define SHFMT_CANCEL 0xFFFFFFFEL")]
        public const uint SHFMT_CANCEL = 0xFFFFFFFE;

        [NativeTypeName("#define SHFMT_NOFORMAT 0xFFFFFFFDL")]
        public const uint SHFMT_NOFORMAT = 0xFFFFFFFD;

        [NativeTypeName("#define SHStartNetConnectionDialog SHStartNetConnectionDialogW")]
        public static delegate*<HWND, ushort*, uint, HRESULT> SHStartNetConnectionDialog => &SHStartNetConnectionDialogW;

        [NativeTypeName("#define SHDefExtractIcon SHDefExtractIconW")]
        public static delegate*<ushort*, int, uint, HICON*, HICON*, uint, HRESULT> SHDefExtractIcon => &SHDefExtractIconW;

        [NativeTypeName("#define Shell_GetCachedImageIndex Shell_GetCachedImageIndexW")]
        public static delegate*<ushort*, int, uint, int> Shell_GetCachedImageIndex => &Shell_GetCachedImageIndexW;

        [NativeTypeName("#define VALIDATEUNC_CONNECT 0x0001")]
        public const int VALIDATEUNC_CONNECT = 0x0001;

        [NativeTypeName("#define VALIDATEUNC_NOUI 0x0002")]
        public const int VALIDATEUNC_NOUI = 0x0002;

        [NativeTypeName("#define VALIDATEUNC_PRINT 0x0004")]
        public const int VALIDATEUNC_PRINT = 0x0004;

        [NativeTypeName("#define VALIDATEUNC_PERSIST 0x0008")]
        public const int VALIDATEUNC_PERSIST = 0x0008;

        [NativeTypeName("#define VALIDATEUNC_VALID 0x000F")]
        public const int VALIDATEUNC_VALID = 0x000F;

        [NativeTypeName("#define PIFNAMESIZE 30")]
        public const int PIFNAMESIZE = 30;

        [NativeTypeName("#define PIFSTARTLOCSIZE 63")]
        public const int PIFSTARTLOCSIZE = 63;

        [NativeTypeName("#define PIFDEFPATHSIZE 64")]
        public const int PIFDEFPATHSIZE = 64;

        [NativeTypeName("#define PIFPARAMSSIZE 64")]
        public const int PIFPARAMSSIZE = 64;

        [NativeTypeName("#define PIFSHPROGSIZE 64")]
        public const int PIFSHPROGSIZE = 64;

        [NativeTypeName("#define PIFSHDATASIZE 64")]
        public const int PIFSHDATASIZE = 64;

        [NativeTypeName("#define PIFDEFFILESIZE 80")]
        public const int PIFDEFFILESIZE = 80;

        [NativeTypeName("#define PIFMAXFILEPATH 260")]
        public const int PIFMAXFILEPATH = 260;

        [NativeTypeName("#define QCMINFO_PLACE_BEFORE 0")]
        public const int QCMINFO_PLACE_BEFORE = 0;

        [NativeTypeName("#define QCMINFO_PLACE_AFTER 1")]
        public const int QCMINFO_PLACE_AFTER = 1;

        [NativeTypeName("#define SFVM_MERGEMENU 1")]
        public const int SFVM_MERGEMENU = 1;

        [NativeTypeName("#define SFVM_INVOKECOMMAND 2")]
        public const int SFVM_INVOKECOMMAND = 2;

        [NativeTypeName("#define SFVM_GETHELPTEXT 3")]
        public const int SFVM_GETHELPTEXT = 3;

        [NativeTypeName("#define SFVM_GETTOOLTIPTEXT 4")]
        public const int SFVM_GETTOOLTIPTEXT = 4;

        [NativeTypeName("#define SFVM_GETBUTTONINFO 5")]
        public const int SFVM_GETBUTTONINFO = 5;

        [NativeTypeName("#define SFVM_GETBUTTONS 6")]
        public const int SFVM_GETBUTTONS = 6;

        [NativeTypeName("#define SFVM_INITMENUPOPUP 7")]
        public const int SFVM_INITMENUPOPUP = 7;

        [NativeTypeName("#define SFVM_FSNOTIFY 14")]
        public const int SFVM_FSNOTIFY = 14;

        [NativeTypeName("#define SFVM_WINDOWCREATED 15")]
        public const int SFVM_WINDOWCREATED = 15;

        [NativeTypeName("#define SFVM_GETDETAILSOF 23")]
        public const int SFVM_GETDETAILSOF = 23;

        [NativeTypeName("#define SFVM_COLUMNCLICK 24")]
        public const int SFVM_COLUMNCLICK = 24;

        [NativeTypeName("#define SFVM_QUERYFSNOTIFY 25")]
        public const int SFVM_QUERYFSNOTIFY = 25;

        [NativeTypeName("#define SFVM_DEFITEMCOUNT 26")]
        public const int SFVM_DEFITEMCOUNT = 26;

        [NativeTypeName("#define SFVM_DEFVIEWMODE 27")]
        public const int SFVM_DEFVIEWMODE = 27;

        [NativeTypeName("#define SFVM_UNMERGEMENU 28")]
        public const int SFVM_UNMERGEMENU = 28;

        [NativeTypeName("#define SFVM_UPDATESTATUSBAR 31")]
        public const int SFVM_UPDATESTATUSBAR = 31;

        [NativeTypeName("#define SFVM_BACKGROUNDENUM 32")]
        public const int SFVM_BACKGROUNDENUM = 32;

        [NativeTypeName("#define SFVM_DIDDRAGDROP 36")]
        public const int SFVM_DIDDRAGDROP = 36;

        [NativeTypeName("#define SFVM_SETISFV 39")]
        public const int SFVM_SETISFV = 39;

        [NativeTypeName("#define SFVM_THISIDLIST 41")]
        public const int SFVM_THISIDLIST = 41;

        [NativeTypeName("#define SFVM_ADDPROPERTYPAGES 47")]
        public const int SFVM_ADDPROPERTYPAGES = 47;

        [NativeTypeName("#define SFVM_BACKGROUNDENUMDONE 48")]
        public const int SFVM_BACKGROUNDENUMDONE = 48;

        [NativeTypeName("#define SFVM_GETNOTIFY 49")]
        public const int SFVM_GETNOTIFY = 49;

        [NativeTypeName("#define SFVM_GETSORTDEFAULTS 53")]
        public const int SFVM_GETSORTDEFAULTS = 53;

        [NativeTypeName("#define SFVM_SIZE 57")]
        public const int SFVM_SIZE = 57;

        [NativeTypeName("#define SFVM_GETZONE 58")]
        public const int SFVM_GETZONE = 58;

        [NativeTypeName("#define SFVM_GETPANE 59")]
        public const int SFVM_GETPANE = 59;

        [NativeTypeName("#define SFVM_GETHELPTOPIC 63")]
        public const int SFVM_GETHELPTOPIC = 63;

        [NativeTypeName("#define SFVM_GETANIMATION 68")]
        public const int SFVM_GETANIMATION = 68;

        [NativeTypeName("#define SFVSOC_INVALIDATE_ALL 0x00000001")]
        public const int SFVSOC_INVALIDATE_ALL = 0x00000001;

        [NativeTypeName("#define SFVSOC_NOSCROLL LVSICF_NOSCROLL")]
        public const int SFVSOC_NOSCROLL = 0x00000002;

        [NativeTypeName("#define SFVS_SELECT_NONE 0x0")]
        public const int SFVS_SELECT_NONE = 0x0;

        [NativeTypeName("#define SFVS_SELECT_ALLITEMS 0x1")]
        public const int SFVS_SELECT_ALLITEMS = 0x1;

        [NativeTypeName("#define SFVS_SELECT_INVERT 0x2")]
        public const int SFVS_SELECT_INVERT = 0x2;

        [NativeTypeName("#define DFM_MERGECONTEXTMENU 1")]
        public const int DFM_MERGECONTEXTMENU = 1;

        [NativeTypeName("#define DFM_INVOKECOMMAND 2")]
        public const int DFM_INVOKECOMMAND = 2;

        [NativeTypeName("#define DFM_GETHELPTEXT 5")]
        public const int DFM_GETHELPTEXT = 5;

        [NativeTypeName("#define DFM_WM_MEASUREITEM 6")]
        public const int DFM_WM_MEASUREITEM = 6;

        [NativeTypeName("#define DFM_WM_DRAWITEM 7")]
        public const int DFM_WM_DRAWITEM = 7;

        [NativeTypeName("#define DFM_WM_INITMENUPOPUP 8")]
        public const int DFM_WM_INITMENUPOPUP = 8;

        [NativeTypeName("#define DFM_VALIDATECMD 9")]
        public const int DFM_VALIDATECMD = 9;

        [NativeTypeName("#define DFM_MERGECONTEXTMENU_TOP 10")]
        public const int DFM_MERGECONTEXTMENU_TOP = 10;

        [NativeTypeName("#define DFM_GETHELPTEXTW 11")]
        public const int DFM_GETHELPTEXTW = 11;

        [NativeTypeName("#define DFM_INVOKECOMMANDEX 12")]
        public const int DFM_INVOKECOMMANDEX = 12;

        [NativeTypeName("#define DFM_MAPCOMMANDNAME 13")]
        public const int DFM_MAPCOMMANDNAME = 13;

        [NativeTypeName("#define DFM_GETDEFSTATICID 14")]
        public const int DFM_GETDEFSTATICID = 14;

        [NativeTypeName("#define DFM_GETVERBW 15")]
        public const int DFM_GETVERBW = 15;

        [NativeTypeName("#define DFM_GETVERBA 16")]
        public const int DFM_GETVERBA = 16;

        [NativeTypeName("#define DFM_MERGECONTEXTMENU_BOTTOM 17")]
        public const int DFM_MERGECONTEXTMENU_BOTTOM = 17;

        [NativeTypeName("#define DFM_MODIFYQCMFLAGS 18")]
        public const int DFM_MODIFYQCMFLAGS = 18;

        [NativeTypeName("#define DFM_CMD_DELETE ((UINT)-1)")]
        public const uint DFM_CMD_DELETE = unchecked((uint)(-1));

        [NativeTypeName("#define DFM_CMD_MOVE ((UINT)-2)")]
        public const uint DFM_CMD_MOVE = unchecked((uint)(-2));

        [NativeTypeName("#define DFM_CMD_COPY ((UINT)-3)")]
        public const uint DFM_CMD_COPY = unchecked((uint)(-3));

        [NativeTypeName("#define DFM_CMD_LINK ((UINT)-4)")]
        public const uint DFM_CMD_LINK = unchecked((uint)(-4));

        [NativeTypeName("#define DFM_CMD_PROPERTIES ((UINT)-5)")]
        public const uint DFM_CMD_PROPERTIES = unchecked((uint)(-5));

        [NativeTypeName("#define DFM_CMD_NEWFOLDER ((UINT)-6)")]
        public const uint DFM_CMD_NEWFOLDER = unchecked((uint)(-6));

        [NativeTypeName("#define DFM_CMD_PASTE ((UINT)-7)")]
        public const uint DFM_CMD_PASTE = unchecked((uint)(-7));

        [NativeTypeName("#define DFM_CMD_VIEWLIST ((UINT)-8)")]
        public const uint DFM_CMD_VIEWLIST = unchecked((uint)(-8));

        [NativeTypeName("#define DFM_CMD_VIEWDETAILS ((UINT)-9)")]
        public const uint DFM_CMD_VIEWDETAILS = unchecked((uint)(-9));

        [NativeTypeName("#define DFM_CMD_PASTELINK ((UINT)-10)")]
        public const uint DFM_CMD_PASTELINK = unchecked((uint)(-10));

        [NativeTypeName("#define DFM_CMD_PASTESPECIAL ((UINT)-11)")]
        public const uint DFM_CMD_PASTESPECIAL = unchecked((uint)(-11));

        [NativeTypeName("#define DFM_CMD_MODALPROP ((UINT)-12)")]
        public const uint DFM_CMD_MODALPROP = unchecked((uint)(-12));

        [NativeTypeName("#define DFM_CMD_RENAME ((UINT)-13)")]
        public const uint DFM_CMD_RENAME = unchecked((uint)(-13));

        [NativeTypeName("#define PID_IS_URL 2")]
        public const int PID_IS_URL = 2;

        [NativeTypeName("#define PID_IS_NAME 4")]
        public const int PID_IS_NAME = 4;

        [NativeTypeName("#define PID_IS_WORKINGDIR 5")]
        public const int PID_IS_WORKINGDIR = 5;

        [NativeTypeName("#define PID_IS_HOTKEY 6")]
        public const int PID_IS_HOTKEY = 6;

        [NativeTypeName("#define PID_IS_SHOWCMD 7")]
        public const int PID_IS_SHOWCMD = 7;

        [NativeTypeName("#define PID_IS_ICONINDEX 8")]
        public const int PID_IS_ICONINDEX = 8;

        [NativeTypeName("#define PID_IS_ICONFILE 9")]
        public const int PID_IS_ICONFILE = 9;

        [NativeTypeName("#define PID_IS_WHATSNEW 10")]
        public const int PID_IS_WHATSNEW = 10;

        [NativeTypeName("#define PID_IS_AUTHOR 11")]
        public const int PID_IS_AUTHOR = 11;

        [NativeTypeName("#define PID_IS_DESCRIPTION 12")]
        public const int PID_IS_DESCRIPTION = 12;

        [NativeTypeName("#define PID_IS_COMMENT 13")]
        public const int PID_IS_COMMENT = 13;

        [NativeTypeName("#define PID_IS_ROAMED 15")]
        public const int PID_IS_ROAMED = 15;

        [NativeTypeName("#define PID_INTSITE_WHATSNEW 2")]
        public const int PID_INTSITE_WHATSNEW = 2;

        [NativeTypeName("#define PID_INTSITE_AUTHOR 3")]
        public const int PID_INTSITE_AUTHOR = 3;

        [NativeTypeName("#define PID_INTSITE_LASTVISIT 4")]
        public const int PID_INTSITE_LASTVISIT = 4;

        [NativeTypeName("#define PID_INTSITE_LASTMOD 5")]
        public const int PID_INTSITE_LASTMOD = 5;

        [NativeTypeName("#define PID_INTSITE_VISITCOUNT 6")]
        public const int PID_INTSITE_VISITCOUNT = 6;

        [NativeTypeName("#define PID_INTSITE_DESCRIPTION 7")]
        public const int PID_INTSITE_DESCRIPTION = 7;

        [NativeTypeName("#define PID_INTSITE_COMMENT 8")]
        public const int PID_INTSITE_COMMENT = 8;

        [NativeTypeName("#define PID_INTSITE_FLAGS 9")]
        public const int PID_INTSITE_FLAGS = 9;

        [NativeTypeName("#define PID_INTSITE_CONTENTLEN 10")]
        public const int PID_INTSITE_CONTENTLEN = 10;

        [NativeTypeName("#define PID_INTSITE_CONTENTCODE 11")]
        public const int PID_INTSITE_CONTENTCODE = 11;

        [NativeTypeName("#define PID_INTSITE_RECURSE 12")]
        public const int PID_INTSITE_RECURSE = 12;

        [NativeTypeName("#define PID_INTSITE_WATCH 13")]
        public const int PID_INTSITE_WATCH = 13;

        [NativeTypeName("#define PID_INTSITE_SUBSCRIPTION 14")]
        public const int PID_INTSITE_SUBSCRIPTION = 14;

        [NativeTypeName("#define PID_INTSITE_URL 15")]
        public const int PID_INTSITE_URL = 15;

        [NativeTypeName("#define PID_INTSITE_TITLE 16")]
        public const int PID_INTSITE_TITLE = 16;

        [NativeTypeName("#define PID_INTSITE_CODEPAGE 18")]
        public const int PID_INTSITE_CODEPAGE = 18;

        [NativeTypeName("#define PID_INTSITE_TRACKING 19")]
        public const int PID_INTSITE_TRACKING = 19;

        [NativeTypeName("#define PID_INTSITE_ICONINDEX 20")]
        public const int PID_INTSITE_ICONINDEX = 20;

        [NativeTypeName("#define PID_INTSITE_ICONFILE 21")]
        public const int PID_INTSITE_ICONFILE = 21;

        [NativeTypeName("#define PID_INTSITE_ROAMED 34")]
        public const int PID_INTSITE_ROAMED = 34;

        [NativeTypeName("#define PIDISF_RECENTLYCHANGED 0x00000001")]
        public const int PIDISF_RECENTLYCHANGED = 0x00000001;

        [NativeTypeName("#define PIDISF_CACHEDSTICKY 0x00000002")]
        public const int PIDISF_CACHEDSTICKY = 0x00000002;

        [NativeTypeName("#define PIDISF_CACHEIMAGES 0x00000010")]
        public const int PIDISF_CACHEIMAGES = 0x00000010;

        [NativeTypeName("#define PIDISF_FOLLOWALLLINKS 0x00000020")]
        public const int PIDISF_FOLLOWALLLINKS = 0x00000020;

        [NativeTypeName("#define PIDISM_GLOBAL 0")]
        public const int PIDISM_GLOBAL = 0;

        [NativeTypeName("#define PIDISM_WATCH 1")]
        public const int PIDISM_WATCH = 1;

        [NativeTypeName("#define PIDISM_DONTWATCH 2")]
        public const int PIDISM_DONTWATCH = 2;

        [NativeTypeName("#define PIDISR_UP_TO_DATE 0")]
        public const int PIDISR_UP_TO_DATE = 0;

        [NativeTypeName("#define PIDISR_NEEDS_ADD 1")]
        public const int PIDISR_NEEDS_ADD = 1;

        [NativeTypeName("#define PIDISR_NEEDS_UPDATE 2")]
        public const int PIDISR_NEEDS_UPDATE = 2;

        [NativeTypeName("#define PIDISR_NEEDS_DELETE 3")]
        public const int PIDISR_NEEDS_DELETE = 3;

        [NativeTypeName("#define SHELLSTATEVERSION_IE4 9")]
        public const int SHELLSTATEVERSION_IE4 = 9;

        [NativeTypeName("#define SHELLSTATEVERSION_WIN2K 10")]
        public const int SHELLSTATEVERSION_WIN2K = 10;

        [NativeTypeName("#define SHELLSTATE_SIZE_WIN95 FIELD_OFFSET(SHELLSTATE,lParamSort)")]
        public static int SHELLSTATE_SIZE_WIN95 => ((int)(Marshal.OffsetOf<SHELLSTATEW>("lParamSort")));

        [NativeTypeName("#define SHELLSTATE_SIZE_NT4 FIELD_OFFSET(SHELLSTATE,version)")]
        public static int SHELLSTATE_SIZE_NT4 => ((int)(Marshal.OffsetOf<SHELLSTATEW>("version")));

        [NativeTypeName("#define SHELLSTATE_SIZE_IE4 FIELD_OFFSET(SHELLSTATE,uNotUsed)")]
        public static int SHELLSTATE_SIZE_IE4 => ((int)(Marshal.OffsetOf<SHELLSTATEW>("uNotUsed")));

        [NativeTypeName("#define SHELLSTATE_SIZE_WIN2K sizeof(SHELLSTATE)")]
        public const uint SHELLSTATE_SIZE_WIN2K = 32;

        [NativeTypeName("#define SSF_SHOWALLOBJECTS 0x00000001")]
        public const int SSF_SHOWALLOBJECTS = 0x00000001;

        [NativeTypeName("#define SSF_SHOWEXTENSIONS 0x00000002")]
        public const int SSF_SHOWEXTENSIONS = 0x00000002;

        [NativeTypeName("#define SSF_HIDDENFILEEXTS 0x00000004")]
        public const int SSF_HIDDENFILEEXTS = 0x00000004;

        [NativeTypeName("#define SSF_SERVERADMINUI 0x00000004")]
        public const int SSF_SERVERADMINUI = 0x00000004;

        [NativeTypeName("#define SSF_SHOWCOMPCOLOR 0x00000008")]
        public const int SSF_SHOWCOMPCOLOR = 0x00000008;

        [NativeTypeName("#define SSF_SORTCOLUMNS 0x00000010")]
        public const int SSF_SORTCOLUMNS = 0x00000010;

        [NativeTypeName("#define SSF_SHOWSYSFILES 0x00000020")]
        public const int SSF_SHOWSYSFILES = 0x00000020;

        [NativeTypeName("#define SSF_DOUBLECLICKINWEBVIEW 0x00000080")]
        public const int SSF_DOUBLECLICKINWEBVIEW = 0x00000080;

        [NativeTypeName("#define SSF_SHOWATTRIBCOL 0x00000100")]
        public const int SSF_SHOWATTRIBCOL = 0x00000100;

        [NativeTypeName("#define SSF_DESKTOPHTML 0x00000200")]
        public const int SSF_DESKTOPHTML = 0x00000200;

        [NativeTypeName("#define SSF_WIN95CLASSIC 0x00000400")]
        public const int SSF_WIN95CLASSIC = 0x00000400;

        [NativeTypeName("#define SSF_DONTPRETTYPATH 0x00000800")]
        public const int SSF_DONTPRETTYPATH = 0x00000800;

        [NativeTypeName("#define SSF_SHOWINFOTIP 0x00002000")]
        public const int SSF_SHOWINFOTIP = 0x00002000;

        [NativeTypeName("#define SSF_MAPNETDRVBUTTON 0x00001000")]
        public const int SSF_MAPNETDRVBUTTON = 0x00001000;

        [NativeTypeName("#define SSF_NOCONFIRMRECYCLE 0x00008000")]
        public const int SSF_NOCONFIRMRECYCLE = 0x00008000;

        [NativeTypeName("#define SSF_HIDEICONS 0x00004000")]
        public const int SSF_HIDEICONS = 0x00004000;

        [NativeTypeName("#define SSF_FILTER 0x00010000")]
        public const int SSF_FILTER = 0x00010000;

        [NativeTypeName("#define SSF_WEBVIEW 0x00020000")]
        public const int SSF_WEBVIEW = 0x00020000;

        [NativeTypeName("#define SSF_SHOWSUPERHIDDEN 0x00040000")]
        public const int SSF_SHOWSUPERHIDDEN = 0x00040000;

        [NativeTypeName("#define SSF_SEPPROCESS 0x00080000")]
        public const int SSF_SEPPROCESS = 0x00080000;

        [NativeTypeName("#define SSF_NONETCRAWLING 0x00100000")]
        public const int SSF_NONETCRAWLING = 0x00100000;

        [NativeTypeName("#define SSF_STARTPANELON 0x00200000")]
        public const int SSF_STARTPANELON = 0x00200000;

        [NativeTypeName("#define SSF_SHOWSTARTPAGE 0x00400000")]
        public const int SSF_SHOWSTARTPAGE = 0x00400000;

        [NativeTypeName("#define SSF_AUTOCHECKSELECT 0x00800000")]
        public const int SSF_AUTOCHECKSELECT = 0x00800000;

        [NativeTypeName("#define SSF_ICONSONLY 0x01000000")]
        public const int SSF_ICONSONLY = 0x01000000;

        [NativeTypeName("#define SSF_SHOWTYPEOVERLAY 0x02000000")]
        public const int SSF_SHOWTYPEOVERLAY = 0x02000000;

        [NativeTypeName("#define SSF_SHOWSTATUSBAR 0x04000000")]
        public const int SSF_SHOWSTATUSBAR = 0x04000000;

        [NativeTypeName("#define SHPPFW_NONE 0x00000000")]
        public const int SHPPFW_NONE = 0x00000000;

        [NativeTypeName("#define SHPPFW_DEFAULT SHPPFW_DIRCREATE")]
        public const int SHPPFW_DEFAULT = 0x00000001;

        [NativeTypeName("#define SHPPFW_DIRCREATE 0x00000001")]
        public const int SHPPFW_DIRCREATE = 0x00000001;

        [NativeTypeName("#define SHPPFW_ASKDIRCREATE 0x00000002")]
        public const int SHPPFW_ASKDIRCREATE = 0x00000002;

        [NativeTypeName("#define SHPPFW_IGNOREFILENAME 0x00000004")]
        public const int SHPPFW_IGNOREFILENAME = 0x00000004;

        [NativeTypeName("#define SHPPFW_NOWRITECHECK 0x00000008")]
        public const int SHPPFW_NOWRITECHECK = 0x00000008;

        [NativeTypeName("#define SHPPFW_MEDIACHECKONLY 0x00000010")]
        public const int SHPPFW_MEDIACHECKONLY = 0x00000010;

        [NativeTypeName("#define SHPathPrepareForWrite SHPathPrepareForWriteW")]
        public static delegate*<HWND, IUnknown*, ushort*, uint, HRESULT> SHPathPrepareForWrite => &SHPathPrepareForWriteW;

        [NativeTypeName("#define SHCreateFileExtractIcon SHCreateFileExtractIconW")]
        public static delegate*<ushort*, uint, Guid*, void**, HRESULT> SHCreateFileExtractIcon => &SHCreateFileExtractIconW;

        public static ref readonly Guid IID_IShellFolderView
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC0, 0x78, 0xA3, 0x37,
                    0x2D, 0xF8,
                    0xCE, 0x11,
                    0xAE,
                    0x65,
                    0x08,
                    0x00,
                    0x2B,
                    0x2E,
                    0x12,
                    0x62
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
