// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/manipulations.h and um/manipulations_i.c in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("18B00C6D-C5EE-41B1-90A9-9D4A929095AD")]
    [NativeTypeName("struct IInertiaProcessor : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IInertiaProcessor
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, Guid*, void**, int>)(lpVtbl[0]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IInertiaProcessor*, uint>)(lpVtbl[1]))((IInertiaProcessor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IInertiaProcessor*, uint>)(lpVtbl[2]))((IInertiaProcessor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT get_InitialOriginX(float* x)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[3]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT put_InitialOriginX(float x)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[4]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT get_InitialOriginY(float* y)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[5]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT put_InitialOriginY(float y)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[6]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_InitialVelocityX(float* x)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[7]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT put_InitialVelocityX(float x)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[8]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_InitialVelocityY(float* y)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[9]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT put_InitialVelocityY(float y)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[10]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT get_InitialAngularVelocity(float* velocity)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[11]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), velocity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT put_InitialAngularVelocity(float velocity)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[12]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), velocity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT get_InitialExpansionVelocity(float* velocity)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[13]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), velocity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT put_InitialExpansionVelocity(float velocity)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[14]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), velocity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT get_InitialRadius(float* radius)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[15]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT put_InitialRadius(float radius)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[16]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT get_BoundaryLeft(float* left)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[17]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT put_BoundaryLeft(float left)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[18]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT get_BoundaryTop(float* top)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[19]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), top);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT put_BoundaryTop(float top)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[20]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), top);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT get_BoundaryRight(float* right)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[21]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT put_BoundaryRight(float right)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[22]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT get_BoundaryBottom(float* bottom)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[23]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), bottom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        public HRESULT put_BoundaryBottom(float bottom)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[24]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), bottom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        public HRESULT get_ElasticMarginLeft(float* left)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[25]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        public HRESULT put_ElasticMarginLeft(float left)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[26]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        public HRESULT get_ElasticMarginTop(float* top)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[27]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), top);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        public HRESULT put_ElasticMarginTop(float top)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[28]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), top);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        public HRESULT get_ElasticMarginRight(float* right)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[29]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        public HRESULT put_ElasticMarginRight(float right)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[30]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        public HRESULT get_ElasticMarginBottom(float* bottom)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[31]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), bottom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        public HRESULT put_ElasticMarginBottom(float bottom)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[32]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), bottom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        public HRESULT get_DesiredDisplacement(float* displacement)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[33]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), displacement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        public HRESULT put_DesiredDisplacement(float displacement)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[34]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), displacement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        public HRESULT get_DesiredRotation(float* rotation)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[35]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), rotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        public HRESULT put_DesiredRotation(float rotation)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[36]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), rotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        public HRESULT get_DesiredExpansion(float* expansion)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[37]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), expansion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        public HRESULT put_DesiredExpansion(float expansion)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[38]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), expansion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        public HRESULT get_DesiredDeceleration(float* deceleration)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[39]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), deceleration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        public HRESULT put_DesiredDeceleration(float deceleration)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[40]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), deceleration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        public HRESULT get_DesiredAngularDeceleration(float* deceleration)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[41]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), deceleration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        public HRESULT put_DesiredAngularDeceleration(float deceleration)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[42]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), deceleration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        public HRESULT get_DesiredExpansionDeceleration(float* deceleration)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[43]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), deceleration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        public HRESULT put_DesiredExpansionDeceleration(float deceleration)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[44]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), deceleration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        public HRESULT get_InitialTimestamp([NativeTypeName("DWORD *")] uint* timestamp)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, uint*, int>)(lpVtbl[45]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), timestamp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        public HRESULT put_InitialTimestamp([NativeTypeName("DWORD")] uint timestamp)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, uint, int>)(lpVtbl[46]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), timestamp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IInertiaProcessor*, int>)(lpVtbl[47]))((IInertiaProcessor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        public HRESULT Process(BOOL* completed)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, BOOL*, int>)(lpVtbl[48]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), completed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        public HRESULT ProcessTime([NativeTypeName("DWORD")] uint timestamp, BOOL* completed)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, uint, BOOL*, int>)(lpVtbl[49]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), timestamp, completed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        public HRESULT Complete()
        {
            return ((delegate* unmanaged<IInertiaProcessor*, int>)(lpVtbl[50]))((IInertiaProcessor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        public HRESULT CompleteTime([NativeTypeName("DWORD")] uint timestamp)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, uint, int>)(lpVtbl[51]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), timestamp);
        }
    }
}
