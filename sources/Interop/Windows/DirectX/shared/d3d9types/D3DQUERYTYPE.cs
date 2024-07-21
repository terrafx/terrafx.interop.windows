// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE"]/*' />
public enum D3DQUERYTYPE
{
    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_VCACHE"]/*' />
    D3DQUERYTYPE_VCACHE = 4,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_RESOURCEMANAGER"]/*' />
    D3DQUERYTYPE_RESOURCEMANAGER = 5,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_VERTEXSTATS"]/*' />
    D3DQUERYTYPE_VERTEXSTATS = 6,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_EVENT"]/*' />
    D3DQUERYTYPE_EVENT = 8,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_OCCLUSION"]/*' />
    D3DQUERYTYPE_OCCLUSION = 9,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_TIMESTAMP"]/*' />
    D3DQUERYTYPE_TIMESTAMP = 10,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_TIMESTAMPDISJOINT"]/*' />
    D3DQUERYTYPE_TIMESTAMPDISJOINT = 11,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_TIMESTAMPFREQ"]/*' />
    D3DQUERYTYPE_TIMESTAMPFREQ = 12,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_PIPELINETIMINGS"]/*' />
    D3DQUERYTYPE_PIPELINETIMINGS = 13,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_INTERFACETIMINGS"]/*' />
    D3DQUERYTYPE_INTERFACETIMINGS = 14,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_VERTEXTIMINGS"]/*' />
    D3DQUERYTYPE_VERTEXTIMINGS = 15,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_PIXELTIMINGS"]/*' />
    D3DQUERYTYPE_PIXELTIMINGS = 16,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_BANDWIDTHTIMINGS"]/*' />
    D3DQUERYTYPE_BANDWIDTHTIMINGS = 17,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_CACHEUTILIZATION"]/*' />
    D3DQUERYTYPE_CACHEUTILIZATION = 18,

    /// <include file='D3DQUERYTYPE.xml' path='doc/member[@name="D3DQUERYTYPE.D3DQUERYTYPE_MEMORYPRESSURE"]/*' />
    D3DQUERYTYPE_MEMORYPRESSURE = 19,
}
