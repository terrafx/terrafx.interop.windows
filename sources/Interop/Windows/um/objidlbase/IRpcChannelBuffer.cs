// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D5F56B60-593B-101A-B569-08002B2DBF7A")]
    [NativeTypeName("struct IRpcChannelBuffer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IRpcChannelBuffer : IRpcChannelBuffer.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IRpcChannelBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRpcChannelBuffer*, uint>)(lpVtbl[1]))((IRpcChannelBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRpcChannelBuffer*, uint>)(lpVtbl[2]))((IRpcChannelBuffer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetBuffer(RPCOLEMESSAGE* pMessage, [NativeTypeName("const IID &")] Guid* riid)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer*, RPCOLEMESSAGE*, Guid*, int>)(lpVtbl[3]))((IRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMessage, riid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SendReceive(RPCOLEMESSAGE* pMessage, [NativeTypeName("ULONG *")] uint* pStatus)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer*, RPCOLEMESSAGE*, uint*, int>)(lpVtbl[4]))((IRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMessage, pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT FreeBuffer(RPCOLEMESSAGE* pMessage)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer*, RPCOLEMESSAGE*, int>)(lpVtbl[5]))((IRpcChannelBuffer*)Unsafe.AsPointer(ref this), pMessage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetDestCtx([NativeTypeName("DWORD *")] uint* pdwDestContext, void** ppvDestContext)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer*, uint*, void**, int>)(lpVtbl[6]))((IRpcChannelBuffer*)Unsafe.AsPointer(ref this), pdwDestContext, ppvDestContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT IsConnected()
        {
            return ((delegate* unmanaged<IRpcChannelBuffer*, int>)(lpVtbl[7]))((IRpcChannelBuffer*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetBuffer(RPCOLEMESSAGE* pMessage, [NativeTypeName("const IID &")] Guid* riid);

            [VtblIndex(4)]
            HRESULT SendReceive(RPCOLEMESSAGE* pMessage, [NativeTypeName("ULONG *")] uint* pStatus);

            [VtblIndex(5)]
            HRESULT FreeBuffer(RPCOLEMESSAGE* pMessage);

            [VtblIndex(6)]
            HRESULT GetDestCtx([NativeTypeName("DWORD *")] uint* pdwDestContext, void** ppvDestContext);

            [VtblIndex(7)]
            HRESULT IsConnected();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IRpcChannelBuffer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IRpcChannelBuffer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IRpcChannelBuffer*, uint> Release;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, const IID &) __attribute__((stdcall))")]
            public delegate* unmanaged<IRpcChannelBuffer*, RPCOLEMESSAGE*, Guid*, int> GetBuffer;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IRpcChannelBuffer*, RPCOLEMESSAGE*, uint*, int> SendReceive;

            [NativeTypeName("HRESULT (RPCOLEMESSAGE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IRpcChannelBuffer*, RPCOLEMESSAGE*, int> FreeBuffer;

            [NativeTypeName("HRESULT (DWORD *, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IRpcChannelBuffer*, uint*, void**, int> GetDestCtx;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IRpcChannelBuffer*, int> IsConnected;
        }
    }
}
