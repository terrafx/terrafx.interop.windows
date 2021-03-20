// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("22F3B823-0B7C-424E-9DF7-33D4F962931B")]
    [NativeTypeName("struct ITouchHitTestingEventArgs : IInspectable")]
    public unsafe partial struct ITouchHitTestingEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITouchHitTestingEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ITouchHitTestingEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITouchHitTestingEventArgs*, uint>)(lpVtbl[1]))((ITouchHitTestingEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITouchHitTestingEventArgs*, uint>)(lpVtbl[2]))((ITouchHitTestingEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ITouchHitTestingEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ITouchHitTestingEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<ITouchHitTestingEventArgs*, IntPtr*, int>)(lpVtbl[4]))((ITouchHitTestingEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ITouchHitTestingEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ITouchHitTestingEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ProximityEvaluation([NativeTypeName("ABI::Windows::UI::Core::CoreProximityEvaluation *")] CoreProximityEvaluation* value)
        {
            return ((delegate* unmanaged<ITouchHitTestingEventArgs*, CoreProximityEvaluation*, int>)(lpVtbl[6]))((ITouchHitTestingEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_ProximityEvaluation([NativeTypeName("ABI::Windows::UI::Core::CoreProximityEvaluation")] CoreProximityEvaluation value)
        {
            return ((delegate* unmanaged<ITouchHitTestingEventArgs*, CoreProximityEvaluation, int>)(lpVtbl[7]))((ITouchHitTestingEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Point([NativeTypeName("ABI::Windows::Foundation::Point *")] Point* value)
        {
            return ((delegate* unmanaged<ITouchHitTestingEventArgs*, Point*, int>)(lpVtbl[8]))((ITouchHitTestingEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_BoundingBox([NativeTypeName("ABI::Windows::Foundation::Rect *")] Rect* value)
        {
            return ((delegate* unmanaged<ITouchHitTestingEventArgs*, Rect*, int>)(lpVtbl[9]))((ITouchHitTestingEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EvaluateProximityToRect([NativeTypeName("ABI::Windows::Foundation::Rect")] Rect controlBoundingBox, [NativeTypeName("ABI::Windows::UI::Core::CoreProximityEvaluation *")] CoreProximityEvaluation* proximityEvaluation)
        {
            return ((delegate* unmanaged<ITouchHitTestingEventArgs*, Rect, CoreProximityEvaluation*, int>)(lpVtbl[10]))((ITouchHitTestingEventArgs*)Unsafe.AsPointer(ref this), controlBoundingBox, proximityEvaluation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EvaluateProximityToPolygon([NativeTypeName("UINT32")] uint controlVerticesLength, [NativeTypeName("ABI::Windows::Foundation::Point *")] Point* controlVertices, [NativeTypeName("ABI::Windows::UI::Core::CoreProximityEvaluation *")] CoreProximityEvaluation* proximityEvaluation)
        {
            return ((delegate* unmanaged<ITouchHitTestingEventArgs*, uint, Point*, CoreProximityEvaluation*, int>)(lpVtbl[11]))((ITouchHitTestingEventArgs*)Unsafe.AsPointer(ref this), controlVerticesLength, controlVertices, proximityEvaluation);
        }
    }
}
