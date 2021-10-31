// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8849DC22-CEDF-4C95-998D-051419DD3F76")]
    [NativeTypeName("struct IAccessibilityDockingService : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAccessibilityDockingService
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAccessibilityDockingService*, Guid*, void**, int>)(lpVtbl[0]))((IAccessibilityDockingService*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAccessibilityDockingService*, uint>)(lpVtbl[1]))((IAccessibilityDockingService*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAccessibilityDockingService*, uint>)(lpVtbl[2]))((IAccessibilityDockingService*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetAvailableSize(HMONITOR hMonitor, uint* pcxFixed, uint* pcyMax)
        {
            return ((delegate* unmanaged<IAccessibilityDockingService*, HMONITOR, uint*, uint*, int>)(lpVtbl[3]))((IAccessibilityDockingService*)Unsafe.AsPointer(ref this), hMonitor, pcxFixed, pcyMax);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT DockWindow(HWND hwnd, HMONITOR hMonitor, uint cyRequested, IAccessibilityDockingServiceCallback* pCallback)
        {
            return ((delegate* unmanaged<IAccessibilityDockingService*, HWND, HMONITOR, uint, IAccessibilityDockingServiceCallback*, int>)(lpVtbl[4]))((IAccessibilityDockingService*)Unsafe.AsPointer(ref this), hwnd, hMonitor, cyRequested, pCallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT UndockWindow(HWND hwnd)
        {
            return ((delegate* unmanaged<IAccessibilityDockingService*, HWND, int>)(lpVtbl[5]))((IAccessibilityDockingService*)Unsafe.AsPointer(ref this), hwnd);
        }
    }
}
