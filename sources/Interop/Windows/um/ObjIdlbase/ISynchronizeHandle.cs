// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000031-0000-0000-C000-000000000046")]
    public unsafe partial struct ISynchronizeHandle
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISynchronizeHandle*, Guid*, void**, int>)(lpVtbl[0]))((ISynchronizeHandle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISynchronizeHandle*, uint>)(lpVtbl[1]))((ISynchronizeHandle*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISynchronizeHandle*, uint>)(lpVtbl[2]))((ISynchronizeHandle*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetHandle([NativeTypeName("HANDLE *")] IntPtr* ph)
        {
            return ((delegate* stdcall<ISynchronizeHandle*, IntPtr*, int>)(lpVtbl[3]))((ISynchronizeHandle*)Unsafe.AsPointer(ref this), ph);
        }
    }
}
