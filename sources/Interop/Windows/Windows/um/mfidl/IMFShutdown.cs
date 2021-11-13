// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("97EC2EA4-0E42-4937-97AC-9D6D328824E1")]
    [NativeTypeName("struct IMFShutdown : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFShutdown : IMFShutdown.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFShutdown*, Guid*, void**, int>)(lpVtbl[0]))((IMFShutdown*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFShutdown*, uint>)(lpVtbl[1]))((IMFShutdown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFShutdown*, uint>)(lpVtbl[2]))((IMFShutdown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Shutdown()
        {
            return ((delegate* unmanaged<IMFShutdown*, int>)(lpVtbl[3]))((IMFShutdown*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetShutdownStatus(MFSHUTDOWN_STATUS* pStatus)
        {
            return ((delegate* unmanaged<IMFShutdown*, MFSHUTDOWN_STATUS*, int>)(lpVtbl[4]))((IMFShutdown*)Unsafe.AsPointer(ref this), pStatus);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Shutdown();

            [VtblIndex(4)]
            HRESULT GetShutdownStatus(MFSHUTDOWN_STATUS* pStatus);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFShutdown*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFShutdown*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFShutdown*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFShutdown*, int> Shutdown;

            [NativeTypeName("HRESULT (MFSHUTDOWN_STATUS *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFShutdown*, MFSHUTDOWN_STATUS*, int> GetShutdownStatus;
        }
    }
}
