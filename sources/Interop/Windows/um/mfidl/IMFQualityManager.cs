// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8D009D86-5B9F-4115-B1FC-9F80D52AB8AB")]
    public unsafe partial struct IMFQualityManager
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IMFQualityManager*, Guid*, void**, int>)(lpVtbl[0]))((IMFQualityManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IMFQualityManager*, uint>)(lpVtbl[1]))((IMFQualityManager*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IMFQualityManager*, uint>)(lpVtbl[2]))((IMFQualityManager*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int NotifyTopology([NativeTypeName("IMFTopology *")] IMFTopology* pTopology)
        {
            return ((delegate* stdcall<IMFQualityManager*, IMFTopology*, int>)(lpVtbl[3]))((IMFQualityManager*)Unsafe.AsPointer(ref this), pTopology);
        }

        [return: NativeTypeName("HRESULT")]
        public int NotifyPresentationClock([NativeTypeName("IMFPresentationClock *")] IMFPresentationClock* pClock)
        {
            return ((delegate* stdcall<IMFQualityManager*, IMFPresentationClock*, int>)(lpVtbl[4]))((IMFQualityManager*)Unsafe.AsPointer(ref this), pClock);
        }

        [return: NativeTypeName("HRESULT")]
        public int NotifyProcessInput([NativeTypeName("IMFTopologyNode *")] IMFTopologyNode* pNode, [NativeTypeName("long")] int lInputIndex, [NativeTypeName("IMFSample *")] IMFSample* pSample)
        {
            return ((delegate* stdcall<IMFQualityManager*, IMFTopologyNode*, int, IMFSample*, int>)(lpVtbl[5]))((IMFQualityManager*)Unsafe.AsPointer(ref this), pNode, lInputIndex, pSample);
        }

        [return: NativeTypeName("HRESULT")]
        public int NotifyProcessOutput([NativeTypeName("IMFTopologyNode *")] IMFTopologyNode* pNode, [NativeTypeName("long")] int lOutputIndex, [NativeTypeName("IMFSample *")] IMFSample* pSample)
        {
            return ((delegate* stdcall<IMFQualityManager*, IMFTopologyNode*, int, IMFSample*, int>)(lpVtbl[6]))((IMFQualityManager*)Unsafe.AsPointer(ref this), pNode, lOutputIndex, pSample);
        }

        [return: NativeTypeName("HRESULT")]
        public int NotifyQualityEvent([NativeTypeName("IUnknown *")] IUnknown* pObject, [NativeTypeName("IMFMediaEvent *")] IMFMediaEvent* pEvent)
        {
            return ((delegate* stdcall<IMFQualityManager*, IUnknown*, IMFMediaEvent*, int>)(lpVtbl[7]))((IMFQualityManager*)Unsafe.AsPointer(ref this), pObject, pEvent);
        }

        [return: NativeTypeName("HRESULT")]
        public int Shutdown()
        {
            return ((delegate* stdcall<IMFQualityManager*, int>)(lpVtbl[8]))((IMFQualityManager*)Unsafe.AsPointer(ref this));
        }
    }
}
