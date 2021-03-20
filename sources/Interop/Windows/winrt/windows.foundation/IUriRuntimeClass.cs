// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9E365E57-48B2-4160-956F-C7385120BBFC")]
    [NativeTypeName("struct IUriRuntimeClass : IInspectable")]
    public unsafe partial struct IUriRuntimeClass
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IUriRuntimeClass*, Guid*, void**, int>)(lpVtbl[0]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IUriRuntimeClass*, uint>)(lpVtbl[1]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IUriRuntimeClass*, uint>)(lpVtbl[2]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
        {
            return ((delegate* unmanaged<IUriRuntimeClass*, uint*, Guid**, int>)(lpVtbl[3]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), iidCount, iids);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRuntimeClassName([NativeTypeName("HSTRING *")] IntPtr* className)
        {
            return ((delegate* unmanaged<IUriRuntimeClass*, IntPtr*, int>)(lpVtbl[4]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), className);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTrustLevel([NativeTypeName("TrustLevel *")] TrustLevel* trustLevel)
        {
            return ((delegate* unmanaged<IUriRuntimeClass*, TrustLevel*, int>)(lpVtbl[5]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), trustLevel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_AbsoluteUri([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUriRuntimeClass*, IntPtr*, int>)(lpVtbl[6]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DisplayUri([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUriRuntimeClass*, IntPtr*, int>)(lpVtbl[7]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Domain([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUriRuntimeClass*, IntPtr*, int>)(lpVtbl[8]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Extension([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUriRuntimeClass*, IntPtr*, int>)(lpVtbl[9]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Fragment([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUriRuntimeClass*, IntPtr*, int>)(lpVtbl[10]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Host([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUriRuntimeClass*, IntPtr*, int>)(lpVtbl[11]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Password([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUriRuntimeClass*, IntPtr*, int>)(lpVtbl[12]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Path([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUriRuntimeClass*, IntPtr*, int>)(lpVtbl[13]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Query([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUriRuntimeClass*, IntPtr*, int>)(lpVtbl[14]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_QueryParsed([NativeTypeName("ABI::Windows::Foundation::IWwwFormUrlDecoderRuntimeClass **")] IWwwFormUrlDecoderRuntimeClass** ppWwwFormUrlDecoder)
        {
            return ((delegate* unmanaged<IUriRuntimeClass*, IWwwFormUrlDecoderRuntimeClass**, int>)(lpVtbl[15]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), ppWwwFormUrlDecoder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_RawUri([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUriRuntimeClass*, IntPtr*, int>)(lpVtbl[16]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SchemeName([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUriRuntimeClass*, IntPtr*, int>)(lpVtbl[17]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_UserName([NativeTypeName("HSTRING *")] IntPtr* value)
        {
            return ((delegate* unmanaged<IUriRuntimeClass*, IntPtr*, int>)(lpVtbl[18]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Port([NativeTypeName("INT32 *")] int* value)
        {
            return ((delegate* unmanaged<IUriRuntimeClass*, int*, int>)(lpVtbl[19]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Suspicious([NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IUriRuntimeClass*, byte*, int>)(lpVtbl[20]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Equals([NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass* pUri, [NativeTypeName("boolean *")] byte* value)
        {
            return ((delegate* unmanaged<IUriRuntimeClass*, IUriRuntimeClass*, byte*, int>)(lpVtbl[21]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), pUri, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CombineUri([NativeTypeName("HSTRING")] IntPtr relativeUri, [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass **")] IUriRuntimeClass** instance)
        {
            return ((delegate* unmanaged<IUriRuntimeClass*, IntPtr, IUriRuntimeClass**, int>)(lpVtbl[22]))((IUriRuntimeClass*)Unsafe.AsPointer(ref this), relativeUri, instance);
        }
    }
}
