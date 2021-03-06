// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AA80E808-2021-11D2-93E0-0060B067B86E")]
    [NativeTypeName("struct IEnumTfDocumentMgrs : IUnknown")]
    public unsafe partial struct IEnumTfDocumentMgrs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumTfDocumentMgrs*, Guid*, void**, int>)(lpVtbl[0]))((IEnumTfDocumentMgrs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumTfDocumentMgrs*, uint>)(lpVtbl[1]))((IEnumTfDocumentMgrs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumTfDocumentMgrs*, uint>)(lpVtbl[2]))((IEnumTfDocumentMgrs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumTfDocumentMgrs** ppEnum)
        {
            return ((delegate* unmanaged<IEnumTfDocumentMgrs*, IEnumTfDocumentMgrs**, int>)(lpVtbl[3]))((IEnumTfDocumentMgrs*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint ulCount, ITfDocumentMgr** rgDocumentMgr, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<IEnumTfDocumentMgrs*, uint, ITfDocumentMgr**, uint*, int>)(lpVtbl[4]))((IEnumTfDocumentMgrs*)Unsafe.AsPointer(ref this), ulCount, rgDocumentMgr, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumTfDocumentMgrs*, int>)(lpVtbl[5]))((IEnumTfDocumentMgrs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint ulCount)
        {
            return ((delegate* unmanaged<IEnumTfDocumentMgrs*, uint, int>)(lpVtbl[6]))((IEnumTfDocumentMgrs*)Unsafe.AsPointer(ref this), ulCount);
        }
    }
}
