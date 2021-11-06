// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EA1EA137-19DF-11D7-A6D2-00065B84435C")]
    [NativeTypeName("struct ITfUIElement : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfUIElement : ITfUIElement.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfUIElement*, Guid*, void**, int>)(lpVtbl[0]))((ITfUIElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfUIElement*, uint>)(lpVtbl[1]))((ITfUIElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfUIElement*, uint>)(lpVtbl[2]))((ITfUIElement*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pbstrDescription)
        {
            return ((delegate* unmanaged<ITfUIElement*, ushort**, int>)(lpVtbl[3]))((ITfUIElement*)Unsafe.AsPointer(ref this), pbstrDescription);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetGUID(Guid* pguid)
        {
            return ((delegate* unmanaged<ITfUIElement*, Guid*, int>)(lpVtbl[4]))((ITfUIElement*)Unsafe.AsPointer(ref this), pguid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Show(BOOL bShow)
        {
            return ((delegate* unmanaged<ITfUIElement*, BOOL, int>)(lpVtbl[5]))((ITfUIElement*)Unsafe.AsPointer(ref this), bShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT IsShown(BOOL* pbShow)
        {
            return ((delegate* unmanaged<ITfUIElement*, BOOL*, int>)(lpVtbl[6]))((ITfUIElement*)Unsafe.AsPointer(ref this), pbShow);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pbstrDescription);

            [VtblIndex(4)]
            HRESULT GetGUID(Guid* pguid);

            [VtblIndex(5)]
            HRESULT Show(BOOL bShow);

            [VtblIndex(6)]
            HRESULT IsShown(BOOL* pbShow);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfUIElement*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfUIElement*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfUIElement*, uint> Release;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfUIElement*, ushort**, int> GetDescription;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfUIElement*, Guid*, int> GetGUID;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfUIElement*, BOOL, int> Show;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfUIElement*, BOOL*, int> IsShown;
        }
    }
}
