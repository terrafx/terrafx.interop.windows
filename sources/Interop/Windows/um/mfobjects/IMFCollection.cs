// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5BC8A76B-869A-46A3-9B03-FA218A66AEBE")]
    [NativeTypeName("struct IMFCollection : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFCollection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFCollection*, Guid*, void**, int>)(lpVtbl[0]))((IMFCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFCollection*, uint>)(lpVtbl[1]))((IMFCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFCollection*, uint>)(lpVtbl[2]))((IMFCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetElementCount([NativeTypeName("DWORD *")] uint* pcElements)
        {
            return ((delegate* unmanaged<IMFCollection*, uint*, int>)(lpVtbl[3]))((IMFCollection*)Unsafe.AsPointer(ref this), pcElements);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetElement([NativeTypeName("DWORD")] uint dwElementIndex, IUnknown** ppUnkElement)
        {
            return ((delegate* unmanaged<IMFCollection*, uint, IUnknown**, int>)(lpVtbl[4]))((IMFCollection*)Unsafe.AsPointer(ref this), dwElementIndex, ppUnkElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT AddElement(IUnknown* pUnkElement)
        {
            return ((delegate* unmanaged<IMFCollection*, IUnknown*, int>)(lpVtbl[5]))((IMFCollection*)Unsafe.AsPointer(ref this), pUnkElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT RemoveElement([NativeTypeName("DWORD")] uint dwElementIndex, IUnknown** ppUnkElement)
        {
            return ((delegate* unmanaged<IMFCollection*, uint, IUnknown**, int>)(lpVtbl[6]))((IMFCollection*)Unsafe.AsPointer(ref this), dwElementIndex, ppUnkElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT InsertElementAt([NativeTypeName("DWORD")] uint dwIndex, IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IMFCollection*, uint, IUnknown*, int>)(lpVtbl[7]))((IMFCollection*)Unsafe.AsPointer(ref this), dwIndex, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT RemoveAllElements()
        {
            return ((delegate* unmanaged<IMFCollection*, int>)(lpVtbl[8]))((IMFCollection*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCollection*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCollection*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCollection*, uint> Release;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCollection*, uint*, int> GetElementCount;

            [NativeTypeName("HRESULT (DWORD, IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCollection*, uint, IUnknown**, int> GetElement;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCollection*, IUnknown*, int> AddElement;

            [NativeTypeName("HRESULT (DWORD, IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCollection*, uint, IUnknown**, int> RemoveElement;

            [NativeTypeName("HRESULT (DWORD, IUnknown *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCollection*, uint, IUnknown*, int> InsertElementAt;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFCollection*, int> RemoveAllElements;
        }
    }
}
