// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.graphics.imaging.interop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("94BC8415-04EA-4B2E-AF13-4DE95AA898EB")]
    [NativeTypeName("struct ISoftwareBitmapNative : IInspectable")]
    [NativeInheritance("IInspectable")]
    public unsafe partial struct ISoftwareBitmapNative
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISoftwareBitmapNative*, Guid*, void**, int>)(lpVtbl[0]))((ISoftwareBitmapNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISoftwareBitmapNative*, uint>)(lpVtbl[1]))((ISoftwareBitmapNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISoftwareBitmapNative*, uint>)(lpVtbl[2]))((ISoftwareBitmapNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<ISoftwareBitmapNative*, uint*, Guid**, int>)(lpVtbl[3]))((ISoftwareBitmapNative*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetRuntimeClassName(HSTRING* className)
        {
            return ((delegate* unmanaged<ISoftwareBitmapNative*, HSTRING*, int>)(lpVtbl[4]))((ISoftwareBitmapNative*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetTrustLevel(TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<ISoftwareBitmapNative*, TrustLevel*, int>)(lpVtbl[5]))((ISoftwareBitmapNative*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetData([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
        {
            return ((delegate* unmanaged<ISoftwareBitmapNative*, Guid*, void**, int>)(lpVtbl[6]))((ISoftwareBitmapNative*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISoftwareBitmapNative*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISoftwareBitmapNative*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISoftwareBitmapNative*, uint> Release;

            [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISoftwareBitmapNative*, uint*, Guid**, int> GetIids;

            [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISoftwareBitmapNative*, HSTRING*, int> GetRuntimeClassName;

            [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISoftwareBitmapNative*, TrustLevel*, int> GetTrustLevel;

            [NativeTypeName("HRESULT (const IID &, LPVOID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISoftwareBitmapNative*, Guid*, void**, int> GetData;
        }
    }
}
