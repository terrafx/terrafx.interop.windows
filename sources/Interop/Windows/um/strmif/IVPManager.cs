// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AAC18C18-E186-46D2-825D-A1F8DC8E395A")]
    public unsafe partial struct IVPManager
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IVPManager*, Guid*, void**, int>)(lpVtbl[0]))((IVPManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IVPManager*, uint>)(lpVtbl[1]))((IVPManager*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IVPManager*, uint>)(lpVtbl[2]))((IVPManager*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVideoPortIndex([NativeTypeName("DWORD")] uint dwVideoPortIndex)
        {
            return ((delegate* stdcall<IVPManager*, uint, int>)(lpVtbl[3]))((IVPManager*)Unsafe.AsPointer(ref this), dwVideoPortIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetVideoPortIndex([NativeTypeName("DWORD *")] uint* pdwVideoPortIndex)
        {
            return ((delegate* stdcall<IVPManager*, uint*, int>)(lpVtbl[4]))((IVPManager*)Unsafe.AsPointer(ref this), pdwVideoPortIndex);
        }
    }
}
