// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/ivectorchangedeventargs.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("575933DF-34FE-4480-AF15-07691F3D5D9B")]
    [NativeTypeName("struct IVectorChangedEventArgs : IInspectable")]
    [NativeInheritance("IInspectable")]
    public unsafe partial struct IVectorChangedEventArgs
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IVectorChangedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IVectorChangedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVectorChangedEventArgs*, uint>)(lpVtbl[1]))((IVectorChangedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVectorChangedEventArgs*, uint>)(lpVtbl[2]))((IVectorChangedEventArgs*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IVectorChangedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((IVectorChangedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IVectorChangedEventArgs*, IntPtr*, int>)(lpVtbl[4]))((IVectorChangedEventArgs*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetTrustLevel(TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IVectorChangedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((IVectorChangedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT get_CollectionChange([NativeTypeName("ABI::Windows::Foundation::Collections::CollectionChange *")] CollectionChange* value)
        {
            return ((delegate* unmanaged<IVectorChangedEventArgs*, CollectionChange*, int>)(lpVtbl[6]))((IVectorChangedEventArgs*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT get_Index([NativeTypeName("unsigned int *")] uint* value)
        {
            return ((delegate* unmanaged<IVectorChangedEventArgs*, uint*, int>)(lpVtbl[7]))((IVectorChangedEventArgs*)Unsafe.AsPointer(ref this), value);
        }
    }
}
