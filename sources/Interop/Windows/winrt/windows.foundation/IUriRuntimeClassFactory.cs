// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("44A9796F-723E-4FDF-A218-033E75B0C084")]
    [NativeTypeName("struct IUriRuntimeClassFactory : IInspectable")]
    public unsafe partial struct IUriRuntimeClassFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IUriRuntimeClassFactory*, Guid*, void**, int>)(lpVtbl[0]))((IUriRuntimeClassFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUriRuntimeClassFactory*, uint>)(lpVtbl[1]))((IUriRuntimeClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUriRuntimeClassFactory*, uint>)(lpVtbl[2]))((IUriRuntimeClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IUriRuntimeClassFactory*, uint*, Guid**, int>)(lpVtbl[3]))((IUriRuntimeClassFactory*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IUriRuntimeClassFactory*, IntPtr*, int>)(lpVtbl[4]))((IUriRuntimeClassFactory*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IUriRuntimeClassFactory*, TrustLevel*, int>)(lpVtbl[5]))((IUriRuntimeClassFactory*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateUri([NativeTypeName("HSTRING")] IntPtr uri, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** instance)
        {
            return ((delegate* unmanaged<IUriRuntimeClassFactory*, IntPtr, IUriRuntimeClass**, int>)(lpVtbl[6]))((IUriRuntimeClassFactory*)Unsafe.AsPointer(ref this), uri, instance);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateWithRelativeUri([NativeTypeName("HSTRING")] IntPtr baseUri, [NativeTypeName("HSTRING")] IntPtr relativeUri, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** instance)
        {
            return ((delegate* unmanaged<IUriRuntimeClassFactory*, IntPtr, IntPtr, IUriRuntimeClass**, int>)(lpVtbl[7]))((IUriRuntimeClassFactory*)Unsafe.AsPointer(ref this), baseUri, relativeUri, instance);
        }
    }
}
