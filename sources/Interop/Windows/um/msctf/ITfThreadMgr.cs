// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AA80E801-2021-11D2-93E0-0060B067B86E")]
    [NativeTypeName("struct ITfThreadMgr : IUnknown")]
    public unsafe partial struct ITfThreadMgr
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfThreadMgr*, Guid*, void**, int>)(lpVtbl[0]))((ITfThreadMgr*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfThreadMgr*, uint>)(lpVtbl[1]))((ITfThreadMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfThreadMgr*, uint>)(lpVtbl[2]))((ITfThreadMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Activate([NativeTypeName("TfClientId *")] uint* ptid)
        {
            return ((delegate* unmanaged<ITfThreadMgr*, uint*, int>)(lpVtbl[3]))((ITfThreadMgr*)Unsafe.AsPointer(ref this), ptid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Deactivate()
        {
            return ((delegate* unmanaged<ITfThreadMgr*, int>)(lpVtbl[4]))((ITfThreadMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDocumentMgr(ITfDocumentMgr** ppdim)
        {
            return ((delegate* unmanaged<ITfThreadMgr*, ITfDocumentMgr**, int>)(lpVtbl[5]))((ITfThreadMgr*)Unsafe.AsPointer(ref this), ppdim);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumDocumentMgrs(IEnumTfDocumentMgrs** ppEnum)
        {
            return ((delegate* unmanaged<ITfThreadMgr*, IEnumTfDocumentMgrs**, int>)(lpVtbl[6]))((ITfThreadMgr*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFocus(ITfDocumentMgr** ppdimFocus)
        {
            return ((delegate* unmanaged<ITfThreadMgr*, ITfDocumentMgr**, int>)(lpVtbl[7]))((ITfThreadMgr*)Unsafe.AsPointer(ref this), ppdimFocus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFocus(ITfDocumentMgr* pdimFocus)
        {
            return ((delegate* unmanaged<ITfThreadMgr*, ITfDocumentMgr*, int>)(lpVtbl[8]))((ITfThreadMgr*)Unsafe.AsPointer(ref this), pdimFocus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AssociateFocus([NativeTypeName("HWND")] IntPtr hwnd, ITfDocumentMgr* pdimNew, ITfDocumentMgr** ppdimPrev)
        {
            return ((delegate* unmanaged<ITfThreadMgr*, IntPtr, ITfDocumentMgr*, ITfDocumentMgr**, int>)(lpVtbl[9]))((ITfThreadMgr*)Unsafe.AsPointer(ref this), hwnd, pdimNew, ppdimPrev);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsThreadFocus([NativeTypeName("BOOL *")] int* pfThreadFocus)
        {
            return ((delegate* unmanaged<ITfThreadMgr*, int*, int>)(lpVtbl[10]))((ITfThreadMgr*)Unsafe.AsPointer(ref this), pfThreadFocus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFunctionProvider([NativeTypeName("const IID &")] Guid* clsid, ITfFunctionProvider** ppFuncProv)
        {
            return ((delegate* unmanaged<ITfThreadMgr*, Guid*, ITfFunctionProvider**, int>)(lpVtbl[11]))((ITfThreadMgr*)Unsafe.AsPointer(ref this), clsid, ppFuncProv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumFunctionProviders(IEnumTfFunctionProviders** ppEnum)
        {
            return ((delegate* unmanaged<ITfThreadMgr*, IEnumTfFunctionProviders**, int>)(lpVtbl[12]))((ITfThreadMgr*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGlobalCompartment(ITfCompartmentMgr** ppCompMgr)
        {
            return ((delegate* unmanaged<ITfThreadMgr*, ITfCompartmentMgr**, int>)(lpVtbl[13]))((ITfThreadMgr*)Unsafe.AsPointer(ref this), ppCompMgr);
        }
    }
}
