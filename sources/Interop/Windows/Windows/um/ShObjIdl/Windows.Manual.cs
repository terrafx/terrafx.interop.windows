// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.SIGDN;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    [return: NativeTypeName("#define ISDBLCLICK(x) (NSTCECT_DBLCLICK == ((x) & NSTCECT_DBLCLICK))")]
    public static bool ISDBLCLICK(NSTCECLICKTYPE x)
        => (x & NSTCECLICKTYPE.NSTCECT_DBLCLICK) == NSTCECLICKTYPE.NSTCECT_DBLCLICK;

    [return: NativeTypeName("#define ISLBUTTON(x) (NSTCECT_LBUTTON == ((x) & NSTCECT_BUTTON))")]
    public static bool ISLBUTTON(NSTCECLICKTYPE x)
        => (x & NSTCECLICKTYPE.NSTCECT_BUTTON) == NSTCECLICKTYPE.NSTCECT_LBUTTON;

    [return: NativeTypeName("#define ISMBUTTON(x) (NSTCECT_MBUTTON == ((x) & NSTCECT_BUTTON))")]
    public static bool ISMBUTTON(NSTCECLICKTYPE x)
        => (x & NSTCECLICKTYPE.NSTCECT_BUTTON) == NSTCECLICKTYPE.NSTCECT_MBUTTON;

    [return: NativeTypeName("#define ISRBUTTON(x) (NSTCECT_RBUTTON == ((x) & NSTCECT_BUTTON))")]
    public static bool ISRBUTTON(NSTCECLICKTYPE x)
        => (x & NSTCECLICKTYPE.NSTCECT_BUTTON) == NSTCECLICKTYPE.NSTCECT_RBUTTON;

    public static HRESULT SHResolveFolderPathInLibrary(IShellLibrary* plib, [NativeTypeName("PCWSTR")] char* pszFolderPath, [NativeTypeName("DWORD")] uint dwTimeout, [NativeTypeName("PWSTR *")] char** ppszResolvedPath)
    {
        *ppszResolvedPath = null;
        ITEMIDLIST* pidlFolder = SHSimpleIDListFromPath(pszFolderPath);
        HRESULT hr = unchecked((pidlFolder) != null ? ((int)(0)) : ((int)(0x80070057)));

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
                    _ = psiResolved->Release();
                }

                _ = psiFolder->Release();
            }

            CoTaskMemFree(pidlFolder);
        }

        return hr;
    }
}
