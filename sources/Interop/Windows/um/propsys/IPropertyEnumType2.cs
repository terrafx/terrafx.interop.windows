// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B6E051C-5DDD-4321-9070-FE2ACB55E794")]
    [NativeTypeName("struct IPropertyEnumType2 : IPropertyEnumType")]
    public unsafe partial struct IPropertyEnumType2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPropertyEnumType2*, Guid*, void**, int>)(lpVtbl[0]))((IPropertyEnumType2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPropertyEnumType2*, uint>)(lpVtbl[1]))((IPropertyEnumType2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPropertyEnumType2*, uint>)(lpVtbl[2]))((IPropertyEnumType2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnumType([NativeTypeName("PROPENUMTYPE *")] PROPENUMTYPE* penumtype)
        {
            return ((delegate* stdcall<IPropertyEnumType2*, PROPENUMTYPE*, int>)(lpVtbl[3]))((IPropertyEnumType2*)Unsafe.AsPointer(ref this), penumtype);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetValue([NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppropvar)
        {
            return ((delegate* stdcall<IPropertyEnumType2*, PROPVARIANT*, int>)(lpVtbl[4]))((IPropertyEnumType2*)Unsafe.AsPointer(ref this), ppropvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRangeMinValue([NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppropvarMin)
        {
            return ((delegate* stdcall<IPropertyEnumType2*, PROPVARIANT*, int>)(lpVtbl[5]))((IPropertyEnumType2*)Unsafe.AsPointer(ref this), ppropvarMin);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRangeSetValue([NativeTypeName("PROPVARIANT *")] PROPVARIANT* ppropvarSet)
        {
            return ((delegate* stdcall<IPropertyEnumType2*, PROPVARIANT*, int>)(lpVtbl[6]))((IPropertyEnumType2*)Unsafe.AsPointer(ref this), ppropvarSet);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayText([NativeTypeName("LPWSTR *")] ushort** ppszDisplay)
        {
            return ((delegate* stdcall<IPropertyEnumType2*, ushort**, int>)(lpVtbl[7]))((IPropertyEnumType2*)Unsafe.AsPointer(ref this), ppszDisplay);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetImageReference([NativeTypeName("LPWSTR *")] ushort** ppszImageRes)
        {
            return ((delegate* stdcall<IPropertyEnumType2*, ushort**, int>)(lpVtbl[8]))((IPropertyEnumType2*)Unsafe.AsPointer(ref this), ppszImageRes);
        }
    }
}
