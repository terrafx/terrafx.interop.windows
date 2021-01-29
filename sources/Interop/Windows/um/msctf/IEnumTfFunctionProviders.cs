// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("E4B24DB0-0990-11D3-8DF0-00105A2799B5")]
    [NativeTypeName("struct IEnumTfFunctionProviders : IUnknown")]
    public unsafe partial struct IEnumTfFunctionProviders
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumTfFunctionProviders*, Guid*, void**, int>)(lpVtbl[0]))((IEnumTfFunctionProviders*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumTfFunctionProviders*, uint>)(lpVtbl[1]))((IEnumTfFunctionProviders*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumTfFunctionProviders*, uint>)(lpVtbl[2]))((IEnumTfFunctionProviders*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumTfFunctionProviders **")] IEnumTfFunctionProviders** ppEnum)
        {
            return ((delegate* unmanaged<IEnumTfFunctionProviders*, IEnumTfFunctionProviders**, int>)(lpVtbl[3]))((IEnumTfFunctionProviders*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("ITfFunctionProvider **")] ITfFunctionProvider** ppCmdobj, [NativeTypeName("ULONG *")] uint* pcFetch)
        {
            return ((delegate* unmanaged<IEnumTfFunctionProviders*, uint, ITfFunctionProvider**, uint*, int>)(lpVtbl[4]))((IEnumTfFunctionProviders*)Unsafe.AsPointer(ref this), ulCount, ppCmdobj, pcFetch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumTfFunctionProviders*, int>)(lpVtbl[5]))((IEnumTfFunctionProviders*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint ulCount)
        {
            return ((delegate* unmanaged<IEnumTfFunctionProviders*, uint, int>)(lpVtbl[6]))((IEnumTfFunctionProviders*)Unsafe.AsPointer(ref this), ulCount);
        }
    }
}
