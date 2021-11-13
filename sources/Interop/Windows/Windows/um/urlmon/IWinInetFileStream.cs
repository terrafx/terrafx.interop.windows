// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("F134C4B7-B1F8-4E75-B886-74B90943BECB")]
    [NativeTypeName("struct IWinInetFileStream : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWinInetFileStream : IWinInetFileStream.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWinInetFileStream*, Guid*, void**, int>)(lpVtbl[0]))((IWinInetFileStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWinInetFileStream*, uint>)(lpVtbl[1]))((IWinInetFileStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWinInetFileStream*, uint>)(lpVtbl[2]))((IWinInetFileStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetHandleForUnlock([NativeTypeName("DWORD_PTR")] nuint hWinInetLockHandle, [NativeTypeName("DWORD_PTR")] nuint dwReserved)
        {
            return ((delegate* unmanaged<IWinInetFileStream*, nuint, nuint, int>)(lpVtbl[3]))((IWinInetFileStream*)Unsafe.AsPointer(ref this), hWinInetLockHandle, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetDeleteFile([NativeTypeName("DWORD_PTR")] nuint dwReserved)
        {
            return ((delegate* unmanaged<IWinInetFileStream*, nuint, int>)(lpVtbl[4]))((IWinInetFileStream*)Unsafe.AsPointer(ref this), dwReserved);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetHandleForUnlock([NativeTypeName("DWORD_PTR")] nuint hWinInetLockHandle, [NativeTypeName("DWORD_PTR")] nuint dwReserved);

            [VtblIndex(4)]
            HRESULT SetDeleteFile([NativeTypeName("DWORD_PTR")] nuint dwReserved);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWinInetFileStream*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWinInetFileStream*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWinInetFileStream*, uint> Release;

            [NativeTypeName("HRESULT (DWORD_PTR, DWORD_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IWinInetFileStream*, nuint, nuint, int> SetHandleForUnlock;

            [NativeTypeName("HRESULT (DWORD_PTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IWinInetFileStream*, nuint, int> SetDeleteFile;
        }
    }
}
