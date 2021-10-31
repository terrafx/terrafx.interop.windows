// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("5B4FB971-B115-4DE1-AD97-E482E3BF6EE4")]
    [NativeTypeName("struct ISpProperties : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISpProperties
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpProperties*, Guid*, void**, int>)(lpVtbl[0]))((ISpProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpProperties*, uint>)(lpVtbl[1]))((ISpProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpProperties*, uint>)(lpVtbl[2]))((ISpProperties*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetPropertyNum([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("LONG")] int lValue)
        {
            return ((delegate* unmanaged<ISpProperties*, ushort*, int, int>)(lpVtbl[3]))((ISpProperties*)Unsafe.AsPointer(ref this), pName, lValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetPropertyNum([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("LONG *")] int* plValue)
        {
            return ((delegate* unmanaged<ISpProperties*, ushort*, int*, int>)(lpVtbl[4]))((ISpProperties*)Unsafe.AsPointer(ref this), pName, plValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetPropertyString([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("LPCWSTR")] ushort* pValue)
        {
            return ((delegate* unmanaged<ISpProperties*, ushort*, ushort*, int>)(lpVtbl[5]))((ISpProperties*)Unsafe.AsPointer(ref this), pName, pValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetPropertyString([NativeTypeName("LPCWSTR")] ushort* pName, [NativeTypeName("LPWSTR *")] ushort** ppCoMemValue)
        {
            return ((delegate* unmanaged<ISpProperties*, ushort*, ushort**, int>)(lpVtbl[6]))((ISpProperties*)Unsafe.AsPointer(ref this), pName, ppCoMemValue);
        }
    }
}
