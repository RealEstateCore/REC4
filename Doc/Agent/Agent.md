[Agent](#)
# Agent

The human, group, or machine that consumes or acts upon an object or data. This higher-level grouping allows properties that are shared among its subclasses (Person, Organization, ....) to be anchored in one joint place, on the Agent class.


**Display name:** Agent<br />
**DTMI:** dtmi:org:w3id:rec:Agent;1

---


## Child interfaces
* [Person](Person.md)
* [Organization](Organization/Organization.md)

---
## Relationships
|Name|Display name|Description|Multiplicity|Target|Properties|Writable|
|-|-|-|-|-|-|-|
|isMemberOf|**en**: is member of|**en**: Indicates membership in an organization. Note that componency (e.g., departments of a corporation) are expressed using the more generic Organization.isPartOf property.|0-Infinity|dtmi:org:w3id:rec:Organization;1||True|
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|customTags|**en**: Custom Tags||map (string->boolean)|True|
|externalIds|**en**: External IDs||map (string->string)|True|
|name|**en**: name||string|True|
## Target Of
### Direct
* Asset.commissionedBy
* Asset.installedBy
* Asset.manufacturedBy
* Asset.servicedBy
* Lease.leasee
* Lease.leasor
* Organization.hasMember
* ServiceObject.acknowledgedBy
* ServiceObject.closedBy
* ServiceObject.createdBy
* Architecture.architectedBy
* Architecture.constructedBy
* Architecture.operatedBy
* Architecture.ownedBy
