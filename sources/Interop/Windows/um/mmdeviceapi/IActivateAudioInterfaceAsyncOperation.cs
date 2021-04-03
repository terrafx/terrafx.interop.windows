// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("72A22D78-CDE4-431D-B8CC-843A71199B6D")]
    [NativeTypeName("struct IActivateAudioInterfaceAsyncOperation : IUnknown")]
    public unsafe partial struct IActivateAudioInterfaceAsyncOperation
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IActivateAudioInterfaceAsyncOperation*, Guid*, void**, int>)(lpVtbl[0]))((IActivateAudioInterfaceAsyncOperation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IActivateAudioInterfaceAsyncOperation*, uint>)(lpVtbl[1]))((IActivateAudioInterfaceAsyncOperation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IActivateAudioInterfaceAsyncOperation*, uint>)(lpVtbl[2]))((IActivateAudioInterfaceAsyncOperation*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetActivateResult([NativeTypeName("HRESULT *")] int* activateResult, IUnknown** activatedInterface)
        {
            return ((delegate* unmanaged<IActivateAudioInterfaceAsyncOperation*, int*, IUnknown**, int>)(lpVtbl[3]))((IActivateAudioInterfaceAsyncOperation*)Unsafe.AsPointer(ref this), activateResult, activatedInterface);
        }
    }
}
