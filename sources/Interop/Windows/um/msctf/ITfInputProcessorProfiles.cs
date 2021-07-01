// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1F02B6C5-7842-4EE6-8A0B-9A24183A95CA")]
    [NativeTypeName("struct ITfInputProcessorProfiles : IUnknown")]
    public unsafe partial struct ITfInputProcessorProfiles
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfiles*, Guid*, void**, int>)(lpVtbl[0]))((ITfInputProcessorProfiles*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfInputProcessorProfiles*, uint>)(lpVtbl[1]))((ITfInputProcessorProfiles*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfInputProcessorProfiles*, uint>)(lpVtbl[2]))((ITfInputProcessorProfiles*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Register([NativeTypeName("const IID &")] Guid* rclsid)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfiles*, Guid*, int>)(lpVtbl[3]))((ITfInputProcessorProfiles*)Unsafe.AsPointer(ref this), rclsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Unregister([NativeTypeName("const IID &")] Guid* rclsid)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfiles*, Guid*, int>)(lpVtbl[4]))((ITfInputProcessorProfiles*)Unsafe.AsPointer(ref this), rclsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddLanguageProfile([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, [NativeTypeName("const WCHAR *")] ushort* pchDesc, [NativeTypeName("ULONG")] uint cchDesc, [NativeTypeName("const WCHAR *")] ushort* pchIconFile, [NativeTypeName("ULONG")] uint cchFile, [NativeTypeName("ULONG")] uint uIconIndex)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfiles*, Guid*, ushort, Guid*, ushort*, uint, ushort*, uint, uint, int>)(lpVtbl[5]))((ITfInputProcessorProfiles*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile, pchDesc, cchDesc, pchIconFile, cchFile, uIconIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveLanguageProfile([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfiles*, Guid*, ushort, Guid*, int>)(lpVtbl[6]))((ITfInputProcessorProfiles*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumInputProcessorInfo(IEnumGUID** ppEnum)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfiles*, IEnumGUID**, int>)(lpVtbl[7]))((ITfInputProcessorProfiles*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefaultLanguageProfile([NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* catid, [NativeTypeName("CLSID *")] Guid* pclsid, [NativeTypeName("GUID *")] Guid* pguidProfile)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfiles*, ushort, Guid*, Guid*, Guid*, int>)(lpVtbl[8]))((ITfInputProcessorProfiles*)Unsafe.AsPointer(ref this), langid, catid, pclsid, pguidProfile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetDefaultLanguageProfile([NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const GUID &")] Guid* guidProfiles)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfiles*, ushort, Guid*, Guid*, int>)(lpVtbl[9]))((ITfInputProcessorProfiles*)Unsafe.AsPointer(ref this), langid, rclsid, guidProfiles);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ActivateLanguageProfile([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfiles)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfiles*, Guid*, ushort, Guid*, int>)(lpVtbl[10]))((ITfInputProcessorProfiles*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfiles);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetActiveLanguageProfile([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID *")] ushort* plangid, [NativeTypeName("GUID *")] Guid* pguidProfile)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfiles*, Guid*, ushort*, Guid*, int>)(lpVtbl[11]))((ITfInputProcessorProfiles*)Unsafe.AsPointer(ref this), rclsid, plangid, pguidProfile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLanguageProfileDescription([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, [NativeTypeName("BSTR *")] ushort** pbstrProfile)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfiles*, Guid*, ushort, Guid*, ushort**, int>)(lpVtbl[12]))((ITfInputProcessorProfiles*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile, pbstrProfile);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurrentLanguage([NativeTypeName("LANGID *")] ushort* plangid)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfiles*, ushort*, int>)(lpVtbl[13]))((ITfInputProcessorProfiles*)Unsafe.AsPointer(ref this), plangid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ChangeCurrentLanguage([NativeTypeName("LANGID")] ushort langid)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfiles*, ushort, int>)(lpVtbl[14]))((ITfInputProcessorProfiles*)Unsafe.AsPointer(ref this), langid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLanguageList([NativeTypeName("LANGID **")] ushort** ppLangId, [NativeTypeName("ULONG *")] uint* pulCount)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfiles*, ushort**, uint*, int>)(lpVtbl[15]))((ITfInputProcessorProfiles*)Unsafe.AsPointer(ref this), ppLangId, pulCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumLanguageProfiles([NativeTypeName("LANGID")] ushort langid, IEnumTfLanguageProfiles** ppEnum)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfiles*, ushort, IEnumTfLanguageProfiles**, int>)(lpVtbl[16]))((ITfInputProcessorProfiles*)Unsafe.AsPointer(ref this), langid, ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnableLanguageProfile([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, [NativeTypeName("BOOL")] int fEnable)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfiles*, Guid*, ushort, Guid*, int, int>)(lpVtbl[17]))((ITfInputProcessorProfiles*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile, fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsEnabledLanguageProfile([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, [NativeTypeName("BOOL *")] int* pfEnable)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfiles*, Guid*, ushort, Guid*, int*, int>)(lpVtbl[18]))((ITfInputProcessorProfiles*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile, pfEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnableLanguageProfileByDefault([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, [NativeTypeName("BOOL")] int fEnable)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfiles*, Guid*, ushort, Guid*, int, int>)(lpVtbl[19]))((ITfInputProcessorProfiles*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile, fEnable);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SubstituteKeyboardLayout([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, [NativeTypeName("HKL")] IntPtr hKL)
        {
            return ((delegate* unmanaged<ITfInputProcessorProfiles*, Guid*, ushort, Guid*, IntPtr, int>)(lpVtbl[20]))((ITfInputProcessorProfiles*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile, hKL);
        }
    }
}
