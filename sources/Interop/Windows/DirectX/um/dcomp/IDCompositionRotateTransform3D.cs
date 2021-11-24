// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[SupportedOSPlatform("windows8.0")]
[Guid("D8F5B23F-D429-4A91-B55A-D2F45FD75B18")]
[NativeTypeName("struct IDCompositionRotateTransform3D : IDCompositionTransform3D")]
[NativeInheritance("IDCompositionTransform3D")]
public unsafe partial struct IDCompositionRotateTransform3D : IDCompositionRotateTransform3D.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionRotateTransform3D*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionRotateTransform3D*, uint>)(lpVtbl[1]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionRotateTransform3D*, uint>)(lpVtbl[2]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetAngle(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[3]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetAngle(float angle)
    {
        return ((delegate* unmanaged<IDCompositionRotateTransform3D*, float, int>)(lpVtbl[4]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), angle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetAxisX(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[5]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetAxisX(float axisX)
    {
        return ((delegate* unmanaged<IDCompositionRotateTransform3D*, float, int>)(lpVtbl[6]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), axisX);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetAxisY(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[7]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetAxisY(float axisY)
    {
        return ((delegate* unmanaged<IDCompositionRotateTransform3D*, float, int>)(lpVtbl[8]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), axisY);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetAxisZ(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[9]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetAxisZ(float axisZ)
    {
        return ((delegate* unmanaged<IDCompositionRotateTransform3D*, float, int>)(lpVtbl[10]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), axisZ);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetCenterX(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[11]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetCenterX(float centerX)
    {
        return ((delegate* unmanaged<IDCompositionRotateTransform3D*, float, int>)(lpVtbl[12]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), centerX);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetCenterY(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[13]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetCenterY(float centerY)
    {
        return ((delegate* unmanaged<IDCompositionRotateTransform3D*, float, int>)(lpVtbl[14]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), centerY);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetCenterZ(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int>)(lpVtbl[15]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetCenterZ(float centerZ)
    {
        return ((delegate* unmanaged<IDCompositionRotateTransform3D*, float, int>)(lpVtbl[16]))((IDCompositionRotateTransform3D*)Unsafe.AsPointer(ref this), centerZ);
    }

    public interface Interface : IDCompositionTransform3D.Interface
    {
        [VtblIndex(3)]
        HRESULT SetAngle(IDCompositionAnimation* animation);

        [VtblIndex(4)]
        HRESULT SetAngle(float angle);

        [VtblIndex(5)]
        HRESULT SetAxisX(IDCompositionAnimation* animation);

        [VtblIndex(6)]
        HRESULT SetAxisX(float axisX);

        [VtblIndex(7)]
        HRESULT SetAxisY(IDCompositionAnimation* animation);

        [VtblIndex(8)]
        HRESULT SetAxisY(float axisY);

        [VtblIndex(9)]
        HRESULT SetAxisZ(IDCompositionAnimation* animation);

        [VtblIndex(10)]
        HRESULT SetAxisZ(float axisZ);

        [VtblIndex(11)]
        HRESULT SetCenterX(IDCompositionAnimation* animation);

        [VtblIndex(12)]
        HRESULT SetCenterX(float centerX);

        [VtblIndex(13)]
        HRESULT SetCenterY(IDCompositionAnimation* animation);

        [VtblIndex(14)]
        HRESULT SetCenterY(float centerY);

        [VtblIndex(15)]
        HRESULT SetCenterZ(IDCompositionAnimation* animation);

        [VtblIndex(16)]
        HRESULT SetCenterZ(float centerZ);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionRotateTransform3D*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionRotateTransform3D*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionRotateTransform3D*, uint> Release;

        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int> SetAngle;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionRotateTransform3D*, float, int> SetAngle1;

        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int> SetAxisX;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionRotateTransform3D*, float, int> SetAxisX1;

        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int> SetAxisY;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionRotateTransform3D*, float, int> SetAxisY1;

        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int> SetAxisZ;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionRotateTransform3D*, float, int> SetAxisZ1;

        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int> SetCenterX;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionRotateTransform3D*, float, int> SetCenterX1;

        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int> SetCenterY;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionRotateTransform3D*, float, int> SetCenterY1;

        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionRotateTransform3D*, IDCompositionAnimation*, int> SetCenterZ;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDCompositionRotateTransform3D*, float, int> SetCenterZ1;
    }
}
