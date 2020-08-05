// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D19F8E94-B126-4446-890C-5DCB7AD71453")]
    [NativeTypeName("struct IMFOutputTrustAuthority : IUnknown")]
    public unsafe partial struct IMFOutputTrustAuthority
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFOutputTrustAuthority*, Guid*, void**, int>)(lpVtbl[0]))((IMFOutputTrustAuthority*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFOutputTrustAuthority*, uint>)(lpVtbl[1]))((IMFOutputTrustAuthority*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFOutputTrustAuthority*, uint>)(lpVtbl[2]))((IMFOutputTrustAuthority*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAction([NativeTypeName("MFPOLICYMANAGER_ACTION *")] MFPOLICYMANAGER_ACTION* pAction)
        {
            return ((delegate* stdcall<IMFOutputTrustAuthority*, MFPOLICYMANAGER_ACTION*, int>)(lpVtbl[3]))((IMFOutputTrustAuthority*)Unsafe.AsPointer(ref this), pAction);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPolicy([NativeTypeName("IMFOutputPolicy **")] IMFOutputPolicy** ppPolicy, [NativeTypeName("DWORD")] uint nPolicy, [NativeTypeName("BYTE **")] byte** ppbTicket, [NativeTypeName("DWORD *")] uint* pcbTicket)
        {
            return ((delegate* stdcall<IMFOutputTrustAuthority*, IMFOutputPolicy**, uint, byte**, uint*, int>)(lpVtbl[4]))((IMFOutputTrustAuthority*)Unsafe.AsPointer(ref this), ppPolicy, nPolicy, ppbTicket, pcbTicket);
        }
    }
}
