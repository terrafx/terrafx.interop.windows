// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("380F5CAD-1B5E-42F2-805D-637FD392D31E")]
    [NativeTypeName("struct IPropertyChangeArray : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPropertyChangeArray
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPropertyChangeArray*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyChangeArray*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPropertyChangeArray*, uint>)(lpVtbl[1]))((IPropertyChangeArray*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPropertyChangeArray*, uint>)(lpVtbl[2]))((IPropertyChangeArray*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetCount(uint* pcOperations)
        {
            return ((delegate* unmanaged<IPropertyChangeArray*, uint*, int>)(lpVtbl[3]))((IPropertyChangeArray*)Unsafe.AsPointer(ref this), pcOperations);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetAt(uint iIndex, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IPropertyChangeArray*, uint, Guid*, void**, int>)(lpVtbl[4]))((IPropertyChangeArray*)Unsafe.AsPointer(ref this), iIndex, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT InsertAt(uint iIndex, IPropertyChange* ppropChange)
        {
            return ((delegate* unmanaged<IPropertyChangeArray*, uint, IPropertyChange*, int>)(lpVtbl[5]))((IPropertyChangeArray*)Unsafe.AsPointer(ref this), iIndex, ppropChange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Append(IPropertyChange* ppropChange)
        {
            return ((delegate* unmanaged<IPropertyChangeArray*, IPropertyChange*, int>)(lpVtbl[6]))((IPropertyChangeArray*)Unsafe.AsPointer(ref this), ppropChange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT AppendOrReplace(IPropertyChange* ppropChange)
        {
            return ((delegate* unmanaged<IPropertyChangeArray*, IPropertyChange*, int>)(lpVtbl[7]))((IPropertyChangeArray*)Unsafe.AsPointer(ref this), ppropChange);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT RemoveAt(uint iIndex)
        {
            return ((delegate* unmanaged<IPropertyChangeArray*, uint, int>)(lpVtbl[8]))((IPropertyChangeArray*)Unsafe.AsPointer(ref this), iIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT IsKeyInArray([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key)
        {
            return ((delegate* unmanaged<IPropertyChangeArray*, PROPERTYKEY*, int>)(lpVtbl[9]))((IPropertyChangeArray*)Unsafe.AsPointer(ref this), key);
        }
    }
}
