// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using static TerraFX.Interop.Windows.CLSCTX;
using static TerraFX.Interop.Windows.SIGDN;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        public static HRESULT SHCreateLibrary([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return CoCreateInstance(__uuidof<ShellLibrary>(), null, (uint)(CLSCTX_INPROC_SERVER), riid, ppv);
        }

        public static HRESULT SHLoadLibraryFromItem(IShellItem* psiLibrary, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            *ppv = null;

            IShellLibrary* plib;
            var hr = CoCreateInstance(__uuidof<ShellLibrary>(), null, (uint)(CLSCTX_INPROC_SERVER), __uuidof<IShellLibrary>(), (void**)(&plib));

            if ((((int)(hr)) >= 0))
            {
                hr = plib->LoadLibraryFromItem(psiLibrary, grfMode);
                if ((((int)(hr)) >= 0))
                {
                    hr = plib->QueryInterface(riid, ppv);
                }

                _ = plib->Release();
            }

            return hr;
        }

        public static HRESULT SHLoadLibraryFromKnownFolder([NativeTypeName("const KNOWNFOLDERID &")] Guid* kfidLibrary, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            *ppv = null;

            IShellLibrary* plib;
            var hr = CoCreateInstance(__uuidof<ShellLibrary>(), null, (uint)(CLSCTX_INPROC_SERVER), __uuidof<IShellLibrary>(), (void**)(&plib));

            if ((((int)(hr)) >= 0))
            {
                hr = plib->LoadLibraryFromKnownFolder(kfidLibrary, grfMode);
                if ((((int)(hr)) >= 0))
                {
                    hr = plib->QueryInterface(riid, ppv);
                }

                _ = plib->Release();
            }

            return hr;
        }

        public static HRESULT SHLoadLibraryFromParsingName([NativeTypeName("PCWSTR")] ushort* pszParsingName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            *ppv = null;
            IShellItem* psiLibrary;
            HRESULT hr = SHCreateItemFromParsingName(pszParsingName, null, __uuidof<IShellItem>(), (void**)(&psiLibrary));

            if ((((int)(hr)) >= 0))
            {
                hr = SHLoadLibraryFromItem(psiLibrary, grfMode, riid, ppv);
                _ = psiLibrary->Release();
            }

            return hr;
        }

        public static HRESULT SHAddFolderPathToLibrary(IShellLibrary* plib, [NativeTypeName("PCWSTR")] ushort* pszFolderPath)
        {
            IShellItem* psiFolder;
            HRESULT hr = SHCreateItemFromParsingName(pszFolderPath, null, __uuidof<IShellItem>(), (void**)(&psiFolder));

            if ((((int)(hr)) >= 0))
            {
                hr = plib->AddFolder(psiFolder);
                _ = psiFolder->Release();
            }

            return hr;
        }

        public static HRESULT SHRemoveFolderPathFromLibrary(IShellLibrary* plib, [NativeTypeName("PCWSTR")] ushort* pszFolderPath)
        {
            ITEMIDLIST* pidlFolder = SHSimpleIDListFromPath(pszFolderPath);
            HRESULT hr = unchecked((pidlFolder) != null ? ((int)(0)) : ((int)(0x80070057)));

            if (((unchecked((int)(hr))) >= 0))
            {
                IShellItem* psiFolder;

                unchecked(hr) = SHCreateItemFromIDList(pidlFolder, __uuidof<IShellItem>(), (void**)(&psiFolder));
                if (((unchecked((int)(hr))) >= 0))
                {
                    unchecked(hr) = plib->RemoveFolder(psiFolder);
                    _ = psiFolder->Release();
                }

                CoTaskMemFree(pidlFolder);
            }

            return hr;
        }

        public static HRESULT SHSaveLibraryInFolderPath(IShellLibrary* plib, [NativeTypeName("PCWSTR")] ushort* pszFolderPath, [NativeTypeName("PCWSTR")] ushort* pszLibraryName, LIBRARYSAVEFLAGS lsf, [NativeTypeName("PWSTR *")] ushort** ppszSavedToPath)
        {
            if ((ppszSavedToPath) != null)
            {
                *ppszSavedToPath = null;
            }

            IShellItem* psiFolder;
            HRESULT hr = SHCreateItemFromParsingName(pszFolderPath, null, __uuidof<IShellItem>(), (void**)(&psiFolder));

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

                    _ = psiSavedTo->Release();
                }

                _ = psiFolder->Release();
            }

            return hr;
        }

        public static void SetContractDelegateWindow(HWND hwndSource, HWND hwndDelegate)
        {
            fixed (char* lpString = "ContractDelegate")
            {
                if (hwndDelegate != (nint)(0))
                {
                    _ = SetPropW(hwndSource, (ushort*)(lpString), (HANDLE)(hwndDelegate));
                }
                else
                {
                    _ = RemovePropW(hwndSource, (ushort*)(lpString));
                }
            }
        }
    }
}
