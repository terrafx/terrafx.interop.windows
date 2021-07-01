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
    public unsafe partial struct IMFCollection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFCollection*, Guid*, void**, int>)(lpVtbl[0]))((IMFCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFCollection*, uint>)(lpVtbl[1]))((IMFCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFCollection*, uint>)(lpVtbl[2]))((IMFCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetElementCount([NativeTypeName("DWORD *")] uint* pcElements)
        {
            return ((delegate* unmanaged<IMFCollection*, uint*, int>)(lpVtbl[3]))((IMFCollection*)Unsafe.AsPointer(ref this), pcElements);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetElement([NativeTypeName("DWORD")] uint dwElementIndex, IUnknown** ppUnkElement)
        {
            return ((delegate* unmanaged<IMFCollection*, uint, IUnknown**, int>)(lpVtbl[4]))((IMFCollection*)Unsafe.AsPointer(ref this), dwElementIndex, ppUnkElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddElement(IUnknown* pUnkElement)
        {
            return ((delegate* unmanaged<IMFCollection*, IUnknown*, int>)(lpVtbl[5]))((IMFCollection*)Unsafe.AsPointer(ref this), pUnkElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveElement([NativeTypeName("DWORD")] uint dwElementIndex, IUnknown** ppUnkElement)
        {
            return ((delegate* unmanaged<IMFCollection*, uint, IUnknown**, int>)(lpVtbl[6]))((IMFCollection*)Unsafe.AsPointer(ref this), dwElementIndex, ppUnkElement);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InsertElementAt([NativeTypeName("DWORD")] uint dwIndex, IUnknown* pUnknown)
        {
            return ((delegate* unmanaged<IMFCollection*, uint, IUnknown*, int>)(lpVtbl[7]))((IMFCollection*)Unsafe.AsPointer(ref this), dwIndex, pUnknown);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveAllElements()
        {
            return ((delegate* unmanaged<IMFCollection*, int>)(lpVtbl[8]))((IMFCollection*)Unsafe.AsPointer(ref this));
        }
    }
}
