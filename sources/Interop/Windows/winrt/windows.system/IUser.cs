// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DF9A26C6-E746-4BCD-B5D4-120103C4209B")]
    [NativeTypeName("struct IUser : IInspectable")]
    public unsafe partial struct IUser
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IUser*, Guid*, void**, int>)(lpVtbl[0]))((IUser*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUser*, uint>)(lpVtbl[1]))((IUser*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUser*, uint>)(lpVtbl[2]))((IUser*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IUser*, uint*, Guid**, int>)(lpVtbl[3]))((IUser*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IUser*, IntPtr*, int>)(lpVtbl[4]))((IUser*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IUser*, TrustLevel*, int>)(lpVtbl[5]))((IUser*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_NonRoamableId([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUser*, IntPtr*, int>)(lpVtbl[6]))((IUser*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AuthenticationStatus([NativeTypeName("ABI::Windows::System::UserAuthenticationStatus *")] UserAuthenticationStatus* value)
        {
            return ((delegate* unmanaged<IUser*, UserAuthenticationStatus*, int>)(lpVtbl[7]))((IUser*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Type([NativeTypeName("ABI::Windows::System::UserType *")] UserType* value)
        {
            return ((delegate* unmanaged<IUser*, UserType*, int>)(lpVtbl[8]))((IUser*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyAsync([NativeTypeName("HSTRING")] IntPtr value, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_IInspectable_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IUser*, IntPtr, IAsyncOperation<IntPtr>**, int>)(lpVtbl[9]))((IUser*)Unsafe.AsPointer(ref this), value, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertiesAsync([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_HSTRING_t *")] IVectorView<IntPtr>* values, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___F__CIPropertySet_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IUser*, IVectorView<IntPtr>*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[10]))((IUser*)Unsafe.AsPointer(ref this), values, operation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPictureAsync([NativeTypeName("ABI::Windows::System::UserPictureSize")] UserPictureSize desiredSize, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStreamReference_t **")] IAsyncOperation<IntPtr>** operation)
        {
            return ((delegate* unmanaged<IUser*, UserPictureSize, IAsyncOperation<IntPtr>**, int>)(lpVtbl[11]))((IUser*)Unsafe.AsPointer(ref this), desiredSize, operation);
        }
    }
}
