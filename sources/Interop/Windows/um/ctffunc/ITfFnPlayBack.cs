// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A3A416A4-0F64-11D3-B5B7-00C04FC324A1")]
    [NativeTypeName("struct ITfFnPlayBack : ITfFunction")]
    public unsafe partial struct ITfFnPlayBack
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfFnPlayBack*, Guid*, void**, int>)(lpVtbl[0]))((ITfFnPlayBack*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfFnPlayBack*, uint>)(lpVtbl[1]))((ITfFnPlayBack*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfFnPlayBack*, uint>)(lpVtbl[2]))((ITfFnPlayBack*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<ITfFnPlayBack*, ushort**, int>)(lpVtbl[3]))((ITfFnPlayBack*)Unsafe.AsPointer(ref this), pbstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryRange([NativeTypeName("ITfRange *")] ITfRange* pRange, [NativeTypeName("ITfRange **")] ITfRange** ppNewRange, [NativeTypeName("BOOL *")] int* pfPlayable)
        {
            return ((delegate* unmanaged<ITfFnPlayBack*, ITfRange*, ITfRange**, int*, int>)(lpVtbl[4]))((ITfFnPlayBack*)Unsafe.AsPointer(ref this), pRange, ppNewRange, pfPlayable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Play([NativeTypeName("ITfRange *")] ITfRange* pRange)
        {
            return ((delegate* unmanaged<ITfFnPlayBack*, ITfRange*, int>)(lpVtbl[5]))((ITfFnPlayBack*)Unsafe.AsPointer(ref this), pRange);
        }
    }
}
