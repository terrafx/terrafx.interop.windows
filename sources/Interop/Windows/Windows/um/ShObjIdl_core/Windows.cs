// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [DllImport("shell32", ExactSpelling = true)]
        [return: NativeTypeName("LPITEMIDLIST")]
        public static extern ITEMIDLIST* SHSimpleIDListFromPath([NativeTypeName("PCWSTR")] ushort* pszPath);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHCreateItemFromIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHCreateItemFromParsingName([NativeTypeName("PCWSTR")] ushort* pszPath, IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHCreateItemWithParent([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlParent, IShellFolder* psfParent, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("const IID &")] Guid* riid, void** ppvItem);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHCreateItemFromRelativeName(IShellItem* psiParent, [NativeTypeName("PCWSTR")] ushort* pszName, IBindCtx* pbc, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHCreateItemInKnownFolder([NativeTypeName("const KNOWNFOLDERID &")] Guid* kfid, [NativeTypeName("DWORD")] uint dwKFFlags, [NativeTypeName("PCWSTR")] ushort* pszItem, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHGetIDListFromObject(IUnknown* punk, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHGetItemFromObject(IUnknown* punk, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHGetPropertyStoreFromIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, GETPROPERTYSTOREFLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHGetPropertyStoreFromParsingName([NativeTypeName("PCWSTR")] ushort* pszPath, IBindCtx* pbc, GETPROPERTYSTOREFLAGS flags, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHGetNameFromIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, SIGDN sigdnName, [NativeTypeName("PWSTR *")] ushort** ppszName);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHGetItemFromDataObject(IDataObject* pdtobj, DATAOBJ_GET_ITEM_FLAGS dwFlags, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHCreateShellItemArray([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlParent, IShellFolder* psf, uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** ppidl, IShellItemArray** ppsiItemArray);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHCreateShellItemArrayFromDataObject(IDataObject* pdo, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHCreateShellItemArrayFromIDLists(uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** rgpidl, IShellItemArray** ppsiItemArray);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHCreateShellItemArrayFromShellItem(IShellItem* psi, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        public static void FreeIDListArray([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidls, uint cItems)
        {
            uint i;

            for (i = 0; i < cItems; i++)
            {
                CoTaskMemFree(ppidls[i]);
            }

            CoTaskMemFree(ppidls);
        }

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHCreateAssociationRegistration([NativeTypeName("const IID &")] Guid* riid, void** ppv);

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

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHCreateDefaultExtractIcon([NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SetCurrentProcessExplicitAppUserModelID([NativeTypeName("PCWSTR")] ushort* AppID);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT GetCurrentProcessExplicitAppUserModelID([NativeTypeName("PWSTR *")] ushort** AppID);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHGetTemporaryPropertyForItem(IShellItem* psi, [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, PROPVARIANT* ppropvar);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHSetTemporaryPropertyForItem(IShellItem* psi, [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHShowManageLibraryUI(IShellItem* psiLibrary, HWND hwndOwner, [NativeTypeName("LPCWSTR")] ushort* pszTitle, [NativeTypeName("LPCWSTR")] ushort* pszInstruction, LIBRARYMANAGEDIALOGOPTIONS lmdOptions);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHResolveLibrary(IShellItem* psiLibrary);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHAssocEnumHandlers([NativeTypeName("PCWSTR")] ushort* pszExtra, ASSOC_FILTER afFilter, IEnumAssocHandlers** ppEnumHandler);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHAssocEnumHandlersForProtocolByApplication([NativeTypeName("PCWSTR")] ushort* protocol, [NativeTypeName("const IID &")] Guid* riid, void** enumHandlers);

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SID_URLExecutionContext
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBC, 0x8E, 0x5F, 0xFB,
                    0xB6, 0xBB,
                    0x10, 0x4D,
                    0xA4,
                    0x61,
                    0x77,
                    0x72,
                    0x91,
                    0xA0,
                    0x90,
                    0x30
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SID_LaunchSourceViewSizePreference
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x92, 0x54, 0x60, 0x80,
                    0xD9, 0x67,
                    0x4F, 0x41,
                    0xAF,
                    0x89,
                    0xA1,
                    0xCD,
                    0xF1,
                    0x24,
                    0x2B,
                    0xC1
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SID_LaunchTargetViewSizePreference
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x72, 0x24, 0xDB, 0x26,
                    0xB7, 0xB7,
                    0x6B, 0x40,
                    0x97,
                    0x02,
                    0x73,
                    0x0A,
                    0x4E,
                    0x20,
                    0xD3,
                    0xBF
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SID_LaunchSourceAppUserModelId
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x10, 0x80, 0xE7, 0x2C,
                    0xDB, 0x74,
                    0xBC, 0x48,
                    0x9C,
                    0x6A,
                    0x10,
                    0xF3,
                    0x72,
                    0x49,
                    0x57,
                    0x23
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SID_ShellExecuteNamedPropertyStore
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA2, 0xAD, 0x84, 0xEB,
                    0xFF, 0x00,
                    0x92, 0x49,
                    0x83,
                    0x24,
                    0xED,
                    0x5C,
                    0xE0,
                    0x61,
                    0xCB,
                    0x29
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

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
        public static nuint ITSAT_DEFAULT_LPARAM => unchecked((nuint)(-1));

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
        public static ref readonly Guid SID_ShellTaskScheduler => ref IID_IShellTaskScheduler;

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
        public static ref readonly Guid SID_SFolderView => ref IID_IFolderView;

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
        public static ref readonly Guid SID_SExplorerBrowserFrame => ref IID_ICommDlgBrowser;

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
        public static ref readonly Guid SID_SProfferService => ref IID_IProfferService;

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
        public static ref readonly Guid CGID_DeskBand => ref IID_IDeskBand;

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
        public static delegate*<ITEMIDLIST**, uint, void> FreeIDListArrayFull => &FreeIDListArray;

        [NativeTypeName("#define FreeIDListArrayChild FreeIDListArray")]
        public static delegate*<ITEMIDLIST**, uint, void> FreeIDListArrayChild => &FreeIDListArray;

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
        public static ref readonly Guid SID_SBandSite => ref IID_IBandSite;

        [NativeTypeName("#define CGID_BandSite IID_IBandSite")]
        public static ref readonly Guid CGID_BandSite => ref IID_IBandSite;

        [NativeTypeName("#define OF_CAP_CANSWITCHTO 0x0001")]
        public const int OF_CAP_CANSWITCHTO = 0x0001;

        [NativeTypeName("#define OF_CAP_CANCLOSE 0x0002")]
        public const int OF_CAP_CANCLOSE = 0x0002;

        [NativeTypeName("#define SID_SNewWindowManager IID_INewWindowManager")]
        public static ref readonly Guid SID_SNewWindowManager => ref IID_INewWindowManager;

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

        [NativeTypeName("#define SID_SNewMenuClient IID_INewMenuClient")]
        public static ref readonly Guid SID_SNewMenuClient => ref IID_INewMenuClient;

        [NativeTypeName("#define SID_SNavigationPane IID_INameSpaceTreeControl")]
        public static ref readonly Guid SID_SNavigationPane => ref IID_INameSpaceTreeControl;

        [NativeTypeName("#define SID_ExplorerPaneVisibility IID_IExplorerPaneVisibility")]
        public static ref readonly Guid SID_ExplorerPaneVisibility => ref IID_IExplorerPaneVisibility;

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
        public static ref readonly Guid SID_ExecuteCommandHost => ref IID_IExecuteCommandHost;

        [NativeTypeName("#define STR_TAB_REUSE_IDENTIFIER L\"Tab Reuse Identifier\"")]
        public const string STR_TAB_REUSE_IDENTIFIER = "Tab Reuse Identifier";

        [NativeTypeName("#define STR_REFERRER_IDENTIFIER L\"Referrer Identifier\"")]
        public const string STR_REFERRER_IDENTIFIER = "Referrer Identifier";

        [NativeTypeName("#define SID_HandlerInfo IID_IHandlerInfo")]
        public static ref readonly Guid SID_HandlerInfo => ref IID_IHandlerInfo;

        [NativeTypeName("#define SID_SHandlerActivationHost IID_IHandlerActivationHost")]
        public static ref readonly Guid SID_SHandlerActivationHost => ref IID_IHandlerActivationHost;

        [NativeTypeName("#define SID_AppActivationUIInfo IID_IAppActivationUIInfo")]
        public static ref readonly Guid SID_AppActivationUIInfo => ref IID_IAppActivationUIInfo;

        [NativeTypeName("#define ISIOI_ICONFILE 0x00000001")]
        public const int ISIOI_ICONFILE = 0x00000001;

        [NativeTypeName("#define ISIOI_ICONINDEX 0x00000002")]
        public const int ISIOI_ICONINDEX = 0x00000002;
    }
}
