// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mediaobj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BE8F4F4E-5B16-4D29-B350-7F6B5D9298AC")]
    [NativeTypeName("struct IDMOVideoOutputOptimizations : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDMOVideoOutputOptimizations
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDMOVideoOutputOptimizations*, Guid*, void**, int>)(lpVtbl[0]))((IDMOVideoOutputOptimizations*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDMOVideoOutputOptimizations*, uint>)(lpVtbl[1]))((IDMOVideoOutputOptimizations*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDMOVideoOutputOptimizations*, uint>)(lpVtbl[2]))((IDMOVideoOutputOptimizations*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int QueryOperationModePreferences([NativeTypeName("ULONG")] uint ulOutputStreamIndex, [NativeTypeName("DWORD *")] uint* pdwRequestedCapabilities)
        {
            return ((delegate* unmanaged<IDMOVideoOutputOptimizations*, uint, uint*, int>)(lpVtbl[3]))((IDMOVideoOutputOptimizations*)Unsafe.AsPointer(ref this), ulOutputStreamIndex, pdwRequestedCapabilities);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SetOperationMode([NativeTypeName("ULONG")] uint ulOutputStreamIndex, [NativeTypeName("DWORD")] uint dwEnabledFeatures)
        {
            return ((delegate* unmanaged<IDMOVideoOutputOptimizations*, uint, uint, int>)(lpVtbl[4]))((IDMOVideoOutputOptimizations*)Unsafe.AsPointer(ref this), ulOutputStreamIndex, dwEnabledFeatures);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentOperationMode([NativeTypeName("ULONG")] uint ulOutputStreamIndex, [NativeTypeName("DWORD *")] uint* pdwEnabledFeatures)
        {
            return ((delegate* unmanaged<IDMOVideoOutputOptimizations*, uint, uint*, int>)(lpVtbl[5]))((IDMOVideoOutputOptimizations*)Unsafe.AsPointer(ref this), ulOutputStreamIndex, pdwEnabledFeatures);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentSampleRequirements([NativeTypeName("ULONG")] uint ulOutputStreamIndex, [NativeTypeName("DWORD *")] uint* pdwRequestedFeatures)
        {
            return ((delegate* unmanaged<IDMOVideoOutputOptimizations*, uint, uint*, int>)(lpVtbl[6]))((IDMOVideoOutputOptimizations*)Unsafe.AsPointer(ref this), ulOutputStreamIndex, pdwRequestedFeatures);
        }
    }
}
