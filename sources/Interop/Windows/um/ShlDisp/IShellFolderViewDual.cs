// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E7A1AF80-4D96-11CF-960C-0080C7F4EE85")]
    [NativeTypeName("struct IShellFolderViewDual : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct IShellFolderViewDual
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellFolderViewDual*, Guid*, void**, int>)(lpVtbl[0]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellFolderViewDual*, uint>)(lpVtbl[1]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellFolderViewDual*, uint>)(lpVtbl[2]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IShellFolderViewDual*, uint*, int>)(lpVtbl[3]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IShellFolderViewDual*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IShellFolderViewDual*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
        {
            return ((delegate* unmanaged<IShellFolderViewDual*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_Application(IDispatch** ppid)
        {
            return ((delegate* unmanaged<IShellFolderViewDual*, IDispatch**, int>)(lpVtbl[7]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT get_Parent(IDispatch** ppid)
        {
            return ((delegate* unmanaged<IShellFolderViewDual*, IDispatch**, int>)(lpVtbl[8]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_Folder(Folder** ppid)
        {
            return ((delegate* unmanaged<IShellFolderViewDual*, Folder**, int>)(lpVtbl[9]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SelectedItems(FolderItems** ppid)
        {
            return ((delegate* unmanaged<IShellFolderViewDual*, FolderItems**, int>)(lpVtbl[10]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_FocusedItem(FolderItem** ppid)
        {
            return ((delegate* unmanaged<IShellFolderViewDual*, FolderItem**, int>)(lpVtbl[11]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), ppid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SelectItem(VARIANT* pvfi, int dwFlags)
        {
            return ((delegate* unmanaged<IShellFolderViewDual*, VARIANT*, int, int>)(lpVtbl[12]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), pvfi, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT PopupItemMenu(FolderItem* pfi, VARIANT vx, VARIANT vy, [NativeTypeName("BSTR *")] ushort** pbs)
        {
            return ((delegate* unmanaged<IShellFolderViewDual*, FolderItem*, VARIANT, VARIANT, ushort**, int>)(lpVtbl[13]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), pfi, vx, vy, pbs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT get_Script(IDispatch** ppDisp)
        {
            return ((delegate* unmanaged<IShellFolderViewDual*, IDispatch**, int>)(lpVtbl[14]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), ppDisp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_ViewOptions([NativeTypeName("long *")] int* plViewOptions)
        {
            return ((delegate* unmanaged<IShellFolderViewDual*, int*, int>)(lpVtbl[15]))((IShellFolderViewDual*)Unsafe.AsPointer(ref this), plViewOptions);
        }
    }
}
