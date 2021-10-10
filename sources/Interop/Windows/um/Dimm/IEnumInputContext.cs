// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Dimm.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("09B5EAB0-F997-11D1-93D4-0060B067B86E")]
    [NativeTypeName("struct IEnumInputContext : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumInputContext
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumInputContext*, Guid*, void**, int>)(lpVtbl[0]))((IEnumInputContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumInputContext*, uint>)(lpVtbl[1]))((IEnumInputContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumInputContext*, uint>)(lpVtbl[2]))((IEnumInputContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumInputContext** ppEnum)
        {
            return ((delegate* unmanaged<IEnumInputContext*, IEnumInputContext**, int>)(lpVtbl[3]))((IEnumInputContext*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("HIMC *")] IntPtr* rgInputContext, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<IEnumInputContext*, uint, IntPtr*, uint*, int>)(lpVtbl[4]))((IEnumInputContext*)Unsafe.AsPointer(ref this), ulCount, rgInputContext, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumInputContext*, int>)(lpVtbl[5]))((IEnumInputContext*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint ulCount)
        {
            return ((delegate* unmanaged<IEnumInputContext*, uint, int>)(lpVtbl[6]))((IEnumInputContext*)Unsafe.AsPointer(ref this), ulCount);
        }
    }
}
