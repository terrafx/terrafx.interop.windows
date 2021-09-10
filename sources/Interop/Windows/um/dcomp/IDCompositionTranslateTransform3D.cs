// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("91636D4B-9BA1-4532-AAF7-E3344994D788")]
    [NativeTypeName("struct IDCompositionTranslateTransform3D : IDCompositionTransform3D")]
    [NativeInheritance("IDCompositionTransform3D")]
    public unsafe partial struct IDCompositionTranslateTransform3D
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDCompositionTranslateTransform3D*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDCompositionTranslateTransform3D*, uint>)(lpVtbl[1]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDCompositionTranslateTransform3D*, uint>)(lpVtbl[2]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetX(float offsetX)
        {
            return ((delegate* unmanaged<IDCompositionTranslateTransform3D*, float, int>)(lpVtbl[4]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), offsetX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetX(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionTranslateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetY(float offsetY)
        {
            return ((delegate* unmanaged<IDCompositionTranslateTransform3D*, float, int>)(lpVtbl[6]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), offsetY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetY(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionTranslateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), animation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetZ(float offsetZ)
        {
            return ((delegate* unmanaged<IDCompositionTranslateTransform3D*, float, int>)(lpVtbl[8]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), offsetZ);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetOffsetZ(IDCompositionAnimation* animation)
        {
            return ((delegate* unmanaged<IDCompositionTranslateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[7]))((IDCompositionTranslateTransform3D*)Unsafe.AsPointer(ref this), animation);
        }
    }
}
