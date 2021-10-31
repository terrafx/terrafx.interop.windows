// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.CLSCTX;
using static TerraFX.Interop.SIGDN;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static HRESULT SHCreateLibrary([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            fixed (Guid* rclsid = &CLSID_ShellLibrary)
            {
                return CoCreateInstance(rclsid, null, (uint)(CLSCTX_INPROC_SERVER), riid, ppv);
            }
        }

        public static HRESULT SHLoadLibraryFromItem(IShellItem* psiLibrary, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            *ppv = null;
            IShellLibrary* plib;
            int hr;

            fixed (Guid* rclsid = &CLSID_ShellLibrary)
            {
                hr = CoCreateInstance(rclsid, null, (uint)(CLSCTX_INPROC_SERVER), __uuidof<IShellLibrary>(), (void**)(&plib));
            }

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

        public static HRESULT SHLoadLibraryFromKnownFolder([NativeTypeName("const KNOWNFOLDERID &")] Guid* kfidLibrary, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            *ppv = null;
            IShellLibrary* plib;
            int hr;

            fixed (Guid* rclsid = &CLSID_ShellLibrary)
            {
                hr = CoCreateInstance(rclsid, null, (uint)(CLSCTX_INPROC_SERVER), __uuidof<IShellLibrary>(), (void**)(&plib));
            }

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

        public static HRESULT SHLoadLibraryFromParsingName([NativeTypeName("PCWSTR")] ushort* pszParsingName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
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

        public static HRESULT SHAddFolderPathToLibrary(IShellLibrary* plib, [NativeTypeName("PCWSTR")] ushort* pszFolderPath)
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

        public static HRESULT SHRemoveFolderPathFromLibrary(IShellLibrary* plib, [NativeTypeName("PCWSTR")] ushort* pszFolderPath)
        {
            ITEMIDLIST* pidlFolder = SHSimpleIDListFromPath(pszFolderPath);
            int hr = unchecked((pidlFolder) != null ? ((int)(0)) : ((int)(0x80070057)));

            if (((unchecked((int)(hr))) >= 0))
            {
                IShellItem* psiFolder;

                unchecked(hr) = SHCreateItemFromIDList(pidlFolder, __uuidof<IShellItem>(), (void**)(&psiFolder));
                if (((unchecked((int)(hr))) >= 0))
                {
                    unchecked(hr) = plib->RemoveFolder(psiFolder);
                    psiFolder->Release();
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

        public static void SetContractDelegateWindow(HWND hwndSource, HWND hwndDelegate)
        {
            fixed (char* lpString = "ContractDelegate")
            {
                if (hwndDelegate != (nint)(0))
                {
                    SetPropW(hwndSource, (ushort*)(lpString), (HANDLE)(hwndDelegate));
                }
                else
                {
                    RemovePropW(hwndSource, (ushort*)(lpString));
                }
            }
        }

        public static ref readonly Guid CLSID_ShellLibrary
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x1D, 0x21, 0xB3, 0xD9,
                    0x7F, 0xE5,
                    0x26, 0x44,
                    0xAA,
                    0xEF,
                    0x30,
                    0xA8,
                    0x06,
                    0xAD,
                    0xD3,
                    0x97
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
