// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("28F54685-06FD-11D2-B27A-00A0C9223196")]
    [NativeTypeName("struct IKsControl : IUnknown")]
    public unsafe partial struct IKsControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IKsControl*, Guid*, void**, int>)(lpVtbl[0]))((IKsControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IKsControl*, uint>)(lpVtbl[1]))((IKsControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IKsControl*, uint>)(lpVtbl[2]))((IKsControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int KsProperty([NativeTypeName("PKSPROPERTY")] KSIDENTIFIER* Property, [NativeTypeName("ULONG")] uint PropertyLength, void* PropertyData, [NativeTypeName("ULONG")] uint DataLength, [NativeTypeName("ULONG *")] uint* BytesReturned)
        {
            return ((delegate* unmanaged<IKsControl*, KSIDENTIFIER*, uint, void*, uint, uint*, int>)(lpVtbl[3]))((IKsControl*)Unsafe.AsPointer(ref this), Property, PropertyLength, PropertyData, DataLength, BytesReturned);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int KsMethod([NativeTypeName("PKSMETHOD")] KSIDENTIFIER* Method, [NativeTypeName("ULONG")] uint MethodLength, void* MethodData, [NativeTypeName("ULONG")] uint DataLength, [NativeTypeName("ULONG *")] uint* BytesReturned)
        {
            return ((delegate* unmanaged<IKsControl*, KSIDENTIFIER*, uint, void*, uint, uint*, int>)(lpVtbl[4]))((IKsControl*)Unsafe.AsPointer(ref this), Method, MethodLength, MethodData, DataLength, BytesReturned);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int KsEvent([NativeTypeName("PKSEVENT")] KSIDENTIFIER* Event, [NativeTypeName("ULONG")] uint EventLength, void* EventData, [NativeTypeName("ULONG")] uint DataLength, [NativeTypeName("ULONG *")] uint* BytesReturned)
        {
            return ((delegate* unmanaged<IKsControl*, KSIDENTIFIER*, uint, void*, uint, uint*, int>)(lpVtbl[5]))((IKsControl*)Unsafe.AsPointer(ref this), Event, EventLength, EventData, DataLength, BytesReturned);
        }
    }
}
