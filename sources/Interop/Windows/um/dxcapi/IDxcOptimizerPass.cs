// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AE2CD79F-CC22-453F-9B6B-B124E7A5204C")]
    [NativeTypeName("struct IDxcOptimizerPass : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDxcOptimizerPass
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDxcOptimizerPass*, Guid*, void**, int>)(lpVtbl[0]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDxcOptimizerPass*, uint>)(lpVtbl[1]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDxcOptimizerPass*, uint>)(lpVtbl[2]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetOptionName([NativeTypeName("LPWSTR *")] ushort** ppResult)
        {
            return ((delegate* unmanaged<IDxcOptimizerPass*, ushort**, int>)(lpVtbl[3]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetDescription([NativeTypeName("LPWSTR *")] ushort** ppResult)
        {
            return ((delegate* unmanaged<IDxcOptimizerPass*, ushort**, int>)(lpVtbl[4]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetOptionArgCount([NativeTypeName("UINT32 *")] uint* pCount)
        {
            return ((delegate* unmanaged<IDxcOptimizerPass*, uint*, int>)(lpVtbl[5]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), pCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetOptionArgName([NativeTypeName("UINT32")] uint argIndex, [NativeTypeName("LPWSTR *")] ushort** ppResult)
        {
            return ((delegate* unmanaged<IDxcOptimizerPass*, uint, ushort**, int>)(lpVtbl[6]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), argIndex, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetOptionArgDescription([NativeTypeName("UINT32")] uint argIndex, [NativeTypeName("LPWSTR *")] ushort** ppResult)
        {
            return ((delegate* unmanaged<IDxcOptimizerPass*, uint, ushort**, int>)(lpVtbl[7]))((IDxcOptimizerPass*)Unsafe.AsPointer(ref this), argIndex, ppResult);
        }
    }
}
