// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0AB198EF-6477-4EE8-8812-6780EDB82D5E")]
    [NativeTypeName("struct ITfThreadMgr2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfThreadMgr2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfThreadMgr2*, Guid*, void**, int>)(lpVtbl[0]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfThreadMgr2*, uint>)(lpVtbl[1]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfThreadMgr2*, uint>)(lpVtbl[2]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Activate([NativeTypeName("TfClientId *")] uint* ptid)
        {
            return ((delegate* unmanaged<ITfThreadMgr2*, uint*, int>)(lpVtbl[3]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this), ptid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Deactivate()
        {
            return ((delegate* unmanaged<ITfThreadMgr2*, int>)(lpVtbl[4]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CreateDocumentMgr(ITfDocumentMgr** ppdim)
        {
            return ((delegate* unmanaged<ITfThreadMgr2*, ITfDocumentMgr**, int>)(lpVtbl[5]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this), ppdim);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT EnumDocumentMgrs(IEnumTfDocumentMgrs** ppEnum)
        {
            return ((delegate* unmanaged<ITfThreadMgr2*, IEnumTfDocumentMgrs**, int>)(lpVtbl[6]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetFocus(ITfDocumentMgr** ppdimFocus)
        {
            return ((delegate* unmanaged<ITfThreadMgr2*, ITfDocumentMgr**, int>)(lpVtbl[7]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this), ppdimFocus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetFocus(ITfDocumentMgr* pdimFocus)
        {
            return ((delegate* unmanaged<ITfThreadMgr2*, ITfDocumentMgr*, int>)(lpVtbl[8]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this), pdimFocus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT IsThreadFocus(BOOL* pfThreadFocus)
        {
            return ((delegate* unmanaged<ITfThreadMgr2*, BOOL*, int>)(lpVtbl[9]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this), pfThreadFocus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetFunctionProvider([NativeTypeName("const IID &")] Guid* clsid, ITfFunctionProvider** ppFuncProv)
        {
            return ((delegate* unmanaged<ITfThreadMgr2*, Guid*, ITfFunctionProvider**, int>)(lpVtbl[10]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this), clsid, ppFuncProv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT EnumFunctionProviders(IEnumTfFunctionProviders** ppEnum)
        {
            return ((delegate* unmanaged<ITfThreadMgr2*, IEnumTfFunctionProviders**, int>)(lpVtbl[11]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT GetGlobalCompartment(ITfCompartmentMgr** ppCompMgr)
        {
            return ((delegate* unmanaged<ITfThreadMgr2*, ITfCompartmentMgr**, int>)(lpVtbl[12]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this), ppCompMgr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT ActivateEx([NativeTypeName("TfClientId *")] uint* ptid, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITfThreadMgr2*, uint*, uint, int>)(lpVtbl[13]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this), ptid, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetActiveFlags([NativeTypeName("DWORD *")] uint* lpdwFlags)
        {
            return ((delegate* unmanaged<ITfThreadMgr2*, uint*, int>)(lpVtbl[14]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this), lpdwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT SuspendKeystrokeHandling()
        {
            return ((delegate* unmanaged<ITfThreadMgr2*, int>)(lpVtbl[15]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT ResumeKeystrokeHandling()
        {
            return ((delegate* unmanaged<ITfThreadMgr2*, int>)(lpVtbl[16]))((ITfThreadMgr2*)Unsafe.AsPointer(ref this));
        }
    }
}
