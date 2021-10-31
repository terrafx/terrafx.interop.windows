// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CD91D690-A7E8-4265-9B38-8BB3BBABA7DE")]
    [NativeTypeName("struct IUIManagerEventSink : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IUIManagerEventSink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IUIManagerEventSink*, Guid*, void**, int>)(lpVtbl[0]))((IUIManagerEventSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUIManagerEventSink*, uint>)(lpVtbl[1]))((IUIManagerEventSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUIManagerEventSink*, uint>)(lpVtbl[2]))((IUIManagerEventSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnWindowOpening(RECT* prcBounds)
        {
            return ((delegate* unmanaged<IUIManagerEventSink*, RECT*, int>)(lpVtbl[3]))((IUIManagerEventSink*)Unsafe.AsPointer(ref this), prcBounds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnWindowOpened(RECT* prcBounds)
        {
            return ((delegate* unmanaged<IUIManagerEventSink*, RECT*, int>)(lpVtbl[4]))((IUIManagerEventSink*)Unsafe.AsPointer(ref this), prcBounds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT OnWindowUpdating(RECT* prcUpdatedBounds)
        {
            return ((delegate* unmanaged<IUIManagerEventSink*, RECT*, int>)(lpVtbl[5]))((IUIManagerEventSink*)Unsafe.AsPointer(ref this), prcUpdatedBounds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT OnWindowUpdated(RECT* prcUpdatedBounds)
        {
            return ((delegate* unmanaged<IUIManagerEventSink*, RECT*, int>)(lpVtbl[6]))((IUIManagerEventSink*)Unsafe.AsPointer(ref this), prcUpdatedBounds);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT OnWindowClosing()
        {
            return ((delegate* unmanaged<IUIManagerEventSink*, int>)(lpVtbl[7]))((IUIManagerEventSink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT OnWindowClosed()
        {
            return ((delegate* unmanaged<IUIManagerEventSink*, int>)(lpVtbl[8]))((IUIManagerEventSink*)Unsafe.AsPointer(ref this));
        }
    }
}
