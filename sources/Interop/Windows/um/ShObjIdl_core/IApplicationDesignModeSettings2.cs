// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("490514E1-675A-4D6E-A58D-E54901B4CA2F")]
    [NativeTypeName("struct IApplicationDesignModeSettings2 : IApplicationDesignModeSettings")]
    [NativeInheritance("IApplicationDesignModeSettings")]
    public unsafe partial struct IApplicationDesignModeSettings2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IApplicationDesignModeSettings2*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IApplicationDesignModeSettings2*, uint>)(lpVtbl[1]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IApplicationDesignModeSettings2*, uint>)(lpVtbl[2]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetNativeDisplaySize(SIZE nativeDisplaySizePixels)
        {
            return ((delegate* unmanaged<IApplicationDesignModeSettings2*, SIZE, int>)(lpVtbl[3]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), nativeDisplaySizePixels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetScaleFactor(DEVICE_SCALE_FACTOR scaleFactor)
        {
            return ((delegate* unmanaged<IApplicationDesignModeSettings2*, DEVICE_SCALE_FACTOR, int>)(lpVtbl[4]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), scaleFactor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetApplicationViewState(APPLICATION_VIEW_STATE viewState)
        {
            return ((delegate* unmanaged<IApplicationDesignModeSettings2*, APPLICATION_VIEW_STATE, int>)(lpVtbl[5]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), viewState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT ComputeApplicationSize(SIZE* applicationSizePixels)
        {
            return ((delegate* unmanaged<IApplicationDesignModeSettings2*, SIZE*, int>)(lpVtbl[6]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), applicationSizePixels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT IsApplicationViewStateSupported(APPLICATION_VIEW_STATE viewState, SIZE nativeDisplaySizePixels, DEVICE_SCALE_FACTOR scaleFactor, BOOL* supported)
        {
            return ((delegate* unmanaged<IApplicationDesignModeSettings2*, APPLICATION_VIEW_STATE, SIZE, DEVICE_SCALE_FACTOR, BOOL*, int>)(lpVtbl[7]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), viewState, nativeDisplaySizePixels, scaleFactor, supported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT TriggerEdgeGesture(EDGE_GESTURE_KIND edgeGestureKind)
        {
            return ((delegate* unmanaged<IApplicationDesignModeSettings2*, EDGE_GESTURE_KIND, int>)(lpVtbl[8]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), edgeGestureKind);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetNativeDisplayOrientation(NATIVE_DISPLAY_ORIENTATION nativeDisplayOrientation)
        {
            return ((delegate* unmanaged<IApplicationDesignModeSettings2*, NATIVE_DISPLAY_ORIENTATION, int>)(lpVtbl[9]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), nativeDisplayOrientation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetApplicationViewOrientation(APPLICATION_VIEW_ORIENTATION viewOrientation)
        {
            return ((delegate* unmanaged<IApplicationDesignModeSettings2*, APPLICATION_VIEW_ORIENTATION, int>)(lpVtbl[10]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), viewOrientation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT SetAdjacentDisplayEdges(ADJACENT_DISPLAY_EDGES adjacentDisplayEdges)
        {
            return ((delegate* unmanaged<IApplicationDesignModeSettings2*, ADJACENT_DISPLAY_EDGES, int>)(lpVtbl[11]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), adjacentDisplayEdges);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetIsOnLockScreen(BOOL isOnLockScreen)
        {
            return ((delegate* unmanaged<IApplicationDesignModeSettings2*, BOOL, int>)(lpVtbl[12]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), isOnLockScreen);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT SetApplicationViewMinWidth(APPLICATION_VIEW_MIN_WIDTH viewMinWidth)
        {
            return ((delegate* unmanaged<IApplicationDesignModeSettings2*, APPLICATION_VIEW_MIN_WIDTH, int>)(lpVtbl[13]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), viewMinWidth);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetApplicationSizeBounds(SIZE* minApplicationSizePixels, SIZE* maxApplicationSizePixels)
        {
            return ((delegate* unmanaged<IApplicationDesignModeSettings2*, SIZE*, SIZE*, int>)(lpVtbl[14]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), minApplicationSizePixels, maxApplicationSizePixels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetApplicationViewOrientation(SIZE applicationSizePixels, APPLICATION_VIEW_ORIENTATION* viewOrientation)
        {
            return ((delegate* unmanaged<IApplicationDesignModeSettings2*, SIZE, APPLICATION_VIEW_ORIENTATION*, int>)(lpVtbl[15]))((IApplicationDesignModeSettings2*)Unsafe.AsPointer(ref this), applicationSizePixels, viewOrientation);
        }
    }
}
