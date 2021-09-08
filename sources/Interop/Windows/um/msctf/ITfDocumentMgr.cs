// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AA80E7F4-2021-11D2-93E0-0060B067B86E")]
    [NativeTypeName("struct ITfDocumentMgr : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfDocumentMgr
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfDocumentMgr*, Guid*, void**, int>)(lpVtbl[0]))((ITfDocumentMgr*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfDocumentMgr*, uint>)(lpVtbl[1]))((ITfDocumentMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfDocumentMgr*, uint>)(lpVtbl[2]))((ITfDocumentMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int CreateContext([NativeTypeName("TfClientId")] uint tidOwner, [NativeTypeName("DWORD")] uint dwFlags, IUnknown* punk, ITfContext** ppic, [NativeTypeName("TfEditCookie *")] uint* pecTextStore)
        {
            return ((delegate* unmanaged<ITfDocumentMgr*, uint, uint, IUnknown*, ITfContext**, uint*, int>)(lpVtbl[3]))((ITfDocumentMgr*)Unsafe.AsPointer(ref this), tidOwner, dwFlags, punk, ppic, pecTextStore);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Push(ITfContext* pic)
        {
            return ((delegate* unmanaged<ITfDocumentMgr*, ITfContext*, int>)(lpVtbl[4]))((ITfDocumentMgr*)Unsafe.AsPointer(ref this), pic);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Pop([NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITfDocumentMgr*, uint, int>)(lpVtbl[5]))((ITfDocumentMgr*)Unsafe.AsPointer(ref this), dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetTop(ITfContext** ppic)
        {
            return ((delegate* unmanaged<ITfDocumentMgr*, ITfContext**, int>)(lpVtbl[6]))((ITfDocumentMgr*)Unsafe.AsPointer(ref this), ppic);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetBase(ITfContext** ppic)
        {
            return ((delegate* unmanaged<ITfDocumentMgr*, ITfContext**, int>)(lpVtbl[7]))((ITfDocumentMgr*)Unsafe.AsPointer(ref this), ppic);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int EnumContexts(IEnumTfContexts** ppEnum)
        {
            return ((delegate* unmanaged<ITfDocumentMgr*, IEnumTfContexts**, int>)(lpVtbl[8]))((ITfDocumentMgr*)Unsafe.AsPointer(ref this), ppEnum);
        }
    }
}
