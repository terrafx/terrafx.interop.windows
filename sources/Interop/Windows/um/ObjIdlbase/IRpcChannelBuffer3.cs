// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("25B15600-0115-11D0-BF0D-00AA00B8DFD2")]
    [NativeTypeName("struct IRpcChannelBuffer3 : IRpcChannelBuffer2")]
    public unsafe partial struct IRpcChannelBuffer3
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IRpcChannelBuffer3*, Guid*, void**, int>)(lpVtbl[0]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IRpcChannelBuffer3*, uint>)(lpVtbl[1]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IRpcChannelBuffer3*, uint>)(lpVtbl[2]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBuffer([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage, [NativeTypeName("const IID &")] Guid* riid)
        {
            return ((delegate* stdcall<IRpcChannelBuffer3*, RPCOLEMESSAGE*, Guid*, int>)(lpVtbl[3]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMessage, riid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SendReceive([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage, [NativeTypeName("ULONG *")] uint* pStatus)
        {
            return ((delegate* stdcall<IRpcChannelBuffer3*, RPCOLEMESSAGE*, uint*, int>)(lpVtbl[4]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMessage, pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FreeBuffer([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMessage)
        {
            return ((delegate* stdcall<IRpcChannelBuffer3*, RPCOLEMESSAGE*, int>)(lpVtbl[5]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMessage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDestCtx([NativeTypeName("DWORD *")] uint* pdwDestContext, [NativeTypeName("void **")] void** ppvDestContext)
        {
            return ((delegate* stdcall<IRpcChannelBuffer3*, uint*, void**, int>)(lpVtbl[6]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pdwDestContext, ppvDestContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsConnected()
        {
            return ((delegate* stdcall<IRpcChannelBuffer3*, int>)(lpVtbl[7]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetProtocolVersion([NativeTypeName("DWORD *")] uint* pdwVersion)
        {
            return ((delegate* stdcall<IRpcChannelBuffer3*, uint*, int>)(lpVtbl[8]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pdwVersion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Send([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("ULONG *")] uint* pulStatus)
        {
            return ((delegate* stdcall<IRpcChannelBuffer3*, RPCOLEMESSAGE*, uint*, int>)(lpVtbl[9]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, pulStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Receive([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("ULONG")] uint ulSize, [NativeTypeName("ULONG *")] uint* pulStatus)
        {
            return ((delegate* stdcall<IRpcChannelBuffer3*, RPCOLEMESSAGE*, uint, uint*, int>)(lpVtbl[10]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, ulSize, pulStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Cancel([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg)
        {
            return ((delegate* stdcall<IRpcChannelBuffer3*, RPCOLEMESSAGE*, int>)(lpVtbl[11]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCallContext([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** pInterface)
        {
            return ((delegate* stdcall<IRpcChannelBuffer3*, RPCOLEMESSAGE*, Guid*, void**, int>)(lpVtbl[12]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, riid, pInterface);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDestCtxEx([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("DWORD *")] uint* pdwDestContext, [NativeTypeName("void **")] void** ppvDestContext)
        {
            return ((delegate* stdcall<IRpcChannelBuffer3*, RPCOLEMESSAGE*, uint*, void**, int>)(lpVtbl[13]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, pdwDestContext, ppvDestContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetState([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("DWORD *")] uint* pState)
        {
            return ((delegate* stdcall<IRpcChannelBuffer3*, RPCOLEMESSAGE*, uint*, int>)(lpVtbl[14]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, pState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterAsync([NativeTypeName("RPCOLEMESSAGE *")] RPCOLEMESSAGE* pMsg, [NativeTypeName("IAsyncManager *")] IAsyncManager* pAsyncMgr)
        {
            return ((delegate* stdcall<IRpcChannelBuffer3*, RPCOLEMESSAGE*, IAsyncManager*, int>)(lpVtbl[15]))((IRpcChannelBuffer3*)Unsafe.AsPointer(ref this), pMsg, pAsyncMgr);
        }
    }
}
