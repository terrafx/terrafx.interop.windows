// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.CLSCTX;
using static TerraFX.Interop.SIGDN;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("Shell32", ExactSpelling = true)]
        [return: NativeTypeName("LPITEMIDLIST")]
        public static extern ITEMIDLIST* SHSimpleIDListFromPath([NativeTypeName("PCWSTR")] ushort* pszPath);

        [DllImport("Shell32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHCreateItemFromIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("Shell32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHCreateItemFromParsingName([NativeTypeName("PCWSTR")] ushort* pszPath, IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("Shell32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHCreateItemWithParent([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlParent, IShellFolder* psfParent, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("const IID &")] Guid* riid, void** ppvItem);

        [DllImport("Shell32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHCreateItemFromRelativeName(IShellItem* psiParent, [NativeTypeName("PCWSTR")] ushort* pszName, IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("Shell32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHCreateItemInKnownFolder([NativeTypeName("const KNOWNFOLDERID &")] Guid* kfid, [NativeTypeName("DWORD")] uint dwKFFlags, [NativeTypeName("PCWSTR")] ushort* pszItem, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("Shell32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHGetIDListFromObject(IUnknown* punk, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl);

        [DllImport("Shell32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHGetItemFromObject(IUnknown* punk, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("Shell32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHGetPropertyStoreFromIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, GETPROPERTYSTOREFLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("Shell32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHGetPropertyStoreFromParsingName([NativeTypeName("PCWSTR")] ushort* pszPath, IBindCtx* pbc, GETPROPERTYSTOREFLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("Shell32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHGetNameFromIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, SIGDN sigdnName, [NativeTypeName("PWSTR *")] ushort** ppszName);

        [DllImport("Shell32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHGetItemFromDataObject(IDataObject* pdtobj, DATAOBJ_GET_ITEM_FLAGS dwFlags, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("Shell32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHCreateShellItemArray([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlParent, IShellFolder* psf, [NativeTypeName("UINT")] uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** ppidl, IShellItemArray** ppsiItemArray);

        [DllImport("Shell32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHCreateShellItemArrayFromDataObject(IDataObject* pdo, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("Shell32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHCreateShellItemArrayFromIDLists([NativeTypeName("UINT")] uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** rgpidl, IShellItemArray** ppsiItemArray);

        [DllImport("Shell32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHCreateShellItemArrayFromShellItem(IShellItem* psi, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        public static void FreeIDListArray([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidls, [NativeTypeName("UINT")] uint cItems)
        {
            uint i;

            for (i = 0; i < cItems; i++)
            {
                CoTaskMemFree(ppidls[i]);
            }

            CoTaskMemFree(ppidls);
        }

        [DllImport("Shell32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHCreateAssociationRegistration([NativeTypeName("const IID &")] Guid* riid, void** ppv);

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

        [DllImport("Shell32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHCreateDefaultExtractIcon([NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("Shell32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SetCurrentProcessExplicitAppUserModelID([NativeTypeName("PCWSTR")] ushort* AppID);

        [DllImport("Shell32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetCurrentProcessExplicitAppUserModelID([NativeTypeName("PWSTR *")] ushort** AppID);

        [DllImport("Shell32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHGetTemporaryPropertyForItem(IShellItem* psi, [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, PROPVARIANT* ppropvar);

        [DllImport("Shell32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHSetTemporaryPropertyForItem(IShellItem* psi, [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar);

        [DllImport("Shell32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHShowManageLibraryUI(IShellItem* psiLibrary, [NativeTypeName("HWND")] IntPtr hwndOwner, [NativeTypeName("LPCWSTR")] ushort* pszTitle, [NativeTypeName("LPCWSTR")] ushort* pszInstruction, LIBRARYMANAGEDIALOGOPTIONS lmdOptions);

        [DllImport("Shell32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHResolveLibrary(IShellItem* psiLibrary);

        [return: NativeTypeName("HRESULT")]
        public static int SHCreateLibrary([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            fixed (Guid* rclsid = &CLSID_ShellLibrary)
            {
                return CoCreateInstance(rclsid, null, (uint)(CLSCTX_INPROC_SERVER), riid, ppv);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public static int SHLoadLibraryFromItem(IShellItem* psiLibrary, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            fixed (Guid* rclsid = &CLSID_ShellLibrary)
            {
                *ppv = null;
                IShellLibrary* plib;
                int hr = CoCreateInstance(rclsid, null, (uint)(CLSCTX_INPROC_SERVER), __uuidof<IShellItem>(), (void**)(&plib));

                if ((((int)(hr)) >= 0))
                {
                    hr = plib->LoadLibraryFromItem(psiLibrary, grfMode);
                    if ((((int)(hr)) >= 0))
                    {
                        hr = plib->QueryInterface(riid, ppv);
                    }

                    plib->Release();
                }

                return hr;
            }
        }

        [return: NativeTypeName("HRESULT")]
        public static int SHLoadLibraryFromKnownFolder([NativeTypeName("const KNOWNFOLDERID &")] Guid* kfidLibrary, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            fixed (Guid* rclsid = &CLSID_ShellLibrary)
            {
                *ppv = null;
                IShellLibrary* plib;
                int hr = CoCreateInstance(rclsid, null, (uint)(CLSCTX_INPROC_SERVER), __uuidof<IShellItem>(), (void**)(&plib));

                if ((((int)(hr)) >= 0))
                {
                    hr = plib->LoadLibraryFromKnownFolder(kfidLibrary, grfMode);
                    if ((((int)(hr)) >= 0))
                    {
                        hr = plib->QueryInterface(riid, ppv);
                    }

                    plib->Release();
                }

                return hr;
            }
        }

        [return: NativeTypeName("HRESULT")]
        public static int SHLoadLibraryFromParsingName([NativeTypeName("PCWSTR")] ushort* pszParsingName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            *ppv = null;
            IShellItem* psiLibrary;
            int hr = SHCreateItemFromParsingName(pszParsingName, null, __uuidof<IShellItem>(), (void**)(&psiLibrary));

            if ((((int)(hr)) >= 0))
            {
                hr = SHLoadLibraryFromItem(psiLibrary, grfMode, riid, ppv);
                psiLibrary->Release();
            }

            return hr;
        }

        [return: NativeTypeName("HRESULT")]
        public static int SHAddFolderPathToLibrary(IShellLibrary* plib, [NativeTypeName("PCWSTR")] ushort* pszFolderPath)
        {
            IShellItem* psiFolder;
            int hr = SHCreateItemFromParsingName(pszFolderPath, null, __uuidof<IShellItem>(), (void**)(&psiFolder));

            if ((((int)(hr)) >= 0))
            {
                hr = plib->AddFolder(psiFolder);
                psiFolder->Release();
            }

            return hr;
        }

        [return: NativeTypeName("HRESULT")]
        public static int SHRemoveFolderPathFromLibrary(IShellLibrary* plib, [NativeTypeName("PCWSTR")] ushort* pszFolderPath)
        {
            ITEMIDLIST* pidlFolder = SHSimpleIDListFromPath(pszFolderPath);
            int hr = unchecked((pidlFolder) != null ? ((int)(0)) : ((int)(0x80070057)));

            if ((((int)(hr)) >= 0))
            {
                IShellItem* psiFolder;

                hr = SHCreateItemFromIDList(pidlFolder, __uuidof<IShellItem>(), (void**)(&psiFolder));
                if ((((int)(hr)) >= 0))
                {
                    hr = plib->RemoveFolder(psiFolder);
                    psiFolder->Release();
                }

                CoTaskMemFree(pidlFolder);
            }

            return hr;
        }

        [return: NativeTypeName("HRESULT")]
        public static int SHSaveLibraryInFolderPath(IShellLibrary* plib, [NativeTypeName("PCWSTR")] ushort* pszFolderPath, [NativeTypeName("PCWSTR")] ushort* pszLibraryName, LIBRARYSAVEFLAGS lsf, [NativeTypeName("PWSTR *")] ushort** ppszSavedToPath)
        {
            if ((ppszSavedToPath) != null)
            {
                *ppszSavedToPath = null;
            }

            IShellItem* psiFolder;
            int hr = SHCreateItemFromParsingName(pszFolderPath, null, __uuidof<IShellItem>(), (void**)(&psiFolder));

            if ((((int)(hr)) >= 0))
            {
                IShellItem* psiSavedTo;

                hr = plib->Save(psiFolder, pszLibraryName, lsf, &psiSavedTo);
                if ((((int)(hr)) >= 0))
                {
                    if ((ppszSavedToPath) != null)
                    {
                        hr = psiSavedTo->GetDisplayName(SIGDN_DESKTOPABSOLUTEPARSING, ppszSavedToPath);
                    }

                    psiSavedTo->Release();
                }

                psiFolder->Release();
            }

            return hr;
        }

        [DllImport("Shell32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHAssocEnumHandlers([NativeTypeName("PCWSTR")] ushort* pszExtra, ASSOC_FILTER afFilter, IEnumAssocHandlers** ppEnumHandler);

        [DllImport("Shell32", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int SHAssocEnumHandlersForProtocolByApplication([NativeTypeName("PCWSTR")] ushort* protocol, [NativeTypeName("const IID &")] Guid* riid, void** enumHandlers);

        public static void SetContractDelegateWindow([NativeTypeName("HWND")] IntPtr hwndSource, [NativeTypeName("HWND")] IntPtr hwndDelegate)
        {
            fixed (char* lpString = "ContractDelegate")
            {
                if (hwndDelegate != IntPtr.Zero)
                {
                    SetPropW(hwndSource, (ushort*)lpString, (IntPtr)(hwndDelegate));
                }
                else
                {

                    RemovePropW(hwndSource, (ushort*)lpString);
                }
            }
        }

        [NativeTypeName("const GUID")]
        public static readonly Guid SID_URLExecutionContext = new Guid(0xFB5F8EBC, 0xBBB6, 0x4D10, 0xA4, 0x61, 0x77, 0x72, 0x91, 0xA0, 0x90, 0x30);

        [NativeTypeName("const GUID")]
        public static readonly Guid SID_LaunchSourceViewSizePreference = new Guid(0x80605492, 0x67d9, 0x414f, 0xaf, 0x89, 0xa1, 0xcd, 0xf1, 0x24, 0x2b, 0xc1);

        [NativeTypeName("const GUID")]
        public static readonly Guid SID_LaunchTargetViewSizePreference = new Guid(0x26db2472, 0xb7b7, 0x406b, 0x97, 0x2, 0x73, 0xa, 0x4e, 0x20, 0xd3, 0xbf);

        [NativeTypeName("const GUID")]
        public static readonly Guid SID_LaunchSourceAppUserModelId = new Guid(0x2ce78010, 0x74db, 0x48bc, 0x9c, 0x6a, 0x10, 0xf3, 0x72, 0x49, 0x57, 0x23);

        [NativeTypeName("const GUID")]
        public static readonly Guid SID_ShellExecuteNamedPropertyStore = new Guid(0xeb84ada2, 0x00ff, 0x4992, 0x83, 0x24, 0xed, 0x5c, 0xe0, 0x61, 0xcb, 0x29);

        [NativeTypeName("#define CMF_NORMAL 0x00000000")]
        public const int CMF_NORMAL = 0x00000000;

        [NativeTypeName("#define CMF_DEFAULTONLY 0x00000001")]
        public const int CMF_DEFAULTONLY = 0x00000001;

        [NativeTypeName("#define CMF_VERBSONLY 0x00000002")]
        public const int CMF_VERBSONLY = 0x00000002;

        [NativeTypeName("#define CMF_EXPLORE 0x00000004")]
        public const int CMF_EXPLORE = 0x00000004;

        [NativeTypeName("#define CMF_NOVERBS 0x00000008")]
        public const int CMF_NOVERBS = 0x00000008;

        [NativeTypeName("#define CMF_CANRENAME 0x00000010")]
        public const int CMF_CANRENAME = 0x00000010;

        [NativeTypeName("#define CMF_NODEFAULT 0x00000020")]
        public const int CMF_NODEFAULT = 0x00000020;

        [NativeTypeName("#define CMF_ITEMMENU 0x00000080")]
        public const int CMF_ITEMMENU = 0x00000080;

        [NativeTypeName("#define CMF_EXTENDEDVERBS 0x00000100")]
        public const int CMF_EXTENDEDVERBS = 0x00000100;

        [NativeTypeName("#define CMF_DISABLEDVERBS 0x00000200")]
        public const int CMF_DISABLEDVERBS = 0x00000200;

        [NativeTypeName("#define CMF_ASYNCVERBSTATE 0x00000400")]
        public const int CMF_ASYNCVERBSTATE = 0x00000400;

        [NativeTypeName("#define CMF_OPTIMIZEFORINVOKE 0x00000800")]
        public const int CMF_OPTIMIZEFORINVOKE = 0x00000800;

        [NativeTypeName("#define CMF_SYNCCASCADEMENU 0x00001000")]
        public const int CMF_SYNCCASCADEMENU = 0x00001000;

        [NativeTypeName("#define CMF_DONOTPICKDEFAULT 0x00002000")]
        public const int CMF_DONOTPICKDEFAULT = 0x00002000;

        [NativeTypeName("#define CMF_RESERVED 0xffff0000")]
        public const uint CMF_RESERVED = 0xffff0000;

        [NativeTypeName("#define GCS_VERBA 0x00000000")]
        public const int GCS_VERBA = 0x00000000;

        [NativeTypeName("#define GCS_HELPTEXTA 0x00000001")]
        public const int GCS_HELPTEXTA = 0x00000001;

        [NativeTypeName("#define GCS_VALIDATEA 0x00000002")]
        public const int GCS_VALIDATEA = 0x00000002;

        [NativeTypeName("#define GCS_VERBW 0x00000004")]
        public const int GCS_VERBW = 0x00000004;

        [NativeTypeName("#define GCS_HELPTEXTW 0x00000005")]
        public const int GCS_HELPTEXTW = 0x00000005;

        [NativeTypeName("#define GCS_VALIDATEW 0x00000006")]
        public const int GCS_VALIDATEW = 0x00000006;

        [NativeTypeName("#define GCS_VERBICONW 0x00000014")]
        public const int GCS_VERBICONW = 0x00000014;

        [NativeTypeName("#define GCS_UNICODE 0x00000004")]
        public const int GCS_UNICODE = 0x00000004;

        [NativeTypeName("#define GCS_VERB GCS_VERBW")]
        public const int GCS_VERB = 0x00000004;

        [NativeTypeName("#define GCS_HELPTEXT GCS_HELPTEXTW")]
        public const int GCS_HELPTEXT = 0x00000005;

        [NativeTypeName("#define GCS_VALIDATE GCS_VALIDATEW")]
        public const int GCS_VALIDATE = 0x00000006;

        [NativeTypeName("#define CMDSTR_NEWFOLDERA \"NewFolder\"")]
        public static ReadOnlySpan<byte> CMDSTR_NEWFOLDERA => new byte[] { 0x4E, 0x65, 0x77, 0x46, 0x6F, 0x6C, 0x64, 0x65, 0x72, 0x00 };

        [NativeTypeName("#define CMDSTR_VIEWLISTA \"ViewList\"")]
        public static ReadOnlySpan<byte> CMDSTR_VIEWLISTA => new byte[] { 0x56, 0x69, 0x65, 0x77, 0x4C, 0x69, 0x73, 0x74, 0x00 };

        [NativeTypeName("#define CMDSTR_VIEWDETAILSA \"ViewDetails\"")]
        public static ReadOnlySpan<byte> CMDSTR_VIEWDETAILSA => new byte[] { 0x56, 0x69, 0x65, 0x77, 0x44, 0x65, 0x74, 0x61, 0x69, 0x6C, 0x73, 0x00 };

        [NativeTypeName("#define CMDSTR_NEWFOLDERW L\"NewFolder\"")]
        public const string CMDSTR_NEWFOLDERW = "NewFolder";

        [NativeTypeName("#define CMDSTR_VIEWLISTW L\"ViewList\"")]
        public const string CMDSTR_VIEWLISTW = "ViewList";

        [NativeTypeName("#define CMDSTR_VIEWDETAILSW L\"ViewDetails\"")]
        public const string CMDSTR_VIEWDETAILSW = "ViewDetails";

        [NativeTypeName("#define CMDSTR_NEWFOLDER CMDSTR_NEWFOLDERW")]
        public const string CMDSTR_NEWFOLDER = "NewFolder";

        [NativeTypeName("#define CMDSTR_VIEWLIST CMDSTR_VIEWLISTW")]
        public const string CMDSTR_VIEWLIST = "ViewList";

        [NativeTypeName("#define CMDSTR_VIEWDETAILS CMDSTR_VIEWDETAILSW")]
        public const string CMDSTR_VIEWDETAILS = "ViewDetails";

        [NativeTypeName("#define CMIC_MASK_HOTKEY SEE_MASK_HOTKEY")]
        public const int CMIC_MASK_HOTKEY = 0x00000020;

        [NativeTypeName("#define CMIC_MASK_FLAG_NO_UI SEE_MASK_FLAG_NO_UI")]
        public const int CMIC_MASK_FLAG_NO_UI = 0x00000400;

        [NativeTypeName("#define CMIC_MASK_UNICODE SEE_MASK_UNICODE")]
        public const int CMIC_MASK_UNICODE = 0x00004000;

        [NativeTypeName("#define CMIC_MASK_NO_CONSOLE SEE_MASK_NO_CONSOLE")]
        public const int CMIC_MASK_NO_CONSOLE = 0x00008000;

        [NativeTypeName("#define CMIC_MASK_ASYNCOK SEE_MASK_ASYNCOK")]
        public const int CMIC_MASK_ASYNCOK = 0x00100000;

        [NativeTypeName("#define CMIC_MASK_NOASYNC SEE_MASK_NOASYNC")]
        public const int CMIC_MASK_NOASYNC = 0x00000100;

        [NativeTypeName("#define CMIC_MASK_SHIFT_DOWN 0x10000000")]
        public const int CMIC_MASK_SHIFT_DOWN = 0x10000000;

        [NativeTypeName("#define CMIC_MASK_CONTROL_DOWN 0x40000000")]
        public const int CMIC_MASK_CONTROL_DOWN = 0x40000000;

        [NativeTypeName("#define CMIC_MASK_FLAG_LOG_USAGE SEE_MASK_FLAG_LOG_USAGE")]
        public const int CMIC_MASK_FLAG_LOG_USAGE = 0x04000000;

        [NativeTypeName("#define CMIC_MASK_NOZONECHECKS SEE_MASK_NOZONECHECKS")]
        public const int CMIC_MASK_NOZONECHECKS = 0x00800000;

        [NativeTypeName("#define CMIC_MASK_PTINVOKE 0x20000000")]
        public const int CMIC_MASK_PTINVOKE = 0x20000000;

        [NativeTypeName("#define IRTIR_TASK_NOT_RUNNING 0")]
        public const int IRTIR_TASK_NOT_RUNNING = 0;

        [NativeTypeName("#define IRTIR_TASK_RUNNING 1")]
        public const int IRTIR_TASK_RUNNING = 1;

        [NativeTypeName("#define IRTIR_TASK_SUSPENDED 2")]
        public const int IRTIR_TASK_SUSPENDED = 2;

        [NativeTypeName("#define IRTIR_TASK_PENDING 3")]
        public const int IRTIR_TASK_PENDING = 3;

        [NativeTypeName("#define IRTIR_TASK_FINISHED 4")]
        public const int IRTIR_TASK_FINISHED = 4;

        [NativeTypeName("#define ITSAT_DEFAULT_LPARAM ((DWORD_PTR)-1)")]
        public static readonly nuint ITSAT_DEFAULT_LPARAM = unchecked((nuint)(-1));

        [NativeTypeName("#define ITSAT_DEFAULT_PRIORITY 0x10000000")]
        public const int ITSAT_DEFAULT_PRIORITY = 0x10000000;

        [NativeTypeName("#define ITSAT_MAX_PRIORITY 0x7fffffff")]
        public const int ITSAT_MAX_PRIORITY = 0x7fffffff;

        [NativeTypeName("#define ITSAT_MIN_PRIORITY 0x00000000")]
        public const int ITSAT_MIN_PRIORITY = 0x00000000;

        [NativeTypeName("#define ITSSFLAG_COMPLETE_ON_DESTROY 0x0000")]
        public const int ITSSFLAG_COMPLETE_ON_DESTROY = 0x0000;

        [NativeTypeName("#define ITSSFLAG_KILL_ON_DESTROY 0x0001")]
        public const int ITSSFLAG_KILL_ON_DESTROY = 0x0001;

        [NativeTypeName("#define ITSSFLAG_FLAGS_MASK 0x0003")]
        public const int ITSSFLAG_FLAGS_MASK = 0x0003;

        [NativeTypeName("#define ITSS_THREAD_DESTROY_DEFAULT_TIMEOUT (10*1000)")]
        public const int ITSS_THREAD_DESTROY_DEFAULT_TIMEOUT = (10 * 1000);

        [NativeTypeName("#define ITSS_THREAD_TERMINATE_TIMEOUT (INFINITE)")]
        public const uint ITSS_THREAD_TERMINATE_TIMEOUT = (0xFFFFFFFF);

        [NativeTypeName("#define ITSS_THREAD_TIMEOUT_NO_CHANGE (INFINITE - 1)")]
        public const uint ITSS_THREAD_TIMEOUT_NO_CHANGE = (0xFFFFFFFF - 1);

        [NativeTypeName("#define SID_ShellTaskScheduler IID_IShellTaskScheduler")]
        public static readonly Guid SID_ShellTaskScheduler = IID_IShellTaskScheduler;

        [NativeTypeName("#define SHCIDS_ALLFIELDS 0x80000000L")]
        public const uint SHCIDS_ALLFIELDS = 0x80000000;

        [NativeTypeName("#define SHCIDS_CANONICALONLY 0x10000000L")]
        public const int SHCIDS_CANONICALONLY = 0x10000000;

        [NativeTypeName("#define SHCIDS_BITMASK 0xFFFF0000L")]
        public const uint SHCIDS_BITMASK = 0xFFFF0000;

        [NativeTypeName("#define SHCIDS_COLUMNMASK 0x0000FFFFL")]
        public const int SHCIDS_COLUMNMASK = 0x0000FFFF;

        [NativeTypeName("#define SFGAO_CANCOPY DROPEFFECT_COPY")]
        public const int SFGAO_CANCOPY = (1);

        [NativeTypeName("#define SFGAO_CANMOVE DROPEFFECT_MOVE")]
        public const int SFGAO_CANMOVE = (2);

        [NativeTypeName("#define SFGAO_CANLINK DROPEFFECT_LINK")]
        public const int SFGAO_CANLINK = (4);

        [NativeTypeName("#define SFGAO_STORAGE 0x00000008L")]
        public const int SFGAO_STORAGE = 0x00000008;

        [NativeTypeName("#define SFGAO_CANRENAME 0x00000010L")]
        public const int SFGAO_CANRENAME = 0x00000010;

        [NativeTypeName("#define SFGAO_CANDELETE 0x00000020L")]
        public const int SFGAO_CANDELETE = 0x00000020;

        [NativeTypeName("#define SFGAO_HASPROPSHEET 0x00000040L")]
        public const int SFGAO_HASPROPSHEET = 0x00000040;

        [NativeTypeName("#define SFGAO_DROPTARGET 0x00000100L")]
        public const int SFGAO_DROPTARGET = 0x00000100;

        [NativeTypeName("#define SFGAO_CAPABILITYMASK 0x00000177L")]
        public const int SFGAO_CAPABILITYMASK = 0x00000177;

        [NativeTypeName("#define SFGAO_PLACEHOLDER 0x00000800L")]
        public const int SFGAO_PLACEHOLDER = 0x00000800;

        [NativeTypeName("#define SFGAO_SYSTEM 0x00001000L")]
        public const int SFGAO_SYSTEM = 0x00001000;

        [NativeTypeName("#define SFGAO_ENCRYPTED 0x00002000L")]
        public const int SFGAO_ENCRYPTED = 0x00002000;

        [NativeTypeName("#define SFGAO_ISSLOW 0x00004000L")]
        public const int SFGAO_ISSLOW = 0x00004000;

        [NativeTypeName("#define SFGAO_GHOSTED 0x00008000L")]
        public const int SFGAO_GHOSTED = 0x00008000;

        [NativeTypeName("#define SFGAO_LINK 0x00010000L")]
        public const int SFGAO_LINK = 0x00010000;

        [NativeTypeName("#define SFGAO_SHARE 0x00020000L")]
        public const int SFGAO_SHARE = 0x00020000;

        [NativeTypeName("#define SFGAO_READONLY 0x00040000L")]
        public const int SFGAO_READONLY = 0x00040000;

        [NativeTypeName("#define SFGAO_HIDDEN 0x00080000L")]
        public const int SFGAO_HIDDEN = 0x00080000;

        [NativeTypeName("#define SFGAO_DISPLAYATTRMASK 0x000FC000L")]
        public const int SFGAO_DISPLAYATTRMASK = 0x000FC000;

        [NativeTypeName("#define SFGAO_FILESYSANCESTOR 0x10000000L")]
        public const int SFGAO_FILESYSANCESTOR = 0x10000000;

        [NativeTypeName("#define SFGAO_FOLDER 0x20000000L")]
        public const int SFGAO_FOLDER = 0x20000000;

        [NativeTypeName("#define SFGAO_FILESYSTEM 0x40000000L")]
        public const int SFGAO_FILESYSTEM = 0x40000000;

        [NativeTypeName("#define SFGAO_HASSUBFOLDER 0x80000000L")]
        public const uint SFGAO_HASSUBFOLDER = 0x80000000;

        [NativeTypeName("#define SFGAO_CONTENTSMASK 0x80000000L")]
        public const uint SFGAO_CONTENTSMASK = 0x80000000;

        [NativeTypeName("#define SFGAO_VALIDATE 0x01000000L")]
        public const int SFGAO_VALIDATE = 0x01000000;

        [NativeTypeName("#define SFGAO_REMOVABLE 0x02000000L")]
        public const int SFGAO_REMOVABLE = 0x02000000;

        [NativeTypeName("#define SFGAO_COMPRESSED 0x04000000L")]
        public const int SFGAO_COMPRESSED = 0x04000000;

        [NativeTypeName("#define SFGAO_BROWSABLE 0x08000000L")]
        public const int SFGAO_BROWSABLE = 0x08000000;

        [NativeTypeName("#define SFGAO_NONENUMERATED 0x00100000L")]
        public const int SFGAO_NONENUMERATED = 0x00100000;

        [NativeTypeName("#define SFGAO_NEWCONTENT 0x00200000L")]
        public const int SFGAO_NEWCONTENT = 0x00200000;

        [NativeTypeName("#define SFGAO_CANMONIKER 0x00400000L")]
        public const int SFGAO_CANMONIKER = 0x00400000;

        [NativeTypeName("#define SFGAO_HASSTORAGE 0x00400000L")]
        public const int SFGAO_HASSTORAGE = 0x00400000;

        [NativeTypeName("#define SFGAO_STREAM 0x00400000L")]
        public const int SFGAO_STREAM = 0x00400000;

        [NativeTypeName("#define SFGAO_STORAGEANCESTOR 0x00800000L")]
        public const int SFGAO_STORAGEANCESTOR = 0x00800000;

        [NativeTypeName("#define SFGAO_STORAGECAPMASK 0x70C50008L")]
        public const int SFGAO_STORAGECAPMASK = 0x70C50008;

        [NativeTypeName("#define SFGAO_PKEYSFGAOMASK 0x81044000L")]
        public const uint SFGAO_PKEYSFGAOMASK = 0x81044000;

        [NativeTypeName("#define CONFLICT_RESOLUTION_CLSID_KEY L\"ConflictResolutionCLSID\"")]
        public const string CONFLICT_RESOLUTION_CLSID_KEY = "ConflictResolutionCLSID";

        [NativeTypeName("#define STR_BIND_FORCE_FOLDER_SHORTCUT_RESOLVE L\"Force Folder Shortcut Resolve\"")]
        public const string STR_BIND_FORCE_FOLDER_SHORTCUT_RESOLVE = "Force Folder Shortcut Resolve";

        [NativeTypeName("#define STR_AVOID_DRIVE_RESTRICTION_POLICY L\"Avoid Drive Restriction Policy\"")]
        public const string STR_AVOID_DRIVE_RESTRICTION_POLICY = "Avoid Drive Restriction Policy";

        [NativeTypeName("#define STR_SKIP_BINDING_CLSID L\"Skip Binding CLSID\"")]
        public const string STR_SKIP_BINDING_CLSID = "Skip Binding CLSID";

        [NativeTypeName("#define STR_PARSE_PREFER_FOLDER_BROWSING L\"Parse Prefer Folder Browsing\"")]
        public const string STR_PARSE_PREFER_FOLDER_BROWSING = "Parse Prefer Folder Browsing";

        [NativeTypeName("#define STR_DONT_PARSE_RELATIVE L\"Don't Parse Relative\"")]
        public const string STR_DONT_PARSE_RELATIVE = "Don't Parse Relative";

        [NativeTypeName("#define STR_PARSE_TRANSLATE_ALIASES L\"Parse Translate Aliases\"")]
        public const string STR_PARSE_TRANSLATE_ALIASES = "Parse Translate Aliases";

        [NativeTypeName("#define STR_PARSE_SKIP_NET_CACHE L\"Skip Net Resource Cache\"")]
        public const string STR_PARSE_SKIP_NET_CACHE = "Skip Net Resource Cache";

        [NativeTypeName("#define STR_PARSE_SHELL_PROTOCOL_TO_FILE_OBJECTS L\"Parse Shell Protocol To File Objects\"")]
        public const string STR_PARSE_SHELL_PROTOCOL_TO_FILE_OBJECTS = "Parse Shell Protocol To File Objects";

        [NativeTypeName("#define STR_TRACK_CLSID L\"Track the CLSID\"")]
        public const string STR_TRACK_CLSID = "Track the CLSID";

        [NativeTypeName("#define STR_INTERNAL_NAVIGATE L\"Internal Navigation\"")]
        public const string STR_INTERNAL_NAVIGATE = "Internal Navigation";

        [NativeTypeName("#define STR_PARSE_PROPERTYSTORE L\"DelegateNamedProperties\"")]
        public const string STR_PARSE_PROPERTYSTORE = "DelegateNamedProperties";

        [NativeTypeName("#define STR_NO_VALIDATE_FILENAME_CHARS L\"NoValidateFilenameChars\"")]
        public const string STR_NO_VALIDATE_FILENAME_CHARS = "NoValidateFilenameChars";

        [NativeTypeName("#define STR_BIND_DELEGATE_CREATE_OBJECT L\"Delegate Object Creation\"")]
        public const string STR_BIND_DELEGATE_CREATE_OBJECT = "Delegate Object Creation";

        [NativeTypeName("#define STR_PARSE_ALLOW_INTERNET_SHELL_FOLDERS L\"Allow binding to Internet shell folder handlers and negate STR_PARSE_PREFER_WEB_BROWSING\"")]
        public const string STR_PARSE_ALLOW_INTERNET_SHELL_FOLDERS = "Allow binding to Internet shell folder handlers and negate STR_PARSE_PREFER_WEB_BROWSING";

        [NativeTypeName("#define STR_PARSE_PREFER_WEB_BROWSING L\"Do not bind to Internet shell folder handlers\"")]
        public const string STR_PARSE_PREFER_WEB_BROWSING = "Do not bind to Internet shell folder handlers";

        [NativeTypeName("#define STR_PARSE_SHOW_NET_DIAGNOSTICS_UI L\"Show network diagnostics UI\"")]
        public const string STR_PARSE_SHOW_NET_DIAGNOSTICS_UI = "Show network diagnostics UI";

        [NativeTypeName("#define STR_PARSE_DONT_REQUIRE_VALIDATED_URLS L\"Do not require validated URLs\"")]
        public const string STR_PARSE_DONT_REQUIRE_VALIDATED_URLS = "Do not require validated URLs";

        [NativeTypeName("#define STR_INTERNETFOLDER_PARSE_ONLY_URLMON_BINDABLE L\"Validate URL\"")]
        public const string STR_INTERNETFOLDER_PARSE_ONLY_URLMON_BINDABLE = "Validate URL";

        [NativeTypeName("#define BIND_INTERRUPTABLE 0xFFFFFFFF")]
        public const uint BIND_INTERRUPTABLE = 0xFFFFFFFF;

        [NativeTypeName("#define STR_BIND_FOLDERS_READ_ONLY L\"Folders As Read Only\"")]
        public const string STR_BIND_FOLDERS_READ_ONLY = "Folders As Read Only";

        [NativeTypeName("#define STR_BIND_FOLDER_ENUM_MODE L\"Folder Enum Mode\"")]
        public const string STR_BIND_FOLDER_ENUM_MODE = "Folder Enum Mode";

        [NativeTypeName("#define STR_PARSE_WITH_EXPLICIT_PROGID L\"ExplicitProgid\"")]
        public const string STR_PARSE_WITH_EXPLICIT_PROGID = "ExplicitProgid";

        [NativeTypeName("#define STR_PARSE_WITH_EXPLICIT_ASSOCAPP L\"ExplicitAssociationApp\"")]
        public const string STR_PARSE_WITH_EXPLICIT_ASSOCAPP = "ExplicitAssociationApp";

        [NativeTypeName("#define STR_PARSE_EXPLICIT_ASSOCIATION_SUCCESSFUL L\"ExplicitAssociationSuccessful\"")]
        public const string STR_PARSE_EXPLICIT_ASSOCIATION_SUCCESSFUL = "ExplicitAssociationSuccessful";

        [NativeTypeName("#define STR_PARSE_AND_CREATE_ITEM L\"ParseAndCreateItem\"")]
        public const string STR_PARSE_AND_CREATE_ITEM = "ParseAndCreateItem";

        [NativeTypeName("#define STR_PROPERTYBAG_PARAM L\"SHBindCtxPropertyBag\"")]
        public const string STR_PROPERTYBAG_PARAM = "SHBindCtxPropertyBag";

        [NativeTypeName("#define STR_ENUM_ITEMS_FLAGS L\"SHCONTF\"")]
        public const string STR_ENUM_ITEMS_FLAGS = "SHCONTF";

        [NativeTypeName("#define STR_STORAGEITEM_CREATION_FLAGS L\"SHGETSTORAGEITEM\"")]
        public const string STR_STORAGEITEM_CREATION_FLAGS = "SHGETSTORAGEITEM";

        [NativeTypeName("#define STR_ITEM_CACHE_CONTEXT L\"ItemCacheContext\"")]
        public const string STR_ITEM_CACHE_CONTEXT = "ItemCacheContext";

        [NativeTypeName("#define SVSI_NOSTATECHANGE ((UINT)0x80000000)")]
        public const uint SVSI_NOSTATECHANGE = ((uint)(0x80000000));

        [NativeTypeName("#define SV2GV_CURRENTVIEW ((UINT)-1)")]
        public const uint SV2GV_CURRENTVIEW = unchecked((uint)(-1));

        [NativeTypeName("#define SV2GV_DEFAULTVIEW ((UINT)-2)")]
        public const uint SV2GV_DEFAULTVIEW = unchecked((uint)(-2));

        [NativeTypeName("#define SID_SFolderView IID_IFolderView")]
        public static readonly Guid SID_SFolderView = IID_IFolderView;

        [NativeTypeName("#define CDBOSC_SETFOCUS 0x00000000")]
        public const int CDBOSC_SETFOCUS = 0x00000000;

        [NativeTypeName("#define CDBOSC_KILLFOCUS 0x00000001")]
        public const int CDBOSC_KILLFOCUS = 0x00000001;

        [NativeTypeName("#define CDBOSC_SELCHANGE 0x00000002")]
        public const int CDBOSC_SELCHANGE = 0x00000002;

        [NativeTypeName("#define CDBOSC_RENAME 0x00000003")]
        public const int CDBOSC_RENAME = 0x00000003;

        [NativeTypeName("#define CDBOSC_STATECHANGE 0x00000004")]
        public const int CDBOSC_STATECHANGE = 0x00000004;

        [NativeTypeName("#define SID_SExplorerBrowserFrame IID_ICommDlgBrowser")]
        public static readonly Guid SID_SExplorerBrowserFrame = IID_ICommDlgBrowser;

        [NativeTypeName("#define CDB2N_CONTEXTMENU_DONE 0x00000001")]
        public const int CDB2N_CONTEXTMENU_DONE = 0x00000001;

        [NativeTypeName("#define CDB2N_CONTEXTMENU_START 0x00000002")]
        public const int CDB2N_CONTEXTMENU_START = 0x00000002;

        [NativeTypeName("#define CDB2GVF_SHOWALLFILES 0x00000001")]
        public const int CDB2GVF_SHOWALLFILES = 0x00000001;

        [NativeTypeName("#define CDB2GVF_ISFILESAVE 0x00000002")]
        public const int CDB2GVF_ISFILESAVE = 0x00000002;

        [NativeTypeName("#define CDB2GVF_ALLOWPREVIEWPANE 0x00000004")]
        public const int CDB2GVF_ALLOWPREVIEWPANE = 0x00000004;

        [NativeTypeName("#define CDB2GVF_NOSELECTVERB 0x00000008")]
        public const int CDB2GVF_NOSELECTVERB = 0x00000008;

        [NativeTypeName("#define CDB2GVF_NOINCLUDEITEM 0x00000010")]
        public const int CDB2GVF_NOINCLUDEITEM = 0x00000010;

        [NativeTypeName("#define CDB2GVF_ISFOLDERPICKER 0x00000020")]
        public const int CDB2GVF_ISFOLDERPICKER = 0x00000020;

        [NativeTypeName("#define CDB2GVF_ADDSHIELD 0x00000040")]
        public const int CDB2GVF_ADDSHIELD = 0x00000040;

        [NativeTypeName("#define SBSP_DEFBROWSER 0x0000")]
        public const int SBSP_DEFBROWSER = 0x0000;

        [NativeTypeName("#define SBSP_SAMEBROWSER 0x0001")]
        public const int SBSP_SAMEBROWSER = 0x0001;

        [NativeTypeName("#define SBSP_NEWBROWSER 0x0002")]
        public const int SBSP_NEWBROWSER = 0x0002;

        [NativeTypeName("#define SBSP_DEFMODE 0x0000")]
        public const int SBSP_DEFMODE = 0x0000;

        [NativeTypeName("#define SBSP_OPENMODE 0x0010")]
        public const int SBSP_OPENMODE = 0x0010;

        [NativeTypeName("#define SBSP_EXPLOREMODE 0x0020")]
        public const int SBSP_EXPLOREMODE = 0x0020;

        [NativeTypeName("#define SBSP_HELPMODE 0x0040")]
        public const int SBSP_HELPMODE = 0x0040;

        [NativeTypeName("#define SBSP_NOTRANSFERHIST 0x0080")]
        public const int SBSP_NOTRANSFERHIST = 0x0080;

        [NativeTypeName("#define SBSP_ABSOLUTE 0x0000")]
        public const int SBSP_ABSOLUTE = 0x0000;

        [NativeTypeName("#define SBSP_RELATIVE 0x1000")]
        public const int SBSP_RELATIVE = 0x1000;

        [NativeTypeName("#define SBSP_PARENT 0x2000")]
        public const int SBSP_PARENT = 0x2000;

        [NativeTypeName("#define SBSP_NAVIGATEBACK 0x4000")]
        public const int SBSP_NAVIGATEBACK = 0x4000;

        [NativeTypeName("#define SBSP_NAVIGATEFORWARD 0x8000")]
        public const int SBSP_NAVIGATEFORWARD = 0x8000;

        [NativeTypeName("#define SBSP_ALLOW_AUTONAVIGATE 0x00010000")]
        public const int SBSP_ALLOW_AUTONAVIGATE = 0x00010000;

        [NativeTypeName("#define SBSP_KEEPSAMETEMPLATE 0x00020000")]
        public const int SBSP_KEEPSAMETEMPLATE = 0x00020000;

        [NativeTypeName("#define SBSP_KEEPWORDWHEELTEXT 0x00040000")]
        public const int SBSP_KEEPWORDWHEELTEXT = 0x00040000;

        [NativeTypeName("#define SBSP_ACTIVATE_NOFOCUS 0x00080000")]
        public const int SBSP_ACTIVATE_NOFOCUS = 0x00080000;

        [NativeTypeName("#define SBSP_CREATENOHISTORY 0x00100000")]
        public const int SBSP_CREATENOHISTORY = 0x00100000;

        [NativeTypeName("#define SBSP_PLAYNOSOUND 0x00200000")]
        public const int SBSP_PLAYNOSOUND = 0x00200000;

        [NativeTypeName("#define SBSP_CALLERUNTRUSTED 0x00800000")]
        public const int SBSP_CALLERUNTRUSTED = 0x00800000;

        [NativeTypeName("#define SBSP_TRUSTFIRSTDOWNLOAD 0x01000000")]
        public const int SBSP_TRUSTFIRSTDOWNLOAD = 0x01000000;

        [NativeTypeName("#define SBSP_UNTRUSTEDFORDOWNLOAD 0x02000000")]
        public const int SBSP_UNTRUSTEDFORDOWNLOAD = 0x02000000;

        [NativeTypeName("#define SBSP_NOAUTOSELECT 0x04000000")]
        public const int SBSP_NOAUTOSELECT = 0x04000000;

        [NativeTypeName("#define SBSP_WRITENOHISTORY 0x08000000")]
        public const int SBSP_WRITENOHISTORY = 0x08000000;

        [NativeTypeName("#define SBSP_TRUSTEDFORACTIVEX 0x10000000")]
        public const int SBSP_TRUSTEDFORACTIVEX = 0x10000000;

        [NativeTypeName("#define SBSP_FEEDNAVIGATION 0x20000000")]
        public const int SBSP_FEEDNAVIGATION = 0x20000000;

        [NativeTypeName("#define SBSP_REDIRECT 0x40000000")]
        public const int SBSP_REDIRECT = 0x40000000;

        [NativeTypeName("#define SBSP_INITIATEDBYHLINKFRAME 0x80000000")]
        public const uint SBSP_INITIATEDBYHLINKFRAME = 0x80000000;

        [NativeTypeName("#define FCW_STATUS 0x0001")]
        public const int FCW_STATUS = 0x0001;

        [NativeTypeName("#define FCW_TOOLBAR 0x0002")]
        public const int FCW_TOOLBAR = 0x0002;

        [NativeTypeName("#define FCW_TREE 0x0003")]
        public const int FCW_TREE = 0x0003;

        [NativeTypeName("#define FCW_INTERNETBAR 0x0006")]
        public const int FCW_INTERNETBAR = 0x0006;

        [NativeTypeName("#define FCW_PROGRESS 0x0008")]
        public const int FCW_PROGRESS = 0x0008;

        [NativeTypeName("#define FCT_MERGE 0x0001")]
        public const int FCT_MERGE = 0x0001;

        [NativeTypeName("#define FCT_CONFIGABLE 0x0002")]
        public const int FCT_CONFIGABLE = 0x0002;

        [NativeTypeName("#define FCT_ADDTOEND 0x0004")]
        public const int FCT_ADDTOEND = 0x0004;

        [NativeTypeName("#define SID_SProfferService IID_IProfferService")]
        public static readonly Guid SID_SProfferService = IID_IProfferService;

        [NativeTypeName("#define STR_DONT_RESOLVE_LINK L\"Don't Resolve Link\"")]
        public const string STR_DONT_RESOLVE_LINK = "Don't Resolve Link";

        [NativeTypeName("#define STR_GET_ASYNC_HANDLER L\"GetAsyncHandler\"")]
        public const string STR_GET_ASYNC_HANDLER = "GetAsyncHandler";

        [NativeTypeName("#define STR_GPS_HANDLERPROPERTIESONLY L\"GPS_HANDLERPROPERTIESONLY\"")]
        public const string STR_GPS_HANDLERPROPERTIESONLY = "GPS_HANDLERPROPERTIESONLY";

        [NativeTypeName("#define STR_GPS_FASTPROPERTIESONLY L\"GPS_FASTPROPERTIESONLY\"")]
        public const string STR_GPS_FASTPROPERTIESONLY = "GPS_FASTPROPERTIESONLY";

        [NativeTypeName("#define STR_GPS_OPENSLOWITEM L\"GPS_OPENSLOWITEM\"")]
        public const string STR_GPS_OPENSLOWITEM = "GPS_OPENSLOWITEM";

        [NativeTypeName("#define STR_GPS_DELAYCREATION L\"GPS_DELAYCREATION\"")]
        public const string STR_GPS_DELAYCREATION = "GPS_DELAYCREATION";

        [NativeTypeName("#define STR_GPS_BESTEFFORT L\"GPS_BESTEFFORT\"")]
        public const string STR_GPS_BESTEFFORT = "GPS_BESTEFFORT";

        [NativeTypeName("#define STR_GPS_NO_OPLOCK L\"GPS_NO_OPLOCK\"")]
        public const string STR_GPS_NO_OPLOCK = "GPS_NO_OPLOCK";

        [NativeTypeName("#define DI_GETDRAGIMAGE TEXT(\"ShellGetDragImage\")")]
        public const string DI_GETDRAGIMAGE = "ShellGetDragImage";

        [NativeTypeName("#define ARCONTENT_AUTORUNINF 0x00000002")]
        public const int ARCONTENT_AUTORUNINF = 0x00000002;

        [NativeTypeName("#define ARCONTENT_AUDIOCD 0x00000004")]
        public const int ARCONTENT_AUDIOCD = 0x00000004;

        [NativeTypeName("#define ARCONTENT_DVDMOVIE 0x00000008")]
        public const int ARCONTENT_DVDMOVIE = 0x00000008;

        [NativeTypeName("#define ARCONTENT_BLANKCD 0x00000010")]
        public const int ARCONTENT_BLANKCD = 0x00000010;

        [NativeTypeName("#define ARCONTENT_BLANKDVD 0x00000020")]
        public const int ARCONTENT_BLANKDVD = 0x00000020;

        [NativeTypeName("#define ARCONTENT_UNKNOWNCONTENT 0x00000040")]
        public const int ARCONTENT_UNKNOWNCONTENT = 0x00000040;

        [NativeTypeName("#define ARCONTENT_AUTOPLAYPIX 0x00000080")]
        public const int ARCONTENT_AUTOPLAYPIX = 0x00000080;

        [NativeTypeName("#define ARCONTENT_AUTOPLAYMUSIC 0x00000100")]
        public const int ARCONTENT_AUTOPLAYMUSIC = 0x00000100;

        [NativeTypeName("#define ARCONTENT_AUTOPLAYVIDEO 0x00000200")]
        public const int ARCONTENT_AUTOPLAYVIDEO = 0x00000200;

        [NativeTypeName("#define ARCONTENT_VCD 0x00000400")]
        public const int ARCONTENT_VCD = 0x00000400;

        [NativeTypeName("#define ARCONTENT_SVCD 0x00000800")]
        public const int ARCONTENT_SVCD = 0x00000800;

        [NativeTypeName("#define ARCONTENT_DVDAUDIO 0x00001000")]
        public const int ARCONTENT_DVDAUDIO = 0x00001000;

        [NativeTypeName("#define ARCONTENT_BLANKBD 0x00002000")]
        public const int ARCONTENT_BLANKBD = 0x00002000;

        [NativeTypeName("#define ARCONTENT_BLURAY 0x00004000")]
        public const int ARCONTENT_BLURAY = 0x00004000;

        [NativeTypeName("#define ARCONTENT_CAMERASTORAGE 0x00008000")]
        public const int ARCONTENT_CAMERASTORAGE = 0x00008000;

        [NativeTypeName("#define ARCONTENT_CUSTOMEVENT 0x00010000")]
        public const int ARCONTENT_CUSTOMEVENT = 0x00010000;

        [NativeTypeName("#define ARCONTENT_NONE 0x00000000")]
        public const int ARCONTENT_NONE = 0x00000000;

        [NativeTypeName("#define ARCONTENT_MASK 0x0001FFFE")]
        public const int ARCONTENT_MASK = 0x0001FFFE;

        [NativeTypeName("#define ARCONTENT_PHASE_UNKNOWN 0x00000000")]
        public const int ARCONTENT_PHASE_UNKNOWN = 0x00000000;

        [NativeTypeName("#define ARCONTENT_PHASE_PRESNIFF 0x10000000")]
        public const int ARCONTENT_PHASE_PRESNIFF = 0x10000000;

        [NativeTypeName("#define ARCONTENT_PHASE_SNIFFING 0x20000000")]
        public const int ARCONTENT_PHASE_SNIFFING = 0x20000000;

        [NativeTypeName("#define ARCONTENT_PHASE_FINAL 0x40000000")]
        public const int ARCONTENT_PHASE_FINAL = 0x40000000;

        [NativeTypeName("#define ARCONTENT_PHASE_MASK 0x70000000")]
        public const int ARCONTENT_PHASE_MASK = 0x70000000;

        [NativeTypeName("#define IEI_PRIORITY_MAX ITSAT_MAX_PRIORITY")]
        public const int IEI_PRIORITY_MAX = 0x7fffffff;

        [NativeTypeName("#define IEI_PRIORITY_MIN ITSAT_MIN_PRIORITY")]
        public const int IEI_PRIORITY_MIN = 0x00000000;

        [NativeTypeName("#define IEIT_PRIORITY_NORMAL ITSAT_DEFAULT_PRIORITY")]
        public const int IEIT_PRIORITY_NORMAL = 0x10000000;

        [NativeTypeName("#define IEIFLAG_ASYNC 0x0001")]
        public const int IEIFLAG_ASYNC = 0x0001;

        [NativeTypeName("#define IEIFLAG_CACHE 0x0002")]
        public const int IEIFLAG_CACHE = 0x0002;

        [NativeTypeName("#define IEIFLAG_ASPECT 0x0004")]
        public const int IEIFLAG_ASPECT = 0x0004;

        [NativeTypeName("#define IEIFLAG_OFFLINE 0x0008")]
        public const int IEIFLAG_OFFLINE = 0x0008;

        [NativeTypeName("#define IEIFLAG_GLEAM 0x0010")]
        public const int IEIFLAG_GLEAM = 0x0010;

        [NativeTypeName("#define IEIFLAG_SCREEN 0x0020")]
        public const int IEIFLAG_SCREEN = 0x0020;

        [NativeTypeName("#define IEIFLAG_ORIGSIZE 0x0040")]
        public const int IEIFLAG_ORIGSIZE = 0x0040;

        [NativeTypeName("#define IEIFLAG_NOSTAMP 0x0080")]
        public const int IEIFLAG_NOSTAMP = 0x0080;

        [NativeTypeName("#define IEIFLAG_NOBORDER 0x0100")]
        public const int IEIFLAG_NOBORDER = 0x0100;

        [NativeTypeName("#define IEIFLAG_QUALITY 0x0200")]
        public const int IEIFLAG_QUALITY = 0x0200;

        [NativeTypeName("#define IEIFLAG_REFRESH 0x0400")]
        public const int IEIFLAG_REFRESH = 0x0400;

        [NativeTypeName("#define DBIM_MINSIZE 0x0001")]
        public const int DBIM_MINSIZE = 0x0001;

        [NativeTypeName("#define DBIM_MAXSIZE 0x0002")]
        public const int DBIM_MAXSIZE = 0x0002;

        [NativeTypeName("#define DBIM_INTEGRAL 0x0004")]
        public const int DBIM_INTEGRAL = 0x0004;

        [NativeTypeName("#define DBIM_ACTUAL 0x0008")]
        public const int DBIM_ACTUAL = 0x0008;

        [NativeTypeName("#define DBIM_TITLE 0x0010")]
        public const int DBIM_TITLE = 0x0010;

        [NativeTypeName("#define DBIM_MODEFLAGS 0x0020")]
        public const int DBIM_MODEFLAGS = 0x0020;

        [NativeTypeName("#define DBIM_BKCOLOR 0x0040")]
        public const int DBIM_BKCOLOR = 0x0040;

        [NativeTypeName("#define DBIMF_NORMAL 0x0000")]
        public const int DBIMF_NORMAL = 0x0000;

        [NativeTypeName("#define DBIMF_FIXED 0x0001")]
        public const int DBIMF_FIXED = 0x0001;

        [NativeTypeName("#define DBIMF_FIXEDBMP 0x0004")]
        public const int DBIMF_FIXEDBMP = 0x0004;

        [NativeTypeName("#define DBIMF_VARIABLEHEIGHT 0x0008")]
        public const int DBIMF_VARIABLEHEIGHT = 0x0008;

        [NativeTypeName("#define DBIMF_UNDELETEABLE 0x0010")]
        public const int DBIMF_UNDELETEABLE = 0x0010;

        [NativeTypeName("#define DBIMF_DEBOSSED 0x0020")]
        public const int DBIMF_DEBOSSED = 0x0020;

        [NativeTypeName("#define DBIMF_BKCOLOR 0x0040")]
        public const int DBIMF_BKCOLOR = 0x0040;

        [NativeTypeName("#define DBIMF_USECHEVRON 0x0080")]
        public const int DBIMF_USECHEVRON = 0x0080;

        [NativeTypeName("#define DBIMF_BREAK 0x0100")]
        public const int DBIMF_BREAK = 0x0100;

        [NativeTypeName("#define DBIMF_ADDTOFRONT 0x0200")]
        public const int DBIMF_ADDTOFRONT = 0x0200;

        [NativeTypeName("#define DBIMF_TOPALIGN 0x0400")]
        public const int DBIMF_TOPALIGN = 0x0400;

        [NativeTypeName("#define DBIMF_NOGRIPPER 0x0800")]
        public const int DBIMF_NOGRIPPER = 0x0800;

        [NativeTypeName("#define DBIMF_ALWAYSGRIPPER 0x1000")]
        public const int DBIMF_ALWAYSGRIPPER = 0x1000;

        [NativeTypeName("#define DBIMF_NOMARGINS 0x2000")]
        public const int DBIMF_NOMARGINS = 0x2000;

        [NativeTypeName("#define DBIF_VIEWMODE_NORMAL 0x0000")]
        public const int DBIF_VIEWMODE_NORMAL = 0x0000;

        [NativeTypeName("#define DBIF_VIEWMODE_VERTICAL 0x0001")]
        public const int DBIF_VIEWMODE_VERTICAL = 0x0001;

        [NativeTypeName("#define DBIF_VIEWMODE_FLOATING 0x0002")]
        public const int DBIF_VIEWMODE_FLOATING = 0x0002;

        [NativeTypeName("#define DBIF_VIEWMODE_TRANSPARENT 0x0004")]
        public const int DBIF_VIEWMODE_TRANSPARENT = 0x0004;

        [NativeTypeName("#define DBPC_SELECTFIRST (DWORD)-1")]
        public const uint DBPC_SELECTFIRST = unchecked((uint)(-1));

        [NativeTypeName("#define DBPC_SELECTLAST (DWORD)-2")]
        public const uint DBPC_SELECTLAST = unchecked((uint)(-2));

        [NativeTypeName("#define CGID_DeskBand IID_IDeskBand")]
        public static readonly Guid CGID_DeskBand = IID_IDeskBand;

        [NativeTypeName("#define THBN_CLICKED 0x1800")]
        public const int THBN_CLICKED = 0x1800;

        [NativeTypeName("#define FOFX_NOSKIPJUNCTIONS 0x00010000")]
        public const int FOFX_NOSKIPJUNCTIONS = 0x00010000;

        [NativeTypeName("#define FOFX_PREFERHARDLINK 0x00020000")]
        public const int FOFX_PREFERHARDLINK = 0x00020000;

        [NativeTypeName("#define FOFX_SHOWELEVATIONPROMPT 0x00040000")]
        public const int FOFX_SHOWELEVATIONPROMPT = 0x00040000;

        [NativeTypeName("#define FOFX_RECYCLEONDELETE 0x00080000")]
        public const int FOFX_RECYCLEONDELETE = 0x00080000;

        [NativeTypeName("#define FOFX_EARLYFAILURE 0x00100000")]
        public const int FOFX_EARLYFAILURE = 0x00100000;

        [NativeTypeName("#define FOFX_PRESERVEFILEEXTENSIONS 0x00200000")]
        public const int FOFX_PRESERVEFILEEXTENSIONS = 0x00200000;

        [NativeTypeName("#define FOFX_KEEPNEWERFILE 0x00400000")]
        public const int FOFX_KEEPNEWERFILE = 0x00400000;

        [NativeTypeName("#define FOFX_NOCOPYHOOKS 0x00800000")]
        public const int FOFX_NOCOPYHOOKS = 0x00800000;

        [NativeTypeName("#define FOFX_NOMINIMIZEBOX 0x01000000")]
        public const int FOFX_NOMINIMIZEBOX = 0x01000000;

        [NativeTypeName("#define FOFX_MOVEACLSACROSSVOLUMES 0x02000000")]
        public const int FOFX_MOVEACLSACROSSVOLUMES = 0x02000000;

        [NativeTypeName("#define FOFX_DONTDISPLAYSOURCEPATH 0x04000000")]
        public const int FOFX_DONTDISPLAYSOURCEPATH = 0x04000000;

        [NativeTypeName("#define FOFX_DONTDISPLAYDESTPATH 0x08000000")]
        public const int FOFX_DONTDISPLAYDESTPATH = 0x08000000;

        [NativeTypeName("#define FOFX_REQUIREELEVATION 0x10000000")]
        public const int FOFX_REQUIREELEVATION = 0x10000000;

        [NativeTypeName("#define FOFX_ADDUNDORECORD 0x20000000")]
        public const int FOFX_ADDUNDORECORD = 0x20000000;

        [NativeTypeName("#define FOFX_COPYASDOWNLOAD 0x40000000")]
        public const int FOFX_COPYASDOWNLOAD = 0x40000000;

        [NativeTypeName("#define FOFX_DONTDISPLAYLOCATIONS 0x80000000")]
        public const uint FOFX_DONTDISPLAYLOCATIONS = 0x80000000;

        [NativeTypeName("#define FreeIDListArrayFull FreeIDListArray")]
        public static readonly delegate*<ITEMIDLIST**, uint, void> FreeIDListArrayFull = &FreeIDListArray;

        [NativeTypeName("#define FreeIDListArrayChild FreeIDListArray")]
        public static readonly delegate*<ITEMIDLIST**, uint, void> FreeIDListArrayChild = &FreeIDListArray;

        [NativeTypeName("#define BSIM_STATE 0x00000001")]
        public const int BSIM_STATE = 0x00000001;

        [NativeTypeName("#define BSIM_STYLE 0x00000002")]
        public const int BSIM_STYLE = 0x00000002;

        [NativeTypeName("#define BSSF_VISIBLE 0x00000001")]
        public const int BSSF_VISIBLE = 0x00000001;

        [NativeTypeName("#define BSSF_NOTITLE 0x00000002")]
        public const int BSSF_NOTITLE = 0x00000002;

        [NativeTypeName("#define BSSF_UNDELETEABLE 0x00001000")]
        public const int BSSF_UNDELETEABLE = 0x00001000;

        [NativeTypeName("#define BSIS_AUTOGRIPPER 0x00000000")]
        public const int BSIS_AUTOGRIPPER = 0x00000000;

        [NativeTypeName("#define BSIS_NOGRIPPER 0x00000001")]
        public const int BSIS_NOGRIPPER = 0x00000001;

        [NativeTypeName("#define BSIS_ALWAYSGRIPPER 0x00000002")]
        public const int BSIS_ALWAYSGRIPPER = 0x00000002;

        [NativeTypeName("#define BSIS_LEFTALIGN 0x00000004")]
        public const int BSIS_LEFTALIGN = 0x00000004;

        [NativeTypeName("#define BSIS_SINGLECLICK 0x00000008")]
        public const int BSIS_SINGLECLICK = 0x00000008;

        [NativeTypeName("#define BSIS_NOCONTEXTMENU 0x00000010")]
        public const int BSIS_NOCONTEXTMENU = 0x00000010;

        [NativeTypeName("#define BSIS_NODROPTARGET 0x00000020")]
        public const int BSIS_NODROPTARGET = 0x00000020;

        [NativeTypeName("#define BSIS_NOCAPTION 0x00000040")]
        public const int BSIS_NOCAPTION = 0x00000040;

        [NativeTypeName("#define BSIS_PREFERNOLINEBREAK 0x00000080")]
        public const int BSIS_PREFERNOLINEBREAK = 0x00000080;

        [NativeTypeName("#define BSIS_LOCKED 0x00000100")]
        public const int BSIS_LOCKED = 0x00000100;

        [NativeTypeName("#define BSIS_PRESERVEORDERDURINGLAYOUT 0x00000200")]
        public const int BSIS_PRESERVEORDERDURINGLAYOUT = 0x00000200;

        [NativeTypeName("#define BSIS_FIXEDORDER 0x00000400")]
        public const int BSIS_FIXEDORDER = 0x00000400;

        [NativeTypeName("#define SID_SBandSite IID_IBandSite")]
        public static readonly Guid SID_SBandSite = IID_IBandSite;

        [NativeTypeName("#define CGID_BandSite IID_IBandSite")]
        public static readonly Guid CGID_BandSite = IID_IBandSite;

        [NativeTypeName("#define OF_CAP_CANSWITCHTO 0x0001")]
        public const int OF_CAP_CANSWITCHTO = 0x0001;

        [NativeTypeName("#define OF_CAP_CANCLOSE 0x0002")]
        public const int OF_CAP_CANCLOSE = 0x0002;

        [NativeTypeName("#define SID_SNewWindowManager IID_INewWindowManager")]
        public static readonly Guid SID_SNewWindowManager = IID_INewWindowManager;

        [NativeTypeName("#define SMDM_SHELLFOLDER 0x00000001")]
        public const int SMDM_SHELLFOLDER = 0x00000001;

        [NativeTypeName("#define SMDM_HMENU 0x00000002")]
        public const int SMDM_HMENU = 0x00000002;

        [NativeTypeName("#define SMDM_TOOLBAR 0x00000004")]
        public const int SMDM_TOOLBAR = 0x00000004;

        [NativeTypeName("#define SMC_INITMENU 0x00000001")]
        public const int SMC_INITMENU = 0x00000001;

        [NativeTypeName("#define SMC_CREATE 0x00000002")]
        public const int SMC_CREATE = 0x00000002;

        [NativeTypeName("#define SMC_EXITMENU 0x00000003")]
        public const int SMC_EXITMENU = 0x00000003;

        [NativeTypeName("#define SMC_GETINFO 0x00000005")]
        public const int SMC_GETINFO = 0x00000005;

        [NativeTypeName("#define SMC_GETSFINFO 0x00000006")]
        public const int SMC_GETSFINFO = 0x00000006;

        [NativeTypeName("#define SMC_GETOBJECT 0x00000007")]
        public const int SMC_GETOBJECT = 0x00000007;

        [NativeTypeName("#define SMC_GETSFOBJECT 0x00000008")]
        public const int SMC_GETSFOBJECT = 0x00000008;

        [NativeTypeName("#define SMC_SFEXEC 0x00000009")]
        public const int SMC_SFEXEC = 0x00000009;

        [NativeTypeName("#define SMC_SFSELECTITEM 0x0000000A")]
        public const int SMC_SFSELECTITEM = 0x0000000A;

        [NativeTypeName("#define SMC_REFRESH 0x00000010")]
        public const int SMC_REFRESH = 0x00000010;

        [NativeTypeName("#define SMC_DEMOTE 0x00000011")]
        public const int SMC_DEMOTE = 0x00000011;

        [NativeTypeName("#define SMC_PROMOTE 0x00000012")]
        public const int SMC_PROMOTE = 0x00000012;

        [NativeTypeName("#define SMC_DEFAULTICON 0x00000016")]
        public const int SMC_DEFAULTICON = 0x00000016;

        [NativeTypeName("#define SMC_NEWITEM 0x00000017")]
        public const int SMC_NEWITEM = 0x00000017;

        [NativeTypeName("#define SMC_CHEVRONEXPAND 0x00000019")]
        public const int SMC_CHEVRONEXPAND = 0x00000019;

        [NativeTypeName("#define SMC_DISPLAYCHEVRONTIP 0x0000002A")]
        public const int SMC_DISPLAYCHEVRONTIP = 0x0000002A;

        [NativeTypeName("#define SMC_SETSFOBJECT 0x0000002D")]
        public const int SMC_SETSFOBJECT = 0x0000002D;

        [NativeTypeName("#define SMC_SHCHANGENOTIFY 0x0000002E")]
        public const int SMC_SHCHANGENOTIFY = 0x0000002E;

        [NativeTypeName("#define SMC_CHEVRONGETTIP 0x0000002F")]
        public const int SMC_CHEVRONGETTIP = 0x0000002F;

        [NativeTypeName("#define SMC_SFDDRESTRICTED 0x00000030")]
        public const int SMC_SFDDRESTRICTED = 0x00000030;

        [NativeTypeName("#define SMC_SFEXEC_MIDDLE 0x00000031")]
        public const int SMC_SFEXEC_MIDDLE = 0x00000031;

        [NativeTypeName("#define SMC_GETAUTOEXPANDSTATE 0x00000041")]
        public const int SMC_GETAUTOEXPANDSTATE = 0x00000041;

        [NativeTypeName("#define SMC_AUTOEXPANDCHANGE 0x00000042")]
        public const int SMC_AUTOEXPANDCHANGE = 0x00000042;

        [NativeTypeName("#define SMC_GETCONTEXTMENUMODIFIER 0x00000043")]
        public const int SMC_GETCONTEXTMENUMODIFIER = 0x00000043;

        [NativeTypeName("#define SMC_GETBKCONTEXTMENU 0x00000044")]
        public const int SMC_GETBKCONTEXTMENU = 0x00000044;

        [NativeTypeName("#define SMC_OPEN 0x00000045")]
        public const int SMC_OPEN = 0x00000045;

        [NativeTypeName("#define SMAE_EXPANDED 0x00000001")]
        public const int SMAE_EXPANDED = 0x00000001;

        [NativeTypeName("#define SMAE_CONTRACTED 0x00000002")]
        public const int SMAE_CONTRACTED = 0x00000002;

        [NativeTypeName("#define SMAE_USER 0x00000004")]
        public const int SMAE_USER = 0x00000004;

        [NativeTypeName("#define SMAE_VALID 0x00000007")]
        public const int SMAE_VALID = 0x00000007;

        [NativeTypeName("#define SMINIT_DEFAULT 0x00000000")]
        public const int SMINIT_DEFAULT = 0x00000000;

        [NativeTypeName("#define SMINIT_RESTRICT_DRAGDROP 0x00000002")]
        public const int SMINIT_RESTRICT_DRAGDROP = 0x00000002;

        [NativeTypeName("#define SMINIT_TOPLEVEL 0x00000004")]
        public const int SMINIT_TOPLEVEL = 0x00000004;

        [NativeTypeName("#define SMINIT_CACHED 0x00000010")]
        public const int SMINIT_CACHED = 0x00000010;

        [NativeTypeName("#define SMINIT_AUTOEXPAND 0x00000100")]
        public const int SMINIT_AUTOEXPAND = 0x00000100;

        [NativeTypeName("#define SMINIT_AUTOTOOLTIP 0x00000200")]
        public const int SMINIT_AUTOTOOLTIP = 0x00000200;

        [NativeTypeName("#define SMINIT_DROPONCONTAINER 0x00000400")]
        public const int SMINIT_DROPONCONTAINER = 0x00000400;

        [NativeTypeName("#define SMINIT_VERTICAL 0x10000000")]
        public const int SMINIT_VERTICAL = 0x10000000;

        [NativeTypeName("#define SMINIT_HORIZONTAL 0x20000000")]
        public const int SMINIT_HORIZONTAL = 0x20000000;

        [NativeTypeName("#define ANCESTORDEFAULT (UINT)-1")]
        public const uint ANCESTORDEFAULT = unchecked((uint)(-1));

        [NativeTypeName("#define SMSET_TOP 0x10000000")]
        public const int SMSET_TOP = 0x10000000;

        [NativeTypeName("#define SMSET_BOTTOM 0x20000000")]
        public const int SMSET_BOTTOM = 0x20000000;

        [NativeTypeName("#define SMSET_DONTOWN 0x00000001")]
        public const int SMSET_DONTOWN = 0x00000001;

        [NativeTypeName("#define SMINV_REFRESH 0x00000001")]
        public const int SMINV_REFRESH = 0x00000001;

        [NativeTypeName("#define SMINV_ID 0x00000008")]
        public const int SMINV_ID = 0x00000008;

        [NativeTypeName("#define SID_ExecuteCreatingProcess __uuidof(ICreatingProcess)")]
        public static readonly Guid SID_ExecuteCreatingProcess = typeof(ICreatingProcess).GUID;

        [NativeTypeName("#define SID_LaunchUIContextProvider __uuidof(ILaunchUIContextProvider)")]
        public static readonly Guid SID_LaunchUIContextProvider = typeof(ILaunchUIContextProvider).GUID;

        [NativeTypeName("#define SID_SNewMenuClient IID_INewMenuClient")]
        public static readonly Guid SID_SNewMenuClient = IID_INewMenuClient;

        [NativeTypeName("#define SID_SNavigationPane IID_INameSpaceTreeControl")]
        public static readonly Guid SID_SNavigationPane = IID_INameSpaceTreeControl;

        [NativeTypeName("#define E_PREVIEWHANDLER_DRM_FAIL _HRESULT_TYPEDEF_(0x86420001L)")]
        public const int E_PREVIEWHANDLER_DRM_FAIL = unchecked((int)(0x86420001));

        [NativeTypeName("#define E_PREVIEWHANDLER_NOAUTH _HRESULT_TYPEDEF_(0x86420002L)")]
        public const int E_PREVIEWHANDLER_NOAUTH = unchecked((int)(0x86420002));

        [NativeTypeName("#define E_PREVIEWHANDLER_NOTFOUND _HRESULT_TYPEDEF_(0x86420003L)")]
        public const int E_PREVIEWHANDLER_NOTFOUND = unchecked((int)(0x86420003));

        [NativeTypeName("#define E_PREVIEWHANDLER_CORRUPT _HRESULT_TYPEDEF_(0x86420004L)")]
        public const int E_PREVIEWHANDLER_CORRUPT = unchecked((int)(0x86420004));

        [NativeTypeName("#define SID_ExplorerPaneVisibility IID_IExplorerPaneVisibility")]
        public static readonly Guid SID_ExplorerPaneVisibility = IID_IExplorerPaneVisibility;

        [NativeTypeName("#define STR_FILE_SYS_BIND_DATA L\"File System Bind Data\"")]
        public const string STR_FILE_SYS_BIND_DATA = "File System Bind Data";

        [NativeTypeName("#define STR_FILE_SYS_BIND_DATA_WIN7_FORMAT L\"Win7FileSystemIdList\"")]
        public const string STR_FILE_SYS_BIND_DATA_WIN7_FORMAT = "Win7FileSystemIdList";

        [NativeTypeName("#define HOMEGROUP_SECURITY_GROUP_MULTI L\"HUG\"")]
        public const string HOMEGROUP_SECURITY_GROUP_MULTI = "HUG";

        [NativeTypeName("#define HOMEGROUP_SECURITY_GROUP L\"HomeUsers\"")]
        public const string HOMEGROUP_SECURITY_GROUP = "HomeUsers";

        [NativeTypeName("#define PROP_CONTRACT_DELEGATE L\"ContractDelegate\"")]
        public const string PROP_CONTRACT_DELEGATE = "ContractDelegate";

        [NativeTypeName("#define SID_ExecuteCommandHost IID_IExecuteCommandHost")]
        public static readonly Guid SID_ExecuteCommandHost = IID_IExecuteCommandHost;

        [NativeTypeName("#define STR_TAB_REUSE_IDENTIFIER L\"Tab Reuse Identifier\"")]
        public const string STR_TAB_REUSE_IDENTIFIER = "Tab Reuse Identifier";

        [NativeTypeName("#define STR_REFERRER_IDENTIFIER L\"Referrer Identifier\"")]
        public const string STR_REFERRER_IDENTIFIER = "Referrer Identifier";

        [NativeTypeName("#define SID_LaunchTargetMonitor __uuidof((struct __declspec(uuid(\"8D547FA1-CC45-40C8-B7C1-D48C183F13F3\")) LaunchTargetMonitor*)0)")]
        public static readonly Guid SID_LaunchTargetMonitor = new Guid(0x8D547FA1, 0xCC45, 0x40C8, 0xB7, 0xC1, 0xD4, 0x8C, 0x18, 0x3F, 0x13, 0xF3);

        [NativeTypeName("#define SID_HandlerInfo IID_IHandlerInfo")]
        public static readonly Guid SID_HandlerInfo = IID_IHandlerInfo;

        [NativeTypeName("#define SID_SHandlerActivationHost IID_IHandlerActivationHost")]
        public static readonly Guid SID_SHandlerActivationHost = IID_IHandlerActivationHost;

        [NativeTypeName("#define SID_AppActivationUIInfo IID_IAppActivationUIInfo")]
        public static readonly Guid SID_AppActivationUIInfo = IID_IAppActivationUIInfo;

        [NativeTypeName("#define ISIOI_ICONFILE 0x00000001")]
        public const int ISIOI_ICONFILE = 0x00000001;

        [NativeTypeName("#define ISIOI_ICONINDEX 0x00000002")]
        public const int ISIOI_ICONINDEX = 0x00000002;

        public static readonly Guid IID_IContextMenu = new Guid(0x000214E4, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IContextMenu2 = new Guid(0x000214F4, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IContextMenu3 = new Guid(0xBCFCE0A0, 0xEC17, 0x11D0, 0x8D, 0x10, 0x00, 0xA0, 0xC9, 0x0F, 0x27, 0x19);

        public static readonly Guid IID_IExecuteCommand = new Guid(0x7F9185B0, 0xCB92, 0x43C5, 0x80, 0xA9, 0x92, 0x27, 0x7A, 0x4F, 0x7B, 0x54);

        public static readonly Guid IID_IPersistFolder = new Guid(0x000214EA, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IRunnableTask = new Guid(0x85788D00, 0x6807, 0x11D0, 0xB8, 0x10, 0x00, 0xC0, 0x4F, 0xD7, 0x06, 0xEC);

        public static readonly Guid IID_IShellTaskScheduler = new Guid(0x6CCB7BE0, 0x6807, 0x11D0, 0xB8, 0x10, 0x00, 0xC0, 0x4F, 0xD7, 0x06, 0xEC);

        public static readonly Guid IID_IPersistFolder2 = new Guid(0x1AC3D9F0, 0x175C, 0x11D1, 0x95, 0xBE, 0x00, 0x60, 0x97, 0x97, 0xEA, 0x4F);

        public static readonly Guid IID_IPersistFolder3 = new Guid(0xCEF04FDF, 0xFE72, 0x11D2, 0x87, 0xA5, 0x00, 0xC0, 0x4F, 0x68, 0x37, 0xCF);

        public static readonly Guid IID_IPersistIDList = new Guid(0x1079ACFC, 0x29BD, 0x11D3, 0x8E, 0x0D, 0x00, 0xC0, 0x4F, 0x68, 0x37, 0xD5);

        public static readonly Guid IID_IEnumIDList = new Guid(0x000214F2, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IEnumFullIDList = new Guid(0xD0191542, 0x7954, 0x4908, 0xBC, 0x06, 0xB2, 0x36, 0x0B, 0xBE, 0x45, 0xBA);

        public static readonly Guid IID_IFileSyncMergeHandler = new Guid(0xD97B5AAC, 0xC792, 0x433C, 0x97, 0x5D, 0x35, 0xC4, 0xEA, 0xDC, 0x7A, 0x9D);

        public static readonly Guid IID_IObjectWithFolderEnumMode = new Guid(0x6A9D9026, 0x0E6E, 0x464C, 0xB0, 0x00, 0x42, 0xEC, 0xC0, 0x7D, 0xE6, 0x73);

        public static readonly Guid IID_IParseAndCreateItem = new Guid(0x67EFED0E, 0xE827, 0x4408, 0xB4, 0x93, 0x78, 0xF3, 0x98, 0x2B, 0x68, 0x5C);

        public static readonly Guid IID_IShellFolder = new Guid(0x000214E6, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IEnumExtraSearch = new Guid(0x0E700BE1, 0x9DB6, 0x11D1, 0xA1, 0xCE, 0x00, 0xC0, 0x4F, 0xD7, 0x5D, 0x13);

        public static readonly Guid IID_IShellFolder2 = new Guid(0x93F2F68C, 0x1D1B, 0x11D3, 0xA3, 0x0E, 0x00, 0xC0, 0x4F, 0x79, 0xAB, 0xD1);

        public static readonly Guid IID_IShellView = new Guid(0x000214E3, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IShellView2 = new Guid(0x88E39E80, 0x3578, 0x11CF, 0xAE, 0x69, 0x08, 0x00, 0x2B, 0x2E, 0x12, 0x62);

        public static readonly Guid IID_IFolderView = new Guid(0xCDE725B0, 0xCCC9, 0x4519, 0x91, 0x7E, 0x32, 0x5D, 0x72, 0xFA, 0xB4, 0xCE);

        public static readonly Guid IID_IFolderView2 = new Guid(0x1AF3A467, 0x214F, 0x4298, 0x90, 0x8E, 0x06, 0xB0, 0x3E, 0x0B, 0x39, 0xF9);

        public static readonly Guid IID_IFolderViewSettings = new Guid(0xAE8C987D, 0x8797, 0x4ED3, 0xBE, 0x72, 0x2A, 0x47, 0xDD, 0x93, 0x8D, 0xB0);

        public static readonly Guid IID_IInitializeNetworkFolder = new Guid(0x6E0F9881, 0x42A8, 0x4F2A, 0x97, 0xF8, 0x8A, 0xF4, 0xE0, 0x26, 0xD9, 0x2D);

        public static readonly Guid IID_INetworkFolderInternal = new Guid(0xCEB38218, 0xC971, 0x47BB, 0xA7, 0x03, 0xF0, 0xBC, 0x99, 0xCC, 0xDB, 0x81);

        public static readonly Guid IID_IPreviewHandlerVisuals = new Guid(0x196BF9A5, 0xB346, 0x4EF0, 0xAA, 0x1E, 0x5D, 0xCD, 0xB7, 0x67, 0x68, 0xB1);

        public static readonly Guid IID_ICommDlgBrowser = new Guid(0x000214F1, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_ICommDlgBrowser2 = new Guid(0x10339516, 0x2894, 0x11D2, 0x90, 0x39, 0x00, 0xC0, 0x4F, 0x8E, 0xEB, 0x3E);

        public static readonly Guid IID_IColumnManager = new Guid(0xD8EC27BB, 0x3F3B, 0x4042, 0xB1, 0x0A, 0x4A, 0xCF, 0xD9, 0x24, 0xD4, 0x53);

        public static readonly Guid IID_IFolderFilterSite = new Guid(0xC0A651F5, 0xB48B, 0x11D2, 0xB5, 0xED, 0x00, 0x60, 0x97, 0xC6, 0x86, 0xF6);

        public static readonly Guid IID_IFolderFilter = new Guid(0x9CC22886, 0xDC8E, 0x11D2, 0xB1, 0xD0, 0x00, 0xC0, 0x4F, 0x8E, 0xEB, 0x3E);

        public static readonly Guid IID_IInputObjectSite = new Guid(0xF1DB8392, 0x7331, 0x11D0, 0x8C, 0x99, 0x00, 0xA0, 0xC9, 0x2D, 0xBF, 0xE8);

        public static readonly Guid IID_IInputObject = new Guid(0x68284FAA, 0x6A48, 0x11D0, 0x8C, 0x78, 0x00, 0xC0, 0x4F, 0xD9, 0x18, 0xB4);

        public static readonly Guid IID_IInputObject2 = new Guid(0x6915C085, 0x510B, 0x44CD, 0x94, 0xAF, 0x28, 0xDF, 0xA5, 0x6C, 0xF9, 0x2B);

        public static readonly Guid IID_IShellIcon = new Guid(0x000214E5, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IShellBrowser = new Guid(0x000214E2, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IProfferService = new Guid(0xCB728B20, 0xF786, 0x11CE, 0x92, 0xAD, 0x00, 0xAA, 0x00, 0xA7, 0x4C, 0xD0);

        public static readonly Guid IID_IGetServiceIds = new Guid(0x4A073526, 0x6103, 0x4E21, 0xB7, 0xBC, 0xF5, 0x19, 0xD1, 0x52, 0x4E, 0x5D);

        public static readonly Guid IID_IShellItem = new Guid(0x43826D1E, 0xE718, 0x42EE, 0xBC, 0x55, 0xA1, 0xE2, 0x61, 0xC3, 0x7B, 0xFE);

        public static readonly Guid IID_IShellItem2 = new Guid(0x7E9FB0D3, 0x919F, 0x4307, 0xAB, 0x2E, 0x9B, 0x18, 0x60, 0x31, 0x0C, 0x93);

        public static readonly Guid IID_IShellItemImageFactory = new Guid(0xBCC18B79, 0xBA16, 0x442F, 0x80, 0xC4, 0x8A, 0x59, 0xC3, 0x0C, 0x46, 0x3B);

        public static readonly Guid IID_IEnumShellItems = new Guid(0x70629033, 0xE363, 0x4A28, 0xA5, 0x67, 0x0D, 0xB7, 0x80, 0x06, 0xE6, 0xD7);

        public static readonly Guid IID_ITransferAdviseSink = new Guid(0xD594D0D8, 0x8DA7, 0x457B, 0xB3, 0xB4, 0xCE, 0x5D, 0xBA, 0xAC, 0x0B, 0x88);

        public static readonly Guid IID_ITransferSource = new Guid(0x00ADB003, 0xBDE9, 0x45C6, 0x8E, 0x29, 0xD0, 0x9F, 0x93, 0x53, 0xE1, 0x08);

        public static readonly Guid IID_IEnumResources = new Guid(0x2DD81FE3, 0xA83C, 0x4DA9, 0xA3, 0x30, 0x47, 0x24, 0x9D, 0x34, 0x5B, 0xA1);

        public static readonly Guid IID_IShellItemResources = new Guid(0xFF5693BE, 0x2CE0, 0x4D48, 0xB5, 0xC5, 0x40, 0x81, 0x7D, 0x1A, 0xCD, 0xB9);

        public static readonly Guid IID_ITransferDestination = new Guid(0x48ADDD32, 0x3CA5, 0x4124, 0xAB, 0xE3, 0xB5, 0xA7, 0x25, 0x31, 0xB2, 0x07);

        public static readonly Guid IID_IFileOperationProgressSink = new Guid(0x04B0F1A7, 0x9490, 0x44BC, 0x96, 0xE1, 0x42, 0x96, 0xA3, 0x12, 0x52, 0xE2);

        public static readonly Guid IID_IShellItemArray = new Guid(0xB63EA76D, 0x1F85, 0x456F, 0xA1, 0x9C, 0x48, 0x15, 0x9E, 0xFA, 0x85, 0x8B);

        public static readonly Guid IID_IInitializeWithItem = new Guid(0x7F73BE3F, 0xFB79, 0x493C, 0xA6, 0xC7, 0x7E, 0xE1, 0x4E, 0x24, 0x58, 0x41);

        public static readonly Guid IID_IObjectWithSelection = new Guid(0x1C9CD5BB, 0x98E9, 0x4491, 0xA6, 0x0F, 0x31, 0xAA, 0xCC, 0x72, 0xB8, 0x3C);

        public static readonly Guid IID_IObjectWithBackReferences = new Guid(0x321A6A6A, 0xD61F, 0x4BF3, 0x97, 0xAE, 0x14, 0xBE, 0x29, 0x86, 0xBB, 0x36);

        public static readonly Guid IID_IPropertyUI = new Guid(0x757A7D9F, 0x919A, 0x4118, 0x99, 0xD7, 0xDB, 0xB2, 0x08, 0xC8, 0xCC, 0x66);

        public static readonly Guid IID_ICategoryProvider = new Guid(0x9AF64809, 0x5864, 0x4C26, 0xA7, 0x20, 0xC1, 0xF7, 0x8C, 0x08, 0x6E, 0xE3);

        public static readonly Guid IID_ICategorizer = new Guid(0xA3B14589, 0x9174, 0x49A8, 0x89, 0xA3, 0x06, 0xA1, 0xAE, 0x2B, 0x9B, 0xA7);

        public static readonly Guid IID_IDropTargetHelper = new Guid(0x4657278B, 0x411B, 0x11D2, 0x83, 0x9A, 0x00, 0xC0, 0x4F, 0xD9, 0x18, 0xD0);

        public static readonly Guid IID_IDragSourceHelper = new Guid(0xDE5BF786, 0x477A, 0x11D2, 0x83, 0x9D, 0x00, 0xC0, 0x4F, 0xD9, 0x18, 0xD0);

        public static readonly Guid IID_IShellLinkA = new Guid(0x000214EE, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IShellLinkW = new Guid(0x000214F9, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IShellLinkDataList = new Guid(0x45E2B4AE, 0xB1C3, 0x11D0, 0xB9, 0x2F, 0x00, 0xA0, 0xC9, 0x03, 0x12, 0xE1);

        public static readonly Guid IID_IResolveShellLink = new Guid(0x5CD52983, 0x9449, 0x11D2, 0x96, 0x3A, 0x00, 0xC0, 0x4F, 0x79, 0xAD, 0xF0);

        public static readonly Guid IID_IActionProgressDialog = new Guid(0x49FF1172, 0xEADC, 0x446D, 0x92, 0x85, 0x15, 0x64, 0x53, 0xA6, 0x43, 0x1C);

        public static readonly Guid IID_IActionProgress = new Guid(0x49FF1173, 0xEADC, 0x446D, 0x92, 0x85, 0x15, 0x64, 0x53, 0xA6, 0x43, 0x1C);

        public static readonly Guid IID_IShellExtInit = new Guid(0x000214E8, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IShellPropSheetExt = new Guid(0x000214E9, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IRemoteComputer = new Guid(0x000214FE, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IQueryContinue = new Guid(0x7307055C, 0xB24A, 0x486B, 0x9F, 0x25, 0x16, 0x3E, 0x59, 0x7A, 0x28, 0xA9);

        public static readonly Guid IID_IObjectWithCancelEvent = new Guid(0xF279B885, 0x0AE9, 0x4B85, 0xAC, 0x06, 0xDD, 0xEC, 0xF9, 0x40, 0x89, 0x41);

        public static readonly Guid IID_IUserNotification = new Guid(0xBA9711BA, 0x5893, 0x4787, 0xA7, 0xE1, 0x41, 0x27, 0x71, 0x51, 0x55, 0x0B);

        public static readonly Guid IID_IItemNameLimits = new Guid(0x1DF0D7F1, 0xB267, 0x4D28, 0x8B, 0x10, 0x12, 0xE2, 0x32, 0x02, 0xA5, 0xC4);

        public static readonly Guid IID_ISearchFolderItemFactory = new Guid(0xA0FFBC28, 0x5482, 0x4366, 0xBE, 0x27, 0x3E, 0x81, 0xE7, 0x8E, 0x06, 0xC2);

        public static readonly Guid IID_IExtractImage = new Guid(0xBB2E617C, 0x0920, 0x11D1, 0x9A, 0x0B, 0x00, 0xC0, 0x4F, 0xC2, 0xD6, 0xC1);

        public static readonly Guid IID_IExtractImage2 = new Guid(0x953BB1EE, 0x93B4, 0x11D1, 0x98, 0xA3, 0x00, 0xC0, 0x4F, 0xB6, 0x87, 0xDA);

        public static readonly Guid IID_IThumbnailHandlerFactory = new Guid(0xE35B4B2E, 0x00DA, 0x4BC1, 0x9F, 0x13, 0x38, 0xBC, 0x11, 0xF5, 0xD4, 0x17);

        public static readonly Guid IID_IParentAndItem = new Guid(0xB3A4B685, 0xB685, 0x4805, 0x99, 0xD9, 0x5D, 0xEA, 0xD2, 0x87, 0x32, 0x36);

        public static readonly Guid IID_IDockingWindow = new Guid(0x012DD920, 0x7B26, 0x11D0, 0x8C, 0xA9, 0x00, 0xA0, 0xC9, 0x2D, 0xBF, 0xE8);

        public static readonly Guid IID_IDeskBand = new Guid(0xEB0FE172, 0x1A3A, 0x11D0, 0x89, 0xB3, 0x00, 0xA0, 0xC9, 0x0A, 0x90, 0xAC);

        public static readonly Guid IID_IDeskBandInfo = new Guid(0x77E425FC, 0xCBF9, 0x4307, 0xBA, 0x6A, 0xBB, 0x57, 0x27, 0x74, 0x56, 0x61);

        public static readonly Guid IID_ITaskbarList = new Guid(0x56FDF342, 0xFD6D, 0x11D0, 0x95, 0x8A, 0x00, 0x60, 0x97, 0xC9, 0xA0, 0x90);

        public static readonly Guid IID_ITaskbarList2 = new Guid(0x602D4995, 0xB13A, 0x429B, 0xA6, 0x6E, 0x19, 0x35, 0xE4, 0x4F, 0x43, 0x17);

        public static readonly Guid IID_ITaskbarList3 = new Guid(0xEA1AFB91, 0x9E28, 0x4B86, 0x90, 0xE9, 0x9E, 0x9F, 0x8A, 0x5E, 0xEF, 0xAF);

        public static readonly Guid IID_ITaskbarList4 = new Guid(0xC43DC798, 0x95D1, 0x4BEA, 0x90, 0x30, 0xBB, 0x99, 0xE2, 0x98, 0x3A, 0x1A);

        public static readonly Guid IID_IExplorerBrowserEvents = new Guid(0x361BBDC7, 0xE6EE, 0x4E13, 0xBE, 0x58, 0x58, 0xE2, 0x24, 0x0C, 0x81, 0x0F);

        public static readonly Guid IID_IExplorerBrowser = new Guid(0xDFD3B6B5, 0xC10C, 0x4BE9, 0x85, 0xF6, 0xA6, 0x69, 0x69, 0xF4, 0x02, 0xF6);

        public static readonly Guid IID_IEnumObjects = new Guid(0x2C1C7E2E, 0x2D0E, 0x4059, 0x83, 0x1E, 0x1E, 0x6F, 0x82, 0x33, 0x5C, 0x2E);

        public static readonly Guid IID_IOperationsProgressDialog = new Guid(0x0C9FB851, 0xE5C9, 0x43EB, 0xA3, 0x70, 0xF0, 0x67, 0x7B, 0x13, 0x87, 0x4C);

        public static readonly Guid IID_IIOCancelInformation = new Guid(0xF5B0BF81, 0x8CB5, 0x4B1B, 0x94, 0x49, 0x1A, 0x15, 0x9E, 0x0C, 0x73, 0x3C);

        public static readonly Guid IID_IFileOperation = new Guid(0x947AAB5F, 0x0A5C, 0x4C13, 0xB4, 0xD6, 0x4B, 0xF7, 0x83, 0x6F, 0xC9, 0xF8);

        public static readonly Guid IID_IFileOperation2 = new Guid(0xCD8F23C1, 0x8F61, 0x4916, 0x90, 0x9D, 0x55, 0xBD, 0xD0, 0x91, 0x87, 0x53);

        public static readonly Guid IID_IObjectProvider = new Guid(0xA6087428, 0x3BE3, 0x4D73, 0xB3, 0x08, 0x7C, 0x04, 0xA5, 0x40, 0xBF, 0x1A);

        public static readonly Guid IID_INamespaceWalkCB = new Guid(0xD92995F8, 0xCF5E, 0x4A76, 0xBF, 0x59, 0xEA, 0xD3, 0x9E, 0xA2, 0xB9, 0x7E);

        public static readonly Guid IID_INamespaceWalkCB2 = new Guid(0x7AC7492B, 0xC38E, 0x438A, 0x87, 0xDB, 0x68, 0x73, 0x78, 0x44, 0xFF, 0x70);

        public static readonly Guid IID_INamespaceWalk = new Guid(0x57CED8A7, 0x3F4A, 0x432C, 0x93, 0x50, 0x30, 0xF2, 0x44, 0x83, 0xF7, 0x4F);

        public static readonly Guid IID_IBandSite = new Guid(0x4CF504B0, 0xDE96, 0x11D0, 0x8B, 0x3F, 0x00, 0xA0, 0xC9, 0x11, 0xE8, 0xE5);

        public static readonly Guid IID_IModalWindow = new Guid(0xB4DB1657, 0x70D7, 0x485E, 0x8E, 0x3E, 0x6F, 0xCB, 0x5A, 0x5C, 0x18, 0x02);

        public static readonly Guid IID_IContextMenuSite = new Guid(0x0811AEBE, 0x0B87, 0x4C54, 0x9E, 0x72, 0x54, 0x8C, 0xF6, 0x49, 0x01, 0x6B);

        public static readonly Guid IID_IMenuBand = new Guid(0x568804CD, 0xCBD7, 0x11D0, 0x98, 0x16, 0x00, 0xC0, 0x4F, 0xD9, 0x19, 0x72);

        public static readonly Guid IID_IRegTreeItem = new Guid(0xA9521922, 0x0812, 0x4D44, 0x9E, 0xC3, 0x7F, 0xD3, 0x8C, 0x72, 0x6F, 0x3D);

        public static readonly Guid IID_IDeskBar = new Guid(0xEB0FE173, 0x1A3A, 0x11D0, 0x89, 0xB3, 0x00, 0xA0, 0xC9, 0x0A, 0x90, 0xAC);

        public static readonly Guid IID_IMenuPopup = new Guid(0xD1E7AFEB, 0x6A2E, 0x11D0, 0x8C, 0x78, 0x00, 0xC0, 0x4F, 0xD9, 0x18, 0xB4);

        public static readonly Guid IID_IFileIsInUse = new Guid(0x64A1CBF0, 0x3A1A, 0x4461, 0x91, 0x58, 0x37, 0x69, 0x69, 0x69, 0x39, 0x50);

        public static readonly Guid IID_IFileDialogEvents = new Guid(0x973510DB, 0x7D7F, 0x452B, 0x89, 0x75, 0x74, 0xA8, 0x58, 0x28, 0xD3, 0x54);

        public static readonly Guid IID_IFileDialog = new Guid(0x42F85136, 0xDB7E, 0x439C, 0x85, 0xF1, 0xE4, 0x07, 0x5D, 0x13, 0x5F, 0xC8);

        public static readonly Guid IID_IFileSaveDialog = new Guid(0x84BCCD23, 0x5FDE, 0x4CDB, 0xAE, 0xA4, 0xAF, 0x64, 0xB8, 0x3D, 0x78, 0xAB);

        public static readonly Guid IID_IFileOpenDialog = new Guid(0xD57C7288, 0xD4AD, 0x4768, 0xBE, 0x02, 0x9D, 0x96, 0x95, 0x32, 0xD9, 0x60);

        public static readonly Guid IID_IFileDialogCustomize = new Guid(0xE6FDD21A, 0x163F, 0x4975, 0x9C, 0x8C, 0xA6, 0x9F, 0x1B, 0xA3, 0x70, 0x34);

        public static readonly Guid IID_IApplicationAssociationRegistration = new Guid(0x4E530B0A, 0xE611, 0x4C77, 0xA3, 0xAC, 0x90, 0x31, 0xD0, 0x22, 0x28, 0x1B);

        public static readonly Guid IID_IDelegateFolder = new Guid(0xADD8BA80, 0x002B, 0x11D0, 0x8F, 0x0F, 0x00, 0xC0, 0x4F, 0xD7, 0xD0, 0x62);

        public static readonly Guid IID_IBrowserFrameOptions = new Guid(0x10DF43C8, 0x1DBE, 0x11D3, 0x8B, 0x34, 0x00, 0x60, 0x97, 0xDF, 0x5B, 0xD4);

        public static readonly Guid IID_INewWindowManager = new Guid(0xD2BC4C84, 0x3F72, 0x4A52, 0xA6, 0x04, 0x7B, 0xCB, 0xF3, 0x98, 0x2C, 0xBB);

        public static readonly Guid IID_IAttachmentExecute = new Guid(0x73DB1241, 0x1E85, 0x4581, 0x8E, 0x4F, 0xA8, 0x1E, 0x1D, 0x0F, 0x8C, 0x57);

        public static readonly Guid IID_IShellMenuCallback = new Guid(0x4CA300A1, 0x9B8D, 0x11D1, 0x8B, 0x22, 0x00, 0xC0, 0x4F, 0xD9, 0x18, 0xD0);

        public static readonly Guid IID_IShellMenu = new Guid(0xEE1F7637, 0xE138, 0x11D1, 0x83, 0x79, 0x00, 0xC0, 0x4F, 0xD9, 0x18, 0xD0);

        public static readonly Guid IID_IKnownFolder = new Guid(0x3AA7AF7E, 0x9B36, 0x420C, 0xA8, 0xE3, 0xF7, 0x7D, 0x46, 0x74, 0xA4, 0x88);

        public static readonly Guid IID_IKnownFolderManager = new Guid(0x8BE2D872, 0x86AA, 0x4D47, 0xB7, 0x76, 0x32, 0xCC, 0xA4, 0x0C, 0x70, 0x18);

        public static readonly Guid IID_ISharingConfigurationManager = new Guid(0xB4CD448A, 0x9C86, 0x4466, 0x92, 0x01, 0x2E, 0x62, 0x10, 0x5B, 0x87, 0xAE);

        public static readonly Guid IID_IRelatedItem = new Guid(0xA73CE67A, 0x8AB1, 0x44F1, 0x8D, 0x43, 0xD2, 0xFC, 0xBF, 0x6B, 0x1C, 0xD0);

        public static readonly Guid IID_IIdentityName = new Guid(0x7D903FCA, 0xD6F9, 0x4810, 0x83, 0x32, 0x94, 0x6C, 0x01, 0x77, 0xE2, 0x47);

        public static readonly Guid IID_IDelegateItem = new Guid(0x3C5A1C94, 0xC951, 0x4CB7, 0xBB, 0x6D, 0x3B, 0x93, 0xF3, 0x0C, 0xCE, 0x93);

        public static readonly Guid IID_ICurrentItem = new Guid(0x240A7174, 0xD653, 0x4A1D, 0xA6, 0xD3, 0xD4, 0x94, 0x3C, 0xFB, 0xFE, 0x3D);

        public static readonly Guid IID_ITransferMediumItem = new Guid(0x77F295D5, 0x2D6F, 0x4E19, 0xB8, 0xAE, 0x32, 0x2F, 0x3E, 0x72, 0x1A, 0xB5);

        public static readonly Guid IID_IDisplayItem = new Guid(0xC6FD5997, 0x9F6B, 0x4888, 0x87, 0x03, 0x94, 0xE8, 0x0E, 0x8C, 0xDE, 0x3F);

        public static readonly Guid IID_IViewStateIdentityItem = new Guid(0x9D264146, 0xA94F, 0x4195, 0x9F, 0x9F, 0x3B, 0xB1, 0x2C, 0xE0, 0xC9, 0x55);

        public static readonly Guid IID_IPreviewItem = new Guid(0x36149969, 0x0A8F, 0x49C8, 0x8B, 0x00, 0x4A, 0xEC, 0xB2, 0x02, 0x22, 0xFB);

        public static readonly Guid IID_IDestinationStreamFactory = new Guid(0x8A87781B, 0x39A7, 0x4A1F, 0xAA, 0xB3, 0xA3, 0x9B, 0x9C, 0x34, 0xA7, 0xD9);

        public static readonly Guid IID_ICreateProcessInputs = new Guid(0xF6EF6140, 0xE26F, 0x4D82, 0xBA, 0xC4, 0xE9, 0xBA, 0x5F, 0xD2, 0x39, 0xA8);

        public static readonly Guid IID_ICreatingProcess = new Guid(0xC2B937A9, 0x3110, 0x4398, 0x8A, 0x56, 0xF3, 0x4C, 0x63, 0x42, 0xD2, 0x44);

        public static readonly Guid IID_ILaunchUIContext = new Guid(0x1791E8F6, 0x21C7, 0x4340, 0x88, 0x2A, 0xA6, 0xA9, 0x3E, 0x3F, 0xD7, 0x3B);

        public static readonly Guid IID_ILaunchUIContextProvider = new Guid(0x0D12C4C8, 0xA3D9, 0x4E24, 0x94, 0xC1, 0x0E, 0x20, 0xC5, 0xA9, 0x56, 0xC4);

        public static readonly Guid IID_INewMenuClient = new Guid(0xDCB07FDC, 0x3BB5, 0x451C, 0x90, 0xBE, 0x96, 0x66, 0x44, 0xFE, 0xD7, 0xB0);

        public static readonly Guid IID_IInitializeWithBindCtx = new Guid(0x71C0D2BC, 0x726D, 0x45CC, 0xA6, 0xC0, 0x2E, 0x31, 0xC1, 0xDB, 0x21, 0x59);

        public static readonly Guid IID_IShellItemFilter = new Guid(0x2659B475, 0xEEB8, 0x48B7, 0x8F, 0x07, 0xB3, 0x78, 0x81, 0x0F, 0x48, 0xCF);

        public static readonly Guid IID_INameSpaceTreeControl = new Guid(0x028212A3, 0xB627, 0x47E9, 0x88, 0x56, 0xC1, 0x42, 0x65, 0x55, 0x4E, 0x4F);

        public static readonly Guid IID_INameSpaceTreeControlFolderCapabilities = new Guid(0xE9701183, 0xE6B3, 0x4FF2, 0x85, 0x68, 0x81, 0x36, 0x15, 0xFE, 0xC7, 0xBE);

        public static readonly Guid IID_IPreviewHandler = new Guid(0x8895B1C6, 0xB41F, 0x4C1C, 0xA5, 0x62, 0x0D, 0x56, 0x42, 0x50, 0x83, 0x6F);

        public static readonly Guid IID_IPreviewHandlerFrame = new Guid(0xFEC87AAF, 0x35F9, 0x447A, 0xAD, 0xB7, 0x20, 0x23, 0x44, 0x91, 0x40, 0x1A);

        public static readonly Guid IID_IExplorerPaneVisibility = new Guid(0xE07010EC, 0xBC17, 0x44C0, 0x97, 0xB0, 0x46, 0xC7, 0xC9, 0x5B, 0x9E, 0xDC);

        public static readonly Guid IID_IContextMenuCB = new Guid(0x3409E930, 0x5A39, 0x11D1, 0x83, 0xFA, 0x00, 0xA0, 0xC9, 0x0D, 0xC8, 0x49);

        public static readonly Guid IID_IDefaultExtractIconInit = new Guid(0x41DED17D, 0xD6B3, 0x4261, 0x99, 0x7D, 0x88, 0xC6, 0x0E, 0x4B, 0x1D, 0x58);

        public static readonly Guid IID_IExplorerCommand = new Guid(0xA08CE4D0, 0xFA25, 0x44AB, 0xB5, 0x7C, 0xC7, 0xB1, 0xC3, 0x23, 0xE0, 0xB9);

        public static readonly Guid IID_IExplorerCommandState = new Guid(0xBDDACB60, 0x7657, 0x47AE, 0x84, 0x45, 0xD2, 0x3E, 0x1A, 0xCF, 0x82, 0xAE);

        public static readonly Guid IID_IInitializeCommand = new Guid(0x85075ACF, 0x231F, 0x40EA, 0x96, 0x10, 0xD2, 0x6B, 0x7B, 0x58, 0xF6, 0x38);

        public static readonly Guid IID_IEnumExplorerCommand = new Guid(0xA88826F8, 0x186F, 0x4987, 0xAA, 0xDE, 0xEA, 0x0C, 0xEF, 0x8F, 0xBF, 0xE8);

        public static readonly Guid IID_IExplorerCommandProvider = new Guid(0x64961751, 0x0835, 0x43C0, 0x8F, 0xFE, 0xD5, 0x76, 0x86, 0x53, 0x0E, 0x64);

        public static readonly Guid IID_IOpenControlPanel = new Guid(0xD11AD862, 0x66DE, 0x4DF4, 0xBF, 0x6C, 0x1F, 0x56, 0x21, 0x99, 0x6A, 0xF1);

        public static readonly Guid IID_IFileSystemBindData = new Guid(0x01E18D10, 0x4D8B, 0x11D2, 0x85, 0x5D, 0x00, 0x60, 0x08, 0x05, 0x93, 0x67);

        public static readonly Guid IID_IFileSystemBindData2 = new Guid(0x3ACF075F, 0x71DB, 0x4AFA, 0x81, 0xF0, 0x3F, 0xC4, 0xFD, 0xF2, 0xA5, 0xB8);

        public static readonly Guid IID_ICustomDestinationList = new Guid(0x6332DEBF, 0x87B5, 0x4670, 0x90, 0xC0, 0x5E, 0x57, 0xB4, 0x08, 0xA4, 0x9E);

        public static readonly Guid IID_IApplicationDestinations = new Guid(0x12337D35, 0x94C6, 0x48A0, 0xBC, 0xE7, 0x6A, 0x9C, 0x69, 0xD4, 0xD6, 0x00);

        public static readonly Guid IID_IApplicationDocumentLists = new Guid(0x3C594F9F, 0x9F30, 0x47A1, 0x97, 0x9A, 0xC9, 0xE8, 0x3D, 0x3D, 0x0A, 0x06);

        public static readonly Guid IID_IObjectWithAppUserModelID = new Guid(0x36DB0196, 0x9665, 0x46D1, 0x9B, 0xA7, 0xD3, 0x70, 0x9E, 0xEC, 0xF9, 0xED);

        public static readonly Guid IID_IObjectWithProgID = new Guid(0x71E806FB, 0x8DEE, 0x46FC, 0xBF, 0x8C, 0x77, 0x48, 0xA8, 0xA1, 0xAE, 0x13);

        public static readonly Guid IID_IUpdateIDList = new Guid(0x6589B6D2, 0x5F8D, 0x4B9E, 0xB7, 0xE0, 0x23, 0xCD, 0xD9, 0x71, 0x7D, 0x8C);

        public static readonly Guid IID_IDesktopWallpaper = new Guid(0xB92B56A9, 0x8B55, 0x4E14, 0x9A, 0x89, 0x01, 0x99, 0xBB, 0xB6, 0xF9, 0x3B);

        public static readonly Guid IID_IHomeGroup = new Guid(0x7A3BD1D9, 0x35A9, 0x4FB3, 0xA4, 0x67, 0xF4, 0x8C, 0xAC, 0x35, 0xE2, 0xD0);

        public static readonly Guid IID_IInitializeWithPropertyStore = new Guid(0xC3E12EB5, 0x7D8D, 0x44F8, 0xB6, 0xDD, 0x0E, 0x77, 0xB3, 0x4D, 0x6D, 0xE4);

        public static readonly Guid IID_IOpenSearchSource = new Guid(0xF0EE7333, 0xE6FC, 0x479B, 0x9F, 0x25, 0xA8, 0x60, 0xC2, 0x34, 0xA3, 0x8E);

        public static readonly Guid IID_IShellLibrary = new Guid(0x11A66EFA, 0x382E, 0x451A, 0x92, 0x34, 0x1E, 0x0E, 0x12, 0xEF, 0x30, 0x85);

        public static readonly Guid IID_IDefaultFolderMenuInitialize = new Guid(0x7690AA79, 0xF8FC, 0x4615, 0xA3, 0x27, 0x36, 0xF7, 0xD1, 0x8F, 0x5D, 0x91);

        public static readonly Guid IID_IApplicationActivationManager = new Guid(0x2E941141, 0x7F97, 0x4756, 0xBA, 0x1D, 0x9D, 0xEC, 0xDE, 0x89, 0x4A, 0x3D);

        public static readonly Guid IID_IVirtualDesktopManager = new Guid(0xA5CD92FF, 0x29BE, 0x454C, 0x8D, 0x04, 0xD8, 0x28, 0x79, 0xFB, 0x3F, 0x1B);

        public static readonly Guid IID_DesktopWallpaper = new Guid(0xC2CF3110, 0x460E, 0x4FC1, 0xB9, 0xD0, 0x8A, 0x1C, 0x0C, 0x9C, 0xC4, 0xBD);

        public static readonly Guid IID_ShellDesktop = new Guid(0x00021400, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_ShellFSFolder = new Guid(0xF3364BA0, 0x65B9, 0x11CE, 0xA9, 0xBA, 0x00, 0xAA, 0x00, 0x4A, 0xE8, 0x37);

        public static readonly Guid IID_NetworkPlaces = new Guid(0x208D2C60, 0x3AEA, 0x1069, 0xA2, 0xD7, 0x08, 0x00, 0x2B, 0x30, 0x30, 0x9D);

        public static readonly Guid IID_ShellLink = new Guid(0x00021401, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_DriveSizeCategorizer = new Guid(0x94357B53, 0xCA29, 0x4B78, 0x83, 0xAE, 0xE8, 0xFE, 0x74, 0x09, 0x13, 0x4F);

        public static readonly Guid IID_DriveTypeCategorizer = new Guid(0xB0A8F3CF, 0x4333, 0x4BAB, 0x88, 0x73, 0x1C, 0xCB, 0x1C, 0xAD, 0xA4, 0x8B);

        public static readonly Guid IID_FreeSpaceCategorizer = new Guid(0xB5607793, 0x24AC, 0x44C7, 0x82, 0xE2, 0x83, 0x17, 0x26, 0xAA, 0x6C, 0xB7);

        public static readonly Guid IID_SizeCategorizer = new Guid(0x55D7B852, 0xF6D1, 0x42F2, 0xAA, 0x75, 0x87, 0x28, 0xA1, 0xB2, 0xD2, 0x64);

        public static readonly Guid IID_PropertiesUI = new Guid(0xD912F8CF, 0x0396, 0x4915, 0x88, 0x4E, 0xFB, 0x42, 0x5D, 0x32, 0x94, 0x3B);

        public static readonly Guid IID_UserNotification = new Guid(0x0010890E, 0x8789, 0x413C, 0xAD, 0xBC, 0x48, 0xF5, 0xB5, 0x11, 0xB3, 0xAF);

        public static readonly Guid IID_TaskbarList = new Guid(0x56FDF344, 0xFD6D, 0x11D0, 0x95, 0x8A, 0x00, 0x60, 0x97, 0xC9, 0xA0, 0x90);

        public static readonly Guid IID_ShellItem = new Guid(0x9AC9FBE1, 0xE0A2, 0x4AD6, 0xB4, 0xEE, 0xE2, 0x12, 0x01, 0x3E, 0xA9, 0x17);

        public static readonly Guid IID_NamespaceWalker = new Guid(0x72EB61E0, 0x8672, 0x4303, 0x91, 0x75, 0xF2, 0xE4, 0xC6, 0x8B, 0x2E, 0x7C);

        public static readonly Guid IID_FileOperation = new Guid(0x3AD05575, 0x8857, 0x4850, 0x92, 0x77, 0x11, 0xB8, 0x5B, 0xDB, 0x8E, 0x09);

        public static readonly Guid IID_FileOpenDialog = new Guid(0xDC1C5A9C, 0xE88A, 0x4DDE, 0xA5, 0xA1, 0x60, 0xF8, 0x2A, 0x20, 0xAE, 0xF7);

        public static readonly Guid IID_FileSaveDialog = new Guid(0xC0B4E2F3, 0xBA21, 0x4773, 0x8D, 0xBA, 0x33, 0x5E, 0xC9, 0x46, 0xEB, 0x8B);

        public static readonly Guid IID_KnownFolderManager = new Guid(0x4DF0C730, 0xDF9D, 0x4AE3, 0x91, 0x53, 0xAA, 0x6B, 0x82, 0xE9, 0x79, 0x5A);

        public static readonly Guid IID_SharingConfigurationManager = new Guid(0x49F371E1, 0x8C5C, 0x4D9C, 0x9A, 0x3B, 0x54, 0xA6, 0x82, 0x7F, 0x51, 0x3C);

        public static readonly Guid IID_NetworkConnections = new Guid(0x7007ACC7, 0x3202, 0x11D1, 0xAA, 0xD2, 0x00, 0x80, 0x5F, 0xC1, 0x27, 0x0E);

        public static readonly Guid IID_ScheduledTasks = new Guid(0xD6277990, 0x4C6A, 0x11CF, 0x8D, 0x87, 0x00, 0xAA, 0x00, 0x60, 0xF5, 0xBF);

        public static readonly Guid IID_ApplicationAssociationRegistration = new Guid(0x591209C7, 0x767B, 0x42B2, 0x9F, 0xBA, 0x44, 0xEE, 0x46, 0x15, 0xF2, 0xC7);

        public static readonly Guid IID_SearchFolderItemFactory = new Guid(0x14010E02, 0xBBBD, 0x41F0, 0x88, 0xE3, 0xED, 0xA3, 0x71, 0x21, 0x65, 0x84);

        public static readonly Guid IID_OpenControlPanel = new Guid(0x06622D85, 0x6856, 0x4460, 0x8D, 0xE1, 0xA8, 0x19, 0x21, 0xB4, 0x1C, 0x4B);

        public static readonly Guid IID_MailRecipient = new Guid(0x9E56BE60, 0xC50F, 0x11CF, 0x9A, 0x2C, 0x00, 0xA0, 0xC9, 0x0A, 0x90, 0xCE);

        public static readonly Guid IID_NetworkExplorerFolder = new Guid(0xF02C1A0D, 0xBE21, 0x4350, 0x88, 0xB0, 0x73, 0x67, 0xFC, 0x96, 0xEF, 0x3C);

        public static readonly Guid IID_DestinationList = new Guid(0x77F10CF0, 0x3DB5, 0x4966, 0xB5, 0x20, 0xB7, 0xC5, 0x4F, 0xD3, 0x5E, 0xD6);

        public static readonly Guid IID_ApplicationDestinations = new Guid(0x86C14003, 0x4D6B, 0x4EF3, 0xA7, 0xB4, 0x05, 0x06, 0x66, 0x3B, 0x2E, 0x68);

        public static readonly Guid IID_ApplicationDocumentLists = new Guid(0x86BEC222, 0x30F2, 0x47E0, 0x9F, 0x25, 0x60, 0xD1, 0x1C, 0xD7, 0x5C, 0x28);

        public static readonly Guid IID_HomeGroup = new Guid(0xDE77BA04, 0x3C92, 0x4D11, 0xA1, 0xA5, 0x42, 0x35, 0x2A, 0x53, 0xE0, 0xE3);

        public static readonly Guid IID_ShellLibrary = new Guid(0xD9B3211D, 0xE57F, 0x4426, 0xAA, 0xEF, 0x30, 0xA8, 0x06, 0xAD, 0xD3, 0x97);

        public static readonly Guid IID_AppStartupLink = new Guid(0x273EB5E7, 0x88B0, 0x4843, 0xBF, 0xEF, 0xE2, 0xC8, 0x1D, 0x43, 0xAA, 0xE5);

        public static readonly Guid IID_EnumerableObjectCollection = new Guid(0x2D3468C1, 0x36A7, 0x43B6, 0xAC, 0x24, 0xD3, 0xF0, 0x2F, 0xD9, 0x60, 0x7A);

        public static readonly Guid IID_FrameworkInputPane = new Guid(0xD5120AA3, 0x46BA, 0x44C5, 0x82, 0x2D, 0xCA, 0x80, 0x92, 0xC1, 0xFC, 0x72);

        public static readonly Guid IID_DefFolderMenu = new Guid(0xC63382BE, 0x7933, 0x48D0, 0x9A, 0xC8, 0x85, 0xFB, 0x46, 0xBE, 0x2F, 0xDD);

        public static readonly Guid IID_AppVisibility = new Guid(0x7E5FE3D9, 0x985F, 0x4908, 0x91, 0xF9, 0xEE, 0x19, 0xF9, 0xFD, 0x15, 0x14);

        public static readonly Guid IID_AppShellVerbHandler = new Guid(0x4ED3A719, 0xCEA8, 0x4BD9, 0x91, 0x0D, 0xE2, 0x52, 0xF9, 0x97, 0xAF, 0xC2);

        public static readonly Guid IID_ExecuteUnknown = new Guid(0xE44E9428, 0xBDBC, 0x4987, 0xA0, 0x99, 0x40, 0xDC, 0x8F, 0xD2, 0x55, 0xE7);

        public static readonly Guid IID_PackageDebugSettings = new Guid(0xB1AEC16F, 0x2383, 0x4852, 0xB0, 0xE9, 0x8F, 0x0B, 0x1D, 0xC6, 0x6B, 0x4D);

        public static readonly Guid IID_SuspensionDependencyManager = new Guid(0x6B273FC5, 0x61FD, 0x4918, 0x95, 0xA2, 0xC3, 0xB5, 0xE9, 0xD7, 0xF5, 0x81);

        public static readonly Guid IID_ApplicationActivationManager = new Guid(0x45BA127D, 0x10A8, 0x46EA, 0x8A, 0xB7, 0x56, 0xEA, 0x90, 0x78, 0x94, 0x3C);

        public static readonly Guid IID_ApplicationDesignModeSettings = new Guid(0x958A6FB5, 0xDCB2, 0x4FAF, 0xAA, 0xFD, 0x7F, 0xB0, 0x54, 0xAD, 0x1A, 0x3B);

        public static readonly Guid IID_IAssocHandlerInvoker = new Guid(0x92218CAB, 0xECAA, 0x4335, 0x81, 0x33, 0x80, 0x7F, 0xD2, 0x34, 0xC2, 0xEE);

        public static readonly Guid IID_IAssocHandler = new Guid(0xF04061AC, 0x1659, 0x4A3F, 0xA9, 0x54, 0x77, 0x5A, 0xA5, 0x7F, 0xC0, 0x83);

        public static readonly Guid IID_IEnumAssocHandlers = new Guid(0x973810AE, 0x9599, 0x4B88, 0x9E, 0x4D, 0x6E, 0xE9, 0x8C, 0x95, 0x52, 0xDA);

        public static readonly Guid IID_IDataObjectProvider = new Guid(0x3D25F6D6, 0x4B2A, 0x433C, 0x91, 0x84, 0x7C, 0x33, 0xAD, 0x35, 0xD0, 0x01);

        public static readonly Guid IID_IDataTransferManagerInterop = new Guid(0x3A3DCD6C, 0x3EAB, 0x43DC, 0xBC, 0xDE, 0x45, 0x67, 0x1C, 0xE8, 0x00, 0xC8);

        public static readonly Guid IID_IFrameworkInputPaneHandler = new Guid(0x226C537B, 0x1E76, 0x4D9E, 0xA7, 0x60, 0x33, 0xDB, 0x29, 0x92, 0x2F, 0x18);

        public static readonly Guid IID_IFrameworkInputPane = new Guid(0x5752238B, 0x24F0, 0x495A, 0x82, 0xF1, 0x2F, 0xD5, 0x93, 0x05, 0x67, 0x96);

        public static readonly Guid IID_IAppVisibilityEvents = new Guid(0x6584CE6B, 0x7D82, 0x49C2, 0x89, 0xC9, 0xC6, 0xBC, 0x02, 0xBA, 0x8C, 0x38);

        public static readonly Guid IID_IAppVisibility = new Guid(0x2246EA2D, 0xCAEA, 0x4444, 0xA3, 0xC4, 0x6D, 0xE8, 0x27, 0xE4, 0x43, 0x13);

        public static readonly Guid IID_IPackageExecutionStateChangeNotification = new Guid(0x1BB12A62, 0x2AD8, 0x432B, 0x8C, 0xCF, 0x0C, 0x2C, 0x52, 0xAF, 0xCD, 0x5B);

        public static readonly Guid IID_IPackageDebugSettings = new Guid(0xF27C3930, 0x8029, 0x4AD1, 0x94, 0xE3, 0x3D, 0xBA, 0x41, 0x78, 0x10, 0xC1);

        public static readonly Guid IID_IPackageDebugSettings2 = new Guid(0x6E3194BB, 0xAB82, 0x4D22, 0x93, 0xF5, 0xFA, 0xBD, 0xA4, 0x0E, 0x7B, 0x16);

        public static readonly Guid IID_ISuspensionDependencyManager = new Guid(0x52B83A42, 0x2543, 0x416A, 0x81, 0xD9, 0xC0, 0xDE, 0x79, 0x69, 0xC8, 0xB3);

        public static readonly Guid IID_IExecuteCommandApplicationHostEnvironment = new Guid(0x18B21AA9, 0xE184, 0x4FF0, 0x9F, 0x5E, 0xF8, 0x82, 0xD0, 0x37, 0x71, 0xB3);

        public static readonly Guid IID_IExecuteCommandHost = new Guid(0x4B6832A2, 0x5F04, 0x4C9D, 0xB8, 0x9D, 0x72, 0x7A, 0x15, 0xD1, 0x03, 0xE7);

        public static readonly Guid IID_IApplicationDesignModeSettings = new Guid(0x2A3DEE9A, 0xE31D, 0x46D6, 0x85, 0x08, 0xBC, 0xC5, 0x97, 0xDB, 0x35, 0x57);

        public static readonly Guid IID_IApplicationDesignModeSettings2 = new Guid(0x490514E1, 0x675A, 0x4D6E, 0xA5, 0x8D, 0xE5, 0x49, 0x01, 0xB4, 0xCA, 0x2F);

        public static readonly Guid IID_ILaunchTargetMonitor = new Guid(0x266FBC7E, 0x490D, 0x46ED, 0xA9, 0x6B, 0x22, 0x74, 0xDB, 0x25, 0x20, 0x03);

        public static readonly Guid IID_ILaunchSourceViewSizePreference = new Guid(0xE5AA01F7, 0x1FB8, 0x4830, 0x87, 0x20, 0x4E, 0x67, 0x34, 0xCB, 0xD5, 0xF3);

        public static readonly Guid IID_ILaunchTargetViewSizePreference = new Guid(0x2F0666C6, 0x12F7, 0x4360, 0xB5, 0x11, 0xA3, 0x94, 0xA0, 0x55, 0x37, 0x25);

        public static readonly Guid IID_ILaunchSourceAppUserModelId = new Guid(0x989191AC, 0x28FF, 0x4CF0, 0x95, 0x84, 0xE0, 0xD0, 0x78, 0xBC, 0x23, 0x96);

        public static readonly Guid IID_IInitializeWithWindow = new Guid(0x3E68D4BD, 0x7135, 0x4D10, 0x80, 0x18, 0x9F, 0xB6, 0xD9, 0xF3, 0x3F, 0xA1);

        public static readonly Guid IID_IHandlerInfo = new Guid(0x997706EF, 0xF880, 0x453B, 0x81, 0x18, 0x39, 0xE1, 0xA2, 0xD2, 0x65, 0x5A);

        public static readonly Guid IID_IHandlerInfo2 = new Guid(0x31CCA04C, 0x04D3, 0x4EA9, 0x90, 0xDE, 0x97, 0xB1, 0x5E, 0x87, 0xA5, 0x32);

        public static readonly Guid IID_IHandlerActivationHost = new Guid(0x35094A87, 0x8BB1, 0x4237, 0x96, 0xC6, 0xC4, 0x17, 0xEE, 0xBD, 0xB0, 0x78);

        public static readonly Guid IID_IAppActivationUIInfo = new Guid(0xABAD189D, 0x9FA3, 0x4278, 0xB3, 0xCA, 0x8C, 0xA4, 0x48, 0xA8, 0x8D, 0xCB);

        public static readonly Guid IID_IContactManagerInterop = new Guid(0x99EACBA7, 0xE073, 0x43B6, 0xA8, 0x96, 0x55, 0xAF, 0xE4, 0x8A, 0x08, 0x33);

        public static readonly Guid IID_IShellIconOverlayIdentifier = new Guid(0x0C6C4200, 0xC589, 0x11D0, 0x99, 0x9A, 0x00, 0xC0, 0x4F, 0xD6, 0x55, 0xE1);

        public static readonly Guid IID_IBannerNotificationHandler = new Guid(0x8D7B2BA7, 0xDB05, 0x46A8, 0x82, 0x3C, 0xD2, 0xB6, 0xDE, 0x08, 0xEE, 0x91);

        public static readonly Guid IID_ISortColumnArray = new Guid(0x6DFC60FB, 0xF2E9, 0x459B, 0xBE, 0xB5, 0x28, 0x8F, 0x1A, 0x7C, 0x7D, 0x54);

        public static readonly Guid IID_IPropertyKeyStore = new Guid(0x75BD59AA, 0xF23B, 0x4963, 0xAB, 0xA4, 0x0B, 0x35, 0x57, 0x52, 0xA9, 0x1B);
    }
}
