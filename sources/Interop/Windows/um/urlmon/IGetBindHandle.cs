// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AF0FF408-129D-4B20-91F0-02BD23D88352")]
    [NativeTypeName("struct IGetBindHandle : IUnknown")]
    public unsafe partial struct IGetBindHandle
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IGetBindHandle*, Guid*, void**, int>)(lpVtbl[0]))((IGetBindHandle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGetBindHandle*, uint>)(lpVtbl[1]))((IGetBindHandle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGetBindHandle*, uint>)(lpVtbl[2]))((IGetBindHandle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBindHandle(BINDHANDLETYPES enumRequestedHandle, [NativeTypeName("HANDLE *")] IntPtr* pRetHandle)
        {
            return ((delegate* unmanaged<IGetBindHandle*, BINDHANDLETYPES, IntPtr*, int>)(lpVtbl[3]))((IGetBindHandle*)Unsafe.AsPointer(ref this), enumRequestedHandle, pRetHandle);
        }
    }
}
