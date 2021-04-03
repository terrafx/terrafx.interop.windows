// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2BDF9464-41E2-43E3-950C-A6865BA25CD4")]
    [NativeTypeName("struct ITextStoreACPSinkEx : ITextStoreACPSink")]
    public unsafe partial struct ITextStoreACPSinkEx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITextStoreACPSinkEx*, Guid*, void**, int>)(lpVtbl[0]))((ITextStoreACPSinkEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITextStoreACPSinkEx*, uint>)(lpVtbl[1]))((ITextStoreACPSinkEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITextStoreACPSinkEx*, uint>)(lpVtbl[2]))((ITextStoreACPSinkEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnTextChange([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("const TS_TEXTCHANGE *")] TS_TEXTCHANGE* pChange)
        {
            return ((delegate* unmanaged<ITextStoreACPSinkEx*, uint, TS_TEXTCHANGE*, int>)(lpVtbl[3]))((ITextStoreACPSinkEx*)Unsafe.AsPointer(ref this), dwFlags, pChange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnSelectionChange()
        {
            return ((delegate* unmanaged<ITextStoreACPSinkEx*, int>)(lpVtbl[4]))((ITextStoreACPSinkEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnLayoutChange(TsLayoutCode lcode, [NativeTypeName("TsViewCookie")] uint vcView)
        {
            return ((delegate* unmanaged<ITextStoreACPSinkEx*, TsLayoutCode, uint, int>)(lpVtbl[5]))((ITextStoreACPSinkEx*)Unsafe.AsPointer(ref this), lcode, vcView);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnStatusChange([NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITextStoreACPSinkEx*, uint, int>)(lpVtbl[6]))((ITextStoreACPSinkEx*)Unsafe.AsPointer(ref this), dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnAttrsChange([NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, [NativeTypeName("ULONG")] uint cAttrs, [NativeTypeName("const TS_ATTRID *")] Guid* paAttrs)
        {
            return ((delegate* unmanaged<ITextStoreACPSinkEx*, int, int, uint, Guid*, int>)(lpVtbl[7]))((ITextStoreACPSinkEx*)Unsafe.AsPointer(ref this), acpStart, acpEnd, cAttrs, paAttrs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnLockGranted([NativeTypeName("DWORD")] uint dwLockFlags)
        {
            return ((delegate* unmanaged<ITextStoreACPSinkEx*, uint, int>)(lpVtbl[8]))((ITextStoreACPSinkEx*)Unsafe.AsPointer(ref this), dwLockFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnStartEditTransaction()
        {
            return ((delegate* unmanaged<ITextStoreACPSinkEx*, int>)(lpVtbl[9]))((ITextStoreACPSinkEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnEndEditTransaction()
        {
            return ((delegate* unmanaged<ITextStoreACPSinkEx*, int>)(lpVtbl[10]))((ITextStoreACPSinkEx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnDisconnect()
        {
            return ((delegate* unmanaged<ITextStoreACPSinkEx*, int>)(lpVtbl[11]))((ITextStoreACPSinkEx*)Unsafe.AsPointer(ref this));
        }
    }
}
