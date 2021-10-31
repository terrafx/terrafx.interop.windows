// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3E90ADE3-7594-4CB0-BB58-69628F5F458C")]
    [NativeTypeName("struct ITfThreadMgrEx : ITfThreadMgr")]
    [NativeInheritance("ITfThreadMgr")]
    public unsafe partial struct ITfThreadMgrEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, Guid*, void**, int>)(lpVtbl[0]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, uint>)(lpVtbl[1]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, uint>)(lpVtbl[2]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Activate([NativeTypeName("TfClientId *")] uint* ptid)
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, uint*, int>)(lpVtbl[3]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), ptid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Deactivate()
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, int>)(lpVtbl[4]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CreateDocumentMgr(ITfDocumentMgr** ppdim)
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, ITfDocumentMgr**, int>)(lpVtbl[5]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), ppdim);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT EnumDocumentMgrs(IEnumTfDocumentMgrs** ppEnum)
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, IEnumTfDocumentMgrs**, int>)(lpVtbl[6]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetFocus(ITfDocumentMgr** ppdimFocus)
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, ITfDocumentMgr**, int>)(lpVtbl[7]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), ppdimFocus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetFocus(ITfDocumentMgr* pdimFocus)
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, ITfDocumentMgr*, int>)(lpVtbl[8]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), pdimFocus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT AssociateFocus(HWND hwnd, ITfDocumentMgr* pdimNew, ITfDocumentMgr** ppdimPrev)
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, HWND, ITfDocumentMgr*, ITfDocumentMgr**, int>)(lpVtbl[9]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), hwnd, pdimNew, ppdimPrev);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT IsThreadFocus(BOOL* pfThreadFocus)
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, BOOL*, int>)(lpVtbl[10]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), pfThreadFocus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetFunctionProvider([NativeTypeName("const IID &")] Guid* clsid, ITfFunctionProvider** ppFuncProv)
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, Guid*, ITfFunctionProvider**, int>)(lpVtbl[11]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), clsid, ppFuncProv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT EnumFunctionProviders(IEnumTfFunctionProviders** ppEnum)
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, IEnumTfFunctionProviders**, int>)(lpVtbl[12]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT GetGlobalCompartment(ITfCompartmentMgr** ppCompMgr)
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, ITfCompartmentMgr**, int>)(lpVtbl[13]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), ppCompMgr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT ActivateEx([NativeTypeName("TfClientId *")] uint* ptid, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, uint*, uint, int>)(lpVtbl[14]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), ptid, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetActiveFlags([NativeTypeName("DWORD *")] uint* lpdwFlags)
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, uint*, int>)(lpVtbl[15]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), lpdwFlags);
        }
    }
}
