// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D5F56B60-593B-101A-B569-08002B2DBF7A")]
    [NativeTypeName("struct IRpcChannelBuffer : IUnknown")]
    public unsafe partial struct IRpcChannelBuffer
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IRpcChannelBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IRpcChannelBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IRpcChannelBuffer*, uint>)(lpVtbl[1]))((IRpcChannelBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IRpcChannelBuffer*, uint>)(lpVtbl[2]))((IRpcChannelBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBuffer([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage, [NativeTypeName("const IID &")] Guid* riid)
        {
            return ((delegate* stdcall<IRpcChannelBuffer*, RPCOLEMESSAGE*, Guid*, int>)(lpVtbl[3]))((IRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMessage, riid);
        }

        [return: NativeTypeName("HRESULT")]
        public int SendReceive([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage, [NativeTypeName("ULONG *")] uint* pStatus)
        {
            return ((delegate* stdcall<IRpcChannelBuffer*, RPCOLEMESSAGE*, uint*, int>)(lpVtbl[4]))((IRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMessage, pStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int FreeBuffer([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage)
        {
            return ((delegate* stdcall<IRpcChannelBuffer*, RPCOLEMESSAGE*, int>)(lpVtbl[5]))((IRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMessage);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDestCtx([NativeTypeName("DWORD *")] uint* pdwDestContext, [NativeTypeName("void **")] void** ppvDestContext)
        {
            return ((delegate* stdcall<IRpcChannelBuffer*, uint*, void**, int>)(lpVtbl[6]))((IRpcChannelBuffer*)Unsafe.AsPointer(ref this), pdwDestContext, ppvDestContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsConnected()
        {
            return ((delegate* stdcall<IRpcChannelBuffer*, int>)(lpVtbl[7]))((IRpcChannelBuffer*)Unsafe.AsPointer(ref this));
        }
    }
}
