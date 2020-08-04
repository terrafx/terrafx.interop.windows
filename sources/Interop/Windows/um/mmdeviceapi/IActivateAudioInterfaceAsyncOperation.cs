// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("72A22D78-CDE4-431D-B8CC-843A71199B6D")]
    public unsafe partial struct IActivateAudioInterfaceAsyncOperation
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IActivateAudioInterfaceAsyncOperation*, Guid*, void**, int>)(lpVtbl[0]))((IActivateAudioInterfaceAsyncOperation*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IActivateAudioInterfaceAsyncOperation*, uint>)(lpVtbl[1]))((IActivateAudioInterfaceAsyncOperation*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IActivateAudioInterfaceAsyncOperation*, uint>)(lpVtbl[2]))((IActivateAudioInterfaceAsyncOperation*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetActivateResult([NativeTypeName("HRESULT *")] int* activateResult, [NativeTypeName("IUnknown **")] IUnknown** activatedInterface)
        {
            return ((delegate* stdcall<IActivateAudioInterfaceAsyncOperation*, int*, IUnknown**, int>)(lpVtbl[3]))((IActivateAudioInterfaceAsyncOperation*)Unsafe.AsPointer(ref this), activateResult, activatedInterface);
        }
    }
}
