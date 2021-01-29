// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("73131F9C-56A9-49DD-B0EE-D046633F7528")]
    [NativeTypeName("struct ITfSourceSingle : IUnknown")]
    public unsafe partial struct ITfSourceSingle
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfSourceSingle*, Guid*, void**, int>)(lpVtbl[0]))((ITfSourceSingle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfSourceSingle*, uint>)(lpVtbl[1]))((ITfSourceSingle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfSourceSingle*, uint>)(lpVtbl[2]))((ITfSourceSingle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AdviseSingleSink([NativeTypeName("TfClientId")] uint tid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown *")] IUnknown* punk)
        {
            return ((delegate* unmanaged<ITfSourceSingle*, uint, Guid*, IUnknown*, int>)(lpVtbl[3]))((ITfSourceSingle*)Unsafe.AsPointer(ref this), tid, riid, punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnadviseSingleSink([NativeTypeName("TfClientId")] uint tid, [NativeTypeName("const IID &")] Guid* riid)
        {
            return ((delegate* unmanaged<ITfSourceSingle*, uint, Guid*, int>)(lpVtbl[4]))((ITfSourceSingle*)Unsafe.AsPointer(ref this), tid, riid);
        }
    }
}
