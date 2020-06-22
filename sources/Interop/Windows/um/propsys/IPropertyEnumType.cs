// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("11E1FBF9-2D56-4A6B-8DB3-7CD193A471F2")]
    public unsafe partial struct IPropertyEnumType
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPropertyEnumType*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyEnumType*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPropertyEnumType*, uint>)(lpVtbl[1]))((IPropertyEnumType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPropertyEnumType*, uint>)(lpVtbl[2]))((IPropertyEnumType*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetEnumType([NativeTypeName("PROPENUMTYPE *")] PROPENUMTYPE* penumtype)
        {
            return ((delegate* stdcall<IPropertyEnumType*, PROPENUMTYPE*, int>)(lpVtbl[3]))((IPropertyEnumType*)Unsafe.AsPointer(ref this), penumtype);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppropvar)
        {
            return ((delegate* stdcall<IPropertyEnumType*, PROPVARIANT*, int>)(lpVtbl[4]))((IPropertyEnumType*)Unsafe.AsPointer(ref this), ppropvar);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRangeMinValue([NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppropvarMin)
        {
            return ((delegate* stdcall<IPropertyEnumType*, PROPVARIANT*, int>)(lpVtbl[5]))((IPropertyEnumType*)Unsafe.AsPointer(ref this), ppropvarMin);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetRangeSetValue([NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppropvarSet)
        {
            return ((delegate* stdcall<IPropertyEnumType*, PROPVARIANT*, int>)(lpVtbl[6]))((IPropertyEnumType*)Unsafe.AsPointer(ref this), ppropvarSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDisplayText([NativeTypeName("LPWSTR *")] ushort** ppszDisplay)
        {
            return ((delegate* stdcall<IPropertyEnumType*, ushort**, int>)(lpVtbl[7]))((IPropertyEnumType*)Unsafe.AsPointer(ref this), ppszDisplay);
        }
    }
}
