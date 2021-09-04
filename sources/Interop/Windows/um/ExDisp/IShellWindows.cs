// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ExDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("85CB6900-4D95-11CF-960C-0080C7F4EE85")]
    [NativeTypeName("struct IShellWindows : IDispatch")]
    public unsafe partial struct IShellWindows
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellWindows*, Guid*, void**, int>)(lpVtbl[0]))((IShellWindows*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellWindows*, uint>)(lpVtbl[1]))((IShellWindows*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellWindows*, uint>)(lpVtbl[2]))((IShellWindows*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IShellWindows*, uint*, int>)(lpVtbl[3]))((IShellWindows*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IShellWindows*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IShellWindows*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IShellWindows*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IShellWindows*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IShellWindows*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IShellWindows*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Count([NativeTypeName("long *")] int* Count)
        {
            return ((delegate* unmanaged<IShellWindows*, int*, int>)(lpVtbl[7]))((IShellWindows*)Unsafe.AsPointer(ref this), Count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Item(VARIANT index, IDispatch** Folder)
        {
            return ((delegate* unmanaged<IShellWindows*, VARIANT, IDispatch**, int>)(lpVtbl[8]))((IShellWindows*)Unsafe.AsPointer(ref this), index, Folder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int _NewEnum(IUnknown** ppunk)
        {
            return ((delegate* unmanaged<IShellWindows*, IUnknown**, int>)(lpVtbl[9]))((IShellWindows*)Unsafe.AsPointer(ref this), ppunk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Register(IDispatch* pid, [NativeTypeName("long")] int hwnd, int swClass, [NativeTypeName("long *")] int* plCookie)
        {
            return ((delegate* unmanaged<IShellWindows*, IDispatch*, int, int, int*, int>)(lpVtbl[10]))((IShellWindows*)Unsafe.AsPointer(ref this), pid, hwnd, swClass, plCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterPending([NativeTypeName("long")] int lThreadId, VARIANT* pvarloc, VARIANT* pvarlocRoot, int swClass, [NativeTypeName("long *")] int* plCookie)
        {
            return ((delegate* unmanaged<IShellWindows*, int, VARIANT*, VARIANT*, int, int*, int>)(lpVtbl[11]))((IShellWindows*)Unsafe.AsPointer(ref this), lThreadId, pvarloc, pvarlocRoot, swClass, plCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Revoke([NativeTypeName("long")] int lCookie)
        {
            return ((delegate* unmanaged<IShellWindows*, int, int>)(lpVtbl[12]))((IShellWindows*)Unsafe.AsPointer(ref this), lCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnNavigate([NativeTypeName("long")] int lCookie, VARIANT* pvarLoc)
        {
            return ((delegate* unmanaged<IShellWindows*, int, VARIANT*, int>)(lpVtbl[13]))((IShellWindows*)Unsafe.AsPointer(ref this), lCookie, pvarLoc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnActivated([NativeTypeName("long")] int lCookie, [NativeTypeName("VARIANT_BOOL")] short fActive)
        {
            return ((delegate* unmanaged<IShellWindows*, int, short, int>)(lpVtbl[14]))((IShellWindows*)Unsafe.AsPointer(ref this), lCookie, fActive);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FindWindowSW(VARIANT* pvarLoc, VARIANT* pvarLocRoot, int swClass, [NativeTypeName("long *")] int* phwnd, int swfwOptions, IDispatch** ppdispOut)
        {
            return ((delegate* unmanaged<IShellWindows*, VARIANT*, VARIANT*, int, int*, int, IDispatch**, int>)(lpVtbl[15]))((IShellWindows*)Unsafe.AsPointer(ref this), pvarLoc, pvarLocRoot, swClass, phwnd, swfwOptions, ppdispOut);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnCreated([NativeTypeName("long")] int lCookie, IUnknown* punk)
        {
            return ((delegate* unmanaged<IShellWindows*, int, IUnknown*, int>)(lpVtbl[16]))((IShellWindows*)Unsafe.AsPointer(ref this), lCookie, punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessAttachDetach([NativeTypeName("VARIANT_BOOL")] short fAttach)
        {
            return ((delegate* unmanaged<IShellWindows*, short, int>)(lpVtbl[17]))((IShellWindows*)Unsafe.AsPointer(ref this), fAttach);
        }
    }
}
