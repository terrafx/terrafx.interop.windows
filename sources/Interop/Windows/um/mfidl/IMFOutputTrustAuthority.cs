// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D19F8E94-B126-4446-890C-5DCB7AD71453")]
    [NativeTypeName("struct IMFOutputTrustAuthority : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFOutputTrustAuthority
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFOutputTrustAuthority*, Guid*, void**, int>)(lpVtbl[0]))((IMFOutputTrustAuthority*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFOutputTrustAuthority*, uint>)(lpVtbl[1]))((IMFOutputTrustAuthority*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFOutputTrustAuthority*, uint>)(lpVtbl[2]))((IMFOutputTrustAuthority*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetAction(MFPOLICYMANAGER_ACTION* pAction)
        {
            return ((delegate* unmanaged<IMFOutputTrustAuthority*, MFPOLICYMANAGER_ACTION*, int>)(lpVtbl[3]))((IMFOutputTrustAuthority*)Unsafe.AsPointer(ref this), pAction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetPolicy(IMFOutputPolicy** ppPolicy, [NativeTypeName("DWORD")] uint nPolicy, byte** ppbTicket, [NativeTypeName("DWORD *")] uint* pcbTicket)
        {
            return ((delegate* unmanaged<IMFOutputTrustAuthority*, IMFOutputPolicy**, uint, byte**, uint*, int>)(lpVtbl[4]))((IMFOutputTrustAuthority*)Unsafe.AsPointer(ref this), ppPolicy, nPolicy, ppbTicket, pcbTicket);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFOutputTrustAuthority*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFOutputTrustAuthority*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFOutputTrustAuthority*, uint> Release;

            [NativeTypeName("HRESULT (MFPOLICYMANAGER_ACTION *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFOutputTrustAuthority*, MFPOLICYMANAGER_ACTION*, int> GetAction;

            [NativeTypeName("HRESULT (IMFOutputPolicy **, DWORD, BYTE **, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFOutputTrustAuthority*, IMFOutputPolicy**, uint, byte**, uint*, int> SetPolicy;
        }
    }
}
