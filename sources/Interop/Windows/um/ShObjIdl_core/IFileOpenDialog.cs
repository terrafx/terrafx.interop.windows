// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D57C7288-D4AD-4768-BE02-9D969532D960")]
    [NativeTypeName("struct IFileOpenDialog : IFileDialog")]
    public unsafe partial struct IFileOpenDialog
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, Guid*, void**, int>)(lpVtbl[0]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFileOpenDialog*, uint>)(lpVtbl[1]))((IFileOpenDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFileOpenDialog*, uint>)(lpVtbl[2]))((IFileOpenDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Show([NativeTypeName("HWND")] IntPtr hwndOwner)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, IntPtr, int>)(lpVtbl[3]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), hwndOwner);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFileTypes([NativeTypeName("UINT")] uint cFileTypes, [NativeTypeName("const COMDLG_FILTERSPEC *")] COMDLG_FILTERSPEC* rgFilterSpec)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, uint, COMDLG_FILTERSPEC*, int>)(lpVtbl[4]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), cFileTypes, rgFilterSpec);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFileTypeIndex([NativeTypeName("UINT")] uint iFileType)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, uint, int>)(lpVtbl[5]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), iFileType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFileTypeIndex([NativeTypeName("UINT *")] uint* piFileType)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, uint*, int>)(lpVtbl[6]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), piFileType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Advise(IFileDialogEvents* pfde, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, IFileDialogEvents*, uint*, int>)(lpVtbl[7]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), pfde, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Unadvise([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, uint, int>)(lpVtbl[8]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOptions([NativeTypeName("FILEOPENDIALOGOPTIONS")] uint fos)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, uint, int>)(lpVtbl[9]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), fos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOptions([NativeTypeName("FILEOPENDIALOGOPTIONS *")] uint* pfos)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, uint*, int>)(lpVtbl[10]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), pfos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDefaultFolder(IShellItem* psi)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, IShellItem*, int>)(lpVtbl[11]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFolder(IShellItem* psi)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, IShellItem*, int>)(lpVtbl[12]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFolder(IShellItem** ppsi)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, IShellItem**, int>)(lpVtbl[13]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), ppsi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentSelection(IShellItem** ppsi)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, IShellItem**, int>)(lpVtbl[14]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), ppsi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFileName([NativeTypeName("LPCWSTR")] ushort* pszName)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, ushort*, int>)(lpVtbl[15]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), pszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFileName([NativeTypeName("LPWSTR *")] ushort** pszName)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, ushort**, int>)(lpVtbl[16]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), pszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetTitle([NativeTypeName("LPCWSTR")] ushort* pszTitle)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, ushort*, int>)(lpVtbl[17]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), pszTitle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetOkButtonLabel([NativeTypeName("LPCWSTR")] ushort* pszText)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, ushort*, int>)(lpVtbl[18]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), pszText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFileNameLabel([NativeTypeName("LPCWSTR")] ushort* pszLabel)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, ushort*, int>)(lpVtbl[19]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), pszLabel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResult(IShellItem** ppsi)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, IShellItem**, int>)(lpVtbl[20]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), ppsi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddPlace(IShellItem* psi, FDAP fdap)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, IShellItem*, FDAP, int>)(lpVtbl[21]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), psi, fdap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDefaultExtension([NativeTypeName("LPCWSTR")] ushort* pszDefaultExtension)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, ushort*, int>)(lpVtbl[22]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), pszDefaultExtension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Close([NativeTypeName("HRESULT")] int hr)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, int, int>)(lpVtbl[23]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), hr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetClientGuid([NativeTypeName("const GUID &")] Guid* guid)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, Guid*, int>)(lpVtbl[24]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), guid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ClearClientData()
        {
            return ((delegate* unmanaged<IFileOpenDialog*, int>)(lpVtbl[25]))((IFileOpenDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFilter(IShellItemFilter* pFilter)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, IShellItemFilter*, int>)(lpVtbl[26]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), pFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetResults(IShellItemArray** ppenum)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, IShellItemArray**, int>)(lpVtbl[27]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), ppenum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSelectedItems(IShellItemArray** ppsai)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, IShellItemArray**, int>)(lpVtbl[28]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), ppsai);
        }
    }
}
