// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E4B24DB0-0990-11D3-8DF0-00105A2799B5")]
    [NativeTypeName("struct IEnumTfFunctionProviders : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumTfFunctionProviders
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumTfFunctionProviders*, Guid*, void**, int>)(lpVtbl[0]))((IEnumTfFunctionProviders*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumTfFunctionProviders*, uint>)(lpVtbl[1]))((IEnumTfFunctionProviders*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumTfFunctionProviders*, uint>)(lpVtbl[2]))((IEnumTfFunctionProviders*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Clone(IEnumTfFunctionProviders** ppEnum)
        {
            return ((delegate* unmanaged<IEnumTfFunctionProviders*, IEnumTfFunctionProviders**, int>)(lpVtbl[3]))((IEnumTfFunctionProviders*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Next([NativeTypeName("ULONG")] uint ulCount, ITfFunctionProvider** ppCmdobj, [NativeTypeName("ULONG *")] uint* pcFetch)
        {
            return ((delegate* unmanaged<IEnumTfFunctionProviders*, uint, ITfFunctionProvider**, uint*, int>)(lpVtbl[4]))((IEnumTfFunctionProviders*)Unsafe.AsPointer(ref this), ulCount, ppCmdobj, pcFetch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IEnumTfFunctionProviders*, int>)(lpVtbl[5]))((IEnumTfFunctionProviders*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Skip([NativeTypeName("ULONG")] uint ulCount)
        {
            return ((delegate* unmanaged<IEnumTfFunctionProviders*, uint, int>)(lpVtbl[6]))((IEnumTfFunctionProviders*)Unsafe.AsPointer(ref this), ulCount);
        }
    }
}
