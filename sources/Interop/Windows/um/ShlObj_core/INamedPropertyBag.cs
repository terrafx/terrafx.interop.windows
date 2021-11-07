// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FB700430-952C-11D1-946F-000000000000")]
    [NativeTypeName("struct INamedPropertyBag : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct INamedPropertyBag : INamedPropertyBag.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<INamedPropertyBag*, Guid*, void**, int>)(lpVtbl[0]))((INamedPropertyBag*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<INamedPropertyBag*, uint>)(lpVtbl[1]))((INamedPropertyBag*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<INamedPropertyBag*, uint>)(lpVtbl[2]))((INamedPropertyBag*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT ReadPropertyNPB([NativeTypeName("PCWSTR")] ushort* pszBagname, [NativeTypeName("PCWSTR")] ushort* pszPropName, PROPVARIANT* pVar)
        {
            return ((delegate* unmanaged<INamedPropertyBag*, ushort*, ushort*, PROPVARIANT*, int>)(lpVtbl[3]))((INamedPropertyBag*)Unsafe.AsPointer(ref this), pszBagname, pszPropName, pVar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT WritePropertyNPB([NativeTypeName("PCWSTR")] ushort* pszBagname, [NativeTypeName("PCWSTR")] ushort* pszPropName, PROPVARIANT* pVar)
        {
            return ((delegate* unmanaged<INamedPropertyBag*, ushort*, ushort*, PROPVARIANT*, int>)(lpVtbl[4]))((INamedPropertyBag*)Unsafe.AsPointer(ref this), pszBagname, pszPropName, pVar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT RemovePropertyNPB([NativeTypeName("PCWSTR")] ushort* pszBagname, [NativeTypeName("PCWSTR")] ushort* pszPropName)
        {
            return ((delegate* unmanaged<INamedPropertyBag*, ushort*, ushort*, int>)(lpVtbl[5]))((INamedPropertyBag*)Unsafe.AsPointer(ref this), pszBagname, pszPropName);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT ReadPropertyNPB([NativeTypeName("PCWSTR")] ushort* pszBagname, [NativeTypeName("PCWSTR")] ushort* pszPropName, PROPVARIANT* pVar);

            [VtblIndex(4)]
            HRESULT WritePropertyNPB([NativeTypeName("PCWSTR")] ushort* pszBagname, [NativeTypeName("PCWSTR")] ushort* pszPropName, PROPVARIANT* pVar);

            [VtblIndex(5)]
            HRESULT RemovePropertyNPB([NativeTypeName("PCWSTR")] ushort* pszBagname, [NativeTypeName("PCWSTR")] ushort* pszPropName);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<INamedPropertyBag*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<INamedPropertyBag*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<INamedPropertyBag*, uint> Release;

            [NativeTypeName("HRESULT (PCWSTR, PCWSTR, PROPVARIANT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<INamedPropertyBag*, ushort*, ushort*, PROPVARIANT*, int> ReadPropertyNPB;

            [NativeTypeName("HRESULT (PCWSTR, PCWSTR, PROPVARIANT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<INamedPropertyBag*, ushort*, ushort*, PROPVARIANT*, int> WritePropertyNPB;

            [NativeTypeName("HRESULT (PCWSTR, PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<INamedPropertyBag*, ushort*, ushort*, int> RemovePropertyNPB;
        }
    }
}
