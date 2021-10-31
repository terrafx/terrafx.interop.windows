// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3D8B0590-F691-11D2-8EA9-006097DF5BD4")]
    [NativeTypeName("struct IDataObjectAsyncCapability : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDataObjectAsyncCapability
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDataObjectAsyncCapability*, Guid*, void**, int>)(lpVtbl[0]))((IDataObjectAsyncCapability*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDataObjectAsyncCapability*, uint>)(lpVtbl[1]))((IDataObjectAsyncCapability*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDataObjectAsyncCapability*, uint>)(lpVtbl[2]))((IDataObjectAsyncCapability*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetAsyncMode(BOOL fDoOpAsync)
        {
            return ((delegate* unmanaged<IDataObjectAsyncCapability*, BOOL, int>)(lpVtbl[3]))((IDataObjectAsyncCapability*)Unsafe.AsPointer(ref this), fDoOpAsync);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetAsyncMode(BOOL* pfIsOpAsync)
        {
            return ((delegate* unmanaged<IDataObjectAsyncCapability*, BOOL*, int>)(lpVtbl[4]))((IDataObjectAsyncCapability*)Unsafe.AsPointer(ref this), pfIsOpAsync);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int StartOperation(IBindCtx* pbcReserved)
        {
            return ((delegate* unmanaged<IDataObjectAsyncCapability*, IBindCtx*, int>)(lpVtbl[5]))((IDataObjectAsyncCapability*)Unsafe.AsPointer(ref this), pbcReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int InOperation(BOOL* pfInAsyncOp)
        {
            return ((delegate* unmanaged<IDataObjectAsyncCapability*, BOOL*, int>)(lpVtbl[6]))((IDataObjectAsyncCapability*)Unsafe.AsPointer(ref this), pfInAsyncOp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int EndOperation([NativeTypeName("HRESULT")] int hResult, IBindCtx* pbcReserved, [NativeTypeName("DWORD")] uint dwEffects)
        {
            return ((delegate* unmanaged<IDataObjectAsyncCapability*, int, IBindCtx*, uint, int>)(lpVtbl[7]))((IDataObjectAsyncCapability*)Unsafe.AsPointer(ref this), hResult, pbcReserved, dwEffects);
        }
    }
}
