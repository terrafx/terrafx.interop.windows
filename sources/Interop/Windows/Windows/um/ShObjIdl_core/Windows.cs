// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHSimpleIDListFromPath"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    [return: NativeTypeName("LPITEMIDLIST")]
    public static extern ITEMIDLIST* SHSimpleIDListFromPath([NativeTypeName("PCWSTR")] char* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateItemFromIDList"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateItemFromIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateItemFromParsingName"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateItemFromParsingName([NativeTypeName("PCWSTR")] char* pszPath, IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateItemWithParent"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateItemWithParent([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlParent, IShellFolder* psfParent, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("const IID &")] Guid* riid, void** ppvItem);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateItemFromRelativeName"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateItemFromRelativeName(IShellItem* psiParent, [NativeTypeName("PCWSTR")] char* pszName, IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateItemInKnownFolder"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateItemInKnownFolder([NativeTypeName("const KNOWNFOLDERID &")] Guid* kfid, [NativeTypeName("DWORD")] uint dwKFFlags, [NativeTypeName("PCWSTR")] char* pszItem, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetIDListFromObject"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetIDListFromObject(IUnknown* punk, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetItemFromObject"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetItemFromObject(IUnknown* punk, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetPropertyStoreFromIDList"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetPropertyStoreFromIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, GETPROPERTYSTOREFLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetPropertyStoreFromParsingName"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetPropertyStoreFromParsingName([NativeTypeName("PCWSTR")] char* pszPath, IBindCtx* pbc, GETPROPERTYSTOREFLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetNameFromIDList"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetNameFromIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, SIGDN sigdnName, [NativeTypeName("PWSTR *")] char** ppszName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetItemFromDataObject"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetItemFromDataObject(IDataObject* pdtobj, DATAOBJ_GET_ITEM_FLAGS dwFlags, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateShellItemArray"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateShellItemArray([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlParent, IShellFolder* psf, uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** ppidl, IShellItemArray** ppsiItemArray);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateShellItemArrayFromDataObject"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateShellItemArrayFromDataObject(IDataObject* pdo, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateShellItemArrayFromIDLists"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateShellItemArrayFromIDLists(uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** rgpidl, IShellItemArray** ppsiItemArray);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateShellItemArrayFromShellItem"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateShellItemArrayFromShellItem(IShellItem* psi, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FreeIDListArray"]/*' />
    public static void FreeIDListArray([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidls, uint cItems)
    {
        uint i;

        for (i = 0; i < cItems; i++)
        {
            CoTaskMemFree(unchecked((void*)(ppidls[i])));
        }

        CoTaskMemFree(ppidls);
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateAssociationRegistration"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateAssociationRegistration([NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FreeKnownFolderDefinitionFields"]/*' />
    public static void FreeKnownFolderDefinitionFields(KNOWNFOLDER_DEFINITION* pKFD)
    {
        CoTaskMemFree(pKFD->pszName);
        CoTaskMemFree(pKFD->pszDescription);
        CoTaskMemFree(pKFD->pszRelativePath);
        CoTaskMemFree(pKFD->pszParsingName);
        CoTaskMemFree(pKFD->pszTooltip);
        CoTaskMemFree(pKFD->pszLocalizedName);
        CoTaskMemFree(pKFD->pszIcon);
        CoTaskMemFree(pKFD->pszSecurity);
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCreateDefaultExtractIcon"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHCreateDefaultExtractIcon([NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetCurrentProcessExplicitAppUserModelID"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SetCurrentProcessExplicitAppUserModelID([NativeTypeName("PCWSTR")] char* AppID);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetCurrentProcessExplicitAppUserModelID"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT GetCurrentProcessExplicitAppUserModelID([NativeTypeName("PWSTR *")] char** AppID);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHGetTemporaryPropertyForItem"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHGetTemporaryPropertyForItem(IShellItem* psi, [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, PROPVARIANT* ppropvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHSetTemporaryPropertyForItem"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHSetTemporaryPropertyForItem(IShellItem* psi, [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHShowManageLibraryUI"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHShowManageLibraryUI(IShellItem* psiLibrary, HWND hwndOwner, [NativeTypeName("LPCWSTR")] char* pszTitle, [NativeTypeName("LPCWSTR")] char* pszInstruction, LIBRARYMANAGEDIALOGOPTIONS lmdOptions);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHResolveLibrary"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHResolveLibrary(IShellItem* psiLibrary);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHAssocEnumHandlers"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHAssocEnumHandlers([NativeTypeName("PCWSTR")] char* pszExtra, ASSOC_FILTER afFilter, IEnumAssocHandlers** ppEnumHandler);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHAssocEnumHandlersForProtocolByApplication"]/*' />
    [DllImport("shell32", ExactSpelling = true)]
    public static extern HRESULT SHAssocEnumHandlersForProtocolByApplication([NativeTypeName("PCWSTR")] char* protocol, [NativeTypeName("const IID &")] Guid* riid, void** enumHandlers);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMDSTR_NEWFOLDERA"]/*' />
    [NativeTypeName("#define CMDSTR_NEWFOLDERA \"NewFolder\"")]
    public static ReadOnlySpan<byte> CMDSTR_NEWFOLDERA => "NewFolder"u8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMDSTR_VIEWLISTA"]/*' />
    [NativeTypeName("#define CMDSTR_VIEWLISTA \"ViewList\"")]
    public static ReadOnlySpan<byte> CMDSTR_VIEWLISTA => "ViewList"u8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMDSTR_VIEWDETAILSA"]/*' />
    [NativeTypeName("#define CMDSTR_VIEWDETAILSA \"ViewDetails\"")]
    public static ReadOnlySpan<byte> CMDSTR_VIEWDETAILSA => "ViewDetails"u8;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMDSTR_NEWFOLDERW"]/*' />
    [NativeTypeName("#define CMDSTR_NEWFOLDERW L\"NewFolder\"")]
    public const string CMDSTR_NEWFOLDERW = "NewFolder";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMDSTR_VIEWLISTW"]/*' />
    [NativeTypeName("#define CMDSTR_VIEWLISTW L\"ViewList\"")]
    public const string CMDSTR_VIEWLISTW = "ViewList";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMDSTR_VIEWDETAILSW"]/*' />
    [NativeTypeName("#define CMDSTR_VIEWDETAILSW L\"ViewDetails\"")]
    public const string CMDSTR_VIEWDETAILSW = "ViewDetails";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMDSTR_NEWFOLDER"]/*' />
    [NativeTypeName("#define CMDSTR_NEWFOLDER CMDSTR_NEWFOLDERW")]
    public const string CMDSTR_NEWFOLDER = "NewFolder";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMDSTR_VIEWLIST"]/*' />
    [NativeTypeName("#define CMDSTR_VIEWLIST CMDSTR_VIEWLISTW")]
    public const string CMDSTR_VIEWLIST = "ViewList";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CMDSTR_VIEWDETAILS"]/*' />
    [NativeTypeName("#define CMDSTR_VIEWDETAILS CMDSTR_VIEWDETAILSW")]
    public const string CMDSTR_VIEWDETAILS = "ViewDetails";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IRTIR_TASK_NOT_RUNNING"]/*' />
    [NativeTypeName("#define IRTIR_TASK_NOT_RUNNING 0")]
    public const int IRTIR_TASK_NOT_RUNNING = 0;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IRTIR_TASK_RUNNING"]/*' />
    [NativeTypeName("#define IRTIR_TASK_RUNNING 1")]
    public const int IRTIR_TASK_RUNNING = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IRTIR_TASK_SUSPENDED"]/*' />
    [NativeTypeName("#define IRTIR_TASK_SUSPENDED 2")]
    public const int IRTIR_TASK_SUSPENDED = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IRTIR_TASK_PENDING"]/*' />
    [NativeTypeName("#define IRTIR_TASK_PENDING 3")]
    public const int IRTIR_TASK_PENDING = 3;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IRTIR_TASK_FINISHED"]/*' />
    [NativeTypeName("#define IRTIR_TASK_FINISHED 4")]
    public const int IRTIR_TASK_FINISHED = 4;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ITSAT_DEFAULT_LPARAM"]/*' />
    [NativeTypeName("#define ITSAT_DEFAULT_LPARAM ((DWORD_PTR)-1)")]
    public static nuint ITSAT_DEFAULT_LPARAM => unchecked((nuint)(-1));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ITSAT_DEFAULT_PRIORITY"]/*' />
    [NativeTypeName("#define ITSAT_DEFAULT_PRIORITY 0x10000000")]
    public const int ITSAT_DEFAULT_PRIORITY = 0x10000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ITSAT_MAX_PRIORITY"]/*' />
    [NativeTypeName("#define ITSAT_MAX_PRIORITY 0x7fffffff")]
    public const int ITSAT_MAX_PRIORITY = 0x7fffffff;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ITSAT_MIN_PRIORITY"]/*' />
    [NativeTypeName("#define ITSAT_MIN_PRIORITY 0x00000000")]
    public const int ITSAT_MIN_PRIORITY = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ITSSFLAG_COMPLETE_ON_DESTROY"]/*' />
    [NativeTypeName("#define ITSSFLAG_COMPLETE_ON_DESTROY 0x0000")]
    public const int ITSSFLAG_COMPLETE_ON_DESTROY = 0x0000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ITSSFLAG_KILL_ON_DESTROY"]/*' />
    [NativeTypeName("#define ITSSFLAG_KILL_ON_DESTROY 0x0001")]
    public const int ITSSFLAG_KILL_ON_DESTROY = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ITSSFLAG_FLAGS_MASK"]/*' />
    [NativeTypeName("#define ITSSFLAG_FLAGS_MASK 0x0003")]
    public const int ITSSFLAG_FLAGS_MASK = 0x0003;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ITSS_THREAD_DESTROY_DEFAULT_TIMEOUT"]/*' />
    [NativeTypeName("#define ITSS_THREAD_DESTROY_DEFAULT_TIMEOUT (10*1000)")]
    public const int ITSS_THREAD_DESTROY_DEFAULT_TIMEOUT = (10 * 1000);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ITSS_THREAD_TERMINATE_TIMEOUT"]/*' />
    [NativeTypeName("#define ITSS_THREAD_TERMINATE_TIMEOUT (INFINITE)")]
    public const uint ITSS_THREAD_TERMINATE_TIMEOUT = (0xFFFFFFFF);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ITSS_THREAD_TIMEOUT_NO_CHANGE"]/*' />
    [NativeTypeName("#define ITSS_THREAD_TIMEOUT_NO_CHANGE (INFINITE - 1)")]
    public const uint ITSS_THREAD_TIMEOUT_NO_CHANGE = (0xFFFFFFFF - 1);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCIDS_ALLFIELDS"]/*' />
    [NativeTypeName("#define SHCIDS_ALLFIELDS 0x80000000L")]
    public const uint SHCIDS_ALLFIELDS = 0x80000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCIDS_CANONICALONLY"]/*' />
    [NativeTypeName("#define SHCIDS_CANONICALONLY 0x10000000L")]
    public const int SHCIDS_CANONICALONLY = 0x10000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCIDS_BITMASK"]/*' />
    [NativeTypeName("#define SHCIDS_BITMASK 0xFFFF0000L")]
    public const uint SHCIDS_BITMASK = 0xFFFF0000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SHCIDS_COLUMNMASK"]/*' />
    [NativeTypeName("#define SHCIDS_COLUMNMASK 0x0000FFFFL")]
    public const int SHCIDS_COLUMNMASK = 0x0000FFFF;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CONFLICT_RESOLUTION_CLSID_KEY"]/*' />
    [NativeTypeName("#define CONFLICT_RESOLUTION_CLSID_KEY L\"ConflictResolutionCLSID\"")]
    public const string CONFLICT_RESOLUTION_CLSID_KEY = "ConflictResolutionCLSID";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BIND_INTERRUPTABLE"]/*' />
    [NativeTypeName("#define BIND_INTERRUPTABLE 0xFFFFFFFF")]
    public const uint BIND_INTERRUPTABLE = 0xFFFFFFFF;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SVSI_NOSTATECHANGE"]/*' />
    [NativeTypeName("#define SVSI_NOSTATECHANGE ((UINT)0x80000000)")]
    public const uint SVSI_NOSTATECHANGE = ((uint)(0x80000000));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SV2GV_CURRENTVIEW"]/*' />
    [NativeTypeName("#define SV2GV_CURRENTVIEW ((UINT)-1)")]
    public const uint SV2GV_CURRENTVIEW = unchecked((uint)(-1));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SV2GV_DEFAULTVIEW"]/*' />
    [NativeTypeName("#define SV2GV_DEFAULTVIEW ((UINT)-2)")]
    public const uint SV2GV_DEFAULTVIEW = unchecked((uint)(-2));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDBOSC_SETFOCUS"]/*' />
    [NativeTypeName("#define CDBOSC_SETFOCUS 0x00000000")]
    public const int CDBOSC_SETFOCUS = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDBOSC_KILLFOCUS"]/*' />
    [NativeTypeName("#define CDBOSC_KILLFOCUS 0x00000001")]
    public const int CDBOSC_KILLFOCUS = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDBOSC_SELCHANGE"]/*' />
    [NativeTypeName("#define CDBOSC_SELCHANGE 0x00000002")]
    public const int CDBOSC_SELCHANGE = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDBOSC_RENAME"]/*' />
    [NativeTypeName("#define CDBOSC_RENAME 0x00000003")]
    public const int CDBOSC_RENAME = 0x00000003;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDBOSC_STATECHANGE"]/*' />
    [NativeTypeName("#define CDBOSC_STATECHANGE 0x00000004")]
    public const int CDBOSC_STATECHANGE = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDB2N_CONTEXTMENU_DONE"]/*' />
    [NativeTypeName("#define CDB2N_CONTEXTMENU_DONE 0x00000001")]
    public const int CDB2N_CONTEXTMENU_DONE = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDB2N_CONTEXTMENU_START"]/*' />
    [NativeTypeName("#define CDB2N_CONTEXTMENU_START 0x00000002")]
    public const int CDB2N_CONTEXTMENU_START = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDB2GVF_SHOWALLFILES"]/*' />
    [NativeTypeName("#define CDB2GVF_SHOWALLFILES 0x00000001")]
    public const int CDB2GVF_SHOWALLFILES = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDB2GVF_ISFILESAVE"]/*' />
    [NativeTypeName("#define CDB2GVF_ISFILESAVE 0x00000002")]
    public const int CDB2GVF_ISFILESAVE = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDB2GVF_ALLOWPREVIEWPANE"]/*' />
    [NativeTypeName("#define CDB2GVF_ALLOWPREVIEWPANE 0x00000004")]
    public const int CDB2GVF_ALLOWPREVIEWPANE = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDB2GVF_NOSELECTVERB"]/*' />
    [NativeTypeName("#define CDB2GVF_NOSELECTVERB 0x00000008")]
    public const int CDB2GVF_NOSELECTVERB = 0x00000008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDB2GVF_NOINCLUDEITEM"]/*' />
    [NativeTypeName("#define CDB2GVF_NOINCLUDEITEM 0x00000010")]
    public const int CDB2GVF_NOINCLUDEITEM = 0x00000010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDB2GVF_ISFOLDERPICKER"]/*' />
    [NativeTypeName("#define CDB2GVF_ISFOLDERPICKER 0x00000020")]
    public const int CDB2GVF_ISFOLDERPICKER = 0x00000020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CDB2GVF_ADDSHIELD"]/*' />
    [NativeTypeName("#define CDB2GVF_ADDSHIELD 0x00000040")]
    public const int CDB2GVF_ADDSHIELD = 0x00000040;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FCW_STATUS"]/*' />
    [NativeTypeName("#define FCW_STATUS 0x0001")]
    public const int FCW_STATUS = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FCW_TOOLBAR"]/*' />
    [NativeTypeName("#define FCW_TOOLBAR 0x0002")]
    public const int FCW_TOOLBAR = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FCW_TREE"]/*' />
    [NativeTypeName("#define FCW_TREE 0x0003")]
    public const int FCW_TREE = 0x0003;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FCW_INTERNETBAR"]/*' />
    [NativeTypeName("#define FCW_INTERNETBAR 0x0006")]
    public const int FCW_INTERNETBAR = 0x0006;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FCW_PROGRESS"]/*' />
    [NativeTypeName("#define FCW_PROGRESS 0x0008")]
    public const int FCW_PROGRESS = 0x0008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FCT_MERGE"]/*' />
    [NativeTypeName("#define FCT_MERGE 0x0001")]
    public const int FCT_MERGE = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FCT_CONFIGABLE"]/*' />
    [NativeTypeName("#define FCT_CONFIGABLE 0x0002")]
    public const int FCT_CONFIGABLE = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FCT_ADDTOEND"]/*' />
    [NativeTypeName("#define FCT_ADDTOEND 0x0004")]
    public const int FCT_ADDTOEND = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IEI_PRIORITY_MAX"]/*' />
    [NativeTypeName("#define IEI_PRIORITY_MAX ITSAT_MAX_PRIORITY")]
    public const int IEI_PRIORITY_MAX = 0x7fffffff;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IEI_PRIORITY_MIN"]/*' />
    [NativeTypeName("#define IEI_PRIORITY_MIN ITSAT_MIN_PRIORITY")]
    public const int IEI_PRIORITY_MIN = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.IEIT_PRIORITY_NORMAL"]/*' />
    [NativeTypeName("#define IEIT_PRIORITY_NORMAL ITSAT_DEFAULT_PRIORITY")]
    public const int IEIT_PRIORITY_NORMAL = 0x10000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DBIM_MINSIZE"]/*' />
    [NativeTypeName("#define DBIM_MINSIZE 0x0001")]
    public const int DBIM_MINSIZE = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DBIM_MAXSIZE"]/*' />
    [NativeTypeName("#define DBIM_MAXSIZE 0x0002")]
    public const int DBIM_MAXSIZE = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DBIM_INTEGRAL"]/*' />
    [NativeTypeName("#define DBIM_INTEGRAL 0x0004")]
    public const int DBIM_INTEGRAL = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DBIM_ACTUAL"]/*' />
    [NativeTypeName("#define DBIM_ACTUAL 0x0008")]
    public const int DBIM_ACTUAL = 0x0008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DBIM_TITLE"]/*' />
    [NativeTypeName("#define DBIM_TITLE 0x0010")]
    public const int DBIM_TITLE = 0x0010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DBIM_MODEFLAGS"]/*' />
    [NativeTypeName("#define DBIM_MODEFLAGS 0x0020")]
    public const int DBIM_MODEFLAGS = 0x0020;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DBIM_BKCOLOR"]/*' />
    [NativeTypeName("#define DBIM_BKCOLOR 0x0040")]
    public const int DBIM_BKCOLOR = 0x0040;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DBIF_VIEWMODE_NORMAL"]/*' />
    [NativeTypeName("#define DBIF_VIEWMODE_NORMAL 0x0000")]
    public const int DBIF_VIEWMODE_NORMAL = 0x0000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DBIF_VIEWMODE_VERTICAL"]/*' />
    [NativeTypeName("#define DBIF_VIEWMODE_VERTICAL 0x0001")]
    public const int DBIF_VIEWMODE_VERTICAL = 0x0001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DBIF_VIEWMODE_FLOATING"]/*' />
    [NativeTypeName("#define DBIF_VIEWMODE_FLOATING 0x0002")]
    public const int DBIF_VIEWMODE_FLOATING = 0x0002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DBIF_VIEWMODE_TRANSPARENT"]/*' />
    [NativeTypeName("#define DBIF_VIEWMODE_TRANSPARENT 0x0004")]
    public const int DBIF_VIEWMODE_TRANSPARENT = 0x0004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DBPC_SELECTFIRST"]/*' />
    [NativeTypeName("#define DBPC_SELECTFIRST (DWORD)-1")]
    public const uint DBPC_SELECTFIRST = unchecked((uint)(-1));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DBPC_SELECTLAST"]/*' />
    [NativeTypeName("#define DBPC_SELECTLAST (DWORD)-2")]
    public const uint DBPC_SELECTLAST = unchecked((uint)(-2));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CGID_DeskBand"]/*' />
    [NativeTypeName("#define CGID_DeskBand IID_IDeskBand")]
    public static ref readonly Guid CGID_DeskBand => ref IID_IDeskBand;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.THBN_CLICKED"]/*' />
    [NativeTypeName("#define THBN_CLICKED 0x1800")]
    public const int THBN_CLICKED = 0x1800;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FreeIDListArrayFull"]/*' />
    [NativeTypeName("#define FreeIDListArrayFull FreeIDListArray")]
    public static delegate*<ITEMIDLIST**, uint, void> FreeIDListArrayFull => &FreeIDListArray;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.FreeIDListArrayChild"]/*' />
    [NativeTypeName("#define FreeIDListArrayChild FreeIDListArray")]
    public static delegate*<ITEMIDLIST**, uint, void> FreeIDListArrayChild => &FreeIDListArray;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BSIM_STATE"]/*' />
    [NativeTypeName("#define BSIM_STATE 0x00000001")]
    public const int BSIM_STATE = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BSIM_STYLE"]/*' />
    [NativeTypeName("#define BSIM_STYLE 0x00000002")]
    public const int BSIM_STYLE = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BSSF_VISIBLE"]/*' />
    [NativeTypeName("#define BSSF_VISIBLE 0x00000001")]
    public const int BSSF_VISIBLE = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BSSF_NOTITLE"]/*' />
    [NativeTypeName("#define BSSF_NOTITLE 0x00000002")]
    public const int BSSF_NOTITLE = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.BSSF_UNDELETEABLE"]/*' />
    [NativeTypeName("#define BSSF_UNDELETEABLE 0x00001000")]
    public const int BSSF_UNDELETEABLE = 0x00001000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CGID_BandSite"]/*' />
    [NativeTypeName("#define CGID_BandSite IID_IBandSite")]
    public static ref readonly Guid CGID_BandSite => ref IID_IBandSite;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SMDM_SHELLFOLDER"]/*' />
    [NativeTypeName("#define SMDM_SHELLFOLDER 0x00000001")]
    public const int SMDM_SHELLFOLDER = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SMDM_HMENU"]/*' />
    [NativeTypeName("#define SMDM_HMENU 0x00000002")]
    public const int SMDM_HMENU = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SMDM_TOOLBAR"]/*' />
    [NativeTypeName("#define SMDM_TOOLBAR 0x00000004")]
    public const int SMDM_TOOLBAR = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SMAE_EXPANDED"]/*' />
    [NativeTypeName("#define SMAE_EXPANDED 0x00000001")]
    public const int SMAE_EXPANDED = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SMAE_CONTRACTED"]/*' />
    [NativeTypeName("#define SMAE_CONTRACTED 0x00000002")]
    public const int SMAE_CONTRACTED = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SMAE_USER"]/*' />
    [NativeTypeName("#define SMAE_USER 0x00000004")]
    public const int SMAE_USER = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SMAE_VALID"]/*' />
    [NativeTypeName("#define SMAE_VALID 0x00000007")]
    public const int SMAE_VALID = 0x00000007;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SMINIT_DEFAULT"]/*' />
    [NativeTypeName("#define SMINIT_DEFAULT 0x00000000")]
    public const int SMINIT_DEFAULT = 0x00000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SMINIT_RESTRICT_DRAGDROP"]/*' />
    [NativeTypeName("#define SMINIT_RESTRICT_DRAGDROP 0x00000002")]
    public const int SMINIT_RESTRICT_DRAGDROP = 0x00000002;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SMINIT_TOPLEVEL"]/*' />
    [NativeTypeName("#define SMINIT_TOPLEVEL 0x00000004")]
    public const int SMINIT_TOPLEVEL = 0x00000004;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SMINIT_CACHED"]/*' />
    [NativeTypeName("#define SMINIT_CACHED 0x00000010")]
    public const int SMINIT_CACHED = 0x00000010;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SMINIT_AUTOEXPAND"]/*' />
    [NativeTypeName("#define SMINIT_AUTOEXPAND 0x00000100")]
    public const int SMINIT_AUTOEXPAND = 0x00000100;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SMINIT_AUTOTOOLTIP"]/*' />
    [NativeTypeName("#define SMINIT_AUTOTOOLTIP 0x00000200")]
    public const int SMINIT_AUTOTOOLTIP = 0x00000200;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SMINIT_DROPONCONTAINER"]/*' />
    [NativeTypeName("#define SMINIT_DROPONCONTAINER 0x00000400")]
    public const int SMINIT_DROPONCONTAINER = 0x00000400;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SMINIT_VERTICAL"]/*' />
    [NativeTypeName("#define SMINIT_VERTICAL 0x10000000")]
    public const int SMINIT_VERTICAL = 0x10000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SMINIT_HORIZONTAL"]/*' />
    [NativeTypeName("#define SMINIT_HORIZONTAL 0x20000000")]
    public const int SMINIT_HORIZONTAL = 0x20000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ANCESTORDEFAULT"]/*' />
    [NativeTypeName("#define ANCESTORDEFAULT (UINT)-1")]
    public const uint ANCESTORDEFAULT = unchecked((uint)(-1));

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SMSET_TOP"]/*' />
    [NativeTypeName("#define SMSET_TOP 0x10000000")]
    public const int SMSET_TOP = 0x10000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SMSET_BOTTOM"]/*' />
    [NativeTypeName("#define SMSET_BOTTOM 0x20000000")]
    public const int SMSET_BOTTOM = 0x20000000;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SMSET_DONTOWN"]/*' />
    [NativeTypeName("#define SMSET_DONTOWN 0x00000001")]
    public const int SMSET_DONTOWN = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SMINV_REFRESH"]/*' />
    [NativeTypeName("#define SMINV_REFRESH 0x00000001")]
    public const int SMINV_REFRESH = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.SMINV_ID"]/*' />
    [NativeTypeName("#define SMINV_ID 0x00000008")]
    public const int SMINV_ID = 0x00000008;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HOMEGROUP_SECURITY_GROUP_MULTI"]/*' />
    [NativeTypeName("#define HOMEGROUP_SECURITY_GROUP_MULTI L\"HUG\"")]
    public const string HOMEGROUP_SECURITY_GROUP_MULTI = "HUG";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HOMEGROUP_SECURITY_GROUP"]/*' />
    [NativeTypeName("#define HOMEGROUP_SECURITY_GROUP L\"HomeUsers\"")]
    public const string HOMEGROUP_SECURITY_GROUP = "HomeUsers";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PROP_CONTRACT_DELEGATE"]/*' />
    [NativeTypeName("#define PROP_CONTRACT_DELEGATE L\"ContractDelegate\"")]
    public const string PROP_CONTRACT_DELEGATE = "ContractDelegate";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ISIOI_ICONFILE"]/*' />
    [NativeTypeName("#define ISIOI_ICONFILE 0x00000001")]
    public const int ISIOI_ICONFILE = 0x00000001;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.ISIOI_ICONINDEX"]/*' />
    [NativeTypeName("#define ISIOI_ICONINDEX 0x00000002")]
    public const int ISIOI_ICONINDEX = 0x00000002;
}
