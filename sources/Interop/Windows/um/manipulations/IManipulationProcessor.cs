// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/manipulations.h and um/manipulations_i.c in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A22AC519-8300-48A0-BEF4-F1BE8737DBA4")]
    [NativeTypeName("struct IManipulationProcessor : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IManipulationProcessor
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IManipulationProcessor*, Guid*, void**, int>)(lpVtbl[0]))((IManipulationProcessor*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IManipulationProcessor*, uint>)(lpVtbl[1]))((IManipulationProcessor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IManipulationProcessor*, uint>)(lpVtbl[2]))((IManipulationProcessor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT get_SupportedManipulations(MANIPULATION_PROCESSOR_MANIPULATIONS* manipulations)
        {
            return ((delegate* unmanaged<IManipulationProcessor*, MANIPULATION_PROCESSOR_MANIPULATIONS*, int>)(lpVtbl[3]))((IManipulationProcessor*)Unsafe.AsPointer(ref this), manipulations);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT put_SupportedManipulations(MANIPULATION_PROCESSOR_MANIPULATIONS manipulations)
        {
            return ((delegate* unmanaged<IManipulationProcessor*, MANIPULATION_PROCESSOR_MANIPULATIONS, int>)(lpVtbl[4]))((IManipulationProcessor*)Unsafe.AsPointer(ref this), manipulations);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT get_PivotPointX([NativeTypeName("FLOAT *")] float* pivotPointX)
        {
            return ((delegate* unmanaged<IManipulationProcessor*, float*, int>)(lpVtbl[5]))((IManipulationProcessor*)Unsafe.AsPointer(ref this), pivotPointX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT put_PivotPointX([NativeTypeName("FLOAT")] float pivotPointX)
        {
            return ((delegate* unmanaged<IManipulationProcessor*, float, int>)(lpVtbl[6]))((IManipulationProcessor*)Unsafe.AsPointer(ref this), pivotPointX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_PivotPointY([NativeTypeName("FLOAT *")] float* pivotPointY)
        {
            return ((delegate* unmanaged<IManipulationProcessor*, float*, int>)(lpVtbl[7]))((IManipulationProcessor*)Unsafe.AsPointer(ref this), pivotPointY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT put_PivotPointY([NativeTypeName("FLOAT")] float pivotPointY)
        {
            return ((delegate* unmanaged<IManipulationProcessor*, float, int>)(lpVtbl[8]))((IManipulationProcessor*)Unsafe.AsPointer(ref this), pivotPointY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT get_PivotRadius([NativeTypeName("FLOAT *")] float* pivotRadius)
        {
            return ((delegate* unmanaged<IManipulationProcessor*, float*, int>)(lpVtbl[9]))((IManipulationProcessor*)Unsafe.AsPointer(ref this), pivotRadius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT put_PivotRadius([NativeTypeName("FLOAT")] float pivotRadius)
        {
            return ((delegate* unmanaged<IManipulationProcessor*, float, int>)(lpVtbl[10]))((IManipulationProcessor*)Unsafe.AsPointer(ref this), pivotRadius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT CompleteManipulation()
        {
            return ((delegate* unmanaged<IManipulationProcessor*, int>)(lpVtbl[11]))((IManipulationProcessor*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT ProcessDown([NativeTypeName("MANIPULATOR_ID")] uint manipulatorId, [NativeTypeName("FLOAT")] float x, [NativeTypeName("FLOAT")] float y)
        {
            return ((delegate* unmanaged<IManipulationProcessor*, uint, float, float, int>)(lpVtbl[12]))((IManipulationProcessor*)Unsafe.AsPointer(ref this), manipulatorId, x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT ProcessMove([NativeTypeName("MANIPULATOR_ID")] uint manipulatorId, [NativeTypeName("FLOAT")] float x, [NativeTypeName("FLOAT")] float y)
        {
            return ((delegate* unmanaged<IManipulationProcessor*, uint, float, float, int>)(lpVtbl[13]))((IManipulationProcessor*)Unsafe.AsPointer(ref this), manipulatorId, x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT ProcessUp([NativeTypeName("MANIPULATOR_ID")] uint manipulatorId, [NativeTypeName("FLOAT")] float x, [NativeTypeName("FLOAT")] float y)
        {
            return ((delegate* unmanaged<IManipulationProcessor*, uint, float, float, int>)(lpVtbl[14]))((IManipulationProcessor*)Unsafe.AsPointer(ref this), manipulatorId, x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT ProcessDownWithTime([NativeTypeName("MANIPULATOR_ID")] uint manipulatorId, [NativeTypeName("FLOAT")] float x, [NativeTypeName("FLOAT")] float y, [NativeTypeName("DWORD")] uint timestamp)
        {
            return ((delegate* unmanaged<IManipulationProcessor*, uint, float, float, uint, int>)(lpVtbl[15]))((IManipulationProcessor*)Unsafe.AsPointer(ref this), manipulatorId, x, y, timestamp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT ProcessMoveWithTime([NativeTypeName("MANIPULATOR_ID")] uint manipulatorId, [NativeTypeName("FLOAT")] float x, [NativeTypeName("FLOAT")] float y, [NativeTypeName("DWORD")] uint timestamp)
        {
            return ((delegate* unmanaged<IManipulationProcessor*, uint, float, float, uint, int>)(lpVtbl[16]))((IManipulationProcessor*)Unsafe.AsPointer(ref this), manipulatorId, x, y, timestamp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT ProcessUpWithTime([NativeTypeName("MANIPULATOR_ID")] uint manipulatorId, [NativeTypeName("FLOAT")] float x, [NativeTypeName("FLOAT")] float y, [NativeTypeName("DWORD")] uint timestamp)
        {
            return ((delegate* unmanaged<IManipulationProcessor*, uint, float, float, uint, int>)(lpVtbl[17]))((IManipulationProcessor*)Unsafe.AsPointer(ref this), manipulatorId, x, y, timestamp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetVelocityX([NativeTypeName("FLOAT *")] float* velocityX)
        {
            return ((delegate* unmanaged<IManipulationProcessor*, float*, int>)(lpVtbl[18]))((IManipulationProcessor*)Unsafe.AsPointer(ref this), velocityX);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT GetVelocityY([NativeTypeName("FLOAT *")] float* velocityY)
        {
            return ((delegate* unmanaged<IManipulationProcessor*, float*, int>)(lpVtbl[19]))((IManipulationProcessor*)Unsafe.AsPointer(ref this), velocityY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT GetExpansionVelocity([NativeTypeName("FLOAT *")] float* expansionVelocity)
        {
            return ((delegate* unmanaged<IManipulationProcessor*, float*, int>)(lpVtbl[20]))((IManipulationProcessor*)Unsafe.AsPointer(ref this), expansionVelocity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT GetAngularVelocity([NativeTypeName("FLOAT *")] float* angularVelocity)
        {
            return ((delegate* unmanaged<IManipulationProcessor*, float*, int>)(lpVtbl[21]))((IManipulationProcessor*)Unsafe.AsPointer(ref this), angularVelocity);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT get_MinimumScaleRotateRadius([NativeTypeName("FLOAT *")] float* minRadius)
        {
            return ((delegate* unmanaged<IManipulationProcessor*, float*, int>)(lpVtbl[22]))((IManipulationProcessor*)Unsafe.AsPointer(ref this), minRadius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT put_MinimumScaleRotateRadius([NativeTypeName("FLOAT")] float minRadius)
        {
            return ((delegate* unmanaged<IManipulationProcessor*, float, int>)(lpVtbl[23]))((IManipulationProcessor*)Unsafe.AsPointer(ref this), minRadius);
        }
    }
}
