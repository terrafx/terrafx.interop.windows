// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWICBitmapDecoderInfo.xml' path='doc/member[@name="IWICBitmapDecoderInfo"]/*' />
[Guid("D8CD007F-D08F-4191-9BFC-236EA7F0E4B5")]
[NativeTypeName("struct IWICBitmapDecoderInfo : IWICBitmapCodecInfo")]
[NativeInheritance("IWICBitmapCodecInfo")]
public unsafe partial struct IWICBitmapDecoderInfo : IWICBitmapDecoderInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IWICBitmapDecoderInfo);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, Guid*, void**, int>)(lpVtbl[0]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint>)(lpVtbl[1]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint>)(lpVtbl[2]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IWICComponentInfo.GetComponentType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetComponentType(WICComponentType* pType)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, WICComponentType*, int>)(lpVtbl[3]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pType);
    }

    /// <inheritdoc cref="IWICComponentInfo.GetCLSID" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, Guid*, int>)(lpVtbl[4]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pclsid);
    }

    /// <inheritdoc cref="IWICComponentInfo.GetSigningStatus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetSigningStatus([NativeTypeName("DWORD *")] uint* pStatus)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint*, int>)(lpVtbl[5]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pStatus);
    }

    /// <inheritdoc cref="IWICComponentInfo.GetAuthor" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAuthor(uint cchAuthor, [NativeTypeName("WCHAR *")] char* wzAuthor, uint* pcchActual)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)(lpVtbl[6]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchAuthor, wzAuthor, pcchActual);
    }

    /// <inheritdoc cref="IWICComponentInfo.GetVendorGUID" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetVendorGUID(Guid* pguidVendor)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, Guid*, int>)(lpVtbl[7]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pguidVendor);
    }

    /// <inheritdoc cref="IWICComponentInfo.GetVersion" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetVersion(uint cchVersion, [NativeTypeName("WCHAR *")] char* wzVersion, uint* pcchActual)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)(lpVtbl[8]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchVersion, wzVersion, pcchActual);
    }

    /// <inheritdoc cref="IWICComponentInfo.GetSpecVersion" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSpecVersion(uint cchSpecVersion, [NativeTypeName("WCHAR *")] char* wzSpecVersion, uint* pcchActual)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)(lpVtbl[9]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchSpecVersion, wzSpecVersion, pcchActual);
    }

    /// <inheritdoc cref="IWICComponentInfo.GetFriendlyName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetFriendlyName(uint cchFriendlyName, [NativeTypeName("WCHAR *")] char* wzFriendlyName, uint* pcchActual)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)(lpVtbl[10]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchFriendlyName, wzFriendlyName, pcchActual);
    }

    /// <inheritdoc cref="IWICBitmapCodecInfo.GetContainerFormat" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetContainerFormat(Guid* pguidContainerFormat)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, Guid*, int>)(lpVtbl[11]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pguidContainerFormat);
    }

    /// <inheritdoc cref="IWICBitmapCodecInfo.GetPixelFormats" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetPixelFormats(uint cFormats, Guid* pguidPixelFormats, uint* pcActual)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint, Guid*, uint*, int>)(lpVtbl[12]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cFormats, pguidPixelFormats, pcActual);
    }

    /// <inheritdoc cref="IWICBitmapCodecInfo.GetColorManagementVersion" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetColorManagementVersion(uint cchColorManagementVersion, [NativeTypeName("WCHAR *")] char* wzColorManagementVersion, uint* pcchActual)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)(lpVtbl[13]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchColorManagementVersion, wzColorManagementVersion, pcchActual);
    }

    /// <inheritdoc cref="IWICBitmapCodecInfo.GetDeviceManufacturer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetDeviceManufacturer(uint cchDeviceManufacturer, [NativeTypeName("WCHAR *")] char* wzDeviceManufacturer, uint* pcchActual)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)(lpVtbl[14]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchDeviceManufacturer, wzDeviceManufacturer, pcchActual);
    }

    /// <inheritdoc cref="IWICBitmapCodecInfo.GetDeviceModels" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetDeviceModels(uint cchDeviceModels, [NativeTypeName("WCHAR *")] char* wzDeviceModels, uint* pcchActual)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)(lpVtbl[15]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchDeviceModels, wzDeviceModels, pcchActual);
    }

    /// <inheritdoc cref="IWICBitmapCodecInfo.GetMimeTypes" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetMimeTypes(uint cchMimeTypes, [NativeTypeName("WCHAR *")] char* wzMimeTypes, uint* pcchActual)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)(lpVtbl[16]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchMimeTypes, wzMimeTypes, pcchActual);
    }

    /// <inheritdoc cref="IWICBitmapCodecInfo.GetFileExtensions" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetFileExtensions(uint cchFileExtensions, [NativeTypeName("WCHAR *")] char* wzFileExtensions, uint* pcchActual)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint, char*, uint*, int>)(lpVtbl[17]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cchFileExtensions, wzFileExtensions, pcchActual);
    }

    /// <inheritdoc cref="IWICBitmapCodecInfo.DoesSupportAnimation" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT DoesSupportAnimation(BOOL* pfSupportAnimation)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, BOOL*, int>)(lpVtbl[18]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pfSupportAnimation);
    }

    /// <inheritdoc cref="IWICBitmapCodecInfo.DoesSupportChromakey" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT DoesSupportChromakey(BOOL* pfSupportChromakey)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, BOOL*, int>)(lpVtbl[19]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pfSupportChromakey);
    }

    /// <inheritdoc cref="IWICBitmapCodecInfo.DoesSupportLossless" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT DoesSupportLossless(BOOL* pfSupportLossless)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, BOOL*, int>)(lpVtbl[20]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pfSupportLossless);
    }

    /// <inheritdoc cref="IWICBitmapCodecInfo.DoesSupportMultiframe" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT DoesSupportMultiframe(BOOL* pfSupportMultiframe)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, BOOL*, int>)(lpVtbl[21]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pfSupportMultiframe);
    }

    /// <inheritdoc cref="IWICBitmapCodecInfo.MatchesMimeType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT MatchesMimeType([NativeTypeName("LPCWSTR")] char* wzMimeType, BOOL* pfMatches)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, char*, BOOL*, int>)(lpVtbl[22]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), wzMimeType, pfMatches);
    }

    /// <include file='IWICBitmapDecoderInfo.xml' path='doc/member[@name="IWICBitmapDecoderInfo.GetPatterns"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetPatterns(uint cbSizePatterns, WICBitmapPattern* pPatterns, uint* pcPatterns, uint* pcbPatternsActual)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, uint, WICBitmapPattern*, uint*, uint*, int>)(lpVtbl[23]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), cbSizePatterns, pPatterns, pcPatterns, pcbPatternsActual);
    }

    /// <include file='IWICBitmapDecoderInfo.xml' path='doc/member[@name="IWICBitmapDecoderInfo.MatchesPattern"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT MatchesPattern(IStream* pIStream, BOOL* pfMatches)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, IStream*, BOOL*, int>)(lpVtbl[24]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), pIStream, pfMatches);
    }

    /// <include file='IWICBitmapDecoderInfo.xml' path='doc/member[@name="IWICBitmapDecoderInfo.CreateInstance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT CreateInstance(IWICBitmapDecoder** ppIBitmapDecoder)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICBitmapDecoderInfo*, IWICBitmapDecoder**, int>)(lpVtbl[25]))((IWICBitmapDecoderInfo*)Unsafe.AsPointer(ref this), ppIBitmapDecoder);
    }

    public interface Interface : IWICBitmapCodecInfo.Interface
    {
        [VtblIndex(23)]
        HRESULT GetPatterns(uint cbSizePatterns, WICBitmapPattern* pPatterns, uint* pcPatterns, uint* pcbPatternsActual);

        [VtblIndex(24)]
        HRESULT MatchesPattern(IStream* pIStream, BOOL* pfMatches);

        [VtblIndex(25)]
        HRESULT CreateInstance(IWICBitmapDecoder** ppIBitmapDecoder);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (WICComponentType *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, WICComponentType*, int> GetComponentType;

        [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetCLSID;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> GetSigningStatus;

        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetAuthor;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetVendorGUID;

        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetVersion;

        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetSpecVersion;

        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetFriendlyName;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, int> GetContainerFormat;

        [NativeTypeName("HRESULT (UINT, GUID *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, Guid*, uint*, int> GetPixelFormats;

        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetColorManagementVersion;

        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetDeviceManufacturer;

        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetDeviceModels;

        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetMimeTypes;

        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, uint*, int> GetFileExtensions;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> DoesSupportAnimation;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> DoesSupportChromakey;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> DoesSupportLossless;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL*, int> DoesSupportMultiframe;

        [NativeTypeName("HRESULT (LPCWSTR, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, BOOL*, int> MatchesMimeType;

        [NativeTypeName("HRESULT (UINT, WICBitmapPattern *, UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, WICBitmapPattern*, uint*, uint*, int> GetPatterns;

        [NativeTypeName("HRESULT (IStream *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, BOOL*, int> MatchesPattern;

        [NativeTypeName("HRESULT (IWICBitmapDecoder **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWICBitmapDecoder**, int> CreateInstance;
    }
}
