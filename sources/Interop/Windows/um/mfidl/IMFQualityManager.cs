// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8D009D86-5B9F-4115-B1FC-9F80D52AB8AB")]
    [NativeTypeName("struct IMFQualityManager : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFQualityManager : IMFQualityManager.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFQualityManager*, Guid*, void**, int>)(lpVtbl[0]))((IMFQualityManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFQualityManager*, uint>)(lpVtbl[1]))((IMFQualityManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFQualityManager*, uint>)(lpVtbl[2]))((IMFQualityManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT NotifyTopology(IMFTopology* pTopology)
        {
            return ((delegate* unmanaged<IMFQualityManager*, IMFTopology*, int>)(lpVtbl[3]))((IMFQualityManager*)Unsafe.AsPointer(ref this), pTopology);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT NotifyPresentationClock(IMFPresentationClock* pClock)
        {
            return ((delegate* unmanaged<IMFQualityManager*, IMFPresentationClock*, int>)(lpVtbl[4]))((IMFQualityManager*)Unsafe.AsPointer(ref this), pClock);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT NotifyProcessInput(IMFTopologyNode* pNode, [NativeTypeName("long")] int lInputIndex, IMFSample* pSample)
        {
            return ((delegate* unmanaged<IMFQualityManager*, IMFTopologyNode*, int, IMFSample*, int>)(lpVtbl[5]))((IMFQualityManager*)Unsafe.AsPointer(ref this), pNode, lInputIndex, pSample);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT NotifyProcessOutput(IMFTopologyNode* pNode, [NativeTypeName("long")] int lOutputIndex, IMFSample* pSample)
        {
            return ((delegate* unmanaged<IMFQualityManager*, IMFTopologyNode*, int, IMFSample*, int>)(lpVtbl[6]))((IMFQualityManager*)Unsafe.AsPointer(ref this), pNode, lOutputIndex, pSample);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT NotifyQualityEvent(IUnknown* pObject, IMFMediaEvent* pEvent)
        {
            return ((delegate* unmanaged<IMFQualityManager*, IUnknown*, IMFMediaEvent*, int>)(lpVtbl[7]))((IMFQualityManager*)Unsafe.AsPointer(ref this), pObject, pEvent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Shutdown()
        {
            return ((delegate* unmanaged<IMFQualityManager*, int>)(lpVtbl[8]))((IMFQualityManager*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT NotifyTopology(IMFTopology* pTopology);

            [VtblIndex(4)]
            HRESULT NotifyPresentationClock(IMFPresentationClock* pClock);

            [VtblIndex(5)]
            HRESULT NotifyProcessInput(IMFTopologyNode* pNode, [NativeTypeName("long")] int lInputIndex, IMFSample* pSample);

            [VtblIndex(6)]
            HRESULT NotifyProcessOutput(IMFTopologyNode* pNode, [NativeTypeName("long")] int lOutputIndex, IMFSample* pSample);

            [VtblIndex(7)]
            HRESULT NotifyQualityEvent(IUnknown* pObject, IMFMediaEvent* pEvent);

            [VtblIndex(8)]
            HRESULT Shutdown();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFQualityManager*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFQualityManager*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFQualityManager*, uint> Release;

            [NativeTypeName("HRESULT (IMFTopology *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFQualityManager*, IMFTopology*, int> NotifyTopology;

            [NativeTypeName("HRESULT (IMFPresentationClock *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFQualityManager*, IMFPresentationClock*, int> NotifyPresentationClock;

            [NativeTypeName("HRESULT (IMFTopologyNode *, long, IMFSample *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFQualityManager*, IMFTopologyNode*, int, IMFSample*, int> NotifyProcessInput;

            [NativeTypeName("HRESULT (IMFTopologyNode *, long, IMFSample *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFQualityManager*, IMFTopologyNode*, int, IMFSample*, int> NotifyProcessOutput;

            [NativeTypeName("HRESULT (IUnknown *, IMFMediaEvent *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFQualityManager*, IUnknown*, IMFMediaEvent*, int> NotifyQualityEvent;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFQualityManager*, int> Shutdown;
        }
    }
}
