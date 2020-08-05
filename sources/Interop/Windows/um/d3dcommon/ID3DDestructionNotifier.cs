// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcommon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A06EB39A-50DA-425B-8C31-4EECD6C270F3")]
    [NativeTypeName("struct ID3DDestructionNotifier : IUnknown")]
    public unsafe partial struct ID3DDestructionNotifier
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3DDestructionNotifier*, Guid*, void**, int>)(lpVtbl[0]))((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3DDestructionNotifier*, uint>)(lpVtbl[1]))((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3DDestructionNotifier*, uint>)(lpVtbl[2]))((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterDestructionCallback([NativeTypeName("PFN_DESTRUCTION_CALLBACK")] delegate* stdcall<void*, void> callbackFn, [NativeTypeName("void *")] void* pData, [NativeTypeName("UINT *")] uint* pCallbackID)
        {
            return ((delegate* stdcall<ID3DDestructionNotifier*, delegate* stdcall<void*, void>, void*, uint*, int>)(lpVtbl[3]))((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this), callbackFn, pData, pCallbackID);
        }

        [return: NativeTypeName("HRESULT")]
        public int UnregisterDestructionCallback([NativeTypeName("UINT")] uint callbackID)
        {
            return ((delegate* stdcall<ID3DDestructionNotifier*, uint, int>)(lpVtbl[4]))((ID3DDestructionNotifier*)Unsafe.AsPointer(ref this), callbackID);
        }
    }
}
