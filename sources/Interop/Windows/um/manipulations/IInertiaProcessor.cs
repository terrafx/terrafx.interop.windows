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
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
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
        [return: NativeTypeName("HRESULT")]
        public int get_InitialOriginX([NativeTypeName("FLOAT *")] float* x)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[3]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int put_InitialOriginX([NativeTypeName("FLOAT")] float x)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[4]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int get_InitialOriginY([NativeTypeName("FLOAT *")] float* y)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[5]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int put_InitialOriginY([NativeTypeName("FLOAT")] float y)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[6]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_InitialVelocityX([NativeTypeName("FLOAT *")] float* x)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[7]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int put_InitialVelocityX([NativeTypeName("FLOAT")] float x)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[8]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int get_InitialVelocityY([NativeTypeName("FLOAT *")] float* y)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[9]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int put_InitialVelocityY([NativeTypeName("FLOAT")] float y)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[10]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int get_InitialAngularVelocity([NativeTypeName("FLOAT *")] float* velocity)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[11]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), velocity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int put_InitialAngularVelocity([NativeTypeName("FLOAT")] float velocity)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[12]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), velocity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_InitialExpansionVelocity([NativeTypeName("FLOAT *")] float* velocity)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[13]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), velocity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int put_InitialExpansionVelocity([NativeTypeName("FLOAT")] float velocity)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[14]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), velocity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int get_InitialRadius([NativeTypeName("FLOAT *")] float* radius)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[15]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int put_InitialRadius([NativeTypeName("FLOAT")] float radius)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[16]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_BoundaryLeft([NativeTypeName("FLOAT *")] float* left)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[17]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int put_BoundaryLeft([NativeTypeName("FLOAT")] float left)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[18]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_BoundaryTop([NativeTypeName("FLOAT *")] float* top)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[19]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), top);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int put_BoundaryTop([NativeTypeName("FLOAT")] float top)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[20]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), top);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_BoundaryRight([NativeTypeName("FLOAT *")] float* right)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[21]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int put_BoundaryRight([NativeTypeName("FLOAT")] float right)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[22]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int get_BoundaryBottom([NativeTypeName("FLOAT *")] float* bottom)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[23]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), bottom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int put_BoundaryBottom([NativeTypeName("FLOAT")] float bottom)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[24]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), bottom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int get_ElasticMarginLeft([NativeTypeName("FLOAT *")] float* left)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[25]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int put_ElasticMarginLeft([NativeTypeName("FLOAT")] float left)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[26]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int get_ElasticMarginTop([NativeTypeName("FLOAT *")] float* top)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[27]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), top);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int put_ElasticMarginTop([NativeTypeName("FLOAT")] float top)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[28]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), top);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int get_ElasticMarginRight([NativeTypeName("FLOAT *")] float* right)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[29]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int put_ElasticMarginRight([NativeTypeName("FLOAT")] float right)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[30]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int get_ElasticMarginBottom([NativeTypeName("FLOAT *")] float* bottom)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[31]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), bottom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int put_ElasticMarginBottom([NativeTypeName("FLOAT")] float bottom)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[32]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), bottom);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int get_DesiredDisplacement([NativeTypeName("FLOAT *")] float* displacement)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[33]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), displacement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int put_DesiredDisplacement([NativeTypeName("FLOAT")] float displacement)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[34]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), displacement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int get_DesiredRotation([NativeTypeName("FLOAT *")] float* rotation)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[35]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), rotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int put_DesiredRotation([NativeTypeName("FLOAT")] float rotation)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[36]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), rotation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int get_DesiredExpansion([NativeTypeName("FLOAT *")] float* expansion)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[37]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), expansion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int put_DesiredExpansion([NativeTypeName("FLOAT")] float expansion)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[38]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), expansion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int get_DesiredDeceleration([NativeTypeName("FLOAT *")] float* deceleration)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[39]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), deceleration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int put_DesiredDeceleration([NativeTypeName("FLOAT")] float deceleration)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[40]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), deceleration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int get_DesiredAngularDeceleration([NativeTypeName("FLOAT *")] float* deceleration)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[41]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), deceleration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int put_DesiredAngularDeceleration([NativeTypeName("FLOAT")] float deceleration)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[42]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), deceleration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int get_DesiredExpansionDeceleration([NativeTypeName("FLOAT *")] float* deceleration)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float*, int>)(lpVtbl[43]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), deceleration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int put_DesiredExpansionDeceleration([NativeTypeName("FLOAT")] float deceleration)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, float, int>)(lpVtbl[44]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), deceleration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int get_InitialTimestamp([NativeTypeName("DWORD *")] uint* timestamp)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, uint*, int>)(lpVtbl[45]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), timestamp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int put_InitialTimestamp([NativeTypeName("DWORD")] uint timestamp)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, uint, int>)(lpVtbl[46]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), timestamp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IInertiaProcessor*, int>)(lpVtbl[47]))((IInertiaProcessor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int Process(BOOL* completed)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, BOOL*, int>)(lpVtbl[48]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), completed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int ProcessTime([NativeTypeName("DWORD")] uint timestamp, BOOL* completed)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, uint, BOOL*, int>)(lpVtbl[49]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), timestamp, completed);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int Complete()
        {
            return ((delegate* unmanaged<IInertiaProcessor*, int>)(lpVtbl[50]))((IInertiaProcessor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int CompleteTime([NativeTypeName("DWORD")] uint timestamp)
        {
            return ((delegate* unmanaged<IInertiaProcessor*, uint, int>)(lpVtbl[51]))((IInertiaProcessor*)Unsafe.AsPointer(ref this), timestamp);
        }
    }
}
