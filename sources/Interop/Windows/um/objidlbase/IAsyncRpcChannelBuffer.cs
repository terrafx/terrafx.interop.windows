// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A5029FB6-3C34-11D1-9C99-00C04FB998AA")]
    [NativeTypeName("struct IAsyncRpcChannelBuffer : IRpcChannelBuffer2")]
    [NativeInheritance("IRpcChannelBuffer2")]
    public unsafe partial struct IAsyncRpcChannelBuffer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAsyncRpcChannelBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAsyncRpcChannelBuffer*, uint>)(lpVtbl[1]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAsyncRpcChannelBuffer*, uint>)(lpVtbl[2]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetBuffer(RPCOLEMESSAGE* pMessage, [NativeTypeName("const IID &")] Guid* riid)
        {
            return ((delegate* unmanaged<IAsyncRpcChannelBuffer*, RPCOLEMESSAGE*, Guid*, int>)(lpVtbl[3]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMessage, riid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SendReceive(RPCOLEMESSAGE* pMessage, [NativeTypeName("ULONG *")] uint* pStatus)
        {
            return ((delegate* unmanaged<IAsyncRpcChannelBuffer*, RPCOLEMESSAGE*, uint*, int>)(lpVtbl[4]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMessage, pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT FreeBuffer(RPCOLEMESSAGE* pMessage)
        {
            return ((delegate* unmanaged<IAsyncRpcChannelBuffer*, RPCOLEMESSAGE*, int>)(lpVtbl[5]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMessage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetDestCtx([NativeTypeName("DWORD *")] uint* pdwDestContext, void** ppvDestContext)
        {
            return ((delegate* unmanaged<IAsyncRpcChannelBuffer*, uint*, void**, int>)(lpVtbl[6]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pdwDestContext, ppvDestContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT IsConnected()
        {
            return ((delegate* unmanaged<IAsyncRpcChannelBuffer*, int>)(lpVtbl[7]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetProtocolVersion([NativeTypeName("DWORD *")] uint* pdwVersion)
        {
            return ((delegate* unmanaged<IAsyncRpcChannelBuffer*, uint*, int>)(lpVtbl[8]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pdwVersion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT Send(RPCOLEMESSAGE* pMsg, ISynchronize* pSync, [NativeTypeName("ULONG *")] uint* pulStatus)
        {
            return ((delegate* unmanaged<IAsyncRpcChannelBuffer*, RPCOLEMESSAGE*, ISynchronize*, uint*, int>)(lpVtbl[9]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMsg, pSync, pulStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT Receive(RPCOLEMESSAGE* pMsg, [NativeTypeName("ULONG *")] uint* pulStatus)
        {
            return ((delegate* unmanaged<IAsyncRpcChannelBuffer*, RPCOLEMESSAGE*, uint*, int>)(lpVtbl[10]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMsg, pulStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetDestCtxEx(RPCOLEMESSAGE* pMsg, [NativeTypeName("DWORD *")] uint* pdwDestContext, void** ppvDestContext)
        {
            return ((delegate* unmanaged<IAsyncRpcChannelBuffer*, RPCOLEMESSAGE*, uint*, void**, int>)(lpVtbl[11]))((IAsyncRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMsg, pdwDestContext, ppvDestContext);
        }
    }
}
