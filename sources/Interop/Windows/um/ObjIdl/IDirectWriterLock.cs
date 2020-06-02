// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0E6D4D92-6738-11CF-9608-00AA00680DB4")]
    public unsafe partial struct IDirectWriterLock
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDirectWriterLock*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDirectWriterLock*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDirectWriterLock*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int WaitForWriteAccess([NativeTypeName("DWORD")] uint dwTimeout)
        {
            return lpVtbl->WaitForWriteAccess((IDirectWriterLock*)Unsafe.AsPointer(ref this), dwTimeout);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseWriteAccess()
        {
            return lpVtbl->ReleaseWriteAccess((IDirectWriterLock*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int HaveWriteAccess()
        {
            return lpVtbl->HaveWriteAccess((IDirectWriterLock*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDirectWriterLock*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDirectWriterLock*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDirectWriterLock*, uint> Release;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IDirectWriterLock*, uint, int> WaitForWriteAccess;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IDirectWriterLock*, int> ReleaseWriteAccess;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IDirectWriterLock*, int> HaveWriteAccess;
        }
    }
}
