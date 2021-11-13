// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("A5CA5F7F-1847-4D87-9C5B-918509F7511D")]
    [NativeTypeName("struct IMonikerProp : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMonikerProp : IMonikerProp.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMonikerProp*, Guid*, void**, int>)(lpVtbl[0]))((IMonikerProp*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMonikerProp*, uint>)(lpVtbl[1]))((IMonikerProp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMonikerProp*, uint>)(lpVtbl[2]))((IMonikerProp*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT PutProperty(MONIKERPROPERTY mkp, [NativeTypeName("LPCWSTR")] ushort* val)
        {
            return ((delegate* unmanaged<IMonikerProp*, MONIKERPROPERTY, ushort*, int>)(lpVtbl[3]))((IMonikerProp*)Unsafe.AsPointer(ref this), mkp, val);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT PutProperty(MONIKERPROPERTY mkp, [NativeTypeName("LPCWSTR")] ushort* val);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMonikerProp*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMonikerProp*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMonikerProp*, uint> Release;

            [NativeTypeName("HRESULT (MONIKERPROPERTY, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IMonikerProp*, MONIKERPROPERTY, ushort*, int> PutProperty;
        }
    }
}
