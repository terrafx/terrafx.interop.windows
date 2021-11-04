// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AA80E905-2021-11D2-93E0-0060B067B86E")]
    [NativeTypeName("struct ITextStoreAnchorSink : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITextStoreAnchorSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITextStoreAnchorSink*, Guid*, void**, int>)(lpVtbl[0]))((ITextStoreAnchorSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITextStoreAnchorSink*, uint>)(lpVtbl[1]))((ITextStoreAnchorSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITextStoreAnchorSink*, uint>)(lpVtbl[2]))((ITextStoreAnchorSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnTextChange([NativeTypeName("DWORD")] uint dwFlags, IAnchor* paStart, IAnchor* paEnd)
        {
            return ((delegate* unmanaged<ITextStoreAnchorSink*, uint, IAnchor*, IAnchor*, int>)(lpVtbl[3]))((ITextStoreAnchorSink*)Unsafe.AsPointer(ref this), dwFlags, paStart, paEnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnSelectionChange()
        {
            return ((delegate* unmanaged<ITextStoreAnchorSink*, int>)(lpVtbl[4]))((ITextStoreAnchorSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT OnLayoutChange(TsLayoutCode lcode, [NativeTypeName("TsViewCookie")] uint vcView)
        {
            return ((delegate* unmanaged<ITextStoreAnchorSink*, TsLayoutCode, uint, int>)(lpVtbl[5]))((ITextStoreAnchorSink*)Unsafe.AsPointer(ref this), lcode, vcView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT OnStatusChange([NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITextStoreAnchorSink*, uint, int>)(lpVtbl[6]))((ITextStoreAnchorSink*)Unsafe.AsPointer(ref this), dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT OnAttrsChange(IAnchor* paStart, IAnchor* paEnd, [NativeTypeName("ULONG")] uint cAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paAttrs)
        {
            return ((delegate* unmanaged<ITextStoreAnchorSink*, IAnchor*, IAnchor*, uint, Guid*, int>)(lpVtbl[7]))((ITextStoreAnchorSink*)Unsafe.AsPointer(ref this), paStart, paEnd, cAttrs, paAttrs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT OnLockGranted([NativeTypeName("DWORD")] uint dwLockFlags)
        {
            return ((delegate* unmanaged<ITextStoreAnchorSink*, uint, int>)(lpVtbl[8]))((ITextStoreAnchorSink*)Unsafe.AsPointer(ref this), dwLockFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT OnStartEditTransaction()
        {
            return ((delegate* unmanaged<ITextStoreAnchorSink*, int>)(lpVtbl[9]))((ITextStoreAnchorSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT OnEndEditTransaction()
        {
            return ((delegate* unmanaged<ITextStoreAnchorSink*, int>)(lpVtbl[10]))((ITextStoreAnchorSink*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreAnchorSink*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreAnchorSink*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreAnchorSink*, uint> Release;

            [NativeTypeName("HRESULT (DWORD, IAnchor *, IAnchor *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreAnchorSink*, uint, IAnchor*, IAnchor*, int> OnTextChange;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreAnchorSink*, int> OnSelectionChange;

            [NativeTypeName("HRESULT (TsLayoutCode, TsViewCookie) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreAnchorSink*, TsLayoutCode, uint, int> OnLayoutChange;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreAnchorSink*, uint, int> OnStatusChange;

            [NativeTypeName("HRESULT (IAnchor *, IAnchor *, ULONG, const TS_ATTRID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreAnchorSink*, IAnchor*, IAnchor*, uint, Guid*, int> OnAttrsChange;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreAnchorSink*, uint, int> OnLockGranted;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreAnchorSink*, int> OnStartEditTransaction;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<ITextStoreAnchorSink*, int> OnEndEditTransaction;
        }
    }
}
