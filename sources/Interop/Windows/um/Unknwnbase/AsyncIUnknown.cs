// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Unknwnbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000E0000-0000-0000-C000-000000000046")]
    [NativeTypeName("struct AsyncIUnknown : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct AsyncIUnknown
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<AsyncIUnknown*, Guid*, void**, int>)(lpVtbl[0]))((AsyncIUnknown*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<AsyncIUnknown*, uint>)(lpVtbl[1]))((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<AsyncIUnknown*, uint>)(lpVtbl[2]))((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Begin_QueryInterface([NativeTypeName("const IID &")] Guid* riid)
        {
            return ((delegate* unmanaged<AsyncIUnknown*, Guid*, int>)(lpVtbl[3]))((AsyncIUnknown*)Unsafe.AsPointer(ref this), riid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Finish_QueryInterface(void** ppvObject)
        {
            return ((delegate* unmanaged<AsyncIUnknown*, void**, int>)(lpVtbl[4]))((AsyncIUnknown*)Unsafe.AsPointer(ref this), ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Begin_AddRef()
        {
            return ((delegate* unmanaged<AsyncIUnknown*, int>)(lpVtbl[5]))((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("ULONG")]
        public uint Finish_AddRef()
        {
            return ((delegate* unmanaged<AsyncIUnknown*, uint>)(lpVtbl[6]))((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int Begin_Release()
        {
            return ((delegate* unmanaged<AsyncIUnknown*, int>)(lpVtbl[7]))((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("ULONG")]
        public uint Finish_Release()
        {
            return ((delegate* unmanaged<AsyncIUnknown*, uint>)(lpVtbl[8]))((AsyncIUnknown*)Unsafe.AsPointer(ref this));
        }
    }
}
