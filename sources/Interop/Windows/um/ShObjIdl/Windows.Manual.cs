// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.SIGDN;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static HRESULT SHResolveFolderPathInLibrary(IShellLibrary* plib, [NativeTypeName("PCWSTR")] ushort* pszFolderPath, [NativeTypeName("DWORD")] uint dwTimeout, [NativeTypeName("PWSTR *")] ushort** ppszResolvedPath)
        {
            *ppszResolvedPath = null;
            ITEMIDLIST* pidlFolder = SHSimpleIDListFromPath(pszFolderPath);
            int hr = unchecked((pidlFolder) != null ? ((int)(0)) : ((int)(0x80070057)));

            if (((unchecked((int)(hr))) >= 0))
            {
                IShellItem* psiFolder;

                hr = SHCreateItemFromIDList(pidlFolder, __uuidof<IShellItem>(), (void**)(&psiFolder));
                if (((unchecked((int)(hr))) >= 0))
                {
                    IShellItem* psiResolved;

                    hr = plib->ResolveFolder(psiFolder, dwTimeout, __uuidof<IShellItem>(), (void**)(&psiResolved));
                    if (((unchecked((int)(hr))) >= 0))
                    {
                        unchecked(hr) = psiResolved->GetDisplayName(SIGDN_DESKTOPABSOLUTEPARSING, ppszResolvedPath);
                        psiResolved->Release();
                    }

                    psiFolder->Release();
                }

                CoTaskMemFree(pidlFolder);
            }

            return hr;
        }

        public static ref readonly Guid CLSID_PublishingWizard
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3C, 0x16, 0x33, 0x6B,
                    0xA5, 0x76,
                    0x6C, 0x4B,
                    0xBF,
                    0x21,
                    0x45,
                    0xDE,
                    0x9C,
                    0xD5,
                    0x03,
                    0xA1
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
