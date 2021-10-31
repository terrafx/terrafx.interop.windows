// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B5E26FF5-D7AD-4304-913F-21A2ED95A1B0")]
    [NativeTypeName("struct ITfFnConfigureRegisterEudc : ITfFunction")]
    [NativeInheritance("ITfFunction")]
    public unsafe partial struct ITfFnConfigureRegisterEudc
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfFnConfigureRegisterEudc*, Guid*, void**, int>)(lpVtbl[0]))((ITfFnConfigureRegisterEudc*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfFnConfigureRegisterEudc*, uint>)(lpVtbl[1]))((ITfFnConfigureRegisterEudc*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfFnConfigureRegisterEudc*, uint>)(lpVtbl[2]))((ITfFnConfigureRegisterEudc*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<ITfFnConfigureRegisterEudc*, ushort**, int>)(lpVtbl[3]))((ITfFnConfigureRegisterEudc*)Unsafe.AsPointer(ref this), pbstrName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Show(HWND hwndParent, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* rguidProfile, [NativeTypeName("BSTR")] ushort* bstrRegistered)
        {
            return ((delegate* unmanaged<ITfFnConfigureRegisterEudc*, HWND, ushort, Guid*, ushort*, int>)(lpVtbl[4]))((ITfFnConfigureRegisterEudc*)Unsafe.AsPointer(ref this), hwndParent, langid, rguidProfile, bstrRegistered);
        }
    }
}
