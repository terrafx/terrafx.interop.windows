// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='IMAGE_HOTSWAP_X64_ENDPOINT_INFO_CC_REG.xml' path='doc/member[@name="IMAGE_HOTSWAP_X64_ENDPOINT_INFO_CC_REG"]/*' />
public enum IMAGE_HOTSWAP_X64_ENDPOINT_INFO_CC_REG
{
    /// <include file='IMAGE_HOTSWAP_X64_ENDPOINT_INFO_CC_REG.xml' path='doc/member[@name="IMAGE_HOTSWAP_X64_ENDPOINT_INFO_CC_REG.EndpointParamRegNone"]/*' />
    EndpointParamRegNone = 0x00,

    /// <include file='IMAGE_HOTSWAP_X64_ENDPOINT_INFO_CC_REG.xml' path='doc/member[@name="IMAGE_HOTSWAP_X64_ENDPOINT_INFO_CC_REG.EndpointParamRegRAX"]/*' />
    EndpointParamRegRAX = 0x01,

    /// <include file='IMAGE_HOTSWAP_X64_ENDPOINT_INFO_CC_REG.xml' path='doc/member[@name="IMAGE_HOTSWAP_X64_ENDPOINT_INFO_CC_REG.EndpointParamRegRCX"]/*' />
    EndpointParamRegRCX = 0x02,

    /// <include file='IMAGE_HOTSWAP_X64_ENDPOINT_INFO_CC_REG.xml' path='doc/member[@name="IMAGE_HOTSWAP_X64_ENDPOINT_INFO_CC_REG.EndpointParamRegRDX"]/*' />
    EndpointParamRegRDX = 0x03,

    /// <include file='IMAGE_HOTSWAP_X64_ENDPOINT_INFO_CC_REG.xml' path='doc/member[@name="IMAGE_HOTSWAP_X64_ENDPOINT_INFO_CC_REG.EndpointParamRegR8"]/*' />
    EndpointParamRegR8 = 0x09,

    /// <include file='IMAGE_HOTSWAP_X64_ENDPOINT_INFO_CC_REG.xml' path='doc/member[@name="IMAGE_HOTSWAP_X64_ENDPOINT_INFO_CC_REG.EndpointParamRegR9"]/*' />
    EndpointParamRegR9 = 0x0A,

    /// <include file='IMAGE_HOTSWAP_X64_ENDPOINT_INFO_CC_REG.xml' path='doc/member[@name="IMAGE_HOTSWAP_X64_ENDPOINT_INFO_CC_REG.EndpointParamRegXMM0"]/*' />
    EndpointParamRegXMM0 = 0xC8,

    /// <include file='IMAGE_HOTSWAP_X64_ENDPOINT_INFO_CC_REG.xml' path='doc/member[@name="IMAGE_HOTSWAP_X64_ENDPOINT_INFO_CC_REG.EndpointParamRegXMM1"]/*' />
    EndpointParamRegXMM1 = 0xC9,

    /// <include file='IMAGE_HOTSWAP_X64_ENDPOINT_INFO_CC_REG.xml' path='doc/member[@name="IMAGE_HOTSWAP_X64_ENDPOINT_INFO_CC_REG.EndpointParamRegXMM2"]/*' />
    EndpointParamRegXMM2 = 0xCA,

    /// <include file='IMAGE_HOTSWAP_X64_ENDPOINT_INFO_CC_REG.xml' path='doc/member[@name="IMAGE_HOTSWAP_X64_ENDPOINT_INFO_CC_REG.EndpointParamRegXMM3"]/*' />
    EndpointParamRegXMM3 = 0xCB,
}
