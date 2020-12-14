// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1F9FC1D0-C39B-4B26-817F-011967D3440E")]
    [NativeTypeName("struct IPropertyDescriptionList : IUnknown")]
    public unsafe partial struct IPropertyDescriptionList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IPropertyDescriptionList*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyDescriptionList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPropertyDescriptionList*, uint>)(lpVtbl[1]))((IPropertyDescriptionList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPropertyDescriptionList*, uint>)(lpVtbl[2]))((IPropertyDescriptionList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCount([NativeTypeName("UINT *")] uint* pcElem)
        {
            return ((delegate* unmanaged<IPropertyDescriptionList*, uint*, int>)(lpVtbl[3]))((IPropertyDescriptionList*)Unsafe.AsPointer(ref this), pcElem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetAt([NativeTypeName("UINT")] uint iElem, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* unmanaged<IPropertyDescriptionList*, uint, Guid*, void**, int>)(lpVtbl[4]))((IPropertyDescriptionList*)Unsafe.AsPointer(ref this), iElem, riid, ppv);
        }
    }
}
