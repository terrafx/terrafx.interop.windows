// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapo.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("26D95C66-80F2-499A-AD54-5AE7F01C6D98")]
    public unsafe partial struct IXAPOParameters
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IXAPOParameters*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IXAPOParameters*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IXAPOParameters*)Unsafe.AsPointer(ref this));
        }

        public void SetParameters([NativeTypeName("const void *")] void* pParameters, [NativeTypeName("UINT32")] uint ParameterByteSize)
        {
            lpVtbl->SetParameters((IXAPOParameters*)Unsafe.AsPointer(ref this), pParameters, ParameterByteSize);
        }

        public void GetParameters([NativeTypeName("void *")] void* pParameters, [NativeTypeName("UINT32")] uint ParameterByteSize)
        {
            lpVtbl->GetParameters((IXAPOParameters*)Unsafe.AsPointer(ref this), pParameters, ParameterByteSize);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IXAPOParameters*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IXAPOParameters*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IXAPOParameters*, uint> Release;

            [NativeTypeName("void (const void *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAPOParameters*, void*, uint, void> SetParameters;

            [NativeTypeName("void (void *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IXAPOParameters*, void*, uint, void> GetParameters;
        }
    }
}
