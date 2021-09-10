// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("6D67E846-5B9C-4DB8-9CBC-DDE12F4254F1")]
    [NativeTypeName("struct ITrayDeskBand : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITrayDeskBand
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITrayDeskBand*, Guid*, void**, int>)(lpVtbl[0]))((ITrayDeskBand*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITrayDeskBand*, uint>)(lpVtbl[1]))((ITrayDeskBand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITrayDeskBand*, uint>)(lpVtbl[2]))((ITrayDeskBand*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int ShowDeskBand([NativeTypeName("const IID &")] Guid* clsid)
        {
            return ((delegate* unmanaged<ITrayDeskBand*, Guid*, int>)(lpVtbl[3]))((ITrayDeskBand*)Unsafe.AsPointer(ref this), clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int HideDeskBand([NativeTypeName("const IID &")] Guid* clsid)
        {
            return ((delegate* unmanaged<ITrayDeskBand*, Guid*, int>)(lpVtbl[4]))((ITrayDeskBand*)Unsafe.AsPointer(ref this), clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int IsDeskBandShown([NativeTypeName("const IID &")] Guid* clsid)
        {
            return ((delegate* unmanaged<ITrayDeskBand*, Guid*, int>)(lpVtbl[5]))((ITrayDeskBand*)Unsafe.AsPointer(ref this), clsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int DeskBandRegistrationChanged()
        {
            return ((delegate* unmanaged<ITrayDeskBand*, int>)(lpVtbl[6]))((ITrayDeskBand*)Unsafe.AsPointer(ref this));
        }
    }
}
