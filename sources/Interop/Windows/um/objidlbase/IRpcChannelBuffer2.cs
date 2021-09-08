// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("594F31D0-7F19-11D0-B194-00A0C90DC8BF")]
    [NativeTypeName("struct IRpcChannelBuffer2 : IRpcChannelBuffer")]
    [NativeInheritance("IRpcChannelBuffer")]
    public unsafe partial struct IRpcChannelBuffer2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer2*, Guid*, void**, int>)(lpVtbl[0]))((IRpcChannelBuffer2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IRpcChannelBuffer2*, uint>)(lpVtbl[1]))((IRpcChannelBuffer2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IRpcChannelBuffer2*, uint>)(lpVtbl[2]))((IRpcChannelBuffer2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetBuffer(RPCOLEMESSAGE* pMessage, [NativeTypeName("const IID &")] Guid* riid)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer2*, RPCOLEMESSAGE*, Guid*, int>)(lpVtbl[3]))((IRpcChannelBuffer2*)Unsafe.AsPointer(ref this), pMessage, riid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int SendReceive(RPCOLEMESSAGE* pMessage, [NativeTypeName("ULONG *")] uint* pStatus)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer2*, RPCOLEMESSAGE*, uint*, int>)(lpVtbl[4]))((IRpcChannelBuffer2*)Unsafe.AsPointer(ref this), pMessage, pStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int FreeBuffer(RPCOLEMESSAGE* pMessage)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer2*, RPCOLEMESSAGE*, int>)(lpVtbl[5]))((IRpcChannelBuffer2*)Unsafe.AsPointer(ref this), pMessage);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetDestCtx([NativeTypeName("DWORD *")] uint* pdwDestContext, void** ppvDestContext)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer2*, uint*, void**, int>)(lpVtbl[6]))((IRpcChannelBuffer2*)Unsafe.AsPointer(ref this), pdwDestContext, ppvDestContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int IsConnected()
        {
            return ((delegate* unmanaged<IRpcChannelBuffer2*, int>)(lpVtbl[7]))((IRpcChannelBuffer2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetProtocolVersion([NativeTypeName("DWORD *")] uint* pdwVersion)
        {
            return ((delegate* unmanaged<IRpcChannelBuffer2*, uint*, int>)(lpVtbl[8]))((IRpcChannelBuffer2*)Unsafe.AsPointer(ref this), pdwVersion);
        }
    }
}
