// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1BE09788-6894-4089-8586-9A2A6C265AC5")]
    [NativeTypeName("struct IMMEndpoint : IUnknown")]
    public unsafe partial struct IMMEndpoint
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMMEndpoint*, Guid*, void**, int>)(lpVtbl[0]))((IMMEndpoint*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMMEndpoint*, uint>)(lpVtbl[1]))((IMMEndpoint*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMMEndpoint*, uint>)(lpVtbl[2]))((IMMEndpoint*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDataFlow([NativeTypeName("EDataFlow *")] EDataFlow* pDataFlow)
        {
            return ((delegate* stdcall<IMMEndpoint*, EDataFlow*, int>)(lpVtbl[3]))((IMMEndpoint*)Unsafe.AsPointer(ref this), pDataFlow);
        }
    }
}
