// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("61E00D45-8FFF-4E60-924E-6537B61612DD")]
    [NativeTypeName("struct IEnumReadyCallback : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumReadyCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumReadyCallback*, Guid*, void**, int>)(lpVtbl[0]))((IEnumReadyCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumReadyCallback*, uint>)(lpVtbl[1]))((IEnumReadyCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumReadyCallback*, uint>)(lpVtbl[2]))((IEnumReadyCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int EnumReady()
        {
            return ((delegate* unmanaged<IEnumReadyCallback*, int>)(lpVtbl[3]))((IEnumReadyCallback*)Unsafe.AsPointer(ref this));
        }
    }
}
