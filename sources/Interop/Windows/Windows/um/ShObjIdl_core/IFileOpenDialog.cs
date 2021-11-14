// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("D57C7288-D4AD-4768-BE02-9D969532D960")]
    [NativeTypeName("struct IFileOpenDialog : IFileDialog")]
    [NativeInheritance("IFileDialog")]
    public unsafe partial struct IFileOpenDialog : IFileOpenDialog.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, Guid*, void**, int>)(lpVtbl[0]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFileOpenDialog*, uint>)(lpVtbl[1]))((IFileOpenDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFileOpenDialog*, uint>)(lpVtbl[2]))((IFileOpenDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Show(HWND hwndOwner)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, HWND, int>)(lpVtbl[3]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), hwndOwner);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetFileTypes(uint cFileTypes, [NativeTypeName("const COMDLG_FILTERSPEC *")] COMDLG_FILTERSPEC* rgFilterSpec)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, uint, COMDLG_FILTERSPEC*, int>)(lpVtbl[4]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), cFileTypes, rgFilterSpec);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetFileTypeIndex(uint iFileType)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, uint, int>)(lpVtbl[5]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), iFileType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetFileTypeIndex(uint* piFileType)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, uint*, int>)(lpVtbl[6]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), piFileType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT Advise(IFileDialogEvents* pfde, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, IFileDialogEvents*, uint*, int>)(lpVtbl[7]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), pfde, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, uint, int>)(lpVtbl[8]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetOptions([NativeTypeName("FILEOPENDIALOGOPTIONS")] uint fos)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, uint, int>)(lpVtbl[9]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), fos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetOptions([NativeTypeName("FILEOPENDIALOGOPTIONS *")] uint* pfos)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, uint*, int>)(lpVtbl[10]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), pfos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetDefaultFolder(IShellItem* psi)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, IShellItem*, int>)(lpVtbl[11]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetFolder(IShellItem* psi)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, IShellItem*, int>)(lpVtbl[12]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), psi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetFolder(IShellItem** ppsi)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, IShellItem**, int>)(lpVtbl[13]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), ppsi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetCurrentSelection(IShellItem** ppsi)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, IShellItem**, int>)(lpVtbl[14]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), ppsi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SetFileName([NativeTypeName("LPCWSTR")] ushort* pszName)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, ushort*, int>)(lpVtbl[15]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), pszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetFileName([NativeTypeName("LPWSTR *")] ushort** pszName)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, ushort**, int>)(lpVtbl[16]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), pszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT SetTitle([NativeTypeName("LPCWSTR")] ushort* pszTitle)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, ushort*, int>)(lpVtbl[17]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), pszTitle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT SetOkButtonLabel([NativeTypeName("LPCWSTR")] ushort* pszText)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, ushort*, int>)(lpVtbl[18]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), pszText);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT SetFileNameLabel([NativeTypeName("LPCWSTR")] ushort* pszLabel)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, ushort*, int>)(lpVtbl[19]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), pszLabel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT GetResult(IShellItem** ppsi)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, IShellItem**, int>)(lpVtbl[20]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), ppsi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT AddPlace(IShellItem* psi, FDAP fdap)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, IShellItem*, FDAP, int>)(lpVtbl[21]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), psi, fdap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT SetDefaultExtension([NativeTypeName("LPCWSTR")] ushort* pszDefaultExtension)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, ushort*, int>)(lpVtbl[22]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), pszDefaultExtension);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT Close(HRESULT hr)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, HRESULT, int>)(lpVtbl[23]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), hr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT SetClientGuid([NativeTypeName("const GUID &")] Guid* guid)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, Guid*, int>)(lpVtbl[24]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), guid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT ClearClientData()
        {
            return ((delegate* unmanaged<IFileOpenDialog*, int>)(lpVtbl[25]))((IFileOpenDialog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT SetFilter(IShellItemFilter* pFilter)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, IShellItemFilter*, int>)(lpVtbl[26]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), pFilter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT GetResults(IShellItemArray** ppenum)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, IShellItemArray**, int>)(lpVtbl[27]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), ppenum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT GetSelectedItems(IShellItemArray** ppsai)
        {
            return ((delegate* unmanaged<IFileOpenDialog*, IShellItemArray**, int>)(lpVtbl[28]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), ppsai);
        }

        public interface Interface : IFileDialog.Interface
        {
            [VtblIndex(27)]
            HRESULT GetResults(IShellItemArray** ppenum);

            [VtblIndex(28)]
            HRESULT GetSelectedItems(IShellItemArray** ppsai);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, uint> Release;

            [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, HWND, int> Show;

            [NativeTypeName("HRESULT (UINT, const COMDLG_FILTERSPEC *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, uint, COMDLG_FILTERSPEC*, int> SetFileTypes;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, uint, int> SetFileTypeIndex;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, uint*, int> GetFileTypeIndex;

            [NativeTypeName("HRESULT (IFileDialogEvents *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, IFileDialogEvents*, uint*, int> Advise;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, uint, int> Unadvise;

            [NativeTypeName("HRESULT (FILEOPENDIALOGOPTIONS) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, uint, int> SetOptions;

            [NativeTypeName("HRESULT (FILEOPENDIALOGOPTIONS *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, uint*, int> GetOptions;

            [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, IShellItem*, int> SetDefaultFolder;

            [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, IShellItem*, int> SetFolder;

            [NativeTypeName("HRESULT (IShellItem **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, IShellItem**, int> GetFolder;

            [NativeTypeName("HRESULT (IShellItem **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, IShellItem**, int> GetCurrentSelection;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, ushort*, int> SetFileName;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, ushort**, int> GetFileName;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, ushort*, int> SetTitle;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, ushort*, int> SetOkButtonLabel;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, ushort*, int> SetFileNameLabel;

            [NativeTypeName("HRESULT (IShellItem **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, IShellItem**, int> GetResult;

            [NativeTypeName("HRESULT (IShellItem *, FDAP) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, IShellItem*, FDAP, int> AddPlace;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, ushort*, int> SetDefaultExtension;

            [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, HRESULT, int> Close;

            [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, Guid*, int> SetClientGuid;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, int> ClearClientData;

            [NativeTypeName("HRESULT (IShellItemFilter *) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, IShellItemFilter*, int> SetFilter;

            [NativeTypeName("HRESULT (IShellItemArray **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, IShellItemArray**, int> GetResults;

            [NativeTypeName("HRESULT (IShellItemArray **) __attribute__((stdcall))")]
            public delegate* unmanaged<IFileOpenDialog*, IShellItemArray**, int> GetSelectedItems;
        }
    }
}
