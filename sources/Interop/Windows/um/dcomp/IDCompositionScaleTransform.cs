// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("71FDE914-40EF-45EF-BD51-68B037C339F9")]
    [NativeTypeName("struct IDCompositionScaleTransform : IDCompositionTransform")]
    [NativeInheritance("IDCompositionTransform")]
    public unsafe partial struct IDCompositionScaleTransform
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionScaleTransform*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionScaleTransform*, uint>)(lpVtbl[1]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionScaleTransform*, uint>)(lpVtbl[2]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetScaleX(float scaleX)
        {
            return ((delegate* unmanaged<IDCompositionScaleTransform*, float, int>)(lpVtbl[4]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), scaleX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetScaleX(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionScaleTransform*, IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetScaleY(float scaleY)
        {
            return ((delegate* unmanaged<IDCompositionScaleTransform*, float, int>)(lpVtbl[6]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), scaleY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetScaleY(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionScaleTransform*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int SetCenterX(float centerX)
        {
            return ((delegate* unmanaged<IDCompositionScaleTransform*, float, int>)(lpVtbl[8]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), centerX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetCenterX(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionScaleTransform*, IDCompositionAnimation*, int>)(lpVtbl[7]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int SetCenterY(float centerY)
        {
            return ((delegate* unmanaged<IDCompositionScaleTransform*, float, int>)(lpVtbl[10]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), centerY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int SetCenterY(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionScaleTransform*, IDCompositionAnimation*, int>)(lpVtbl[9]))((IDCompositionScaleTransform*)Unsafe.AsPointer(ref this), animation);
        }
    }
}
