// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AF0FF408-129D-4B20-91F0-02BD23D88352")]
    [NativeTypeName("struct IGetBindHandle : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IGetBindHandle : IGetBindHandle.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IGetBindHandle*, Guid*, void**, int>)(lpVtbl[0]))((IGetBindHandle*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGetBindHandle*, uint>)(lpVtbl[1]))((IGetBindHandle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGetBindHandle*, uint>)(lpVtbl[2]))((IGetBindHandle*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetBindHandle(BINDHANDLETYPES enumRequestedHandle, HANDLE* pRetHandle)
        {
            return ((delegate* unmanaged<IGetBindHandle*, BINDHANDLETYPES, HANDLE*, int>)(lpVtbl[3]))((IGetBindHandle*)Unsafe.AsPointer(ref this), enumRequestedHandle, pRetHandle);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetBindHandle(BINDHANDLETYPES enumRequestedHandle, HANDLE* pRetHandle);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IGetBindHandle*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IGetBindHandle*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IGetBindHandle*, uint> Release;

            [NativeTypeName("HRESULT (BINDHANDLETYPES, HANDLE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IGetBindHandle*, BINDHANDLETYPES, HANDLE*, int> GetBindHandle;
        }
    }
}
