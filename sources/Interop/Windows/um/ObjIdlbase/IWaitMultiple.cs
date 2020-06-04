// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000002B-0000-0000-C000-000000000046")]
    public unsafe partial struct IWaitMultiple
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWaitMultiple*, Guid*, void**, int>)(lpVtbl[0]))((IWaitMultiple*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWaitMultiple*, uint>)(lpVtbl[1]))((IWaitMultiple*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWaitMultiple*, uint>)(lpVtbl[2]))((IWaitMultiple*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int WaitMultiple([NativeTypeName("DWORD")] uint timeout, [NativeTypeName("ISynchronize **")] ISynchronize** pSync)
        {
            return ((delegate* stdcall<IWaitMultiple*, uint, ISynchronize**, int>)(lpVtbl[3]))((IWaitMultiple*)Unsafe.AsPointer(ref this), timeout, pSync);
        }

        [return: NativeTypeName("HRESULT")]
        public int AddSynchronize([NativeTypeName("ISynchronize *")] ISynchronize* pSync)
        {
            return ((delegate* stdcall<IWaitMultiple*, ISynchronize*, int>)(lpVtbl[4]))((IWaitMultiple*)Unsafe.AsPointer(ref this), pSync);
        }
    }
}
