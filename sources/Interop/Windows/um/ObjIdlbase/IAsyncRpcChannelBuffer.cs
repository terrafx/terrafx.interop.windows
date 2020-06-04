// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A5029FB6-3C34-11D1-9C99-00C04FB998AA")]
    public unsafe partial struct IAsyncRpcChannelBuffer
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAsyncRpcChannelBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAsyncRpcChannelBuffer*, uint>)(lpVtbl[1]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAsyncRpcChannelBuffer*, uint>)(lpVtbl[2]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBuffer([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage, [NativeTypeName("const IID &")] Guid* riid)
        {
            return ((delegate* stdcall<IAsyncRpcChannelBuffer*, RPCOLEMESSAGE*, Guid*, int>)(lpVtbl[3]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMessage, riid);
        }

        [return: NativeTypeName("HRESULT")]
        public int SendReceive([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage, [NativeTypeName("ULONG *")] uint* pStatus)
        {
            return ((delegate* stdcall<IAsyncRpcChannelBuffer*, RPCOLEMESSAGE*, uint*, int>)(lpVtbl[4]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMessage, pStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int FreeBuffer([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage)
        {
            return ((delegate* stdcall<IAsyncRpcChannelBuffer*, RPCOLEMESSAGE*, int>)(lpVtbl[5]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMessage);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDestCtx([NativeTypeName("DWORD *")] uint* pdwDestContext, [NativeTypeName("void **")] void** ppvDestContext)
        {
            return ((delegate* stdcall<IAsyncRpcChannelBuffer*, uint*, void**, int>)(lpVtbl[6]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pdwDestContext, ppvDestContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsConnected()
        {
            return ((delegate* stdcall<IAsyncRpcChannelBuffer*, int>)(lpVtbl[7]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProtocolVersion([NativeTypeName("DWORD *")] uint* pdwVersion)
        {
            return ((delegate* stdcall<IAsyncRpcChannelBuffer*, uint*, int>)(lpVtbl[8]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pdwVersion);
        }

        [return: NativeTypeName("HRESULT")]
        public int Send([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("ISynchronize *")] ISynchronize* pSync, [NativeTypeName("ULONG *")] uint* pulStatus)
        {
            return ((delegate* stdcall<IAsyncRpcChannelBuffer*, RPCOLEMESSAGE*, ISynchronize*, uint*, int>)(lpVtbl[9]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMsg, pSync, pulStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int Receive([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("ULONG *")] uint* pulStatus)
        {
            return ((delegate* stdcall<IAsyncRpcChannelBuffer*, RPCOLEMESSAGE*, uint*, int>)(lpVtbl[10]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMsg, pulStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDestCtxEx([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("DWORD *")] uint* pdwDestContext, [NativeTypeName("void **")] void** ppvDestContext)
        {
            return ((delegate* stdcall<IAsyncRpcChannelBuffer*, RPCOLEMESSAGE*, uint*, void**, int>)(lpVtbl[11]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMsg, pdwDestContext, ppvDestContext);
        }
    }
}
