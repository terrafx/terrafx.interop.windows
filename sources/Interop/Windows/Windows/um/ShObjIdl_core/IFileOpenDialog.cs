// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IFileOpenDialog.xml' path='doc/member[@name="IFileOpenDialog"]/*' />
[Guid("D57C7288-D4AD-4768-BE02-9D969532D960")]
[NativeTypeName("struct IFileOpenDialog : IFileDialog")]
[NativeInheritance("IFileDialog")]
public unsafe partial struct IFileOpenDialog : IFileOpenDialog.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileOpenDialog));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, Guid*, void**, int>)(lpVtbl[0]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, uint>)(lpVtbl[1]))((IFileOpenDialog*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, uint>)(lpVtbl[2]))((IFileOpenDialog*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IModalWindow.Show" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Show(HWND hwndOwner)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, HWND, int>)(lpVtbl[3]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), hwndOwner);
    }

    /// <inheritdoc cref="IFileDialog.SetFileTypes" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetFileTypes(uint cFileTypes, [NativeTypeName("const COMDLG_FILTERSPEC *")] COMDLG_FILTERSPEC* rgFilterSpec)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, uint, COMDLG_FILTERSPEC*, int>)(lpVtbl[4]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), cFileTypes, rgFilterSpec);
    }

    /// <inheritdoc cref="IFileDialog.SetFileTypeIndex" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetFileTypeIndex(uint iFileType)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, uint, int>)(lpVtbl[5]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), iFileType);
    }

    /// <inheritdoc cref="IFileDialog.GetFileTypeIndex" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFileTypeIndex(uint* piFileType)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, uint*, int>)(lpVtbl[6]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), piFileType);
    }

    /// <inheritdoc cref="IFileDialog.Advise" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Advise(IFileDialogEvents* pfde, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, IFileDialogEvents*, uint*, int>)(lpVtbl[7]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), pfde, pdwCookie);
    }

    /// <inheritdoc cref="IFileDialog.Unadvise" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, uint, int>)(lpVtbl[8]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), dwCookie);
    }

    /// <inheritdoc cref="IFileDialog.SetOptions" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetOptions([NativeTypeName("FILEOPENDIALOGOPTIONS")] uint fos)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, uint, int>)(lpVtbl[9]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), fos);
    }

    /// <inheritdoc cref="IFileDialog.GetOptions" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetOptions([NativeTypeName("FILEOPENDIALOGOPTIONS *")] uint* pfos)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, uint*, int>)(lpVtbl[10]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), pfos);
    }

    /// <inheritdoc cref="IFileDialog.SetDefaultFolder" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetDefaultFolder(IShellItem* psi)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, IShellItem*, int>)(lpVtbl[11]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), psi);
    }

    /// <inheritdoc cref="IFileDialog.SetFolder" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetFolder(IShellItem* psi)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, IShellItem*, int>)(lpVtbl[12]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), psi);
    }

    /// <inheritdoc cref="IFileDialog.GetFolder" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetFolder(IShellItem** ppsi)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, IShellItem**, int>)(lpVtbl[13]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), ppsi);
    }

    /// <inheritdoc cref="IFileDialog.GetCurrentSelection" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetCurrentSelection(IShellItem** ppsi)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, IShellItem**, int>)(lpVtbl[14]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), ppsi);
    }

    /// <inheritdoc cref="IFileDialog.SetFileName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetFileName([NativeTypeName("LPCWSTR")] char* pszName)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, char*, int>)(lpVtbl[15]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), pszName);
    }

    /// <inheritdoc cref="IFileDialog.GetFileName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetFileName([NativeTypeName("LPWSTR *")] char** pszName)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, char**, int>)(lpVtbl[16]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), pszName);
    }

    /// <inheritdoc cref="IFileDialog.SetTitle" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetTitle([NativeTypeName("LPCWSTR")] char* pszTitle)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, char*, int>)(lpVtbl[17]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), pszTitle);
    }

    /// <inheritdoc cref="IFileDialog.SetOkButtonLabel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetOkButtonLabel([NativeTypeName("LPCWSTR")] char* pszText)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, char*, int>)(lpVtbl[18]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), pszText);
    }

    /// <inheritdoc cref="IFileDialog.SetFileNameLabel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetFileNameLabel([NativeTypeName("LPCWSTR")] char* pszLabel)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, char*, int>)(lpVtbl[19]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), pszLabel);
    }

    /// <inheritdoc cref="IFileDialog.GetResult" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetResult(IShellItem** ppsi)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, IShellItem**, int>)(lpVtbl[20]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), ppsi);
    }

    /// <inheritdoc cref="IFileDialog.AddPlace" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT AddPlace(IShellItem* psi, FDAP fdap)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, IShellItem*, FDAP, int>)(lpVtbl[21]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), psi, fdap);
    }

    /// <inheritdoc cref="IFileDialog.SetDefaultExtension" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetDefaultExtension([NativeTypeName("LPCWSTR")] char* pszDefaultExtension)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, char*, int>)(lpVtbl[22]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), pszDefaultExtension);
    }

    /// <inheritdoc cref="IFileDialog.Close" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT Close(HRESULT hr)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, HRESULT, int>)(lpVtbl[23]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), hr);
    }

    /// <inheritdoc cref="IFileDialog.SetClientGuid" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetClientGuid([NativeTypeName("const GUID &")] Guid* guid)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, Guid*, int>)(lpVtbl[24]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), guid);
    }

    /// <inheritdoc cref="IFileDialog.ClearClientData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT ClearClientData()
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, int>)(lpVtbl[25]))((IFileOpenDialog*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IFileDialog.SetFilter" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT SetFilter(IShellItemFilter* pFilter)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, IShellItemFilter*, int>)(lpVtbl[26]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), pFilter);
    }

    /// <include file='IFileOpenDialog.xml' path='doc/member[@name="IFileOpenDialog.GetResults"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetResults(IShellItemArray** ppenum)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, IShellItemArray**, int>)(lpVtbl[27]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), ppenum);
    }

    /// <include file='IFileOpenDialog.xml' path='doc/member[@name="IFileOpenDialog.GetSelectedItems"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT GetSelectedItems(IShellItemArray** ppsai)
    {
        return ((delegate* unmanaged[MemberFunction]<IFileOpenDialog*, IShellItemArray**, int>)(lpVtbl[28]))((IFileOpenDialog*)Unsafe.AsPointer(ref this), ppsai);
    }

    public interface Interface : IFileDialog.Interface
    {
        [VtblIndex(27)]
        HRESULT GetResults(IShellItemArray** ppenum);

        [VtblIndex(28)]
        HRESULT GetSelectedItems(IShellItemArray** ppsai);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HWND, int> Show;

        [NativeTypeName("HRESULT (UINT, const COMDLG_FILTERSPEC *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, COMDLG_FILTERSPEC*, int> SetFileTypes;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> SetFileTypeIndex;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetFileTypeIndex;

        [NativeTypeName("HRESULT (IFileDialogEvents *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IFileDialogEvents*, uint*, int> Advise;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> Unadvise;

        [NativeTypeName("HRESULT (FILEOPENDIALOGOPTIONS) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> SetOptions;

        [NativeTypeName("HRESULT (FILEOPENDIALOGOPTIONS *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetOptions;

        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IShellItem*, int> SetDefaultFolder;

        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IShellItem*, int> SetFolder;

        [NativeTypeName("HRESULT (IShellItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IShellItem**, int> GetFolder;

        [NativeTypeName("HRESULT (IShellItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IShellItem**, int> GetCurrentSelection;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetFileName;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char**, int> GetFileName;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetTitle;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetOkButtonLabel;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetFileNameLabel;

        [NativeTypeName("HRESULT (IShellItem **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IShellItem**, int> GetResult;

        [NativeTypeName("HRESULT (IShellItem *, FDAP) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IShellItem*, FDAP, int> AddPlace;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> SetDefaultExtension;

        [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HRESULT, int> Close;

        [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> SetClientGuid;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ClearClientData;

        [NativeTypeName("HRESULT (IShellItemFilter *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IShellItemFilter*, int> SetFilter;

        [NativeTypeName("HRESULT (IShellItemArray **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IShellItemArray**, int> GetResults;

        [NativeTypeName("HRESULT (IShellItemArray **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IShellItemArray**, int> GetSelectedItems;
    }
}
