// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("22D44C94-A419-4542-A272-AE26093ECECF")]
    [NativeTypeName("struct ITextStoreACPSink : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITextStoreACPSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITextStoreACPSink*, Guid*, void**, int>)(lpVtbl[0]))((ITextStoreACPSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITextStoreACPSink*, uint>)(lpVtbl[1]))((ITextStoreACPSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITextStoreACPSink*, uint>)(lpVtbl[2]))((ITextStoreACPSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnTextChange([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const TS_TEXTCHANGE *")] TS_TEXTCHANGE* pChange)
        {
            return ((delegate* unmanaged<ITextStoreACPSink*, uint, TS_TEXTCHANGE*, int>)(lpVtbl[3]))((ITextStoreACPSink*)Unsafe.AsPointer(ref this), dwFlags, pChange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnSelectionChange()
        {
            return ((delegate* unmanaged<ITextStoreACPSink*, int>)(lpVtbl[4]))((ITextStoreACPSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT OnLayoutChange(TsLayoutCode lcode, [NativeTypeName("TsViewCookie")] uint vcView)
        {
            return ((delegate* unmanaged<ITextStoreACPSink*, TsLayoutCode, uint, int>)(lpVtbl[5]))((ITextStoreACPSink*)Unsafe.AsPointer(ref this), lcode, vcView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT OnStatusChange([NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITextStoreACPSink*, uint, int>)(lpVtbl[6]))((ITextStoreACPSink*)Unsafe.AsPointer(ref this), dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT OnAttrsChange([NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, [NativeTypeName("ULONG")] uint cAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paAttrs)
        {
            return ((delegate* unmanaged<ITextStoreACPSink*, int, int, uint, Guid*, int>)(lpVtbl[7]))((ITextStoreACPSink*)Unsafe.AsPointer(ref this), acpStart, acpEnd, cAttrs, paAttrs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT OnLockGranted([NativeTypeName("DWORD")] uint dwLockFlags)
        {
            return ((delegate* unmanaged<ITextStoreACPSink*, uint, int>)(lpVtbl[8]))((ITextStoreACPSink*)Unsafe.AsPointer(ref this), dwLockFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT OnStartEditTransaction()
        {
            return ((delegate* unmanaged<ITextStoreACPSink*, int>)(lpVtbl[9]))((ITextStoreACPSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT OnEndEditTransaction()
        {
            return ((delegate* unmanaged<ITextStoreACPSink*, int>)(lpVtbl[10]))((ITextStoreACPSink*)Unsafe.AsPointer(ref this));
        }
    }
}
