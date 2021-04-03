// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8F1B8AD8-0B6B-4874-90C5-BD76011E8F7C")]
    [NativeTypeName("struct ITfMessagePump : IUnknown")]
    public unsafe partial struct ITfMessagePump
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfMessagePump*, Guid*, void**, int>)(lpVtbl[0]))((ITfMessagePump*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfMessagePump*, uint>)(lpVtbl[1]))((ITfMessagePump*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfMessagePump*, uint>)(lpVtbl[2]))((ITfMessagePump*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PeekMessageA([NativeTypeName("LPMSG")] MSG* pMsg, [NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("UINT")] uint wMsgFilterMin, [NativeTypeName("UINT")] uint wMsgFilterMax, [NativeTypeName("UINT")] uint wRemoveMsg, [NativeTypeName("BOOL *")] int* pfResult)
        {
            return ((delegate* unmanaged<ITfMessagePump*, MSG*, IntPtr, uint, uint, uint, int*, int>)(lpVtbl[3]))((ITfMessagePump*)Unsafe.AsPointer(ref this), pMsg, hwnd, wMsgFilterMin, wMsgFilterMax, wRemoveMsg, pfResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMessageA([NativeTypeName("LPMSG")] MSG* pMsg, [NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("UINT")] uint wMsgFilterMin, [NativeTypeName("UINT")] uint wMsgFilterMax, [NativeTypeName("BOOL *")] int* pfResult)
        {
            return ((delegate* unmanaged<ITfMessagePump*, MSG*, IntPtr, uint, uint, int*, int>)(lpVtbl[4]))((ITfMessagePump*)Unsafe.AsPointer(ref this), pMsg, hwnd, wMsgFilterMin, wMsgFilterMax, pfResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int PeekMessageW([NativeTypeName("LPMSG")] MSG* pMsg, [NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("UINT")] uint wMsgFilterMin, [NativeTypeName("UINT")] uint wMsgFilterMax, [NativeTypeName("UINT")] uint wRemoveMsg, [NativeTypeName("BOOL *")] int* pfResult)
        {
            return ((delegate* unmanaged<ITfMessagePump*, MSG*, IntPtr, uint, uint, uint, int*, int>)(lpVtbl[5]))((ITfMessagePump*)Unsafe.AsPointer(ref this), pMsg, hwnd, wMsgFilterMin, wMsgFilterMax, wRemoveMsg, pfResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMessageW([NativeTypeName("LPMSG")] MSG* pMsg, [NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("UINT")] uint wMsgFilterMin, [NativeTypeName("UINT")] uint wMsgFilterMax, [NativeTypeName("BOOL *")] int* pfResult)
        {
            return ((delegate* unmanaged<ITfMessagePump*, MSG*, IntPtr, uint, uint, int*, int>)(lpVtbl[6]))((ITfMessagePump*)Unsafe.AsPointer(ref this), pMsg, hwnd, wMsgFilterMin, wMsgFilterMax, pfResult);
        }
    }
}
