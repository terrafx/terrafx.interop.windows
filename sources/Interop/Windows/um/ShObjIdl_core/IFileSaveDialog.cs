// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("84BCCD23-5FDE-4CDB-AEA4-AF64B83D78AB")]
    [NativeTypeName("struct IFileSaveDialog : IFileDialog")]
    [NativeInheritance("IFileDialog")]
    public unsafe partial struct IFileSaveDialog
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, Guid*, void**, int>)(lpVtbl[0]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFileSaveDialog*, uint>)(lpVtbl[1]))((IFileSaveDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFileSaveDialog*, uint>)(lpVtbl[2]))((IFileSaveDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Show([NativeTypeName("HWND")] IntPtr hwndOwner)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, IntPtr, int>)(lpVtbl[3]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), hwndOwner);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetFileTypes([NativeTypeName("UINT")] uint cFileTypes, [NativeTypeName("const COMDLG_FILTERSPEC *")] COMDLG_FILTERSPEC* rgFilterSpec)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, uint, COMDLG_FILTERSPEC*, int>)(lpVtbl[4]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), cFileTypes, rgFilterSpec);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetFileTypeIndex([NativeTypeName("UINT")] uint iFileType)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, uint, int>)(lpVtbl[5]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), iFileType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetFileTypeIndex([NativeTypeName("UINT *")] uint* piFileType)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, uint*, int>)(lpVtbl[6]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), piFileType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT Advise(IFileDialogEvents* pfde, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, IFileDialogEvents*, uint*, int>)(lpVtbl[7]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), pfde, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, uint, int>)(lpVtbl[8]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetOptions([NativeTypeName("FILEOPENDIALOGOPTIONS")] uint fos)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, uint, int>)(lpVtbl[9]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), fos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetOptions([NativeTypeName("FILEOPENDIALOGOPTIONS *")] uint* pfos)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, uint*, int>)(lpVtbl[10]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), pfos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetDefaultFolder(IShellItem* psi)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, IShellItem*, int>)(lpVtbl[11]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetFolder(IShellItem* psi)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, IShellItem*, int>)(lpVtbl[12]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetFolder(IShellItem** ppsi)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, IShellItem**, int>)(lpVtbl[13]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), ppsi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetCurrentSelection(IShellItem** ppsi)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, IShellItem**, int>)(lpVtbl[14]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), ppsi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SetFileName([NativeTypeName("LPCWSTR")] ushort* pszName)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, ushort*, int>)(lpVtbl[15]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), pszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetFileName([NativeTypeName("LPWSTR *")] ushort** pszName)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, ushort**, int>)(lpVtbl[16]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), pszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT SetTitle([NativeTypeName("LPCWSTR")] ushort* pszTitle)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, ushort*, int>)(lpVtbl[17]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), pszTitle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT SetOkButtonLabel([NativeTypeName("LPCWSTR")] ushort* pszText)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, ushort*, int>)(lpVtbl[18]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), pszText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT SetFileNameLabel([NativeTypeName("LPCWSTR")] ushort* pszLabel)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, ushort*, int>)(lpVtbl[19]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), pszLabel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT GetResult(IShellItem** ppsi)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, IShellItem**, int>)(lpVtbl[20]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), ppsi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT AddPlace(IShellItem* psi, FDAP fdap)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, IShellItem*, FDAP, int>)(lpVtbl[21]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), psi, fdap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT SetDefaultExtension([NativeTypeName("LPCWSTR")] ushort* pszDefaultExtension)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, ushort*, int>)(lpVtbl[22]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), pszDefaultExtension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT Close(HRESULT hr)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, HRESULT, int>)(lpVtbl[23]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), hr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT SetClientGuid([NativeTypeName("const GUID &")] Guid* guid)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, Guid*, int>)(lpVtbl[24]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), guid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT ClearClientData()
        {
            return ((delegate* unmanaged<IFileSaveDialog*, int>)(lpVtbl[25]))((IFileSaveDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT SetFilter(IShellItemFilter* pFilter)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, IShellItemFilter*, int>)(lpVtbl[26]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), pFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT SetSaveAsItem(IShellItem* psi)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, IShellItem*, int>)(lpVtbl[27]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT SetProperties(IPropertyStore* pStore)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, IPropertyStore*, int>)(lpVtbl[28]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), pStore);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT SetCollectedProperties(IPropertyDescriptionList* pList, BOOL fAppendDefault)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, IPropertyDescriptionList*, BOOL, int>)(lpVtbl[29]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), pList, fAppendDefault);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT GetProperties(IPropertyStore** ppStore)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, IPropertyStore**, int>)(lpVtbl[30]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), ppStore);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT ApplyProperties(IShellItem* psi, IPropertyStore* pStore, [NativeTypeName("HWND")] IntPtr hwnd, IFileOperationProgressSink* pSink)
        {
            return ((delegate* unmanaged<IFileSaveDialog*, IShellItem*, IPropertyStore*, IntPtr, IFileOperationProgressSink*, int>)(lpVtbl[31]))((IFileSaveDialog*)Unsafe.AsPointer(ref this), psi, pStore, hwnd, pSink);
        }
    }
}
