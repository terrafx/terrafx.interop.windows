// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("25642426-028D-4474-977B-111BB114FE3E")]
    [NativeTypeName("struct ITextStoreSinkAnchorEx : ITextStoreAnchorSink")]
    [NativeInheritance("ITextStoreAnchorSink")]
    public unsafe partial struct ITextStoreSinkAnchorEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITextStoreSinkAnchorEx*, Guid*, void**, int>)(lpVtbl[0]))((ITextStoreSinkAnchorEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITextStoreSinkAnchorEx*, uint>)(lpVtbl[1]))((ITextStoreSinkAnchorEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITextStoreSinkAnchorEx*, uint>)(lpVtbl[2]))((ITextStoreSinkAnchorEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnTextChange([NativeTypeName("DWORD")] uint dwFlags, IAnchor* paStart, IAnchor* paEnd)
        {
            return ((delegate* unmanaged<ITextStoreSinkAnchorEx*, uint, IAnchor*, IAnchor*, int>)(lpVtbl[3]))((ITextStoreSinkAnchorEx*)Unsafe.AsPointer(ref this), dwFlags, paStart, paEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnSelectionChange()
        {
            return ((delegate* unmanaged<ITextStoreSinkAnchorEx*, int>)(lpVtbl[4]))((ITextStoreSinkAnchorEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT OnLayoutChange(TsLayoutCode lcode, [NativeTypeName("TsViewCookie")] uint vcView)
        {
            return ((delegate* unmanaged<ITextStoreSinkAnchorEx*, TsLayoutCode, uint, int>)(lpVtbl[5]))((ITextStoreSinkAnchorEx*)Unsafe.AsPointer(ref this), lcode, vcView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT OnStatusChange([NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITextStoreSinkAnchorEx*, uint, int>)(lpVtbl[6]))((ITextStoreSinkAnchorEx*)Unsafe.AsPointer(ref this), dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT OnAttrsChange(IAnchor* paStart, IAnchor* paEnd, [NativeTypeName("ULONG")] uint cAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paAttrs)
        {
            return ((delegate* unmanaged<ITextStoreSinkAnchorEx*, IAnchor*, IAnchor*, uint, Guid*, int>)(lpVtbl[7]))((ITextStoreSinkAnchorEx*)Unsafe.AsPointer(ref this), paStart, paEnd, cAttrs, paAttrs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT OnLockGranted([NativeTypeName("DWORD")] uint dwLockFlags)
        {
            return ((delegate* unmanaged<ITextStoreSinkAnchorEx*, uint, int>)(lpVtbl[8]))((ITextStoreSinkAnchorEx*)Unsafe.AsPointer(ref this), dwLockFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT OnStartEditTransaction()
        {
            return ((delegate* unmanaged<ITextStoreSinkAnchorEx*, int>)(lpVtbl[9]))((ITextStoreSinkAnchorEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT OnEndEditTransaction()
        {
            return ((delegate* unmanaged<ITextStoreSinkAnchorEx*, int>)(lpVtbl[10]))((ITextStoreSinkAnchorEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT OnDisconnect()
        {
            return ((delegate* unmanaged<ITextStoreSinkAnchorEx*, int>)(lpVtbl[11]))((ITextStoreSinkAnchorEx*)Unsafe.AsPointer(ref this));
        }
    }
}
