// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000214EE-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IShellLinkA : IUnknown")]
    public unsafe partial struct IShellLinkA
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellLinkA*, Guid*, void**, int>)(lpVtbl[0]))((IShellLinkA*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellLinkA*, uint>)(lpVtbl[1]))((IShellLinkA*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellLinkA*, uint>)(lpVtbl[2]))((IShellLinkA*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPath([NativeTypeName("LPSTR")] sbyte* pszFile, int cch, WIN32_FIND_DATAA* pfd, [NativeTypeName("DWORD")] uint fFlags)
        {
            return ((delegate* unmanaged<IShellLinkA*, sbyte*, int, WIN32_FIND_DATAA*, uint, int>)(lpVtbl[3]))((IShellLinkA*)Unsafe.AsPointer(ref this), pszFile, cch, pfd, fFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDList([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
        {
            return ((delegate* unmanaged<IShellLinkA*, ITEMIDLIST**, int>)(lpVtbl[4]))((IShellLinkA*)Unsafe.AsPointer(ref this), ppidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
        {
            return ((delegate* unmanaged<IShellLinkA*, ITEMIDLIST*, int>)(lpVtbl[5]))((IShellLinkA*)Unsafe.AsPointer(ref this), pidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDescription([NativeTypeName("LPSTR")] sbyte* pszName, int cch)
        {
            return ((delegate* unmanaged<IShellLinkA*, sbyte*, int, int>)(lpVtbl[6]))((IShellLinkA*)Unsafe.AsPointer(ref this), pszName, cch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDescription([NativeTypeName("LPCSTR")] sbyte* pszName)
        {
            return ((delegate* unmanaged<IShellLinkA*, sbyte*, int>)(lpVtbl[7]))((IShellLinkA*)Unsafe.AsPointer(ref this), pszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWorkingDirectory([NativeTypeName("LPSTR")] sbyte* pszDir, int cch)
        {
            return ((delegate* unmanaged<IShellLinkA*, sbyte*, int, int>)(lpVtbl[8]))((IShellLinkA*)Unsafe.AsPointer(ref this), pszDir, cch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetWorkingDirectory([NativeTypeName("LPCSTR")] sbyte* pszDir)
        {
            return ((delegate* unmanaged<IShellLinkA*, sbyte*, int>)(lpVtbl[9]))((IShellLinkA*)Unsafe.AsPointer(ref this), pszDir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetArguments([NativeTypeName("LPSTR")] sbyte* pszArgs, int cch)
        {
            return ((delegate* unmanaged<IShellLinkA*, sbyte*, int, int>)(lpVtbl[10]))((IShellLinkA*)Unsafe.AsPointer(ref this), pszArgs, cch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetArguments([NativeTypeName("LPCSTR")] sbyte* pszArgs)
        {
            return ((delegate* unmanaged<IShellLinkA*, sbyte*, int>)(lpVtbl[11]))((IShellLinkA*)Unsafe.AsPointer(ref this), pszArgs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetHotkey([NativeTypeName("WORD *")] ushort* pwHotkey)
        {
            return ((delegate* unmanaged<IShellLinkA*, ushort*, int>)(lpVtbl[12]))((IShellLinkA*)Unsafe.AsPointer(ref this), pwHotkey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetHotkey([NativeTypeName("WORD")] ushort wHotkey)
        {
            return ((delegate* unmanaged<IShellLinkA*, ushort, int>)(lpVtbl[13]))((IShellLinkA*)Unsafe.AsPointer(ref this), wHotkey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetShowCmd(int* piShowCmd)
        {
            return ((delegate* unmanaged<IShellLinkA*, int*, int>)(lpVtbl[14]))((IShellLinkA*)Unsafe.AsPointer(ref this), piShowCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetShowCmd(int iShowCmd)
        {
            return ((delegate* unmanaged<IShellLinkA*, int, int>)(lpVtbl[15]))((IShellLinkA*)Unsafe.AsPointer(ref this), iShowCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIconLocation([NativeTypeName("LPSTR")] sbyte* pszIconPath, int cch, int* piIcon)
        {
            return ((delegate* unmanaged<IShellLinkA*, sbyte*, int, int*, int>)(lpVtbl[16]))((IShellLinkA*)Unsafe.AsPointer(ref this), pszIconPath, cch, piIcon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetIconLocation([NativeTypeName("LPCSTR")] sbyte* pszIconPath, int iIcon)
        {
            return ((delegate* unmanaged<IShellLinkA*, sbyte*, int, int>)(lpVtbl[17]))((IShellLinkA*)Unsafe.AsPointer(ref this), pszIconPath, iIcon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRelativePath([NativeTypeName("LPCSTR")] sbyte* pszPathRel, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<IShellLinkA*, sbyte*, uint, int>)(lpVtbl[18]))((IShellLinkA*)Unsafe.AsPointer(ref this), pszPathRel, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Resolve([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("DWORD")] uint fFlags)
        {
            return ((delegate* unmanaged<IShellLinkA*, IntPtr, uint, int>)(lpVtbl[19]))((IShellLinkA*)Unsafe.AsPointer(ref this), hwnd, fFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetPath([NativeTypeName("LPCSTR")] sbyte* pszFile)
        {
            return ((delegate* unmanaged<IShellLinkA*, sbyte*, int>)(lpVtbl[20]))((IShellLinkA*)Unsafe.AsPointer(ref this), pszFile);
        }
    }
}
