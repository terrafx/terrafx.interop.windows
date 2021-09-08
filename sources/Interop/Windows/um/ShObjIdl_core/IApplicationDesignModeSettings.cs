// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2A3DEE9A-E31D-46D6-8508-BCC597DB3557")]
    [NativeTypeName("struct IApplicationDesignModeSettings : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IApplicationDesignModeSettings
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IApplicationDesignModeSettings*, Guid*, void**, int>)(lpVtbl[0]))((IApplicationDesignModeSettings*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IApplicationDesignModeSettings*, uint>)(lpVtbl[1]))((IApplicationDesignModeSettings*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IApplicationDesignModeSettings*, uint>)(lpVtbl[2]))((IApplicationDesignModeSettings*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetNativeDisplaySize(SIZE nativeDisplaySizePixels)
        {
            return ((delegate* unmanaged<IApplicationDesignModeSettings*, SIZE, int>)(lpVtbl[3]))((IApplicationDesignModeSettings*)Unsafe.AsPointer(ref this), nativeDisplaySizePixels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetScaleFactor(DEVICE_SCALE_FACTOR scaleFactor)
        {
            return ((delegate* unmanaged<IApplicationDesignModeSettings*, DEVICE_SCALE_FACTOR, int>)(lpVtbl[4]))((IApplicationDesignModeSettings*)Unsafe.AsPointer(ref this), scaleFactor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetApplicationViewState(APPLICATION_VIEW_STATE viewState)
        {
            return ((delegate* unmanaged<IApplicationDesignModeSettings*, APPLICATION_VIEW_STATE, int>)(lpVtbl[5]))((IApplicationDesignModeSettings*)Unsafe.AsPointer(ref this), viewState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int ComputeApplicationSize(SIZE* applicationSizePixels)
        {
            return ((delegate* unmanaged<IApplicationDesignModeSettings*, SIZE*, int>)(lpVtbl[6]))((IApplicationDesignModeSettings*)Unsafe.AsPointer(ref this), applicationSizePixels);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int IsApplicationViewStateSupported(APPLICATION_VIEW_STATE viewState, SIZE nativeDisplaySizePixels, DEVICE_SCALE_FACTOR scaleFactor, [NativeTypeName("BOOL *")] int* supported)
        {
            return ((delegate* unmanaged<IApplicationDesignModeSettings*, APPLICATION_VIEW_STATE, SIZE, DEVICE_SCALE_FACTOR, int*, int>)(lpVtbl[7]))((IApplicationDesignModeSettings*)Unsafe.AsPointer(ref this), viewState, nativeDisplaySizePixels, scaleFactor, supported);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int TriggerEdgeGesture(EDGE_GESTURE_KIND edgeGestureKind)
        {
            return ((delegate* unmanaged<IApplicationDesignModeSettings*, EDGE_GESTURE_KIND, int>)(lpVtbl[8]))((IApplicationDesignModeSettings*)Unsafe.AsPointer(ref this), edgeGestureKind);
        }
    }
}
