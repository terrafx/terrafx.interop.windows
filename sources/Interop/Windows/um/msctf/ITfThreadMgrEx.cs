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
    public unsafe partial struct ITfThreadMgrEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, Guid*, void**, int>)(lpVtbl[0]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, uint>)(lpVtbl[1]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, uint>)(lpVtbl[2]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Activate([NativeTypeName("TfClientId *")] uint* ptid)
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, uint*, int>)(lpVtbl[3]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), ptid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Deactivate()
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, int>)(lpVtbl[4]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDocumentMgr(ITfDocumentMgr** ppdim)
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, ITfDocumentMgr**, int>)(lpVtbl[5]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), ppdim);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumDocumentMgrs(IEnumTfDocumentMgrs** ppEnum)
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, IEnumTfDocumentMgrs**, int>)(lpVtbl[6]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFocus(ITfDocumentMgr** ppdimFocus)
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, ITfDocumentMgr**, int>)(lpVtbl[7]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), ppdimFocus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetFocus(ITfDocumentMgr* pdimFocus)
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, ITfDocumentMgr*, int>)(lpVtbl[8]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), pdimFocus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AssociateFocus([NativeTypeName("HWND")] IntPtr hwnd, ITfDocumentMgr* pdimNew, ITfDocumentMgr** ppdimPrev)
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, IntPtr, ITfDocumentMgr*, ITfDocumentMgr**, int>)(lpVtbl[9]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), hwnd, pdimNew, ppdimPrev);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsThreadFocus([NativeTypeName("BOOL *")] int* pfThreadFocus)
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, int*, int>)(lpVtbl[10]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), pfThreadFocus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetFunctionProvider([NativeTypeName("const IID &")] Guid* clsid, ITfFunctionProvider** ppFuncProv)
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, Guid*, ITfFunctionProvider**, int>)(lpVtbl[11]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), clsid, ppFuncProv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumFunctionProviders(IEnumTfFunctionProviders** ppEnum)
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, IEnumTfFunctionProviders**, int>)(lpVtbl[12]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetGlobalCompartment(ITfCompartmentMgr** ppCompMgr)
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, ITfCompartmentMgr**, int>)(lpVtbl[13]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), ppCompMgr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ActivateEx([NativeTypeName("TfClientId *")] uint* ptid, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, uint*, uint, int>)(lpVtbl[14]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), ptid, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetActiveFlags([NativeTypeName("DWORD *")] uint* lpdwFlags)
        {
            return ((delegate* unmanaged<ITfThreadMgrEx*, uint*, int>)(lpVtbl[15]))((ITfThreadMgrEx*)Unsafe.AsPointer(ref this), lpdwFlags);
        }
    }
}
