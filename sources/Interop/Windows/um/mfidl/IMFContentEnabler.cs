// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D3C4EF59-49CE-4381-9071-D5BCD044C770")]
    public unsafe partial struct IMFContentEnabler
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFContentEnabler*, Guid*, void**, int>)(lpVtbl[0]))((IMFContentEnabler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFContentEnabler*, uint>)(lpVtbl[1]))((IMFContentEnabler*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFContentEnabler*, uint>)(lpVtbl[2]))((IMFContentEnabler*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEnableType([NativeTypeName("GUID *")] Guid* pType)
        {
            return ((delegate* stdcall<IMFContentEnabler*, Guid*, int>)(lpVtbl[3]))((IMFContentEnabler*)Unsafe.AsPointer(ref this), pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEnableURL([NativeTypeName("LPWSTR *")] ushort** ppwszURL, [NativeTypeName("DWORD *")] uint* pcchURL, [NativeTypeName("MF_URL_TRUST_STATUS *")] MF_URL_TRUST_STATUS* pTrustStatus)
        {
            return ((delegate* stdcall<IMFContentEnabler*, ushort**, uint*, MF_URL_TRUST_STATUS*, int>)(lpVtbl[4]))((IMFContentEnabler*)Unsafe.AsPointer(ref this), ppwszURL, pcchURL, pTrustStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEnableData([NativeTypeName("BYTE **")] byte** ppbData, [NativeTypeName("DWORD *")] uint* pcbData)
        {
            return ((delegate* stdcall<IMFContentEnabler*, byte**, uint*, int>)(lpVtbl[5]))((IMFContentEnabler*)Unsafe.AsPointer(ref this), ppbData, pcbData);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsAutomaticSupported([NativeTypeName("BOOL *")] int* pfAutomatic)
        {
            return ((delegate* stdcall<IMFContentEnabler*, int*, int>)(lpVtbl[6]))((IMFContentEnabler*)Unsafe.AsPointer(ref this), pfAutomatic);
        }

        [return: NativeTypeName("HRESULT")]
        public int AutomaticEnable()
        {
            return ((delegate* stdcall<IMFContentEnabler*, int>)(lpVtbl[7]))((IMFContentEnabler*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int MonitorEnable()
        {
            return ((delegate* stdcall<IMFContentEnabler*, int>)(lpVtbl[8]))((IMFContentEnabler*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Cancel()
        {
            return ((delegate* stdcall<IMFContentEnabler*, int>)(lpVtbl[9]))((IMFContentEnabler*)Unsafe.AsPointer(ref this));
        }
    }
}
