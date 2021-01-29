// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8F1A7EA6-1654-4502-A86E-B2902344D507")]
    [NativeTypeName("struct IEnumTfContexts : IUnknown")]
    public unsafe partial struct IEnumTfContexts
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumTfContexts*, Guid*, void**, int>)(lpVtbl[0]))((IEnumTfContexts*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumTfContexts*, uint>)(lpVtbl[1]))((IEnumTfContexts*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumTfContexts*, uint>)(lpVtbl[2]))((IEnumTfContexts*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumTfContexts **")] IEnumTfContexts** ppEnum)
        {
            return ((delegate* unmanaged<IEnumTfContexts*, IEnumTfContexts**, int>)(lpVtbl[3]))((IEnumTfContexts*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint ulCount, [NativeTypeName("ITfContext **")] ITfContext** rgContext, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<IEnumTfContexts*, uint, ITfContext**, uint*, int>)(lpVtbl[4]))((IEnumTfContexts*)Unsafe.AsPointer(ref this), ulCount, rgContext, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumTfContexts*, int>)(lpVtbl[5]))((IEnumTfContexts*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint ulCount)
        {
            return ((delegate* unmanaged<IEnumTfContexts*, uint, int>)(lpVtbl[6]))((IEnumTfContexts*)Unsafe.AsPointer(ref this), ulCount);
        }
    }
}
