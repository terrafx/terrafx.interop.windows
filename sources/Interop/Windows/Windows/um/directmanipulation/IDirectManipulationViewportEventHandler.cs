// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows8.0")]
    [Guid("952121DA-D69F-45F9-B0F9-F23944321A6D")]
    [NativeTypeName("struct IDirectManipulationViewportEventHandler : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDirectManipulationViewportEventHandler : IDirectManipulationViewportEventHandler.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDirectManipulationViewportEventHandler*, Guid*, void**, int>)(lpVtbl[0]))((IDirectManipulationViewportEventHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirectManipulationViewportEventHandler*, uint>)(lpVtbl[1]))((IDirectManipulationViewportEventHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirectManipulationViewportEventHandler*, uint>)(lpVtbl[2]))((IDirectManipulationViewportEventHandler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT OnViewportStatusChanged(IDirectManipulationViewport* viewport, DIRECTMANIPULATION_STATUS current, DIRECTMANIPULATION_STATUS previous)
        {
            return ((delegate* unmanaged<IDirectManipulationViewportEventHandler*, IDirectManipulationViewport*, DIRECTMANIPULATION_STATUS, DIRECTMANIPULATION_STATUS, int>)(lpVtbl[3]))((IDirectManipulationViewportEventHandler*)Unsafe.AsPointer(ref this), viewport, current, previous);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnViewportUpdated(IDirectManipulationViewport* viewport)
        {
            return ((delegate* unmanaged<IDirectManipulationViewportEventHandler*, IDirectManipulationViewport*, int>)(lpVtbl[4]))((IDirectManipulationViewportEventHandler*)Unsafe.AsPointer(ref this), viewport);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT OnContentUpdated(IDirectManipulationViewport* viewport, IDirectManipulationContent* content)
        {
            return ((delegate* unmanaged<IDirectManipulationViewportEventHandler*, IDirectManipulationViewport*, IDirectManipulationContent*, int>)(lpVtbl[5]))((IDirectManipulationViewportEventHandler*)Unsafe.AsPointer(ref this), viewport, content);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT OnViewportStatusChanged(IDirectManipulationViewport* viewport, DIRECTMANIPULATION_STATUS current, DIRECTMANIPULATION_STATUS previous);

            [VtblIndex(4)]
            HRESULT OnViewportUpdated(IDirectManipulationViewport* viewport);

            [VtblIndex(5)]
            HRESULT OnContentUpdated(IDirectManipulationViewport* viewport, IDirectManipulationContent* content);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDirectManipulationViewportEventHandler*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDirectManipulationViewportEventHandler*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDirectManipulationViewportEventHandler*, uint> Release;

            [NativeTypeName("HRESULT (IDirectManipulationViewport *, DIRECTMANIPULATION_STATUS, DIRECTMANIPULATION_STATUS) __attribute__((stdcall))")]
            public delegate* unmanaged<IDirectManipulationViewportEventHandler*, IDirectManipulationViewport*, DIRECTMANIPULATION_STATUS, DIRECTMANIPULATION_STATUS, int> OnViewportStatusChanged;

            [NativeTypeName("HRESULT (IDirectManipulationViewport *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDirectManipulationViewportEventHandler*, IDirectManipulationViewport*, int> OnViewportUpdated;

            [NativeTypeName("HRESULT (IDirectManipulationViewport *, IDirectManipulationContent *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDirectManipulationViewportEventHandler*, IDirectManipulationViewport*, IDirectManipulationContent*, int> OnContentUpdated;
        }
    }
}
