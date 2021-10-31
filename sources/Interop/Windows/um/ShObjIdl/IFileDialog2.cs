// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("61744FC7-85B5-4791-A9B0-272276309B13")]
    [NativeTypeName("struct IFileDialog2 : IFileDialog")]
    [NativeInheritance("IFileDialog")]
    public unsafe partial struct IFileDialog2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFileDialog2*, Guid*, void**, int>)(lpVtbl[0]))((IFileDialog2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFileDialog2*, uint>)(lpVtbl[1]))((IFileDialog2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFileDialog2*, uint>)(lpVtbl[2]))((IFileDialog2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Show(HWND hwndOwner)
        {
            return ((delegate* unmanaged<IFileDialog2*, HWND, int>)(lpVtbl[3]))((IFileDialog2*)Unsafe.AsPointer(ref this), hwndOwner);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetFileTypes([NativeTypeName("UINT")] uint cFileTypes, [NativeTypeName("const COMDLG_FILTERSPEC *")] COMDLG_FILTERSPEC* rgFilterSpec)
        {
            return ((delegate* unmanaged<IFileDialog2*, uint, COMDLG_FILTERSPEC*, int>)(lpVtbl[4]))((IFileDialog2*)Unsafe.AsPointer(ref this), cFileTypes, rgFilterSpec);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetFileTypeIndex([NativeTypeName("UINT")] uint iFileType)
        {
            return ((delegate* unmanaged<IFileDialog2*, uint, int>)(lpVtbl[5]))((IFileDialog2*)Unsafe.AsPointer(ref this), iFileType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetFileTypeIndex([NativeTypeName("UINT *")] uint* piFileType)
        {
            return ((delegate* unmanaged<IFileDialog2*, uint*, int>)(lpVtbl[6]))((IFileDialog2*)Unsafe.AsPointer(ref this), piFileType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT Advise(IFileDialogEvents* pfde, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<IFileDialog2*, IFileDialogEvents*, uint*, int>)(lpVtbl[7]))((IFileDialog2*)Unsafe.AsPointer(ref this), pfde, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<IFileDialog2*, uint, int>)(lpVtbl[8]))((IFileDialog2*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetOptions([NativeTypeName("FILEOPENDIALOGOPTIONS")] uint fos)
        {
            return ((delegate* unmanaged<IFileDialog2*, uint, int>)(lpVtbl[9]))((IFileDialog2*)Unsafe.AsPointer(ref this), fos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetOptions([NativeTypeName("FILEOPENDIALOGOPTIONS *")] uint* pfos)
        {
            return ((delegate* unmanaged<IFileDialog2*, uint*, int>)(lpVtbl[10]))((IFileDialog2*)Unsafe.AsPointer(ref this), pfos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetDefaultFolder(IShellItem* psi)
        {
            return ((delegate* unmanaged<IFileDialog2*, IShellItem*, int>)(lpVtbl[11]))((IFileDialog2*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetFolder(IShellItem* psi)
        {
            return ((delegate* unmanaged<IFileDialog2*, IShellItem*, int>)(lpVtbl[12]))((IFileDialog2*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetFolder(IShellItem** ppsi)
        {
            return ((delegate* unmanaged<IFileDialog2*, IShellItem**, int>)(lpVtbl[13]))((IFileDialog2*)Unsafe.AsPointer(ref this), ppsi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetCurrentSelection(IShellItem** ppsi)
        {
            return ((delegate* unmanaged<IFileDialog2*, IShellItem**, int>)(lpVtbl[14]))((IFileDialog2*)Unsafe.AsPointer(ref this), ppsi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SetFileName([NativeTypeName("LPCWSTR")] ushort* pszName)
        {
            return ((delegate* unmanaged<IFileDialog2*, ushort*, int>)(lpVtbl[15]))((IFileDialog2*)Unsafe.AsPointer(ref this), pszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetFileName([NativeTypeName("LPWSTR *")] ushort** pszName)
        {
            return ((delegate* unmanaged<IFileDialog2*, ushort**, int>)(lpVtbl[16]))((IFileDialog2*)Unsafe.AsPointer(ref this), pszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT SetTitle([NativeTypeName("LPCWSTR")] ushort* pszTitle)
        {
            return ((delegate* unmanaged<IFileDialog2*, ushort*, int>)(lpVtbl[17]))((IFileDialog2*)Unsafe.AsPointer(ref this), pszTitle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT SetOkButtonLabel([NativeTypeName("LPCWSTR")] ushort* pszText)
        {
            return ((delegate* unmanaged<IFileDialog2*, ushort*, int>)(lpVtbl[18]))((IFileDialog2*)Unsafe.AsPointer(ref this), pszText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT SetFileNameLabel([NativeTypeName("LPCWSTR")] ushort* pszLabel)
        {
            return ((delegate* unmanaged<IFileDialog2*, ushort*, int>)(lpVtbl[19]))((IFileDialog2*)Unsafe.AsPointer(ref this), pszLabel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT GetResult(IShellItem** ppsi)
        {
            return ((delegate* unmanaged<IFileDialog2*, IShellItem**, int>)(lpVtbl[20]))((IFileDialog2*)Unsafe.AsPointer(ref this), ppsi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT AddPlace(IShellItem* psi, FDAP fdap)
        {
            return ((delegate* unmanaged<IFileDialog2*, IShellItem*, FDAP, int>)(lpVtbl[21]))((IFileDialog2*)Unsafe.AsPointer(ref this), psi, fdap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT SetDefaultExtension([NativeTypeName("LPCWSTR")] ushort* pszDefaultExtension)
        {
            return ((delegate* unmanaged<IFileDialog2*, ushort*, int>)(lpVtbl[22]))((IFileDialog2*)Unsafe.AsPointer(ref this), pszDefaultExtension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT Close(HRESULT hr)
        {
            return ((delegate* unmanaged<IFileDialog2*, HRESULT, int>)(lpVtbl[23]))((IFileDialog2*)Unsafe.AsPointer(ref this), hr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT SetClientGuid([NativeTypeName("const GUID &")] Guid* guid)
        {
            return ((delegate* unmanaged<IFileDialog2*, Guid*, int>)(lpVtbl[24]))((IFileDialog2*)Unsafe.AsPointer(ref this), guid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT ClearClientData()
        {
            return ((delegate* unmanaged<IFileDialog2*, int>)(lpVtbl[25]))((IFileDialog2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT SetFilter(IShellItemFilter* pFilter)
        {
            return ((delegate* unmanaged<IFileDialog2*, IShellItemFilter*, int>)(lpVtbl[26]))((IFileDialog2*)Unsafe.AsPointer(ref this), pFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT SetCancelButtonLabel([NativeTypeName("LPCWSTR")] ushort* pszLabel)
        {
            return ((delegate* unmanaged<IFileDialog2*, ushort*, int>)(lpVtbl[27]))((IFileDialog2*)Unsafe.AsPointer(ref this), pszLabel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT SetNavigationRoot(IShellItem* psi)
        {
            return ((delegate* unmanaged<IFileDialog2*, IShellItem*, int>)(lpVtbl[28]))((IFileDialog2*)Unsafe.AsPointer(ref this), psi);
        }
    }
}
