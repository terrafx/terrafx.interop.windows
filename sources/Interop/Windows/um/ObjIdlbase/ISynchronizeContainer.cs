// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000033-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ISynchronizeContainer : IUnknown")]
    public unsafe partial struct ISynchronizeContainer
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISynchronizeContainer*, Guid*, void**, int>)(lpVtbl[0]))((ISynchronizeContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISynchronizeContainer*, uint>)(lpVtbl[1]))((ISynchronizeContainer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISynchronizeContainer*, uint>)(lpVtbl[2]))((ISynchronizeContainer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int AddSynchronize([NativeTypeName("ISynchronize *")] ISynchronize* pSync)
        {
            return ((delegate* stdcall<ISynchronizeContainer*, ISynchronize*, int>)(lpVtbl[3]))((ISynchronizeContainer*)Unsafe.AsPointer(ref this), pSync);
        }

        [return: NativeTypeName("HRESULT")]
        public int WaitMultiple([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwTimeOut, [NativeTypeName("ISynchronize **")] ISynchronize** ppSync)
        {
            return ((delegate* stdcall<ISynchronizeContainer*, uint, uint, ISynchronize**, int>)(lpVtbl[4]))((ISynchronizeContainer*)Unsafe.AsPointer(ref this), dwFlags, dwTimeOut, ppSync);
        }
    }
}
